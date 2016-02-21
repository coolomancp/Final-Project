Imports System.IO

Public Class frmCharScreen
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(playerInf.HP)
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
    End Sub

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Dim save() As String = {playerInf.name, playerInf.HP, playerInf.HPM, playerInf.MP, playerInf.MPM, playerInf.strength, playerInf.intelligence, playerInf.agility, playerInf.activeBracers, playerInf.activeChest, playerInf.activeGloves, playerInf.activeHelm, playerInf.activeLegs, playerInf.activeWepL, playerInf.activeWepR, playerInf.charClass, playerInf.level}
        File.AppendAllLines(resPath & "Saves\" & Convert.ToString(playerInf.name & ".txt"), save)
    End Sub

    Private Sub btnConfirmNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
