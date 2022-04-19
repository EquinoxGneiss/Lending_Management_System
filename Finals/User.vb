Imports System.Data.OleDb
Imports System.IO.File
Imports System.IO.FileStream
Public Class User
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\gamed\source\repos\EquinoxGniess\Lending_Management_System\Finals\accounts.accdb"
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using useracc As New OleDbCommand("SELECT COUNT(*) FROM member WHERE ")

    End Sub

    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged

    End Sub
End Class