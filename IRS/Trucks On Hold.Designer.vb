<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trucks_On_Hold
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TrucksDataGridView = New System.Windows.Forms.DataGridView()
        Me.SelectBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Hold_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TruckIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaulerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TareWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IrS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintBasicTicket = New System.Windows.Forms.Button()
        Me.CreateTicketButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SetupTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter()
        Me.TrucksTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TrucksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrucksDataGridView
        '
        Me.TrucksDataGridView.AllowUserToAddRows = False
        Me.TrucksDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.TrucksDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TrucksDataGridView.AutoGenerateColumns = False
        Me.TrucksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TrucksDataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TrucksDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.TrucksDataGridView.ColumnHeadersHeight = 35
        Me.TrucksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectBtn, Me.DeleteBtn, Me.Hold_Date, Me.TruckIdDataGridViewTextBoxColumn, Me.HaulerNameDataGridViewTextBoxColumn, Me.AccountNameDataGridViewTextBoxColumn, Me.JobNameDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.TareWeightDataGridViewTextBoxColumn})
        Me.TrucksDataGridView.DataSource = Me.TrucksBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TrucksDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.TrucksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrucksDataGridView.Location = New System.Drawing.Point(159, 36)
        Me.TrucksDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrucksDataGridView.Name = "TrucksDataGridView"
        Me.TrucksDataGridView.ReadOnly = True
        Me.TrucksDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.TrucksDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TrucksDataGridView.RowTemplate.Height = 30
        Me.TrucksDataGridView.Size = New System.Drawing.Size(930, 571)
        Me.TrucksDataGridView.TabIndex = 30
        '
        'SelectBtn
        '
        Me.SelectBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SelectBtn.DataPropertyName = "SelectBtn"
        Me.SelectBtn.FillWeight = 20.0!
        Me.SelectBtn.HeaderText = ""
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.ReadOnly = True
        Me.SelectBtn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SelectBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SelectBtn.Width = 75
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DeleteBtn.DataPropertyName = "DeleteBtn"
        Me.DeleteBtn.FillWeight = 20.0!
        Me.DeleteBtn.HeaderText = ""
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ReadOnly = True
        Me.DeleteBtn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeleteBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeleteBtn.Width = 75
        '
        'Hold_Date
        '
        Me.Hold_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Hold_Date.DataPropertyName = "Hold_Date"
        DataGridViewCellStyle9.Format = "g"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Hold_Date.DefaultCellStyle = DataGridViewCellStyle9
        Me.Hold_Date.FillWeight = 130.0!
        Me.Hold_Date.HeaderText = "Date"
        Me.Hold_Date.Name = "Hold_Date"
        Me.Hold_Date.ReadOnly = True
        '
        'TruckIdDataGridViewTextBoxColumn
        '
        Me.TruckIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TruckIdDataGridViewTextBoxColumn.DataPropertyName = "Truck_Id"
        Me.TruckIdDataGridViewTextBoxColumn.FillWeight = 65.0!
        Me.TruckIdDataGridViewTextBoxColumn.HeaderText = "Truck"
        Me.TruckIdDataGridViewTextBoxColumn.Name = "TruckIdDataGridViewTextBoxColumn"
        Me.TruckIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaulerNameDataGridViewTextBoxColumn
        '
        Me.HaulerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HaulerNameDataGridViewTextBoxColumn.DataPropertyName = "Hauler_Name"
        Me.HaulerNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.HaulerNameDataGridViewTextBoxColumn.HeaderText = "Hauler"
        Me.HaulerNameDataGridViewTextBoxColumn.Name = "HaulerNameDataGridViewTextBoxColumn"
        Me.HaulerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountNameDataGridViewTextBoxColumn
        '
        Me.AccountNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AccountNameDataGridViewTextBoxColumn.DataPropertyName = "Account_Name"
        Me.AccountNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.AccountNameDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.AccountNameDataGridViewTextBoxColumn.Name = "AccountNameDataGridViewTextBoxColumn"
        Me.AccountNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobNameDataGridViewTextBoxColumn
        '
        Me.JobNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JobNameDataGridViewTextBoxColumn.DataPropertyName = "Job_Name"
        Me.JobNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.JobNameDataGridViewTextBoxColumn.HeaderText = "Job"
        Me.JobNameDataGridViewTextBoxColumn.Name = "JobNameDataGridViewTextBoxColumn"
        Me.JobNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TareWeightDataGridViewTextBoxColumn
        '
        Me.TareWeightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TareWeightDataGridViewTextBoxColumn.DataPropertyName = "Tare_Weight"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.TareWeightDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TareWeightDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.TareWeightDataGridViewTextBoxColumn.HeaderText = "Tare"
        Me.TareWeightDataGridViewTextBoxColumn.Name = "TareWeightDataGridViewTextBoxColumn"
        Me.TareWeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrucksBindingSource
        '
        Me.TrucksBindingSource.DataMember = "Trucks"
        Me.TrucksBindingSource.DataSource = Me.IrS_ScaleDataSet
        '
        'IrS_ScaleDataSet
        '
        Me.IrS_ScaleDataSet.DataSetName = "IRS_ScaleDataSet"
        Me.IrS_ScaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 607)
        Me.Panel1.TabIndex = 32
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Thistle
        Me.Button12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(16, 198)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(127, 47)
        Me.Button12.TabIndex = 29
        Me.Button12.Text = "Reports"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PrintBasicTicket)
        Me.GroupBox2.Controls.Add(Me.CreateTicketButton)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(5, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 163)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket"
        '
        'PrintBasicTicket
        '
        Me.PrintBasicTicket.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBasicTicket.ForeColor = System.Drawing.Color.Black
        Me.PrintBasicTicket.Location = New System.Drawing.Point(11, 100)
        Me.PrintBasicTicket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintBasicTicket.Name = "PrintBasicTicket"
        Me.PrintBasicTicket.Size = New System.Drawing.Size(127, 47)
        Me.PrintBasicTicket.TabIndex = 31
        Me.PrintBasicTicket.Text = "Print Basic Ticket"
        Me.PrintBasicTicket.UseVisualStyleBackColor = True
        '
        'CreateTicketButton
        '
        Me.CreateTicketButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateTicketButton.ForeColor = System.Drawing.Color.Black
        Me.CreateTicketButton.Location = New System.Drawing.Point(11, 28)
        Me.CreateTicketButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CreateTicketButton.Name = "CreateTicketButton"
        Me.CreateTicketButton.Size = New System.Drawing.Size(127, 47)
        Me.CreateTicketButton.TabIndex = 28
        Me.CreateTicketButton.Text = "Create Ticket"
        Me.CreateTicketButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 330)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tables"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Lavender
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(11, 261)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 47)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "Trucks"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Lavender
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(11, 213)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 47)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Products"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lavender
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(11, 165)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 47)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Jobs"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lavender
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(11, 117)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 47)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Haulers"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lavender
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(11, 69)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 47)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Customers"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(11, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Finished Tickets"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SetupTableAdapter1
        '
        Me.SetupTableAdapter1.ClearBeforeFill = True
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(159, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(930, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "List Of Trucks On Hold"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Trucks_On_Hold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 607)
        Me.ControlBox = False
        Me.Controls.Add(Me.TrucksDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Trucks_On_Hold"
        Me.Text = "Trucks On Hold"
        CType(Me.TrucksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrucksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintBasicTicket As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CreateTicketButton As System.Windows.Forms.Button
    Friend WithEvents SetupTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter
    Friend WithEvents IrS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents TrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DeleteBtn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Hold_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TruckIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaulerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TareWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
