<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCharScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCharScreen))
        Me.pnlChestF = New System.Windows.Forms.Panel()
        Me.picChest = New System.Windows.Forms.PictureBox()
        Me.pnlChestB = New System.Windows.Forms.Panel()
        Me.pnlHeadF = New System.Windows.Forms.Panel()
        Me.picHelm = New System.Windows.Forms.PictureBox()
        Me.pnlHeadB = New System.Windows.Forms.Panel()
        Me.pnlGlovesF = New System.Windows.Forms.Panel()
        Me.picGloves = New System.Windows.Forms.PictureBox()
        Me.pnlGlovesB = New System.Windows.Forms.Panel()
        Me.pnlWepRightF = New System.Windows.Forms.Panel()
        Me.picHandR = New System.Windows.Forms.PictureBox()
        Me.pnlWepRightB = New System.Windows.Forms.Panel()
        Me.pnlWepLeftF = New System.Windows.Forms.Panel()
        Me.picHandL = New System.Windows.Forms.PictureBox()
        Me.pnlWepLeftB = New System.Windows.Forms.Panel()
        Me.pnlBracerF = New System.Windows.Forms.Panel()
        Me.picBracer = New System.Windows.Forms.PictureBox()
        Me.pnlBracerB = New System.Windows.Forms.Panel()
        Me.pnlLegsF = New System.Windows.Forms.Panel()
        Me.picLegs = New System.Windows.Forms.PictureBox()
        Me.pnlLegsB = New System.Windows.Forms.Panel()
        Me.lblCIHP = New System.Windows.Forms.Label()
        Me.lblHPVal = New System.Windows.Forms.Label()
        Me.cboLHand = New System.Windows.Forms.ComboBox()
        Me.cboBracer = New System.Windows.Forms.ComboBox()
        Me.cboLegs = New System.Windows.Forms.ComboBox()
        Me.cboChest = New System.Windows.Forms.ComboBox()
        Me.cboHead = New System.Windows.Forms.ComboBox()
        Me.cboGloves = New System.Windows.Forms.ComboBox()
        Me.cboRHand = New System.Windows.Forms.ComboBox()
        Me.btnSav = New System.Windows.Forms.Button()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.lblDPS = New System.Windows.Forms.Label()
        Me.lblArmor = New System.Windows.Forms.Label()
        Me.lblIntel = New System.Windows.Forms.Label()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.lblAgi = New System.Windows.Forms.Label()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.lblDPSVal = New System.Windows.Forms.Label()
        Me.lblArmorVal = New System.Windows.Forms.Label()
        Me.lblIntelVal = New System.Windows.Forms.Label()
        Me.lblStrVal = New System.Windows.Forms.Label()
        Me.lblAgiVal = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblManaVal = New System.Windows.Forms.Label()
        Me.lblCharName = New System.Windows.Forms.Label()
        Me.lblCNVal = New System.Windows.Forms.Label()
        Me.proBarHealthVal = New System.Windows.Forms.ProgressBar()
        Me.proBarManaVal = New System.Windows.Forms.ProgressBar()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblLvl = New System.Windows.Forms.Label()
        Me.pnlChestF.SuspendLayout()
        CType(Me.picChest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeadF.SuspendLayout()
        CType(Me.picHelm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGlovesF.SuspendLayout()
        CType(Me.picGloves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWepRightF.SuspendLayout()
        CType(Me.picHandR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWepLeftF.SuspendLayout()
        CType(Me.picHandL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBracerF.SuspendLayout()
        CType(Me.picBracer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLegsF.SuspendLayout()
        CType(Me.picLegs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlChestF
        '
        Me.pnlChestF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlChestF.Controls.Add(Me.picChest)
        Me.pnlChestF.Location = New System.Drawing.Point(197, 190)
        Me.pnlChestF.Name = "pnlChestF"
        Me.pnlChestF.Size = New System.Drawing.Size(50, 50)
        Me.pnlChestF.TabIndex = 0
        '
        'picChest
        '
        Me.picChest.ErrorImage = CType(resources.GetObject("picChest.ErrorImage"), System.Drawing.Image)
        Me.picChest.Image = Global.WindowsApplication1.My.Resources.Resources.Chest
        Me.picChest.Location = New System.Drawing.Point(0, -3)
        Me.picChest.Name = "picChest"
        Me.picChest.Size = New System.Drawing.Size(53, 47)
        Me.picChest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChest.TabIndex = 45
        Me.picChest.TabStop = False
        '
        'pnlChestB
        '
        Me.pnlChestB.BackColor = System.Drawing.Color.Gold
        Me.pnlChestB.Location = New System.Drawing.Point(194, 187)
        Me.pnlChestB.Name = "pnlChestB"
        Me.pnlChestB.Size = New System.Drawing.Size(56, 56)
        Me.pnlChestB.TabIndex = 1
        '
        'pnlHeadF
        '
        Me.pnlHeadF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlHeadF.Controls.Add(Me.picHelm)
        Me.pnlHeadF.Location = New System.Drawing.Point(197, 96)
        Me.pnlHeadF.Name = "pnlHeadF"
        Me.pnlHeadF.Size = New System.Drawing.Size(50, 50)
        Me.pnlHeadF.TabIndex = 2
        '
        'picHelm
        '
        Me.picHelm.ErrorImage = CType(resources.GetObject("picHelm.ErrorImage"), System.Drawing.Image)
        Me.picHelm.Image = Global.WindowsApplication1.My.Resources.Resources.Helm
        Me.picHelm.Location = New System.Drawing.Point(0, 0)
        Me.picHelm.Name = "picHelm"
        Me.picHelm.Size = New System.Drawing.Size(53, 47)
        Me.picHelm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelm.TabIndex = 44
        Me.picHelm.TabStop = False
        '
        'pnlHeadB
        '
        Me.pnlHeadB.BackColor = System.Drawing.Color.Gold
        Me.pnlHeadB.Location = New System.Drawing.Point(194, 93)
        Me.pnlHeadB.Name = "pnlHeadB"
        Me.pnlHeadB.Size = New System.Drawing.Size(56, 56)
        Me.pnlHeadB.TabIndex = 3
        '
        'pnlGlovesF
        '
        Me.pnlGlovesF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlGlovesF.Controls.Add(Me.picGloves)
        Me.pnlGlovesF.Location = New System.Drawing.Point(82, 156)
        Me.pnlGlovesF.Name = "pnlGlovesF"
        Me.pnlGlovesF.Size = New System.Drawing.Size(50, 50)
        Me.pnlGlovesF.TabIndex = 2
        '
        'picGloves
        '
        Me.picGloves.ErrorImage = CType(resources.GetObject("picGloves.ErrorImage"), System.Drawing.Image)
        Me.picGloves.Image = Global.WindowsApplication1.My.Resources.Resources.Gloves
        Me.picGloves.Location = New System.Drawing.Point(0, -3)
        Me.picGloves.Name = "picGloves"
        Me.picGloves.Size = New System.Drawing.Size(53, 47)
        Me.picGloves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGloves.TabIndex = 45
        Me.picGloves.TabStop = False
        '
        'pnlGlovesB
        '
        Me.pnlGlovesB.BackColor = System.Drawing.Color.Gold
        Me.pnlGlovesB.Location = New System.Drawing.Point(79, 153)
        Me.pnlGlovesB.Name = "pnlGlovesB"
        Me.pnlGlovesB.Size = New System.Drawing.Size(56, 56)
        Me.pnlGlovesB.TabIndex = 3
        '
        'pnlWepRightF
        '
        Me.pnlWepRightF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlWepRightF.Controls.Add(Me.picHandR)
        Me.pnlWepRightF.Location = New System.Drawing.Point(82, 228)
        Me.pnlWepRightF.Name = "pnlWepRightF"
        Me.pnlWepRightF.Size = New System.Drawing.Size(50, 50)
        Me.pnlWepRightF.TabIndex = 2
        '
        'picHandR
        '
        Me.picHandR.ErrorImage = CType(resources.GetObject("picHandR.ErrorImage"), System.Drawing.Image)
        Me.picHandR.Image = Global.WindowsApplication1.My.Resources.Resources.SwordR
        Me.picHandR.Location = New System.Drawing.Point(0, 0)
        Me.picHandR.Name = "picHandR"
        Me.picHandR.Size = New System.Drawing.Size(53, 47)
        Me.picHandR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHandR.TabIndex = 45
        Me.picHandR.TabStop = False
        '
        'pnlWepRightB
        '
        Me.pnlWepRightB.BackColor = System.Drawing.Color.Gold
        Me.pnlWepRightB.Location = New System.Drawing.Point(79, 225)
        Me.pnlWepRightB.Name = "pnlWepRightB"
        Me.pnlWepRightB.Size = New System.Drawing.Size(56, 56)
        Me.pnlWepRightB.TabIndex = 3
        '
        'pnlWepLeftF
        '
        Me.pnlWepLeftF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlWepLeftF.Controls.Add(Me.picHandL)
        Me.pnlWepLeftF.Location = New System.Drawing.Point(310, 231)
        Me.pnlWepLeftF.Name = "pnlWepLeftF"
        Me.pnlWepLeftF.Size = New System.Drawing.Size(50, 50)
        Me.pnlWepLeftF.TabIndex = 5
        '
        'picHandL
        '
        Me.picHandL.ErrorImage = CType(resources.GetObject("picHandL.ErrorImage"), System.Drawing.Image)
        Me.picHandL.Image = Global.WindowsApplication1.My.Resources.Resources.SwordL
        Me.picHandL.Location = New System.Drawing.Point(0, 0)
        Me.picHandL.Name = "picHandL"
        Me.picHandL.Size = New System.Drawing.Size(53, 47)
        Me.picHandL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHandL.TabIndex = 45
        Me.picHandL.TabStop = False
        '
        'pnlWepLeftB
        '
        Me.pnlWepLeftB.BackColor = System.Drawing.Color.Gold
        Me.pnlWepLeftB.Location = New System.Drawing.Point(307, 228)
        Me.pnlWepLeftB.Name = "pnlWepLeftB"
        Me.pnlWepLeftB.Size = New System.Drawing.Size(56, 56)
        Me.pnlWepLeftB.TabIndex = 7
        '
        'pnlBracerF
        '
        Me.pnlBracerF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlBracerF.Controls.Add(Me.picBracer)
        Me.pnlBracerF.Location = New System.Drawing.Point(310, 159)
        Me.pnlBracerF.Name = "pnlBracerF"
        Me.pnlBracerF.Size = New System.Drawing.Size(50, 50)
        Me.pnlBracerF.TabIndex = 4
        '
        'picBracer
        '
        Me.picBracer.ErrorImage = CType(resources.GetObject("picBracer.ErrorImage"), System.Drawing.Image)
        Me.picBracer.Image = Global.WindowsApplication1.My.Resources.Resources.Bracer
        Me.picBracer.Location = New System.Drawing.Point(-3, 0)
        Me.picBracer.Name = "picBracer"
        Me.picBracer.Size = New System.Drawing.Size(53, 47)
        Me.picBracer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBracer.TabIndex = 45
        Me.picBracer.TabStop = False
        '
        'pnlBracerB
        '
        Me.pnlBracerB.BackColor = System.Drawing.Color.Gold
        Me.pnlBracerB.Location = New System.Drawing.Point(307, 156)
        Me.pnlBracerB.Name = "pnlBracerB"
        Me.pnlBracerB.Size = New System.Drawing.Size(56, 56)
        Me.pnlBracerB.TabIndex = 6
        '
        'pnlLegsF
        '
        Me.pnlLegsF.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlLegsF.Controls.Add(Me.picLegs)
        Me.pnlLegsF.Location = New System.Drawing.Point(197, 282)
        Me.pnlLegsF.Name = "pnlLegsF"
        Me.pnlLegsF.Size = New System.Drawing.Size(50, 50)
        Me.pnlLegsF.TabIndex = 8
        '
        'picLegs
        '
        Me.picLegs.ErrorImage = CType(resources.GetObject("picLegs.ErrorImage"), System.Drawing.Image)
        Me.picLegs.Image = Global.WindowsApplication1.My.Resources.Resources.Legs
        Me.picLegs.Location = New System.Drawing.Point(0, 0)
        Me.picLegs.Name = "picLegs"
        Me.picLegs.Size = New System.Drawing.Size(53, 47)
        Me.picLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLegs.TabIndex = 45
        Me.picLegs.TabStop = False
        '
        'pnlLegsB
        '
        Me.pnlLegsB.BackColor = System.Drawing.Color.Gold
        Me.pnlLegsB.Location = New System.Drawing.Point(194, 279)
        Me.pnlLegsB.Name = "pnlLegsB"
        Me.pnlLegsB.Size = New System.Drawing.Size(56, 56)
        Me.pnlLegsB.TabIndex = 9
        '
        'lblCIHP
        '
        Me.lblCIHP.AutoSize = True
        Me.lblCIHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIHP.Location = New System.Drawing.Point(12, 9)
        Me.lblCIHP.Name = "lblCIHP"
        Me.lblCIHP.Size = New System.Drawing.Size(69, 24)
        Me.lblCIHP.TabIndex = 10
        Me.lblCIHP.Text = "Health:"
        '
        'lblHPVal
        '
        Me.lblHPVal.AutoSize = True
        Me.lblHPVal.BackColor = System.Drawing.Color.Transparent
        Me.lblHPVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPVal.Location = New System.Drawing.Point(26, 28)
        Me.lblHPVal.Name = "lblHPVal"
        Me.lblHPVal.Size = New System.Drawing.Size(34, 16)
        Me.lblHPVal.TabIndex = 12
        Me.lblHPVal.Text = "(1/1)"
        '
        'cboLHand
        '
        Me.cboLHand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLHand.FormattingEnabled = True
        Me.cboLHand.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboLHand.Location = New System.Drawing.Point(307, 277)
        Me.cboLHand.Name = "cboLHand"
        Me.cboLHand.Size = New System.Drawing.Size(56, 21)
        Me.cboLHand.TabIndex = 13
        '
        'cboBracer
        '
        Me.cboBracer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBracer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBracer.FormattingEnabled = True
        Me.cboBracer.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboBracer.Location = New System.Drawing.Point(307, 201)
        Me.cboBracer.Name = "cboBracer"
        Me.cboBracer.Size = New System.Drawing.Size(56, 21)
        Me.cboBracer.TabIndex = 14
        '
        'cboLegs
        '
        Me.cboLegs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLegs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLegs.FormattingEnabled = True
        Me.cboLegs.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboLegs.Location = New System.Drawing.Point(194, 325)
        Me.cboLegs.Name = "cboLegs"
        Me.cboLegs.Size = New System.Drawing.Size(56, 21)
        Me.cboLegs.TabIndex = 15
        '
        'cboChest
        '
        Me.cboChest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChest.FormattingEnabled = True
        Me.cboChest.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboChest.Location = New System.Drawing.Point(194, 231)
        Me.cboChest.Name = "cboChest"
        Me.cboChest.Size = New System.Drawing.Size(56, 21)
        Me.cboChest.TabIndex = 16
        '
        'cboHead
        '
        Me.cboHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHead.FormattingEnabled = True
        Me.cboHead.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboHead.Location = New System.Drawing.Point(194, 138)
        Me.cboHead.Name = "cboHead"
        Me.cboHead.Size = New System.Drawing.Size(56, 21)
        Me.cboHead.TabIndex = 17
        '
        'cboGloves
        '
        Me.cboGloves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGloves.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGloves.FormattingEnabled = True
        Me.cboGloves.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboGloves.Location = New System.Drawing.Point(79, 198)
        Me.cboGloves.Name = "cboGloves"
        Me.cboGloves.Size = New System.Drawing.Size(56, 21)
        Me.cboGloves.TabIndex = 18
        '
        'cboRHand
        '
        Me.cboRHand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRHand.FormattingEnabled = True
        Me.cboRHand.Items.AddRange(New Object() {"(none)", "Debug"})
        Me.cboRHand.Location = New System.Drawing.Point(79, 275)
        Me.cboRHand.Name = "cboRHand"
        Me.cboRHand.Size = New System.Drawing.Size(56, 21)
        Me.cboRHand.TabIndex = 19
        '
        'btnSav
        '
        Me.btnSav.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSav.Location = New System.Drawing.Point(354, 406)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(79, 26)
        Me.btnSav.TabIndex = 20
        Me.btnSav.Text = "Save"
        Me.btnSav.UseVisualStyleBackColor = True
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.Location = New System.Drawing.Point(8, 0)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(49, 24)
        Me.lblStats.TabIndex = 21
        Me.lblStats.Text = "Stats"
        '
        'lblDPS
        '
        Me.lblDPS.AutoSize = True
        Me.lblDPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPS.Location = New System.Drawing.Point(21, 30)
        Me.lblDPS.Name = "lblDPS"
        Me.lblDPS.Size = New System.Drawing.Size(35, 15)
        Me.lblDPS.TabIndex = 22
        Me.lblDPS.Text = "DPS:"
        '
        'lblArmor
        '
        Me.lblArmor.AutoSize = True
        Me.lblArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmor.Location = New System.Drawing.Point(9, 43)
        Me.lblArmor.Name = "lblArmor"
        Me.lblArmor.Size = New System.Drawing.Size(43, 15)
        Me.lblArmor.TabIndex = 23
        Me.lblArmor.Text = "Armor:"
        '
        'lblIntel
        '
        Me.lblIntel.AutoSize = True
        Me.lblIntel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntel.Location = New System.Drawing.Point(9, 69)
        Me.lblIntel.Name = "lblIntel"
        Me.lblIntel.Size = New System.Drawing.Size(73, 15)
        Me.lblIntel.TabIndex = 24
        Me.lblIntel.Text = "Intelligence:"
        '
        'lblStr
        '
        Me.lblStr.AutoSize = True
        Me.lblStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStr.Location = New System.Drawing.Point(25, 82)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(56, 15)
        Me.lblStr.TabIndex = 25
        Me.lblStr.Text = "Strength:"
        '
        'lblAgi
        '
        Me.lblAgi.AutoSize = True
        Me.lblAgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgi.Location = New System.Drawing.Point(36, 95)
        Me.lblAgi.Name = "lblAgi"
        Me.lblAgi.Size = New System.Drawing.Size(41, 15)
        Me.lblAgi.TabIndex = 26
        Me.lblAgi.Text = "Agility:"
        '
        'lblMana
        '
        Me.lblMana.AutoSize = True
        Me.lblMana.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMana.Location = New System.Drawing.Point(19, 54)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(62, 24)
        Me.lblMana.TabIndex = 27
        Me.lblMana.Text = "Mana:"
        '
        'lblDPSVal
        '
        Me.lblDPSVal.AutoSize = True
        Me.lblDPSVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPSVal.ForeColor = System.Drawing.Color.Yellow
        Me.lblDPSVal.Location = New System.Drawing.Point(56, 30)
        Me.lblDPSVal.Name = "lblDPSVal"
        Me.lblDPSVal.Size = New System.Drawing.Size(0, 15)
        Me.lblDPSVal.TabIndex = 28
        '
        'lblArmorVal
        '
        Me.lblArmorVal.AutoSize = True
        Me.lblArmorVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmorVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblArmorVal.Location = New System.Drawing.Point(56, 44)
        Me.lblArmorVal.Name = "lblArmorVal"
        Me.lblArmorVal.Size = New System.Drawing.Size(0, 15)
        Me.lblArmorVal.TabIndex = 29
        '
        'lblIntelVal
        '
        Me.lblIntelVal.AutoSize = True
        Me.lblIntelVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntelVal.ForeColor = System.Drawing.Color.Blue
        Me.lblIntelVal.Location = New System.Drawing.Point(84, 69)
        Me.lblIntelVal.Name = "lblIntelVal"
        Me.lblIntelVal.Size = New System.Drawing.Size(0, 15)
        Me.lblIntelVal.TabIndex = 30
        '
        'lblStrVal
        '
        Me.lblStrVal.AutoSize = True
        Me.lblStrVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrVal.ForeColor = System.Drawing.Color.Red
        Me.lblStrVal.Location = New System.Drawing.Point(84, 82)
        Me.lblStrVal.Name = "lblStrVal"
        Me.lblStrVal.Size = New System.Drawing.Size(0, 15)
        Me.lblStrVal.TabIndex = 31
        '
        'lblAgiVal
        '
        Me.lblAgiVal.AutoSize = True
        Me.lblAgiVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgiVal.ForeColor = System.Drawing.Color.Lime
        Me.lblAgiVal.Location = New System.Drawing.Point(84, 94)
        Me.lblAgiVal.Name = "lblAgiVal"
        Me.lblAgiVal.Size = New System.Drawing.Size(0, 15)
        Me.lblAgiVal.TabIndex = 32
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlStats.Controls.Add(Me.lblAgiVal)
        Me.pnlStats.Controls.Add(Me.lblStrVal)
        Me.pnlStats.Controls.Add(Me.lblStats)
        Me.pnlStats.Controls.Add(Me.lblIntelVal)
        Me.pnlStats.Controls.Add(Me.lblArmorVal)
        Me.pnlStats.Controls.Add(Me.lblDPSVal)
        Me.pnlStats.Controls.Add(Me.lblAgi)
        Me.pnlStats.Controls.Add(Me.lblStr)
        Me.pnlStats.Controls.Add(Me.lblIntel)
        Me.pnlStats.Controls.Add(Me.lblArmor)
        Me.pnlStats.Controls.Add(Me.lblDPS)
        Me.pnlStats.Location = New System.Drawing.Point(4, 318)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(131, 119)
        Me.pnlStats.TabIndex = 33
        '
        'lblManaVal
        '
        Me.lblManaVal.AutoSize = True
        Me.lblManaVal.BackColor = System.Drawing.Color.Transparent
        Me.lblManaVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManaVal.Location = New System.Drawing.Point(32, 73)
        Me.lblManaVal.Name = "lblManaVal"
        Me.lblManaVal.Size = New System.Drawing.Size(34, 16)
        Me.lblManaVal.TabIndex = 35
        Me.lblManaVal.Text = "(1/1)"
        '
        'lblCharName
        '
        Me.lblCharName.AutoSize = True
        Me.lblCharName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName.Location = New System.Drawing.Point(163, 366)
        Me.lblCharName.Name = "lblCharName"
        Me.lblCharName.Size = New System.Drawing.Size(49, 15)
        Me.lblCharName.TabIndex = 37
        Me.lblCharName.Text = "Name:"
        '
        'lblCNVal
        '
        Me.lblCNVal.AutoSize = True
        Me.lblCNVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNVal.Location = New System.Drawing.Point(213, 366)
        Me.lblCNVal.Name = "lblCNVal"
        Me.lblCNVal.Size = New System.Drawing.Size(70, 15)
        Me.lblCNVal.TabIndex = 38
        Me.lblCNVal.Text = "[Undefined]"
        '
        'proBarHealthVal
        '
        Me.proBarHealthVal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.proBarHealthVal.ForeColor = System.Drawing.Color.Red
        Me.proBarHealthVal.Location = New System.Drawing.Point(87, 12)
        Me.proBarHealthVal.Name = "proBarHealthVal"
        Me.proBarHealthVal.Size = New System.Drawing.Size(321, 23)
        Me.proBarHealthVal.Step = 1
        Me.proBarHealthVal.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.proBarHealthVal.TabIndex = 42
        Me.proBarHealthVal.Value = 100
        '
        'proBarManaVal
        '
        Me.proBarManaVal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.proBarManaVal.ForeColor = System.Drawing.Color.Blue
        Me.proBarManaVal.Location = New System.Drawing.Point(87, 55)
        Me.proBarManaVal.Name = "proBarManaVal"
        Me.proBarManaVal.Size = New System.Drawing.Size(321, 23)
        Me.proBarManaVal.Step = 1
        Me.proBarManaVal.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.proBarManaVal.TabIndex = 43
        Me.proBarManaVal.Value = 100
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(167, 400)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(45, 15)
        Me.lblLevel.TabIndex = 44
        Me.lblLevel.Text = "Level:"
        '
        'lblLvl
        '
        Me.lblLvl.AutoSize = True
        Me.lblLvl.Location = New System.Drawing.Point(213, 402)
        Me.lblLvl.Name = "lblLvl"
        Me.lblLvl.Size = New System.Drawing.Size(13, 13)
        Me.lblLvl.TabIndex = 45
        Me.lblLvl.Text = "0"
        '
        'frmCharScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(435, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLvl)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.proBarManaVal)
        Me.Controls.Add(Me.proBarHealthVal)
        Me.Controls.Add(Me.lblCNVal)
        Me.Controls.Add(Me.lblCharName)
        Me.Controls.Add(Me.lblManaVal)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.lblMana)
        Me.Controls.Add(Me.btnSav)
        Me.Controls.Add(Me.cboRHand)
        Me.Controls.Add(Me.cboGloves)
        Me.Controls.Add(Me.cboHead)
        Me.Controls.Add(Me.cboChest)
        Me.Controls.Add(Me.cboLegs)
        Me.Controls.Add(Me.cboBracer)
        Me.Controls.Add(Me.cboLHand)
        Me.Controls.Add(Me.lblHPVal)
        Me.Controls.Add(Me.lblCIHP)
        Me.Controls.Add(Me.pnlLegsF)
        Me.Controls.Add(Me.pnlLegsB)
        Me.Controls.Add(Me.pnlWepLeftF)
        Me.Controls.Add(Me.pnlWepLeftB)
        Me.Controls.Add(Me.pnlBracerF)
        Me.Controls.Add(Me.pnlBracerB)
        Me.Controls.Add(Me.pnlWepRightF)
        Me.Controls.Add(Me.pnlWepRightB)
        Me.Controls.Add(Me.pnlGlovesF)
        Me.Controls.Add(Me.pnlGlovesB)
        Me.Controls.Add(Me.pnlHeadF)
        Me.Controls.Add(Me.pnlHeadB)
        Me.Controls.Add(Me.pnlChestF)
        Me.Controls.Add(Me.pnlChestB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(451, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(451, 472)
        Me.Name = "frmCharScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Character Information"
        Me.pnlChestF.ResumeLayout(False)
        CType(Me.picChest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeadF.ResumeLayout(False)
        CType(Me.picHelm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGlovesF.ResumeLayout(False)
        CType(Me.picGloves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWepRightF.ResumeLayout(False)
        CType(Me.picHandR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWepLeftF.ResumeLayout(False)
        CType(Me.picHandL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBracerF.ResumeLayout(False)
        CType(Me.picBracer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLegsF.ResumeLayout(False)
        CType(Me.picLegs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlChestF As System.Windows.Forms.Panel
    Friend WithEvents pnlChestB As System.Windows.Forms.Panel
    Friend WithEvents pnlHeadF As System.Windows.Forms.Panel
    Friend WithEvents pnlHeadB As System.Windows.Forms.Panel
    Friend WithEvents pnlGlovesF As System.Windows.Forms.Panel
    Friend WithEvents pnlGlovesB As System.Windows.Forms.Panel
    Friend WithEvents pnlWepRightF As System.Windows.Forms.Panel
    Friend WithEvents pnlWepRightB As System.Windows.Forms.Panel
    Friend WithEvents pnlWepLeftF As System.Windows.Forms.Panel
    Friend WithEvents pnlWepLeftB As System.Windows.Forms.Panel
    Friend WithEvents pnlBracerF As System.Windows.Forms.Panel
    Friend WithEvents pnlBracerB As System.Windows.Forms.Panel
    Friend WithEvents pnlLegsF As System.Windows.Forms.Panel
    Friend WithEvents pnlLegsB As System.Windows.Forms.Panel
    Friend WithEvents lblCIHP As System.Windows.Forms.Label
    Friend WithEvents lblHPVal As System.Windows.Forms.Label
    Friend WithEvents cboLHand As ComboBox
    Friend WithEvents cboBracer As ComboBox
    Friend WithEvents cboLegs As ComboBox
    Friend WithEvents cboChest As ComboBox
    Friend WithEvents cboHead As ComboBox
    Friend WithEvents cboGloves As ComboBox
    Friend WithEvents cboRHand As ComboBox
    Friend WithEvents btnSav As Button
    Friend WithEvents lblStats As Label
    Friend WithEvents lblDPS As Label
    Friend WithEvents lblArmor As Label
    Friend WithEvents lblIntel As Label
    Friend WithEvents lblStr As Label
    Friend WithEvents lblAgi As Label
    Friend WithEvents lblMana As Label
    Friend WithEvents lblDPSVal As Label
    Friend WithEvents lblArmorVal As Label
    Friend WithEvents lblIntelVal As Label
    Friend WithEvents lblStrVal As Label
    Friend WithEvents lblAgiVal As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblManaVal As Label
    Friend WithEvents lblCharName As Label
    Friend WithEvents lblCNVal As Label
    Friend WithEvents proBarHealthVal As ProgressBar
    Friend WithEvents proBarManaVal As ProgressBar
    Friend WithEvents picHelm As System.Windows.Forms.PictureBox
    Friend WithEvents picChest As System.Windows.Forms.PictureBox
    Friend WithEvents picGloves As System.Windows.Forms.PictureBox
    Friend WithEvents picHandR As System.Windows.Forms.PictureBox
    Friend WithEvents picHandL As System.Windows.Forms.PictureBox
    Friend WithEvents picBracer As System.Windows.Forms.PictureBox
    Friend WithEvents picLegs As System.Windows.Forms.PictureBox
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblLvl As Label
End Class
