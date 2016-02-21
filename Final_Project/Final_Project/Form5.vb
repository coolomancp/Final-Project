Public Class frmExitWarning
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Application.Exit()
        frmMainScr.wmpAmbient = Nothing
        frmMainScr.wmpMusic = Nothing
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
    End Sub
End Class