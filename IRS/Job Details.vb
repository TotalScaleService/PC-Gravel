Imports System.Windows.Forms

Public Class Job_Details
    Public Job As String
    Public Account As String
    Dim JobRow As IRS_ScaleDataSet.JobRow

    Public Sub New(ByVal fAccount As String, ByVal fJob As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Account = fAccount
        Job = fJob


        Me.JobTableAdapter.FillByJobAccount(Me.IRS_ScaleDataSet.Job, Job, Account)
        Me.ProductTableAdapter.Fill(Me.IRS_ScaleDataSet.Product)
        Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Account, Job)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.Validate()
            Me.JobBindingSource.EndEdit()
            Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet.Job)
            Me.Job_ProductsTableAdapter.Update(Me.IRS_ScaleDataSet.Job_Products)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub JobBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.JobBindingSource.EndEdit()
        Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet.Job)

    End Sub

    Private Sub Job_Details_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Job_List.Fill_List()
    End Sub

    Private Sub Job_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub



    Private Sub Job_ProductsDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Job_ProductsDataGridView.RowValidating
        Dim row As IRS.IRS_ScaleDataSet.Job_ProductsRow
        row = CType(CType(Me.Job_ProductsBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.Job_ProductsRow)
        row.Account_Name = Me.Account
        row.Job_Name = Me.Job
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Delete " + vbCrLf + Me.Job + " ??", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            Me.JobBindingSource.RemoveCurrent()
            Me.Validate()
            Me.JobBindingSource.EndEdit()
            Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub TxtKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Job_NumberTextBox.KeyDown, Job_NameComboBox.KeyDown, Job_KeyTextBox.KeyDown, DescriptionTextBox.KeyDown, AddressTextBox.KeyDown, Account_NameTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Job_ProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Job_ProductsDataGridView.CellContentClick

        Try

            If e.RowIndex > -1 Then

                Dim row As IRS.IRS_ScaleDataSet.Job_ProductsRow
                row = CType(CType(Me.Job_ProductsBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.Job_ProductsRow)

                If e.ColumnIndex = Me.Deletebtn.Index Then

                    row.Delete()
                    Me.Validate()
                    Me.Job_ProductsBindingSource.EndEdit()
                    Me.Job_ProductsTableAdapter.Update(Me.IRS_ScaleDataSet)
                    Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Account, Job)

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
