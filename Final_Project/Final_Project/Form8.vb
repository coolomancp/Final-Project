Public Class frmBattle

    Private Sub btnFlee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlee.Click
        mainScr.pcbMonster11.Enabled = False
        mainScr.pcbMonster11.Visible = False
        mainScr.pcbMonster11.Left = -100
        monst1Dead = True
        Hide() ' Hides the battle screen
        ' Sets whatever frame is currently visible to the idle image in respect to the direction the player is facing
        If playerInf.charClass = "Warrior" Then
            If charDir = 1 And mainScr.pcbPlayer1.Visible = True Then
                charY = 340
                mainScr.pcbPlayer1.Image = warIdleL
            ElseIf charDir = 1 And mainScr.pcbPlayer2.Visible = True Then
                charY = 340
                mainScr.pcbPlayer2.Image = warIdleL
            ElseIf charDir = 1 And mainScr.pcbPlayer3.Visible = True Then
                charY = 340
                mainScr.pcbPlayer3.Image = warIdleL
            ElseIf charDir = 1 And mainScr.pcbPlayer4.Visible = True Then
                charY = 340
                mainScr.pcbPlayer4.Image = warIdleL
            ElseIf charDir = 2 And mainScr.pcbPlayer1.Visible = True Then
                charY = 340
                mainScr.pcbPlayer1.Image = warIdleR
            ElseIf charDir = 2 And mainScr.pcbPlayer2.Visible = True Then
                charY = 340
                mainScr.pcbPlayer2.Image = warIdleR
            ElseIf charDir = 2 And mainScr.pcbPlayer3.Visible = True Then
                charY = 340
                mainScr.pcbPlayer3.Image = warIdleR
            ElseIf charDir = 2 And mainScr.pcbPlayer4.Visible = True Then
                charY = 340
                mainScr.pcbPlayer4.Image = warIdleR
            End If
        ElseIf playerInf.charClass = "Mage" Then
            If charDir = 1 And mainScr.pcbPlayer1.Visible = True Then
                charY = 330
                mainScr.pcbPlayer1.Image = magIdleL
            ElseIf charDir = 1 And mainScr.pcbPlayer2.Visible = True Then
                charY = 330
                mainScr.pcbPlayer2.Image = magIdleL
            ElseIf charDir = 1 And mainScr.pcbPlayer3.Visible = True Then
                charY = 330
                mainScr.pcbPlayer3.Image = magIdleL
            ElseIf charDir = 1 And mainScr.pcbPlayer4.Visible = True Then
                charY = 330
                mainScr.pcbPlayer4.Image = magIdleL
            ElseIf charDir = 2 And mainScr.pcbPlayer1.Visible = True Then
                charY = 330
                mainScr.pcbPlayer1.Image = magIdleR
            ElseIf charDir = 2 And mainScr.pcbPlayer2.Visible = True Then
                charY = 330
                mainScr.pcbPlayer2.Image = magIdleR
            ElseIf charDir = 2 And mainScr.pcbPlayer3.Visible = True Then
                charY = 330
                mainScr.pcbPlayer3.Image = magIdleR
            ElseIf charDir = 2 And mainScr.pcbPlayer4.Visible = True Then
                charY = 330
                mainScr.pcbPlayer4.Image = magIdleR
            End If
        ElseIf playerInf.charClass = "Rogue" Then
            If charDir = 1 And mainScr.pcbPlayer1.Visible = True Then
                mainScr.pcbPlayer1.Image = rogIdleL
                charY = 340
                mainScr.pcbPlayer1.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer1.Size = New Size(72, 61)
            ElseIf charDir = 1 And mainScr.pcbPlayer2.Visible = True Then
                charY = 340
                mainScr.pcbPlayer2.Image = rogIdleL
                mainScr.pcbPlayer2.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer2.Size = New Size(72, 61)
            ElseIf charDir = 1 And mainScr.pcbPlayer3.Visible = True Then
                charY = 340
                mainScr.pcbPlayer3.Image = rogIdleL
                mainScr.pcbPlayer3.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer3.Size = New Size(72, 61)
            ElseIf charDir = 1 And mainScr.pcbPlayer4.Visible = True Then
                charY = 340
                mainScr.pcbPlayer4.Image = rogIdleL
                mainScr.pcbPlayer4.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer4.Size = New Size(72, 61)
            ElseIf charDir = 2 And mainScr.pcbPlayer1.Visible = True Then
                charY = 340
                mainScr.pcbPlayer1.Image = rogIdleR
                mainScr.pcbPlayer1.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer1.Size = New Size(72, 61)
            ElseIf charDir = 2 And mainScr.pcbPlayer2.Visible = True Then
                charY = 340
                mainScr.pcbPlayer2.Image = rogIdleR
                mainScr.pcbPlayer2.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer2.Size = New Size(72, 61)
            ElseIf charDir = 2 And mainScr.pcbPlayer3.Visible = True Then
                charY = 340
                mainScr.pcbPlayer3.Image = rogIdleR
                mainScr.pcbPlayer3.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer3.Size = New Size(72, 61)
            ElseIf charDir = 2 And mainScr.pcbPlayer4.Visible = True Then
                charY = 340
                mainScr.pcbPlayer4.Image = rogIdleR
                mainScr.pcbPlayer4.Location = New Point(charX, charY - 10) ' Offset for idle image
                mainScr.pcbPlayer4.Size = New Size(72, 61)
            End If
        End If
        ' Resets player Y
        mainScr.pcbPlayer1.Location = New Point(charX, charY)
        mainScr.pcbPlayer2.Location = New Point(charX, charY)
        mainScr.pcbPlayer3.Location = New Point(charX, charY)
        mainScr.pcbPlayer4.Location = New Point(charX, charY)
        mainScr.Show() ' Shows the main screen
    End Sub

    Private Sub frmBattle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dungeon.type = "grasslands" Then
            pcbBattleBG.Image = grasslandBG
        End If
        pcbBattlePlayer.Parent = pcbBattleBG
        pcbBattleEnemy.Parent = pcbBattleBG
    End Sub
End Class