﻿Public Class frmShop
    Dim total ' Holds the total cost for the player's purchase
    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshShop() ' Updates shop information on startup
    End Sub

    ' Refreshes all the shop's info including appearence
    Sub refreshShop()
        If playerInf.charClass = "Warrior" Then
            pcbPlayer.Image = warIdleL
        ElseIf playerInf.charClass = "Rogue" Then
            pcbPlayer.Image = rogIdleL
        ElseIf playerInf.charClass = "Mage" Then
            pcbPlayer.Image = magIdleL
        End If
        If mapScr.rdbNSShop.Checked = True Then
            chkItem1.Text = "Health Potion (10 G)"
            chkItem2.Text = "Mana Potion (7 G)"
            chkItem3.Text = "Health Potion+ (50 G)"
            chkItem4.Text = "Mana Potion+ (35 G)"
        Else
            ' If no shop is selected, tell the player and return to the map
            MsgBox("There was an error loading the shop, please try again.")
            Hide()
            mapScr.Show()
        End If
        lblGold.Text = "Gold: " & playerInf.moneyAmount
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        If playerInf.moneyAmount - total >= 0 Then ' Verifies player has enough gold
            playerInf.moneyAmount -= total
            lblGold.Text = "Gold: " & playerInf.moneyAmount
            ' Adds the item to an available inventory slot
            For i As Integer = 0 To playerInf.inventory.Length - 1
                If playerInf.inventory(i) = 0 Then
                    If chkItem1.Checked = True Then
                        playerInf.inventory(i) = 14
                        chkItem1.Checked = False
                    Else
                        chkItem1.Checked = False
                    End If
                    If chkItem2.Checked = True And (i + 1) <= playerInf.inventory.Length - 1 Then
                        playerInf.inventory(i + 1) = 16
                        chkItem1.Checked = False
                    Else
                        chkItem2.Checked = False
                    End If
                    If chkItem3.Checked = True And (i + 2) <= playerInf.inventory.Length - 1 Then
                        playerInf.inventory(i + 2) = 15
                        chkItem1.Checked = False
                    Else
                        chkItem3.Checked = False
                    End If
                    If chkItem4.Checked = True And (i + 3) <= playerInf.inventory.Length - 1 Then
                        playerInf.inventory(i + 3) = 17
                        chkItem1.Checked = False
                    Else
                        chkItem4.Checked = False
                    End If
                End If
                If chkItem1.Checked = False And chkItem2.Checked = False Then
                    If chkItem3.Checked = False And chkItem4.Checked = False Then
                        Exit For
                    End If
                End If
            Next
        Else
            MsgBox("You cannot afford to purchase these!")
        End If
    End Sub

    Private Sub chkItem1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItem1.CheckedChanged
        ' Determines total
        If chkItem1.Checked = True Then
            ' Add 10 G to the total if the health potion is checked
            total = total + 10
            Else
            ' Removes 10 G from the total if the health potion is unchecked
            total = total - 10
        End If
        lblTotal.Text = "Total: " & total ' Updates total
    End Sub

    Private Sub chkItem2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItem2.CheckedChanged
        ' Determines total
        If chkItem2.Checked = True Then
            ' Add 7 G to the total if the mana potion is checked
            total = total + 7
        Else
            ' Removes 7 G from the total if the mana potion is unchecked
            total = total - 7
        End If
        lblTotal.Text = "Total: " & total ' Updates total
    End Sub

    Private Sub chkItem3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItem3.CheckedChanged
        ' Determines total
        If chkItem3.Checked = True Then
            ' Add 50 G to the total if the health potion [lus is checked
            total = total + 50
        Else
            ' Removes 50 G from the total if the health potion plus is unchecked
            total = total - 50
        End If
        lblTotal.Text = "Total: " & total ' Updates total
    End Sub

    Private Sub chkItem4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItem4.CheckedChanged
        ' Determines total
        If chkItem4.Checked = True Then
            ' Add 35 G to the total if the mana potion plus is checked
            total = total + 35
        Else
            ' Removes 35 G from the total if the mana potion plus is unchecked
            total = total - 35
        End If
        lblTotal.Text = "Total: " & total ' Updates total
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Returns to the map
        Me.Hide()
        chkItem1.Checked = False
        chkItem2.Checked = False
        chkItem3.Checked = False
        chkItem4.Checked = False
        mapScr.Show()
    End Sub
End Class