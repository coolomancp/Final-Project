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
        Me.btnCharI = New System.Windows.Forms.Button()
        Me.btnInv = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picMainScr = New System.Windows.Forms.PictureBox()
        Me.timeIdle = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainScr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlMenu.Controls.Add(Me.btnCharI)
        Me.pnlMenu.Controls.Add(Me.btnInv)
        Me.pnlMenu.Location = New System.Drawing.Point(12, 433)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(700, 100)
        Me.pnlMenu.TabIndex = 0
        '
        'btnCharI
        '
        Me.btnCharI.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharI.Location = New System.Drawing.Point(605, 23)
        Me.btnCharI.Name = "btnCharI"
        Me.btnCharI.Size = New System.Drawing.Size(92, 34)
        Me.btnCharI.TabIndex = 1
        Me.btnCharI.Text = "Char Info"
        Me.btnCharI.UseVisualStyleBackColor = True
        '
        'btnInv
        '
        Me.btnInv.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv.Location = New System.Drawing.Point(605, 63)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(92, 34)
        Me.btnInv.TabIndex = 0
        Me.btnInv.Text = "Inventory"
        Me.btnInv.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.picPlayer)
        Me.pnlMain.Controls.Add(Me.picMainScr)
        Me.pnlMain.Location = New System.Drawing.Point(13, 12)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(699, 415)
        Me.pnlMain.TabIndex = 3
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(640, 330)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(56, 67)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 2
        Me.picPlayer.TabStop = False
        '
        'picMainScr
        '
        Me.picMainScr.Image = Global.WindowsApplication1.My.Resources.Resources.shstagewaterfall084slow1
        Me.picMainScr.Location = New System.Drawing.Point(-1, 1)
        Me.picMainScr.Name = "picMainScr"
        Me.picMainScr.Size = New System.Drawing.Size(699, 415)
        Me.picMainScr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMainScr.TabIndex = 1
        Me.picMainScr.TabStop = False
        '
        'timeIdle
        '
        Me.timeIdle.Enabled = True
        Me.timeIdle.Interval = 1000
        '
        'frmMainScr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(724, 545)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 584)
        Me.Name = "frmMainScr"
        Me.Text = "Main Screen"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainScr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnCharI As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents picMainScr As PictureBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents timeIdle As Timer
End Class
