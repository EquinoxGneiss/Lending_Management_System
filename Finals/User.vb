Imports System.IO.File
Imports System.IO.FileStream
Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AccountsDataSet.info' table. You can move, or remove it, as needed.
        Me.InfoTableAdapter.Fill(Me.AccountsDataSet.info)

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        InfoBindingSource.AddNew()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        On Error GoTo SaveErr
        InfoBindingSource.EndEdit()
        InfoTableAdapter.Update(AccountsDataSet.info)
        MessageBox.Show("Successfully Save!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr:
        Exit Sub
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.InfoTableAdapter.Search(Me.AccountsDataSet.info, LASTNAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        InfoBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        InfoBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        InfoBindingSource.MoveNext()
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        InfoBindingSource.MoveFirst()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        InfoBindingSource.MoveLast()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        txtpicture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub txtpicture_TextChanged(sender As Object, e As EventArgs) Handles txtpicture.TextChanged
        If (System.IO.File.Exists(txtpicture.Text)) Then
            PictureBox1.Image = Image.FromFile(txtpicture.Text)
        End If
        If txtpicture.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub LASTNAMEToolStripLabel_Click(sender As Object, e As EventArgs) Handles LASTNAMEToolStripLabel.Click

    End Sub
End Class