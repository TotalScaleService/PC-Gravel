Imports System.Windows.Forms

Public Class Zip_Codes

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.Validate()
            Me.Zip_CodesBindingSource.EndEdit()
            Me.Zip_CodesTableAdapter.Update(Me.IRS_ScaleDataSet.Zip_Codes)
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

    Private Sub Zip_CodesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zip_CodesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Zip_CodesBindingSource.EndEdit()
            Me.Zip_CodesTableAdapter.Update(Me.IRS_ScaleDataSet.Zip_Codes)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Zip_Codes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IRS_ScaleDataSet.States' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Fill(Me.IRS_ScaleDataSet.States)

        Me.Zip_CodesTableAdapter.Fill(Me.IRS_ScaleDataSet.Zip_Codes)

    End Sub

    Private Sub Zip_CodesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Zip_CodesDataGridView.CellContentClick

    End Sub

    Private Sub Zip_CodesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Zip_CodesDataGridView.DataError
        Me.Zip_CodesBindingSource.CancelEdit()

    End Sub
End Class
