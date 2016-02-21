Imports System.IO

Public Class frmCharScreen
    Dim playerInf As playerInfo
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox(playerInf.HP)
    End Sub

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Dim save() As String = {playerInf.name, playerInf.HP, playerInf.HPM, playerInf.MP, playerInf.MPM, playerInf.strength, playerInf.intelligence, playerInf.agility, playerInf.activeBracers, playerInf.activeChest, playerInf.activeGloves, playerInf.activeHelm, playerInf.activeLegs, playerInf.activeWepL, playerInf.activeWepR, playerInf.charClass}
        File.AppendAllLines(resPath & "Saves\" & Convert.ToString(playerInf.name & ".txt"), save)
    End Sub

    Private Sub btnConfirmNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmNC.Click
        Dim validInp1 As Boolean = txtChngCN.Text Like "[A-Z]*[A-Z]" ' Allows name to be upper case
        Dim validInp2 As Boolean = txtChngCN.Text Like "[a-z]*[a-z]" ' Allows name to be lower case
        Dim validInp3 As Boolean = txtChngCN.Text Like "[A-Z]*[a-z]" ' Allows name to start upper case and end lower case
        Dim validInp4 As Boolean = txtChngCN.Text Like "[a-z]*[A-Z]" ' Allows name to start lower case and end upper case
        If validInp1 = True Or validInp2 = True Or validInp3 = True Or validInp4 = True And txtChngCN.Text IsNot "" Then 'Prevents user from entering an invalid name
            lblCNVal.Text = txtChngCN.Text
            playerInf.name = txtChngCN.Text
            txtChngCN.Clear()
        Else
            txtChngCN.Clear()
            MessageBox.Show("Please only enter letters (A-Z)")
        End If
    End Sub

    Private Sub recHealthBarV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
