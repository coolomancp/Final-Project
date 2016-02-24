Imports System.IO
Public Class frmExitWarning
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        ' Saves player information into a txt file in a saves folder
        File.WriteAllText(resPath & "Saves\" & Convert.ToString(playerInf.name & ".txt"), "")
        Dim save() As String = {playerInf.name, playerInf.HP, playerInf.HPM, playerInf.MP, playerInf.MPM, playerInf.strength, playerInf.intelligence, playerInf.agility, playerInf.activeBracers, playerInf.activeChest, playerInf.activeGloves, playerInf.activeHelm, playerInf.activeLegs, playerInf.activeWepL, playerInf.activeWepR, playerInf.charClass, playerInf.level, playerInf.moneyAmount, playerInf.charX, playerInf.charY, playerInf.dungeonID, playerInf.dungeonRM}
        File.AppendAllLines(resPath & "Saves\" & Convert.ToString(playerInf.name & ".txt"), save)
        ' Frees up RAM from music
        frmMainScr.wmpAmbient = Nothing
        frmMainScr.wmpMusic = Nothing
        ' Exits
        Application.Exit()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
    End Sub
End Class