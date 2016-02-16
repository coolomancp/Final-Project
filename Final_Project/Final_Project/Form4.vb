Public Class frmLaunchScr
    Dim mainScr As New frmMainScr
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        mainScr.Show()
        Me.Hide()
    End Sub
End Class