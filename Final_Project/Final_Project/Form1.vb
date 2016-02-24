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
    End Sub

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        ' Saves player information into a txt file in a saves folder
        File.WriteAllText(resPath & "Saves\" & Convert.ToString(playerInf.name & ".txt"), "")
        Dim save() As String = {playerInf.name, playerInf.HP, playerInf.HPM, playerInf.MP, playerInf.MPM, playerInf.strength, playerInf.intelligence, playerInf.agility, playerInf.activeBracers, playerInf.activeChest, playerInf.activeGloves, playerInf.activeHelm, playerInf.activeLegs, playerInf.activeWepL, playerInf.activeWepR, playerInf.charClass, playerInf.level, playerInf.moneyAmount, playerInf.charX, playerInf.charY, playerInf.dungeonID, playerInf.dungeonRM}
        File.AppendAllLines(resPath & "Saves\" & Convert.ToString(playerInf.name & ".txt"), save)
    End Sub
End Class
