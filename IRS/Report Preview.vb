Public Class Report_Preview

    Dim DisableTimer As Boolean = True
    Dim UseArchive As Boolean
    Public Sub New(Optional ByVal _UseArchive As Boolean = False)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        UseArchive = _UseArchive

        If UseArchive Then
            Me.Text = "VIEWING ARCHIVED RECORDS<<<<<<<<<<<<<<<"
        Else
            Me.Text = "View Records"
        End If
        Me.pnlMoreFiltering.Visible = True

        ' This section loads distinct jobs, accounts, and products into the following tables.
        ' This is so if any of those are deleted or changed you can still pull up reports on them.
        ' If these were linked from transactions to each table then deleting or changing one would alter already existing
        ' records.
        Using DJTA As IRS_ScaleDataSetTableAdapters.distinctJobsTableAdapter = New IRS_ScaleDataSetTableAdapters.distinctJobsTableAdapter()
            DJTA.Fill(Me.IrS_ScaleDataSet1.distinctJobs)
        End Using
        Using DCTA As IRS_ScaleDataSetTableAdapters.DistinctCustomersTableAdapter = New IRS_ScaleDataSetTableAdapters.DistinctCustomersTableAdapter()
            DCTA.Fill(Me.IrS_ScaleDataSet1.DistinctCustomers)
        End Using
        Using DPTA As IRS_ScaleDataSetTableAdapters.DistinctProductsTableAdapter = New IRS_ScaleDataSetTableAdapters.DistinctProductsTableAdapter()
            DPTA.Fill(Me.IrS_ScaleDataSet1.DistinctProducts)
        End Using
        ' End Section.  We are leaving the 3 lines below as of 3/01/2018 because we aren't sure if they are used elsewhere yet.

        Me.ProductTableAdapter1.Fill(Me.IrS_ScaleDataSet1.Product)
        Me.AccountTableAdapter1.Fill(Me.IrS_ScaleDataSet1.Account)
        Me.TransactionJobsTableAdapter1.Fill(Me.IrS_ScaleDataSet1.TransactionJobs)
        Me.ckFilterByJob.Checked = True
        Me.cboCustomers.Items.Clear()
        Me.cboProducts.Items.Clear()
        Me.cboJobs.Items.Clear()
        Me.cbReportType.SelectedIndex = 0
        CheckAllBoxes()

        LoadData()


    End Sub

    Private Sub CheckAllBoxes()
        Me.IrS_ScaleDataSet1.ProductsFiltered.Clear()
        Me.IrS_ScaleDataSet1.AccountsFiltered.Clear()
        Me.IrS_ScaleDataSet1.Job_Name_Filtered.Clear()

        Me.cboProducts.Items.Clear()
        Me.cboCustomers.Items.Clear()
        Me.cboJobs.Items.Clear()

        ' The products, customers, and jobs isolated from transactions in the above section are used to populate
        ' the checkboxes for report searching.
        For Each row As IRS_ScaleDataSet.DistinctProductsRow In Me.IrS_ScaleDataSet1.DistinctProducts
            Me.cboProducts.Items.Add(row.Product_Name, True)
        Next

        For Each row As IRS_ScaleDataSet.DistinctCustomersRow In Me.IrS_ScaleDataSet1.DistinctCustomers
            Me.cboCustomers.Items.Add(row.Customer, True)
        Next

        For Each row As IRS_ScaleDataSet.distinctJobsRow In Me.IrS_ScaleDataSet1.distinctJobs
            If Not row.IsJob_NameNull Then Me.cboJobs.Items.Add(row.Job_Name, True)
        Next

        For Each Item As Object In Me.cboProducts.CheckedItems
            Dim row As IRS.IRS_ScaleDataSet.ProductsFilteredRow = Me.IrS_ScaleDataSet1.ProductsFiltered.NewProductsFilteredRow
            row.Product_Name = Item
            Me.IrS_ScaleDataSet1.ProductsFiltered.AddProductsFilteredRow(row)
        Next

        For Each Item As Object In Me.cboCustomers.CheckedItems
            Dim row As IRS.IRS_ScaleDataSet.AccountsFilteredRow = Me.IrS_ScaleDataSet1.AccountsFiltered.NewAccountsFilteredRow
            row.Account_Name = Item
            Me.IrS_ScaleDataSet1.AccountsFiltered.AddAccountsFilteredRow(row)
        Next

        For Each Item As Object In Me.cboJobs.CheckedItems
            Dim row As IRS.IRS_ScaleDataSet.Job_Name_FilteredRow = Me.IrS_ScaleDataSet1.Job_Name_Filtered.NewJob_Name_FilteredRow
            row.Job_Name = Item
            Me.IrS_ScaleDataSet1.Job_Name_Filtered.AddJob_Name_FilteredRow(row)
        Next

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Public Sub LoadData()
        Me.Timer1.Stop()
        DisableTimer = False

        Dim Rpt As New CrystalReport
        If Me.cbReportType.SelectedIndex = 0 Then
            Rpt.LoadReport(CrystalReport.enReportType.Report)
        ElseIf Me.cbReportType.SelectedIndex = 1 Then
            Rpt.LoadReport(CrystalReport.enReportType.ProductReport)
        ElseIf Me.cbReportType.SelectedIndex = 2 Then
            Rpt.LoadReport(CrystalReport.enReportType.ProductByTicket)
        End If

        Me.SetupTableAdapter1.Fill(Me.IrS_ScaleDataSet1.Setup)
        Me.IrS_ScaleDataSet1.ReportSetup.Clear()
        Dim FilterString As String = ""
        Dim ReportSetupRow As IRS_ScaleDataSet.ReportSetupRow = Me.IrS_ScaleDataSet1.ReportSetup.NewReportSetupRow
        Me.Starting_Ticket.Text = Me.Starting_Ticket.Text.Trim
        Me.Ending_Ticket.Text = Me.Ending_Ticket.Text.Trim

        Me.TransactionsTableAdapter1.Fill(Me.IrS_ScaleDataSet1.Transactions)

        If Me.grpDateFilter.Enabled Then
            If Me.UseArchive Then
                Me.TransactionsTableAdapter1.FillByArchiveDate(Me.IrS_ScaleDataSet1.Transactions, Me.StartFilterDate.Value, Me.EndFilterDate.Value)
            Else
                Me.TransactionsTableAdapter1.FillByDate(Me.IrS_ScaleDataSet1.Transactions, Me.StartFilterDate.Value, Me.EndFilterDate.Value)
            End If

            ReportSetupRow.FilterString = "Transactions Between " + Me.StartFilterDate.Value.ToShortDateString + " and " + Me.EndFilterDate.Value.ToShortDateString

        ElseIf Me.Starting_Ticket.Text <> "" And Me.Ending_Ticket.Text <> "" Then

            Dim Starting As Integer = CType(Me.Starting_Ticket.Text, Integer)
            Dim Ending As Integer = CType(Me.Ending_Ticket.Text, Integer)

            If Me.UseArchive Then
                Me.TransactionsTableAdapter1.FillByStartingEndingArchive(Me.IrS_ScaleDataSet1.Transactions, Starting, Ending)
            Else
                Me.TransactionsTableAdapter1.FillByStartingEndingTicket(Me.IrS_ScaleDataSet1.Transactions, Starting, Ending)
            End If

            ReportSetupRow.FilterString = "All Tickets Between " + Starting.ToString + " And " + Ending.ToString

            ', Me, Me.StartFilterDate.Value, Me.EndFilterDate.Value)

        Else
            If Me.UseArchive Then
                Me.TransactionsTableAdapter1.FillByNotVoidedArchive(Me.IrS_ScaleDataSet1.Transactions)
            Else
                Me.TransactionsTableAdapter1.FillByNotVoided(Me.IrS_ScaleDataSet1.Transactions)
            End If

            ReportSetupRow.FilterString = "All Transactions In Database"
        End If
        ReportSetupRow.Supress_Detail = Me.Suppres_Details.Checked
        ReportSetupRow.Show_Price = Me.ckShowPrice.Checked

        Me.IrS_ScaleDataSet1.ReportSetup.AddReportSetupRow(ReportSetupRow)

        Rpt.Report.SetDataSource(Me.IrS_ScaleDataSet1)

        Me.CrystalReportViewer1.ReportSource = Rpt.Report

    End Sub

    Private Sub Sort_By_Date_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sort_By_Date_CheckBox.CheckedChanged
        Me.grpDateFilter.Enabled = Me.Sort_By_Date_CheckBox.Checked
        If Me.Visible Then LoadData()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '  Me.Timer1.Stop()
        '  LoadData()
    End Sub

    Private Sub StartFilterDate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartFilterDate.CloseUp, EndFilterDate.CloseUp
        Me.Timer1.Stop()
        Me.Timer1.Start()
    End Sub

    Private Sub Report_Preview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartFilterDate.Value = Now
        Me.EndFilterDate.Value = Now
        Me.ckShowPrice.Checked = My.Forms.MDIParent.Setup.SetupItems.Show_Price_By_Default
    End Sub

    'Private Sub btnMoreFiltering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoreFiltering.Click
    '    If Me.btnMoreFiltering.Text = "More Filtering" Then
    '        Me.btnMoreFiltering.Text = "Less Filtering"
    '        Me.pnlMoreFiltering.Visible = True
    '    Else
    '        Me.btnMoreFiltering.Text = "More Filtering"
    '        Me.pnlMoreFiltering.Visible = False
    '        Me.CheckAllBoxes()
    '        LoadData()
    '    End If

    'End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.Getting_Data.TopMost = True
        My.Forms.Getting_Data.Show()

        Me.IrS_ScaleDataSet1.ProductsFiltered.Clear()
        Me.IrS_ScaleDataSet1.AccountsFiltered.Clear()
        Me.IrS_ScaleDataSet1.Job_Name_Filtered.Clear()
        For Each Item As Object In Me.cboProducts.CheckedItems
            Dim row As IRS.IRS_ScaleDataSet.ProductsFilteredRow = Me.IrS_ScaleDataSet1.ProductsFiltered.NewProductsFilteredRow
            row.Product_Name = Item
            Me.IrS_ScaleDataSet1.ProductsFiltered.AddProductsFilteredRow(row)
        Next

        For Each Item As Object In Me.cboCustomers.CheckedItems
            Dim row As IRS.IRS_ScaleDataSet.AccountsFilteredRow = Me.IrS_ScaleDataSet1.AccountsFiltered.NewAccountsFilteredRow
            row.Account_Name = Item
            Me.IrS_ScaleDataSet1.AccountsFiltered.AddAccountsFilteredRow(row)
        Next
        If Me.ckFilterByJob.Checked = True Then
            For Each Item As Object In Me.cboJobs.CheckedItems
                Dim row As IRS.IRS_ScaleDataSet.Job_Name_FilteredRow = Me.IrS_ScaleDataSet1.Job_Name_Filtered.NewJob_Name_FilteredRow
                row.Job_Name = Item
                Me.IrS_ScaleDataSet1.Job_Name_Filtered.AddJob_Name_FilteredRow(row)
            Next
        Else

            For Each Item As Object In Me.cboJobs.Items
                Dim row As IRS.IRS_ScaleDataSet.Job_Name_FilteredRow = Me.IrS_ScaleDataSet1.Job_Name_Filtered.NewJob_Name_FilteredRow
                row.Job_Name = Item
                Me.IrS_ScaleDataSet1.Job_Name_Filtered.AddJob_Name_FilteredRow(row)
            Next

        End If


        LoadData()
        My.Forms.Getting_Data.Close()
    End Sub

    Private Sub pnlMoreFiltering_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlMoreFiltering.Paint

    End Sub


    Private Sub cboCustomers_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles cboProducts.ItemCheck, cboCustomers.ItemCheck

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Checked As Boolean
        Dim txt As String = "Uncheck All Products"
        If Me.Button4.Text = txt Then
            Me.Button4.Text = "Check All Products"
            Checked = False
        Else
            Checked = True
            Me.Button4.Text = txt

        End If


        Me.cboProducts.Items.Clear()

        For Each row As IRS_ScaleDataSet.ProductRow In Me.IrS_ScaleDataSet1.Product
            Me.cboProducts.Items.Add(row.Product_Name, Checked)
        Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim Checked As Boolean
        Dim txt As String = "Uncheck All Customers"
        If Me.Button2.Text = txt Then
            Me.Button2.Text = "Check All Customers"
            Checked = False
        Else
            Checked = True
            Me.Button2.Text = txt

        End If

        Me.cboCustomers.Items.Clear()
        For Each row As IRS_ScaleDataSet.AccountRow In Me.IrS_ScaleDataSet1.Account
            Me.cboCustomers.Items.Add(row.Account_Name, Checked)

        Next
    End Sub

    Private Sub ckShowPrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckShowPrice.CheckedChanged
        LoadData()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim Checked As Boolean
        Dim txt As String = "Uncheck All Jobs"
        If Me.Button5.Text = txt Then
            Me.Button5.Text = "Check All Jobs"
            Checked = False
        Else
            Checked = True
            Me.Button5.Text = txt

        End If



        Me.cboJobs.Items.Clear()
        For Each row As IRS_ScaleDataSet.TransactionJobsRow In Me.IrS_ScaleDataSet1.TransactionJobs
            Me.cboJobs.Items.Add(row.Job_Name, Checked)
        Next

    End Sub

    Private Sub ckFilterByJob_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckFilterByJob.CheckedChanged
        Me.pnlJob.Visible = Me.ckFilterByJob.Checked
    End Sub

    Private Sub Starting_Ticket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Starting_Ticket.TextChanged, Ending_Ticket.TextChanged
        Me.grpDateFilter.Enabled = Me.Starting_Ticket.Text.Trim = "" And Me.Ending_Ticket.Text.Trim = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Ending_Ticket.Text = ""
        Me.Starting_Ticket.Text = ""


    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Forms.Getting_Data.TopMost = True
        My.Forms.Getting_Data.Show()
        My.Application.DoEvents()


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted



    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub CrystalReportViewer1_ReportRefresh(ByVal source As Object, ByVal e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles CrystalReportViewer1.ReportRefresh


    End Sub

    Private Sub cbReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportType.SelectedIndexChanged

    End Sub
End Class