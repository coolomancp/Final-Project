Public Class frmLaunchScr
    Dim mainScr As New frmMainScr
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        mainScr.Show()
        Me.Hide()
    End Sub

    Private Sub frmLaunchScr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With picLogo
            .Parent = picBackground
        End With
    End Sub
End Class