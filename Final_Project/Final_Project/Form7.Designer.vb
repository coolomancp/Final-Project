<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCharCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCharCreate))
        Me.lblCharName = New System.Windows.Forms.Label()
        Me.grpCharPrev = New System.Windows.Forms.GroupBox()
        Me.pcbCharPrev = New System.Windows.Forms.PictureBox()
        Me.txtChName = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblChooseClass = New System.Windows.Forms.Label()
        Me.rdbWarrior = New System.Windows.Forms.RadioButton()
        Me.rdbMage = New System.Windows.Forms.RadioButton()
        Me.rdbRogue = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStatStr = New System.Windows.Forms.Label()
        Me.lblStatIntel = New System.Windows.Forms.Label()
        Me.lblStatAgi = New System.Windows.Forms.Label()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblAgi = New System.Windows.Forms.Label()
        Me.grpCharPrev.SuspendLayout()
        CType(Me.pcbCharPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharName
        '
        Me.lblCharName.AutoSize = True
        Me.lblCharName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName.Location = New System.Drawing.Point(12, 28)
        Me.lblCharName.Name = "lblCharName"
        Me.lblCharName.Size = New System.Drawing.Size(79, 25)
        Me.lblCharName.TabIndex = 0
        Me.lblCharName.Text = "Name:"
        '
        'grpCharPrev
        '
        Me.grpCharPrev.Controls.Add(Me.pcbCharPrev)
        Me.grpCharPrev.Location = New System.Drawing.Point(457, 12)
        Me.grpCharPrev.Name = "grpCharPrev"
        Me.grpCharPrev.Size = New System.Drawing.Size(200, 260)
        Me.grpCharPrev.TabIndex = 1
        Me.grpCharPrev.TabStop = False
        '
        'pcbCharPrev
        '
        Me.pcbCharPrev.Location = New System.Drawing.Point(7, 16)
        Me.pcbCharPrev.Name = "pcbCharPrev"
        Me.pcbCharPrev.Size = New System.Drawing.Size(187, 235)
        Me.pcbCharPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCharPrev.TabIndex = 0
        Me.pcbCharPrev.TabStop = False
        '
        'txtChName
        '
        Me.txtChName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChName.Location = New System.Drawing.Point(90, 25)
        Me.txtChName.MaxLength = 25
        Me.txtChName.Name = "txtChName"
        Me.txtChName.Size = New System.Drawing.Size(116, 31)
        Me.txtChName.TabIndex = 2
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(513, 242)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(92, 37)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblChooseClass
        '
        Me.lblChooseClass.AutoSize = True
        Me.lblChooseClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseClass.Location = New System.Drawing.Point(12, 75)
        Me.lblChooseClass.Name = "lblChooseClass"
        Me.lblChooseClass.Size = New System.Drawing.Size(78, 25)
        Me.lblChooseClass.TabIndex = 4
        Me.lblChooseClass.Text = "Class:"
        '
        'rdbWarrior
        '
        Me.rdbWarrior.AutoSize = True
        Me.rdbWarrior.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbWarrior.Location = New System.Drawing.Point(41, 114)
        Me.rdbWarrior.Name = "rdbWarrior"
        Me.rdbWarrior.Size = New System.Drawing.Size(78, 24)
        Me.rdbWarrior.TabIndex = 5
        Me.rdbWarrior.TabStop = True
        Me.rdbWarrior.Text = "Warrior"
        Me.rdbWarrior.UseVisualStyleBackColor = True
        '
        'rdbMage
        '
        Me.rdbMage.AutoSize = True
        Me.rdbMage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMage.Location = New System.Drawing.Point(41, 143)
        Me.rdbMage.Name = "rdbMage"
        Me.rdbMage.Size = New System.Drawing.Size(67, 24)
        Me.rdbMage.TabIndex = 6
        Me.rdbMage.TabStop = True
        Me.rdbMage.Text = "Mage"
        Me.rdbMage.UseVisualStyleBackColor = True
        '
        'rdbRogue
        '
        Me.rdbRogue.AutoSize = True
        Me.rdbRogue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRogue.Location = New System.Drawing.Point(41, 172)
        Me.rdbRogue.Name = "rdbRogue"
        Me.rdbRogue.Size = New System.Drawing.Size(75, 24)
        Me.rdbRogue.TabIndex = 7
        Me.rdbRogue.TabStop = True
        Me.rdbRogue.Text = "Rogue"
        Me.rdbRogue.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 251)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblStatStr
        '
        Me.lblStatStr.AutoSize = True
        Me.lblStatStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatStr.Location = New System.Drawing.Point(218, 123)
        Me.lblStatStr.Name = "lblStatStr"
        Me.lblStatStr.Size = New System.Drawing.Size(65, 15)
        Me.lblStatStr.TabIndex = 9
        Me.lblStatStr.Text = "Strength:"
        '
        'lblStatIntel
        '
        Me.lblStatIntel.AutoSize = True
        Me.lblStatIntel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatIntel.Location = New System.Drawing.Point(197, 152)
        Me.lblStatIntel.Name = "lblStatIntel"
        Me.lblStatIntel.Size = New System.Drawing.Size(86, 15)
        Me.lblStatIntel.TabIndex = 10
        Me.lblStatIntel.Text = "Intelligence:"
        '
        'lblStatAgi
        '
        Me.lblStatAgi.AutoSize = True
        Me.lblStatAgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatAgi.Location = New System.Drawing.Point(234, 177)
        Me.lblStatAgi.Name = "lblStatAgi"
        Me.lblStatAgi.Size = New System.Drawing.Size(49, 15)
        Me.lblStatAgi.TabIndex = 11
        Me.lblStatAgi.Text = "Agility:"
        '
        'lblStr
        '
        Me.lblStr.AutoSize = True
        Me.lblStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStr.Location = New System.Drawing.Point(290, 123)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(14, 15)
        Me.lblStr.TabIndex = 12
        Me.lblStr.Text = "0"
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInt.Location = New System.Drawing.Point(290, 152)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(14, 15)
        Me.lblInt.TabIndex = 13
        Me.lblInt.Text = "0"
        '
        'lblAgi
        '
        Me.lblAgi.AutoSize = True
        Me.lblAgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAgi.Location = New System.Drawing.Point(290, 181)
        Me.lblAgi.Name = "lblAgi"
        Me.lblAgi.Size = New System.Drawing.Size(14, 15)
        Me.lblAgi.TabIndex = 14
        Me.lblAgi.Text = "0"
        '
        'frmCharCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAgi)
        Me.Controls.Add(Me.lblInt)
        Me.Controls.Add(Me.lblStr)
        Me.Controls.Add(Me.lblStatAgi)
        Me.Controls.Add(Me.lblStatIntel)
        Me.Controls.Add(Me.lblStatStr)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rdbRogue)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.rdbMage)
        Me.Controls.Add(Me.rdbWarrior)
        Me.Controls.Add(Me.lblChooseClass)
        Me.Controls.Add(Me.txtChName)
        Me.Controls.Add(Me.grpCharPrev)
        Me.Controls.Add(Me.lblCharName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(715, 324)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(715, 324)
        Me.Name = "frmCharCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Character Creation"
        Me.grpCharPrev.ResumeLayout(False)
        CType(Me.pcbCharPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCharName As Label
    Friend WithEvents grpCharPrev As GroupBox
    Friend WithEvents pcbCharPrev As PictureBox
    Friend WithEvents txtChName As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblChooseClass As Label
    Friend WithEvents rdbWarrior As RadioButton
    Friend WithEvents rdbMage As RadioButton
    Friend WithEvents rdbRogue As RadioButton
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblStatStr As System.Windows.Forms.Label
    Friend WithEvents lblStatIntel As System.Windows.Forms.Label
    Friend WithEvents lblStatAgi As System.Windows.Forms.Label
    Friend WithEvents lblStr As System.Windows.Forms.Label
    Friend WithEvents lblInt As System.Windows.Forms.Label
    Friend WithEvents lblAgi As System.Windows.Forms.Label
End Class
