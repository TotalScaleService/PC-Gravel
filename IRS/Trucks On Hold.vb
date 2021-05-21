Public Class Trucks_On_Hold

    Private Sub CreateTicketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTicketButton.Click
        ' My.Forms.MDIParent.MenuStrip.Visible = False
        Dim Ticket As New Weigh_Ticket()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.MDIParent.pnlWeights.Visible = False
        My.Forms.MDIParent.MenuStrip.Visible = False

        ShowForm(My.Forms.Ticket_List)
        RefreshTrucksOnHold()

    End Sub

    Private Sub PrintBasicTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBasicTicket.Click
        My.Forms.BasicTicketInfo.ShowDialog()
        RefreshTrucksOnHold()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowForm(My.Forms.Account_List)
        RefreshTrucksOnHold()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ShowForm(My.Forms.Haulers_List)
        RefreshTrucksOnHold()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ShowForm(My.Forms.Job_List)
        RefreshTrucksOnHold()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ShowForm(My.Forms.Product_List)
        RefreshTrucksOnHold()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ShowForm(My.Forms.Truck_List)
        RefreshTrucksOnHold()

    End Sub

    Private Sub TrucksDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TrucksDataGridView.CellContentClick
        Try

            If e.RowIndex > -1 Then
                Dim row As IRS.IRS_ScaleDataSet.TrucksRow
                row = CType(CType(Me.TrucksBindingSource.Current, DataRowView).Row, IRS.IRS_ScaleDataSet.TrucksRow)
                If e.ColumnIndex = Me.SelectBtn.Index Then
                    Dim Ticket As New Weigh_Ticket(row.Hauler_Name, row.Truck_Id)
                ElseIf e.ColumnIndex = Me.DeleteBtn.Index Then
                    row.On_Hold = False
                    Me.TrucksBindingSource.EndEdit()
                    Me.TrucksTableAdapter.Update(Me.IrS_ScaleDataSet.Trucks)
                    Me.TrucksTableAdapter.FillByOnHold(Me.IrS_ScaleDataSet.Trucks)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Trucks_On_Hold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTrucksOnHold()
    End Sub


    Private Sub ShowForm(ByVal f As Windows.Forms.Form)

        f.MdiParent = Me.MdiParent
        f.Dock = DockStyle.Fill
        f.Show()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim f As New Report_Preview(False)
        f.WindowState = FormWindowState.Maximized
        f.ShowDialog()
        RefreshTrucksOnHold()

    End Sub

    Private Sub RefreshTrucksOnHold()
        Me.TrucksTableAdapter.FillByOnHold(Me.IrS_ScaleDataSet.Trucks)
    End Sub
End Class