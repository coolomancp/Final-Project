<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScr))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.lblTest2 = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCharI = New System.Windows.Forms.Button()
        Me.btnInv = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblLevelUp = New System.Windows.Forms.Label()
        Me.pcbMonster23 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster24 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster22 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster21 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster13 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster14 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster12 = New System.Windows.Forms.PictureBox()
        Me.pcbMonster11 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer3 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer2 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer4 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer1 = New System.Windows.Forms.PictureBox()
        Me.pcbMainScr = New System.Windows.Forms.PictureBox()
        Me.tmrAnim = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMonst1Anim = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMonst2Anim = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLvlUpInvis = New System.Windows.Forms.Timer(Me.components)
        Me.tmrNxtRoom = New System.Windows.Forms.Timer(Me.components)
        Me.wmpAmbient = New AxWMPLib.AxWindowsMediaPlayer()
        Me.wmpMusic = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pnlMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.pcbMonster23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMonster11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMainScr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpAmbient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenu.Controls.Add(Me.lblTest2)
        Me.pnlMenu.Controls.Add(Me.lblTest)
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.btnCharI)
        Me.pnlMenu.Controls.Add(Me.btnInv)
        Me.pnlMenu.Location = New System.Drawing.Point(12, 433)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(700, 100)
        Me.pnlMenu.TabIndex = 0
        '
        'lblTest2
        '
        Me.lblTest2.AutoSize = True
        Me.lblTest2.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTest2.Location = New System.Drawing.Point(20, 44)
        Me.lblTest2.Name = "lblTest2"
        Me.lblTest2.Size = New System.Drawing.Size(39, 13)
        Me.lblTest2.TabIndex = 6
        Me.lblTest2.Text = "Label1"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTest.Location = New System.Drawing.Point(17, 27)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(42, 13)
        Me.lblTest.TabIndex = 5
        Me.lblTest.Text = "Testing"
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnDefault
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(605, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Game"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCharI
        '
        Me.btnCharI.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnChaIn
        Me.btnCharI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCharI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCharI.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharI.Location = New System.Drawing.Point(605, 27)
        Me.btnCharI.Name = "btnCharI"
        Me.btnCharI.Size = New System.Drawing.Size(92, 34)
        Me.btnCharI.TabIndex = 1
        Me.btnCharI.Text = "Char Info"
        Me.btnCharI.UseVisualStyleBackColor = True
        '
        'btnInv
        '
        Me.btnInv.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnInv.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnInv
        Me.btnInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInv.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv.Location = New System.Drawing.Point(605, 63)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(92, 34)
        Me.btnInv.TabIndex = 0
        Me.btnInv.Text = "Inventory"
        Me.btnInv.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlMain.Controls.Add(Me.lblLevelUp)
        Me.pnlMain.Controls.Add(Me.pcbMonster23)
        Me.pnlMain.Controls.Add(Me.pcbMonster24)
        Me.pnlMain.Controls.Add(Me.pcbMonster22)
        Me.pnlMain.Controls.Add(Me.pcbMonster21)
        Me.pnlMain.Controls.Add(Me.pcbMonster13)
        Me.pnlMain.Controls.Add(Me.pcbMonster14)
        Me.pnlMain.Controls.Add(Me.pcbMonster12)
        Me.pnlMain.Controls.Add(Me.pcbMonster11)
        Me.pnlMain.Controls.Add(Me.pcbPlayer3)
        Me.pnlMain.Controls.Add(Me.wmpAmbient)
        Me.pnlMain.Controls.Add(Me.wmpMusic)
        Me.pnlMain.Controls.Add(Me.pcbPlayer2)
        Me.pnlMain.Controls.Add(Me.pcbPlayer4)
        Me.pnlMain.Controls.Add(Me.pcbPlayer1)
        Me.pnlMain.Controls.Add(Me.pcbMainScr)
        Me.pnlMain.Location = New System.Drawing.Point(13, 12)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(703, 420)
        Me.pnlMain.TabIndex = 3
        '
        'lblLevelUp
        '
        Me.lblLevelUp.AutoSize = True
        Me.lblLevelUp.BackColor = System.Drawing.Color.Transparent
        Me.lblLevelUp.Font = New System.Drawing.Font("Monotxt", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelUp.ForeColor = System.Drawing.Color.Gold
        Me.lblLevelUp.Location = New System.Drawing.Point(209, 67)
        Me.lblLevelUp.Name = "lblLevelUp"
        Me.lblLevelUp.Size = New System.Drawing.Size(272, 47)
        Me.lblLevelUp.TabIndex = 58
        Me.lblLevelUp.Text = "LEVEL UP!"
        Me.lblLevelUp.Visible = False
        '
        'pcbMonster23
        '
        Me.pcbMonster23.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster23.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR3
        Me.pcbMonster23.Location = New System.Drawing.Point(438, 53)
        Me.pcbMonster23.Name = "pcbMonster23"
        Me.pcbMonster23.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster23.TabIndex = 14
        Me.pcbMonster23.TabStop = False
        Me.pcbMonster23.Visible = False
        '
        'pcbMonster24
        '
        Me.pcbMonster24.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster24.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR4
        Me.pcbMonster24.Location = New System.Drawing.Point(522, 24)
        Me.pcbMonster24.Name = "pcbMonster24"
        Me.pcbMonster24.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster24.TabIndex = 13
        Me.pcbMonster24.TabStop = False
        Me.pcbMonster24.Visible = False
        '
        'pcbMonster22
        '
        Me.pcbMonster22.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster22.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR2
        Me.pcbMonster22.Location = New System.Drawing.Point(509, 100)
        Me.pcbMonster22.Name = "pcbMonster22"
        Me.pcbMonster22.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster22.TabIndex = 12
        Me.pcbMonster22.TabStop = False
        Me.pcbMonster22.Visible = False
        '
        'pcbMonster21
        '
        Me.pcbMonster21.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster21.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR1
        Me.pcbMonster21.Location = New System.Drawing.Point(438, 134)
        Me.pcbMonster21.Name = "pcbMonster21"
        Me.pcbMonster21.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster21.TabIndex = 11
        Me.pcbMonster21.TabStop = False
        '
        'pcbMonster13
        '
        Me.pcbMonster13.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster13.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR3
        Me.pcbMonster13.Location = New System.Drawing.Point(483, 178)
        Me.pcbMonster13.Name = "pcbMonster13"
        Me.pcbMonster13.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster13.TabIndex = 10
        Me.pcbMonster13.TabStop = False
        Me.pcbMonster13.Visible = False
        '
        'pcbMonster14
        '
        Me.pcbMonster14.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster14.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR4
        Me.pcbMonster14.Location = New System.Drawing.Point(567, 149)
        Me.pcbMonster14.Name = "pcbMonster14"
        Me.pcbMonster14.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster14.TabIndex = 9
        Me.pcbMonster14.TabStop = False
        Me.pcbMonster14.Visible = False
        '
        'pcbMonster12
        '
        Me.pcbMonster12.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster12.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR2
        Me.pcbMonster12.Location = New System.Drawing.Point(554, 225)
        Me.pcbMonster12.Name = "pcbMonster12"
        Me.pcbMonster12.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster12.TabIndex = 8
        Me.pcbMonster12.TabStop = False
        Me.pcbMonster12.Visible = False
        '
        'pcbMonster11
        '
        Me.pcbMonster11.BackColor = System.Drawing.Color.Transparent
        Me.pcbMonster11.Image = Global.WindowsApplication1.My.Resources.Resources.gobWalkR1
        Me.pcbMonster11.Location = New System.Drawing.Point(483, 359)
        Me.pcbMonster11.Name = "pcbMonster11"
        Me.pcbMonster11.Size = New System.Drawing.Size(43, 40)
        Me.pcbMonster11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbMonster11.TabIndex = 7
        Me.pcbMonster11.TabStop = False
        '
        'pcbPlayer3
        '
        Me.pcbPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer3.Image = Global.WindowsApplication1.My.Resources.Resources.warAttR1
        Me.pcbPlayer3.Location = New System.Drawing.Point(106, 259)
        Me.pcbPlayer3.Name = "pcbPlayer3"
        Me.pcbPlayer3.Size = New System.Drawing.Size(104, 140)
        Me.pcbPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbPlayer3.TabIndex = 3
        Me.pcbPlayer3.TabStop = False
        Me.pcbPlayer3.Visible = False
        '
        'pcbPlayer2
        '
        Me.pcbPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer2.Image = Global.WindowsApplication1.My.Resources.Resources.rogAttR4
        Me.pcbPlayer2.Location = New System.Drawing.Point(216, 317)
        Me.pcbPlayer2.Name = "pcbPlayer2"
        Me.pcbPlayer2.Size = New System.Drawing.Size(107, 70)
        Me.pcbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbPlayer2.TabIndex = 5
        Me.pcbPlayer2.TabStop = False
        Me.pcbPlayer2.Visible = False
        '
        'pcbPlayer4
        '
        Me.pcbPlayer4.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer4.Image = Global.WindowsApplication1.My.Resources.Resources.rogAttR3
        Me.pcbPlayer4.Location = New System.Drawing.Point(152, 129)
        Me.pcbPlayer4.Name = "pcbPlayer4"
        Me.pcbPlayer4.Size = New System.Drawing.Size(107, 70)
        Me.pcbPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbPlayer4.TabIndex = 4
        Me.pcbPlayer4.TabStop = False
        Me.pcbPlayer4.Visible = False
        '
        'pcbPlayer1
        '
        Me.pcbPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer1.Image = Global.WindowsApplication1.My.Resources.Resources.rogIdleR
        Me.pcbPlayer1.Location = New System.Drawing.Point(365, 341)
        Me.pcbPlayer1.Name = "pcbPlayer1"
        Me.pcbPlayer1.Size = New System.Drawing.Size(72, 61)
        Me.pcbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbPlayer1.TabIndex = 2
        Me.pcbPlayer1.TabStop = False
        '
        'pcbMainScr
        '
        Me.pcbMainScr.Image = Global.WindowsApplication1.My.Resources.Resources.shstagewaterfall084slow1
        Me.pcbMainScr.Location = New System.Drawing.Point(2, 2)
        Me.pcbMainScr.Name = "pcbMainScr"
        Me.pcbMainScr.Size = New System.Drawing.Size(699, 415)
        Me.pcbMainScr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMainScr.TabIndex = 1
        Me.pcbMainScr.TabStop = False
        '
        'tmrAnim
        '
        Me.tmrAnim.Interval = 200
        '
        'tmrMonst1Anim
        '
        Me.tmrMonst1Anim.Enabled = True
        Me.tmrMonst1Anim.Interval = 200
        '
        'tmrMonst2Anim
        '
        '
        'tmrLvlUpInvis
        '
        Me.tmrLvlUpInvis.Interval = 3000
        '
        'tmrNxtRoom
        '
        Me.tmrNxtRoom.Interval = 300
        '
        'wmpAmbient
        '
        Me.wmpAmbient.Enabled = True
        Me.wmpAmbient.Location = New System.Drawing.Point(326, 140)
        Me.wmpAmbient.Name = "wmpAmbient"
        Me.wmpAmbient.OcxState = CType(resources.GetObject("wmpAmbient.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpAmbient.Size = New System.Drawing.Size(75, 23)
        Me.wmpAmbient.TabIndex = 6
        Me.wmpAmbient.Visible = False
        '
        'wmpMusic
        '
        Me.wmpMusic.Enabled = True
        Me.wmpMusic.Location = New System.Drawing.Point(326, 225)
        Me.wmpMusic.Name = "wmpMusic"
        Me.wmpMusic.OcxState = CType(resources.GetObject("wmpMusic.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpMusic.Size = New System.Drawing.Size(75, 23)
        Me.wmpMusic.TabIndex = 4
        Me.wmpMusic.Visible = False
        '
        'frmMainScr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rockyMenuBG
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(724, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 584)
        Me.Name = "frmMainScr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Screen"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.pcbMonster23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMonster11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMainScr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpAmbient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnCharI As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents pcbMainScr As PictureBox
    Friend WithEvents pcbPlayer1 As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents tmrAnim As Timer
    Friend WithEvents pcbPlayer2 As PictureBox
    Friend WithEvents pcbPlayer4 As PictureBox
    Friend WithEvents pcbPlayer3 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTest As Label
    Friend WithEvents wmpMusic As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wmpAmbient As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pcbMonster13 As PictureBox
    Friend WithEvents pcbMonster14 As PictureBox
    Friend WithEvents pcbMonster12 As PictureBox
    Friend WithEvents pcbMonster11 As PictureBox
    Friend WithEvents pcbMonster23 As PictureBox
    Friend WithEvents pcbMonster24 As PictureBox
    Friend WithEvents pcbMonster22 As PictureBox
    Friend WithEvents pcbMonster21 As PictureBox
    Friend WithEvents tmrMonst1Anim As Timer
    Friend WithEvents tmrMonst2Anim As System.Windows.Forms.Timer
    Friend WithEvents lblTest2 As System.Windows.Forms.Label
    Friend WithEvents lblLevelUp As System.Windows.Forms.Label
    Friend WithEvents tmrLvlUpInvis As System.Windows.Forms.Timer
    Friend WithEvents tmrNxtRoom As System.Windows.Forms.Timer
End Class
