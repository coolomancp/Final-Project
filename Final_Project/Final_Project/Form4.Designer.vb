<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLaunchScr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaunchScr))
        Me.lblDemoNotice = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.lblTutorial = New System.Windows.Forms.Label()
        Me.lblTutorialTitle = New System.Windows.Forms.Label()
        Me.lblDemoNote = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDemoNotice
        '
        Me.lblDemoNotice.AutoSize = True
        Me.lblDemoNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblDemoNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDemoNotice.ForeColor = System.Drawing.Color.Red
        Me.lblDemoNotice.Location = New System.Drawing.Point(406, 265)
        Me.lblDemoNotice.Name = "lblDemoNotice"
        Me.lblDemoNotice.Size = New System.Drawing.Size(165, 24)
        Me.lblDemoNotice.TabIndex = 4
        Me.lblDemoNotice.Text = "-- Alpha Demo --"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(230, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(536, 284)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Location = New System.Drawing.Point(431, 385)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(140, 40)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Game"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(431, 441)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(140, 40)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New Game"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'picBackground
        '
        Me.picBackground.Image = Global.WindowsApplication1.My.Resources.Resources.TitleScreenN
        Me.picBackground.Location = New System.Drawing.Point(0, -2)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(1000, 534)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'btnTutorial
        '
        Me.btnTutorial.BackColor = System.Drawing.Color.Transparent
        Me.btnTutorial.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnDefault
        Me.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutorial.Location = New System.Drawing.Point(465, 495)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(75, 23)
        Me.btnTutorial.TabIndex = 5
        Me.btnTutorial.Text = "Tutorial"
        Me.btnTutorial.UseVisualStyleBackColor = False
        '
        'lblTutorial
        '
        Me.lblTutorial.BackColor = System.Drawing.Color.Transparent
        Me.lblTutorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutorial.Location = New System.Drawing.Point(0, 98)
        Me.lblTutorial.Name = "lblTutorial"
        Me.lblTutorial.Size = New System.Drawing.Size(1000, 166)
        Me.lblTutorial.TabIndex = 6
        Me.lblTutorial.Text = resources.GetString("lblTutorial.Text")
        Me.lblTutorial.Visible = False
        '
        'lblTutorialTitle
        '
        Me.lblTutorialTitle.AutoSize = True
        Me.lblTutorialTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutorialTitle.Location = New System.Drawing.Point(419, 12)
        Me.lblTutorialTitle.Name = "lblTutorialTitle"
        Me.lblTutorialTitle.Size = New System.Drawing.Size(125, 37)
        Me.lblTutorialTitle.TabIndex = 7
        Me.lblTutorialTitle.Text = "Tutorial"
        Me.lblTutorialTitle.Visible = False
        '
        'lblDemoNote
        '
        Me.lblDemoNote.AutoSize = True
        Me.lblDemoNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDemoNote.Location = New System.Drawing.Point(110, 338)
        Me.lblDemoNote.Name = "lblDemoNote"
        Me.lblDemoNote.Size = New System.Drawing.Size(758, 16)
        Me.lblDemoNote.TabIndex = 8
        Me.lblDemoNote.Text = "NOTE: This game is an Alpha Demo, so there will be Placeholders for missing asset" &
    "s and not all dungeons have been finished."
        Me.lblDemoNote.Visible = False
        '
        'frmLaunchScr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 529)
        Me.Controls.Add(Me.lblDemoNote)
        Me.Controls.Add(Me.lblTutorialTitle)
        Me.Controls.Add(Me.lblTutorial)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.lblDemoNotice)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.picBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1015, 568)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1015, 568)
        Me.Name = "frmLaunchScr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dungeon Crawler 2.0 [Demo]"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblDemoNotice As System.Windows.Forms.Label
    Friend WithEvents btnTutorial As System.Windows.Forms.Button
    Friend WithEvents lblTutorial As System.Windows.Forms.Label
    Friend WithEvents lblTutorialTitle As System.Windows.Forms.Label
    Friend WithEvents lblDemoNote As System.Windows.Forms.Label
End Class
