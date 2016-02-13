Public Class frmCharScreen

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
        If txtChngCN.Text IsNot "" Then 'Prevents user from entering nothing as a character name
            lblCNVal.Text = txtChngCN.Text
        End If
    End Sub

    Private Sub recHealthBarV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
