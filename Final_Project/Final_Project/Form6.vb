Imports System.IO
Public Class frmLoadScr
    Dim usrSelection As String
    Dim file2 As String
    'Dim playerInf As playerInfo
    Private Sub frmLoadScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Checks saves file for save files
        For Each foundFile As String In
        My.Computer.FileSystem.GetFiles(resPath & "\Saves\")
            ' Removes path and ".txt" from file names and shows them in the list box
            file2 = Replace(foundFile, resPath & "\Saves\", "")
            lstSaves.Items.Add(Replace(file2, ".txt", ""))
        Next
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide() ' "Closes" the window
        frmLaunchScr.Show()
    End Sub

    Private Sub lstSaves_MouseClick(sender As Object, e As MouseEventArgs) Handles lstSaves.MouseClick
        ' Determines the user's selection
        usrSelection = lstSaves.SelectedItem
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' Opens save file
        Using r As StreamReader = New StreamReader(resPath & "\Saves\" & usrSelection & ".txt")
            ' Sets player's variables from save file
            playerInf.name = r.ReadLine
            playerInf.HP = r.ReadLine
            playerInf.HPM = r.ReadLine
            playerInf.MP = r.ReadLine
            playerInf.MPM = r.ReadLine
            playerInf.strength = r.ReadLine
            playerInf.intelligence = r.ReadLine
            playerInf.agility = r.ReadLine
            playerInf.activeBracers = r.ReadLine
            playerInf.activeChest = r.ReadLine
            playerInf.activeGloves = r.ReadLine
            playerInf.activeHelm = r.ReadLine
            playerInf.activeLegs = r.ReadLine
            playerInf.activeWepL = r.ReadLine
            playerInf.activeWepR = r.ReadLine
            playerInf.charClass = r.ReadLine
            playerInf.level = r.ReadLine
            playerInf.exp = r.ReadLine
            playerInf.moneyAmount = r.ReadLine
            playerInf.charX = r.ReadLine
            playerInf.charY = r.ReadLine
            playerInf.dungeonID = r.ReadLine
            playerInf.dungeonRM = r.ReadLine
            ReDim playerInf.inventory(r.ReadLine)
        End Using
        ' Opens inventory file
        Dim run As Boolean = False
        Using r As StreamReader = New StreamReader(resPath & "\Saves\Inventorys\" & usrSelection & "Inv" & ".txt")
            Dim count As Integer
            For i As Integer = 0 To playerInf.inventory.Length - 1
                playerInf.inventory(i) = Val(r.ReadLine)
                If playerInf.inventory(i) >= 1 And playerInf.inventory(i) <= 3 Then ' Weapon index
                    If playerInf.inventory(i) = 1 Then ' If the player is equipping daggers
                        If count = 0 Then
                            charInfoScr.cboRHand.Items.Add(itemIndex(playerInf.inventory(i)))
                            count = 1
                        ElseIf count = 1 Then
                            charInfoScr.cboLHand.Items.Add(itemIndex(playerInf.inventory(i)))
                            count = 0
                        End If
                    Else
                        If count = 0 Then
                            charInfoScr.cboRHand.Items.Add(itemIndex(playerInf.inventory(i)))
                            count = 1
                        ElseIf count = 1 Then
                            charInfoScr.cboLHand.Items.Add(itemIndex(playerInf.inventory(i)))
                            count = 0
                        End If
                    End If
                ElseIf playerInf.inventory(i) >= 4 And playerInf.inventory(i) <= 5 Then ' Head item index
                    charInfoScr.cboHead.Items.Add(itemIndex(playerInf.inventory(i)))
                ElseIf playerInf.inventory(i) >= 6 And playerInf.inventory(i) <= 6 Then ' Glove index
                    charInfoScr.cboGloves.Items.Add(itemIndex(playerInf.inventory(i)))
                ElseIf playerInf.inventory(i) >= 7 And playerInf.inventory(i) <= 9 Then ' Leg item index
                    charInfoScr.cboLegs.Items.Add(itemIndex(playerInf.inventory(i)))
                ElseIf playerInf.inventory(i) >= 10 And playerInf.inventory(i) <= 12 Then ' Chest item index
                    charInfoScr.cboChest.Items.Add(itemIndex(playerInf.inventory(i)))
                ElseIf playerInf.inventory(i) >= 13 And playerInf.inventory(i) <= 13 Then ' Bracer index
                    charInfoScr.cboBracer.Items.Add(itemIndex(playerInf.inventory(i)))
                End If
                mainScr.lblTest2.Text += playerInf.inventory(i).ToString
            Next
        End Using
        ' Calculates and stores damage
        playerInf.dmg = items(playerInf.activeWepL).dmg + items(playerInf.activeWepR).dmg + (20 + playerInf.level)
        ' Calculates and stores armor
        playerInf.armor = items(playerInf.activeBracers).armor + items(playerInf.activeChest).armor + items(playerInf.activeGloves).armor + items(playerInf.activeHelm).armor + items(playerInf.activeLegs).armor
        ' Launches main window and hides load screen
        mapScr.Show()
        Me.Hide()
    End Sub
End Class