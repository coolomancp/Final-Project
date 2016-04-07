<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattle
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
        Me.btnFlee = New System.Windows.Forms.Button()
        Me.pnlBattleMenu = New System.Windows.Forms.Panel()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.pcbBattleBG = New System.Windows.Forms.PictureBox()
        Me.pcbBattlePlayer = New System.Windows.Forms.PictureBox()
        Me.pcbBattleEnemy = New System.Windows.Forms.PictureBox()
        Me.pnlBattleMenu.SuspendLayout()
        CType(Me.pcbBattleBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBattlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBattleEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFlee
        '
        Me.btnFlee.Image = Global.WindowsApplication1.My.Resources.Resources.btnDefault
        Me.btnFlee.Location = New System.Drawing.Point(621, 133)
        Me.btnFlee.Name = "btnFlee"
        Me.btnFlee.Size = New System.Drawing.Size(75, 23)
        Me.btnFlee.TabIndex = 0
        Me.btnFlee.Text = "Flee"
        Me.btnFlee.UseVisualStyleBackColor = True
        '
        'pnlBattleMenu
        '
        Me.pnlBattleMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlBattleMenu.Controls.Add(Me.btnFlee)
        Me.pnlBattleMenu.Location = New System.Drawing.Point(13, 375)
        Me.pnlBattleMenu.Name = "pnlBattleMenu"
        Me.pnlBattleMenu.Size = New System.Drawing.Size(699, 159)
        Me.pnlBattleMenu.TabIndex = 1
        '
        'pcbBattleBG
        '
        Me.pcbBattleBG.BackColor = System.Drawing.Color.Transparent
        Me.pcbBattleBG.Location = New System.Drawing.Point(13, 12)
        Me.pcbBattleBG.Name = "pcbBattleBG"
        Me.pcbBattleBG.Size = New System.Drawing.Size(699, 357)
        Me.pcbBattleBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBattleBG.TabIndex = 2
        Me.pcbBattleBG.TabStop = False
        '
        'pcbBattlePlayer
        '
        Me.pcbBattlePlayer.Image = Global.WindowsApplication1.My.Resources.Resources.rogIdleR
        Me.pcbBattlePlayer.Location = New System.Drawing.Point(13, 246)
        Me.pcbBattlePlayer.Name = "pcbBattlePlayer"
        Me.pcbBattlePlayer.Size = New System.Drawing.Size(133, 123)
        Me.pcbBattlePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBattlePlayer.TabIndex = 3
        Me.pcbBattlePlayer.TabStop = False
        '
        'pcbBattleEnemy
        '
        Me.pcbBattleEnemy.Image = Global.WindowsApplication1.My.Resources.Resources.gobIdleL
        Me.pcbBattleEnemy.Location = New System.Drawing.Point(576, 246)
        Me.pcbBattleEnemy.Name = "pcbBattleEnemy"
        Me.pcbBattleEnemy.Size = New System.Drawing.Size(133, 123)
        Me.pcbBattleEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBattleEnemy.TabIndex = 4
        Me.pcbBattleEnemy.TabStop = False
        '
        'frmBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.pcbBattleEnemy)
        Me.Controls.Add(Me.pcbBattlePlayer)
        Me.Controls.Add(Me.pcbBattleBG)
        Me.Controls.Add(Me.pnlBattleMenu)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 584)
        Me.Name = "frmBattle"
        Me.Text = "Battle"
        Me.pnlBattleMenu.ResumeLayout(False)
        CType(Me.pcbBattleBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBattlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBattleEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFlee As System.Windows.Forms.Button
    Friend WithEvents pnlBattleMenu As System.Windows.Forms.Panel
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents pcbBattleBG As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBattlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBattleEnemy As System.Windows.Forms.PictureBox
End Class
