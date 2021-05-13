Imports System.Windows.Forms

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Ticket_List
    Dim EditingTicket As Boolean = False

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TransactionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TransactionsBindingSource.EndEdit()
        Me.TransactionsTableAdapter.Update(Me.IRS_ScaleDataSet.Transactions)

    End Sub

    Private Sub Ticket_List_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
        If EditingTicket = True Then
            EditingTicket = False
            Dim p As Integer = Me.TransactionsBindingSource.Position

            My.Forms.Getting_Data.TopMost = True
            My.Forms.Getting_Data.Show()
            My.Application.DoEvents()

            Me.TransactionsTableAdapter.Fill(Me.IRS_ScaleDataSet.Transactions)
            Me.TransactionsBindingSource.Position = p

            My.Forms.Getting_Data.Close()

        End If

    End Sub

    Private Sub Ticket_List_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.MDIParent.pnlWeights.Visible = True
        My.Forms.MDIParent.MainMenuStrip.Visible = True
    End Sub

    Private Sub Ticket_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IRS_ScaleDataSet.Distinct_Trucks' table. You can move, or remove it, as needed.
        Me.Distinct_TrucksTableAdapter.Fill(Me.IRS_ScaleDataSet.Distinct_Trucks)
        My.Forms.Getting_Data.TopMost = True
        My.Forms.Getting_Data.Show()
        My.Application.DoEvents()
        Me.JobTableAdapter.Fill(Me.IRS_ScaleDataSet.Job)
        Me.TrucksTableAdapter.Fill(Me.IRS_ScaleDataSet.Trucks)
        Me.HaulerTableAdapter.Fill(Me.IRS_ScaleDataSet.Hauler)
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Me.ProductTableAdapter.Fill(Me.IRS_ScaleDataSet.Product)
        SetFilter()
        Me.TransactionsTableAdapter.Fill(Me.IRS_ScaleDataSet.Transactions)
        Me.Opacity = 1
        My.Forms.Getting_Data.Close()


    End Sub

    Private Sub Sort_By_Date_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sort_By_Date_CheckBox.CheckedChanged
        Me.grpDateFilter.Enabled = Me.Sort_By_Date_CheckBox.Checked

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlFilter.Paint

    End Sub

    Private Sub DateFilterChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartFilterDate.ValueChanged, EndFilterDate.ValueChanged

        'SetFilter()

    End Sub

    Public Sub SetFilter()
        Dim Filter As String = ""


        'New section for displaying 'Loading Data' when filter is changed.
        My.Forms.Getting_Data.TopMost = True
        My.Forms.Getting_Data.Show()
        My.Application.DoEvents()

        If Me.grpDateFilter.Enabled Then
            Filter = "Date_Out >= #" + Me.StartFilterDate.Value.ToShortDateString + "#   AND Date_Out <= #" + Me.EndFilterDate.Value.AddDays(1).ToShortDateString + "#"
        End If
        If Me.Product_NameComboBox.Enabled Then
            Filter += SetAnd(Filter) + "Product_Name ='" + Me.Product_NameComboBox.Text + "'"
        End If
        If Me.Account_NameComboBox.Enabled Then
            Filter += SetAnd(Filter) + "Account_Name='" + Me.Account_NameComboBox.Text + "'"
        End If

        If Me.Hauler_NameComboBox.Enabled Then
            Filter += SetAnd(Filter) + "Hauler_Name='" + Me.Hauler_NameComboBox.Text + "'"
        End If

        If Me.Truck_IdComboBox.Enabled Then
            Filter += SetAnd(Filter) + "Truck_Id='" + Me.Truck_IdComboBox.Text + "'"
        End If
        If Me.Job_NameComboBox.Enabled Then
            Filter += SetAnd(Filter) + "Job_Name='" + Me.Job_NameComboBox.Text + "'"
        End If

        If Me.Button2.Text = "View Non Voided Tickets" Then
            Filter += SetAnd(Filter) + "Void=true"
        Else
            Filter += SetAnd(Filter) + "Void=false"
        End If


        Me.TransactionsBindingSource.Filter = Filter
        Dim row As IRS_ScaleDataSet.TransactionsRow
        Dim Quantity As Integer
        For I As Integer = 0 To Me.TransactionsBindingSource.Count - 1
            row = CType(CType(Me.TransactionsBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.TransactionsRow)
            If Not row.IsQuantityNull Then Quantity += row.Quantity

        Next I

        My.Forms.Getting_Data.Close()
        'This sorts the existing datagridview by column(4) which is Date_Out descending.
        TransactionsDataGridView.Sort(TransactionsDataGridView.Columns(4), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Public Function SetAnd(ByVal Filter As String) As String
        If Filter <> "" Then
            Return " and "
        Else
            Return ""

        End If
    End Function


    Private Sub Product_NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product_NameComboBox.SelectedIndexChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Me.Product_NameComboBox.Enabled = Me.CheckBox3.Checked
        'SetFilter()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Account_NameComboBox.Enabled = Me.CheckBox2.Checked
        'SetFilter()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.Hauler_NameComboBox.Enabled = Me.CheckBox1.Checked
        'SetFilter()

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Me.Truck_IdComboBox.Enabled = Me.CheckBox4.Checked
        'SetFilter()

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Me.Job_NameComboBox.Enabled = Me.CheckBox5.Checked
        'SetFilter()

    End Sub

    Private Sub CheckFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Truck_IdComboBox.TextChanged, Product_NameComboBox.TextChanged, Job_NameComboBox.TextChanged, Hauler_NameComboBox.TextChanged, Account_NameComboBox.TextChanged
        'SetFilter()

    End Sub

    Private Sub grpDateFilter_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpDateFilter.EnabledChanged
        'SetFilter()

    End Sub

    Private Sub grpDateFilter_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpDateFilter.Enter

    End Sub

    Private Sub TransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TransactionsDataGridView.CellContentClick
        If e.ColumnIndex >= 0 Then
            If e.ColumnIndex = Me.SelectBtn.Index Then
                Me.EditingTicket = True
                Dim row As IRS_ScaleDataSet.TransactionsRow
                row = CType(CType(Me.TransactionsBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.TransactionsRow)
                Dim WeighTicket As New Weigh_Ticket(row.Ticket)
            ElseIf e.ColumnIndex = Me.VoidBtn.Index Then
                Dim row As IRS_ScaleDataSet.TransactionsRow
                row = CType(CType(Me.TransactionsBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.TransactionsRow)
                row.Void = True
                Me.TransactionsTableAdapter.Update(Me.IRS_ScaleDataSet.Transactions)

            ElseIf e.ColumnIndex = Me.RestoreBtn.Index Then
                Dim row As IRS_ScaleDataSet.TransactionsRow
                row = CType(CType(Me.TransactionsBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.TransactionsRow)
                row.Void = False
                Me.TransactionsTableAdapter.Update(Me.IRS_ScaleDataSet.Transactions)
            End If
        End If
    End Sub

    'Private Sub ReportByProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Rpt As New 
    '    Dim ds As New IRS_ScaleDataSet
    '    Dim row As IRS_ScaleDataSet.TransactionsRow
    '    For I As Integer = 0 To Me.TransactionsBindingSource.List.Count - 1
    '        row = CType(CType(Me.TransactionsBindingSource(I), DataRowView).Row, IRS_ScaleDataSet.TransactionsRow)
    '        Dim NewRow As IRS_ScaleDataSet.TransactionsRow = ds.Transactions.NewTransactionsRow
    '        NewRow.ItemArray = row.ItemArray
    '        ds.Transactions.AddTransactionsRow(NewRow)
    '    Next







    '    Rpt.SetDataSource(ds)
    '    My.Forms.Report_Preview.CrystalReportViewer1.ReportSource = Rpt
    '    My.Forms.Report_Preview.ShowDialog()

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub Account_NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Account_NameComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.Button2.Text = "View Non Voided Tickets" Then
            Me.RestoreBtn.Visible = False
            Me.SelectBtn.Visible = True
            Me.VoidBtn.Visible = True
            Me.Button2.Text = "View Voided Tickets"
        Else
            Me.RestoreBtn.Visible = True
            Me.SelectBtn.Visible = False
            Me.VoidBtn.Visible = False
            Me.Button2.Text = "View Non Voided Tickets"
        End If
        SetFilter()
    End Sub

    Private Sub Job_NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Job_NameComboBox.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        SetFilter()
    End Sub
End Class
