Imports System.IO
Public Class frmLoadScr
    Dim usrSelection As String
    Dim file2 As String
    'Dim playerInf As playerInfo
    Private Sub frmLoadScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Checks saves file for save files
        For Each foundFile As String In
        My.Computer.FileSystem.GetFiles(resPath & "Saves\")
            ' Removes path and ".txt" from file names and shows them in the list box
            file2 = Replace(foundFile, resPath & "Saves\", "")
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
        Using r As StreamReader = New StreamReader(resPath & "Saves\" & usrSelection & ".txt")
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
            playerInf.moneyAmount = r.ReadLine
            playerInf.charX = r.ReadLine
            playerInf.charY = r.ReadLine
            playerInf.dungeonID = r.ReadLine
            playerInf.dungeonRM = r.ReadLine
        End Using
        ' Launches main window and hides load screen
        mainScr.Refresh()
        mainScr.Show()
        Me.Hide()
    End Sub
End Class