Imports WMPLib
Imports AxWMPLib
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms
Public Class frmMainScr
    Dim invStat As Boolean = False ' Default status of the inventory screen is hidden
    Dim infStat As Boolean = False ' Default status of the char info screen is hidden
    Dim charMovSpd As Integer = 5 ' Player's movement speed
    Dim attStat As Boolean = False ' Is player attacking?
    Dim monstY As Integer ' Monster's Y coord
    Dim monst1X As Integer ' First monster's X coord
    Dim monst2X As Integer ' Second monster's X coord
    Dim monst3X As Integer ' Third monster's X coord
    Dim monst4X As Integer ' Fourth monster's X coord

    Private Sub btnCharI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharI.Click
        If infStat = False Then ' Checks if the character info screen is closed
            ' Places character information screen on the left side of the main screen
            charInfoScr.Left = Location.X \ 4 + 7
            charInfoScr.Top = Location.Y + Location.Y \ 3
            ' Refreshes character information
            charInfoScr.RefreshCharInf()
            ' Add armor and DPS calculation
            charInfoScr.Show() ' Opens the character info screen
            infStat = True ' Character info screen status is set as open
        ElseIf infStat = True Then ' Checks if the character info screen is open
            charInfoScr.Hide() ' Closes the character info screen
            infStat = False ' Character info screen status is set to closed
        End If
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        ' Launches inventory screen if it's closed. Closes inventory screen if it's open
        If invStat = False Then ' Checks if the inventory screen is closed
            ' Places inventory screen on the right side of the main screen
            inventoryScr.Left = Location.X * 2 - Location.X \ 2 + inventoryScr.Size.Width - 21
            inventoryScr.Top = Location.Y + Location.Y \ 3
            inventoryScr.RefreshInv() ' Refreshes screen
            inventoryScr.Show() ' Opens the inventory screen
            invStat = True ' Inventory screen status is set as open
        ElseIf invStat = True Then ' Checks if the inventory screen is open
            inventoryScr.Hide() ' Closes the inventory screen
            invStat = False ' Inventory screen status is set to closed
        End If
    End Sub

    Private Sub frmMainScr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        DungeonCreate()
        If playerInf.charClass = "Warrior" Then
            charY = 340
            charMovSpd = 5
            pcbPlayer1.Image = My.Resources.warIdleR
            pcbPlayer2.Image = My.Resources.warIdleR
            pcbPlayer3.Image = My.Resources.warIdleR
            pcbPlayer4.Image = My.Resources.warIdleR
        ElseIf playerInf.charClass = "Rogue" Then
            charY = 340
            charMovSpd = 10
            pcbPlayer1.Image = My.Resources.rogIdleR
            pcbPlayer2.Image = My.Resources.rogIdleR
            pcbPlayer3.Image = My.Resources.rogIdleR
            pcbPlayer4.Image = My.Resources.rogIdleR
        ElseIf playerInf.charClass = "Mage" Then
            charY = 330
            charMovSpd = 5
            pcbPlayer1.Image = My.Resources.magIdleR
            pcbPlayer2.Image = My.Resources.magIdleR
            pcbPlayer3.Image = My.Resources.magIdleR
            pcbPlayer4.Image = My.Resources.magIdleR
        End If
        ' Reloads player's last position
        pcbPlayer1.Location = New Point(charX, charY)
        pcbPlayer2.Location = New Point(charX, charY)
        pcbPlayer3.Location = New Point(charX, charY)
        pcbPlayer4.Location = New Point(charX, charY)
        lblTest.Text = Convert.ToString(pcbPlayer1.Location)
        KeyPreview = True ' Form accepts indirect keyboard input
        ' Sets each frame's parent to the background to allow transparency
        pcbPlayer1.Parent = pcbMainScr
        pcbPlayer2.Parent = pcbMainScr
        pcbPlayer3.Parent = pcbMainScr
        pcbPlayer4.Parent = pcbMainScr
        pcbMonster11.Parent = pcbMainScr
        pcbMonster12.Parent = pcbMainScr
        pcbMonster13.Parent = pcbMainScr
        pcbMonster14.Parent = pcbMainScr
        pcbMonster21.Parent = pcbMainScr
        pcbMonster22.Parent = pcbMainScr
        pcbMonster23.Parent = pcbMainScr
        pcbMonster24.Parent = pcbMainScr
        ' Sets lvl up label for transparency
        lblLevelUp.Parent = pcbMainScr
        lblLevelUp.Visible = False
        ' Sets background music **No sound..?
        wmpMusic.URL = resPath + "bgmusicGreen.wav"
        wmpMusic.settings.playCount = 5000000 ' Gives the illusion the sound loops forever
        ' Sets ambient sounds and sets ambient sound volume low
        wmpAmbient.URL = resPath + "waterfallAmbient.wav"
        wmpAmbient.settings.volume = 10
        wmpAmbient.settings.playCount = 5000000 ' Gives the illusion the sound loops forever
    End Sub
    Private Sub timeanim_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrAnim.Tick
        ' Animates the player's character by turning one frame on as the previous frame is turned off
        If pcbPlayer1.Visible = True Then
            pcbPlayer1.Visible = False
            pcbPlayer2.Visible = True
        ElseIf pcbPlayer2.Visible = True Then
            pcbPlayer2.Visible = False
            pcbPlayer3.Visible = True
        ElseIf pcbPlayer3.Visible = True Then
            pcbPlayer3.Visible = False
            pcbPlayer4.Visible = True
        ElseIf pcbPlayer4.Visible = True Then
            pcbPlayer4.Visible = False
            pcbPlayer1.Visible = True
        End If
        attStat = False
    End Sub

    Private Sub frmMainScr_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        lblTest.Text = Convert.ToString(pcbPlayer1.Location)
        Select Case e.KeyCode
            Case Keys.A And charX > -5 ' Moves player to the left if they are pressing "A" and are not already the maximum amount left
                ' Sets the picture boxes up for frames 1-4 of the player walking left
                If playerInf.charClass = "Warrior" Then
                    pcbPlayer1.Image = warWalkL1
                    pcbPlayer2.Image = warWalkL2
                    pcbPlayer3.Image = warWalkL3
                    pcbPlayer4.Image = warWalkL4
                    battleTrigger() ' Triggers battle if player is close to a monster
                    nxtRoom() ' Checks if player is far enough to the right to enter the next room / floor
                    charY = 340
                ElseIf playerInf.charClass = "Rogue" Then
                    pcbPlayer1.Image = rogWalkL1
                    pcbPlayer2.Image = rogWalkL2
                    pcbPlayer3.Image = rogWalkL3
                    charY = 350
                    pcbPlayer4.Image = rogWalkL4
                    battleTrigger() ' Triggers battle if player is close to a monster
                    nxtRoom() ' Checks if player is far enough to the right to enter the next room / floor
                ElseIf playerInf.charClass = "Mage" Then
                    pcbPlayer1.Image = magFlyL1
                    pcbPlayer2.Image = magFlyL2
                    pcbPlayer3.Image = magFlyL3
                    pcbPlayer4.Image = magFlyL4
                    battleTrigger() ' Triggers battle if player is close to a monster
                    nxtRoom() ' Checks if player is far enough to the right to enter the next room / floor
                End If
                ' Resets player Y
                pcbPlayer1.Location = New Point(charX, charY)
                pcbPlayer2.Location = New Point(charX, charY)
                pcbPlayer3.Location = New Point(charX, charY)
                pcbPlayer4.Location = New Point(charX, charY)
                tmrAnim.Enabled = True ' Starts animation
                ' Moves player left
                pcbPlayer1.Left -= charMovSpd
                pcbPlayer2.Left -= charMovSpd
                pcbPlayer3.Left -= charMovSpd
                pcbPlayer4.Left -= charMovSpd
                charDir = 1 ' Character's direction set to "left"
                charX = charX - charMovSpd ' Updates player's x coord (Decrease)
            Case Keys.D And charX < 655 ' Moves player to the right if they are pressing "D" and are not already the maximum amount right
                ' Sets the picture boxes up for frames 1-4 of the player walking right
                If playerInf.charClass = "Warrior" Then
                    pcbPlayer1.Image = warWalkR1
                    pcbPlayer2.Image = warWalkR2
                    pcbPlayer3.Image = warWalkR3
                    pcbPlayer4.Image = warWalkR4
                    battleTrigger() ' Triggers battle if player is close to a monster
                    nxtRoom() ' Checks if player is far enough to the right to enter the next room / floor
                    charY = 340
                ElseIf playerInf.charClass = "Rogue" Then
                    pcbPlayer1.Image = rogWalkR1
                    pcbPlayer2.Image = rogWalkR2
                    pcbPlayer3.Image = rogWalkR3
                    pcbPlayer4.Image = rogWalkR4
                    charY = 350
                    battleTrigger() ' Triggers battle if player is close to a monster
                    nxtRoom() ' Checks if player is far enough to the right to enter the next room / floor
                ElseIf playerInf.charClass = "Mage" Then
                    pcbPlayer1.Image = magFlyR1
                    pcbPlayer2.Image = magFlyR2
                    pcbPlayer3.Image = magFlyR3
                    pcbPlayer4.Image = magFlyR4
                    battleTrigger() ' Triggers battle if player is close to a monster
                    nxtRoom() ' Checks if player is far enough to the right to enter the next room / floor
                End If
                ' Resets player Y
                pcbPlayer1.Location = New Point(charX, charY)
                pcbPlayer2.Location = New Point(charX, charY)
                pcbPlayer3.Location = New Point(charX, charY)
                pcbPlayer4.Location = New Point(charX, charY)
                tmrAnim.Enabled = True ' Starts animation
                ' Moves player right
                pcbPlayer1.Left += charMovSpd
                pcbPlayer2.Left += charMovSpd
                pcbPlayer3.Left += charMovSpd
                pcbPlayer4.Left += charMovSpd
                charDir = 2 ' Character's direction set to "right"
                charX = charX + charMovSpd ' Updates player's x coord (Increase)
            Case Keys.X And charX < 655 And charDir = 2 ' Character attacks
                attStat = True ' Character is now attacking
                ' Updates images to reflect attack animation
                If playerInf.charClass = "Warrior" Then
                    pcbPlayer1.Image = warAttR1
                    pcbPlayer2.Image = warAttR2
                    pcbPlayer3.Image = warAttR3
                    pcbPlayer4.Image = warAttR4
                    charY = 258
                ElseIf playerInf.charClass = "Rogue" Then
                    pcbPlayer1.Image = rogAttR1
                    pcbPlayer2.Image = rogAttR2
                    pcbPlayer3.Image = rogAttR3
                    pcbPlayer4.Image = rogAttR4
                    charY = 330
                ElseIf playerInf.charClass = "Mage" Then
                    pcbPlayer1.Image = magAttR1
                    pcbPlayer2.Image = magAttR2
                    pcbPlayer3.Image = magAttR3
                    pcbPlayer4.Image = magAttR4
                End If
                ' Resets player Y
                pcbPlayer1.Location = New Point(charX, charY)
                pcbPlayer2.Location = New Point(charX, charY)
                pcbPlayer3.Location = New Point(charX, charY)
                pcbPlayer4.Location = New Point(charX, charY)
                tmrAnim.Enabled = True ' Starts animation
            Case Keys.X And charX > -5 And charDir = 1 ' Character attacks
                attStat = True ' Character is now attacking
                ' Updates images to reflect attack animation
                If playerInf.charClass = "Warrior" Then
                    pcbPlayer1.Image = warAttL1
                    pcbPlayer2.Image = warAttL2
                    pcbPlayer3.Image = warAttL3
                    pcbPlayer4.Image = warAttL4
                    charY = 258
                ElseIf playerInf.charClass = "Rogue" Then
                    pcbPlayer1.Image = rogAttL1
                    pcbPlayer2.Image = rogAttL2
                    pcbPlayer3.Image = rogAttL3
                    pcbPlayer4.Image = rogAttL4
                    charY = 330
                ElseIf playerInf.charClass = "Mage" Then
                    pcbPlayer1.Image = magAttL1
                    pcbPlayer2.Image = magAttL2
                    pcbPlayer3.Image = magAttL3
                    pcbPlayer4.Image = magAttL4
                End If
                ' Resets player Y
                pcbPlayer1.Location = New Point(charX, charY)
                pcbPlayer2.Location = New Point(charX, charY)
                pcbPlayer3.Location = New Point(charX, charY)
                pcbPlayer4.Location = New Point(charX, charY)
                tmrAnim.Enabled = True ' Starts animation
        End Select
    End Sub
    ' ADD PROCEDURE DOC
    Sub battleTrigger()
        If pcbPlayer1.Right > pcbMonster11.Left - (pcbMonster11.Width - 20) And monst1Dead = False Then
            Hide()
            If dungeon.monstertype = "Goblin" Then
                fleeMod = 30 ' 30% more likely to flee
            End If
            monst1Battle = True
            battleScr.refreshForm() ' Refreshes screen for updates
            battleScr.Show() ' Battle screen appears
        Else
            lblTest2.Text = "{ " & playerInf.exp & " }"
        End If
        If pcbPlayer1.Right > pcbMonster21.Left - (pcbMonster21.Width - 20) And monst2Dead = False Then
            Hide()
            If dungeon.monstertype = "Goblin" Then
                fleeMod = 30 ' 30% more likely to flee
            End If
            monst2Battle = True
            battleScr.refreshForm()
            battleScr.Show()
        Else
            lblTest2.Text = "{ " & playerInf.exp & " }"
        End If
    End Sub
    Private Sub frmMainScr_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
        tmrAnim.Enabled = False ' Stops animation
        lblTest.Text = Convert.ToString(pcbPlayer1.Location)
        ' Sets whatever frame is currently visible to the idle image in respect to the direction the player is facing
        If playerInf.charClass = "Warrior" Then
            If charDir = 1 And pcbPlayer1.Visible = True Then
                charY = 340
                pcbPlayer1.Image = warIdleL
            ElseIf charDir = 1 And pcbPlayer2.Visible = True Then
                charY = 340
                pcbPlayer2.Image = warIdleL
            ElseIf charDir = 1 And pcbPlayer3.Visible = True Then
                charY = 340
                pcbPlayer3.Image = warIdleL
            ElseIf charDir = 1 And pcbPlayer4.Visible = True Then
                charY = 340
                pcbPlayer4.Image = warIdleL
            ElseIf charDir = 2 And pcbPlayer1.Visible = True Then
                charY = 340
                pcbPlayer1.Image = warIdleR
            ElseIf charDir = 2 And pcbPlayer2.Visible = True Then
                charY = 340
                pcbPlayer2.Image = warIdleR
            ElseIf charDir = 2 And pcbPlayer3.Visible = True Then
                charY = 340
                pcbPlayer3.Image = warIdleR
            ElseIf charDir = 2 And pcbPlayer4.Visible = True Then
                charY = 340
                pcbPlayer4.Image = warIdleR
            End If
        ElseIf playerInf.charClass = "Mage" Then
            If charDir = 1 And pcbPlayer1.Visible = True Then
                charY = 330
                pcbPlayer1.Image = magIdleL
            ElseIf charDir = 1 And pcbPlayer2.Visible = True Then
                charY = 330
                pcbPlayer2.Image = magIdleL
            ElseIf charDir = 1 And pcbPlayer3.Visible = True Then
                charY = 330
                pcbPlayer3.Image = magIdleL
            ElseIf charDir = 1 And pcbPlayer4.Visible = True Then
                charY = 330
                pcbPlayer4.Image = magIdleL
            ElseIf charDir = 2 And pcbPlayer1.Visible = True Then
                charY = 330
                pcbPlayer1.Image = magIdleR
            ElseIf charDir = 2 And pcbPlayer2.Visible = True Then
                charY = 330
                pcbPlayer2.Image = magIdleR
            ElseIf charDir = 2 And pcbPlayer3.Visible = True Then
                charY = 330
                pcbPlayer3.Image = magIdleR
            ElseIf charDir = 2 And pcbPlayer4.Visible = True Then
                charY = 330
                pcbPlayer4.Image = magIdleR
            End If
        ElseIf playerInf.charClass = "Rogue" Then
            If charDir = 1 And pcbPlayer1.Visible = True Then
                pcbPlayer1.Image = rogIdleL
                charY = 340
                pcbPlayer1.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer1.Size = New Size(72, 61)
            ElseIf charDir = 1 And pcbPlayer2.Visible = True Then
                charY = 340
                pcbPlayer2.Image = rogIdleL
                pcbPlayer2.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer2.Size = New Size(72, 61)
            ElseIf charDir = 1 And pcbPlayer3.Visible = True Then
                charY = 340
                pcbPlayer3.Image = rogIdleL
                pcbPlayer3.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer3.Size = New Size(72, 61)
            ElseIf charDir = 1 And pcbPlayer4.Visible = True Then
                charY = 340
                pcbPlayer4.Image = rogIdleL
                pcbPlayer4.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer4.Size = New Size(72, 61)
            ElseIf charDir = 2 And pcbPlayer1.Visible = True Then
                charY = 340
                pcbPlayer1.Image = rogIdleR
                pcbPlayer1.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer1.Size = New Size(72, 61)
            ElseIf charDir = 2 And pcbPlayer2.Visible = True Then
                charY = 340
                pcbPlayer2.Image = rogIdleR
                pcbPlayer2.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer2.Size = New Size(72, 61)
            ElseIf charDir = 2 And pcbPlayer3.Visible = True Then
                charY = 340
                pcbPlayer3.Image = rogIdleR
                pcbPlayer3.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer3.Size = New Size(72, 61)
            ElseIf charDir = 2 And pcbPlayer4.Visible = True Then
                charY = 340
                pcbPlayer4.Image = rogIdleR
                pcbPlayer4.Location = New Point(charX, charY - 10) ' Offset for idle image
                pcbPlayer4.Size = New Size(72, 61)
            End If
        End If
        ' Resets player Y
        pcbPlayer1.Location = New Point(charX, charY)
        pcbPlayer2.Location = New Point(charX, charY)
        pcbPlayer3.Location = New Point(charX, charY)
        pcbPlayer4.Location = New Point(charX, charY)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        exitWarning.Show() ' Shows exit screen
    End Sub

    Private Sub tmrMonst1Anim_Tick(ByVal sender As Object, ByVal e As EventArgs)
        ' Animations monster movement
        If pcbMonster11.Visible = True Then
            pcbMonster11.Visible = False
            pcbMonster12.Visible = True
        ElseIf pcbMonster12.Visible = True Then
            pcbMonster12.Visible = False
            pcbMonster13.Visible = True
        ElseIf pcbMonster13.Visible = True Then
            pcbMonster13.Visible = False
            pcbMonster14.Visible = True
        ElseIf pcbMonster14.Visible = True Then
            pcbMonster14.Visible = False
            pcbMonster11.Visible = True
        End If
    End Sub

    Private Sub tmrMonst2Anim_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrMonst2Anim.Tick
        ' Animators second monster's movement
        If pcbMonster21.Visible = True Then
            pcbMonster21.Visible = False
            pcbMonster22.Visible = True
        ElseIf pcbMonster22.Visible = True Then
            pcbMonster22.Visible = False
            pcbMonster23.Visible = True
        ElseIf pcbMonster13.Visible = True Then
            pcbMonster23.Visible = False
            pcbMonster24.Visible = True
        ElseIf pcbMonster24.Visible = True Then
            pcbMonster24.Visible = False
            pcbMonster21.Visible = True
        End If
    End Sub

    Private Sub tmrLvlUpInvis_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLvlUpInvis.Tick
        ' Makes level up message go away
        lblLevelUp.Visible = False
        tmrLvlUpInvis.Enabled = False
    End Sub

    Sub nxtRoom()
        ' Checks for the next room collision
        If pcbPlayer1.Right >= 640 Then
            tmrNxtRoom.Enabled = True
        End If
    End Sub
    Dim count As Integer = 0
    Private Sub tmrNxtRoom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrNxtRoom.Tick
        If playerInf.charClass = "Rogue" Then
            ' Next Room
            charX = 0 ' Reset character position
            tmrNxtRoom.Enabled = False
        End If
        If count = 0 Then
            DungeonCreate()
            count = 1
        Else
            count = 0
        End If
    End Sub

    ' Dungeon creation procedure
    Sub DungeonCreate()
        ' Background
        If dungeon.type = "grasslands" Then
            pcbMainScr.Image = grasslandRoomBG
        End If
        ' Monster placement !!!*** Issue with placement and replacement ***!!!
        If dungeon.numOfRms = playerInf.dungeonRM Then
            ' Dungeon boss setup
        Else
            If dungeon.monstertype = "Goblin" Then
                If dungeon.monstNum >= 1 Then
                    pcbMonster11.Image = gobWalkL1
                    pcbMonster12.Image = gobWalkL2
                    pcbMonster13.Image = gobWalkL3
                    pcbMonster14.Image = gobWalkL4
                    monst1X = 400
                    pcbMonster11.Location = New Point(monst1X, 358)
                    pcbMonster12.Location = New Point(monst1X, 358)
                    pcbMonster13.Location = New Point(monst1X, 358)
                    pcbMonster14.Location = New Point(monst1X, 358)
                    monst1Dead = False
                End If
                If dungeon.monstNum >= 2 Then
                    pcbMonster21.Image = gobWalkL1
                    pcbMonster22.Image = gobWalkL2
                    pcbMonster23.Image = gobWalkL3
                    pcbMonster24.Image = gobWalkL4
                    monst2X = 430
                    pcbMonster21.Location = New Point(monst2X, 358)
                    pcbMonster22.Location = New Point(monst2X, 358)
                    pcbMonster23.Location = New Point(monst2X, 358)
                    pcbMonster24.Location = New Point(monst2X, 358)
                    monst2Dead = False
                End If
                If dungeon.monstNum >= 3 Then
                    'pcbMonster31.Image = gobWalkL1
                    'pcbMonster32.Image = gobWalkL2
                    'pcbMonster33.Image = gobWalkL3
                    'pcbMonster34.Image = gobWalkL4
                End If
                If dungeon.monstNum = 4 Then
                    'pcbMonster31.Image = gobWalkL1
                    'pcbMonster32.Image = gobWalkL2
                    'pcbMonster33.Image = gobWalkL3
                    'pcbMonster34.Image = gobWalkL4
                    'pcbMonster41.Image = gobWalkL1
                    'pcbMonster42.Image = gobWalkL2
                    'pcbMonster43.Image = gobWalkL3
                    'pcbMonster44.Image = gobWalkL4
                End If
            End If
        End If
    End Sub
End Class