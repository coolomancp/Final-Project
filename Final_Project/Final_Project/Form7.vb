Imports System.IO
Public Class frmCharCreate
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim validInp1 As Boolean = txtChName.Text Like "[A-Z]*[A-Z]" ' Allows name to be upper case
        Dim validInp2 As Boolean = txtChName.Text Like "[a-z]*[a-z]" ' Allows name to be lower case
        Dim validInp3 As Boolean = txtChName.Text Like "[A-Z]*[a-z]" ' Allows name to start upper case and end lower case
        Dim validInp4 As Boolean = txtChName.Text Like "[a-z]*[A-Z]" ' Allows name to start lower case and end upper case
        Dim wasValid As Boolean
        ' Determines if name is valid (rules above)
        If validInp1 = True Or validInp2 = True Or validInp3 = True Or validInp4 = True And txtChName.Text IsNot "" Then
            ' Determines if the name has already been used
            If File.Exists(resPath & "\Saves\" & txtChName.Text & ".txt") = False Then
                playerInf.name = txtChName.Text
                wasValid = True
            ElseIf File.Exists(resPath & "\Saves\" & txtChName.Text & ".txt") = True Then
                txtChName.Clear()
                MessageBox.Show("A character with this name already exists, please choose a different name.")
                wasValid = False
            End If
        Else
            txtChName.Clear()
            MessageBox.Show("Please only enter letters (A-Z)")
            wasValid = False
        End If
        If wasValid = True Then
            ' If the name is valid, the user may progress to the game start
            If rdbWarrior.Checked = True Then
                frmCharScreen.cboRHand.Items.Add("Basic Axe RH")
                frmCharScreen.cboLHand.Items.Add("Basic Axe LH")
            ElseIf rdbRogue.Checked = True Then
                frmCharScreen.cboRHand.Items.Add("Basic Dagger")
                frmCharScreen.cboLHand.Items.Add("Basic Dagger")
            ElseIf rdbMage.Checked = True Then
                frmCharScreen.cboRHand.Items.Add("Old Wand")
            End If
            Me.Hide()
            mainScr.Show()
        End If
    End Sub

    Private Sub rdbWarrior_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbWarrior.CheckedChanged
        ' Sets variables to reflect the warrior class
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
        playerInf.exp = 0
        playerInf.activeBracers = "wornBracers"
        playerInf.activeChest = "wornChestplate"
        playerInf.activeGloves = "wornGloves"
        playerInf.activeHelm = "wornHelm"
        playerInf.activeLegs = "wornLegPlate"
        playerInf.activeWepL = "basicAxe"
        playerInf.activeWepR = "basicAxe"
        playerInf.moneyAmount = 0
        playerInf.dungeonID = 1
        playerInf.dungeonRM = 1
        ReDim playerInf.inventory(11)
        lblStr.Text = playerInf.strength
        lblInt.Text = playerInf.intelligence
        lblAgi.Text = playerInf.agility
    End Sub

    Private Sub rdbMage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbMage.CheckedChanged
        ' Sets variables to reflect the mage class
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
        playerInf.activeBracers = "wornBracers"
        playerInf.activeChest = "wornDress"
        playerInf.activeGloves = "wornGloves"
        playerInf.activeHelm = "wornHat"
        playerInf.activeLegs = "wornPants"
        playerInf.activeWepL = "(none)"
        playerInf.activeWepR = "oldWand"
        playerInf.moneyAmount = 0
        playerInf.dungeonID = 1
        playerInf.dungeonRM = 1
        ReDim playerInf.inventory(11)
        lblStr.Text = playerInf.strength
        lblInt.Text = playerInf.intelligence
        lblAgi.Text = playerInf.agility
    End Sub

    Private Sub rdbRogue_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRogue.CheckedChanged
        ' Sets variables to reflect the rogue class
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
        playerInf.activeBracers = 13
        playerInf.activeChest = 12
        playerInf.activeGloves = 6
        playerInf.activeHelm = 4
        playerInf.activeLegs = 9
        playerInf.activeWepL = 1
        playerInf.activeWepR = 1
        playerInf.moneyAmount = 0
        playerInf.dungeonID = 1
        playerInf.dungeonRM = 1
        ReDim playerInf.inventory(11)
        playerInf.inventory(0) = 1
        playerInf.inventory(1) = 1
        playerInf.inventory(2) = 4
        playerInf.inventory(3) = 12
        playerInf.inventory(4) = 9
        playerInf.inventory(5) = 13
        playerInf.inventory(6) = 6
        lblStr.Text = playerInf.strength
        lblInt.Text = playerInf.intelligence
        lblAgi.Text = playerInf.agility
        charInfoScr.pcbHandL.Image = rogBasDagL
        charInfoScr.pcbHandR.Image = rogBasDagR
        charInfoScr.cboLHand.Items.Add("Basic Dagger")
        charInfoScr.cboLHand.Text = "Basic Dagger"
        charInfoScr.cboRHand.Items.Add("Basic Dagger")
        charInfoScr.cboRHand.Text = "Basic Dagger"
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' Switches back to the launch screen
        Me.Hide()
        frmLaunchScr.Show()
    End Sub
End Class