Imports System.Windows.Forms

Public Class Haulers_List

    Private Sub HaulerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.HaulerBindingSource.EndEdit()
            Me.HaulerTableAdapter.Update(Me.IRS_ScaleDataSet.Hauler)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Haulers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Dim row As IRS_ScaleDataSet.AccountRow = Me.IRS_ScaleDataSet.Account.NewAccountRow
        row.Account_Name = ""
        Me.IRS_ScaleDataSet.Account.AddAccountRow(row)
        Me.HaulerTableAdapter.Fill(Me.IRS_ScaleDataSet.Hauler)

    End Sub

    Private Sub HaulerDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles HaulerDataGridView.DataError
        '   Me.HaulerBindingSource.CancelEdit()
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        If Me.txtFilter.Text.Trim = "" Then
            HaulerBindingSource.Filter = ""
        Else
            Me.HaulerBindingSource.Filter = "Hauler_Name Like '" + Me.txtFilter.Text + "*'"
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.Validate()
            Me.HaulerBindingSource.EndEdit()
            Me.HaulerTableAdapter.Update(Me.IRS_ScaleDataSet.Hauler)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
