﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCharI = New System.Windows.Forms.Button()
        Me.btnInv = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tmrAnim = New System.Windows.Forms.Timer(Me.components)
        Me.pcbPlayer2 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer4 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer3 = New System.Windows.Forms.PictureBox()
        Me.pcbPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picMainScr = New System.Windows.Forms.PictureBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.pnlMenu.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.pcbPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainScr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlMenu.Controls.Add(Me.lblTest)
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.btnCharI)
        Me.pnlMenu.Controls.Add(Me.btnInv)
        Me.pnlMenu.Location = New System.Drawing.Point(12, 433)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(700, 100)
        Me.pnlMenu.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(605, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Game"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCharI
        '
        Me.btnCharI.Font = New System.Drawing.Font("Myriad Web Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharI.Location = New System.Drawing.Point(605, 27)
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
        Me.pnlMain.Controls.Add(Me.pcbPlayer2)
        Me.pnlMain.Controls.Add(Me.pcbPlayer4)
        Me.pnlMain.Controls.Add(Me.pcbPlayer3)
        Me.pnlMain.Controls.Add(Me.pcbPlayer1)
        Me.pnlMain.Controls.Add(Me.picMainScr)
        Me.pnlMain.Location = New System.Drawing.Point(13, 12)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(699, 415)
        Me.pnlMain.TabIndex = 3
        '
        'tmrAnim
        '
        Me.tmrAnim.Interval = 200
        '
        'pcbPlayer2
        '
        Me.pcbPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer2.Image = Global.WindowsApplication1.My.Resources.Resources.warWalkL2
        Me.pcbPlayer2.Location = New System.Drawing.Point(0, 330)
        Me.pcbPlayer2.Name = "pcbPlayer2"
        Me.pcbPlayer2.Size = New System.Drawing.Size(56, 67)
        Me.pcbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlayer2.TabIndex = 5
        Me.pcbPlayer2.TabStop = False
        Me.pcbPlayer2.Visible = False
        '
        'pcbPlayer4
        '
        Me.pcbPlayer4.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer4.Image = Global.WindowsApplication1.My.Resources.Resources.warWalkL4
        Me.pcbPlayer4.Location = New System.Drawing.Point(0, 330)
        Me.pcbPlayer4.Name = "pcbPlayer4"
        Me.pcbPlayer4.Size = New System.Drawing.Size(56, 67)
        Me.pcbPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlayer4.TabIndex = 4
        Me.pcbPlayer4.TabStop = False
        Me.pcbPlayer4.Visible = False
        '
        'pcbPlayer3
        '
        Me.pcbPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer3.Image = Global.WindowsApplication1.My.Resources.Resources.warWalkL3
        Me.pcbPlayer3.Location = New System.Drawing.Point(0, 330)
        Me.pcbPlayer3.Name = "pcbPlayer3"
        Me.pcbPlayer3.Size = New System.Drawing.Size(56, 67)
        Me.pcbPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlayer3.TabIndex = 3
        Me.pcbPlayer3.TabStop = False
        Me.pcbPlayer3.Visible = False
        '
        'pcbPlayer1
        '
        Me.pcbPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbPlayer1.Image = Global.WindowsApplication1.My.Resources.Resources.warWalkL1
        Me.pcbPlayer1.Location = New System.Drawing.Point(0, 330)
        Me.pcbPlayer1.Name = "pcbPlayer1"
        Me.pcbPlayer1.Size = New System.Drawing.Size(56, 67)
        Me.pcbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlayer1.TabIndex = 2
        Me.pcbPlayer1.TabStop = False
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
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(17, 27)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(42, 13)
        Me.lblTest.TabIndex = 5
        Me.lblTest.Text = "Testing"
        '
        'frmMainScr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(724, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 584)
        Me.Name = "frmMainScr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Screen"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.pcbPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainScr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnCharI As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents picMainScr As PictureBox
    Friend WithEvents pcbPlayer1 As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents tmrAnim As Timer
    Friend WithEvents pcbPlayer2 As PictureBox
    Friend WithEvents pcbPlayer4 As PictureBox
    Friend WithEvents pcbPlayer3 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTest As Label
End Class