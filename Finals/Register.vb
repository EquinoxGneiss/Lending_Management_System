Imports System.Data.OleDb
Public Class Register

    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\JJ\source\repos\EquinoxGniess\Lending_Management_System\Finals\accounts.accdb;"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM member WHERE [USERNAME] = @USERNAME OR [PASSWORD] = @PASSWORD", con)
            cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUsername.Text.Trim
            cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If txtConfirmPassword.Text <> txtPassword.Text Then
                MessageBox.Show("Password didn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If count > 0 Then
                    MessageBox.Show("Username and Password is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End Using

        Using create As New OleDbCommand("INSERT INTO member([USERNAME],[PASSWORD],[CONTACT],[EMAIL])VALUES(@USERNAME,@PASSWORD,@CONTACT,@EMAIL)", con)
            create.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUsername.Text.Trim
            create.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim
            create.Parameters.AddWithValue("@CONTACT", OleDbType.VarChar).Value = txtContact.Text.Trim
            create.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = txtEmail.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Account created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Clear()
                txtPassword.Clear()
                txtConfirmPassword.Clear()
                txtContact.Clear()
                txtEmail.Clear()
            End If
        End Using
        con.Close()

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.hide

        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.view
        txtPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.hide

        If txtConfirmPassword.UseSystemPasswordChar = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.view
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class