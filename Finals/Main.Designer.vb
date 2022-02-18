<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactiomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbLoan = New System.Windows.Forms.PictureBox()
        Me.pbWithdraw = New System.Windows.Forms.PictureBox()
        Me.pbDeposit = New System.Windows.Forms.PictureBox()
        Me.pbManage = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.DateandMonth = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWithdraw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransactiomToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripMenuItem, Me.WithdrawToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.FileToolStripMenuItem.Text = "Manage"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'WithdrawToolStripMenuItem
        '
        Me.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem"
        Me.WithdrawToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.WithdrawToolStripMenuItem.Text = "Withdraw and Deposit"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'TransactiomToolStripMenuItem
        '
        Me.TransactiomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem})
        Me.TransactiomToolStripMenuItem.Name = "TransactiomToolStripMenuItem"
        Me.TransactiomToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.TransactiomToolStripMenuItem.Text = "Transaction"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.SummaryToolStripMenuItem.Text = "About"
        '
        'pbLoan
        '
        Me.pbLoan.BackColor = System.Drawing.Color.Transparent
        Me.pbLoan.BackgroundImage = CType(resources.GetObject("pbLoan.BackgroundImage"), System.Drawing.Image)
        Me.pbLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLoan.Location = New System.Drawing.Point(424, 107)
        Me.pbLoan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbLoan.Name = "pbLoan"
        Me.pbLoan.Size = New System.Drawing.Size(175, 145)
        Me.pbLoan.TabIndex = 5
        Me.pbLoan.TabStop = False
        '
        'pbWithdraw
        '
        Me.pbWithdraw.BackColor = System.Drawing.Color.Transparent
        Me.pbWithdraw.BackgroundImage = CType(resources.GetObject("pbWithdraw.BackgroundImage"), System.Drawing.Image)
        Me.pbWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbWithdraw.Location = New System.Drawing.Point(669, 107)
        Me.pbWithdraw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbWithdraw.Name = "pbWithdraw"
        Me.pbWithdraw.Size = New System.Drawing.Size(175, 145)
        Me.pbWithdraw.TabIndex = 6
        Me.pbWithdraw.TabStop = False
        '
        'pbDeposit
        '
        Me.pbDeposit.BackColor = System.Drawing.Color.Transparent
        Me.pbDeposit.BackgroundImage = CType(resources.GetObject("pbDeposit.BackgroundImage"), System.Drawing.Image)
        Me.pbDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDeposit.Location = New System.Drawing.Point(903, 107)
        Me.pbDeposit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbDeposit.Name = "pbDeposit"
        Me.pbDeposit.Size = New System.Drawing.Size(175, 145)
        Me.pbDeposit.TabIndex = 7
        Me.pbDeposit.TabStop = False
        '
        'pbManage
        '
        Me.pbManage.BackColor = System.Drawing.Color.Transparent
        Me.pbManage.BackgroundImage = CType(resources.GetObject("pbManage.BackgroundImage"), System.Drawing.Image)
        Me.pbManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbManage.Location = New System.Drawing.Point(1135, 107)
        Me.pbManage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbManage.Name = "pbManage"
        Me.pbManage.Size = New System.Drawing.Size(175, 145)
        Me.pbManage.TabIndex = 8
        Me.pbManage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 256)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Loan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(685, 256)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 31)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Withdraw"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(928, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 31)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Deposit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1189, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 31)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "User"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.BackColor = System.Drawing.Color.Transparent
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(16, 46)
        Me.Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(78, 31)
        Me.Time.TabIndex = 13
        Me.Time.Text = "Time"
        '
        'DateandMonth
        '
        Me.DateandMonth.AutoSize = True
        Me.DateandMonth.BackColor = System.Drawing.Color.Transparent
        Me.DateandMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateandMonth.Location = New System.Drawing.Point(237, 46)
        Me.DateandMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateandMonth.Name = "DateandMonth"
        Me.DateandMonth.Size = New System.Drawing.Size(76, 31)
        Me.DateandMonth.TabIndex = 14
        Me.DateandMonth.Text = "Date"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 353)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(531, 352)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(628, 353)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(531, 352)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1167, 353)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(531, 352)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(241, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1800, 870)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateandMonth)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbManage)
        Me.Controls.Add(Me.pbDeposit)
        Me.Controls.Add(Me.pbWithdraw)
        Me.Controls.Add(Me.pbLoan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lending Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWithdraw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactiomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithdrawToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbLoan As PictureBox
    Friend WithEvents pbWithdraw As PictureBox
    Friend WithEvents pbDeposit As PictureBox
    Friend WithEvents pbManage As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Time As Label
    Friend WithEvents DateandMonth As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
