'    Touchscreen frontend interface for ip camera, mechanical systems and lighting
'    Copyright (C) 2007 Jonny van der Hoeven

'    This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.

'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.

'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports System.IO
Public Class TouchForm
    Const appfilename As String = "pathto/visual touch executable.exe" 'path to visual touch

    Dim mylastprocs() As Process        'Needed to see if app needs to be killed
    Dim WithEvents netproc As Process   'Use Netproc to get admin access on server
    Dim netproccount As Integer         'Counter for retry when network is unstable

    'Setup form and updatepanels
    Private Sub TouchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For Each tp As TabPage In Me.MainTabControl.TabPages
                tp.BackColor = Color.Black
            Next
            UpdatePanelState()
        Catch ex As Exception
            hndlerr(ex, "TouchForm Load")
        End Try
    End Sub

    'Error handling
    Private Sub hndlerr(ByVal ex As Exception, ByVal Source As String)
        MsgBox("Er is een fout opgetreden in: " & Source & vbCrLf & "Exception text: " & ex.Message & vbCrLf & " Exception source: " & ex.Source, MsgBoxStyle.Critical, "Foutmelding CVTI")
    End Sub

    'Form Close and cleanup
    Private Sub TouchForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            StopVideoTimer.Stop()
            VTKilltimer.Stop()
        Catch ex As Exception
            hndlerr(ex, "TouchForm Closing")
        End Try
        mylastprocs = Nothing
        netproc = Nothing
        netproccount = Nothing
    End Sub

    'Updates panels and set urls for browsers
    Sub UpdatePanelState()

        Try
            Select Case MainTabControl.SelectedIndex

                Case 0 'dome cam
                    'Scale video
                    If DomeTab.Width > DomeTab.Height Then
                        DomePanel.Height = DomeTab.Height
                        DomePanel.Width = (DomePanel.Height / 3) * 4
                    Else
                        DomePanel.Width = DomeTab.Width
                        DomePanel.Height = (DomePanel.Width / 4) * 3
                    End If

                    DomePanel.Left = (DomeTab.Width / 2) - (DomePanel.Width / 2)
                    DomePanel.Top = (DomeTab.Height / 2) - (DomePanel.Height / 2)

                    DomeBrowser.Width = DomePanel.Width + (DomeBrowser.Left * -1) + 20
                    DomeBrowser.Height = DomePanel.Height + (DomeBrowser.Top * -1) + 44 ' mpeg 4 is 44, mjpeg is 20

                    'Load URL and unset others
                    ArLBrowser.Url = New Uri("about:blank")
                    ArRBrowser.Url = New Uri("about:blank")
                    DocWebBrowser.Url = New Uri("about:blank")
                    DomeBrowser.Url = New Uri("http://192.168.10.100/ViewerFrame?Resolution=640x480&Quality=Clarity&Sound=disable&Mode=MPEG-4&RPeriod=0&SendMethod=2&View=Full")

                    'Set timer to return to main screen
                    StopVideoTimer.Start()


                Case 2 ' ar cam
                    'Scale video
                    ArSplit.SplitterDistance = (DomeTab.Width / 2)

                    ArLPanel.Width = 640
                    ArLPanel.Height = 480
                    ArLPanel.Left = ((DomeTab.Width - (DomeTab.Width / 2)) / 2) - (ArLPanel.Width / 2)
                    ArLPanel.Top = (DomeTab.Height / 2) - (ArLPanel.Height / 2)
                    ArLBrowser.Width = ArLPanel.Width + (ArLBrowser.Left * -1) + 20
                    ArLBrowser.Height = ArLPanel.Height + (ArLBrowser.Top * -1) + 20

                    ArRPanel.Width = 640
                    ArRPanel.Height = 480
                    ArRPanel.Left = ((DomeTab.Width - (DomeTab.Width / 2)) / 2) - (ArRPanel.Width / 2)
                    ArRPanel.Top = (DomeTab.Height / 2) - (ArRPanel.Height / 2)
                    ArRBrowser.Width = ArRPanel.Width + (ArRBrowser.Left * -1) + 20
                    ArRBrowser.Height = ArRPanel.Height + (ArRBrowser.Top * -1) + 20

                    'Load URL and unset others
                    DomeBrowser.Url = New Uri("about:blank")
                    DocWebBrowser.Url = New Uri("about:blank")
                    ArLBrowser.Url = New Uri("http://192.168.10.200/live/index.html")
                    ArRBrowser.Url = New Uri("http://192.168.10.201/live/index.html")

                    'Set timer to return to main screen
                    StopVideoTimer.Start()
                Case 3 'beheer
                    'unset all URL's
                    DocWebBrowser.Url = New Uri("about:blank")
                    DomeBrowser.Url = New Uri("about:blank")
                    ArLBrowser.Url = New Uri("about:blank")
                    ArRBrowser.Url = New Uri("about:blank")

                    StopVideoTimer.Stop()
                Case 4 'doc
                    DomeBrowser.Url = New Uri("about:blank")
                    ArLBrowser.Url = New Uri("about:blank")
                    ArRBrowser.Url = New Uri("about:blank")

                    DocWebBrowser.Url = New Uri(Application.StartupPath & "\doc\Documentatie CVTI.mht")

                    StopVideoTimer.Stop()
            End Select

        Catch ex As Exception
            hndlerr(ex, "UpdatePanelState")
        End Try
    End Sub

    'Tab selected
    Private Sub MainTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainTabControl.SelectedIndexChanged
        Try
            UpdatePanelState()
            VTKilltimer.Stop()
        Catch ex As Exception
            hndlerr(ex, "Tabcontrol selected index change")
        End Try
    End Sub

    'Start technical interface
    Private Sub LuikenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LuikenButton.Click
        Try
            If checkcode(0) Then
                startvt(0)
            End If
        Catch ex As Exception
            hndlerr(ex, "Luiken Click handler")
        End Try
    End Sub

    'Start Control software
    Sub startvt(ByVal vtset As Integer)
        Try
            Dim myproc As Process
            VTTopFormTimer.Stop()
            killvt()
            updatesettings(vtset)

            '  myproc = Process.Start(appfilename)

            If Not vtset = 0 Then VTKilltimer.Start() 'If not technical interface keep timer to close it

            LoadingForm.ShowDialog()
            VTTopFormTimer.Start()
        Catch ex As Exception
            hndlerr(ex, "Start Visual Touch")
        End Try
    End Sub

    'Changes files in visual touch to change backgrounds and other settings
    Sub updatesettings(ByVal vtset As Integer)
        Try
            Dim mysetfile As New FileInfo(Application.StartupPath & "\options" & vtset & ".txt")
            Dim vtdatadir As New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Visual Productions\VisualTouch\")

            If mysetfile.Exists Then
                mysetfile.CopyTo(vtdatadir.FullName & "options.xml", True)
            End If
        Catch ex As Exception
            hndlerr(ex, "Update visual touch settings file")
        End Try
    End Sub

    'Kill visualtouch
    Sub killvt()
        Try
            Dim myprocs() As Process = Process.GetProcessesByName("VisualTouch")
            Dim myproc As Process

            VTKilltimer.Stop()

            For Each myproc In myprocs
                myproc.CloseMainWindow()
            Next

            myprocs = Nothing
            myproc = Nothing

        Catch ex As Exception
            hndlerr(ex, "Kill visual touch")
        End Try
    End Sub

    'check code from inputform
    Function checkcode(ByVal code As Integer) As Boolean
        Try
            InputForm.ShowDialog()
            If InputForm.lastcode = code Then
                checkcode = True
            End If
        Catch ex As Exception
            hndlerr(ex, "Check codeinput")
        End Try
    End Function

    'close app
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Try
            If checkcode(0) Then
                Me.Close()
            End If
        Catch ex As Exception
            hndlerr(ex, "closebutton")
        End Try
    End Sub
    'go fullscreen
    Private Sub FullscreenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenButton.Click
        Try
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                If checkcode(0) Then
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    FullscreenButton.Text = "Activeer Fullscreen"
                End If
            Else
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Me.Size = My.Computer.Screen.Bounds.Size
                Me.WindowState = FormWindowState.Maximized
                FullscreenButton.Text = "Fullscreen Verlaten"
                UpdatePanelState()
            End If
        Catch ex As Exception
            hndlerr(ex, "Full screen toggler")
        End Try
    End Sub
    'on resize 
    Private Sub TouchForm_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Try
            UpdatePanelState()
        Catch ex As Exception
            hndlerr(ex, "Updatelayoutsize")
        End Try
    End Sub

    'start light interface concert
    Private Sub ConcertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConcertButton.Click
        Try
            If checkcode(0) Then
                startvt(1)
            End If
        Catch ex As Exception
            hndlerr(ex, "Concert button click handler")
        End Try
    End Sub

    'Start light interface simple
    Private Sub WerkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WerkButton.Click
        Try
            startvt(2)
        Catch ex As Exception
            hndlerr(ex, "werk button click handler")
        End Try
    End Sub

    'control dome camera presets
    Sub sendpresetcommand(ByVal mypresetid As Integer)
        Try
            Select Case mypresetid
                Case 0
                    ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=HomePosition")
                Case Else
                    ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=Preset&Data=" & mypresetid & "&PresetOperation=Move&Type=Preset")
            End Select
        Catch ex As Exception
            hndlerr(ex, "Change preset")
        End Try
    End Sub

    'restart local computer
    Private Sub RestartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartButton.Click
        Try
            If MsgBox("Weet u zeker dat u deze computer nu wilt herstarten?", MsgBoxStyle.YesNoCancel, "Computer Herstarten?") = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start("shutdown.exe", "-r -f -t 5")
            End If
        Catch ex As Exception
            hndlerr(ex, "Restart button handler")
        End Try
    End Sub

    'restart server
    Private Sub ServerRestartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerRestartButton.Click
        Try
            If checkcode(0) Then
                If MsgBox("Indien er geen andere lichttafel aktief is zal dit tot een blackout in de zaal leiden. Wilt u doorgaan?", MsgBoxStyle.YesNoCancel, "Server Herstarten?") = MsgBoxResult.Yes Then

                    NetprocServer()

                End If
            End If
        Catch ex As Exception
            hndlerr(ex, "Restart server button handler")
        End Try
    End Sub

    'use netproc to get netmon access on server
    Private Sub NetprocServer()
        Try
            netproc = System.Diagnostics.Process.Start("net.exe", "use \\master\ipc$ /user:user pwd")
            netproc.EnableRaisingEvents = True
        Catch ex As Exception
            hndlerr(ex, "server netproc")
        End Try
    End Sub

    'get netproc event exit
    Private Sub netproc_Exited(ByVal sender As Object, ByVal e As System.EventArgs) Handles netproc.Exited
        System.Diagnostics.Process.Start("shutdown.exe", "-r -f -t 5 -m \\MASTER")

        netproccount = netproccount + 1

        If netproccount < 5 And netproc.ExitCode <> 0 Then
            NetprocServer() ' Retry
        Else
            System.Diagnostics.Process.Start("shutdown.exe", "-r -f -t 5 -m \\MASTER")
            netproccount = 0
        End If


    End Sub

    'close lighting control after 15 minutes
    Private Sub VTKilltimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VTKilltimer.Tick
        VTKilltimer.Stop()
        killvt()
    End Sub

    'return to main tab when displaying video feed for 15 min
    Private Sub StopVideoTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopVideoTimer.Tick
        MainTabControl.SelectedIndex = 1
    End Sub

    'control dome camera zoom in
    Sub zoomin()
        Try
            ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=ZoomTele")
        Catch ex As Exception
            hndlerr(ex, "Zoomin url sender")
        End Try
    End Sub
    Private Sub ZoomInButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ZoomInButton.MouseDown
        Try
            zoomin()
            ZoomInTimer.Start()
        Catch ex As Exception
            hndlerr(ex, "Zoomin button handler")
        End Try
    End Sub
    Private Sub ZoomInTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomInTimer.Tick
        zoomin()
    End Sub
    Private Sub ZoomInButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ZoomInButton.MouseUp
        ZoomInTimer.Stop()
    End Sub

    'control dome camera zoom out
    Sub zoomout()
        Try
            ArRBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=ZoomWide")
        Catch ex As Exception
            hndlerr(ex, "Zoomout url sender")
        End Try
    End Sub
    Private Sub ZoomOutButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ZoomOutButton.MouseDown
        Try
            zoomout()
            ZoomOutTimer.Start()
        Catch ex As Exception
            hndlerr(ex, "Zoomout button handler")
        End Try

    End Sub
    Private Sub ZoomOutTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOutTimer.Tick
        zoomout()
    End Sub
    Private Sub ZoomOutButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ZoomOutButton.MouseUp
        ZoomOutTimer.Stop()
    End Sub

    'dome camera reset
    Private Sub RestartCameraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartCameraButton.Click
        ArLBrowser.Url = New Uri("http://192.168.10.100/nphRestart?PAGE=Restart&Restart=OK")
        MsgBox("Het commando om de Zaal Camera te herstarten is verzonden, het kan tot een minuut duren tot de camera weer aktief is.", MsgBoxStyle.Information, "Zaal Camera is opnieuw gestart.")
    End Sub

    'focus Near
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=FocusNear&Dist=1")
    End Sub

    'focus far
    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=FocusFar&Dist=1")
    End Sub

    'focus auto
    Private Sub Button5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseDown
        ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=FocusAuto")
    End Sub

    'Brightness increase
    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown

        ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=Brighter")
    End Sub

    'Brightness decrease
    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown

        ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=Darker")
    End Sub

    'Brightness auto
    Private Sub Button9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseDown
        ArLBrowser.Url = New Uri("http://192.168.10.100/nphControlCamera?Direction=DefaultBrightness")
    End Sub

    'disable input for screen cleaning
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MsgBox("Weet u zeker dat u de touch bediening van dit scherm tijdelijk uit wilt schakelen? Hierna kunt u gedurende 2 minuten geen bedieningen uitvoeren. Daardoor is het mogelijk dit scherm te reinigen.", MsgBoxStyle.YesNoCancel, "Scherm bediening uitschakelen voor schoonmaak?") = vbYes Then
            CleanScreenTimer.Start()
            MainTabControl.Enabled = False
        End If
    End Sub

    'enable input after screen cleaning
    Private Sub CleanScreenTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanScreenTimer.Tick
        CleanScreenTimer.Stop()
        MainTabControl.Enabled = True
    End Sub

    'scroll through documentation
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            DocWebBrowser.Document.Body.ScrollTop = DocWebBrowser.Document.Body.ScrollTop + 250
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            DocWebBrowser.Document.Body.ScrollTop = DocWebBrowser.Document.Body.ScrollTop - 250
        Catch ex As Exception

        End Try
    End Sub

    'set dome camera to presets
    Private Sub Button13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseDown
        sendpresetcommand(0)
    End Sub
    Private Sub Button14_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseDown
        sendpresetcommand(3)
    End Sub
    Private Sub Button15_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button15.MouseDown
        sendpresetcommand(2)
    End Sub
    Private Sub Button16_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button16.MouseDown
        sendpresetcommand(1)
    End Sub
    Private Sub Button17_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseDown
        sendpresetcommand(4)
    End Sub

End Class
