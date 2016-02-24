Imports System.IO
Public Class frmSvFilRdr
    Dim usrSelection As String
    Dim file2 As String
    Dim plyrClass As String

    Private Sub lstSaves_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSaves.SelectedIndexChanged
        usrSelection = lstSaves.SelectedItem
        Using r As StreamReader = New StreamReader(txtSavesDirectory.Text & usrSelection & ".txt")
            ' Sets player's variables from save file
            txtCN.Text = r.ReadLine
            txtCH.Text = r.ReadLine
            txtMH.Text = r.ReadLine
            txtCM.Text = r.ReadLine
            txtMM.Text = r.ReadLine
            txtStr.Text = r.ReadLine
            txtInt.Text = r.ReadLine
            txtAgi.Text = r.ReadLine
            r.ReadLine()
            r.ReadLine()
            r.ReadLine()
            r.ReadLine()
            r.ReadLine()
            r.ReadLine()
            r.ReadLine()
            plyrClass = r.ReadLine
            txtLvl.Text = r.ReadLine
            txtMon.Text = r.ReadLine
        End Using
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        lstSaves.Items.Clear()
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtSavesDirectory.Text = FolderBrowserDialog1.SelectedPath + "\"
        End If
        For Each foundFile As String In
            My.Computer.FileSystem.GetFiles(txtSavesDirectory.Text)
            ' Removes path and ".txt" from file names and shows them in the list box
            file2 = Replace(foundFile, txtSavesDirectory.Text, "")
            lstSaves.Items.Add(Replace(file2, ".txt", ""))
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        File.WriteAllText(txtSavesDirectory.Text & Convert.ToString(usrSelection & ".txt"), "")
        Dim save() As String = {txtCN.Text, txtCH.Text, txtMH.Text, txtCM.Text, txtMM.Text, txtStr.Text, txtInt.Text, txtAgi.Text, "(none)", "(none)", "(none)", "(none)", "(none)", "(none)", "(none)", plyrClass, txtLvl.Text, txtMon.Text}
        File.AppendAllLines(txtSavesDirectory.Text & Convert.ToString(usrSelection & ".txt"), save)
    End Sub
End Class
