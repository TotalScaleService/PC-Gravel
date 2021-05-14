Imports System.Windows.Forms

Public Class System_Setup

    Dim Port1Index As Integer
    Dim Port2Index As Integer
    Dim Port3Index As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Try

                My.Settings.FlashDeliveryRate = Me.ckFlashDeliveryRate.Checked
                My.Settings.FlashDeliveryRate = Me.ckFlashDeliveryRate.Checked

                My.Settings.FirstScaleName = txtScale1Name.Text
                My.Settings.First_Scale_ComPort = Comm_PortComboBox.Text

                My.Settings.Second_Scale = ckDualScale.Checked
                My.Settings.SecondScaleName = txtScale2Name.Text
                My.Settings.Second_Scale_ComPort = Comm_PortComboBox2.Text
                My.Settings.ReceiptPrinterPort = Comm_PortComboBox3.Text

                My.Settings.ReportPrinter = Report_PrinterTextBox.Text
                My.Settings.TicketPrinter = Ticket_PrinterTextBox.Text
                My.Settings.SimulateScale = Simulate_ScaleCheckBox.Checked

                My.Settings.Save()

            Catch ex As Exception

            End Try

            Me.Validate()
            Me.SetupBindingSource.EndEdit()
            Me.SetupTableAdapter.Update(Me.IRS_ScaleDataSet.Setup)
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

    Private Sub System_Setup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HaulerTableAdapter.Fill(Me.IRS_ScaleDataSet.Hauler)
        Me.Comm_PortComboBox.Items.Clear()
        Me.Comm_PortComboBox2.Items.Clear()
        Me.Comm_PortComboBox3.Items.Clear()

        Me.SetupTableAdapter.Fill(Me.IRS_ScaleDataSet.Setup)

        If Me.IRS_ScaleDataSet.Setup.Count = 0 Then
            Me.SetupBindingSource.AddNew()
        End If

        Dim MyCount As Int16 = 0

        Port1Index = 0
        Port2Index = 0
        Port3Index = 0

        'Add a No Printer Option for cases where there is no receipt printer hooked up.
        Me.Comm_PortComboBox3.Items.Add("No Printer")

        For Each PortName As String In My.Computer.Ports.SerialPortNames
            Me.Comm_PortComboBox.Items.Add(PortName)
            Me.Comm_PortComboBox2.Items.Add(PortName)
            Me.Comm_PortComboBox3.Items.Add(PortName)

            If My.Settings.First_Scale_ComPort = PortName Then
                Port1Index = MyCount
            End If
            If My.Settings.Second_Scale_ComPort = PortName Then
                Port2Index = MyCount
            End If
            If My.Settings.ReceiptPrinterPort = PortName Then
                Port3Index = MyCount + 1  ' I added an extra item to the list so I have to index 1 higher to account for that.
            End If
            MyCount = MyCount + 1
        Next

        Try

            Me.ckFlashDeliveryRate.Checked = My.Settings.FlashDeliveryRate
            txtScale1Name.Text = My.Settings.FirstScaleName
            txtScale2Name.Text = My.Settings.SecondScaleName
            Report_PrinterTextBox.Text = My.Settings.ReportPrinter
            Ticket_PrinterTextBox.Text = My.Settings.TicketPrinter
            ckDualScale.Checked = My.Settings.Second_Scale
            Simulate_ScaleCheckBox.Checked = My.Settings.SimulateScale

            Me.Comm_PortComboBox.SelectedIndex = Port1Index
            Me.Comm_PortComboBox2.SelectedIndex = Port2Index
            Me.Comm_PortComboBox3.SelectedIndex = Port3Index

            Label4.Enabled = ckDualScale.Checked
            txtScale2Name.Enabled = ckDualScale.Checked
            Comm_PortComboBox2.Enabled = ckDualScale.Checked

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Zip_Codes.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim row As IRS_ScaleDataSet.SetupRow

        row = CType(CType(Me.SetupBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.SetupRow)
        If row.Ticket_Paper <> "" Then
            With Me.PrintDialog1.PrinterSettings.DefaultPageSettings.PaperSize
                .RawKind = 0
                .PaperName = row.Ticket_Paper
                '.RawKind = row.Ticket_Raw_Kind
                .Height = row.Ticket_Height
                .Width = row.Ticket_Width
            End With
        End If
        Me.PrintDialog1.PrinterSettings.PrinterName = Me.Ticket_PrinterTextBox.Text
        If Me.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then


            Dim Ps As Printing.PaperSize = Me.PrintDialog1.PrinterSettings.DefaultPageSettings.PaperSize
            Dim PsString As String = Ps.ToString

            Dim NewPs As New Printing.PaperSize
            row.Ticket_Height = Ps.Height
            row.Ticket_Paper = Ps.PaperName 'String
            row.Ticket_Raw_Kind = 0
            row.Ticket_Width = Ps.Width 'Width



        End If

        Me.Ticket_PrinterTextBox.Text = Me.PrintDialog1.PrinterSettings.PrinterName

    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.PrintDialog1.PrinterSettings.PrinterName = Me.Report_PrinterTextBox.Text
        If Me.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then Me.Report_PrinterTextBox.Text = Me.PrintDialog1.PrinterSettings.PrinterName

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Archive_Date_Range.ShowDialog()

    End Sub

    Private Sub ckDualScale_CheckedChanged(sender As Object, e As EventArgs) Handles ckDualScale.CheckedChanged

        Label4.Enabled = ckDualScale.Checked
        txtScale2Name.Enabled = ckDualScale.Checked
        Comm_PortComboBox2.Enabled = ckDualScale.Checked

    End Sub

    Private Sub ckAllowEmail_CheckedChanged(sender As Object, e As EventArgs) Handles ckAllowEmail.CheckedChanged
        pnlEmail.Visible = ckAllowEmail.Checked
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
