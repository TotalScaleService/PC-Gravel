Imports System

Public Class Weigh_Ticket
    Dim OriginalText As String
    Dim OriginalValue As Double

    Dim OriginalDeliveryCharge As Double
    Dim OriginalDeliverFlatCharge As Boolean

    Dim CurrentText As String
    Public NewTicket, Reprint As Boolean
    Dim TransactionRow As IRS.IRS_ScaleDataSet.TransactionsRow
    Dim Down As Boolean
    Dim WithEvents indicator As WeightIndicator = My.Forms.MDIParent.Indicator


    Dim AccountSet As Boolean = False
    Dim ProductSet As Boolean = False

    Dim SavePriceToAccount As Boolean = False
    Dim SavePriceToJob As Boolean
    Dim UOM_Type As String

    Dim InWt As Integer

    Dim ManualTare As Boolean = False
    Dim Flash_Colors As Boolean

    Dim ProductRow As IRS.IRS_ScaleDataSet.ProductRow
    Dim Accountrow As IRS.IRS_ScaleDataSet.AccountRow

    Dim SuspendUpdate As Boolean = False

    Public WithEvents PrinterSerialPort As System.IO.Ports.SerialPort
    'Dim Logger As New ErrorLog.LogError


    Private Sub FillTables()

        Me.ProductTableAdapter.Fill(Me.IRS_ScaleDataSet.Product)
        Me.JobTableAdapter.Fill(Me.IRS_ScaleDataSet.Job)
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Me.TrucksTableAdapter.Fill(Me.IRS_ScaleDataSet.Trucks)
        Me.HaulerTableAdapter.Fill(Me.IRS_ScaleDataSet.Hauler)
        Me.SetupTableAdapter.Fill(Me.IRS_ScaleDataSet.Setup)
        SetTaxRate()

    End Sub


    Public Sub New(ByVal Ticket As String)  'Accessed from the Ticket Screen.  Should pull up completed ticket.



        InitializeComponent()

        Me.SuspendUpdate = True

        Me.grpQuantity.Enabled = True
        NewTicket = False
        Reprint = True
        FillTables()
        Me.SetGrossBtn.Visible = True

        Me.TransactionsTableAdapter.FillByTicket(Me.IRS_ScaleDataSet.Transactions, Ticket)
        If Me.IRS_ScaleDataSet.Transactions.Count = 0 Then
            'I don't think this will ever happen But Just in case...
            MsgBox("Cannot Find Ticket" + vbCrLf + Ticket, MsgBoxStyle.OkOnly, "Cannot Find Ticket")
            Me.Close()
            Exit Sub
        End If
        TransactionRow = Me.IRS_ScaleDataSet.Transactions(0)
        Me.QuantityTextBox.ReadOnly = TransactionRow.Unit_Of_Measure <> "Count"
        GetTransactionInformation()
        Me.SuspendUpdate = False


    End Sub


    Public Sub New(ByVal Hauler As String, ByVal TruckId As String)   ' Should be accessed to finalize a truck.

        InitializeComponent()
        NewTicket = False
        Reprint = False
        FillTables()
        Dim TruckRow As IRS_ScaleDataSet.TrucksRow = Me.IRS_ScaleDataSet.Trucks.FindByTruck_IdHauler_Name(TruckId, Hauler)

        Me.SetGrossBtn.Visible = True
        MakeNewTicket()

        With Me.TransactionRow

            .Hauler_Name = TruckRow.Hauler_Name
            If Not TruckRow.IsAccount_NameNull Then .Account_Name = TruckRow.Account_Name
            If Not TruckRow.IsJob_NameNull Then .Job_Name = TruckRow.Job_Name
            If Not TruckRow.IsProduct_NameNull Then .Product_Name = TruckRow.Product_Name
            If Not TruckRow.IsTare_WeightNull Then .Tare = TruckRow.Tare_Weight
            If Not TruckRow.IsCommentNull Then .Comment = TruckRow.Comment
            If Not TruckRow.IsTare_WeightNull Then Me.InWt = TruckRow.Tare_Weight
            If Not TruckRow.IsDriver_NameNull Then Me.txtDriver.Text = TruckRow.Driver_Name

        End With
        TransactionRow.Hauler_Name = Hauler
        TransactionRow.Truck_Id = TruckId
        GetTransactionInformation()

    End Sub



    Public Sub New()
        InitializeComponent()
        Me.NewTicket = True
        Me.Reprint = False
        Me.SetGrossBtn.Visible = True
        FillTables()
        MakeNewTicket()
        GetTransactionInformation()
        Me.GetDefaultAccount()


    End Sub

    Private Sub MakeNewTicket()
        Me.IRS_ScaleDataSet.Transactions.Clear()
        Me.TransactionsBindingSource.AddNew()
        TransactionRow = CType(CType(Me.TransactionsBindingSource.Current, DataRowView).Row, IRS.IRS_ScaleDataSet.TransactionsRow)
        TransactionRow.Delivery_Rate = 0
        Me.TransactionRow.Date_Out = Now
        TransactionRow.Taxable = True
        Dim TicketNumber As New Ticket_Number
        TransactionRow.Ticket = TicketNumber.New_Ticket_Number
        Me.TransactionsBindingSource.EndEdit()
    End Sub

    Private Sub GetTransactionInformation()

        'Me.SuspendUpdate = True
        With TransactionRow

            Me.MdiParent = My.Forms.MDIParent
            Me.WindowState = FormWindowState.Maximized
            Me.Show()

            If Reprint Then
                My.Forms.MDIParent.LockWeight()
                Me.Print_Ticket_Button.Text = "Reprint Ticket"
                Me.Save_Vehicle_Button.Text = "Save"
                Me.Print_Receipt_Button.Text = "Reprint Receipt"
                Me.Print_Ticket_Button.Visible = True
                Me.Save_Vehicle_Button.Visible = True
            End If

            Me.Account_NameComboBox.SelectedIndex = -1
            Me.Job_NameComboBox.SelectedIndex = -1
            Me.Product_NameComboBox.SelectedIndex = -1
            Me.ProductSet = False
            Me.tmrUpdate.Enabled = Not Reprint
            If Not Reprint Then Me.UpdateTime()
            If Me.TransactionRow.IsShow_PricingNull Then Me.TransactionRow.Show_Pricing = False
            Me.pnlPricing.Visible = Me.TransactionRow.Show_Pricing

            'Added by Matt Burkett 01/04/17
            'Me.grpPrice.Enabled = Me.TransactionRow.Show_Pricing


            'Weight
            Me.grpWeight.Visible = True
            Me.grpQuantity.Enabled = True
            If Not .IsGrossNull Then Me.GrossTextBox.Text = .Gross
            If Not .IsTareNull Then Me.TareTextBox.Text = .Tare
            If Not .IsTareNull And Not .IsGrossNull Then Me.NetTextBox.Text = Me.GrossTextBox.Text - Me.TareTextBox.Text
            If Me.NetTextBox.Text <> "" Then Me.NetTonsTextBox.Text = Me.NetTextBox.Text * 0.0005

            If Not Me.TransactionRow.IsYards_ConversionNull And Me.NetTonsTextBox.Text <> "" Then Me.Tons_Per_YardTextBox.Text = Format(Me.TransactionRow.Yards_Conversion, "0.00")

            If Not Me.TransactionRow.IsQuantityNull Then Me.QuantityTextBox.Text = Me.TransactionRow.Quantity
            If Not Me.TransactionRow.IsPrice_Per_UOMNull Then Me.Price_Per_UOMTextBox.Text = Format$(Me.TransactionRow.Price_Per_UOM, "$0.00")


            'Delivery Rate
            If Not .IsDelivery_Flat_RateNull Then
                Me.Delivery_Flat_RateCheckBox.Checked = .Delivery_Flat_Rate
                Me.OriginalDeliverFlatCharge = Me.Delivery_Flat_RateCheckBox.Checked
            End If
            If Not .IsDelivery_RateNull Then Me.Delivery_RateTextBox.Text = .Delivery_Rate
            pnlDelivery_Rate_By_Quantity.Visible = Not Me.Delivery_Flat_RateCheckBox.Checked

            'Quantity
            If Not .IsQuantityNull Then Me.QuantityTextBox.Text = .Quantity

            'Price
            If Not .IsPrice_Per_UOMNull Then Me.Price_Per_UOMTextBox.Text = .Price_Per_UOM
            If Not .IsTaxableNull Then Me.TaxableCheckBox.Checked = .Taxable
            ' Added Unit of Measure pull from record.
            UOM_Type = Me.TransactionRow.Unit_Of_Measure


            'Hauler Information
            If TransactionRow.IsHauler_NameNull Then

                If My.Forms.MDIParent.Setup.SetupItems.Default_Hauler.Trim <> "" And Me.Hauler_NameComboBox.SelectedIndex = -1 Then

                    Me.Hauler_NameComboBox.SelectedIndex = Me.Hauler_NameComboBox.FindStringExact(My.Forms.MDIParent.Setup.SetupItems.Default_Hauler)
                    Me.Hauler_NameComboBox.Text = My.Forms.MDIParent.Setup.SetupItems.Default_Hauler

                Else

                    Me.Hauler_NameComboBox.SelectedIndex = -1

                End If

            Else
                Me.Hauler_NameComboBox.Text = Me.TransactionRow.Hauler_Name

                If Me.TransactionRow.IsTruck_IdNull Then

                    Me.Truck_IdComboBox.SelectedIndex = -1

                Else

                    Me.Truck_IdComboBox.Text = Me.TransactionRow.Truck_Id
                    Me.Truck_IdComboBox.Enabled = True

                End If

            End If

            'Account Information
            If Me.TransactionRow.IsAccount_NameNull Then

                If Me.AccountSet = False Then
                    Me.Account_NameComboBox.SelectedIndex = -1
                End If

            Else

                Me.Account_NameComboBox.Text = Me.TransactionRow.Account_Name
                If Not Me.TransactionRow.IsDriver_NameNull Then Me.txtDriver.Text = TransactionRow.Driver_Name
                If Not Me.TransactionRow.IsJob_NameNull Then
                    Me.Job_NameComboBox.Text = Me.TransactionRow.Job_Name
                    Me.Job_NameComboBox.Enabled = True
                End If
                If Not Me.TransactionRow.IsJob_DescriptionNull Then Me.Description_Textbox.Text = Me.TransactionRow.Job_Description

            End If

            'Comment
            If Not Me.TransactionRow.IsCommentNull Then Me.CommentTextBox.Text = Me.TransactionRow.Comment

            'Ticket
            Me.TicketTextBox.Text = Me.TransactionRow.Ticket

            'Product
            If Me.TransactionRow.IsProduct_NameNull Then

                Me.Product_NameComboBox.SelectedIndex = -1
                Me.pnlPricing.Visible = My.Forms.MDIParent.Setup.SetupItems.Show_Price_By_Default

            Else

                If Not .IsProduct_NameNull Then Me.Product_NameComboBox.SelectedIndex = Me.Product_NameComboBox.FindStringExact(.Product_Name)

            End If


        End With

        UpdateGTN()
        UpdateDeliveryTotalPrice()
        'Me.SuspendUpdate = False

    End Sub

    Private Sub Weigh_Ticket_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Account_NameComboBox.DataBindings.Clear()
        My.Forms.MDIParent.MenuStrip.Visible = True
        My.Forms.MDIParent.TrucksOnHold.TrucksTableAdapter.FillByOnHold(My.Forms.MDIParent.TrucksOnHold.IrS_ScaleDataSet.Trucks)
        'My.Forms.MDIParent.TrucksOnHold.TrucksTableAdapter.FillByOnHold(My.Forms.MDIParent.IrS_ScaleDataSet1.Trucks)
        My.Forms.MDIParent.UnlockWeight()

    End Sub

    Private Sub SetTaxRate()
        If Me.NewTicket Then
            If Me.IRS_ScaleDataSet.Setup.Count > 0 Then
                Me.Tax_RateLabel.Text = "Tax Rate: " + Format$(Me.IRS_ScaleDataSet.Setup(0).Tax_Rate * 100, "0.0") + "%"
            Else
                Me.Tax_RateLabel.Text = "No Tax"
            End If
        End If
        Me.UpdatePrice()
    End Sub

    Private Sub UpdateGTN()
        If Reprint = False Then
            If Me.NewTicket = False And Me.ManualTare = False Then
                If Me.InWt > 0 Then
                    If My.Forms.MDIParent.Weight > Me.InWt Then
                        Me.GrossTextBox.Text = My.Forms.MDIParent.Weight
                        Me.TareTextBox.Text = Me.InWt
                    Else
                        Me.GrossTextBox.Text = Me.InWt
                        Me.TareTextBox.Text = My.Forms.MDIParent.Weight

                    End If
                Else
                    Me.GrossTextBox.Text = My.Forms.MDIParent.Weight
                End If

            End If
        End If

        Dim G, T, N, NT As Double
        Try
            If GrossTextBox.Text.Trim = "" Then GrossTextBox.Text = 0
            G = CType(GrossTextBox.Text, Double)
            If TareTextBox.Text.Trim = "" Then TareTextBox.Text = 0
            T = CType(TareTextBox.Text, Double)
        Catch ex As Exception
            G = 0
            T = 0
        End Try

        N = G - T 'Math.Abs(G - T)
        NT = N * 0.0005
        Me.NetTextBox.Text = N
        Me.NetTonsTextBox.Text = Format(NT, "0.00")

        If Me.Reprint = True Then

            If Not Me.TransactionRow.IsYards_ConversionNull And Me.NetTonsTextBox.Text <> "" Then Me.Tons_Per_YardTextBox.Text = Format(Me.TransactionRow.Yards_Conversion, "0.00")

        Else

            If Not Me.TransactionRow.IsYards_ConversionNull And Me.NetTonsTextBox.Text <> "" Then Me.Tons_Per_YardTextBox.Text = Format(Me.TransactionRow.Yards_Conversion, "0.00")

        End If

        Dim YardsPerTon As Double = 0
        If Me.pnlTonsPerYard.Visible Then
            If Me.Tons_Per_YardTextBox.Text <> "" Then
                Try
                    YardsPerTon = CType(Me.Tons_Per_YardTextBox.Text, Double)
                Catch ex As Exception
                End Try
            End If
        End If
        If Me.grpWeight.Visible And Me.grpQuantity.Enabled And UOM_Type <> "Count" Then
            If YardsPerTon <> 0 Then
                Dim Yards As Double = YardsPerTon
                If Yards < 0 Then Yards = 0
                Me.QuantityTextBox.Text = Format(Yards * NT, "0.00")
            Else
                If NT < 0 Then NT = 0
                Me.QuantityTextBox.Text = Format(NT, "0.00")
            End If
        End If
    End Sub

    Private Sub Update_Job()
        Try
            If Me.Account_NameComboBox.SelectedIndex <> -1 Then
                Dim Row As IRS_ScaleDataSet.JobRow
                Row = Me.IRS_ScaleDataSet.Job.FindByAccount_NameJob_Name(Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
                If Row Is Nothing Then
                    Row = Me.IRS_ScaleDataSet.Job.NewJobRow
                    Row.Account_Name = Me.Account_NameComboBox.Text
                    Row.Job_Name = Me.Job_NameComboBox.Text
                    Row.Description = Me.Description_Textbox.Text
                    Me.IRS_ScaleDataSet.Job.AddJobRow(Row)
                Else
                    Row.Description = Me.Description_Textbox.Text
                End If
                Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet.Job)
            End If
        Catch ex As Exception
            MsgBox("Error Saving Job Information " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Update_Job()
    End Sub

    Private Sub Truck_IdComboBox_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Truck_IdComboBox.EnabledChanged
        If Me.Truck_IdComboBox.Enabled = False Then Me.Truck_IdComboBox.Text = ""
    End Sub

    Private Sub GetNext(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Truck_IdComboBox.KeyDown, Job_NameComboBox.KeyDown, Account_NameComboBox.KeyDown, Hauler_NameComboBox.KeyDown, Delivery_Flat_RateCheckBox.KeyDown, CommentTextBox.KeyDown, Button1.KeyDown, QuantityTextBox.KeyDown
        If sender.GetType Is Me.Hauler_NameComboBox.GetType Then
            sender.DroppedDown = False
        End If
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FKTrucksHaulerBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles FKTrucksHaulerBindingSource.ListChanged
        Me.Truck_IdComboBox.SelectedIndex = -1
    End Sub

    Private Sub FKJobAccount1BindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles FKJobAccount1BindingSource.ListChanged
        Me.Job_NameComboBox.SelectedIndex = -1
        Me.Description_Textbox.Text = ""
    End Sub

    Private Sub Truck_IdComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Truck_IdComboBox.TextChanged
        Me.Save_Vehicle_Button.Visible = Me.Truck_IdComboBox.Text.Trim <> ""
        If Me.SuspendUpdate = False Then
            Dim row As IRS.IRS_ScaleDataSet.TrucksRow
            row = Me.IRS_ScaleDataSet.Trucks.FindByTruck_IdHauler_Name(Me.Truck_IdComboBox.Text, Me.Hauler_NameComboBox.Text)
            If Not row Is Nothing Then
                If Not row.IsAccount_NameNull And AccountSet = False Then
                    Me.Account_NameComboBox.SelectedIndex = Me.Account_NameComboBox.FindStringExact(row.Account_Name)
                    If Not row.IsJob_NameNull Then
                        Me.Job_NameComboBox.SelectedIndex = Me.Job_NameComboBox.FindStringExact(row.Job_Name)
                    Else
                        Me.Job_NameComboBox.SelectedIndex = -1
                    End If
                Else
                    If Me.AccountSet = False Then
                        Me.Account_NameComboBox.SelectedIndex = -1
                        Me.Job_NameComboBox.SelectedIndex = -1
                        Me.Description_Textbox.Text = ""
                    End If
                End If
                If Not row.IsProduct_NameNull And ProductSet = False Then
                    Me.Product_NameComboBox.SelectedIndex = Me.Product_NameComboBox.FindStringExact(row.Product_Name)
                Else
                    If ProductSet = False Then Me.Product_NameComboBox.SelectedIndex = -1
                End If
                If Not row.IsTare_WeightNull Then
                    Me.TareTextBox.Text = CType(row.Tare_Weight, Long)
                Else
                    Me.TareTextBox.Text = 0
                End If
            Else
                Me.TareTextBox.Text = 0
                If Me.AccountSet = False Then
                    Dim HRow As IRS_ScaleDataSet.HaulerRow = Me.IRS_ScaleDataSet.Hauler.FindByHauler_Name(Me.Hauler_NameComboBox.Text)
                    If Not HRow Is Nothing Then
                        If Not HRow.IsDefault_AccountNull Then
                            Me.Account_NameComboBox.SelectedIndex = Me.Account_NameComboBox.FindStringExact(HRow.Default_Account)
                        End If
                    End If
                    Me.Account_NameComboBox.SelectedIndex = -1
                    Me.Job_NameComboBox.SelectedIndex = -1
                    Me.Description_Textbox.Text = ""
                End If
                If Me.ProductSet = False Then Me.Product_NameComboBox.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Job_NameComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Job_NameComboBox.TextChanged
        Me.Description_Textbox.Enabled = Me.Job_NameComboBox.Text.Trim <> ""

        'Added by Matt Burkett to disable update when loading existing transaction
        If Me.SuspendUpdate = False Then

            If Me.Description_Textbox.Enabled Then

                Dim tbl As New IRS_ScaleDataSet.JobDataTable
                Me.JobTableAdapter.Fill(tbl)
                Dim Row As IRS_ScaleDataSet.JobRow = tbl.FindByAccount_NameJob_Name(Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                If Not Row Is Nothing Then

                    If Not Row.IsDescriptionNull Then
                        Me.Description_Textbox.Text = Row.Description
                    Else
                        Me.Description_Textbox.Text = ""
                    End If

                    If Row.IsShow_PriceNull Then Row.Show_Price = False
                    Me.pnlPricing.Visible = Row.Show_Price

                Else

                    Me.Description_Textbox.Text = ""

                End If

            Else

                Me.Description_Textbox.Text = ""

            End If

            SetPriceForProduct()

        End If

    End Sub

    Private Sub Product_NameComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Product_NameComboBox.TextChanged

        'Added by Matt Burkett to disable update when loading existing transaction
        If Me.SuspendUpdate = False Then

            SetPriceForProduct()

        End If

    End Sub

    Private Sub SetPriceForProduct()
        Dim row As IRS.IRS_ScaleDataSet.ProductRow = Me.IRS_ScaleDataSet.Product.FindByProduct_Name(Me.Product_NameComboBox.Text)
        Me.ProductRow = row
        If Not row Is Nothing Then

            Me.grpWeight.Visible = row.Use_Scale And row.Unit_Of_Measure.ToUpper <> "COUNT"
            Me.pnlTonsPerYard.Visible = row.Unit_Of_Measure.ToUpper = "YARDS"
            Me.QuantityTextBox.ReadOnly = Me.grpWeight.Visible
            Dim UOM As String = row.Unit_Of_Measure
            Me.TransactionRow.Unit_Of_Measure = row.Unit_Of_Measure

            'If the product row has a Yards per Ton conversion save it in the Transaction row.
            If Not row.IsTons_Per_YardNull Then
                Me.TransactionRow.Yards_Conversion = row.Tons_Per_Yard
            Else
                Me.TransactionRow.Yards_Conversion = 1
            End If
            UOM_Type = UOM
            UOM = UOM.Replace("s", "")

            Me.Price_Per_UOMLabel.Text = "Price Per " + UOM
            Me.grpQuantity.Enabled = True
            pnlDelivery_Rate_By_Quantity.Visible = Not Me.Delivery_Flat_RateCheckBox.Checked
            Me.Price_Per_UOMTextBox.Text = row.Price_Per_UOM
            Me.grpProduct.ForeColor = Color.Blue
            Me.grpProduct.Text = "Product"
            If Me.Product_NameComboBox.Text.Trim <> "" Then ProductSet = True
        Else
            If Me.Product_NameComboBox.Text <> "" Then
                Me.grpProduct.ForeColor = Color.Red
                Me.grpProduct.Text = "Product - Not In Database"
            End If
            pnlDelivery_Rate_By_Quantity.Visible = False
            Me.grpQuantity.Enabled = False
            Me.QuantityTextBox.ReadOnly = True
            Me.pnlTonsPerYard.Visible = False
            Me.grpWeight.Visible = False
        End If
        If Not Me.Accountrow Is Nothing And Not Me.ProductRow Is Nothing Then
            If Me.ProductRow.Taxable Then
                If Me.Accountrow.IsTaxableNull Then Me.Accountrow.Taxable = True
                Me.TaxableCheckBox.Checked = Me.Accountrow.Taxable
            Else
                Me.TaxableCheckBox.Checked = False
            End If
        Else
            Me.TaxableCheckBox.Checked = False
        End If

        UpdateGTN()
        SetProductLabel()
        GetPricing()

    End Sub

    Private Sub SetProductLabel()
        Me.lblStatus.Text = "What Product Are You Getting"
        If Me.grpWeight.Visible Then
            Me.LblStatus2.Text = "Press [ Alt ] [ T ] or click the [ Set Tare ] Button To Set The Truck Tare"
        Else
            Me.LblStatus2.Text = ""
        End If
    End Sub

    Private Sub SetAccountLabel()
        Me.lblStatus.Text = "Who Are You Selling To"
        If Me.Hauler_NameComboBox.Text.Trim = "" Or (Me.Hauler_NameComboBox.Text = Me.Account_NameComboBox.Text) Then
            Me.LblStatus2.Text = ""
        Else
            Me.LblStatus2.Text = "Press [ ALT ] [ H ] Or Click  [ Same As Hauler ] Button To Copy The Hauler Name "
        End If
    End Sub

    Private Sub SeeIfDouble(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.OriginalText Is Nothing Then Me.OriginalText = ""

        If sender.text.trim = "" Or sender.Text.IndexOf("$") >= 0 Then
            Exit Sub

        End If

        If sender.Focused Then
            Try
                Dim StringArray As Array = sender.Text.ToCharArray
                Dim FoundDecimal As Boolean = False
                For Each c As Char In StringArray
                    If c = "." And FoundDecimal = True Then
                        sender.text = Me.OriginalText
                        sender.SelectionStart = Me.OriginalText.Length
                        Exit For
                    ElseIf c = "." Then
                        FoundDecimal = True
                    Else
                        If InStr("1234567890.", c) = 0 Then
                            sender.text = Me.OriginalText
                            sender.SelectionStart = Me.OriginalText.Length
                            Exit For
                        End If
                    End If
                Next
                Dim D As Double = CType(sender.text, Double)
            Catch ex As Exception
                sender.text = Me.OriginalText
                sender.SelectionStart = Me.OriginalText.Length
            End Try
            Me.OriginalText = sender.text
        End If

    End Sub

    Private Sub CboGotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.DroppedDown = True

    End Sub

    Private Sub Account_NameComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Account_NameComboBox.TextChanged

        'Added by Matt Burkett to disable update when loading existing transaction
        If Me.SuspendUpdate = False Then

            If Me.Account_NameComboBox.Focused And Me.Account_NameComboBox.Text <> "" Then AccountSet = True
            If Me.Account_NameComboBox.Text.Trim = "" Then
                Me.pnlAccount.Text = "Sold To"
                Me.pnlAccount.ForeColor = Color.Blue
            End If

            Dim Row As IRS.IRS_ScaleDataSet.AccountRow = Me.IRS_ScaleDataSet.Account.FindByAccount_Name(Me.Account_NameComboBox.Text)
            Me.Accountrow = Row

            If Not Row Is Nothing Then
                If Row.IsShow_PriceNull Then Row.Show_Price = True
                Me.pnlPricing.Visible = Row.Show_Price
                Me.TransactionRow.Show_Pricing = Row.Show_Price
            Else
                Me.TransactionRow.Show_Pricing = False
                Me.Job_NameComboBox.SelectedIndex = -1
                Me.Description_Textbox.Text = ""
            End If

            Me.Job_NameComboBox.Enabled = Me.Account_NameComboBox.Text.Trim <> ""
            SetPriceForProduct()
            Me.SetAccountLabel()

        End If

    End Sub

    Private Sub Hauler_NameComboBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hauler_NameComboBox.GotFocus
        Me.lblStatus.Text = "Select Hauler Name"
        Me.LblStatus2.Text = ""
        sender.BackColor = My.Settings.Selected_Color
        sender.SelectAll()
    End Sub

    Private Sub Truck_IdComboBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Truck_IdComboBox.GotFocus
        Me.lblStatus.Text = "Select Vehicle Id"
        Me.LblStatus2.Text = ""
        sender.BackColor = My.Settings.Selected_Color
        sender.SelectAll()
    End Sub

    Private Sub Account_NameComboBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Account_NameComboBox.GotFocus
        SetAccountLabel()

        sender.BackColor = My.Settings.Selected_Color
        sender.SelectAll()

    End Sub

    Private Sub Job_NameComboBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Job_NameComboBox.GotFocus
        sender.BackColor = My.Settings.Selected_Color
        Me.lblStatus.Text = "Does " + Me.Account_NameComboBox.Text + " Have a Job # Or P.O.?"
        Me.LblStatus2.Text = ""
        sender.SelectAll()
    End Sub

    Private Sub Description_Combobox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblStatus.Text = "Would You Like To Describe This Part Of " + Me.Account_NameComboBox.Text + " Have a Job # Or P.O.?"
        sender.BackColor = My.Settings.Selected_Color
    End Sub


    Private Sub Hauler_NameComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hauler_NameComboBox.TextChanged
        If Me.SuspendUpdate = False Then GetDefaultAccount()
    End Sub

    Private Sub GetDefaultAccount()
        Me.Truck_IdComboBox.Enabled = Me.Hauler_NameComboBox.Text.Trim <> ""
        Dim Haulerrow As IRS_ScaleDataSet.HaulerRow = Me.IRS_ScaleDataSet.Hauler.FindByHauler_Name(Me.Hauler_NameComboBox.Text)
        If Not Haulerrow Is Nothing Then
            If Not Haulerrow.IsDefault_AccountNull Then
                If Haulerrow.Default_Account.Trim <> "" Then
                    Me.Account_NameComboBox.Text = Haulerrow.Default_Account
                    AccountSet = True
                End If

            End If

        End If
        If Me.Hauler_NameComboBox.Text.Trim = "" Then
            Me.pnlVehicle.Text = "Vehicle Information"
            Me.pnlVehicle.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub Product_NameComboBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product_NameComboBox.GotFocus
        Me.SetProductLabel()
        Me.LblStatus2.Text = ""
        sender.BackColor = My.Settings.Selected_Color
        sender.SelectAll()
    End Sub

    Private Sub Product_NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product_NameComboBox.SelectedIndexChanged
        If Me.Product_NameComboBox.Focused And Me.Product_NameComboBox.Text <> "" Then ProductSet = True

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetTare(False)
    End Sub

    Private Function SetTare(ByVal UseTare As Boolean, Optional ByVal Prompt As String = "Key In Tare Weight") As DialogResult
        Dim Dr As DialogResult = Windows.Forms.DialogResult.OK
        My.Forms.Manual_Weight.Label2.Text = Prompt
        My.Forms.Manual_Weight.Label1.Text = "Then Press Enter Or Click Ok "
        My.Forms.Manual_Weight.Text = "Enter Tare Weight"
        Me.ManualTare = True
        If UseTare Or Reprint Then
            If Me.TareTextBox.Text = "" Then Me.TareTextBox.Text = 0
            My.Forms.Manual_Weight.CurVal = CType(Me.TareTextBox.Text, Double)
        Else
            My.Forms.Manual_Weight.CurVal = My.Forms.MDIParent.Weight
        End If

        Dr = My.Forms.Manual_Weight.ShowDialog
        If Dr = Windows.Forms.DialogResult.OK Then
            Me.TareTextBox.Text = My.Forms.Manual_Weight.numManual_Weight.Value
        End If
        Me.UpdateGTN()
        Return Dr
    End Function


    Private Function SetGross() As DialogResult
        Dim Dr As DialogResult = Windows.Forms.DialogResult.OK
        If Reprint Then

            My.Forms.Manual_Weight.Label2.Text = "Key In Gross Weight"
            My.Forms.Manual_Weight.Label1.Text = "Then Press Enter Or Click Ok "
            My.Forms.Manual_Weight.Text = "Enter Gross Weight"

            If Me.GrossTextBox.Text = "" Then Me.GrossTextBox.Text = 0
            My.Forms.Manual_Weight.CurVal = CType(Me.GrossTextBox.Text, Double)

            Dr = My.Forms.Manual_Weight.ShowDialog
            If Dr = Windows.Forms.DialogResult.OK Then
                Me.GrossTextBox.Text = My.Forms.Manual_Weight.numManual_Weight.Value
            End If
        Else
            Dr = My.Forms.Manual_Weight.ShowDialog
            If Dr = Windows.Forms.DialogResult.OK Then
                My.Forms.MDIParent.LockWeight()
                Dim NewValue As Integer = My.Forms.Manual_Weight.numManual_Weight.Value

                My.Forms.MDIParent.Indicator.SimulateDataRecieved(NewValue, WeightIndicator.ScaleStatus.Ok)
            End If

        End If
        Me.UpdateGTN()
        Return Dr
    End Function




    Private Sub indicator_Weight_Change(ByVal Data As WeightIndicator.ScaleData, ByVal Simulate As Boolean) Handles indicator.Weight_Change
        If Me.Reprint = False Then Me.GrossTextBox.Text = My.Forms.MDIParent.Weight
    End Sub

    Private Sub UpdateWeight(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TareTextBox.TextChanged, GrossTextBox.TextChanged
        If Me.Reprint = False Then UpdateGTN()
    End Sub

    Private Sub GrossTextBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrossTextBox.VisibleChanged
        UpdateGTN()
    End Sub

    Private Sub ClearStatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Truck_IdComboBox.LostFocus, Job_NameComboBox.LostFocus
        Me.lblStatus.Text = ""
        sender.BackColor = Color.White

    End Sub

    Public Sub FormatPrice(ByVal sender As System.Object)
        If Me.OriginalText Is Nothing Then Me.OriginalText = ""
        If sender.Text.IndexOf("$") >= 0 Then Exit Sub
        'Me.SetTaxRate()
        If sender.text = "" Then
            sender.text = "$0.00"
        Else
            Try
                If sender.text.trim = "" Then sender.text = 0


                sender.text = Format$(CType(sender.text, Double), "$0.00")
            Catch ex As Exception
            End Try
        End If


    End Sub

    Private Sub Remove_Price_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Text = sender.Text.Trim("$")
    End Sub

    Private Sub Delivery_RateTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delivery_RateTextBox.GotFocus
        Me.OriginalText = sender.text
        If sender.text.trim <> "" Then
            Me.OriginalDeliveryCharge = sender.text
        Else
            Me.OriginalDeliveryCharge = 0
        End If
        sender.SelectAll()
        SetDeleveryLabel()
        Remove_Price_Format(sender, e)
        SetColorOfDeliveryRate()

    End Sub

    Private Sub grpPrice_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grpPrice.DragOver

    End Sub

    Private Sub grpPrice_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpPrice.EnabledChanged

        'Added by Matt Burkett - When no pricing was to be printed or viewed on screen these commands disabled the ability to re-print the ticket.
        'I remarked out these commands so the user could still print the ticket or receipt.

        'Me.Print_Ticket_Button.Visible = Me.grpPrice.Enabled
        'Me.Print_Receipt_Button.Visible = Me.grpPrice.Enabled

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpPrice.Enter

    End Sub

    Private Sub Delivery_Flat_RateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_Flat_RateCheckBox.CheckedChanged

        'Added by Matt Burkett to disable update when loading existing transaction
        If Me.SuspendUpdate = False Then

            Me.pnlDelivery_Rate_By_Quantity.Visible = Not Me.Delivery_Flat_RateCheckBox.Checked And Me.grpQuantity.Enabled
            Me.UpdatePrice()
            Me.SetFlatRateCheckBoxStatus()

        End If

    End Sub

    Private Sub Delivery_RateTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_RateTextBox.Enter
    End Sub

    Private Sub SetDeleveryLabel()
        If Me.Delivery_Flat_RateCheckBox.Checked Then
            Me.lblStatus.Text = "Delivery By Flat Rate"
            Me.LblStatus2.Text = "Press [ F ] To Change To Regular Rate"
        Else
            Me.lblStatus.Text = "Delivery By Regular Rate"
            Me.LblStatus2.Text = "Press [ F ] To Change To Regular Rate"
        End If
    End Sub

    Private Sub QuantityTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuantityTextBox.GotFocus
        If Me.QuantityTextBox.Enabled Then
            Me.OriginalText = sender.text
            Me.lblStatus.Text = "Change The Quantity"
            sender.BackColor = My.Settings.Selected_Color
            sender.SelectAll()
        End If
    End Sub

    Private Sub QuantityTextBox_ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuantityTextBox.ReadOnlyChanged
        Me.QuantityTextBox.TabStop = Not Me.QuantityTextBox.ReadOnly
    End Sub

    Private Sub QuantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityTextBox.TextChanged

        SeeIfDouble(sender, e)
        Me.Delivery_Rate_Quantity_Textbox.Text = Me.QuantityTextBox.Text

    End Sub

    Private Sub Delivery_Rate_Quantity_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_Rate_Quantity_Textbox.TextChanged

        If Me.SuspendUpdate = False Then

            UpdateDeliveryTotalPrice()

        End If

    End Sub

    Private Sub UpdateDeliveryTotalPrice()
        Dim Quantity, Rate As Double
        If Me.Delivery_Rate_Quantity_Textbox.Text.Trim <> "" Then
            Try
                Quantity = CType(Me.Delivery_Rate_Quantity_Textbox.Text, Double)
            Catch ex As Exception

            End Try

        End If
        If Me.Delivery_RateTextBox.Text.Trim <> "" Then
            Try
                Rate = CType(Me.Delivery_RateTextBox.Text, Double)
            Catch ex As Exception

            End Try
        End If
        Me.Delivery_Rate_Total_Textbox.Text = Quantity * Rate
        Me.UpdatePrice()
    End Sub

    Private Sub Delivery_Rate_Total_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_Rate_Total_Textbox.TextChanged
        Me.FormatPrice(sender)
    End Sub

    Private Sub Delivery_RateTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_RateTextBox.TextChanged

        'Added by Matt Burkett to disable update when loading existing transaction
        If Me.SuspendUpdate = False Then

            If Not sender.focused Then
                FormatPrice(sender)
            Else
                SeeIfDouble(sender, e)
            End If

            SetColorOfDeliveryRate()
            UpdateDeliveryTotalPrice()

        End If

    End Sub

    Private Sub SetColorOfDeliveryRate()
        Flash_Colors = True
        'If Me.Delivery_RateTextBox.Focused Then
        '    Me.Delivery_RateTextBox.BackColor = Color.Yellow
        '    Flash_Colors = False
        'Else
        '    Try
        '        If Delivery_RateTextBox.Text.Trim <> "" Then
        '            If CType(Me.Delivery_RateTextBox.Text, Double) <> 0 Then
        '                Me.Delivery_RateTextBox.BackColor = Color.White
        '                Flash_Colors = False
        '            Else
        '                Flash_Colors = True
        '                'Me.Delivery_RateTextBox.BackColor = Color.Pink

        '            End If
        '        Else
        '            Flash_Colors = True
        '            'Me.Delivery_RateTextBox.BackColor = Color.Pink

        '        End If


        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub UpdatePrice()

        If Me.grpPrice.Enabled Then


            If Me.Price_Per_UOMTextBox.Text = "" Or Me.QuantityTextBox.Text = "" Then
                Exit Sub
            End If
            Dim Tax As Double
            If Me.IRS_ScaleDataSet.Setup.Count > 0 Then
                Tax = Me.IRS_ScaleDataSet.Setup(0).Tax_Rate
            Else
                Tax = 0
            End If
            If Not Me.TaxableCheckBox.Checked Then Tax = 0
            Dim PricePerYard As Double
            Try
                PricePerYard = CType(Me.Price_Per_UOMTextBox.Text, Double)
            Catch ex As Exception
            End Try
            Dim Quantity As Double
            Try
                Quantity = CType(Me.QuantityTextBox.Text, Double)
            Catch ex As Exception
            End Try

            Dim ExtendedPrice As Double
            ExtendedPrice = PricePerYard * Quantity
            Me.Extended_Price_TextBox.Text = Format$(ExtendedPrice, "$0.00")
            ExtendedPrice = CType(Me.Extended_Price_TextBox.Text, Double)

            Dim TotalTax As Double = Tax * ExtendedPrice
            Me.TotalTax_Textbox.Text = Format(TotalTax, "$0.00")
            TotalTax = CType(Me.TotalTax_Textbox.Text, Double)

            Dim Subtotal As Double
            Subtotal = TotalTax + ExtendedPrice
            Me.Subtotal_Textbox.Text = Format$(Subtotal, "$0.00")


            Dim DeliveryPrice As Double
            If Me.Delivery_Flat_RateCheckBox.Checked Then
                Try
                    DeliveryPrice = CType(Me.Delivery_RateTextBox.Text, Double)
                Catch ex As Exception
                End Try
            Else
                Try
                    DeliveryPrice = CType(Me.Delivery_Rate_Total_Textbox.Text, Double)
                Catch ex As Exception
                End Try
            End If
            Me.DeliveryPrice_TextBox.Text = Format$(DeliveryPrice, "$0.00")

            Dim TotalPrice As Double
            TotalPrice = DeliveryPrice + Subtotal
            Me.TotalPrice_TextBox.Text = Format$(TotalPrice, "$0.00")
        Else
            Me.Price_Per_UOMTextBox.Text = "$0.00"
            Me.Extended_Price_TextBox.Text = "$0.00"
            Me.TotalTax_Textbox.Text = "$0.00"
            Me.Subtotal_Textbox.Text = "$0.00"
            Me.DeliveryPrice_TextBox.Text = "$0.00"
            Me.TotalPrice_TextBox.Text = "$0.00"
        End If


    End Sub

    Private Sub TaxableCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxableCheckBox.CheckedChanged
        If Me.TaxableCheckBox.Checked Then
            SetTaxRate()
        Else
            Me.Tax_RateLabel.Text = "No Tax"
            Me.UpdatePrice()

        End If
    End Sub

    Private Sub Account_NameComboBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Account_NameComboBox.TextUpdate

    End Sub

    Private Sub Price_Per_UOMTextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Price_Per_UOMTextBox.GotFocus
        If sender.enabled Then
            sender.SelectAll()

            If sender.text.trim <> "" Then
                Me.OriginalValue = sender.text
            Else
                Me.OriginalValue = 0
            End If

            Me.OriginalText = sender.text
            sender.BackColor = My.Settings.Selected_Color
            Me.SetPricePerUOMLabel()
            Remove_Price_Format(sender, e)
        End If
    End Sub

    Private Sub Price_Per_UOMTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Price_Per_UOMTextBox.TextChanged

        'Added by Matt Burkett to disable update when loading existing transaction
        If Me.SuspendUpdate = False Then

            If Not sender.focused Then
                FormatPrice(sender)
            Else
                SeeIfDouble(sender, e)
            End If
            UpdatePrice()

        End If

    End Sub

    Private Sub QuantityTextBox_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityTextBox.LostFocus
        If Me.QuantityTextBox.Text = "" Then Me.QuantityTextBox.Text = 0

        Dim D As Double = CType(Me.QuantityTextBox.Text, Double)
        Me.QuantityTextBox.Text = Format(D, "0.00")
        Me.lblStatus.Text = ""
        sender.BackColor = Color.White
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PricingChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryPrice_TextBox.TextChanged
        If Not sender.focused Then
            FormatPrice(sender)
        Else
            SeeIfDouble(sender, e)
        End If
        UpdatePrice()
    End Sub

    Private Sub FormatTotals(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalPrice_TextBox.TextChanged, Extended_Price_TextBox.TextChanged, Subtotal_Textbox.TextChanged, TotalTax_Textbox.TextChanged
        FormatPrice(sender)
    End Sub

    Private Sub grpQuantity_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpQuantity.EnabledChanged
        If Me.grpQuantity.Enabled = False Then
            Me.QuantityTextBox.Text = "0.00"
        End If
        Me.grpPrice.Enabled = Me.grpQuantity.Enabled

    End Sub

    Private Sub grpQuantity_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpQuantity.Enter

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
        'If Reprint Then My.Forms.Ticket_List.ShowDialog()
    End Sub

    Private Sub Hauler_NameComboBox_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hauler_NameComboBox.LostFocus
        Me.lblStatus.Text = ""
        Me.Hauler_NameComboBox.BackColor = Color.White
        If Me.Hauler_NameComboBox.SelectedIndex = -1 And Me.Hauler_NameComboBox.Text.Trim <> "" Then
            Me.pnlVehicle.Text = "Vehicle Information -Hauler Not In Database"
            Me.pnlVehicle.ForeColor = Color.Red
        Else
            Me.pnlVehicle.Text = "Vehicle Information"
            Me.pnlVehicle.ForeColor = Me.grpDelivery.ForeColor

        End If
    End Sub

    Private Sub Account_NameComboBox_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Account_NameComboBox.LostFocus
        sender.BackColor = Color.White
        If Me.Account_NameComboBox.SelectedIndex = -1 And Me.Account_NameComboBox.Text.Trim <> "" Then
            Me.pnlAccount.Text = "Sold To -Account Not In Database"
            Me.pnlAccount.ForeColor = Color.Red

        Else
            Me.pnlAccount.Text = "Sold To"
            Me.pnlAccount.ForeColor = Color.Blue
        End If

    End Sub

    Private Sub Product_NameComboBox_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product_NameComboBox.LostFocus
        Me.lblStatus.Text = ""
        sender.BackColor = Color.White
        Me.Product_NameComboBox.SelectedIndex = Me.Product_NameComboBox.FindStringExact(Me.Product_NameComboBox.Text)
        If Me.Product_NameComboBox.SelectedIndex = -1 Then Me.Product_NameComboBox.Text = ""
    End Sub

    Public Function Prompt_User(ByVal Prompt As String) As DialogResult
        With My.Forms.Warning_Box
            .Label1.Text = Prompt
        End With
        Return My.Forms.Warning_Box.ShowDialog
    End Function

    Private Sub Print_Ticket_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Ticket_Button.Click
        'Logger.Save("---------------------------")
        'Logger.Save("Print / Save Ticket Pressed For Truck ID " + Me.Truck_IdComboBox.Text)

        Print_Ticket(True, False)

    End Sub

    Private Function Print_Ticket(ByVal Print As Boolean, ByVal Receipt As Boolean) As DialogResult

        'Logger.Save(" ")
        'Logger.Save("Hold/Print Ticket entered @" + DateTime.Now.ToString)
        Dim PrintType As String = "Save Record"

        If Print Then PrintType = "Print Ticket"

        If Receipt Then PrintType = "Print Receipt"

        If Me.Hauler_NameComboBox.Text.Trim = "" Then
            Me.lblButtonPrompt.Text = "Hauler and Vehicle Must Be Set To " + PrintType
            Me.Hauler_NameComboBox.Focus()
            Return Windows.Forms.DialogResult.Cancel
            Exit Function
        ElseIf Me.Truck_IdComboBox.Text.Trim = "" Then
            Me.lblButtonPrompt.Text = "Vehicle Id Must Be Set To " + PrintType
            Me.Truck_IdComboBox.Focus()
            Return Windows.Forms.DialogResult.Cancel
            Exit Function
        ElseIf Me.Account_NameComboBox.Text.Trim = "" Then
            Me.lblButtonPrompt.Text = "Account Must Be Set To " + PrintType
            Me.Account_NameComboBox.Focus()
            Return Windows.Forms.DialogResult.Cancel
            Exit Function

        ElseIf Me.TareTextBox.Visible And (CType(Me.NetTextBox.Text, Double) <= 0 Or CType(Me.TareTextBox.Text, Double) <= 0) And Me.NewTicket Then
            If Me.SetTare(True, "Verify Tare Weight") = Windows.Forms.DialogResult.Cancel Then
                Return Windows.Forms.DialogResult.Cancel
                Exit Function
            End If

        End If

        If Me.QuantityTextBox.Text = "" Then Me.QuantityTextBox.Text = 0
        If CType(Me.QuantityTextBox.Text, Double) <= 0 And Me.NewTicket Then
            If Me.Prompt_User("Quantity Is Zero" + vbCrLf + "Are You Sure You Want To " + PrintType) = Windows.Forms.DialogResult.Cancel Then
                Return Windows.Forms.DialogResult.Cancel
                Exit Function
            End If

        End If
        Try
            'If Reprint = False Then
            If StoreSystemInfo(False) = Windows.Forms.DialogResult.Cancel Then
                Exit Function
                Return Windows.Forms.DialogResult.Cancel
            End If

            'Added by Matt Burkett 04/26/2018 to make sure a new ticket number is applied at saving.
            'With 2 or more stations adding tickets the system will try to save two identical tickets
            'if both were adding at the same time.

            'If this is a new ticket only, I check to make sure the number isn't taken.
            'Also if its a new ticket the ticket number must have advanced so we save it in the setup file.

            If Me.NewTicket = True Then

                Dim TicketNumber As New Ticket_Number
                TransactionRow.Ticket = TicketNumber.New_Ticket_Number
                My.Forms.MDIParent.Setup.SaveTicket(Me.TransactionRow.Ticket)

            End If


            'End If
            Me.Validate()

            If Not Me.Reprint Then Me.TransactionRow.Date_Out = Now

            Me.TransactionRow.Account_Name = Me.Account_NameComboBox.Text
            Me.TransactionRow.Hauler_Name = Me.Hauler_NameComboBox.Text
            Me.TransactionRow.Truck_Id = Me.Truck_IdComboBox.Text
            Me.TransactionRow.Driver_Name = Me.txtDriver.Text
            Dim JTbl As New IRS_ScaleDataSet.JobDataTable
            Me.JobTableAdapter.Fill(JTbl)
            Dim JobRow As IRS_ScaleDataSet.JobRow = JTbl.FindByAccount_NameJob_Name(Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
            If Not JobRow Is Nothing Then
                Me.TransactionRow.Job_Name = JobRow.Job_Name
                If Not JobRow.IsJob_NumberNull Then Me.TransactionRow.Job_Number = JobRow.Job_Number
                If Not JobRow.IsDescriptionNull Then Me.TransactionRow.Job_Description = JobRow.Description
                If Not JobRow.IsAddressNull Then Me.TransactionRow.Job_Address = JobRow.Address
                If Not JobRow.IsJob_KeyNull Then Me.TransactionRow.Job_Key = JobRow.Job_Key
            End If

            Me.TransactionRow.Product_Name = Me.Product_NameComboBox.Text
            Me.Job_ProductsTableAdapter.Fill(Me.IRS_ScaleDataSet.Job_Products)
            Dim JobProductRow As IRS_ScaleDataSet.Job_ProductsRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
            If Not JobProductRow Is Nothing Then
                If Not JobProductRow.IsProduct_NumberNull Then Me.TransactionRow.Product_Number = JobProductRow.Product_Number
            End If


            If Me.grpWeight.Visible Then
                TransactionRow.Scale_Used = True
                If Me.GrossTextBox.Text = "" Then Me.GrossTextBox.Text = 0
                If Me.TareTextBox.Text = "" Then Me.TareTextBox.Text = 0
                TransactionRow.Gross = CType(Me.GrossTextBox.Text, Integer)
                TransactionRow.Tare = CType(Me.TareTextBox.Text, Integer)
            Else
                TransactionRow.Scale_Used = False
                TransactionRow.Gross = 0
                TransactionRow.Tare = 0
            End If

            TransactionRow.Unit_Of_Measure = Me.Unit_Of_MeasureLabel1.Text

            If Me.QuantityTextBox.Text = "" Then Me.QuantityTextBox.Text = 0
            TransactionRow.Quantity = CType(Me.QuantityTextBox.Text, Double)

            If Me.Tons_Per_YardTextBox.Visible Then
                If Me.Tons_Per_YardTextBox.Text = "" Then Me.Tons_Per_YardTextBox.Text = 0
                TransactionRow.Yards_Conversion = CType(Me.Tons_Per_YardTextBox.Text, Double)
            Else
                TransactionRow.Yards_Conversion = 0
            End If

            If Me.Price_Per_UOMTextBox.Text = "" Then Me.Price_Per_UOMTextBox.Text = 0
            TransactionRow.Price_Per_UOM = CType(Me.Price_Per_UOMTextBox.Text, Double)

            If Me.TaxableCheckBox.Checked Then
                If Me.IRS_ScaleDataSet.Setup.Count > 0 Then
                    TransactionRow.Tax_Rate = Me.IRS_ScaleDataSet.Setup(0).Tax_Rate
                Else
                    TransactionRow.Tax_Rate = 0
                End If
            Else
                TransactionRow.Tax_Rate = 0
            End If

            Me.TransactionRow.Comment = Me.CommentTextBox.Text


            If Delivery_RateTextBox.Text = "" Then Delivery_RateTextBox.Text = 0
            TransactionRow.Delivery_Rate = CType(Delivery_RateTextBox.Text, Double)
            Me.TransactionRow.Delivery_Flat_Rate = Me.Delivery_Flat_RateCheckBox.Checked
            Me.TransactionRow.Taxable = Me.TaxableCheckBox.Checked
            Me.TransactionRow.Show_Pricing = Me.pnlPricing.Visible
            Dim HaulerRow As IRS_ScaleDataSet.HaulerRow = Me.IRS_ScaleDataSet.Hauler.FindByHauler_Name(Me.TransactionRow.Hauler_Name)

            Dim AccountRow As IRS_ScaleDataSet.AccountRow = Me.IRS_ScaleDataSet.Account.FindByAccount_Name(Me.TransactionRow.Account_Name)

            Dim ShowAccountPrice As Boolean = True
            Dim ShowHaulerPrice As Boolean = True
            If Not AccountRow Is Nothing Then
                If Not AccountRow.IsShow_Price_On_TicketNull Then
                    ShowAccountPrice = AccountRow.Show_Price_On_Ticket
                End If
            End If

            If Not HaulerRow Is Nothing Then
                If Not HaulerRow.IsShow_Price_On_TicketNull Then
                    ShowHaulerPrice = HaulerRow.Show_Price_On_Ticket
                End If
            End If


            Me.TransactionRow.Show_Price_On_Ticket = (ShowAccountPrice = True) And (ShowHaulerPrice = True)

            If Me.pnlPricing.Visible = False Then Me.TransactionRow.Show_Price_On_Ticket = False
            Me.TransactionRow.Void = False

            If Me.TransactionRow.IsAccount_NameNull Then Me.TransactionRow.Account_Name = ""
            If Me.TransactionRow.IsProduct_NameNull Then Me.TransactionRow.Product_Name = ""
            If Me.TransactionRow.IsJob_NameNull Then Me.TransactionRow.Job_Name = ""


            Me.TransactionsBindingSource.EndEdit()


            Me.TransactionsTableAdapter.Update(Me.IRS_ScaleDataSet.Transactions)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

            If Print Then

                Dim ticketRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If My.Forms.MDIParent.Setup.SetupItems.Ticket_Copies_Per_Page = 2 Then
                    ticketRpt.Load("Reports\Ticket_2_Part.rpt")
                ElseIf My.Forms.MDIParent.Setup.SetupItems.Ticket_Copies_Per_Page = 3 Then
                    ticketRpt.Load("Reports\Ticket_3_Part.rpt")
                Else
                    ticketRpt.Load("Reports\Ticket.rpt")
                End If

                Me.JobTotalsByAccount_ByDateTableAdapter.FillByJobProduct(Me.IRS_ScaleDataSet.JobTotalsByAccount_ByDate, Now, Now, Me.TransactionRow.Job_Name, Me.TransactionRow.Account_Name, Me.TransactionRow.Product_Name)
                Me.JobTotalsByAccountTableAdapter.FillByJobProduct(Me.IRS_ScaleDataSet.JobTotalsByAccount, Me.TransactionRow.Job_Name, Me.TransactionRow.Account_Name, Me.TransactionRow.Product_Name)
                Me.TransactionsTableAdapter.FillByTicket(Me.IRS_ScaleDataSet.Transactions, Me.TransactionRow.Ticket)
                Me.TransactionRow = Me.IRS_ScaleDataSet.Transactions(0)
                ticketRpt.SetDataSource(Me.IRS_ScaleDataSet)

                Me.SetupTableAdapter.Fill(Me.IRS_ScaleDataSet.Setup)

                If My.Forms.MDIParent.PrintToScreen Then
                    My.Forms.Ticket_Preview.CrystalReportViewer1.ReportSource = ticketRpt
                    My.Forms.Ticket_Preview.ShowDialog()
                Else
                    Try

                        If My.Forms.MDIParent.Setup.SetupItems.Ticket_Printer.Trim <> "" Then
                            ticketRpt.PrintOptions.PrinterName = My.Forms.MDIParent.Setup.SetupItems.Ticket_Printer
                            If My.Forms.MDIParent.Setup.SetupItems.Ticket_Paper <> "" Then
                                With My.Forms.MDIParent.Setup.SetupItems
                                    Dim ps As New Printing.PaperSource
                                    ps.SourceName = .Ticket_Paper
                                    ps.RawKind = 0
                                    'ps.Height = .Ticket_Height
                                    'ps.Width = .Ticket_Width
                                    Try
                                        ticketRpt.PrintOptions.CustomPaperSource = ps
                                    Catch ex As Exception

                                    End Try

                                    'ticketRpt.PrintOptions.CustomPaperSource.RawKind = 0
                                    'row.Ticket_Raw_Kind = 0
                                    'row.Ticket_Width = Ps.Width 'Width
                                End With
                            End If
                        End If

                        Try
                            ticketRpt.PrintOptions.PaperSize = GetPaperSize(My.Forms.MDIParent.Setup.SetupItems.Ticket_Printer).RawKind
                        Catch ex As Exception

                        End Try

                        ticketRpt.PrintToPrinter(My.Forms.MDIParent.Setup.SetupItems.Ticket_Copies, True, 0, 0)

                        'Dim PrintReportOptions As New CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions
                        ''ticketRpt.Report.PrintOptions.PrinterName = My.Forms.MDIParent.Setup.SetupItems.Ticket_Printer.ToString
                        'Dim PrintOutputController As New CrystalDecisions.ReportAppServer.Controllers.PrintOutputController
                        'Dim RptClientDoc As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument

                        'If My.Forms.MDIParent.Setup.SetupItems.Ticket_Printer.Trim <> "" Then

                        '    PrintReportOptions.PrinterName = My.Forms.MDIParent.Setup.SetupItems.Ticket_Printer.ToString

                        'End If

                        'Int32.TryParse(My.Forms.MDIParent.Setup.SetupItems.Ticket_Copies, PrintReportOptions.NumberOfCopies)
                        'PrintReportOptions.JobTitle = "Ticket"
                        'RptClientDoc = ticketRpt.ReportClientDocument
                        'RptClientDoc.PrintOutputController.PrintReport(PrintReportOptions)

                    Catch ex As Exception
                        MsgBox("Error Printing To Printer" + vbCrLf + ex.Message, MsgBoxStyle.OkOnly, "Printer Error")
                    End Try
                End If

                ticketRpt.Close()
                ticketRpt.Dispose()

            ElseIf Receipt Then

                Dim iCounter As Integer
                Try

                    PrinterSerialPort = New System.IO.Ports.SerialPort
                    PrinterSerialPort.PortName = My.Settings("ReceiptPrinterPort")
                    PrinterSerialPort.BaudRate = 9600
                    PrinterSerialPort.DataBits = 8
                    PrinterSerialPort.Parity = IO.Ports.Parity.None
                    PrinterSerialPort.StopBits = IO.Ports.StopBits.One

                    If Me.PrinterSerialPort.IsOpen Then

                        Me.PrinterSerialPort.Close()

                    End If

                    Me.PrinterSerialPort.Open()
                    For iCounter = 1 To 6
                        Me.PrinterSerialPort.WriteLine("")
                    Next
                    Me.PrinterSerialPort.WriteLine("TICKET  #: " + Me.TransactionRow.Ticket.ToString)
                    Me.PrinterSerialPort.WriteLine("TRUCK ID#: " + Mid(Me.TransactionRow.Truck_Id, 1, 22))
                    Me.PrinterSerialPort.WriteLine("CUSTOMER : " + Mid(Me.TransactionRow.Account_Name, 1, 22))
                    Me.PrinterSerialPort.WriteLine("PRODUCT  : " + Mid(Me.TransactionRow.Product_Name, 1, 22))
                    Me.PrinterSerialPort.WriteLine("JOB NAME : " + Mid(Me.TransactionRow.Job_Name, 1, 22))
                    Me.PrinterSerialPort.WriteLine(Me.TransactionRow.Date_Out)

                    Me.PrinterSerialPort.WriteLine("")
                    Me.PrinterSerialPort.WriteLine(Me.TransactionRow.Gross.ToString.PadLeft(8 - Len(Me.TransactionRow.Gross.ToString)) + " lb    GROSS")
                    Me.PrinterSerialPort.WriteLine(Me.TransactionRow.Tare.ToString.PadLeft(8 - Len(Me.TransactionRow.Tare.ToString)) + " lb    TARE")
                    Dim iNet As Int32 = Math.Abs(Me.TransactionRow.Gross - Me.TransactionRow.Tare)
                    Me.PrinterSerialPort.WriteLine(iNet.ToString.PadLeft(8 - Len(iNet.ToString)) + " lb    NET")
                    Me.PrinterSerialPort.WriteLine(Me.TransactionRow.Quantity.ToString.PadLeft(7 - Len(Me.TransactionRow.Quantity.ToString)) + " " + Me.TransactionRow.Unit_Of_Measure + "  NET")
                    Me.PrinterSerialPort.WriteLine(Chr(27) + "e1")
                    Me.PrinterSerialPort.Close()
                    Me.PrinterSerialPort.Dispose()

                Catch ex As Exception

                    MsgBox("Error Printing Receipt " + ex.Message)

                End Try

            End If
            My.Forms.MDIParent.UnlockWeight()
            My.Forms.MDIParent.SetToStraightWeigh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Function GetPaperSize(ByVal PrinterName As String) As System.Drawing.Printing.PaperSize
        Dim PaperName As String = ""
        Try
            PaperName = My.Forms.MDIParent.Setup.SetupItems.Ticket_Paper
        Catch ex As Exception


        End Try
        Dim selectedPaperSize As System.Drawing.Printing.PaperSize = New System.Drawing.Printing.PaperSize
        Dim myPrinterSettings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings()
        myPrinterSettings.PrinterName = PrinterName
        For Each myPaperSize As System.Drawing.Printing.PaperSize In myPrinterSettings.PaperSizes
            If myPaperSize.PaperName = PaperName Then
                selectedPaperSize = myPaperSize
            End If
        Next
        Return selectedPaperSize
    End Function


    Private Sub lblButtonPrompt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblButtonPrompt.TextChanged
        If Me.lblButtonPrompt.Text <> "" Then Me.tmrButtonLabelClear.Start()
    End Sub

    Private Sub tmrButtonLabelClear_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrButtonLabelClear.Tick
        Me.lblButtonPrompt.Text = ""
    End Sub

    Private Sub Same_As_Hauler_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Same_As_Hauler_Button.Click
        If Me.Hauler_NameComboBox.Text <> "" Then
            Me.Account_NameComboBox.Text = Me.Hauler_NameComboBox.Text
            Dim tbl As New IRS_ScaleDataSet.HaulerDataTable
            Me.HaulerTableAdapter.Fill(tbl)
            Dim row As IRS_ScaleDataSet.HaulerRow = tbl.FindByHauler_Name(Me.Hauler_NameComboBox.Text)
            If Not row Is Nothing Then row.Same_As_Sold_To = True

        End If

        Me.Account_NameComboBox.Focus()

    End Sub

    Private Sub CommentTextBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentTextBox.GotFocus
        sender.BackColor = My.Settings.Selected_Color
    End Sub

    Private Sub CommentTextBox_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentTextBox.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub Print_Ticket_Button_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles Print_Ticket_Button.GiveFeedback

    End Sub

    Private Sub Save_Vehicle_Button_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Vehicle_Button.GotFocus, Print_Ticket_Button.GotFocus, Cancel_Button.GotFocus, btnSaveTicket.GotFocus
        sender.BackColor = My.Settings.Selected_Color
    End Sub

    Private Sub Save_Vehicle_Button_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Vehicle_Button.LostFocus, Print_Ticket_Button.LostFocus, Cancel_Button.LostFocus, btnSaveTicket.LostFocus
        sender.BackColor = Me.BackColor
    End Sub

    Private Sub Delivery_Flat_RateCheckBox_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_Flat_RateCheckBox.GotFocus

        SetFlatRateCheckBoxStatus()

        Me.OriginalDeliverFlatCharge = Me.Delivery_Flat_RateCheckBox.Checked

    End Sub

    Private Sub SetFlatRateCheckBoxStatus()
        If Me.Delivery_Flat_RateCheckBox.Checked Then
            Me.lblStatus.Text = "Delivery By Flat Rate"
            Me.LblStatus2.Text = "Press the Space Bar Or Click The [ Flat Rate ] Check Box To Change To Regular Rate"
        Else
            Me.lblStatus.Text = "Delivery By Regular Rate"
            Me.LblStatus2.Text = "Press the Space Bar Or Click The [ Flat Rate ] Check Box To Change To Flat Rate"
        End If
    End Sub


    Private Sub GroupBox1_GotFocus_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.GotFocus
        Me.lblButtonPrompt.Text = ""
        Me.tmrButtonLabelClear.Stop()

    End Sub

    Private Sub Description_Textbox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Description_Textbox.GotFocus
        sender.BackColor = My.Settings.Selected_Color
        Me.lblStatus.Text = "Description Of Job"
        Me.LblStatus2.Text = ""
        sender.SelectAll()
    End Sub

    Private Sub Description_Textbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Description_Textbox.KeyDown
        Me.GetNext(sender, e)
    End Sub

    Private Sub Description_Textbox_lostfocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Description_Textbox.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub Description_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Description_Textbox.TextChanged

    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub lblStatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStatus.TextChanged
        If Me.lblStatus.Text.Trim = "" Then Me.LblStatus2.Text = ""
    End Sub

    Private Sub Delivery_RateTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Delivery_RateTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.F Then
            Me.Delivery_Flat_RateCheckBox.Checked = Not Me.Delivery_Flat_RateCheckBox.Checked
            SetDeleveryLabel()
            e.SuppressKeyPress = True
            Me.OriginalDeliverFlatCharge = Me.Delivery_Flat_RateCheckBox.Checked
        End If
    End Sub

    Private Sub Price_Per_UOMTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Price_Per_UOMTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.T Then
            Me.TaxableCheckBox.Checked = Not Me.TaxableCheckBox.Checked
            SetPricePerUOMLabel()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub SetPricePerUOMLabel()
        If Me.TaxableCheckBox.Checked Then
            Me.lblStatus.Text = "Change The " + Price_Per_UOMLabel.Text
            Me.LblStatus2.Text = "Press [ T ] To Remove Tax"
        Else
            Me.lblStatus.Text = "Change The " + Price_Per_UOMLabel.Text
            Me.LblStatus2.Text = "Press [ T ] To Include Tax"
        End If
    End Sub

    Private Sub LblStatus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatus2.Click

    End Sub

    Private Sub LblStatus2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblStatus2.TextChanged
        Me.LblStatus2.Visible = Me.LblStatus2.Text.Trim <> ""
    End Sub

    Private Sub SetTruckTareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Product_NameComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Product_NameComboBox.KeyDown
        If e.KeyCode = Keys.Return Then
            If Me.Product_NameComboBox.SelectedIndex <> -1 Then
                Me.SelectNextControl(sender, True, True, True, True)
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        UpdateTime()
    End Sub

    Public Sub UpdateTime()
        Me.TimeLabel.Text = Now.ToLongDateString + "        " + Now.ToLongTimeString
    End Sub

    Private Sub Save_Vehicle_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Vehicle_Button.Click

        'Logger.Save("---------------------------")
        'Logger.Save("Place on Hold Pressed For Truck ID " + Me.Truck_IdComboBox.Text)
        If Reprint = False Then
            If StoreSystemInfo(True) = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Else
            Me.Print_Ticket(False, False)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
        My.Forms.MDIParent.TrucksOnHold.TrucksTableAdapter.FillByOnHold(My.Forms.MDIParent.TrucksOnHold.IrS_ScaleDataSet.Trucks)
        My.Forms.MDIParent.UnlockWeight()
        My.Forms.MDIParent.SetToStraightWeigh()
    End Sub


    Private Function StoreSystemInfo(ByVal OnHold As Boolean) As DialogResult

        Dim dr As DialogResult = Windows.Forms.DialogResult.OK

        dr = StoreAccountInfo()

        If dr = Windows.Forms.DialogResult.OK Then

            StoreHaulerInfo()
            StoreJob()

            If Me.Product_NameComboBox.SelectedIndex <> -1 Then

                Dim row As IRS_ScaleDataSet.ProductRow
                row = CType(CType(Me.ProductBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.ProductRow)

            End If

            StoreTrucks(OnHold)
            'StoreAccountPricing()
            'StoreJobPricing()

        End If

        Return dr
    End Function


    Private Sub StoreHaulerInfo()
        If Me.Hauler_NameComboBox.SelectedIndex = -1 And Me.Hauler_NameComboBox.Text.Trim <> "" Then

            Dim Tbl As New IRS_ScaleDataSet.HaulerDataTable
            Me.HaulerTableAdapter.Fill(Tbl)
            Dim row As IRS_ScaleDataSet.HaulerRow = Tbl.FindByHauler_Name(Me.Hauler_NameComboBox.Text)
            If row Is Nothing Then
                row = Tbl.NewHaulerRow

                row.Hauler_Name = Me.Hauler_NameComboBox.Text
                row.Same_As_Sold_To = Me.Account_NameComboBox.Text.Trim = Me.Hauler_NameComboBox.Text.Trim
                Tbl.AddHaulerRow(row)
                Me.HaulerTableAdapter.Update(Tbl)

            End If



        End If
    End Sub


    Private Function StoreAccountInfo() As DialogResult

        Dim Dr As DialogResult = Windows.Forms.DialogResult.OK

        If Me.Account_NameComboBox.FindStringExact(Me.Account_NameComboBox.Text) = -1 And Me.Account_NameComboBox.Text.Trim <> "" Then
            Dim Account_Name As String = Me.Account_NameComboBox.Text
            Dim EditAccount As New Add_Edit_Account(Account_Name)
            EditAccount.lblPrompt.Text = "Verify New Account Information"
            EditAccount.StartPosition = FormStartPosition.CenterScreen
            Dr = EditAccount.ShowDialog()
        End If
        Return Dr
    End Function


    Public Sub StoreJob()
        If Me.Job_NameComboBox.Text.Trim <> "" And Me.Account_NameComboBox.Text.Trim <> "" Then
            Dim Row As IRS_ScaleDataSet.JobRow
            Dim Tbl As New IRS_ScaleDataSet.JobDataTable
            Me.JobTableAdapter.Fill(Tbl)
            Row = Tbl.FindByAccount_NameJob_Name(Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
            If Row Is Nothing Then
                Row = Tbl.NewJobRow
                Row.Account_Name = Me.Account_NameComboBox.Text
                Row.Job_Name = Me.Job_NameComboBox.Text
                If Me.Description_Textbox.Text.Trim <> "" Then Row.Description = Me.Description_Textbox.Text
                Tbl.AddJobRow(Row)
            Else
                Row.Job_Name = Me.Job_NameComboBox.Text
                If Me.Description_Textbox.Text.Trim <> "" Then Row.Description = Me.Description_Textbox.Text
            End If
            Me.JobTableAdapter.Update(Tbl)
        End If
    End Sub


    Public Sub StoreTrucks(ByVal OnHold As Boolean)

        'Logger.Save("StoreTrucks called @ " + DateTime.Now.ToString)

        If Reprint Then Exit Sub

        'Added comparison for Reprint.  Reprint = false means the ticket is either new or finalizing.  So go ahead and save truck info.
        'Don't save it otherwise.  I think editing tickets is throwing off truck information.
        If Me.Truck_IdComboBox.Text.Trim <> "" And Me.Hauler_NameComboBox.Text.Trim <> "" And Me.Reprint = False Then

            Dim Tbl As New IRS_ScaleDataSet.TrucksDataTable
            Me.TrucksTableAdapter.Fill(Tbl)

            Dim row As IRS.IRS_ScaleDataSet.TrucksRow = Tbl.FindByTruck_IdHauler_Name(Me.Truck_IdComboBox.Text, Me.Hauler_NameComboBox.Text)

            If row Is Nothing Then

                row = Tbl.NewTrucksRow
                row.Truck_Id = Me.Truck_IdComboBox.Text
                row.Hauler_Name = Me.Hauler_NameComboBox.Text
                If Me.Account_NameComboBox.Text.Trim <> "" Then row.Account_Name = Me.Account_NameComboBox.Text
                If Me.Job_NameComboBox.Text.Trim <> "" Then row.Job_Name = Me.Job_NameComboBox.Text
                If Me.Product_NameComboBox.Text.Trim <> "" Then row.Product_Name = Me.Product_NameComboBox.Text
                If Me.txtDriver.Text.Trim <> "" Then
                    row.Driver_Name = Me.txtDriver.Text
                Else
                    row.SetDriver_NameNull()
                End If

                If OnHold Then
                    If Me.CommentTextBox.Text <> "" Then row.Comment = Me.CommentTextBox.Text
                Else
                    row.SetCommentNull()
                End If
                row.On_Hold = OnHold
                row.Hold_Date = Now
                row.Tare_Weight = My.Forms.MDIParent.Weight
                Tbl.AddTrucksRow(row)
                'Logger.Save("Truck on hold = " + OnHold.ToString)
                'Logger.Save("Truck " + Me.Truck_IdComboBox.Text + " not found, added to db with weight = " + My.Forms.MDIParent.Weight.ToString + " @ " + DateTime.Now.ToString)

            Else

                row.Truck_Id = Me.Truck_IdComboBox.Text
                row.Hauler_Name = Me.Hauler_NameComboBox.Text
                If Me.Account_NameComboBox.Text.Trim <> "" Then row.Account_Name = Me.Account_NameComboBox.Text
                If Me.Job_NameComboBox.Text.Trim <> "" Then
                    row.Job_Name = Me.Job_NameComboBox.Text
                Else
                    row.Job_Name = ""
                End If
                If Me.Product_NameComboBox.Text.Trim <> "" Then row.Product_Name = Me.Product_NameComboBox.Text

                If Me.txtDriver.Text.Trim <> "" Then
                    row.Driver_Name = Me.txtDriver.Text
                Else
                    row.SetDriver_NameNull()
                End If

                If OnHold Then
                    If Me.CommentTextBox.Text <> "" Then row.Comment = Me.CommentTextBox.Text
                Else
                    row.SetCommentNull()
                End If
                row.On_Hold = OnHold
                row.Hold_Date = Now
            End If

            'Logger.Save("Truck " + Me.Truck_IdComboBox.Text + " Found and On Hold = " + OnHold.ToString + " Manual Tare = " + Me.ManualTare.ToString)
            'Logger.Save("** Existing Tare Weight = " + row.Tare_Weight.ToString)
            If Me.ManualTare Or OnHold = False Then
                If Me.TareTextBox.Text.Trim <> "" Then row.Tare_Weight = Me.TareTextBox.Text
                'Logger.Save("Manual Tare is True or OnHold = False therefore Tare Weight equeals textbox value of " + Me.TareTextBox.Text)
            Else
                ' Added by Matt Burkett 05/19/2016  Only change trucks tare wt if scale wt is greater than 1000lbs
                If OnHold And My.Forms.MDIParent.Weight > 1000 Then
                    row.Tare_Weight = My.Forms.MDIParent.Weight
                    'Logger.Save("** Scale Weight is over 1000lbs and OnHold = True so new Tare Weight = " + My.Forms.MDIParent.Weight.ToString)
                    'Else
                    'Logger.Save("Scale Weight under 1000lbs or OnHold = False so Tare Weight not set.  It = " + row.Tare_Weight.ToString)
                End If
            End If

            'Logger.Save("Tare Weight = " + row.Tare_Weight.ToString + " Update occurred @ " + DateTime.Now.ToString)

            Me.TrucksTableAdapter.Update(Tbl)

        End If
    End Sub


    Private Sub GetPricing()

        'see if there is pricing for the job
        Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow
        If Me.Account_NameComboBox.Text.Trim = "" Or Me.Job_NameComboBox.Text.Trim = "" Then
            JobProductRow = Nothing
        Else
            Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
            JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
        End If

        Dim AccountProductRow As IRS.IRS_ScaleDataSet.AccountProductsRow
        If Me.Account_NameComboBox.Text.Trim = "" Then
            AccountProductRow = Nothing
        Else
            Me.AccountProductsTableAdapter.FillByAccount(Me.IRS_ScaleDataSet.AccountProducts, Me.Account_NameComboBox.Text)
            AccountProductRow = Me.IRS_ScaleDataSet.AccountProducts.FindByProduct_NameAccount_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text)
        End If

        If Not JobProductRow Is Nothing Then ' If there is a Product price for the job

            If Not JobProductRow.IsDelivery_RateNull Then
                Me.Delivery_RateTextBox.Text = JobProductRow.Delivery_Rate
                If JobProductRow.IsFlat_RateNull Then JobProductRow.Flat_Rate = False
                Me.Delivery_Flat_RateCheckBox.Checked = JobProductRow.Flat_Rate
            Else
                Me.Delivery_Rate_Quantity_Textbox.Text = "0.00"
            End If

            If Not JobProductRow.IsPriceNull Then
                Me.Price_Per_UOMTextBox.Text = JobProductRow.Price
            End If

        ElseIf Not AccountProductRow Is Nothing Then ' If not is there a Product price for the account

            'no Pricing For the Job So Check The Account
            If Not AccountProductRow.IsDelivery_RateNull Then

                Me.Delivery_RateTextBox.Text = AccountProductRow.Delivery_Rate

                If AccountProductRow.IsFlat_RateNull Then
                    AccountProductRow.Flat_Rate = False
                Else
                    Me.Delivery_Flat_RateCheckBox.Checked = AccountProductRow.Flat_Rate
                End If

            Else

                Me.Delivery_RateTextBox.Text = "0.00"
                Me.Delivery_Flat_RateCheckBox.Checked = False

            End If

            If Not AccountProductRow.IsPriceNull Then

                Me.Price_Per_UOMTextBox.Text = AccountProductRow.Price

            End If

        Else    ' If no records set the values to 0.00

            Me.Delivery_RateTextBox.Text = "0.00"
            Me.Delivery_Flat_RateCheckBox.Checked = False

        End If

    End Sub

    'Not currently being used.  Saving in case I need it in the future.
    Private Sub StoreJobPricing()

        Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow
        If Me.Account_NameComboBox.Text.Trim = "" Or Me.Job_NameComboBox.Text = "" Or Me.Product_NameComboBox.Text.Trim = "" Then Exit Sub
        Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

        JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
        If Me.Job_NameComboBox.Text <> "" And Me.Product_NameComboBox.Text <> "" Then

            Me.SavePriceToJob = False
            If JobProductRow Is Nothing Then
                JobProductRow = Me.IRS_ScaleDataSet.Job_Products.NewJob_ProductsRow
                JobProductRow.Product_Name = Me.Product_NameComboBox.Text
                JobProductRow.Account_Name = Me.Account_NameComboBox.Text
                JobProductRow.Job_Name = Me.Job_NameComboBox.Text
                Me.IRS_ScaleDataSet.Job_Products.AddJob_ProductsRow(JobProductRow)
                Me.SavePriceToJob = True
            End If
            If Me.SavePriceToJob = True Then

                If Me.Price_Per_UOMTextBox.Text.Trim = "" Then Me.Price_Per_UOMTextBox.Text = 0
                If Me.Price_Per_UOMTextBox.Text > 0 Then
                    JobProductRow.Price = CType(Me.Price_Per_UOMTextBox.Text, Double)
                Else
                    JobProductRow.SetPriceNull()
                End If

            End If
            If Me.Delivery_RateTextBox.Text.Trim = "" Then Me.Delivery_RateTextBox.Text = 0
            If Me.Delivery_RateTextBox.Text > 0 Then
                JobProductRow.Delivery_Rate = CType(Me.Delivery_RateTextBox.Text, Double)
            Else
                JobProductRow.SetDelivery_RateNull()
            End If

            JobProductRow.Flat_Rate = Me.Delivery_Flat_RateCheckBox.Checked

            ' Addeed by Matt Burkett on 7/25/16 to prevent price changes or delivery charge changes on existing products.
            If Me.SavePriceToJob = True Then
                Me.Job_ProductsTableAdapter.Update(Me.IRS_ScaleDataSet.Job_Products)
            End If

        End If
    End Sub




    'Not being used.  Keeping just in case I need it in the future.
    Private Sub StoreAccountPricing()

        Dim AccountProductRow As IRS.IRS_ScaleDataSet.AccountProductsRow
        Me.AccountProductsTableAdapter.FillByAccount(Me.IRS_ScaleDataSet.AccountProducts, Me.Account_NameComboBox.Text)
        AccountProductRow = Me.IRS_ScaleDataSet.AccountProducts.FindByProduct_NameAccount_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text)
        If Me.Account_NameComboBox.Text <> "" And Me.Product_NameComboBox.Text <> "" Then
            Dim Accountexists As Boolean = True
            If AccountProductRow Is Nothing Then
                Accountexists = False
                AccountProductRow = Me.IRS_ScaleDataSet.AccountProducts.NewAccountProductsRow
                AccountProductRow.Product_Name = Me.Product_NameComboBox.Text
                AccountProductRow.Account_Name = Me.Account_NameComboBox.Text
                Me.IRS_ScaleDataSet.AccountProducts.AddAccountProductsRow(AccountProductRow)
                Me.SavePriceToAccount = True
            End If
            If Me.SavePriceToAccount = True Or Accountexists = False Then
                If Me.Price_Per_UOMTextBox.Text.Trim = "" Then Me.Price_Per_UOMTextBox.Text = 0
                If Me.Price_Per_UOMTextBox.Text > 0 Then
                    AccountProductRow.Price = CType(Me.Price_Per_UOMTextBox.Text, Double)
                Else
                    AccountProductRow.SetPriceNull()
                End If
            End If
            'If it is a new account or No job exists then
            If Me.Job_NameComboBox.Text.Trim = "" Or Accountexists = False Then
                If Me.Delivery_RateTextBox.Text.Trim = "" Then Me.Delivery_RateTextBox.Text = 0
                If Me.Delivery_RateTextBox.Text > 0 Then
                    AccountProductRow.Delivery_Rate = CType(Me.Delivery_RateTextBox.Text, Double)
                Else
                    AccountProductRow.SetDelivery_RateNull()
                End If
                AccountProductRow.Flat_Rate = Me.Delivery_Flat_RateCheckBox.Checked
            End If
            Me.AccountProductsTableAdapter.Update(Me.IRS_ScaleDataSet.AccountProducts)
        End If
    End Sub



    Private Sub Price_Per_UOMTextBox_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Price_Per_UOMTextBox.LostFocus

        Dim Price As Double
        Price = CType(Me.Price_Per_UOMTextBox.Text, Double)

        If Me.Account_NameComboBox.Text = "" And Me.Job_NameComboBox.Text = "" Then Exit Sub

        If Price <> Me.OriginalValue Then

            Dim SavePrice As New Apply_Price_Change
            SavePrice.Job = Me.Job_NameComboBox.Text
            SavePrice.Account = Me.Account_NameComboBox.Text
            SavePrice.Price = Price

            Using PCGravelDataSet As New IRS_ScaleDataSet

                Dim SelectedProductTableAdapter As New IRS_ScaleDataSetTableAdapters.ProductTableAdapter
                Dim SelectedProductTable As New IRS_ScaleDataSet.ProductDataTable
                Dim SelectedProductRow As IRS.IRS_ScaleDataSet.ProductRow

                If SelectedProductTableAdapter.FillByProduct(SelectedProductTable, Me.Product_NameComboBox.Text) > 0 Then

                    SelectedProductRow = SelectedProductTable(0)
                    SavePrice.ProductPrice = SelectedProductRow.Price_Per_UOM

                End If

                Dim SelectedAcctProdTableAdapter As New IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter
                Dim SelectedAcctProdTable As New IRS_ScaleDataSet.AccountProductsDataTable
                Dim SelectedAcctProdRow As IRS.IRS_ScaleDataSet.AccountProductsRow

                If SelectedAcctProdTableAdapter.FillByAcct_Product(SelectedAcctProdTable, Me.Account_NameComboBox.Text, Me.Product_NameComboBox.Text) > 0 Then
                    SelectedAcctProdRow = SelectedAcctProdTable(0)
                    SavePrice.AccountPrice = SelectedAcctProdRow.Price
                Else
                    SavePrice.AccountPrice = 0
                End If

                Dim SelectedJobProdTableAdapter As New IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter
                Dim SelectedJobProdTable As New IRS_ScaleDataSet.Job_ProductsDataTable

                Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow

                Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                If JobProductRow Is Nothing Then

                    SavePrice.JobPrice = 0

                Else

                    SavePrice.JobPrice = JobProductRow.Price

                End If
            End Using

            If SavePrice.ShowDialog = Windows.Forms.DialogResult.OK Then

                If SavePrice.Response = Apply_Price_Change.RetVal.Account Then

                    SaveAccountPrice()

                ElseIf SavePrice.Response = Apply_Price_Change.RetVal.job Then

                    SaveJobPrice()

                End If

            Else

                Me.Price_Per_UOMTextBox.Text = OriginalValue

            End If

        End If
        sender.BackColor = Color.White
        Me.lblStatus.Text = ""
        FormatPrice(sender)

    End Sub

    Private Sub Delivery_Flat_RateCheckBox_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_Flat_RateCheckBox.LostFocus
        sender.BackColor = Me.BackColor
        Me.lblStatus.Text = ""

        Dim FlatRate As Boolean
        FlatRate = Me.Delivery_Flat_RateCheckBox.Checked

        If Me.Account_NameComboBox.Text = "" And Me.Job_NameComboBox.Text = "" Then Exit Sub

        If FlatRate <> Me.OriginalDeliverFlatCharge Then

            Dim SaveFlatRate As New Apply_Price_Change(False)
            SaveFlatRate.Job = Me.Job_NameComboBox.Text
            SaveFlatRate.Account = Me.Account_NameComboBox.Text

            If FlatRate = False Then
                SaveFlatRate.Price = 0
            Else
                SaveFlatRate.Price = 1
            End If

            Using PCGravelDataSet As New IRS_ScaleDataSet

                Dim SelectedProductTableAdapter As New IRS_ScaleDataSetTableAdapters.ProductTableAdapter
                Dim SelectedProductTable As New IRS_ScaleDataSet.ProductDataTable

                ' Matt Burkett Change on 12/18/18
                'There is no delivery Charge default by product so this is -1.
                SaveFlatRate.ProductPrice = -1

                Dim SelectedAcctProdTableAdapter As New IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter
                Dim SelectedAcctProdTable As New IRS_ScaleDataSet.AccountProductsDataTable
                Dim SelectedAcctProdRow As IRS.IRS_ScaleDataSet.AccountProductsRow

                If SelectedAcctProdTableAdapter.FillByAcct_Product(SelectedAcctProdTable, Me.Account_NameComboBox.Text, Me.Product_NameComboBox.Text) > 0 Then
                    SelectedAcctProdRow = SelectedAcctProdTable(0)
                    If SelectedAcctProdRow.Flat_Rate = True Then
                        SaveFlatRate.AccountPrice = 1
                    Else
                        SaveFlatRate.AccountPrice = 0
                    End If

                Else
                    SaveFlatRate.AccountPrice = -1
                End If

                Dim SelectedJobProdTableAdapter As New IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter
                Dim SelectedJobProdTable As New IRS_ScaleDataSet.Job_ProductsDataTable

                Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow

                Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                If JobProductRow Is Nothing Then

                    SaveFlatRate.JobPrice = -1

                Else

                    If JobProductRow.Flat_Rate = True Then
                        SaveFlatRate.JobPrice = 1
                    Else
                        SaveFlatRate.JobPrice = 0
                    End If

                End If

            End Using


            If SaveFlatRate.ShowDialog = Windows.Forms.DialogResult.OK Then

                If SaveFlatRate.Response = Apply_Price_Change.RetVal.Account Then

                    SaveAccountPrice()

                ElseIf SaveFlatRate.Response = Apply_Price_Change.RetVal.job Then

                    SaveJobPrice()

                End If

            Else

                Me.Price_Per_UOMTextBox.Text = OriginalValue

            End If

        End If

        sender.BackColor = Color.White
        Me.lblStatus.Text = ""
        FormatPrice(sender)


    End Sub

    Private Sub Delivery_RateTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delivery_RateTextBox.LostFocus

        sender.BackColor = Color.White
        Me.lblStatus.Text = ""
        FormatPrice(sender)
        'New Subroutine to allow the user to set the delivery charge default where they want it.
        SetColorOfDeliveryRate()

        Dim Price As Double
        Price = CType(Me.Delivery_RateTextBox.Text, Double)

        If Me.Account_NameComboBox.Text = "" And Me.Job_NameComboBox.Text = "" Then Exit Sub

        If Price <> Me.OriginalDeliveryCharge Then

            Dim SavePrice As New Apply_Price_Change(True) 'Sets the Apply_Price_Change form to Delivery Charge
            SavePrice.Job = Me.Job_NameComboBox.Text
            SavePrice.Account = Me.Account_NameComboBox.Text
            SavePrice.Price = Price

            Using PCGravelDataSet As New IRS_ScaleDataSet

                Dim SelectedProductTableAdapter As New IRS_ScaleDataSetTableAdapters.ProductTableAdapter
                Dim SelectedProductTable As New IRS_ScaleDataSet.ProductDataTable

                ' Matt Burkett Change on 12/18/18
                'There is no delivery Charge default by product so this is Zero.
                SavePrice.ProductPrice = 0

                Dim SelectedAcctProdTableAdapter As New IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter
                Dim SelectedAcctProdTable As New IRS_ScaleDataSet.AccountProductsDataTable
                Dim SelectedAcctProdRow As IRS.IRS_ScaleDataSet.AccountProductsRow

                If SelectedAcctProdTableAdapter.FillByAcct_Product(SelectedAcctProdTable, Me.Account_NameComboBox.Text, Me.Product_NameComboBox.Text) > 0 Then
                    SelectedAcctProdRow = SelectedAcctProdTable(0)
                    If SelectedAcctProdRow.IsDelivery_RateNull Then
                        SavePrice.AccountPrice = 0
                    Else
                        SavePrice.AccountPrice = SelectedAcctProdRow.Delivery_Rate
                    End If

                Else
                    SavePrice.AccountPrice = 0
                End If

                Dim SelectedJobProdTableAdapter As New IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter
                Dim SelectedJobProdTable As New IRS_ScaleDataSet.Job_ProductsDataTable

                Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow

                Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

                If JobProductRow Is Nothing Then

                    SavePrice.JobPrice = 0

                Else

                    SavePrice.JobPrice = JobProductRow.Delivery_Rate

                End If
            End Using

            If SavePrice.ShowDialog = Windows.Forms.DialogResult.OK Then

                If SavePrice.Response = Apply_Price_Change.RetVal.Account Then

                    SaveAccountPrice()

                ElseIf SavePrice.Response = Apply_Price_Change.RetVal.job Then

                    SaveJobPrice()

                End If

            Else

                Me.Price_Per_UOMTextBox.Text = OriginalValue

            End If

        End If
        sender.BackColor = Color.White
        Me.lblStatus.Text = ""
        FormatPrice(sender)

    End Sub

    Private Sub Item_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Item_NameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.backcolor = Color.Yellow

    End Sub

    Private Sub Item_NameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.backcolor = Color.White
    End Sub

    Private Sub Item_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Weigh_Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Mid(My.Settings("ReceiptPrinterPort"), 1, 3).ToUpper <> "COM" Then
            Print_Receipt_Button.Enabled = False
        Else
            Print_Receipt_Button.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetGrossBtn.Click
        SetGross()

    End Sub

    Private Sub Button2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.Account_NameComboBox.SelectedIndex < 0 Or Me.Job_NameComboBox.Text = "" Then Exit Sub
        If StoreAccountInfo() <> Windows.Forms.DialogResult.OK Then Exit Sub
        Try

            Dim JobRow As IRS_ScaleDataSet.JobRow = Me.IRS_ScaleDataSet.Job.FindByAccount_NameJob_Name(Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)
            If JobRow Is Nothing Then
                JobRow = Me.IRS_ScaleDataSet.Job.NewJobRow
                JobRow.Job_Name = Me.Job_NameComboBox.Text
                JobRow.Account_Name = Me.Account_NameComboBox.Text
                Me.IRS_ScaleDataSet.Job.AddJobRow(JobRow)
                Me.JobTableAdapter.Update(Me.IRS_ScaleDataSet.Job)
            End If

            Dim f As New Job_Details(Me.Account_NameComboBox.Text, JobRow.Job_Name)
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim CurJob As String = JobRow.Job_Name
                Me.JobTableAdapter.Fill(Me.IRS_ScaleDataSet.Job)
                Me.Job_ProductsTableAdapter.Fill(Me.IRS_ScaleDataSet.Job_Products)
                Me.Job_NameComboBox.Text = CurJob
                JobRow = Me.IRS_ScaleDataSet.Job.FindByAccount_NameJob_Name(Me.Account_NameComboBox.Text, CurJob)
                If Not JobRow Is Nothing Then
                    If JobRow.IsDescriptionNull Then
                        Me.Description_Textbox.Text = ""
                    Else
                        Me.Description_Textbox.Text = JobRow.Description
                    End If

                End If
            Else
                Me.Job_NameComboBox.Text = JobRow.Job_Name
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Truck_IdComboBox_TabStopChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Truck_IdComboBox.TabStopChanged

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tmrFlashRateColor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlashRateColor.Tick
        Try
            If My.Settings.FlashDeliveryRate = False Then Exit Sub
        Catch ex As Exception

        End Try
        If Me.Flash_Colors = True Then
            If Me.Delivery_RateTextBox.BackColor = Color.White Then
                Me.Delivery_RateTextBox.BackColor = Color.Lime
            Else
                Me.Delivery_RateTextBox.BackColor = Color.White
            End If
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnSaveTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTicket.Click
        'Logger.Save("---------------------------")
        'Logger.Save("Save Ticket Only Pressed For Truck ID " + Me.Truck_IdComboBox.Text)
        Print_Ticket(False, False)
    End Sub

    Private Sub Print_Ticket_Button_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Print_Ticket_Button.VisibleChanged
        Me.btnSaveTicket.Visible = Me.Print_Ticket_Button.Visible
    End Sub

    Private Sub pnlVehicle_Enter(sender As Object, e As EventArgs) Handles pnlVehicle.Enter

    End Sub

    Private Sub Print_Receipt_Button_Click(sender As Object, e As EventArgs) Handles Print_Receipt_Button.Click

        If Mid(My.Settings("ReceiptPrinterPort"), 1, 3).ToUpper = "COM" Then
            Print_Ticket(False, True)
        Else
            MsgBox("Receipt Printer not installed.")
        End If

    End Sub

    Private Sub SaveJobPrice()

        Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow

        Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

        JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

        If JobProductRow Is Nothing Then

            JobProductRow = Me.IRS_ScaleDataSet.Job_Products.NewJob_ProductsRow
            JobProductRow.Product_Name = Me.Product_NameComboBox.Text
            JobProductRow.Account_Name = Me.Account_NameComboBox.Text
            JobProductRow.Job_Name = Me.Job_NameComboBox.Text
            Me.IRS_ScaleDataSet.Job_Products.AddJob_ProductsRow(JobProductRow)

        End If

        If Me.Price_Per_UOMTextBox.Text.Trim = "" Then Me.Price_Per_UOMTextBox.Text = 0

        If Me.Price_Per_UOMTextBox.Text > 0 Then
            JobProductRow.Price = CType(Me.Price_Per_UOMTextBox.Text, Double)
        Else
            JobProductRow.SetPriceNull()
        End If

        If Me.Delivery_RateTextBox.Text.Trim = "" Then Me.Delivery_RateTextBox.Text = 0
        If Me.Delivery_RateTextBox.Text > 0 Then
            JobProductRow.Delivery_Rate = CType(Me.Delivery_RateTextBox.Text, Double)
        Else
            JobProductRow.SetDelivery_RateNull()
        End If

        JobProductRow.Flat_Rate = Me.Delivery_Flat_RateCheckBox.Checked
        Me.Job_ProductsTableAdapter.Update(Me.IRS_ScaleDataSet.Job_Products)

    End Sub

    Private Sub Account_NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Account_NameComboBox.SelectedIndexChanged

    End Sub

    Private Sub SaveAccountPrice()

        Dim AccountProductRow As IRS.IRS_ScaleDataSet.AccountProductsRow
        Me.AccountProductsTableAdapter.FillByAccount(Me.IRS_ScaleDataSet.AccountProducts, Me.Account_NameComboBox.Text)
        AccountProductRow = Me.IRS_ScaleDataSet.AccountProducts.FindByProduct_NameAccount_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text)

        If AccountProductRow Is Nothing Then

            AccountProductRow = Me.IRS_ScaleDataSet.AccountProducts.NewAccountProductsRow
            AccountProductRow.Product_Name = Me.Product_NameComboBox.Text
            AccountProductRow.Account_Name = Me.Account_NameComboBox.Text
            Me.IRS_ScaleDataSet.AccountProducts.AddAccountProductsRow(AccountProductRow)

        End If

        If Me.Price_Per_UOMTextBox.Text.Trim = "" Then Me.Price_Per_UOMTextBox.Text = 0

        If Me.Price_Per_UOMTextBox.Text > 0 Then
            AccountProductRow.Price = CType(Me.Price_Per_UOMTextBox.Text, Double)
        Else
            AccountProductRow.SetPriceNull()
        End If

        If Me.Delivery_RateTextBox.Text.Trim = "" Then Me.Delivery_RateTextBox.Text = 0
        If Me.Delivery_RateTextBox.Text > 0 Then
            AccountProductRow.Delivery_Rate = CType(Me.Delivery_RateTextBox.Text, Double)
        Else
            AccountProductRow.SetDelivery_RateNull()
        End If
        AccountProductRow.Flat_Rate = Me.Delivery_Flat_RateCheckBox.Checked

        Me.AccountProductsTableAdapter.Update(Me.IRS_ScaleDataSet.AccountProducts)

        ' Now find out if there this job exists in the JobProducts table and remove it if it does...
        Dim JobProductRow As IRS.IRS_ScaleDataSet.Job_ProductsRow

        Me.Job_ProductsTableAdapter.FillByAccount__Job(Me.IRS_ScaleDataSet.Job_Products, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

        JobProductRow = Me.IRS_ScaleDataSet.Job_Products.FindByProduct_NameAccount_NameJob_Name(Me.Product_NameComboBox.Text, Me.Account_NameComboBox.Text, Me.Job_NameComboBox.Text)

        If JobProductRow IsNot Nothing Then  'If you find a Job Pricing entry delete it because it will override the account price.  Matt Burkett

            JobProductRow.Delete()

            Me.Job_ProductsTableAdapter.Update(Me.IRS_ScaleDataSet.Job_Products)

        End If

    End Sub

End Class