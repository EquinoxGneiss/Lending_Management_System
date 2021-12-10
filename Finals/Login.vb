Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If txtUser.Text = "cruzjustin" Then
            If txtPass.Text = "200427" Then
                MsgBox("Login Successful!", vbInformation, "Welcome!")
                Main.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Password!", vbCritical, "Error")
            End If
        Else
            MsgBox("Incorrect Username!", vbCritical, "Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class