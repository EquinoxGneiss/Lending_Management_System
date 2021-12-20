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
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactiomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbLoan = New System.Windows.Forms.PictureBox()
        Me.pbWithdraw = New System.Windows.Forms.PictureBox()
        Me.pbDeposit = New System.Windows.Forms.PictureBox()
        Me.pbManage = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWithdraw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.TransactiomToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripMenuItem, Me.WithdrawToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.FileToolStripMenuItem.Text = "Manage"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'WithdrawToolStripMenuItem
        '
        Me.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem"
        Me.WithdrawToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.WithdrawToolStripMenuItem.Text = "Withdraw and Deposit"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'TransactiomToolStripMenuItem
        '
        Me.TransactiomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem})
        Me.TransactiomToolStripMenuItem.Name = "TransactiomToolStripMenuItem"
        Me.TransactiomToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TransactiomToolStripMenuItem.Text = "Transaction"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SummaryToolStripMenuItem.Text = "About"
        '
        'pbLoan
        '
        Me.pbLoan.BackColor = System.Drawing.Color.Transparent
        Me.pbLoan.BackgroundImage = CType(resources.GetObject("pbLoan.BackgroundImage"), System.Drawing.Image)
        Me.pbLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLoan.Location = New System.Drawing.Point(318, 87)
        Me.pbLoan.Name = "pbLoan"
        Me.pbLoan.Size = New System.Drawing.Size(131, 118)
        Me.pbLoan.TabIndex = 5
        Me.pbLoan.TabStop = False
        '
        'pbWithdraw
        '
        Me.pbWithdraw.BackColor = System.Drawing.Color.Transparent
        Me.pbWithdraw.BackgroundImage = CType(resources.GetObject("pbWithdraw.BackgroundImage"), System.Drawing.Image)
        Me.pbWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbWithdraw.Location = New System.Drawing.Point(502, 87)
        Me.pbWithdraw.Name = "pbWithdraw"
        Me.pbWithdraw.Size = New System.Drawing.Size(131, 118)
        Me.pbWithdraw.TabIndex = 6
        Me.pbWithdraw.TabStop = False
        '
        'pbDeposit
        '
        Me.pbDeposit.BackColor = System.Drawing.Color.Transparent
        Me.pbDeposit.BackgroundImage = CType(resources.GetObject("pbDeposit.BackgroundImage"), System.Drawing.Image)
        Me.pbDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDeposit.Location = New System.Drawing.Point(677, 87)
        Me.pbDeposit.Name = "pbDeposit"
        Me.pbDeposit.Size = New System.Drawing.Size(131, 118)
        Me.pbDeposit.TabIndex = 7
        Me.pbDeposit.TabStop = False
        '
        'pbManage
        '
        Me.pbManage.BackColor = System.Drawing.Color.Transparent
        Me.pbManage.BackgroundImage = CType(resources.GetObject("pbManage.BackgroundImage"), System.Drawing.Image)
        Me.pbManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbManage.Location = New System.Drawing.Point(851, 87)
        Me.pbManage.Name = "pbManage"
        Me.pbManage.Size = New System.Drawing.Size(131, 118)
        Me.pbManage.TabIndex = 8
        Me.pbManage.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 707)
        Me.Controls.Add(Me.pbManage)
        Me.Controls.Add(Me.pbDeposit)
        Me.Controls.Add(Me.pbWithdraw)
        Me.Controls.Add(Me.pbLoan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Lending Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWithdraw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
End Class
