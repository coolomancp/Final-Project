Public Class frmInventory
    Dim changeDetect As Integer
    Private Sub frmInventory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        RefreshInv() ' Update the form
    End Sub

    ' This procedure updates the information on the form to reflect new changes
    Sub RefreshInv()
        lblmonAmount.Text = playerInf.moneyAmount ' Updates money
        For i As Integer = 1 To playerInf.inventory.Length
            ' Updates inventory slots. CType used to allow dynamic inventory, and save space
            setInventorySlots(CType(CType(pnlInv.Controls("pnlSlot" & i.ToString), Panel).Controls("pcbSlot" & i.ToString()), PictureBox), i - 1)
            ' Updates labels to items
            setInventoryLabel(CType(pnlInv.Controls("lblSlot" & i.ToString), Label), i - 1)
            ' Adjusts labels so they line up with panels
            If CType(pnlInv.Controls("lblSlot" & i.ToString), Label).Text <> "Empty" Then
                CType(pnlInv.Controls("lblSlot" & i.ToString), Label).Left = CType(pnlInv.Controls("lblSlot" & i.ToString), Label).Left - ((CType(pnlInv.Controls("lblSlot" & i.ToString), Label).Text.Length) / 1.5)
            End If
            lblSlot1.Text = lblSlot1.Top.ToString
        Next
    End Sub

    Private Sub VInvScrollBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VInvScrollBar.Scroll
        ' Scrolls the inventory slots with the scroll bar by taking the object and moving it in relation to the scroll bar
        Dim counter As Integer
        For i As Integer = 1 To playerInf.inventory.Length
            If VInvScrollBar.Value < changeDetect Then
                CType(pnlInv.Controls("pnlSlot" & i.ToString()), Panel).Top = CType(pnlInv.Controls("pnlSlot" & i.ToString()), Panel).Top - VInvScrollBar.Value * 0.5
                CType(pnlInv.Controls("lblSlot" & i.ToString()), Label).Top = CType(pnlInv.Controls("lblSlot" & i.ToString()), Label).Top - VInvScrollBar.Value * 0.5
            Else
                CType(pnlInv.Controls("pnlSlot" & i.ToString()), Panel).Top = CType(pnlInv.Controls("pnlSlot" & i.ToString()), Panel).Top + VInvScrollBar.Value * 0.5
                CType(pnlInv.Controls("lblSlot" & i.ToString()), Label).Top = CType(pnlInv.Controls("lblSlot" & i.ToString()), Label).Top + VInvScrollBar.Value * 0.5
            End If
        Next
    End Sub

    Private Sub VInvScrollBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VInvScrollBar.ValueChanged
        changeDetect = VInvScrollBar.Value
    End Sub
    ' Pre: Takes in the picturebox object as picBox and the index of the inventory slot
    ' Post: Outputs the corresponding image to the picturbox
    Sub setInventorySlots(ByRef picBox As PictureBox, ByVal index As Integer)
        If playerInf.inventory(index) = 4 Then ' Checks for special items with class varients
            If playerInf.charClass = "Warrior" Then
                picBox.Image = items(playerInf.inventory(index)).imageVar
            ElseIf playerInf.charClass = "Rogue" Then
                picBox.Image = items(playerInf.inventory(index)).image
            ElseIf playerInf.charClass = "Mage" Then
                picBox.Image = items(playerInf.inventory(index)).imageVar2
            End If
        Else
            picBox.Image = items(playerInf.inventory(index)).image
        End If
        ' If no image has been implemented, fill with the placeholder image
        If picBox.Image Is Nothing Then
            picBox.Image = phImg
        End If
    End Sub

    ' Pre: Takes in what item is in the inventory slot(index), and what label to change
    ' Post: Updates label to reflect the item in the slot
    Sub setInventoryLabel(ByRef label As Label, ByVal index As Integer)
        label.Text = itemIndex(playerInf.inventory(index))
    End Sub
End Class