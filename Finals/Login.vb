Imports System.Data.OleDb
Public Class Login
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\gamed\Documents\FinalsVb.net\Finals\Finals\accounts.accdb;"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click



        If txtUser.Text = Nothing Or txtPass.Text = Nothing Then
            MessageBox.Show("Please enter correct credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using login As New OleDbCommand("SELECT COUNT(*) FROM member WHERE [USERNAME] = @USERNAME OR [PASSWORD] = @PASSWORD", con)
            login.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUser.Text.Trim
            login.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPass.Text.Trim

            Dim logincount = Convert.ToInt32(login.ExecuteScalar())
            If logincount > 0 Then
                MessageBox.Show("Login Successfully!", "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Main.Show()
            Else
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUser.Clear()
                txtPass.Clear()
            End If
        End Using
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
        Me.CenterToScreen()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub pbshow_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub pbshow_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbshow_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbshow_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.hide

        If txtPass.UseSystemPasswordChar = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.view
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
    End Sub
End Class