<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket_List
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.TransactionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.SelectBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RestoreBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VoidBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Job_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.JobBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Truck_IdComboBox = New System.Windows.Forms.ComboBox()
        Me.DistinctTrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hauler_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.HaulerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Account_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.AccountBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpDateFilter = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartFilterDate = New System.Windows.Forms.DateTimePicker()
        Me.EndFilterDate = New System.Windows.Forms.DateTimePicker()
        Me.Sort_By_Date_CheckBox = New System.Windows.Forms.CheckBox()
        Me.TrucksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HaulerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter()
        Me.ProductTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter()
        Me.AccountTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter()
        Me.HaulerTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter()
        Me.TrucksTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter()
        Me.JobTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.JobTableAdapter()
        Me.Distinct_TrucksTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Distinct_TrucksTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        CType(Me.JobBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistinctTrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HaulerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDateFilter.SuspendLayout()
        CType(Me.TrucksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.IRS_ScaleDataSet
        Me.TransactionsBindingSource.Filter = "Void = false "
        '
        'IRS_ScaleDataSet
        '
        Me.IRS_ScaleDataSet.DataSetName = "IRS_ScaleDataSet"
        Me.IRS_ScaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsDataGridView
        '
        Me.TransactionsDataGridView.AllowUserToAddRows = False
        Me.TransactionsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.TransactionsDataGridView.AutoGenerateColumns = False
        Me.TransactionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectBtn, Me.RestoreBtn, Me.VoidBtn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn17, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15})
        Me.TransactionsDataGridView.DataSource = Me.TransactionsBindingSource
        Me.TransactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionsDataGridView.Location = New System.Drawing.Point(0, 182)
        Me.TransactionsDataGridView.Name = "TransactionsDataGridView"
        Me.TransactionsDataGridView.ReadOnly = True
        Me.TransactionsDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Maroon
        Me.TransactionsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.TransactionsDataGridView.RowTemplate.Height = 23
        Me.TransactionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TransactionsDataGridView.Size = New System.Drawing.Size(1068, 412)
        Me.TransactionsDataGridView.TabIndex = 2
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SelectBtn.DataPropertyName = "SelectBtn"
        Me.SelectBtn.HeaderText = ""
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.ReadOnly = True
        Me.SelectBtn.Width = 5
        '
        'RestoreBtn
        '
        Me.RestoreBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RestoreBtn.DataPropertyName = "RestoreBtn"
        Me.RestoreBtn.HeaderText = ""
        Me.RestoreBtn.Name = "RestoreBtn"
        Me.RestoreBtn.ReadOnly = True
        Me.RestoreBtn.Visible = False
        '
        'VoidBtn
        '
        Me.VoidBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VoidBtn.DataPropertyName = "VoidBtn"
        Me.VoidBtn.HeaderText = ""
        Me.VoidBtn.Name = "VoidBtn"
        Me.VoidBtn.ReadOnly = True
        Me.VoidBtn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VoidBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VoidBtn.Width = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ticket"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N0"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ticket"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date_Out"
        DataGridViewCellStyle19.Format = "g"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 62
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Hauler_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hauler"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Truck_Id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vehicle"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 79
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Account_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 93
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Job_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Job"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 55
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Gross"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N0"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn8.HeaderText = "Gross"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 69
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Tare"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N0"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tare"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 61
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tons"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 63
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Price_Per_UOM"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "C2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn13.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Delivery_Rate"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "C2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn17.HeaderText = "Delivery Rate"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 117
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Delivery_Flat_Rate"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Flat Rate"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 71
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Unit_Of_Measure"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Units"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Yards_Conversion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Yards Per Ton"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 122
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 93
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.Button2)
        Me.pnlFilter.Controls.Add(Me.Job_NameComboBox)
        Me.pnlFilter.Controls.Add(Me.Truck_IdComboBox)
        Me.pnlFilter.Controls.Add(Me.Hauler_NameComboBox)
        Me.pnlFilter.Controls.Add(Me.Account_NameComboBox)
        Me.pnlFilter.Controls.Add(Me.Product_NameComboBox)
        Me.pnlFilter.Controls.Add(Me.CheckBox5)
        Me.pnlFilter.Controls.Add(Me.CheckBox4)
        Me.pnlFilter.Controls.Add(Me.CheckBox3)
        Me.pnlFilter.Controls.Add(Me.CheckBox2)
        Me.pnlFilter.Controls.Add(Me.CheckBox1)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlFilter.Location = New System.Drawing.Point(0, 84)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1068, 98)
        Me.pnlFilter.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(501, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "View Voided Tickets"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Job_NameComboBox
        '
        Me.Job_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Job_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Job_NameComboBox.DataSource = Me.JobBindingSource1
        Me.Job_NameComboBox.DisplayMember = "Job_Name"
        Me.Job_NameComboBox.Enabled = False
        Me.Job_NameComboBox.FormattingEnabled = True
        Me.Job_NameComboBox.Location = New System.Drawing.Point(252, 21)
        Me.Job_NameComboBox.Name = "Job_NameComboBox"
        Me.Job_NameComboBox.Size = New System.Drawing.Size(207, 21)
        Me.Job_NameComboBox.TabIndex = 13
        Me.Job_NameComboBox.ValueMember = "Job_Name"
        '
        'JobBindingSource1
        '
        Me.JobBindingSource1.DataMember = "Job"
        Me.JobBindingSource1.DataSource = Me.IRS_ScaleDataSet
        '
        'Truck_IdComboBox
        '
        Me.Truck_IdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Truck_IdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Truck_IdComboBox.DataSource = Me.DistinctTrucksBindingSource
        Me.Truck_IdComboBox.DisplayMember = "Truck_Id"
        Me.Truck_IdComboBox.Enabled = False
        Me.Truck_IdComboBox.FormattingEnabled = True
        Me.Truck_IdComboBox.Location = New System.Drawing.Point(501, 21)
        Me.Truck_IdComboBox.Name = "Truck_IdComboBox"
        Me.Truck_IdComboBox.Size = New System.Drawing.Size(207, 21)
        Me.Truck_IdComboBox.TabIndex = 12
        Me.Truck_IdComboBox.ValueMember = "Truck_Id"
        '
        'DistinctTrucksBindingSource
        '
        Me.DistinctTrucksBindingSource.DataMember = "Distinct_Trucks"
        Me.DistinctTrucksBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'Hauler_NameComboBox
        '
        Me.Hauler_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Hauler_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Hauler_NameComboBox.DataSource = Me.HaulerBindingSource1
        Me.Hauler_NameComboBox.DisplayMember = "Hauler_Name"
        Me.Hauler_NameComboBox.Enabled = False
        Me.Hauler_NameComboBox.FormattingEnabled = True
        Me.Hauler_NameComboBox.Location = New System.Drawing.Point(7, 67)
        Me.Hauler_NameComboBox.Name = "Hauler_NameComboBox"
        Me.Hauler_NameComboBox.Size = New System.Drawing.Size(207, 21)
        Me.Hauler_NameComboBox.TabIndex = 11
        Me.Hauler_NameComboBox.ValueMember = "Hauler_Name"
        '
        'HaulerBindingSource1
        '
        Me.HaulerBindingSource1.DataMember = "Hauler"
        Me.HaulerBindingSource1.DataSource = Me.IRS_ScaleDataSet
        '
        'Account_NameComboBox
        '
        Me.Account_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Account_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Account_NameComboBox.DataSource = Me.AccountBindingSource1
        Me.Account_NameComboBox.DisplayMember = "Account_Name"
        Me.Account_NameComboBox.Enabled = False
        Me.Account_NameComboBox.FormattingEnabled = True
        Me.Account_NameComboBox.Location = New System.Drawing.Point(7, 21)
        Me.Account_NameComboBox.Name = "Account_NameComboBox"
        Me.Account_NameComboBox.Size = New System.Drawing.Size(207, 21)
        Me.Account_NameComboBox.TabIndex = 10
        Me.Account_NameComboBox.ValueMember = "Account_Name"
        '
        'AccountBindingSource1
        '
        Me.AccountBindingSource1.DataMember = "Account"
        Me.AccountBindingSource1.DataSource = Me.IRS_ScaleDataSet
        '
        'Product_NameComboBox
        '
        Me.Product_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Product_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Product_NameComboBox.DataSource = Me.ProductBindingSource1
        Me.Product_NameComboBox.DisplayMember = "Product_Name"
        Me.Product_NameComboBox.Enabled = False
        Me.Product_NameComboBox.FormattingEnabled = True
        Me.Product_NameComboBox.Location = New System.Drawing.Point(252, 67)
        Me.Product_NameComboBox.Name = "Product_NameComboBox"
        Me.Product_NameComboBox.Size = New System.Drawing.Size(207, 21)
        Me.Product_NameComboBox.TabIndex = 9
        Me.Product_NameComboBox.ValueMember = "Product_Name"
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "Product"
        Me.ProductBindingSource1.DataSource = Me.IRS_ScaleDataSet
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(252, 2)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(96, 17)
        Me.CheckBox5.TabIndex = 8
        Me.CheckBox5.Text = "Filter By Job"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(502, 2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox4.TabIndex = 7
        Me.CheckBox4.Text = "Filter By Truck"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(252, 48)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Filter By Product"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Filter By Customer"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Filter By Hauler"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpDateFilter
        '
        Me.grpDateFilter.Controls.Add(Me.Label2)
        Me.grpDateFilter.Controls.Add(Me.Label1)
        Me.grpDateFilter.Controls.Add(Me.StartFilterDate)
        Me.grpDateFilter.Controls.Add(Me.EndFilterDate)
        Me.grpDateFilter.Location = New System.Drawing.Point(121, 38)
        Me.grpDateFilter.Name = "grpDateFilter"
        Me.grpDateFilter.Size = New System.Drawing.Size(649, 40)
        Me.grpDateFilter.TabIndex = 3
        Me.grpDateFilter.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "and"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Between"
        '
        'StartFilterDate
        '
        Me.StartFilterDate.Location = New System.Drawing.Point(74, 11)
        Me.StartFilterDate.Name = "StartFilterDate"
        Me.StartFilterDate.Size = New System.Drawing.Size(262, 21)
        Me.StartFilterDate.TabIndex = 0
        '
        'EndFilterDate
        '
        Me.EndFilterDate.Location = New System.Drawing.Point(379, 11)
        Me.EndFilterDate.Name = "EndFilterDate"
        Me.EndFilterDate.Size = New System.Drawing.Size(257, 21)
        Me.EndFilterDate.TabIndex = 1
        '
        'Sort_By_Date_CheckBox
        '
        Me.Sort_By_Date_CheckBox.AutoSize = True
        Me.Sort_By_Date_CheckBox.Checked = True
        Me.Sort_By_Date_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Sort_By_Date_CheckBox.Location = New System.Drawing.Point(6, 51)
        Me.Sort_By_Date_CheckBox.Name = "Sort_By_Date_CheckBox"
        Me.Sort_By_Date_CheckBox.Size = New System.Drawing.Size(112, 19)
        Me.Sort_By_Date_CheckBox.TabIndex = 2
        Me.Sort_By_Date_CheckBox.Text = "Filter By Date"
        Me.Sort_By_Date_CheckBox.UseVisualStyleBackColor = True
        '
        'TrucksBindingSource1
        '
        Me.TrucksBindingSource1.DataMember = "Trucks"
        Me.TrucksBindingSource1.DataSource = Me.IRS_ScaleDataSet
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'TrucksBindingSource
        '
        Me.TrucksBindingSource.DataMember = "FK_Trucks_Hauler"
        Me.TrucksBindingSource.DataSource = Me.HaulerBindingSource
        '
        'HaulerBindingSource
        '
        Me.HaulerBindingSource.DataMember = "Hauler"
        Me.HaulerBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'AccountBindingSource
        '
        Me.AccountBindingSource.DataMember = "Account"
        Me.AccountBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'AccountTableAdapter
        '
        Me.AccountTableAdapter.ClearBeforeFill = True
        '
        'HaulerTableAdapter
        '
        Me.HaulerTableAdapter.ClearBeforeFill = True
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'Distinct_TrucksTableAdapter
        '
        Me.Distinct_TrucksTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.grpDateFilter)
        Me.Panel1.Controls.Add(Me.Sort_By_Date_CheckBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 84)
        Me.Panel1.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(252, 11)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(207, 27)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update List"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Ticket_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1068, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.TransactionsDataGridView)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticket_List"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tickets"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        CType(Me.JobBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistinctTrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HaulerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDateFilter.ResumeLayout(False)
        Me.grpDateFilter.PerformLayout()
        CType(Me.TrucksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TransactionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents grpDateFilter As System.Windows.Forms.GroupBox
    Friend WithEvents StartFilterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndFilterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sort_By_Date_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents Product_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter
    Friend WithEvents Account_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HaulerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HaulerTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter
    Friend WithEvents Hauler_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter
    Friend WithEvents Truck_IdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.JobTableAdapter
    Friend WithEvents Job_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JobBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HaulerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AccountBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DistinctTrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Distinct_TrucksTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Distinct_TrucksTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents RestoreBtn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents VoidBtn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As Button
End Class
