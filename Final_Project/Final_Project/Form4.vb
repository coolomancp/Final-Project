Public Class frmLaunchScr
    Dim mainScr As New frmMainScr
    Dim mainScrStat As Boolean = False
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' Temp code to open other forms for testing
        If mainScrStat = False Then ' Checks if the main screen is closed
            mainScr.Show() ' Opens the main screen
            mainScrStat = True ' Main screen status is set as open
        ElseIf mainScrStat = True Then ' Checks if the main screen is open
            mainScr.Hide() ' Closes the main screen
            mainScrStat = False ' Main screen status is set to closed
        End If
    End Sub
End Class