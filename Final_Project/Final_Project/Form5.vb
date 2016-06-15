Imports System.IO
Public Class frmExitWarning
    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnYes.Click
        ' Defines player's dungeon unlocks
        playerInf.dungeonID = mapProg
        ' Saves player information into a txt file in a saves folder
        File.WriteAllText(resPath & "\Saves\" & Convert.ToString(playerInf.name & ".txt"), "")
        Dim save() As String = {playerInf.name, playerInf.HP, playerInf.HPM, playerInf.MP, playerInf.MPM, playerInf.strength, playerInf.intelligence, playerInf.agility, playerInf.activeBracers, playerInf.activeChest, playerInf.activeGloves, playerInf.activeHelm, playerInf.activeLegs, playerInf.activeWepL, playerInf.activeWepR, playerInf.charClass, playerInf.level, playerInf.exp, playerInf.moneyAmount, playerInf.charX, playerInf.charY, playerInf.dungeonID, playerInf.dungeonRM, playerInf.inventory.Length - 1}
        File.AppendAllLines(resPath & "\Saves\" & Convert.ToString(playerInf.name & ".txt"), save) ' Saves all non-array information about the player
        ' Saves array-based information (inventory) to the save file
        File.WriteAllText(resPath & "\Saves\Inventorys\" & Convert.ToString(playerInf.name & "Inv" & ".txt"), "")
        Dim invToString() As String = Array.ConvertAll(Of Integer, String)(playerInf.inventory, Function(x) x.ToString()) ' Converts inventory to string for saving
        File.AppendAllLines(resPath & "\Saves\Inventorys\" & Convert.ToString(playerInf.name & "Inv" & ".txt"), invToString)
        ' Frees up RAM from music
        mainScr.wmpAmbient = Nothing
        mainScr.wmpMusic = Nothing
        ' Exits
        Application.Exit()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
    End Sub
End Class