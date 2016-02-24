Public Class frmCharCreate
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim validInp1 As Boolean = txtChName.Text Like "[A-Z]*[A-Z]" ' Allows name to be upper case
        Dim validInp2 As Boolean = txtChName.Text Like "[a-z]*[a-z]" ' Allows name to be lower case
        Dim validInp3 As Boolean = txtChName.Text Like "[A-Z]*[a-z]" ' Allows name to start upper case and end lower case
        Dim validInp4 As Boolean = txtChName.Text Like "[a-z]*[A-Z]" ' Allows name to start lower case and end upper case
        Dim wasValid As Boolean
        If validInp1 = True Or validInp2 = True Or validInp3 = True Or validInp4 = True And txtChName.Text IsNot "" Then 'Prevents user from entering an invalid name
            playerInf.name = txtChName.Text
            wasValid = True
        Else
            txtChName.Clear()
            MessageBox.Show("Please only enter letters (A-Z)")
            wasValid = False
        End If
        If wasValid = True Then
            Me.Hide()
            mainScr.Show()
        End If
    End Sub

    Private Sub rdbWarrior_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWarrior.CheckedChanged
        pcbCharPrev.Image = My.Resources.warIdleR
        playerInf.charClass = "Warrior"
        playerInf.HP = 100
        playerInf.HPM = 100
        playerInf.MP = 50
        playerInf.MPM = 50
        playerInf.strength = 5
        playerInf.intelligence = 2
        playerInf.agility = 3
        playerInf.level = 1
        playerInf.activeBracers = "(none)"
        playerInf.activeChest = "(none)"
        playerInf.activeGloves = "(none)"
        playerInf.activeHelm = "(none)"
        playerInf.activeLegs = "(none)"
        playerInf.activeWepL = "(none)"
        playerInf.activeWepR = "(none)"
        playerInf.moneyAmount = 0
        lblStr.Text = playerInf.strength
        lblInt.Text = playerInf.intelligence
        lblAgi.Text = playerInf.agility
    End Sub

    Private Sub rdbMage_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMage.CheckedChanged
        pcbCharPrev.Image = My.Resources.magFlyL1
        playerInf.charClass = "Mage"
        playerInf.HP = 75
        playerInf.HPM = 75
        playerInf.MP = 80
        playerInf.MPM = 80
        playerInf.strength = 2
        playerInf.intelligence = 5
        playerInf.agility = 3
        playerInf.level = 1
        playerInf.activeBracers = "(none)"
        playerInf.activeChest = "(none)"
        playerInf.activeGloves = "(none)"
        playerInf.activeHelm = "(none)"
        playerInf.activeLegs = "(none)"
        playerInf.activeWepL = "(none)"
        playerInf.activeWepR = "(none)"
        playerInf.moneyAmount = 0
        lblStr.Text = playerInf.strength
        lblInt.Text = playerInf.intelligence
        lblAgi.Text = playerInf.agility
    End Sub

    Private Sub rdbRogue_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRogue.CheckedChanged
        pcbCharPrev.Image = My.Resources.rogIdleR
        playerInf.charClass = "Rogue"
        playerInf.HP = 75
        playerInf.HPM = 75
        playerInf.MP = 65
        playerInf.MPM = 65
        playerInf.strength = 3
        playerInf.intelligence = 2
        playerInf.agility = 5
        playerInf.level = 1
        playerInf.activeBracers = "(none)"
        playerInf.activeChest = "(none)"
        playerInf.activeGloves = "(none)"
        playerInf.activeHelm = "(none)"
        playerInf.activeLegs = "(none)"
        playerInf.activeWepL = "(none)"
        playerInf.activeWepR = "(none)"
        playerInf.moneyAmount = 0
        lblStr.Text = playerInf.strength
        lblInt.Text = playerInf.intelligence
        lblAgi.Text = playerInf.agility
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        frmLaunchScr.Show()
    End Sub
End Class