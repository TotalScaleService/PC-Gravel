<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Job_Details
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
        Dim Account_NameLabel As System.Windows.Forms.Label
        Dim Job_NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Job_NumberLabel As System.Windows.Forms.Label
        Dim Job_KeyLabel As System.Windows.Forms.Label
        Dim Show_PriceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Account_NameTextBox = New System.Windows.Forms.TextBox()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.Job_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Job_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Job_KeyTextBox = New System.Windows.Forms.TextBox()
        Me.Show_PriceCheckBox = New System.Windows.Forms.CheckBox()
        Me.grpProducts = New System.Windows.Forms.GroupBox()
        Me.Job_ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Deletebtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cboProductName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Job_ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.JobTableAdapter()
        Me.Job_ProductsTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter()
        Me.ProductTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter()
        Account_NameLabel = New System.Windows.Forms.Label()
        Job_NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Job_NumberLabel = New System.Windows.Forms.Label()
        Job_KeyLabel = New System.Windows.Forms.Label()
        Show_PriceLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProducts.SuspendLayout()
        CType(Me.Job_ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Job_ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Account_NameLabel
        '
        Account_NameLabel.AutoSize = True
        Account_NameLabel.Location = New System.Drawing.Point(34, 39)
        Account_NameLabel.Name = "Account_NameLabel"
        Account_NameLabel.Size = New System.Drawing.Size(131, 20)
        Account_NameLabel.TabIndex = 2
        Account_NameLabel.Text = "Account Name:"
        '
        'Job_NameLabel
        '
        Job_NameLabel.AutoSize = True
        Job_NameLabel.Location = New System.Drawing.Point(34, 71)
        Job_NameLabel.Name = "Job_NameLabel"
        Job_NameLabel.Size = New System.Drawing.Size(94, 20)
        Job_NameLabel.TabIndex = 4
        Job_NameLabel.Text = "Job Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(34, 105)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(105, 20)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(34, 137)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(80, 20)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "Address:"
        '
        'Job_NumberLabel
        '
        Job_NumberLabel.AutoSize = True
        Job_NumberLabel.Location = New System.Drawing.Point(34, 169)
        Job_NumberLabel.Name = "Job_NumberLabel"
        Job_NumberLabel.Size = New System.Drawing.Size(110, 20)
        Job_NumberLabel.TabIndex = 10
        Job_NumberLabel.Text = "Job Number:"
        '
        'Job_KeyLabel
        '
        Job_KeyLabel.AutoSize = True
        Job_KeyLabel.Location = New System.Drawing.Point(34, 201)
        Job_KeyLabel.Name = "Job_KeyLabel"
        Job_KeyLabel.Size = New System.Drawing.Size(77, 20)
        Job_KeyLabel.TabIndex = 12
        Job_KeyLabel.Text = "Job Key:"
        '
        'Show_PriceLabel
        '
        Show_PriceLabel.AutoSize = True
        Show_PriceLabel.Location = New System.Drawing.Point(34, 235)
        Show_PriceLabel.Name = "Show_PriceLabel"
        Show_PriceLabel.Size = New System.Drawing.Size(103, 20)
        Show_PriceLabel.TabIndex = 14
        Show_PriceLabel.Text = "Show Price:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(510, 532)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 45)
        Me.TableLayoutPanel1.TabIndex = 7
        Me.TableLayoutPanel1.TabStop = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(12, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(285, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(112, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(148, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(111, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Account_NameTextBox
        '
        Me.Account_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Account_Name", True))
        Me.Account_NameTextBox.Enabled = False
        Me.Account_NameTextBox.Location = New System.Drawing.Point(171, 36)
        Me.Account_NameTextBox.Name = "Account_NameTextBox"
        Me.Account_NameTextBox.Size = New System.Drawing.Size(491, 26)
        Me.Account_NameTextBox.TabIndex = 0
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'IRS_ScaleDataSet
        '
        Me.IRS_ScaleDataSet.DataSetName = "IRS_ScaleDataSet"
        Me.IRS_ScaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Job_NameComboBox
        '
        Me.Job_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Job_Name", True))
        Me.Job_NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Job_NameComboBox.Enabled = False
        Me.Job_NameComboBox.FormattingEnabled = True
        Me.Job_NameComboBox.Location = New System.Drawing.Point(171, 68)
        Me.Job_NameComboBox.Name = "Job_NameComboBox"
        Me.Job_NameComboBox.Size = New System.Drawing.Size(491, 28)
        Me.Job_NameComboBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(171, 102)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(491, 26)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(171, 134)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(491, 26)
        Me.AddressTextBox.TabIndex = 3
        '
        'Job_NumberTextBox
        '
        Me.Job_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Job_Number", True))
        Me.Job_NumberTextBox.Location = New System.Drawing.Point(171, 166)
        Me.Job_NumberTextBox.Name = "Job_NumberTextBox"
        Me.Job_NumberTextBox.Size = New System.Drawing.Size(491, 26)
        Me.Job_NumberTextBox.TabIndex = 4
        '
        'Job_KeyTextBox
        '
        Me.Job_KeyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Job_Key", True))
        Me.Job_KeyTextBox.Location = New System.Drawing.Point(171, 198)
        Me.Job_KeyTextBox.Name = "Job_KeyTextBox"
        Me.Job_KeyTextBox.Size = New System.Drawing.Size(491, 26)
        Me.Job_KeyTextBox.TabIndex = 5
        '
        'Show_PriceCheckBox
        '
        Me.Show_PriceCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.JobBindingSource, "Show_Price", True))
        Me.Show_PriceCheckBox.Location = New System.Drawing.Point(171, 230)
        Me.Show_PriceCheckBox.Name = "Show_PriceCheckBox"
        Me.Show_PriceCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.Show_PriceCheckBox.TabIndex = 6
        Me.Show_PriceCheckBox.TabStop = False
        '
        'grpProducts
        '
        Me.grpProducts.Controls.Add(Me.Job_ProductsDataGridView)
        Me.grpProducts.Location = New System.Drawing.Point(47, 277)
        Me.grpProducts.Name = "grpProducts"
        Me.grpProducts.Size = New System.Drawing.Size(881, 247)
        Me.grpProducts.TabIndex = 16
        Me.grpProducts.TabStop = False
        Me.grpProducts.Text = "Products"
        '
        'Job_ProductsDataGridView
        '
        Me.Job_ProductsDataGridView.AutoGenerateColumns = False
        Me.Job_ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Job_ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Job_ProductsDataGridView.ColumnHeadersHeight = 50
        Me.Job_ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Deletebtn, Me.cboProductName, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.Job_ProductsDataGridView.DataSource = Me.Job_ProductsBindingSource
        Me.Job_ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Job_ProductsDataGridView.Location = New System.Drawing.Point(3, 22)
        Me.Job_ProductsDataGridView.Name = "Job_ProductsDataGridView"
        Me.Job_ProductsDataGridView.RowHeadersWidth = 30
        Me.Job_ProductsDataGridView.RowTemplate.Height = 28
        Me.Job_ProductsDataGridView.Size = New System.Drawing.Size(875, 222)
        Me.Job_ProductsDataGridView.TabIndex = 0
        Me.Job_ProductsDataGridView.TabStop = False
        '
        'Deletebtn
        '
        Me.Deletebtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Deletebtn.DataPropertyName = "Deletebtn"
        Me.Deletebtn.FillWeight = 30.0!
        Me.Deletebtn.HeaderText = ""
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.ReadOnly = True
        Me.Deletebtn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Deletebtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cboProductName
        '
        Me.cboProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cboProductName.DataPropertyName = "Product_Name"
        Me.cboProductName.DataSource = Me.ProductBindingSource
        Me.cboProductName.DisplayMember = "Product_Name"
        Me.cboProductName.HeaderText = "Product"
        Me.cboProductName.Name = "cboProductName"
        Me.cboProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboProductName.ValueMember = "Product_Name"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Product_Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product #"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Delivery_Rate"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Delivery Rate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Flat_Rate"
        Me.DataGridViewCheckBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Flat Rate"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Job_ProductsBindingSource
        '
        Me.Job_ProductsBindingSource.DataMember = "Job_Products"
        Me.Job_ProductsBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'Job_ProductsTableAdapter
        '
        Me.Job_ProductsTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Job_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(940, 595)
        Me.Controls.Add(Me.grpProducts)
        Me.Controls.Add(Account_NameLabel)
        Me.Controls.Add(Me.Account_NameTextBox)
        Me.Controls.Add(Job_NameLabel)
        Me.Controls.Add(Me.Job_NameComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Job_NumberLabel)
        Me.Controls.Add(Me.Job_NumberTextBox)
        Me.Controls.Add(Job_KeyLabel)
        Me.Controls.Add(Me.Job_KeyTextBox)
        Me.Controls.Add(Show_PriceLabel)
        Me.Controls.Add(Me.Show_PriceCheckBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Job_Details"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProducts.ResumeLayout(False)
        CType(Me.Job_ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Job_ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.JobTableAdapter
    Friend WithEvents Account_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Job_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Job_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Job_KeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Show_PriceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents grpProducts As System.Windows.Forms.GroupBox
    Friend WithEvents Job_ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Job_ProductsTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter
    Friend WithEvents Job_ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Deletebtn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboProductName As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
