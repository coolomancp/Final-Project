Public Class frmMainScr
    Dim inventoryScr As New frmInventory ' Inventory screen is loaded (hidden)
    Dim charInfoScr As New frmCharScreen ' Character Info screen is loaded (hidden)
    Dim invStat As Boolean = False ' Default status of the inventory screen is hidden
    Dim infStat As Boolean = False ' Default status of the char info screen is hidden
    Dim charX As Integer = 640 ' Player's starting x coord
    Dim charY As Integer = 330 ' Player's starting y coord
    Dim charMovSpd As Integer = 5 ' Player's movement speed
    Dim charDir As Boolean = True ' Is the player facing the right?

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
        If invStat = False Then ' 
            inventoryScr.Show()
            invStat = True
        ElseIf invStat = True Then
            inventoryScr.Hide()
            invStat = False
        End If
    End Sub

    Private Sub frmMainScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        With picPlayer
            .Parent = picMainScr
        End With
    End Sub
    Private Sub timeIdle_Tick(sender As Object, e As EventArgs) Handles timeIdle.Tick
        'If charDir = True Then
        '    picPlayer.Image = warIdleR
        'ElseIf charDir = False Then
        '    picPlayer.Image = warIdleL
        'End If
    End Sub

    Private Sub frmMainScr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar.ToString = "a" And charX > 0 Then
            charX = charX - charMovSpd
            picPlayer.Location = New Point(charX, charY) ' Moves player to the left
            picPlayer.Image = warWalkL
            charDir = False ' Player is facing the left
        ElseIf e.KeyChar.ToString = "d" And charX < 675 Then
            charX = charX + charMovSpd
            picPlayer.Location = New Point(charX, charY) ' Moves player to the right
            picPlayer.Image = warWalkR
            charDir = True ' Player is facing the right
        End If
    End Sub
End Class