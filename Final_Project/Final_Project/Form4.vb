Public Class frmLaunchScr
    Dim loadScr As New frmLoadScr
    Dim mainScr As New frmMainScr
    Dim playerInf As playerInfo
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Me.Hide() ' Hides launch screen
    End Sub

    Private Sub frmLaunchScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With picLogo
            .Parent = picBackground
        End With
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadScr.Show()
        Me.Hide()
    End Sub
End Class