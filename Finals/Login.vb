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
End Class