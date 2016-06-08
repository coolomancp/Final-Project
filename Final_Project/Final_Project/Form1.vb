Imports System.IO

Public Class frmCharScreen
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCharInf()
    End Sub

    Private Sub btnUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpd.Click
        ' Updates stats
        RefreshCharInf()
    End Sub

    Private Sub cboLHand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLHand.SelectedIndexChanged
        changeItem(cboLHand.Text, pcbHandL, "HandL")
        RefreshCharInf()
    End Sub

    Private Sub cboRHand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRHand.SelectedIndexChanged
        changeItem(cboRHand.Text, pcbHandR, "HandR")
        RefreshCharInf()
    End Sub

    Private Sub cboHead_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHead.SelectedIndexChanged
        changeItem(cboHead.Text, pcbHelm, "Head")
        RefreshCharInf()
    End Sub

    Private Sub cboGloves_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGloves.SelectedIndexChanged
        changeItem(cboGloves.Text, pcbGloves, "Gloves")
        RefreshCharInf()
    End Sub

    Private Sub cboChest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChest.SelectedIndexChanged
        changeItem(cboChest.Text, pcbChest, "Chest")
        RefreshCharInf()
    End Sub

    Private Sub cboBracer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBracer.SelectedIndexChanged
        changeItem(cboBracer.Text, pcbBracer, "Bracers")
        RefreshCharInf()
    End Sub

    Private Sub cboLegs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLegs.SelectedIndexChanged
        changeItem(cboLegs.Text, pcbLegs, "Legs")
        RefreshCharInf()
    End Sub
    ' Pre: Takes in item's string name, the picturebox that corresponds with it and the matching active item type
    ' Post: Changes the picture box's picture to match the current item selected, and updates player's active item to match
    Sub changeItem(ByVal item As String, ByRef pcb As PictureBox, ByRef active As String)
        If items(revItemIndex(item)).image Is Nothing Then ' Temp check for no asset to prevent crash
        Else
            pcb.Image = items(revItemIndex(item)).image ' Changes picturebox to item's image
        End If
        ' Sets the corresponding item to an active slot
        If active = "HandL" Then
            playerInf.activeWepL = items(revItemIndex(item)).ID
        ElseIf active = "HandR" Then
            playerInf.activeWepR = items(revItemIndex(item)).ID
        ElseIf active = "Head" Then
            playerInf.activeHelm = items(revItemIndex(item)).ID
        ElseIf active = "Chest" Then
            playerInf.activeChest = items(revItemIndex(item)).ID
        ElseIf active = "Gloves" Then
            playerInf.activeGloves = items(revItemIndex(item)).ID
        ElseIf active = "Bracers" Then
            playerInf.activeBracers = items(revItemIndex(item)).ID
        ElseIf active = "Legs" Then
            playerInf.activeLegs = items(revItemIndex(item)).ID
        End If
    End Sub
    Public Sub RefreshCharInf()
        ' Sets all of the comboboxes starting text to the player's current equipment
        cboBracer.Text = playerInf.activeBracers
        cboChest.Text = playerInf.activeChest
        cboGloves.Text = playerInf.activeGloves
        cboHead.Text = playerInf.activeHelm
        cboLegs.Text = playerInf.activeLegs
        cboLHand.Text = playerInf.activeWepL
        cboRHand.Text = playerInf.activeWepR
        ' Updates all of the player's stats
        lblDPSVal.Text = items(playerInf.activeWepL).dmg + items(playerInf.activeWepR).dmg + (20 + playerInf.level)
        lblArmorVal.Text = items(playerInf.activeBracers).armor + items(playerInf.activeChest).armor + items(playerInf.activeGloves).armor + items(playerInf.activeHelm).armor + items(playerInf.activeLegs).armor
        lblStrVal.Text = Convert.ToString(playerInf.strength)
        lblIntelVal.Text = Convert.ToString(playerInf.intelligence)
        lblAgiVal.Text = Convert.ToString(playerInf.agility)
        lblHPVal.Text = "(" & Convert.ToString(playerInf.HP) & "/" & Convert.ToString(playerInf.HPM) & ")"
        lblManaVal.Text = "(" & Convert.ToString(playerInf.MP) & "/" & Convert.ToString(playerInf.MPM) & ")"
        lblCNVal.Text = playerInf.name
        lblLvl.Text = playerInf.level
        ' Updates progress bars to reflect the player's current HP and MP values
        proBarHealthVal.Value = (playerInf.HP / playerInf.HPM) * 100
        proBarManaVal.Value = (playerInf.MP \ playerInf.MPM) * 100
        ' Sets active weapons
        cboRHand.Text = itemIndex(playerInf.activeWepR)
        cboLHand.Text = itemIndex(playerInf.activeWepL)
        cboHead.Text = itemIndex(playerInf.activeHelm)
        cboChest.Text = itemIndex(playerInf.activeChest)
        cboLegs.Text = itemIndex(playerInf.activeLegs)
        cboGloves.Text = itemIndex(playerInf.activeGloves)
        cboBracer.Text = itemIndex(playerInf.activeBracers)
    End Sub
End Class
