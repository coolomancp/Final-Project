Public Class frmLaunchScr
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.Hide() ' Hides launch screen
        creation.Show() ' Shows character creation screen
    End Sub

    Private Sub frmLaunchScr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        With picLogo
            .Parent = picBackground
        End With
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadScr.Show()
        Me.Hide()
    End Sub
End Class