<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShop
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
        Me.pcbPlayer = New System.Windows.Forms.PictureBox()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.pnlShopItems = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.chkItem4 = New System.Windows.Forms.CheckBox()
        Me.chkItem3 = New System.Windows.Forms.CheckBox()
        Me.chkItem2 = New System.Windows.Forms.CheckBox()
        Me.chkItem1 = New System.Windows.Forms.CheckBox()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.pcbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlShopItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbPlayer
        '
        Me.pcbPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pcbPlayer.Image = Global.WindowsApplication1.My.Resources.Resources.rogIdleL
        Me.pcbPlayer.Location = New System.Drawing.Point(523, 232)
        Me.pcbPlayer.Name = "pcbPlayer"
        Me.pcbPlayer.Size = New System.Drawing.Size(170, 152)
        Me.pcbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlayer.TabIndex = 0
        Me.pcbPlayer.TabStop = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.Transparent
        Me.btnBuy.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnDefault
        Me.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuy.Location = New System.Drawing.Point(350, 293)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 1
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'pnlShopItems
        '
        Me.pnlShopItems.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnInv
        Me.pnlShopItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlShopItems.Controls.Add(Me.lblTotal)
        Me.pnlShopItems.Controls.Add(Me.chkItem4)
        Me.pnlShopItems.Controls.Add(Me.chkItem3)
        Me.pnlShopItems.Controls.Add(Me.chkItem2)
        Me.pnlShopItems.Controls.Add(Me.chkItem1)
        Me.pnlShopItems.Location = New System.Drawing.Point(237, 137)
        Me.pnlShopItems.Name = "pnlShopItems"
        Me.pnlShopItems.Size = New System.Drawing.Size(188, 150)
        Me.pnlShopItems.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Location = New System.Drawing.Point(100, 128)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'chkItem4
        '
        Me.chkItem4.AutoSize = True
        Me.chkItem4.BackColor = System.Drawing.Color.Transparent
        Me.chkItem4.ForeColor = System.Drawing.SystemColors.Control
        Me.chkItem4.Location = New System.Drawing.Point(14, 109)
        Me.chkItem4.Name = "chkItem4"
        Me.chkItem4.Size = New System.Drawing.Size(73, 17)
        Me.chkItem4.TabIndex = 3
        Me.chkItem4.Text = "[ ITEM 4 ]"
        Me.chkItem4.UseVisualStyleBackColor = False
        '
        'chkItem3
        '
        Me.chkItem3.AutoSize = True
        Me.chkItem3.BackColor = System.Drawing.Color.Transparent
        Me.chkItem3.ForeColor = System.Drawing.SystemColors.Control
        Me.chkItem3.Location = New System.Drawing.Point(14, 77)
        Me.chkItem3.Name = "chkItem3"
        Me.chkItem3.Size = New System.Drawing.Size(73, 17)
        Me.chkItem3.TabIndex = 2
        Me.chkItem3.Text = "[ ITEM 3 ]"
        Me.chkItem3.UseVisualStyleBackColor = False
        '
        'chkItem2
        '
        Me.chkItem2.AutoSize = True
        Me.chkItem2.BackColor = System.Drawing.Color.Transparent
        Me.chkItem2.ForeColor = System.Drawing.SystemColors.Control
        Me.chkItem2.Location = New System.Drawing.Point(14, 45)
        Me.chkItem2.Name = "chkItem2"
        Me.chkItem2.Size = New System.Drawing.Size(73, 17)
        Me.chkItem2.TabIndex = 1
        Me.chkItem2.Text = "[ ITEM 2 ]"
        Me.chkItem2.UseVisualStyleBackColor = False
        '
        'chkItem1
        '
        Me.chkItem1.AutoSize = True
        Me.chkItem1.BackColor = System.Drawing.Color.Transparent
        Me.chkItem1.ForeColor = System.Drawing.SystemColors.Control
        Me.chkItem1.Location = New System.Drawing.Point(14, 10)
        Me.chkItem1.Name = "chkItem1"
        Me.chkItem1.Size = New System.Drawing.Size(73, 17)
        Me.chkItem1.TabIndex = 0
        Me.chkItem1.Text = "[ ITEM 1 ]"
        Me.chkItem1.UseVisualStyleBackColor = False
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.BackColor = System.Drawing.Color.Transparent
        Me.lblGold.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGold.ForeColor = System.Drawing.Color.Gold
        Me.lblGold.Location = New System.Drawing.Point(817, 9)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(155, 21)
        Me.lblGold.TabIndex = 3
        Me.lblGold.Text = "Gold: [Amount]"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.btnChaIn
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(896, 426)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.shop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.pnlShopItems)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.pcbPlayer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShop"
        Me.Text = "Shop"
        CType(Me.pcbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlShopItems.ResumeLayout(False)
        Me.pnlShopItems.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbPlayer As PictureBox
    Friend WithEvents btnBuy As Button
    Friend WithEvents pnlShopItems As Panel
    Friend WithEvents chkItem4 As CheckBox
    Friend WithEvents chkItem3 As CheckBox
    Friend WithEvents chkItem2 As CheckBox
    Friend WithEvents chkItem1 As CheckBox
    Friend WithEvents lblGold As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBack As Button
End Class
