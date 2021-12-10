Public Class Loan
    Dim index As Integer
    Dim computePayment As Integer

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
        Dim Balance As Double
        Dim Interest As Double
        Dim Months As Integer
        Dim Payment As Double
        Dim MonthlyInterest As Double
        Dim Multiplier As Double
        Dim LoanBalance As Double
        Dim FinalPayment As Double
        Dim PaymentNumber As Integer

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
        MsgBox("Loan Transferred into your account", MsgBoxStyle.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class