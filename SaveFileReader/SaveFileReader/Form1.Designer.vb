<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSvFilRdr
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
        Me.lblCharName = New System.Windows.Forms.Label()
        Me.lblCurrentHealth = New System.Windows.Forms.Label()
        Me.lblMxHeal = New System.Windows.Forms.Label()
        Me.lblCurrentMana = New System.Windows.Forms.Label()
        Me.lblMxMana = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.lblIntelligence = New System.Windows.Forms.Label()
        Me.lblAgility = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lstSaves = New System.Windows.Forms.ListBox()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.txtCH = New System.Windows.Forms.TextBox()
        Me.txtMH = New System.Windows.Forms.TextBox()
        Me.txtCM = New System.Windows.Forms.TextBox()
        Me.txtMM = New System.Windows.Forms.TextBox()
        Me.txtStr = New System.Windows.Forms.TextBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.txtAgi = New System.Windows.Forms.TextBox()
        Me.txtLvl = New System.Windows.Forms.TextBox()
        Me.txtMon = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtSavesDirectory = New System.Windows.Forms.TextBox()
        Me.lblSavesDir = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCharName
        '
        Me.lblCharName.AutoSize = True
        Me.lblCharName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName.Location = New System.Drawing.Point(12, 20)
        Me.lblCharName.Name = "lblCharName"
        Me.lblCharName.Size = New System.Drawing.Size(144, 20)
        Me.lblCharName.TabIndex = 0
        Me.lblCharName.Text = "Character Name:"
        '
        'lblCurrentHealth
        '
        Me.lblCurrentHealth.AutoSize = True
        Me.lblCurrentHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentHealth.Location = New System.Drawing.Point(24, 40)
        Me.lblCurrentHealth.Name = "lblCurrentHealth"
        Me.lblCurrentHealth.Size = New System.Drawing.Size(132, 20)
        Me.lblCurrentHealth.TabIndex = 1
        Me.lblCurrentHealth.Text = "Current Health:"
        '
        'lblMxHeal
        '
        Me.lblMxHeal.AutoSize = True
        Me.lblMxHeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMxHeal.Location = New System.Drawing.Point(52, 60)
        Me.lblMxHeal.Name = "lblMxHeal"
        Me.lblMxHeal.Size = New System.Drawing.Size(104, 20)
        Me.lblMxHeal.TabIndex = 2
        Me.lblMxHeal.Text = "Max Health:"
        '
        'lblCurrentMana
        '
        Me.lblCurrentMana.AutoSize = True
        Me.lblCurrentMana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMana.Location = New System.Drawing.Point(33, 80)
        Me.lblCurrentMana.Name = "lblCurrentMana"
        Me.lblCurrentMana.Size = New System.Drawing.Size(123, 20)
        Me.lblCurrentMana.TabIndex = 3
        Me.lblCurrentMana.Text = "Current Mana:"
        '
        'lblMxMana
        '
        Me.lblMxMana.AutoSize = True
        Me.lblMxMana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMxMana.Location = New System.Drawing.Point(61, 100)
        Me.lblMxMana.Name = "lblMxMana"
        Me.lblMxMana.Size = New System.Drawing.Size(95, 20)
        Me.lblMxMana.TabIndex = 4
        Me.lblMxMana.Text = "Max Mana:"
        '
        'lblStrength
        '
        Me.lblStrength.AutoSize = True
        Me.lblStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrength.Location = New System.Drawing.Point(72, 120)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(84, 20)
        Me.lblStrength.TabIndex = 5
        Me.lblStrength.Text = "Strength:"
        '
        'lblIntelligence
        '
        Me.lblIntelligence.AutoSize = True
        Me.lblIntelligence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntelligence.Location = New System.Drawing.Point(49, 140)
        Me.lblIntelligence.Name = "lblIntelligence"
        Me.lblIntelligence.Size = New System.Drawing.Size(107, 20)
        Me.lblIntelligence.TabIndex = 6
        Me.lblIntelligence.Text = "Intelligence:"
        '
        'lblAgility
        '
        Me.lblAgility.AutoSize = True
        Me.lblAgility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgility.Location = New System.Drawing.Point(94, 160)
        Me.lblAgility.Name = "lblAgility"
        Me.lblAgility.Size = New System.Drawing.Size(62, 20)
        Me.lblAgility.TabIndex = 7
        Me.lblAgility.Text = "Agility:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(100, 180)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(56, 20)
        Me.lblLevel.TabIndex = 8
        Me.lblLevel.Text = "Level:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(90, 200)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(66, 20)
        Me.lblMoney.TabIndex = 18
        Me.lblMoney.Text = "Money:"
        '
        'lstSaves
        '
        Me.lstSaves.FormattingEnabled = True
        Me.lstSaves.Location = New System.Drawing.Point(16, 231)
        Me.lstSaves.Name = "lstSaves"
        Me.lstSaves.Size = New System.Drawing.Size(532, 134)
        Me.lstSaves.TabIndex = 20
        '
        'txtCN
        '
        Me.txtCN.Location = New System.Drawing.Point(155, 21)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(100, 20)
        Me.txtCN.TabIndex = 21
        '
        'txtCH
        '
        Me.txtCH.Location = New System.Drawing.Point(155, 41)
        Me.txtCH.Name = "txtCH"
        Me.txtCH.Size = New System.Drawing.Size(100, 20)
        Me.txtCH.TabIndex = 22
        '
        'txtMH
        '
        Me.txtMH.Location = New System.Drawing.Point(155, 61)
        Me.txtMH.Name = "txtMH"
        Me.txtMH.Size = New System.Drawing.Size(100, 20)
        Me.txtMH.TabIndex = 23
        '
        'txtCM
        '
        Me.txtCM.Location = New System.Drawing.Point(155, 81)
        Me.txtCM.Name = "txtCM"
        Me.txtCM.Size = New System.Drawing.Size(100, 20)
        Me.txtCM.TabIndex = 24
        '
        'txtMM
        '
        Me.txtMM.Location = New System.Drawing.Point(155, 101)
        Me.txtMM.Name = "txtMM"
        Me.txtMM.Size = New System.Drawing.Size(100, 20)
        Me.txtMM.TabIndex = 25
        '
        'txtStr
        '
        Me.txtStr.Location = New System.Drawing.Point(155, 121)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(100, 20)
        Me.txtStr.TabIndex = 26
        '
        'txtInt
        '
        Me.txtInt.Location = New System.Drawing.Point(155, 141)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(100, 20)
        Me.txtInt.TabIndex = 27
        '
        'txtAgi
        '
        Me.txtAgi.Location = New System.Drawing.Point(155, 161)
        Me.txtAgi.Name = "txtAgi"
        Me.txtAgi.Size = New System.Drawing.Size(100, 20)
        Me.txtAgi.TabIndex = 28
        '
        'txtLvl
        '
        Me.txtLvl.Location = New System.Drawing.Point(155, 181)
        Me.txtLvl.Name = "txtLvl"
        Me.txtLvl.Size = New System.Drawing.Size(100, 20)
        Me.txtLvl.TabIndex = 29
        '
        'txtMon
        '
        Me.txtMon.Location = New System.Drawing.Point(155, 201)
        Me.txtMon.Name = "txtMon"
        Me.txtMon.Size = New System.Drawing.Size(100, 20)
        Me.txtMon.TabIndex = 30
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(356, 86)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(121, 23)
        Me.btnBrowse.TabIndex = 32
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtSavesDirectory
        '
        Me.txtSavesDirectory.Location = New System.Drawing.Point(286, 60)
        Me.txtSavesDirectory.Name = "txtSavesDirectory"
        Me.txtSavesDirectory.Size = New System.Drawing.Size(262, 20)
        Me.txtSavesDirectory.TabIndex = 33
        '
        'lblSavesDir
        '
        Me.lblSavesDir.AutoSize = True
        Me.lblSavesDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavesDir.Location = New System.Drawing.Point(342, 37)
        Me.lblSavesDir.Name = "lblSavesDir"
        Me.lblSavesDir.Size = New System.Drawing.Size(140, 20)
        Me.lblSavesDir.TabIndex = 34
        Me.lblSavesDir.Text = "Saves Directory:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(379, 138)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmSvFilRdr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 379)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblSavesDir)
        Me.Controls.Add(Me.txtSavesDirectory)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtMon)
        Me.Controls.Add(Me.txtLvl)
        Me.Controls.Add(Me.txtAgi)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.txtStr)
        Me.Controls.Add(Me.txtMM)
        Me.Controls.Add(Me.txtCM)
        Me.Controls.Add(Me.txtMH)
        Me.Controls.Add(Me.txtCH)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.lstSaves)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblAgility)
        Me.Controls.Add(Me.lblIntelligence)
        Me.Controls.Add(Me.lblStrength)
        Me.Controls.Add(Me.lblMxMana)
        Me.Controls.Add(Me.lblCurrentMana)
        Me.Controls.Add(Me.lblMxHeal)
        Me.Controls.Add(Me.lblCurrentHealth)
        Me.Controls.Add(Me.lblCharName)
        Me.Name = "frmSvFilRdr"
        Me.Text = "Save File Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCharName As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHealth As System.Windows.Forms.Label
    Friend WithEvents lblMxHeal As System.Windows.Forms.Label
    Friend WithEvents lblCurrentMana As System.Windows.Forms.Label
    Friend WithEvents lblMxMana As System.Windows.Forms.Label
    Friend WithEvents lblStrength As System.Windows.Forms.Label
    Friend WithEvents lblIntelligence As System.Windows.Forms.Label
    Friend WithEvents lblAgility As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents lstSaves As System.Windows.Forms.ListBox
    Friend WithEvents txtCN As System.Windows.Forms.TextBox
    Friend WithEvents txtCH As System.Windows.Forms.TextBox
    Friend WithEvents txtMH As System.Windows.Forms.TextBox
    Friend WithEvents txtCM As System.Windows.Forms.TextBox
    Friend WithEvents txtMM As System.Windows.Forms.TextBox
    Friend WithEvents txtStr As System.Windows.Forms.TextBox
    Friend WithEvents txtInt As System.Windows.Forms.TextBox
    Friend WithEvents txtAgi As System.Windows.Forms.TextBox
    Friend WithEvents txtLvl As System.Windows.Forms.TextBox
    Friend WithEvents txtMon As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtSavesDirectory As TextBox
    Friend WithEvents lblSavesDir As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnUpdate As Button
End Class
