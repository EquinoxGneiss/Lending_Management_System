Imports System.Data.OleDb
Public Class Loan
    Dim index As Integer
    Dim computePayment As Integer
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\gamed\source\repos\EquinoxGniess\Lending_Management_System\Finals\accounts.accdb"

    Dim Balance As Double
    Dim Interest As Double
    Dim Months As Integer
    Dim Payment As Double
    Dim MonthlyInterest As Double
    Dim Multiplier As Double
    Dim LoanBalance As Double
    Dim FinalPayment As Double
    Dim PaymentNumber As Integer
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewLoan.Click
        If computePayment Then
        Else
            nudMonths.Text = ""
        End If
        txtAnalysis.Text = ""
        btnCompute.Enabled = True
        btnNewLoan.Enabled = False
        txtBalance.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCompute.Click


        If txtBalance.Text <> "" Then
            Balance = Val(txtBalance.Text)
        Else
            MessageBox.Show("Must enter a Loan Balance value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtBalance.Focus()
            Return
        End If

        If txtInterest.Text <> "" Then
            Interest = Val(txtInterest.Text)
        Else
            MessageBox.Show("Must enter an Interest Rate value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInterest.Focus()
            Return
        End If

        MonthlyInterest = Interest / 1200
        If computePayment Then
            If nudMonths.Text <> "" Then
                Months = Val(nudMonths.Text)
            Else
                MessageBox.Show("Must enter a Number of Months value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                nudMonths.Focus()
                Return
            End If
            If Interest = 0 Then
                Payment = Balance / Months
            Else
                Multiplier = CDbl((1 + MonthlyInterest) ^ Months)
                Payment = Balance * MonthlyInterest * Multiplier / (Multiplier - 1)
            End If
            txtPayment.Text = Format(Payment, "0.00")
        Else
            If txtPayment.Text <> "" Then
                Payment = Val(txtPayment.Text)
                If Payment <= (Balance * MonthlyInterest + 1.0) Then
                    If MessageBox.Show("Minimum payment must be " + Format(CInt(Balance * MonthlyInterest + 1.0), "₱0.00") +
                                       ControlChars.CrLf + "Do you want to use the minimum payment?", "Input Error",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        txtPayment.Text = Format(CInt(Balance * MonthlyInterest + 1.0), "0.00")
                        Payment = Val(txtPayment.Text)
                    Else
                        txtPayment.Focus()
                        Return
                    End If
                End If
            Else
                MessageBox.Show("Must enter a Monthly Payment value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPayment.Focus()
                Return
            End If
            If Interest = 0 Then
                Months = CInt(Balance / Payment)
            Else
                Months = CInt((Math.Log(Payment) - Math.Log(Payment - Balance * MonthlyInterest)) / Math.Log(1 + MonthlyInterest))
            End If
            nudMonths.Text = Format(Months, "0")
        End If

        Payment = Val(txtPayment.Text)

        txtAnalysis.Text = "Loan Balance: " + vbTab + vbTab + Format(Balance, "₱0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Interest Rate: " + vbTab + vbTab + Format(Interest, "₱0.00") + "%"

        LoanBalance = Balance
        For PaymentNumber = 1 To Months - 1
            LoanBalance += LoanBalance * MonthlyInterest - Payment
        Next PaymentNumber

        FinalPayment = LoanBalance
        If FinalPayment > Payment Then
            LoanBalance += LoanBalance * MonthlyInterest - Payment
            FinalPayment = LoanBalance
            Months += 1
            nudMonths.Text = Format(Months, "0")
        End If

        customer.CustomerName = txtname.Text
        customer.CostumerAddress = txtaddress.Text

        txtAnalysis.Text += ControlChars.CrLf + ControlChars.CrLf + Format(Months - 1, "0") + " Payments of " + vbTab + vbTab + Format(Payment, "₱0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Final Payment of: " + vbTab + vbTab + Format(FinalPayment, "₱0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Total Payments: " + vbTab + vbTab + Format((Months - 1) * Payment + FinalPayment, "₱0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Interest Paid " + vbTab + vbTab + Format((Months - 1) * Payment + FinalPayment - Balance, "₱0.00")


        btnCompute.Enabled = False
        btnNewLoan.Enabled = True
        btnNewLoan.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Using create As New OleDbCommand("INSERT INTO transactions ([AMOUNT],[LOAN_TYPE],[INTEREST_RATE],[NUMBER_OF_PAYMENT],[MONTHLY_PAYMENT],[FINAL_PAYMENT],[TIME],[DATE_AND_MONTH])VALUES(@AMOUNT,@LOAN_TYPE,@INTEREST_RATE,@NUMBER_OF_PAYMENT,@MONTHLY_PAYMENT,@FINAL_PAYMENT,@TIME,@DATE_AND_MONTH)", con)
            create.Parameters.AddWithValue("@AMOUNT", OleDbType.VarChar).Value = txtBalance.Text.Trim
            create.Parameters.AddWithValue("@LOAN_TYPE", OleDbType.VarChar).Value = ComboBox1.Text.Trim
            create.Parameters.AddWithValue("@INTEREST_RATE", OleDbType.VarChar).Value = txtInterest.Text.Trim
            create.Parameters.AddWithValue("@NUMBER_OF_PAYMENT", OleDbType.VarChar).Value = nudMonths.Text.Trim
            create.Parameters.AddWithValue("@MONTHLY_PAYMENT", OleDbType.VarChar).Value = txtPayment.Text.Trim
            create.Parameters.AddWithValue("@FINAL_PAYMENT", OleDbType.VarChar).Value = FinalPayment
            create.Parameters.AddWithValue("@TIME", OleDbType.VarChar).Value = Time.Text
            create.Parameters.AddWithValue("@DATE_AND_MONTH", OleDbType.VarChar).Value = DateandMonth.Text
            If create.ExecuteNonQuery Then
                MsgBox("Loan Transferred into your account", MsgBoxStyle.Information)
                txtBalance.Clear()
                txtInterest.Clear()
                txtPayment.Clear()
            End If
        End Using
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
        DateandMonth.Text = FormatDateTime(Today)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeString
    End Sub

    Private Sub DateandMonth_Click(sender As Object, e As EventArgs) Handles DateandMonth.Click

    End Sub
End Class