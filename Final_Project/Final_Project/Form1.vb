Public Class frmCharScreen
    Dim playerInfo As playerInfo
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Sets all of the comboboxes starting text to "(none)"
        cboBracer.Text = "(none)"
        cboChest.Text = "(none)"
        cboGloves.Text = "(none)"
        cboHead.Text = "(none)"
        cboLegs.Text = "(none)"
        cboLHand.Text = "(none)"
        cboRHand.Text = "(none)"
    End Sub

    Private Sub cboChest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChest.SelectedIndexChanged

    End Sub

    Private Sub cboLegs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLegs.SelectedIndexChanged

    End Sub

    Private Sub cboBracer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBracer.SelectedIndexChanged

    End Sub

    Private Sub cboLHand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLHand.SelectedIndexChanged

    End Sub

    Private Sub panLegsF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlLegsF.Paint

    End Sub

    Private Sub panLegsB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlLegsB.Paint

    End Sub

    Private Sub panWepLeftF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlWepLeftF.Paint

    End Sub

    Private Sub panWepLeftB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlWepLeftB.Paint

    End Sub

    Private Sub panBracerF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlBracerF.Paint

    End Sub

    Private Sub panBracerB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlBracerB.Paint

    End Sub

    Private Sub panHeadF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlHeadF.Paint

    End Sub

    Private Sub panHeadB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlHeadB.Paint

    End Sub

    Private Sub panChestF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlChestF.Paint

    End Sub

    Private Sub panChestB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlChestB.Paint

    End Sub

    Private Sub cboHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHead.SelectedIndexChanged

    End Sub

    Private Sub cboRHand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRHand.SelectedIndexChanged

    End Sub

    Private Sub cboGloves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGloves.SelectedIndexChanged

    End Sub

    Private Sub panWepRightF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlWepRightF.Paint

    End Sub

    Private Sub panWepRightB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlWepRightB.Paint

    End Sub

    Private Sub panGlovesF_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlGlovesF.Paint

    End Sub

    Private Sub panGlovesB_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlGlovesB.Paint

    End Sub

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click

    End Sub

    Private Sub btnConfirmNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmNC.Click
        Dim validInp1 As Boolean = txtChngCN.Text Like "[A-Z]*[A-Z]" ' Allows name to be upper case
        Dim validInp2 As Boolean = txtChngCN.Text Like "[a-z]*[a-z]" ' Allows name to be lower case
        Dim validInp3 As Boolean = txtChngCN.Text Like "[A-Z]*[a-z]" ' Allows name to start upper case and end lower case
        Dim validInp4 As Boolean = txtChngCN.Text Like "[a-z]*[A-Z]" ' Allows name to start lower case and end upper case
        If validInp1 = True Or validInp2 = True Or validInp3 = True Or validInp4 = True And txtChngCN.Text IsNot "" Then 'Prevents user from entering an invalid name
            lblCNVal.Text = txtChngCN.Text
            playerInfo.name = txtChngCN.Text
            txtChngCN.Clear()
        Else
            txtChngCN.Clear()
            MessageBox.Show("Please only enter letters (A-Z)")
        End If
    End Sub

    Private Sub recHealthBarV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
