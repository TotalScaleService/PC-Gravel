Imports System.Windows.Forms

Public Class Truck_List

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.Validate()
            Me.TrucksBindingSource.EndEdit()
            Me.TrucksTableAdapter.Update(Me.IRS_ScaleDataSet.Trucks)
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

    Private Sub TrucksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrucksBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TrucksBindingSource.EndEdit()
            Me.TrucksTableAdapter.Update(Me.IRS_ScaleDataSet.Trucks)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Truck_List_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.MDIParent.TrucksOnHold.TrucksTableAdapter.FillByOnHold(My.Forms.MDIParent.TrucksOnHold.IrS_ScaleDataSet.Trucks)
    End Sub

    Private Sub Truck_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HaulerTableAdapter.Fill(Me.IRS_ScaleDataSet.Hauler)
        Me.TrucksTableAdapter.Fill(Me.IRS_ScaleDataSet.Trucks)
        Me.cboHaulerList.Items.Clear()
        For Each row As IRS_ScaleDataSet.HaulerRow In Me.IRS_ScaleDataSet.Hauler
            Me.cboHaulerList.Items.Add(row.Hauler_Name)
        Next
        Me.cboHaulerList.SelectedIndex = -1
    End Sub

    Public Sub SetFilter()
        Dim Hauler As String = ""
        Dim Trucks As String = ""
        Dim Filter As String = ""
        Hauler = Me.cboHaulerList.Text.Trim
        If Me.txtFilter.Text.Trim <> "" Then Trucks = Me.txtFilter.Text.Trim
        If Hauler <> "" Then
            Filter = "Hauler_Name='" + Hauler + "'"
        End If
        If Filter <> "" And Trucks <> "" Then
            Filter += " and "
        End If

        If Trucks <> "" Then
            Filter += "Truck_Id like '" + Trucks + "*'"
        End If
        Me.TrucksBindingSource.Filter = Filter
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        SetFilter()
    End Sub

    Private Sub cboHaulerList_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHaulerList.TextChanged
        SetFilter()
    End Sub

   
    Private Sub TrucksDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TrucksDataGridView.CellContentClick

    End Sub

    Private Sub TrucksDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TrucksDataGridView.DataError

    End Sub
End Class
