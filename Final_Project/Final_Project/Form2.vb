Public Class frmInventory
    Dim scrollValArr(1) As Double
    Dim pnlOrigTopArr(playerInf.inventory.Length - 1) As Integer
    Dim lblOrigTopArr(playerInf.inventory.Length - 1) As Integer
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
        Next
        ReDim Preserve pnlOrigTopArr(playerInf.inventory.Length - 1)
        ReDim Preserve lblOrigTopArr(playerInf.inventory.Length - 1)
        For i As Integer = 0 To playerInf.inventory.Length - 1
            pnlOrigTopArr(i) = CType(pnlInv.Controls("pnlSlot" & i + 1.ToString()), Panel).Top
            lblOrigTopArr(i) = CType(pnlInv.Controls("lblSlot" & i + 1.ToString()), Label).Top
        Next
    End Sub

    Private Sub VInvScrollBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VInvScrollBar.Scroll
        ' Scrolls the inventory slots with the scroll bar by taking the object and moving it in relation to the scroll bar
        scrollValArr(0) = VInvScrollBar.Value
        For i As Integer = 1 To playerInf.inventory.Length
            If scrollValArr(0) > scrollValArr(1) Then
                CType(pnlInv.Controls("pnlSlot" & i.ToString()), Panel).Top = pnlOrigTopArr(i - 1) - VInvScrollBar.Value * 0.1
                CType(pnlInv.Controls("lblSlot" & i.ToString()), Label).Top = lblOrigTopArr(i - 1) - VInvScrollBar.Value * 0.1
                lblmonAmount.Text = "Increase! " & VInvScrollBar.Value.ToString
            Else
                CType(pnlInv.Controls("pnlSlot" & i.ToString()), Panel).Top = pnlOrigTopArr(i - 1) - VInvScrollBar.Value * 0.1
                CType(pnlInv.Controls("lblSlot" & i.ToString()), Label).Top = lblOrigTopArr(i - 1) - VInvScrollBar.Value * 0.1
                lblmonAmount.Text = "Decrease! " & VInvScrollBar.Value.ToString
            End If
        Next
        scrollValArr(1) = VInvScrollBar.Value
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
    Dim counter
End Class