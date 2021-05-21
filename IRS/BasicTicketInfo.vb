Imports System.Windows.Forms

Public Class BasicTicketInfo
    Dim Gross As Integer = My.Forms.MDIParent.Weight


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim HandWeight As Integer = 0
        Integer.TryParse(Me.txtHand.Text, HandWeight)

        Dim BT As New CrystalReport
        BT.LoadReport(CrystalReport.enReportType.Basic)
        Dim DS As New IRS_ScaleDataSet

        Dim SetupTblAdapter As New IRS_ScaleDataSetTableAdapters.SetupTableAdapter
        SetupTblAdapter.Fill(DS.Setup)
        Dim row As IRS_ScaleDataSet.BasicTicketRow = DS.BasicTicket.NewBasicTicketRow
        row.Comment = Me.TextBox1.Text
        row.Date_Time = Now
        row.ScaleWeight = Me.Gross
        row.HandWeight = HandWeight
        DS.BasicTicket.AddBasicTicketRow(row)

        BT.Report.SetDataSource(DS)
        ' BT.SetParameters("Comment=" + Me.TextBox1.Text + "&DateWeighed=" + Now.ToString + "&grossweight=" + Me.Gross.ToString + "&HandWeight=" + Me.Gross.ToString)
        ' BT.Report.SetDataSource(Me.IRS_ScaleDataSet)
        'BT.Report.SetParameterValue(BT.Report.Parameter_Comment.ParameterFieldName, Me.TextBox1.Text)
        'BT.Report.SetParameterValue(BT.Report.Parameter_Date_Weighed.ParameterFieldName, Now)
        'BT.Report.SetParameterValue(BT.Report.Parameter_Gross_Weight.ParameterFieldName, Me.Gross)
        If My.Forms.MDIParent.PrintToScreen = True Then
            Dim TktPreview As New Ticket_Preview
            With TktPreview
                .CrystalReportViewer1.ReportSource = BT.Report
                .ShowDialog()
            End With
        Else
            Try
                BT.Report.PrintToPrinter(1, 1, 1, 1)
            Catch ex As Exception
                MsgBox("Problem Printing " + ex.Message, vbOKOnly, "Opps...")
            End Try

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BasicTicketInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IRS_ScaleDataSet.Setup' table. You can move, or remove it, as needed.
        Me.SetupTableAdapter.Fill(Me.IRS_ScaleDataSet.Setup)
        Me.Gross = My.Forms.MDIParent.Weight
        Me.lblWeight.Text = "Scale Weight : " + Me.Gross.ToString
        Me.txtHand.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblDate.Text = Now.ToShortDateString + "  " + Now.ToLongTimeString
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        sender.backcolor = Color.Yellow
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        sender.backcolor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.GotFocus, Cancel_Button.GotFocus
        sender.backcolor = Color.Yellow

    End Sub

    Private Sub Button_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel_Button.LostFocus, OK_Button.LostFocus
        sender.backcolor = Me.BackColor


    End Sub

    Private Sub SetupBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SetupBindingSource.EndEdit()
        Me.SetupTableAdapter.Update(Me.IRS_ScaleDataSet.Setup)

    End Sub
End Class
