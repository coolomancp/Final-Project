Public Class frmBattle
    Dim counter As Integer = 0
    Dim damage As Integer ' Holds the value of damage done to the player
    Private Sub btnFlee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlee.Click
        Dim fleeChance As Integer
        Randomize()
        ' Calculates a random chance for fleeing + flee modifier
        fleeChance = Int((100 - 1 + 1) * Rnd() + 1) + fleeMod
        ' If the flee chance is 50+, the player flees
        If fleeChance >= 50 Then
            If monst1Battle = True Then
                mainScr.pcbMonster11.Left = -100
                monst1Dead = True
                monst1Battle = False
            End If
            If monst2Battle = True Then

                mainScr.pcbMonster21.Left = -100
                monst2Dead = True
                monst2Battle = False
            End If
            Hide() ' Hides the battle screen
            ' Resets player Y
            mainScr.pcbPlayer1.Location = New Point(charX, charY)
            mainScr.pcbPlayer2.Location = New Point(charX, charY)
            mainScr.pcbPlayer3.Location = New Point(charX, charY)
            mainScr.pcbPlayer4.Location = New Point(charX, charY)
            mainScr.Show() ' Shows the main screen
            mainScr.WindowState = FormWindowState.Normal
        ElseIf fleeChance < 50 Then
            monstAttack()
        End If
    End Sub

    Private Sub frmBattle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshForm()
    End Sub
    ' Refreshes the form by re-running the load code with some additions, refreshing the default state of some objects
    Sub refreshForm()
        ' Sets background depending on dungeon type
        If dungeon.type = "grasslands" Then
            pcbBattleBG.Image = grasslandBG
        End If
        ' Determines what class is fighting and displays them
        If playerInf.charClass = "Warrior" Then
            pcbBattlePlayer.Image = warBattS
        ElseIf playerInf.charClass = "Rogue" Then
            pcbBattlePlayer.Image = rogBattS
        ElseIf playerInf.charClass = "Mage" Then
            pcbBattlePlayer.Image = magBattS
        End If
        ' Determines what monster is fighting and displays them
        If dungeon.monstertype = "Goblin" Then
            pcbBattleEnemy.Image = gobBattS
            monstInf.HP = 100
            monstInf.HPM = 100
            monstInf.MP = 50
            monstInf.MPM = 50
            monstInf.armor = 0
        End If
        If dungeon.monstertype = "grasslandsBoss" Then
            pcbBattleEnemy.Image = grassBossIdle
            monstInf.HP = 150
            monstInf.HPM = 150
            monstInf.MP = 75
            monstInf.MPM = 75
            monstInf.armor = 2
        End If
        ' Parents images and labels to allow transparency
        pcbBattlePlayer.Parent = pcbBattleBG
        pcbBattleEnemy.Parent = pcbBattleBG
        lblEnemyHP.Parent = pcbBattleBG
        lblEnemyDefeat.Parent = pcbBattleBG
        lblExpAmount.Parent = pcbBattleBG
        ' Sets player's initial health and mana
        proBarHealthVal.Value = (playerInf.HP / playerInf.HPM) * 100
        proBarManaVal.Value = (playerInf.MP / playerInf.MPM) * 100
        lblHPVal.Text = "(" & playerInf.HP & "/" & playerInf.HPM & ")"
        lblManaVal.Text = "(" & playerInf.MP & "/" & playerInf.MPM & ")"
        ' Checks health and sets color reflecting how much is left
        If proBarHealthVal.Value <= 50 And proBarHealthVal.Value > 30 Then
            proBarHealthVal.ForeColor = Color.Yellow
        ElseIf proBarHealthVal.Value <= 30 Then
            proBarHealthVal.ForeColor = Color.Red
        End If
        ' Sets enemy's initial health
        proBarEnemyHP.Value = (monstInf.HP / monstInf.HPM) * 100
        lblEnemyHP.Text = "(" & monstInf.HP & "/" & monstInf.HPM & ")"
        ' Resets objects to default state
        lblEnemyDefeat.Visible = False
        lblExpAmount.Visible = False
        proBarEnemyHP.Visible = True
        lblEnemyHP.Visible = True
    End Sub
    Sub monstAttack()
        ' Monster's attack and animation are decided and played
        Select Case dungeon.monstertype
            Case Is = "Goblin"
                pcbBattleEnemy.Image = gobAttL ' Goblin attacks
                pcbBattleEnemy.Location = New Point(576, 197)
                pcbBattleEnemy.Size = New Size(175, 175)
            Case Is = "grasslandsBoss"
                pcbBattleEnemy.Image = grassBossAtt
                pcbBattleEnemy.Location = New Point(576, 197)
                pcbBattleEnemy.Size = New Size(123, 123)
        End Select
        attackAnim.Enabled = True
    End Sub

    Private Sub attackAnim_tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles attackAnim.Tick
        ' Resets the enemy back to their idle animation
        Select Case dungeon.monstertype
            Case Is = "Goblin"
                pcbBattleEnemy.Image = gobIdleL
                pcbBattleEnemy.Location = New Point(576, 246)
                pcbBattleEnemy.Size = New Size(123, 123)
            Case Is = "grasslandsBoss"
                pcbBattleEnemy.Image = grassBossIdle
                pcbBattleEnemy.Location = New Point(576, 246)
                pcbBattleEnemy.Size = New Size(123, 123)
        End Select
        attackAnim.Enabled = False
        playerHit.Enabled = True
    End Sub

    Private Sub playerHit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playerHit.Tick
        ' Plays animation for player getting hit
        pcbBattlePlayer.Image = rogHitR
        ' Player is damaged
        If counter = 0 Then
            Select Case dungeon.monstertype
                Case Is = "Goblin"
                    playerInf.HP = playerInf.HP - dmgToPlayer(5 * dungeon.difficulty)
                Case Is = "grasslandsBoss"
                    playerInf.HP = playerInf.HP - dmgToPlayer(10 * dungeon.difficulty)
            End Select
        End If
        If playerInf.HP <= 0 Then
            playerInf.HP = 0
            deathAnim.Enabled = True
        End If
        ' Health bar is refreshed
        proBarHealthVal.Value = (playerInf.HP / playerInf.HPM) * 100
        lblHPVal.Text = "(" & playerInf.HP & "/" & playerInf.HPM & ")"
        If proBarHealthVal.Value <= 50 And proBarHealthVal.Value > 30 Then
            proBarHealthVal.ForeColor = Color.Yellow
        ElseIf proBarHealthVal.Value <= 30 Then
            proBarHealthVal.ForeColor = Color.Red
        End If
        ' Return to battle stance after being hit
        If counter = 1 Then
            pcbBattlePlayer.Image = rogBattS
            counter = 0
            playerHit.Enabled = False
        Else
            counter = 1
        End If
    End Sub

    Private Sub btnAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttack.Click
        btnAbilities.Visible = True
        btnAbilities.Enabled = True
        btnMelee.Visible = True
        btnMelee.Enabled = True
        btnAttack.Enabled = False
    End Sub

    Private Sub btnMelee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMelee.Click
        btnAbilities.Visible = False
        btnAbilities.Enabled = False
        btnMelee.Visible = False
        btnMelee.Enabled = False
        ' **** Attack Sequence ****
        playerAttAnim.Enabled = True
        btnAttack.Enabled = True
    End Sub

    Private Sub playerAttAnim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playerAttAnim.Tick
        pcbBattlePlayer.Image = rogMeleeN ' Plays attack animation gif
        pcbBattlePlayer.Size = New Size(180, 166)
        pcbBattlePlayer.Location = New Point(13, 203)
        If counter = 0 Then
            monstInf.HP = monstInf.HP - (playerInf.dmg - monstInf.armor) ' Damage to monster calculated
            lblEnemyHP.Text = "(" & monstInf.HP & "/" & monstInf.HPM & ")"
        End If
        If monstInf.HP <= 0 Then ' Checks if the enemy has died
            monstInf.HP = 0
            counter = 0
            deathAnim.Enabled = True
        End If
        proBarEnemyHP.Value = (monstInf.HP / monstInf.HPM) * 100 ' Updates enemy's health bar
        If counter = 1 Then
            If playerInf.charClass = "Rogue" Then
                pcbBattlePlayer.Image = rogBattS ' Rogue returns to battle stance
                pcbBattlePlayer.Size = New Size(133, 123)
                pcbBattlePlayer.Location = New Point(13, 246)
            End If
            counter = 0 ' Counter reset
            playerAttAnim.Enabled = False ' Attack animation finished
            If monstInf.HP > 0 Then
                monstAttack() ' Enemy attack begins
            End If
        Else
            counter = 1
        End If
    End Sub

    Private Sub deathAnim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deathAnim.Tick
        If monstInf.HP = 0 Then
            If dungeon.monstertype = "Goblin" Then
                pcbBattleEnemy.Image = gobDeath
            End If
        ElseIf playerInf.HP = 0 Then
            ' Add player death animations
            If playerInf.charClass = "Warrior" Then
            ElseIf playerInf.charClass = "Rogue" Then
            ElseIf playerInf.charClass = "Mage" Then
            End If
        End If
        If counter = 1 Then
            counter = 0
            If playerInf.charClass = "Warrior" Then

            ElseIf playerInf.charClass = "Rogue" Then
                pcbBattlePlayer.Image = rogBattS
            ElseIf playerInf.charClass = "Mage" Then

            End If
            pcbBattleEnemy.Image = Nothing
            playerAttAnim.Enabled = False
            deathAnim.Enabled = False
            If dungeon.monstertype = "Goblin" Then
                lblEnemyDefeat.Text = "Goblin Defeated!"
                lblExpAmount.Text = "5 EXP"
                playerInf.exp = playerInf.exp + 5
            ElseIf dungeon.monstertype = "grasslandsBoss" Then
                lblEnemyDefeat.Text = "Boss Defeated!"
                lblExpAmount.Text = "20 EXP"
                playerInf.exp = playerInf.exp + 20
            End If
            If monst1Battle = True Then
                mainScr.pcbMonster11.Left = -200
                monst1Dead = True
                monst1Battle = False
            End If
            If monst2Battle = True Then
                mainScr.pcbMonster21.Left = -200
                monst2Dead = True
                monst2Battle = False
            End If
            lblEnemyDefeat.Visible = True
            lblExpAmount.Visible = True
            lblEnemyHP.Visible = False
            proBarEnemyHP.Visible = False
            tmrTimeToHide.Enabled = True
        Else
            counter = 1
        End If
    End Sub

    Private Sub tmrTimeToHide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeToHide.Tick
        ' Hides screen and returns to the main screen after a 3 second wait
        Hide()
        ' Checks if player has leveled up
        If playerInf.exp >= (playerInf.level * 5) Then
            ' Levels up player
            mainScr.lblLevelUp.Visible = True
            playerInf.exp = playerInf.exp - (playerInf.level * 5)
            playerInf.level = playerInf.level + 1
            mainScr.tmrLvlUpInvis.Enabled = True
        End If
        If dungeon.monstertype = "grasslandsBoss" Then
            If mapProg = 1 Then
                grassldDunge = True
            ElseIf mapProg = 2 Then
                gondorDunge = True
            End If
            If grassldDunge Or gondorDunge = False Then
                mapProg = mapProg + 1
                playerInf.dungeonID = mapProg
            End If
            mapScr.Show()
        Else
            mainScr.Show()
        End If
        tmrTimeToHide.Enabled = False
    End Sub

    ' Calculates if player's armor nullifies damage. Outputs 0 if it does, outputs the damage if it doesn't
    Function dmgToPlayer(ByVal dmg) As Integer
        If dmg + playerInf.armor >= 0 Then ' Damage nullified?
            Return 0 ' 0 damage
        Else
            Return dmg ' Full damage fed back
        End If
    End Function
End Class