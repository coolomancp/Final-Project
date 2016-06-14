Public Class frmMap
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If rdbGreatPlains.Checked = True Then
            monstmulti.level = 1 ' Sets level of monsters
            dungeon.monstertype = "Goblin" ' Dungeon monster type set as Goblins
            dungeon.monstNum = 2 ' Number of monsters
            dungeon.difficulty = (1 * Val(cboMultiplier.Text)) ' Easy difficulty
            dungeon.type = "grasslands" ' Sets dungeon type
            dungeon.numOfRms = 4 ' 4 room dungeon
            playerInf.dungeonRM = 1 ' Resets player to first room
            mainScr.Refresh()
            mainScr.Show()
            Me.Hide()
        ElseIf rdbBadlands.Checked = True Then
            rdbBadlands.Checked = False
            MsgBox("Low level! Please return at level 100")
        End If
    End Sub
    ' Refreshes the map to show current progress
    Sub refreshProg()
        mapProg = playerInf.dungeonID
        Select Case mapProg
            Case Is >= 1
                rdbNSShop.Enabled = True
                rdbGondar.Enabled = True
            Case Is >= 2
                rdbOldtown.Enabled = True
            Case Is >= 3
                rdbLionguard.Enabled = True
            Case Is >= 4
                rdbMountains.Enabled = True
            Case Is >= 5
                rdbVikinghelmPort.Enabled = True
            Case Is >= 6
                rdbBattlePlain.Enabled = True
            Case Is >= 7
                rdbYgg.Enabled = True
            Case Is >= 8
                rdbDarkForest.Enabled = True
            Case Is >= 9
                rdbMountDeath.Enabled = True
            Case Is >= 10
                rdbDarkTower.Enabled = True
        End Select
    End Sub
End Class