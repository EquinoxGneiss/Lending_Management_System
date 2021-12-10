Public Class Main
    Private Sub LoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem.Click
        Loan.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbLoan.Click
        Loan.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbWithdraw.Click
        Loan.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbDeposit.Click
        Loan.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub pbLoan_MouseHover(sender As Object, e As EventArgs) Handles pbLoan.MouseHover
        Dim tt As New ToolTip()
        tt.SetToolTip(pbLoan, "Loan")
    End Sub
End Class
