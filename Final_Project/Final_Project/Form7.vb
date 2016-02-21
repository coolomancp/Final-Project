Public Class frmCharCreate
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim validInp1 As Boolean = txtChName.Text Like "[A-Z]*[A-Z]" ' Allows name to be upper case
        Dim validInp2 As Boolean = txtChName.Text Like "[a-z]*[a-z]" ' Allows name to be lower case
        Dim validInp3 As Boolean = txtChName.Text Like "[A-Z]*[a-z]" ' Allows name to start upper case and end lower case
        Dim validInp4 As Boolean = txtChName.Text Like "[a-z]*[A-Z]" ' Allows name to start lower case and end upper case
        If validInp1 = True Or validInp2 = True Or validInp3 = True Or validInp4 = True And txtChName.Text IsNot "" Then 'Prevents user from entering an invalid name
            playerInf.name = txtChName.Text
        Else
            txtChName.Clear()
            MessageBox.Show("Please only enter letters (A-Z)")
        End If
        Me.Hide()
        mainScr.Show()
    End Sub

    Private Sub rdbWarrior_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWarrior.CheckedChanged
        pcbCharPrev.Image = My.Resources.warIdleR
        playerInf.charClass = "Warrior"
    End Sub

    Private Sub rdbMage_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMage.CheckedChanged
        pcbCharPrev.Image = My.Resources.magFlyL1
        playerInf.charClass = "Mage"
    End Sub

    Private Sub rdbRogue_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRogue.CheckedChanged
        pcbCharPrev.Image = My.Resources.rogIdleR
        playerInf.charClass = "Rogue"
    End Sub
End Class