Imports System.IO

Public Class frmCharScreen
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Sets all of the comboboxes starting text to the player's current equipment
        cboBracer.Text = playerInf.activeBracers
        cboChest.Text = playerInf.activeChest
        cboGloves.Text = playerInf.activeGloves
        cboHead.Text = playerInf.activeHelm
        cboLegs.Text = playerInf.activeLegs
        cboLHand.Text = playerInf.activeWepL
        cboRHand.Text = playerInf.activeWepR
        ' Updates all of the player's stats
        lblDPSVal.Text = "WIP"
        lblArmorVal.Text = "WIP"
        lblStrVal.Text = Convert.ToString(playerInf.strength)
        lblIntelVal.Text = Convert.ToString(playerInf.intelligence)
        lblAgiVal.Text = Convert.ToString(playerInf.agility)
        lblHPVal.Text = "(" & Convert.ToString(playerInf.HP) & "/" & Convert.ToString(playerInf.HPM) & ")"
        lblManaVal.Text = "(" & Convert.ToString(playerInf.MP) & "/" & Convert.ToString(playerInf.MPM) & ")"
        lblCNVal.Text = playerInf.name
        lblLvl.Text = playerInf.level
        ' Updates progress bars to reflect the player's current HP and MP values
        proBarHealthVal.Value = (playerInf.HP \ playerInf.HPM) * 100
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

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        ' Saves player information into a txt file in a saves folder
        'File.WriteAllText(resPath & "\Saves\" & Convert.ToString(playerInf.name & ".txt"), "")
        'Dim save() As String = {playerInf.name, playerInf.HP, playerInf.HPM, playerInf.MP, playerInf.MPM, playerInf.strength, playerInf.intelligence, playerInf.agility, playerInf.activeBracers, playerInf.activeChest, playerInf.activeGloves, playerInf.activeHelm, playerInf.activeLegs, playerInf.activeWepL, playerInf.activeWepR, playerInf.charClass, playerInf.level, playerInf.moneyAmount, playerInf.charX, playerInf.charY, playerInf.dungeonID, playerInf.dungeonRM}
        'File.AppendAllLines(resPath & "\Saves\" & Convert.ToString(playerInf.name & ".txt"), save)
        MsgBox("WIP; May be removed")
    End Sub

    Private Sub cboLHand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLHand.SelectedIndexChanged
        If cboLHand.Text = "(none)" Then
            pcbHandL.Image = My.Resources.SwordL
        ElseIf cboLHand.Text = "Debug" Then
            pcbHandL.Image = debugImg
        Else
            changeItemImage(cboLHand.Text)
        End If
    End Sub

    Private Sub cboRHand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRHand.SelectedIndexChanged
        If cboRHand.Text = "(none)" Then
            pcbHandR.Image = My.Resources.SwordR
        ElseIf cboRHand.Text = "Debug" Then
            pcbHandR.Image = debugImg
        Else
            changeItemImage(cboRHand.Text)
        End If
    End Sub

    Private Sub cboHead_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHead.SelectedIndexChanged
        If cboHead.Text = "(none)" Then
            pcbHelm.Image = My.Resources.Helm
        ElseIf cboHead.Text = "Debug" Then
            pcbHelm.Image = debugImg
        Else
            changeItemImage(cboHead.Text)
        End If
    End Sub

    Private Sub cboGloves_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGloves.SelectedIndexChanged
        If cboGloves.Text = "(none)" Then
            pcbGloves.Image = My.Resources.Gloves
        ElseIf cboGloves.Text = "Debug" Then
            pcbGloves.Image = debugImg
        Else
            changeItemImage(cboGloves.Text)
        End If
    End Sub

    Private Sub cboChest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChest.SelectedIndexChanged
        If cboChest.Text = "(none)" Then
            pcbChest.Image = My.Resources.Chest
        ElseIf cboChest.Text = "Debug" Then
            pcbChest.Image = debugImg
        Else
            changeItemImage(cboChest.Text)
        End If
    End Sub

    Private Sub cboBracer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBracer.SelectedIndexChanged
        If cboBracer.Text = "(none)" Then
            pcbBracer.Image = My.Resources.Bracer
        ElseIf cboBracer.Text = "Debug" Then
            pcbBracer.Image = debugImg
        Else
            changeItemImage(cboBracer.Text)
        End If
    End Sub

    Private Sub cboLegs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLegs.SelectedIndexChanged
        If cboLegs.Text = "(none)" Then
            pcbLegs.Image = My.Resources.Legs
        ElseIf cboLegs.Text = "Debug" Then
            pcbLegs.Image = debugImg
        Else
            changeItemImage(cboLegs.Text)
        End If
    End Sub

    Sub changeItemImage(ByVal item)
        If item = "Basic Dagger" Then
            pcbHandL.Image = rogBasDagL
            pcbHandR.Image = rogBasDagR
        ElseIf item = "Worn Helm" Then
            pcbHelm.Image = rogBasHelm
        End If
    End Sub

    Sub changePlayerStats(ByVal item)
        If revItemIndex(item) = 1 Then
            wepStats.str = 1
            wepStats.agi = 2
            wepStats.int = 1
            wepStats.damage = 10
        ElseIf revItemIndex(item) = 2 Then

        End If
    End Sub
End Class
