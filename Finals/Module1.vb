Module Module1

    Public NumberOfAccounts As Integer

    Structure PlayerType
        Dim AccountName As String
        Dim AccountType As String
        Dim Withdraw As Integer
        Dim Deposit As Integer
        Dim OverDraft As Boolean
        Dim CustomerName As String
        Dim CostumerAddress As String
    End Structure

    Public Bank(19) As PlayerType

    Public customer As PlayerType

End Module
