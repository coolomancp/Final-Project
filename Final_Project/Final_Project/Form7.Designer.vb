<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharCreate
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
        Me.grpCharPrev.SuspendLayout()
        CType(Me.pcbCharPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharName
        '
        Me.lblCharName.AutoSize = True
        Me.lblCharName.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName.Location = New System.Drawing.Point(12, 28)
        Me.lblCharName.Name = "lblCharName"
        Me.lblCharName.Size = New System.Drawing.Size(71, 26)
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
        Me.pcbCharPrev.Image = Global.WindowsApplication1.My.Resources.Resources.warIdleR
        Me.pcbCharPrev.Location = New System.Drawing.Point(7, 16)
        Me.pcbCharPrev.Name = "pcbCharPrev"
        Me.pcbCharPrev.Size = New System.Drawing.Size(187, 235)
        Me.pcbCharPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCharPrev.TabIndex = 0
        Me.pcbCharPrev.TabStop = False
        '
        'txtChName
        '
        Me.txtChName.Font = New System.Drawing.Font("Myriad Pro Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChName.Location = New System.Drawing.Point(83, 25)
        Me.txtChName.MaxLength = 25
        Me.txtChName.Name = "txtChName"
        Me.txtChName.Size = New System.Drawing.Size(116, 33)
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
        Me.lblChooseClass.Font = New System.Drawing.Font("Myriad Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseClass.Location = New System.Drawing.Point(12, 75)
        Me.lblChooseClass.Name = "lblChooseClass"
        Me.lblChooseClass.Size = New System.Drawing.Size(64, 26)
        Me.lblChooseClass.TabIndex = 4
        Me.lblChooseClass.Text = "Class:"
        '
        'rdbWarrior
        '
        Me.rdbWarrior.AutoSize = True
        Me.rdbWarrior.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbWarrior.Location = New System.Drawing.Point(41, 114)
        Me.rdbWarrior.Name = "rdbWarrior"
        Me.rdbWarrior.Size = New System.Drawing.Size(76, 23)
        Me.rdbWarrior.TabIndex = 5
        Me.rdbWarrior.TabStop = True
        Me.rdbWarrior.Text = "Warrior"
        Me.rdbWarrior.UseVisualStyleBackColor = True
        '
        'rdbMage
        '
        Me.rdbMage.AutoSize = True
        Me.rdbMage.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMage.Location = New System.Drawing.Point(41, 143)
        Me.rdbMage.Name = "rdbMage"
        Me.rdbMage.Size = New System.Drawing.Size(65, 23)
        Me.rdbMage.TabIndex = 6
        Me.rdbMage.TabStop = True
        Me.rdbMage.Text = "Mage"
        Me.rdbMage.UseVisualStyleBackColor = True
        '
        'rdbRogue
        '
        Me.rdbRogue.AutoSize = True
        Me.rdbRogue.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRogue.Location = New System.Drawing.Point(41, 172)
        Me.rdbRogue.Name = "rdbRogue"
        Me.rdbRogue.Size = New System.Drawing.Size(71, 23)
        Me.rdbRogue.TabIndex = 7
        Me.rdbRogue.TabStop = True
        Me.rdbRogue.Text = "Rogue"
        Me.rdbRogue.UseVisualStyleBackColor = True
        '
        'frmCharCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 286)
        Me.Controls.Add(Me.rdbRogue)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.rdbMage)
        Me.Controls.Add(Me.rdbWarrior)
        Me.Controls.Add(Me.lblChooseClass)
        Me.Controls.Add(Me.txtChName)
        Me.Controls.Add(Me.grpCharPrev)
        Me.Controls.Add(Me.lblCharName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
End Class
