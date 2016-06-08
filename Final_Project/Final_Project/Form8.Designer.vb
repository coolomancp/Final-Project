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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBattle))
        Me.pnlBattleMenu = New System.Windows.Forms.Panel()
        Me.btnMelee = New System.Windows.Forms.Button()
        Me.btnAbilities = New System.Windows.Forms.Button()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.proBarManaVal = New System.Windows.Forms.ProgressBar()
        Me.proBarHealthVal = New System.Windows.Forms.ProgressBar()
        Me.lblManaVal = New System.Windows.Forms.Label()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.lblHPVal = New System.Windows.Forms.Label()
        Me.lblCIHP = New System.Windows.Forms.Label()
        Me.btnFlee = New System.Windows.Forms.Button()
        Me.attackAnim = New System.Windows.Forms.Timer(Me.components)
        Me.playerHit = New System.Windows.Forms.Timer(Me.components)
        Me.proBarEnemyHP = New System.Windows.Forms.ProgressBar()
        Me.playerAttAnim = New System.Windows.Forms.Timer(Me.components)
        Me.deathAnim = New System.Windows.Forms.Timer(Me.components)
        Me.pcbBattleEnemy = New System.Windows.Forms.PictureBox()
        Me.pcbBattlePlayer = New System.Windows.Forms.PictureBox()
        Me.pcbBattleBG = New System.Windows.Forms.PictureBox()
        Me.lblEnemyHP = New System.Windows.Forms.Label()
        Me.lblEnemyDefeat = New System.Windows.Forms.Label()
        Me.lblExpAmount = New System.Windows.Forms.Label()
        Me.tmrTimeToHide = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBattleMenu.SuspendLayout()
        CType(Me.pcbBattleEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBattlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBattleBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBattleMenu
        '
        Me.pnlBattleMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlBattleMenu.Controls.Add(Me.btnMelee)
        Me.pnlBattleMenu.Controls.Add(Me.btnAbilities)
        Me.pnlBattleMenu.Controls.Add(Me.btnAttack)
        Me.pnlBattleMenu.Controls.Add(Me.btnItems)
        Me.pnlBattleMenu.Controls.Add(Me.proBarManaVal)
        Me.pnlBattleMenu.Controls.Add(Me.proBarHealthVal)
        Me.pnlBattleMenu.Controls.Add(Me.lblManaVal)
        Me.pnlBattleMenu.Controls.Add(Me.lblMana)
        Me.pnlBattleMenu.Controls.Add(Me.lblHPVal)
        Me.pnlBattleMenu.Controls.Add(Me.lblCIHP)
        Me.pnlBattleMenu.Controls.Add(Me.btnFlee)
        Me.pnlBattleMenu.Location = New System.Drawing.Point(13, 375)
        Me.pnlBattleMenu.Name = "pnlBattleMenu"
        Me.pnlBattleMenu.Size = New System.Drawing.Size(699, 159)
        Me.pnlBattleMenu.TabIndex = 1
        '
        'btnMelee
        '
        Me.btnMelee.BackColor = System.Drawing.Color.Firebrick
        Me.btnMelee.Location = New System.Drawing.Point(471, 66)
        Me.btnMelee.Name = "btnMelee"
        Me.btnMelee.Size = New System.Drawing.Size(91, 29)
        Me.btnMelee.TabIndex = 53
        Me.btnMelee.Text = "Melee"
        Me.btnMelee.UseVisualStyleBackColor = False
        Me.btnMelee.Visible = False
        '
        'btnAbilities
        '
        Me.btnAbilities.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbilities.Location = New System.Drawing.Point(471, 34)
        Me.btnAbilities.Name = "btnAbilities"
        Me.btnAbilities.Size = New System.Drawing.Size(91, 29)
        Me.btnAbilities.TabIndex = 52
        Me.btnAbilities.Text = "Abilities"
        Me.btnAbilities.UseVisualStyleBackColor = False
        Me.btnAbilities.Visible = False
        '
        'btnAttack
        '
        Me.btnAttack.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnAttack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnChaIn
        Me.btnAttack.Image = Global.WindowsApplication1.My.Resources.Resources.btnChaIn
        Me.btnAttack.Location = New System.Drawing.Point(595, 34)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(101, 35)
        Me.btnAttack.TabIndex = 51
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnInv
        Me.btnItems.Image = Global.WindowsApplication1.My.Resources.Resources.btnInv
        Me.btnItems.Location = New System.Drawing.Point(595, 75)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(101, 35)
        Me.btnItems.TabIndex = 50
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'proBarManaVal
        '
        Me.proBarManaVal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.proBarManaVal.ForeColor = System.Drawing.Color.Blue
        Me.proBarManaVal.Location = New System.Drawing.Point(84, 61)
        Me.proBarManaVal.Name = "proBarManaVal"
        Me.proBarManaVal.Size = New System.Drawing.Size(321, 23)
        Me.proBarManaVal.Step = 1
        Me.proBarManaVal.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.proBarManaVal.TabIndex = 49
        Me.proBarManaVal.Value = 100
        '
        'proBarHealthVal
        '
        Me.proBarHealthVal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.proBarHealthVal.ForeColor = System.Drawing.Color.Green
        Me.proBarHealthVal.Location = New System.Drawing.Point(84, 18)
        Me.proBarHealthVal.Name = "proBarHealthVal"
        Me.proBarHealthVal.Size = New System.Drawing.Size(321, 23)
        Me.proBarHealthVal.Step = 1
        Me.proBarHealthVal.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.proBarHealthVal.TabIndex = 48
        Me.proBarHealthVal.Value = 100
        '
        'lblManaVal
        '
        Me.lblManaVal.AutoSize = True
        Me.lblManaVal.BackColor = System.Drawing.Color.Transparent
        Me.lblManaVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManaVal.Location = New System.Drawing.Point(24, 79)
        Me.lblManaVal.Name = "lblManaVal"
        Me.lblManaVal.Size = New System.Drawing.Size(34, 16)
        Me.lblManaVal.TabIndex = 47
        Me.lblManaVal.Text = "(1/1)"
        '
        'lblMana
        '
        Me.lblMana.AutoSize = True
        Me.lblMana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMana.Location = New System.Drawing.Point(16, 60)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(62, 24)
        Me.lblMana.TabIndex = 46
        Me.lblMana.Text = "Mana:"
        '
        'lblHPVal
        '
        Me.lblHPVal.AutoSize = True
        Me.lblHPVal.BackColor = System.Drawing.Color.Transparent
        Me.lblHPVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPVal.Location = New System.Drawing.Point(18, 34)
        Me.lblHPVal.Name = "lblHPVal"
        Me.lblHPVal.Size = New System.Drawing.Size(34, 16)
        Me.lblHPVal.TabIndex = 45
        Me.lblHPVal.Text = "(1/1)"
        '
        'lblCIHP
        '
        Me.lblCIHP.AutoSize = True
        Me.lblCIHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIHP.Location = New System.Drawing.Point(9, 15)
        Me.lblCIHP.Name = "lblCIHP"
        Me.lblCIHP.Size = New System.Drawing.Size(69, 24)
        Me.lblCIHP.TabIndex = 44
        Me.lblCIHP.Text = "Health:"
        '
        'btnFlee
        '
        Me.btnFlee.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnDefault
        Me.btnFlee.Image = Global.WindowsApplication1.My.Resources.Resources.btnDefault
        Me.btnFlee.Location = New System.Drawing.Point(595, 133)
        Me.btnFlee.Name = "btnFlee"
        Me.btnFlee.Size = New System.Drawing.Size(101, 23)
        Me.btnFlee.TabIndex = 0
        Me.btnFlee.Text = "Flee"
        Me.btnFlee.UseVisualStyleBackColor = True
        '
        'attackAnim
        '
        Me.attackAnim.Interval = 1500
        '
        'playerHit
        '
        Me.playerHit.Interval = 500
        '
        'proBarEnemyHP
        '
        Me.proBarEnemyHP.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.proBarEnemyHP.ForeColor = System.Drawing.Color.Red
        Me.proBarEnemyHP.Location = New System.Drawing.Point(576, 203)
        Me.proBarEnemyHP.Name = "proBarEnemyHP"
        Me.proBarEnemyHP.Size = New System.Drawing.Size(123, 23)
        Me.proBarEnemyHP.Step = 1
        Me.proBarEnemyHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.proBarEnemyHP.TabIndex = 54
        Me.proBarEnemyHP.Value = 100
        '
        'playerAttAnim
        '
        Me.playerAttAnim.Interval = 1000
        '
        'deathAnim
        '
        Me.deathAnim.Interval = 200
        '
        'pcbBattleEnemy
        '
        Me.pcbBattleEnemy.Image = Global.WindowsApplication1.My.Resources.Resources.gobIdleL
        Me.pcbBattleEnemy.Location = New System.Drawing.Point(576, 246)
        Me.pcbBattleEnemy.Name = "pcbBattleEnemy"
        Me.pcbBattleEnemy.Size = New System.Drawing.Size(123, 123)
        Me.pcbBattleEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBattleEnemy.TabIndex = 4
        Me.pcbBattleEnemy.TabStop = False
        '
        'pcbBattlePlayer
        '
        Me.pcbBattlePlayer.Image = Global.WindowsApplication1.My.Resources.Resources.rogueBaseAttack
        Me.pcbBattlePlayer.Location = New System.Drawing.Point(13, 246)
        Me.pcbBattlePlayer.Name = "pcbBattlePlayer"
        Me.pcbBattlePlayer.Size = New System.Drawing.Size(133, 123)
        Me.pcbBattlePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBattlePlayer.TabIndex = 3
        Me.pcbBattlePlayer.TabStop = False
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
        'lblEnemyHP
        '
        Me.lblEnemyHP.AutoSize = True
        Me.lblEnemyHP.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemyHP.Location = New System.Drawing.Point(607, 226)
        Me.lblEnemyHP.Name = "lblEnemyHP"
        Me.lblEnemyHP.Size = New System.Drawing.Size(54, 13)
        Me.lblEnemyHP.TabIndex = 55
        Me.lblEnemyHP.Text = "(100/100)"
        '
        'lblEnemyDefeat
        '
        Me.lblEnemyDefeat.AutoSize = True
        Me.lblEnemyDefeat.Font = New System.Drawing.Font("Monotxt", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyDefeat.ForeColor = System.Drawing.Color.Red
        Me.lblEnemyDefeat.Location = New System.Drawing.Point(117, 28)
        Me.lblEnemyDefeat.Name = "lblEnemyDefeat"
        Me.lblEnemyDefeat.Size = New System.Drawing.Size(496, 47)
        Me.lblEnemyDefeat.TabIndex = 56
        Me.lblEnemyDefeat.Text = "[Enemy] Defeated!"
        Me.lblEnemyDefeat.Visible = False
        '
        'lblExpAmount
        '
        Me.lblExpAmount.AutoSize = True
        Me.lblExpAmount.Font = New System.Drawing.Font("Monotxt", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpAmount.ForeColor = System.Drawing.Color.Gold
        Me.lblExpAmount.Location = New System.Drawing.Point(259, 95)
        Me.lblExpAmount.Name = "lblExpAmount"
        Me.lblExpAmount.Size = New System.Drawing.Size(188, 47)
        Me.lblExpAmount.TabIndex = 57
        Me.lblExpAmount.Text = "-- EXP"
        Me.lblExpAmount.Visible = False
        '
        'tmrTimeToHide
        '
        Me.tmrTimeToHide.Interval = 3000
        '
        'frmBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblExpAmount)
        Me.Controls.Add(Me.lblEnemyDefeat)
        Me.Controls.Add(Me.lblEnemyHP)
        Me.Controls.Add(Me.proBarEnemyHP)
        Me.Controls.Add(Me.pcbBattleEnemy)
        Me.Controls.Add(Me.pcbBattlePlayer)
        Me.Controls.Add(Me.pcbBattleBG)
        Me.Controls.Add(Me.pnlBattleMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 584)
        Me.Name = "frmBattle"
        Me.Text = "Battle"
        Me.pnlBattleMenu.ResumeLayout(False)
        Me.pnlBattleMenu.PerformLayout()
        CType(Me.pcbBattleEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBattlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBattleBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFlee As System.Windows.Forms.Button
    Friend WithEvents pnlBattleMenu As System.Windows.Forms.Panel
    Friend WithEvents pcbBattleBG As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBattlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBattleEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents attackAnim As System.Windows.Forms.Timer
    Friend WithEvents playerHit As System.Windows.Forms.Timer
    Friend WithEvents proBarManaVal As System.Windows.Forms.ProgressBar
    Friend WithEvents proBarHealthVal As System.Windows.Forms.ProgressBar
    Friend WithEvents lblManaVal As System.Windows.Forms.Label
    Friend WithEvents lblMana As System.Windows.Forms.Label
    Friend WithEvents lblHPVal As System.Windows.Forms.Label
    Friend WithEvents lblCIHP As System.Windows.Forms.Label
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents btnMelee As System.Windows.Forms.Button
    Friend WithEvents btnAbilities As System.Windows.Forms.Button
    Friend WithEvents proBarEnemyHP As System.Windows.Forms.ProgressBar
    Friend WithEvents playerAttAnim As System.Windows.Forms.Timer
    Friend WithEvents deathAnim As System.Windows.Forms.Timer
    Friend WithEvents lblEnemyHP As System.Windows.Forms.Label
    Friend WithEvents lblEnemyDefeat As System.Windows.Forms.Label
    Friend WithEvents lblExpAmount As System.Windows.Forms.Label
    Friend WithEvents tmrTimeToHide As System.Windows.Forms.Timer
End Class
