Public Class frmMainScr
    Dim inventoryScr As New frmInventory ' Inventory screen is loaded (hidden)
    Dim charInfoScr As New frmCharScreen ' Character Info screen is loaded (hidden)
    Dim exitWarning As New frmExitWarning ' Warns player to save before exiting
    Dim invStat As Boolean = False ' Default status of the inventory screen is hidden
    Dim infStat As Boolean = False ' Default status of the char info screen is hidden
    Dim charX As Integer = 0 ' Player's starting x coord
    Dim charY As Integer = 330 ' Player's starting y coord
    Dim charMovSpd As Integer = 5 ' Player's movement speed
    Dim charDir As Integer = 2 ' Player's direction

    Private Sub btnCharI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharI.Click
        If infStat = False Then ' Checks if the inventory screen is closed
            charInfoScr.Show() ' Opens the inventory screen
            infStat = True ' Inventory screen status is set as open
        ElseIf infStat = True Then ' Checks if the inventory screen is open
            charInfoScr.Hide() ' Closes the inventory screen
            infStat = False ' Inventory screen status is set to closed
        End If
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        ' Launches inventory screen if it's closed. Closes inventory screen if it's open
        If invStat = False Then ' 
            inventoryScr.Show()
            invStat = True
        ElseIf invStat = True Then
            inventoryScr.Hide()
            invStat = False
        End If
    End Sub

    Private Sub frmMainScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True ' Form accepts indirect keyboard input
        ' Sets each character frame's parent to the background to allow transparency
        With pcbPlayer1
            .Parent = picMainScr
        End With
        With pcbPlayer2
            .Parent = picMainScr
        End With
        With pcbPlayer3
            .Parent = picMainScr
        End With
        With pcbPlayer4
            .Parent = picMainScr
        End With
        If charDir = 1 Then
            pcbPlayer1.Image = warIdleL
        ElseIf charDir = 2 Then
            pcbPlayer1.Image = warIdleR
        End If
        ' Reloads player's last position
        pcbPlayer1.Location = New Point(charX, charY)
        pcbPlayer2.Location = New Point(charX, charY)
        pcbPlayer3.Location = New Point(charX, charY)
        pcbPlayer4.Location = New Point(charX, charY)
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
    End Sub

    Private Sub frmMainScr_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.A And charX > -5 ' Moves player to the left if they are pressing "A" and are not already the maximum amount left
                ' Sets the picture boxes up for frames 1-4 of the player walking left
                pcbPlayer1.Image = warWalkL1
                pcbPlayer2.Image = warWalkL2
                pcbPlayer3.Image = warWalkL3
                pcbPlayer4.Image = warWalkL4

                tmrAnim.Enabled = True ' Starts animation
                ' Moves player left
                pcbPlayer1.Left -= charMovSpd
                pcbPlayer2.Left -= charMovSpd
                pcbPlayer3.Left -= charMovSpd
                pcbPlayer4.Left -= charMovSpd
                charDir = 1 ' Character's direction set to "left"
                charX = charX - charMovSpd ' Updates player's x coord (Decrease)
            Case = Keys.D And charX < 655 ' Moves player to the right if they are pressing "D" and are not already the maximum amount right
                ' Sets the picture boxes up for frames 1-4 of the player walking right
                pcbPlayer1.Image = warWalkR1
                pcbPlayer2.Image = warWalkR2
                pcbPlayer3.Image = warWalkR3
                pcbPlayer4.Image = warWalkR4

                tmrAnim.Enabled = True ' Starts animation
                ' Moves player right
                pcbPlayer1.Left += charMovSpd
                pcbPlayer2.Left += charMovSpd
                pcbPlayer3.Left += charMovSpd
                pcbPlayer4.Left += charMovSpd
                charDir = 2 ' Character's direction set to "right"
                charX = charX + charMovSpd ' Updates player's x coord (Increase)
        End Select
        lblTest.Text = charX
    End Sub

    Private Sub frmMainScr_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        tmrAnim.Enabled = False ' Stops animation
        ' Sets whatever frame is currently visible to the idle image in respect to the direction the player is facing
        If charDir = 1 And pcbPlayer1.Visible = True Then
            pcbPlayer1.Image = warIdleL
        ElseIf charDir = 1 And pcbPlayer2.Visible = True Then
            pcbPlayer2.Image = warIdleL
        ElseIf charDir = 1 And pcbPlayer3.Visible = True Then
            pcbPlayer3.Image = warIdleL
        ElseIf charDir = 1 And pcbPlayer4.Visible = True Then
            pcbPlayer4.Image = warIdleL
        ElseIf charDir = 2 And pcbPlayer1.Visible = True Then
            pcbPlayer1.Image = warIdleR
        ElseIf charDir = 2 And pcbPlayer2.Visible = True Then
            pcbPlayer2.Image = warIdleR
        ElseIf charDir = 2 And pcbPlayer3.Visible = True Then
            pcbPlayer3.Image = warIdleR
        ElseIf charDir = 2 And pcbPlayer4.Visible = True Then
            pcbPlayer4.Image = warIdleR
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        exitWarning.Show() ' Shows exit screen
    End Sub
End Class