Public Class frmLaunchScr
    Dim loadScr As New frmLoadScr
    Dim playerInf As playerInfo
    Dim mainScr As New frmMainScr
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' Default player stats
        playerInf.HP = 100
        playerInf.HPM = 100
        playerInf.MP = 50
        playerInf.MPM = 50
        playerInf.name = "[Debug]"
        playerInf.strength = 25
        playerInf.intelligence = 10
        playerInf.agility = 15
        playerInf.activeHelm = "(none)"
        playerInf.activeChest = "(none)"
        playerInf.activeLegs = "(none)"
        playerInf.activeGloves = "(none)"
        playerInf.activeBracers = "(none)"
        playerInf.activeWepL = "(none)"
        playerInf.activeWepR = "(none)"
        playerInf.charClass = "(none)"
        mainScr.Show() ' Shows main screen
        Me.Hide() ' Hides launch screen
    End Sub

    Private Sub frmLaunchScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With picLogo
            .Parent = picBackground
        End With
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadScr.Show()
    End Sub
End Class