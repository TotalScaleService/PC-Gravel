Imports System.Windows.Forms

Public Class Product_List

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Button.Click
        Try
            Me.Validate()
            Me.ProductBindingSource.EndEdit()
            Me.ProductTableAdapter.Update(Me.IRS_ScaleDataSet.Product)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ProductBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProductBindingSource.EndEdit()
            Me.ProductTableAdapter.Update(Me.IRS_ScaleDataSet.Product)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Product_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProductTableAdapter.Fill(Me.IRS_ScaleDataSet.Product)
    End Sub


    Private Sub ProductDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles ProductDataGridView.CellValidating
        If e.ColumnIndex = Me.ProductDataGridView.Columns("Price_Per_UOM").Index Or _
             e.ColumnIndex = Me.ProductDataGridView.Columns("Tons_Per_Yard").Index Then
            Try
                If e.FormattedValue <> "" Then Dim D As Double = CType(e.FormattedValue, Double)
            Catch ex As Exception
                sender.CurrentCell.Value = 0
            End Try
        End If
    End Sub

    Private Sub ProductDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ProductDataGridView.DataError
        MsgBox(e.Exception.Message)
    End Sub
End Class
