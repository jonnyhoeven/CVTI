<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TouchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TouchForm))
        Me.TabImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.VTKilltimer = New System.Windows.Forms.Timer(Me.components)
        Me.ZoomInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ZoomOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StopVideoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DomeHelpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VTTopFormTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CloseTab = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.ArTab = New System.Windows.Forms.TabPage
        Me.ArSplit = New System.Windows.Forms.SplitContainer
        Me.ArLPanel = New System.Windows.Forms.Panel
        Me.ArLBrowser = New System.Windows.Forms.WebBrowser
        Me.Label3 = New System.Windows.Forms.Label
        Me.ArRPanel = New System.Windows.Forms.Panel
        Me.ArRBrowser = New System.Windows.Forms.WebBrowser
        Me.Label4 = New System.Windows.Forms.Label
        Me.LightTab = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.DomeTab = New System.Windows.Forms.TabPage
        Me.DomePanel = New System.Windows.Forms.Panel
        Me.DomeBrowser = New System.Windows.Forms.WebBrowser
        Me.MainTabControl = New System.Windows.Forms.TabControl
        Me.DocTab = New System.Windows.Forms.TabPage
        Me.DocWebBrowser = New System.Windows.Forms.WebBrowser
        Me.CleanScreenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DomeInfoCloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ZoomInButton = New System.Windows.Forms.Button
        Me.ZoomOutButton = New System.Windows.Forms.Button
        Me.LuikenButton = New System.Windows.Forms.Button
        Me.WerkButton = New System.Windows.Forms.Button
        Me.ConcertButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.RestartButton = New System.Windows.Forms.Button
        Me.RestartCameraButton = New System.Windows.Forms.Button
        Me.FullscreenButton = New System.Windows.Forms.Button
        Me.ServerRestartButton = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.CloseTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ArTab.SuspendLayout()
        Me.ArSplit.Panel1.SuspendLayout()
        Me.ArSplit.Panel2.SuspendLayout()
        Me.ArSplit.SuspendLayout()
        Me.ArLPanel.SuspendLayout()
        Me.ArRPanel.SuspendLayout()
        Me.LightTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.DomeTab.SuspendLayout()
        Me.DomePanel.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.DocTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabImageList
        '
        Me.TabImageList.ImageStream = CType(resources.GetObject("TabImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TabImageList.TransparentColor = System.Drawing.Color.White
        Me.TabImageList.Images.SetKeyName(0, "dome.png")
        Me.TabImageList.Images.SetKeyName(1, "verl.png")
        Me.TabImageList.Images.SetKeyName(2, "arcam.png")
        Me.TabImageList.Images.SetKeyName(3, "manage.png")
        Me.TabImageList.Images.SetKeyName(4, "help.png")
        '
        'Button6
        '
        Me.Button6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(86, 135)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 60)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Button1"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Location = New System.Drawing.Point(169, 135)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(77, 60)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Button2"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Location = New System.Drawing.Point(252, 135)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 60)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Button3"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'VTKilltimer
        '
        Me.VTKilltimer.Interval = 900000
        '
        'ZoomInTimer
        '
        Me.ZoomInTimer.Interval = 300
        '
        'ZoomOutTimer
        '
        Me.ZoomOutTimer.Interval = 300
        '
        'StopVideoTimer
        '
        Me.StopVideoTimer.Interval = 10800000
        '
        'DomeHelpTimer
        '
        Me.DomeHelpTimer.Interval = 20000
        '
        'VTTopFormTimer
        '
        Me.VTTopFormTimer.Interval = 2000
        '
        'CloseTab
        '
        Me.CloseTab.BackColor = System.Drawing.Color.Black
        Me.CloseTab.Controls.Add(Me.TableLayoutPanel2)
        Me.CloseTab.ImageIndex = 3
        Me.CloseTab.Location = New System.Drawing.Point(4, 59)
        Me.CloseTab.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseTab.Name = "CloseTab"
        Me.CloseTab.Size = New System.Drawing.Size(882, 403)
        Me.CloseTab.TabIndex = 4
        Me.CloseTab.Text = "Beheer"
        Me.CloseTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CloseButton, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RestartButton, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RestartCameraButton, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FullscreenButton, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ServerRestartButton, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Button10, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(882, 403)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ArTab
        '
        Me.ArTab.BackColor = System.Drawing.Color.Black
        Me.ArTab.Controls.Add(Me.ArSplit)
        Me.ArTab.ImageIndex = 2
        Me.ArTab.Location = New System.Drawing.Point(4, 59)
        Me.ArTab.Margin = New System.Windows.Forms.Padding(0)
        Me.ArTab.Name = "ArTab"
        Me.ArTab.Size = New System.Drawing.Size(882, 403)
        Me.ArTab.TabIndex = 2
        Me.ArTab.Text = "Skybox"
        Me.ArTab.UseVisualStyleBackColor = True
        '
        'ArSplit
        '
        Me.ArSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArSplit.Location = New System.Drawing.Point(0, 0)
        Me.ArSplit.Name = "ArSplit"
        '
        'ArSplit.Panel1
        '
        Me.ArSplit.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.ArSplit.Panel1.Controls.Add(Me.ArLPanel)
        Me.ArSplit.Panel1.Controls.Add(Me.Label3)
        '
        'ArSplit.Panel2
        '
        Me.ArSplit.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.ArSplit.Panel2.Controls.Add(Me.ArRPanel)
        Me.ArSplit.Panel2.Controls.Add(Me.Label4)
        Me.ArSplit.Size = New System.Drawing.Size(882, 403)
        Me.ArSplit.SplitterDistance = 435
        Me.ArSplit.SplitterWidth = 2
        Me.ArSplit.TabIndex = 0
        '
        'ArLPanel
        '
        Me.ArLPanel.BackColor = System.Drawing.Color.Transparent
        Me.ArLPanel.Controls.Add(Me.ArLBrowser)
        Me.ArLPanel.Location = New System.Drawing.Point(21, 91)
        Me.ArLPanel.Name = "ArLPanel"
        Me.ArLPanel.Size = New System.Drawing.Size(200, 100)
        Me.ArLPanel.TabIndex = 4
        '
        'ArLBrowser
        '
        Me.ArLBrowser.Location = New System.Drawing.Point(-172, -49)
        Me.ArLBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ArLBrowser.Name = "ArLBrowser"
        Me.ArLBrowser.Size = New System.Drawing.Size(331, 134)
        Me.ArLBrowser.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 20, 20, 0)
        Me.Label3.Size = New System.Drawing.Size(435, 403)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Links (vanuit de zaal gezien)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ArRPanel
        '
        Me.ArRPanel.BackColor = System.Drawing.Color.Transparent
        Me.ArRPanel.Controls.Add(Me.ArRBrowser)
        Me.ArRPanel.Location = New System.Drawing.Point(38, 94)
        Me.ArRPanel.Name = "ArRPanel"
        Me.ArRPanel.Size = New System.Drawing.Size(200, 100)
        Me.ArRPanel.TabIndex = 4
        '
        'ArRBrowser
        '
        Me.ArRBrowser.Location = New System.Drawing.Point(-172, -49)
        Me.ArRBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ArRBrowser.Name = "ArRBrowser"
        Me.ArRBrowser.Size = New System.Drawing.Size(319, 131)
        Me.ArRBrowser.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(20)
        Me.Label4.Size = New System.Drawing.Size(445, 403)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rechts (vanuit de zaal gezien)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LightTab
        '
        Me.LightTab.BackColor = System.Drawing.Color.Black
        Me.LightTab.Controls.Add(Me.TableLayoutPanel1)
        Me.LightTab.ImageIndex = 1
        Me.LightTab.Location = New System.Drawing.Point(4, 59)
        Me.LightTab.Margin = New System.Windows.Forms.Padding(0)
        Me.LightTab.Name = "LightTab"
        Me.LightTab.Size = New System.Drawing.Size(882, 403)
        Me.LightTab.TabIndex = 3
        Me.LightTab.Text = "Verlichting"
        Me.LightTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LuikenButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.WerkButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ConcertButton, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(882, 403)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DomeTab
        '
        Me.DomeTab.BackColor = System.Drawing.Color.Black
        Me.DomeTab.Controls.Add(Me.Button16)
        Me.DomeTab.Controls.Add(Me.Button15)
        Me.DomeTab.Controls.Add(Me.Button14)
        Me.DomeTab.Controls.Add(Me.Button13)
        Me.DomeTab.Controls.Add(Me.Button9)
        Me.DomeTab.Controls.Add(Me.Button5)
        Me.DomeTab.Controls.Add(Me.Button3)
        Me.DomeTab.Controls.Add(Me.Button4)
        Me.DomeTab.Controls.Add(Me.Button2)
        Me.DomeTab.Controls.Add(Me.Button1)
        Me.DomeTab.Controls.Add(Me.ZoomInButton)
        Me.DomeTab.Controls.Add(Me.ZoomOutButton)
        Me.DomeTab.Controls.Add(Me.DomePanel)
        Me.DomeTab.ImageIndex = 0
        Me.DomeTab.Location = New System.Drawing.Point(4, 59)
        Me.DomeTab.Margin = New System.Windows.Forms.Padding(0)
        Me.DomeTab.Name = "DomeTab"
        Me.DomeTab.Size = New System.Drawing.Size(882, 403)
        Me.DomeTab.TabIndex = 1
        Me.DomeTab.Text = "Zaal Camera"
        Me.DomeTab.UseVisualStyleBackColor = True
        '
        'DomePanel
        '
        Me.DomePanel.BackColor = System.Drawing.Color.Transparent
        Me.DomePanel.Controls.Add(Me.DomeBrowser)
        Me.DomePanel.Location = New System.Drawing.Point(8, 20)
        Me.DomePanel.Name = "DomePanel"
        Me.DomePanel.Size = New System.Drawing.Size(200, 100)
        Me.DomePanel.TabIndex = 3
        '
        'DomeBrowser
        '
        Me.DomeBrowser.Location = New System.Drawing.Point(-1, -53)
        Me.DomeBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.DomeBrowser.Name = "DomeBrowser"
        Me.DomeBrowser.Size = New System.Drawing.Size(160, 109)
        Me.DomeBrowser.TabIndex = 0
        '
        'MainTabControl
        '
        Me.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MainTabControl.Controls.Add(Me.DomeTab)
        Me.MainTabControl.Controls.Add(Me.LightTab)
        Me.MainTabControl.Controls.Add(Me.ArTab)
        Me.MainTabControl.Controls.Add(Me.CloseTab)
        Me.MainTabControl.Controls.Add(Me.DocTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.MainTabControl.ImageList = Me.TabImageList
        Me.MainTabControl.ItemSize = New System.Drawing.Size(150, 55)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.Padding = New System.Drawing.Point(0, 0)
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(890, 466)
        Me.MainTabControl.TabIndex = 0
        '
        'DocTab
        '
        Me.DocTab.Controls.Add(Me.Button12)
        Me.DocTab.Controls.Add(Me.Button11)
        Me.DocTab.Controls.Add(Me.DocWebBrowser)
        Me.DocTab.ImageIndex = 4
        Me.DocTab.Location = New System.Drawing.Point(4, 59)
        Me.DocTab.Name = "DocTab"
        Me.DocTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DocTab.Size = New System.Drawing.Size(882, 403)
        Me.DocTab.TabIndex = 5
        Me.DocTab.Text = "Help"
        Me.DocTab.UseVisualStyleBackColor = True
        '
        'DocWebBrowser
        '
        Me.DocWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocWebBrowser.Location = New System.Drawing.Point(3, 3)
        Me.DocWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.DocWebBrowser.Name = "DocWebBrowser"
        Me.DocWebBrowser.Size = New System.Drawing.Size(876, 397)
        Me.DocWebBrowser.TabIndex = 0
        '
        'CleanScreenTimer
        '
        Me.CleanScreenTimer.Interval = 60000
        '
        'DomeInfoCloseTimer
        '
        Me.DomeInfoCloseTimer.Interval = 10000
        '
        'Button16
        '
        Me.Button16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button16.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button16.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tribune
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(808, 313)
        Me.Button16.Margin = New System.Windows.Forms.Padding(0)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(60, 43)
        Me.Button16.TabIndex = 14
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button15.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.parterre
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(808, 270)
        Me.Button15.Margin = New System.Windows.Forms.Padding(0)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(60, 43)
        Me.Button15.TabIndex = 13
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.plafond
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(808, 355)
        Me.Button14.Margin = New System.Windows.Forms.Padding(0)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(60, 43)
        Me.Button14.TabIndex = 12
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button13.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.podium
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(808, 227)
        Me.Button13.Margin = New System.Windows.Forms.Padding(0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(60, 43)
        Me.Button13.TabIndex = 11
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.WindowsApplication1.My.Resources.Resources.brightauto1
        Me.Button9.Location = New System.Drawing.Point(68, 274)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 62)
        Me.Button9.TabIndex = 10
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.focusauto1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(8, 274)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 62)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.brightmin1
        Me.Button3.Location = New System.Drawing.Point(68, 336)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 62)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.brightplus1
        Me.Button4.Location = New System.Drawing.Point(68, 212)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 62)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.focusmin1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 336)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 62)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.focusplus1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 212)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 62)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ZoomInButton
        '
        Me.ZoomInButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomInButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ZoomInButton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.zoomin1
        Me.ZoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ZoomInButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoomInButton.Location = New System.Drawing.Point(808, 58)
        Me.ZoomInButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ZoomInButton.Name = "ZoomInButton"
        Me.ZoomInButton.Size = New System.Drawing.Size(60, 62)
        Me.ZoomInButton.TabIndex = 1
        Me.ZoomInButton.UseVisualStyleBackColor = True
        '
        'ZoomOutButton
        '
        Me.ZoomOutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomOutButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ZoomOutButton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.zoomout1
        Me.ZoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ZoomOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoomOutButton.Location = New System.Drawing.Point(808, 120)
        Me.ZoomOutButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ZoomOutButton.Name = "ZoomOutButton"
        Me.ZoomOutButton.Size = New System.Drawing.Size(60, 62)
        Me.ZoomOutButton.TabIndex = 0
        Me.ZoomOutButton.UseVisualStyleBackColor = True
        '
        'LuikenButton
        '
        Me.LuikenButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LuikenButton.BackColor = System.Drawing.SystemColors.Control
        Me.LuikenButton.Image = Global.WindowsApplication1.My.Resources.Resources.td
        Me.LuikenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LuikenButton.Location = New System.Drawing.Point(47, 164)
        Me.LuikenButton.Name = "LuikenButton"
        Me.LuikenButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LuikenButton.Size = New System.Drawing.Size(258, 74)
        Me.LuikenButton.TabIndex = 0
        Me.LuikenButton.Text = "&Technische Bediening"
        Me.LuikenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LuikenButton.UseVisualStyleBackColor = True
        '
        'WerkButton
        '
        Me.WerkButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WerkButton.BackColor = System.Drawing.SystemColors.Control
        Me.WerkButton.Image = CType(resources.GetObject("WerkButton.Image"), System.Drawing.Image)
        Me.WerkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WerkButton.Location = New System.Drawing.Point(311, 164)
        Me.WerkButton.Name = "WerkButton"
        Me.WerkButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.WerkButton.Size = New System.Drawing.Size(258, 74)
        Me.WerkButton.TabIndex = 2
        Me.WerkButton.Text = "&Zaal Verlichting"
        Me.WerkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.WerkButton.UseVisualStyleBackColor = True
        '
        'ConcertButton
        '
        Me.ConcertButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConcertButton.BackColor = System.Drawing.SystemColors.Control
        Me.ConcertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ConcertButton.Image = Global.WindowsApplication1.My.Resources.Resources.rpho
        Me.ConcertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConcertButton.Location = New System.Drawing.Point(575, 164)
        Me.ConcertButton.Name = "ConcertButton"
        Me.ConcertButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ConcertButton.Size = New System.Drawing.Size(258, 74)
        Me.ConcertButton.TabIndex = 1
        Me.ConcertButton.Text = "&Repetitie && B.L.V.D."
        Me.ConcertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ConcertButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.SystemColors.Control
        Me.CloseButton.Image = Global.WindowsApplication1.My.Resources.Resources.close
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(572, 240)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CloseButton.Size = New System.Drawing.Size(264, 80)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "CVTI &Afsluiten"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RestartButton
        '
        Me.RestartButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestartButton.BackColor = System.Drawing.SystemColors.Control
        Me.RestartButton.Image = Global.WindowsApplication1.My.Resources.Resources.rebootlocal
        Me.RestartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RestartButton.Location = New System.Drawing.Point(44, 80)
        Me.RestartButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RestartButton.Size = New System.Drawing.Size(264, 80)
        Me.RestartButton.TabIndex = 1
        Me.RestartButton.Text = "Computer &Herstarten"
        Me.RestartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RestartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RestartButton.UseVisualStyleBackColor = True
        '
        'RestartCameraButton
        '
        Me.RestartCameraButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestartCameraButton.BackColor = System.Drawing.SystemColors.Control
        Me.RestartCameraButton.Image = Global.WindowsApplication1.My.Resources.Resources.rebootcamera
        Me.RestartCameraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RestartCameraButton.Location = New System.Drawing.Point(572, 80)
        Me.RestartCameraButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RestartCameraButton.Name = "RestartCameraButton"
        Me.RestartCameraButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RestartCameraButton.Size = New System.Drawing.Size(264, 80)
        Me.RestartCameraButton.TabIndex = 7
        Me.RestartCameraButton.Text = "&Camera Herstarten"
        Me.RestartCameraButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RestartCameraButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RestartCameraButton.UseVisualStyleBackColor = True
        '
        'FullscreenButton
        '
        Me.FullscreenButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullscreenButton.BackColor = System.Drawing.SystemColors.Control
        Me.FullscreenButton.Image = Global.WindowsApplication1.My.Resources.Resources.mini
        Me.FullscreenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FullscreenButton.Location = New System.Drawing.Point(44, 240)
        Me.FullscreenButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FullscreenButton.Name = "FullscreenButton"
        Me.FullscreenButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.FullscreenButton.Size = New System.Drawing.Size(264, 80)
        Me.FullscreenButton.TabIndex = 0
        Me.FullscreenButton.Text = "&Fullscreen Verlaten"
        Me.FullscreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FullscreenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FullscreenButton.UseVisualStyleBackColor = True
        '
        'ServerRestartButton
        '
        Me.ServerRestartButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerRestartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ServerRestartButton.Image = Global.WindowsApplication1.My.Resources.Resources.rebootserver
        Me.ServerRestartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ServerRestartButton.Location = New System.Drawing.Point(308, 240)
        Me.ServerRestartButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ServerRestartButton.Name = "ServerRestartButton"
        Me.ServerRestartButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ServerRestartButton.Size = New System.Drawing.Size(264, 80)
        Me.ServerRestartButton.TabIndex = 4
        Me.ServerRestartButton.Text = "&Server Herstarten"
        Me.ServerRestartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ServerRestartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ServerRestartButton.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Image = Global.WindowsApplication1.My.Resources.Resources.clean
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(308, 80)
        Me.Button10.Margin = New System.Windows.Forms.Padding(0)
        Me.Button10.Name = "Button10"
        Me.Button10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button10.Size = New System.Drawing.Size(264, 80)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Scherm Schoonmaken"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.Image = Global.WindowsApplication1.My.Resources.Resources.down1
        Me.Button12.Location = New System.Drawing.Point(815, 336)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(59, 59)
        Me.Button12.TabIndex = 2
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.Image = Global.WindowsApplication1.My.Resources.Resources.up1
        Me.Button11.Location = New System.Drawing.Point(815, 6)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(59, 59)
        Me.Button11.TabIndex = 1
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TouchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(890, 466)
        Me.Controls.Add(Me.MainTabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TouchForm"
        Me.Text = "Camera & Visual Touch Interface"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CloseTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ArTab.ResumeLayout(False)
        Me.ArSplit.Panel1.ResumeLayout(False)
        Me.ArSplit.Panel2.ResumeLayout(False)
        Me.ArSplit.ResumeLayout(False)
        Me.ArLPanel.ResumeLayout(False)
        Me.ArRPanel.ResumeLayout(False)
        Me.LightTab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.DomeTab.ResumeLayout(False)
        Me.DomePanel.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.DocTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents VTKilltimer As System.Windows.Forms.Timer
    Friend WithEvents ZoomInTimer As System.Windows.Forms.Timer
    Friend WithEvents ZoomOutTimer As System.Windows.Forms.Timer
    Friend WithEvents StopVideoTimer As System.Windows.Forms.Timer
    Friend WithEvents TabImageList As System.Windows.Forms.ImageList
    Friend WithEvents DomeHelpTimer As System.Windows.Forms.Timer
    Friend WithEvents VTTopFormTimer As System.Windows.Forms.Timer
    Friend WithEvents CloseTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RestartButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents FullscreenButton As System.Windows.Forms.Button
    Friend WithEvents ServerRestartButton As System.Windows.Forms.Button
    Friend WithEvents RestartCameraButton As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ArTab As System.Windows.Forms.TabPage
    Friend WithEvents ArSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents ArLPanel As System.Windows.Forms.Panel
    Friend WithEvents ArLBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ArRPanel As System.Windows.Forms.Panel
    Friend WithEvents ArRBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LightTab As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LuikenButton As System.Windows.Forms.Button
    Friend WithEvents WerkButton As System.Windows.Forms.Button
    Friend WithEvents ConcertButton As System.Windows.Forms.Button
    Friend WithEvents DomeTab As System.Windows.Forms.TabPage
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ZoomInButton As System.Windows.Forms.Button
    Friend WithEvents ZoomOutButton As System.Windows.Forms.Button
    Friend WithEvents DomePanel As System.Windows.Forms.Panel
    Friend WithEvents DomeBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents CleanScreenTimer As System.Windows.Forms.Timer
    Friend WithEvents DocTab As System.Windows.Forms.TabPage
    Friend WithEvents DocWebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents DomeInfoCloseTimer As System.Windows.Forms.Timer

End Class
