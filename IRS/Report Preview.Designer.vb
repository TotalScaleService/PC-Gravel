<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Preview
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblReport_Type = New System.Windows.Forms.Label()
        Me.cbReportType = New System.Windows.Forms.ComboBox()
        Me.Suppres_Details = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Ending_Ticket = New System.Windows.Forms.MaskedTextBox()
        Me.Starting_Ticket = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckShowPrice = New System.Windows.Forms.CheckBox()
        Me.btnMoreFiltering = New System.Windows.Forms.Button()
        Me.grpDateFilter = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartFilterDate = New System.Windows.Forms.DateTimePicker()
        Me.EndFilterDate = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Sort_By_Date_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckFilterByJob = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMoreFiltering = New System.Windows.Forms.Panel()
        Me.pnlJob = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboJobs = New System.Windows.Forms.CheckedListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCustomers = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProducts = New System.Windows.Forms.CheckedListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProductsFilteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IrS_ScaleDataSet1 = New IRS.IRS_ScaleDataSet()
        Me.SetupTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter()
        Me.TransactionsTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter()
        Me.AccountTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter()
        Me.ProductTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter()
        Me.TransactionJobsTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.TransactionJobsTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDateFilter.SuspendLayout()
        Me.pnlMoreFiltering.SuspendLayout()
        Me.pnlJob.SuspendLayout()
        CType(Me.ProductsFilteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrS_ScaleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 321)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(853, 258)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblReport_Type)
        Me.Panel1.Controls.Add(Me.cbReportType)
        Me.Panel1.Controls.Add(Me.Suppres_Details)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ckShowPrice)
        Me.Panel1.Controls.Add(Me.btnMoreFiltering)
        Me.Panel1.Controls.Add(Me.grpDateFilter)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Sort_By_Date_CheckBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 90)
        Me.Panel1.TabIndex = 16
        '
        'lblReport_Type
        '
        Me.lblReport_Type.AutoSize = True
        Me.lblReport_Type.Location = New System.Drawing.Point(486, 4)
        Me.lblReport_Type.Name = "lblReport_Type"
        Me.lblReport_Type.Size = New System.Drawing.Size(69, 13)
        Me.lblReport_Type.TabIndex = 21
        Me.lblReport_Type.Text = "Report Type:"
        Me.lblReport_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbReportType
        '
        Me.cbReportType.FormattingEnabled = True
        Me.cbReportType.Items.AddRange(New Object() {"Transaction", "Product", "Tickets"})
        Me.cbReportType.Location = New System.Drawing.Point(486, 22)
        Me.cbReportType.Name = "cbReportType"
        Me.cbReportType.Size = New System.Drawing.Size(115, 21)
        Me.cbReportType.TabIndex = 20
        '
        'Suppres_Details
        '
        Me.Suppres_Details.AutoSize = True
        Me.Suppres_Details.Location = New System.Drawing.Point(401, 7)
        Me.Suppres_Details.Name = "Suppres_Details"
        Me.Suppres_Details.Size = New System.Drawing.Size(69, 17)
        Me.Suppres_Details.TabIndex = 19
        Me.Suppres_Details.Text = "Summary"
        Me.Suppres_Details.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Ending_Ticket)
        Me.GroupBox1.Controls.Add(Me.Starting_Ticket)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(615, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 70)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(148, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Ending_Ticket
        '
        Me.Ending_Ticket.Location = New System.Drawing.Point(89, 37)
        Me.Ending_Ticket.Mask = "0000000"
        Me.Ending_Ticket.Name = "Ending_Ticket"
        Me.Ending_Ticket.Size = New System.Drawing.Size(55, 20)
        Me.Ending_Ticket.TabIndex = 3
        Me.Ending_Ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Starting_Ticket
        '
        Me.Starting_Ticket.Location = New System.Drawing.Point(89, 9)
        Me.Starting_Ticket.Mask = "0000000"
        Me.Starting_Ticket.Name = "Starting_Ticket"
        Me.Starting_Ticket.Size = New System.Drawing.Size(55, 20)
        Me.Starting_Ticket.TabIndex = 2
        Me.Starting_Ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Ending Ticket"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Starting Ticket"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckShowPrice
        '
        Me.ckShowPrice.AutoSize = True
        Me.ckShowPrice.Location = New System.Drawing.Point(401, 26)
        Me.ckShowPrice.Name = "ckShowPrice"
        Me.ckShowPrice.Size = New System.Drawing.Size(80, 17)
        Me.ckShowPrice.TabIndex = 17
        Me.ckShowPrice.Text = "Show Price"
        Me.ckShowPrice.UseVisualStyleBackColor = True
        '
        'btnMoreFiltering
        '
        Me.btnMoreFiltering.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreFiltering.Location = New System.Drawing.Point(130, 7)
        Me.btnMoreFiltering.Name = "btnMoreFiltering"
        Me.btnMoreFiltering.Size = New System.Drawing.Size(44, 31)
        Me.btnMoreFiltering.TabIndex = 15
        Me.btnMoreFiltering.Text = "More Filtering"
        Me.btnMoreFiltering.UseVisualStyleBackColor = True
        Me.btnMoreFiltering.Visible = False
        '
        'grpDateFilter
        '
        Me.grpDateFilter.Controls.Add(Me.Label2)
        Me.grpDateFilter.Controls.Add(Me.Label1)
        Me.grpDateFilter.Controls.Add(Me.StartFilterDate)
        Me.grpDateFilter.Controls.Add(Me.EndFilterDate)
        Me.grpDateFilter.Location = New System.Drawing.Point(96, 37)
        Me.grpDateFilter.Name = "grpDateFilter"
        Me.grpDateFilter.Size = New System.Drawing.Size(513, 40)
        Me.grpDateFilter.TabIndex = 3
        Me.grpDateFilter.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "and"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Between"
        '
        'StartFilterDate
        '
        Me.StartFilterDate.Location = New System.Drawing.Point(74, 11)
        Me.StartFilterDate.Name = "StartFilterDate"
        Me.StartFilterDate.Size = New System.Drawing.Size(200, 20)
        Me.StartFilterDate.TabIndex = 0
        '
        'EndFilterDate
        '
        Me.EndFilterDate.Location = New System.Drawing.Point(305, 12)
        Me.EndFilterDate.Name = "EndFilterDate"
        Me.EndFilterDate.Size = New System.Drawing.Size(200, 20)
        Me.EndFilterDate.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(220, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 31)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Update Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Sort_By_Date_CheckBox
        '
        Me.Sort_By_Date_CheckBox.AutoSize = True
        Me.Sort_By_Date_CheckBox.Checked = True
        Me.Sort_By_Date_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Sort_By_Date_CheckBox.Location = New System.Drawing.Point(8, 51)
        Me.Sort_By_Date_CheckBox.Name = "Sort_By_Date_CheckBox"
        Me.Sort_By_Date_CheckBox.Size = New System.Drawing.Size(89, 17)
        Me.Sort_By_Date_CheckBox.TabIndex = 2
        Me.Sort_By_Date_CheckBox.Text = "Filter By Date"
        Me.Sort_By_Date_CheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckFilterByJob
        '
        Me.ckFilterByJob.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ckFilterByJob.AutoSize = True
        Me.ckFilterByJob.Location = New System.Drawing.Point(562, 3)
        Me.ckFilterByJob.Name = "ckFilterByJob"
        Me.ckFilterByJob.Size = New System.Drawing.Size(83, 17)
        Me.ckFilterByJob.TabIndex = 18
        Me.ckFilterByJob.Text = "Filter By Job"
        Me.ckFilterByJob.UseVisualStyleBackColor = True
        Me.ckFilterByJob.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'pnlMoreFiltering
        '
        Me.pnlMoreFiltering.Controls.Add(Me.ckFilterByJob)
        Me.pnlMoreFiltering.Controls.Add(Me.pnlJob)
        Me.pnlMoreFiltering.Controls.Add(Me.Button4)
        Me.pnlMoreFiltering.Controls.Add(Me.Button2)
        Me.pnlMoreFiltering.Controls.Add(Me.Label4)
        Me.pnlMoreFiltering.Controls.Add(Me.cboCustomers)
        Me.pnlMoreFiltering.Controls.Add(Me.Label3)
        Me.pnlMoreFiltering.Controls.Add(Me.cboProducts)
        Me.pnlMoreFiltering.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMoreFiltering.Location = New System.Drawing.Point(0, 90)
        Me.pnlMoreFiltering.Name = "pnlMoreFiltering"
        Me.pnlMoreFiltering.Size = New System.Drawing.Size(853, 231)
        Me.pnlMoreFiltering.TabIndex = 17
        Me.pnlMoreFiltering.Visible = False
        '
        'pnlJob
        '
        Me.pnlJob.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlJob.Controls.Add(Me.Button5)
        Me.pnlJob.Controls.Add(Me.Label5)
        Me.pnlJob.Controls.Add(Me.cboJobs)
        Me.pnlJob.Location = New System.Drawing.Point(562, 24)
        Me.pnlJob.Name = "pnlJob"
        Me.pnlJob.Size = New System.Drawing.Size(281, 200)
        Me.pnlJob.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(129, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 25)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Uncheck All Jobs"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Only Show Jobs"
        '
        'cboJobs
        '
        Me.cboJobs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboJobs.CheckOnClick = True
        Me.cboJobs.FormattingEnabled = True
        Me.cboJobs.Location = New System.Drawing.Point(16, 36)
        Me.cboJobs.Name = "cboJobs"
        Me.cboJobs.Size = New System.Drawing.Size(250, 154)
        Me.cboJobs.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(126, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 25)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Uncheck All Products"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(409, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 25)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Uncheck All Customers"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Only Show Customers"
        '
        'cboCustomers
        '
        Me.cboCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboCustomers.CheckOnClick = True
        Me.cboCustomers.FormattingEnabled = True
        Me.cboCustomers.Location = New System.Drawing.Point(296, 60)
        Me.cboCustomers.Name = "cboCustomers"
        Me.cboCustomers.Size = New System.Drawing.Size(250, 154)
        Me.cboCustomers.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Only Show Products"
        '
        'cboProducts
        '
        Me.cboProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboProducts.CheckOnClick = True
        Me.cboProducts.FormattingEnabled = True
        Me.cboProducts.Location = New System.Drawing.Point(20, 60)
        Me.cboProducts.Name = "cboProducts"
        Me.cboProducts.Size = New System.Drawing.Size(250, 154)
        Me.cboProducts.TabIndex = 0
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProductsFilteredBindingSource
        '
        Me.ProductsFilteredBindingSource.DataMember = "ProductsFiltered"
        Me.ProductsFilteredBindingSource.DataSource = Me.IrS_ScaleDataSet1
        '
        'IrS_ScaleDataSet1
        '
        Me.IrS_ScaleDataSet1.DataSetName = "IRS_ScaleDataSet"
        Me.IrS_ScaleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SetupTableAdapter1
        '
        Me.SetupTableAdapter1.ClearBeforeFill = True
        '
        'TransactionsTableAdapter1
        '
        Me.TransactionsTableAdapter1.ClearBeforeFill = True
        '
        'AccountTableAdapter1
        '
        Me.AccountTableAdapter1.ClearBeforeFill = True
        '
        'ProductTableAdapter1
        '
        Me.ProductTableAdapter1.ClearBeforeFill = True
        '
        'TransactionJobsTableAdapter1
        '
        Me.TransactionJobsTableAdapter1.ClearBeforeFill = True
        '
        'Report_Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(853, 579)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.pnlMoreFiltering)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Report_Preview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDateFilter.ResumeLayout(False)
        Me.grpDateFilter.PerformLayout()
        Me.pnlMoreFiltering.ResumeLayout(False)
        Me.pnlMoreFiltering.PerformLayout()
        Me.pnlJob.ResumeLayout(False)
        Me.pnlJob.PerformLayout()
        CType(Me.ProductsFilteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrS_ScaleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents IrS_ScaleDataSet1 As IRS.IRS_ScaleDataSet
    Friend WithEvents SetupTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter
    Friend WithEvents TransactionsTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpDateFilter As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartFilterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndFilterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sort_By_Date_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnMoreFiltering As System.Windows.Forms.Button
    Friend WithEvents pnlMoreFiltering As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCustomers As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboProducts As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AccountTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter
    Friend WithEvents ProductTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductsFilteredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ckShowPrice As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboJobs As System.Windows.Forms.CheckedListBox
    Friend WithEvents ckFilterByJob As System.Windows.Forms.CheckBox
    Friend WithEvents pnlJob As System.Windows.Forms.Panel
    Friend WithEvents TransactionJobsTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.TransactionJobsTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ending_Ticket As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Starting_Ticket As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Suppres_Details As System.Windows.Forms.CheckBox
    Friend WithEvents lblReport_Type As Label
    Friend WithEvents cbReportType As ComboBox
End Class
