﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExitWarning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExitWarning))
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lblSaveWarn = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Myriad Web Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.Location = New System.Drawing.Point(99, 30)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(166, 14)
        Me.lblWarning.TabIndex = 0
        Me.lblWarning.Text = "Are you sure you want to exit?"
        '
        'lblSaveWarn
        '
        Me.lblSaveWarn.AutoSize = True
        Me.lblSaveWarn.Font = New System.Drawing.Font("Myriad Web Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveWarn.Location = New System.Drawing.Point(64, 42)
        Me.lblSaveWarn.Name = "lblSaveWarn"
        Me.lblSaveWarn.Size = New System.Drawing.Size(237, 14)
        Me.lblSaveWarn.TabIndex = 1
        Me.lblSaveWarn.Text = "(Your game data will be saved upon exiting)"
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Myriad Web Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(14, 81)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(87, 21)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Myriad Web Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(261, 81)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(87, 21)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "[Room progress is not saved]"
        '
        'frmExitWarning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 125)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblSaveWarn)
        Me.Controls.Add(Me.lblWarning)
        Me.Font = New System.Drawing.Font("Myriad Web Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(379, 153)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(379, 153)
        Me.Name = "frmExitWarning"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exit Warning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWarning As Label
    Friend WithEvents lblSaveWarn As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
