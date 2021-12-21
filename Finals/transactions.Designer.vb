<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transactions))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccountsDataSet = New Finals.accountsDataSet()
        Me.AccountsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transact = New Finals.transact()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New Finals.transactTableAdapters.transactionsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOANTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INTERESTRATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMBEROFPAYMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTHLYPAYMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINALPAYMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEANDMONTHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.AMOUNTDataGridViewTextBoxColumn, Me.LOANTYPEDataGridViewTextBoxColumn, Me.INTERESTRATEDataGridViewTextBoxColumn, Me.NUMBEROFPAYMENTDataGridViewTextBoxColumn, Me.MONTHLYPAYMENTDataGridViewTextBoxColumn, Me.FINALPAYMENTDataGridViewTextBoxColumn, Me.TIMEDataGridViewTextBoxColumn, Me.DATEANDMONTHDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TransactionsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1346, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'AccountsDataSet
        '
        Me.AccountsDataSet.DataSetName = "accountsDataSet"
        Me.AccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsDataSetBindingSource
        '
        Me.AccountsDataSetBindingSource.DataSource = Me.AccountsDataSet
        Me.AccountsDataSetBindingSource.Position = 0
        '
        'Transact
        '
        Me.Transact.DataSetName = "transact"
        Me.Transact.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "transactions"
        Me.TransactionsBindingSource.DataSource = Me.Transact
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'AMOUNTDataGridViewTextBoxColumn
        '
        Me.AMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.Name = "AMOUNTDataGridViewTextBoxColumn"
        Me.AMOUNTDataGridViewTextBoxColumn.Width = 150
        '
        'LOANTYPEDataGridViewTextBoxColumn
        '
        Me.LOANTYPEDataGridViewTextBoxColumn.DataPropertyName = "LOAN_TYPE"
        Me.LOANTYPEDataGridViewTextBoxColumn.HeaderText = "LOAN_TYPE"
        Me.LOANTYPEDataGridViewTextBoxColumn.Name = "LOANTYPEDataGridViewTextBoxColumn"
        Me.LOANTYPEDataGridViewTextBoxColumn.Width = 150
        '
        'INTERESTRATEDataGridViewTextBoxColumn
        '
        Me.INTERESTRATEDataGridViewTextBoxColumn.DataPropertyName = "INTEREST_RATE"
        Me.INTERESTRATEDataGridViewTextBoxColumn.HeaderText = "INTEREST_RATE"
        Me.INTERESTRATEDataGridViewTextBoxColumn.Name = "INTERESTRATEDataGridViewTextBoxColumn"
        Me.INTERESTRATEDataGridViewTextBoxColumn.Width = 150
        '
        'NUMBEROFPAYMENTDataGridViewTextBoxColumn
        '
        Me.NUMBEROFPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "NUMBER_OF_PAYMENT"
        Me.NUMBEROFPAYMENTDataGridViewTextBoxColumn.HeaderText = "NUMBER_OF_PAYMENT"
        Me.NUMBEROFPAYMENTDataGridViewTextBoxColumn.Name = "NUMBEROFPAYMENTDataGridViewTextBoxColumn"
        Me.NUMBEROFPAYMENTDataGridViewTextBoxColumn.Width = 150
        '
        'MONTHLYPAYMENTDataGridViewTextBoxColumn
        '
        Me.MONTHLYPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "MONTHLY_PAYMENT"
        Me.MONTHLYPAYMENTDataGridViewTextBoxColumn.HeaderText = "MONTHLY_PAYMENT"
        Me.MONTHLYPAYMENTDataGridViewTextBoxColumn.Name = "MONTHLYPAYMENTDataGridViewTextBoxColumn"
        Me.MONTHLYPAYMENTDataGridViewTextBoxColumn.Width = 150
        '
        'FINALPAYMENTDataGridViewTextBoxColumn
        '
        Me.FINALPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "FINAL_PAYMENT"
        Me.FINALPAYMENTDataGridViewTextBoxColumn.HeaderText = "FINAL_PAYMENT"
        Me.FINALPAYMENTDataGridViewTextBoxColumn.Name = "FINALPAYMENTDataGridViewTextBoxColumn"
        Me.FINALPAYMENTDataGridViewTextBoxColumn.Width = 150
        '
        'TIMEDataGridViewTextBoxColumn
        '
        Me.TIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME"
        Me.TIMEDataGridViewTextBoxColumn.HeaderText = "TIME"
        Me.TIMEDataGridViewTextBoxColumn.Name = "TIMEDataGridViewTextBoxColumn"
        Me.TIMEDataGridViewTextBoxColumn.Width = 150
        '
        'DATEANDMONTHDataGridViewTextBoxColumn
        '
        Me.DATEANDMONTHDataGridViewTextBoxColumn.DataPropertyName = "DATE_AND_MONTH"
        Me.DATEANDMONTHDataGridViewTextBoxColumn.HeaderText = "DATE_AND_MONTH"
        Me.DATEANDMONTHDataGridViewTextBoxColumn.Name = "DATEANDMONTHDataGridViewTextBoxColumn"
        Me.DATEANDMONTHDataGridViewTextBoxColumn.Width = 150
        '
        'transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AccountsDataSet As accountsDataSet
    Friend WithEvents AccountsDataSetBindingSource As BindingSource
    Friend WithEvents Transact As transact
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As transactTableAdapters.transactionsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AMOUNTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOANTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INTERESTRATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMBEROFPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MONTHLYPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FINALPAYMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEANDMONTHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
