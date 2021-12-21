Public Class transactions
    Private Sub transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Transact.transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.Transact.transactions)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class