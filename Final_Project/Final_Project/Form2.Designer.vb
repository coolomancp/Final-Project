<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblmonAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(13, 416)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(58, 16)
        Me.lblMoney.TabIndex = 0
        Me.lblMoney.Text = "Money:"
        '
        'lblmonAmount
        '
        Me.lblmonAmount.AutoSize = True
        Me.lblmonAmount.Location = New System.Drawing.Point(69, 419)
        Me.lblmonAmount.Name = "lblmonAmount"
        Me.lblmonAmount.Size = New System.Drawing.Size(13, 13)
        Me.lblmonAmount.TabIndex = 1
        Me.lblmonAmount.Text = "0"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblmonAmount)
        Me.Controls.Add(Me.lblMoney)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(451, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(451, 480)
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMoney As Label
    Friend WithEvents lblmonAmount As Label
End Class
