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


Public Class InputForm
    Public lastcode As Integer

    'Clear textbox and start autoclose timer
    Private Sub Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbox.Text = ""
        InpuformCloseTimer.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cbox.Text = cbox.Text & "5"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cbox.Text = cbox.Text & "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cbox.Text = cbox.Text & "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cbox.Text = cbox.Text & "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cbox.Text = cbox.Text & "4"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cbox.Text = cbox.Text & "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cbox.Text = cbox.Text & "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        cbox.Text = cbox.Text & "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        cbox.Text = cbox.Text & "9"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        cbox.Text = cbox.Text & "0"
    End Sub

    'backspace
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If cbox.Text.Length > 0 Then
            cbox.Text = cbox.Text.Remove(cbox.Text.Length - 1, 1)
        End If
    End Sub

    'Ok
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If IsNumeric(cbox.Text) Then
            lastcode = cbox.Text
        End If
        Me.Close()
    End Sub

    'cancel
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        lastcode = Nothing
        Me.Close()
    End Sub

    'check state and 
    Private Sub Input_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        InpuformCloseTimer.Stop()
        If IsNumeric(cbox.Text) Then
            lastcode = cbox.Text
        End If
    End Sub
    'Auto close form when inactive
    Private Sub InpuformCloseTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles InpuformCloseTimer.Tick
        Me.Close()
    End Sub

    'if input is enter/cr return
    Private Sub cbox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbox.KeyUp
        If e.KeyCode = 13 Then ' return key
            Me.Close()
        End If
    End Sub

End Class