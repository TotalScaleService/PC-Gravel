Imports System.Windows.Forms

Public Class Job_List

    




    Private Sub JobBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.JobBindingSource.EndEdit()
            Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet.Job)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Fill_List()
        Me.JobTableAdapter.Fill(Me.IRS_ScaleDataSet.Job)
    End Sub

    Private Sub Job_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IRS_ScaleDataSet.Account' table. You can move, or remove it, as needed.
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Me.JobTableAdapter.Fill(Me.IRS_ScaleDataSet.Job)
        Me.cboAccountsList.Items.Clear()
        For Each row As IRS_ScaleDataSet.AccountRow In Me.IRS_ScaleDataSet.Account
            Me.cboAccountsList.Items.Add(row.Account_Name)
        Next
        Me.cboAccountsList.SelectedIndex = -1
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        SetFilter()

    End Sub

    Public Sub SetFilter()
        Dim Account As String = ""
        Dim Jobs As String = ""
        Dim Filter As String = ""
        Account = Me.cboAccountsList.Text.Trim
        If Me.txtFilter.Text.Trim <> "" Then Jobs = Me.txtFilter.Text.Trim
        If Account <> "" Then
            Filter = "Account_Name='" + Account + "'"
        End If
        If Filter <> "" And Jobs <> "" Then
            Filter += " and "
        End If

        If Jobs <> "" Then
            Filter += "Job_Name like '" + Jobs + "*'"
        End If
        Me.JobBindingSource.Filter = Filter
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.JobBindingSource.EndEdit()
            Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet.Job)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub JobDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles JobDataGridView.CellContentClick
        If e.ColumnIndex = Me.EditBtn.Index And e.RowIndex > -1 Then
            If JobBindingSource.Current.IsNew Then Exit Sub
            Dim row As IRS_ScaleDataSet.JobRow
            row = CType(CType(Me.JobBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.JobRow)
            Dim f As New Job_Details(row.Account_Name, row.Job_Name)
            f.ShowDialog()
        End If
    End Sub

    Private Sub JobDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles JobDataGridView.DataError
    End Sub

   

    Private Sub cboAccountsList_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAccountsList.TextChanged
        SetFilter()
    End Sub
End Class
