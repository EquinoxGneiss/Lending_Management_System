<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.btnnew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtpicture = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LASTNAMEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LASTNAMEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PICTUREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsDataSet = New Finals.accountsDataSet()
        Me.InfoTableAdapter = New Finals.accountsDataSetTableAdapters.infoTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchToolStrip.SuspendLayout()
        CType(Me.InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(164, 236)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lastname"
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfoBindingSource, "LASTNAME", True))
        Me.txtlastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(164, 50)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(399, 26)
        Me.txtlastname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Picture"
        '
        'txtfirstname
        '
        Me.txtfirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfoBindingSource, "FIRSTNAME", True))
        Me.txtfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(164, 91)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(399, 26)
        Me.txtfirstname.TabIndex = 7
        '
        'txtage
        '
        Me.txtage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfoBindingSource, "AGE", True))
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(164, 135)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(93, 26)
        Me.txtage.TabIndex = 8
        '
        'txtpicture
        '
        Me.txtpicture.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfoBindingSource, "PICTURE", True))
        Me.txtpicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpicture.Location = New System.Drawing.Point(164, 186)
        Me.txtpicture.Name = "txtpicture"
        Me.txtpicture.Size = New System.Drawing.Size(399, 26)
        Me.txtpicture.TabIndex = 10
        '
        'cmbgender
        '
        Me.cmbgender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfoBindingSource, "GENDER", True))
        Me.cmbgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbgender.Location = New System.Drawing.Point(389, 135)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(174, 28)
        Me.cmbgender.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(593, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(164, 265)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(75, 23)
        Me.btnprevious.TabIndex = 13
        Me.btnprevious.Text = "PREVIOUS"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(245, 236)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(245, 265)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 15
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(326, 236)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 16
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Location = New System.Drawing.Point(326, 265)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(75, 23)
        Me.btnfirst.TabIndex = 17
        Me.btnfirst.Text = "FIRST"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(407, 236)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 23)
        Me.btnremove.TabIndex = 18
        Me.btnremove.Text = "REMOVE"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(407, 265)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(75, 23)
        Me.btnlast.TabIndex = 19
        Me.btnlast.Text = "LAST"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(488, 236)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 52)
        Me.btnclose.TabIndex = 20
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(721, 265)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnbrowse.TabIndex = 21
        Me.btnbrowse.Text = "BROWSE"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.AGEDataGridViewTextBoxColumn, Me.PICTUREDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(164, 332)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(632, 209)
        Me.DataGridView1.TabIndex = 22
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LASTNAMEToolStripLabel, Me.LASTNAMEToolStripTextBox, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(944, 25)
        Me.SearchToolStrip.TabIndex = 23
        Me.SearchToolStrip.Text = "SearchToolStrip"
        '
        'LASTNAMEToolStripLabel
        '
        Me.LASTNAMEToolStripLabel.Name = "LASTNAMEToolStripLabel"
        Me.LASTNAMEToolStripLabel.Size = New System.Drawing.Size(70, 22)
        Me.LASTNAMEToolStripLabel.Text = "LASTNAME:"
        '
        'LASTNAMEToolStripTextBox
        '
        Me.LASTNAMEToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LASTNAMEToolStripTextBox.Name = "LASTNAMEToolStripTextBox"
        Me.LASTNAMEToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.SearchToolStripButton.Text = "Search"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'AGEDataGridViewTextBoxColumn
        '
        Me.AGEDataGridViewTextBoxColumn.DataPropertyName = "AGE"
        Me.AGEDataGridViewTextBoxColumn.HeaderText = "AGE"
        Me.AGEDataGridViewTextBoxColumn.Name = "AGEDataGridViewTextBoxColumn"
        '
        'PICTUREDataGridViewTextBoxColumn
        '
        Me.PICTUREDataGridViewTextBoxColumn.DataPropertyName = "PICTURE"
        Me.PICTUREDataGridViewTextBoxColumn.HeaderText = "PICTURE"
        Me.PICTUREDataGridViewTextBoxColumn.Name = "PICTUREDataGridViewTextBoxColumn"
        '
        'InfoBindingSource
        '
        Me.InfoBindingSource.DataMember = "info"
        Me.InfoBindingSource.DataSource = Me.AccountsDataSet
        '
        'AccountsDataSet
        '
        Me.AccountsDataSet.DataSetName = "accountsDataSet"
        Me.AccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InfoTableAdapter
        '
        Me.InfoTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(593, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 200)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "No Image Uploaded"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 561)
        Me.Controls.Add(Me.SearchToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.txtpicture)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label6)
        Me.Name = "User"
        Me.Text = "User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        CType(Me.InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtpicture As TextBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnlast As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnbrowse As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AccountsDataSet As accountsDataSet
    Friend WithEvents InfoBindingSource As BindingSource
    Friend WithEvents InfoTableAdapter As accountsDataSetTableAdapters.infoTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AGEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PICTUREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SearchToolStrip As ToolStrip
    Friend WithEvents LASTNAMEToolStripLabel As ToolStripLabel
    Friend WithEvents LASTNAMEToolStripTextBox As ToolStripTextBox
    Friend WithEvents SearchToolStripButton As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
End Class
