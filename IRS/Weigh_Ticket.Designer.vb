<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weigh_Ticket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Hauler_NameLabel As System.Windows.Forms.Label
        Dim Truck_IdLabel As System.Windows.Forms.Label
        Dim DescriptionLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim GrossLabel As System.Windows.Forms.Label
        Dim TareLabel As System.Windows.Forms.Label
        Dim NetLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Tons_Per_YardLabel As System.Windows.Forms.Label
        Dim TicketLabel1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Delivery_RateLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Me.Tax_RateLabel = New System.Windows.Forms.Label()
        Me.Price_Per_UOMLabel = New System.Windows.Forms.Label()
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter()
        Me.HaulerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HaulerTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter()
        Me.Truck_IdComboBox = New System.Windows.Forms.ComboBox()
        Me.FKTrucksHaulerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrucksTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter()
        Me.Job_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.FKJobAccount1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.JobTableAdapter()
        Me.Account_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Product_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.grpWeight = New System.Windows.Forms.GroupBox()
        Me.SetGrossBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlTonsPerYard = New System.Windows.Forms.Panel()
        Me.Tons_Per_YardTextBox = New System.Windows.Forms.TextBox()
        Me.NetTonsTextBox = New System.Windows.Forms.TextBox()
        Me.NetTextBox = New System.Windows.Forms.TextBox()
        Me.TareTextBox = New System.Windows.Forms.TextBox()
        Me.GrossTextBox = New System.Windows.Forms.TextBox()
        Me.grpQuantity = New System.Windows.Forms.GroupBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Of_MeasureLabel1 = New System.Windows.Forms.Label()
        Me.pnlVehicle = New System.Windows.Forms.GroupBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.Driver_Label = New System.Windows.Forms.Label()
        Me.Hauler_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.pnlAccount = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Description_Textbox = New System.Windows.Forms.TextBox()
        Me.Same_As_Hauler_Button = New System.Windows.Forms.Button()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.FKTrucksHaulerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketTextBox = New System.Windows.Forms.TextBox()
        Me.Price_Per_UOMTextBox = New System.Windows.Forms.TextBox()
        Me.grpPrice = New System.Windows.Forms.GroupBox()
        Me.Extended_Price_TextBox = New System.Windows.Forms.TextBox()
        Me.TaxableCheckBox = New System.Windows.Forms.CheckBox()
        Me.TotalPrice_TextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryPrice_TextBox = New System.Windows.Forms.TextBox()
        Me.Subtotal_Textbox = New System.Windows.Forms.TextBox()
        Me.TotalTax_Textbox = New System.Windows.Forms.TextBox()
        Me.SetupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SetupTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.pnlDelivery_Rate_By_Quantity = New System.Windows.Forms.Panel()
        Me.Delivery_Rate_Total_Textbox = New System.Windows.Forms.TextBox()
        Me.Delivery_Rate_Quantity_Textbox = New System.Windows.Forms.TextBox()
        Me.Delivery_Flat_RateCheckBox = New System.Windows.Forms.CheckBox()
        Me.Delivery_RateTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Print_Receipt_Button = New System.Windows.Forms.Button()
        Me.btnSaveTicket = New System.Windows.Forms.Button()
        Me.lblButtonPrompt = New System.Windows.Forms.Label()
        Me.Save_Vehicle_Button = New System.Windows.Forms.Button()
        Me.Print_Ticket_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.tmrButtonLabelClear = New System.Windows.Forms.Timer(Me.components)
        Me.LblStatus2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.AccountProductsTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter()
        Me.TicketTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TicketTableAdapter()
        Me.Job_ProductsTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter()
        Me.pnlPricing = New System.Windows.Forms.Panel()
        Me.JobTotalsByAccount_ByDateTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.JobTotalsByAccount_ByDateTableAdapter()
        Me.JobTotalsByAccountTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.JobTotalsByAccountTableAdapter()
        Me.tmrFlashRateColor = New System.Windows.Forms.Timer(Me.components)
        Hauler_NameLabel = New System.Windows.Forms.Label()
        Truck_IdLabel = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        GrossLabel = New System.Windows.Forms.Label()
        TareLabel = New System.Windows.Forms.Label()
        NetLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Tons_Per_YardLabel = New System.Windows.Forms.Label()
        TicketLabel1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Delivery_RateLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTrucksHaulerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKJobAccount1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWeight.SuspendLayout()
        Me.pnlTonsPerYard.SuspendLayout()
        Me.grpQuantity.SuspendLayout()
        Me.pnlVehicle.SuspendLayout()
        Me.pnlAccount.SuspendLayout()
        Me.grpProduct.SuspendLayout()
        CType(Me.FKTrucksHaulerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrice.SuspendLayout()
        CType(Me.SetupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDelivery.SuspendLayout()
        Me.pnlDelivery_Rate_By_Quantity.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlPricing.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hauler_NameLabel
        '
        Hauler_NameLabel.AutoSize = True
        Hauler_NameLabel.ForeColor = System.Drawing.Color.Black
        Hauler_NameLabel.Location = New System.Drawing.Point(51, 24)
        Hauler_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Hauler_NameLabel.Name = "Hauler_NameLabel"
        Hauler_NameLabel.Size = New System.Drawing.Size(77, 22)
        Hauler_NameLabel.TabIndex = 4
        Hauler_NameLabel.Text = "Hauler:"
        '
        'Truck_IdLabel
        '
        Truck_IdLabel.AutoSize = True
        Truck_IdLabel.ForeColor = System.Drawing.Color.Black
        Truck_IdLabel.Location = New System.Drawing.Point(43, 56)
        Truck_IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Truck_IdLabel.Name = "Truck_IdLabel"
        Truck_IdLabel.Size = New System.Drawing.Size(84, 22)
        Truck_IdLabel.TabIndex = 6
        Truck_IdLabel.Text = "Vehicle:"
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.ForeColor = System.Drawing.Color.Black
        DescriptionLabel1.Location = New System.Drawing.Point(4, 119)
        DescriptionLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescriptionLabel1.Name = "DescriptionLabel1"
        DescriptionLabel1.Size = New System.Drawing.Size(124, 22)
        DescriptionLabel1.TabIndex = 15
        DescriptionLabel1.Text = "Description:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(20, 57)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(94, 22)
        Label1.TabIndex = 19
        Label1.Text = "Account:"
        AddHandler Label1.Click, AddressOf Me.Label1_Click
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.ForeColor = System.Drawing.Color.Black
        Product_NameLabel.Location = New System.Drawing.Point(32, 30)
        Product_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(96, 22)
        Product_NameLabel.TabIndex = 24
        Product_NameLabel.Text = "Product :"
        '
        'CommentLabel
        '
        CommentLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(35, 594)
        CommentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(106, 22)
        CommentLabel.TabIndex = 28
        CommentLabel.Text = "Comment:"
        '
        'GrossLabel
        '
        GrossLabel.AutoSize = True
        GrossLabel.ForeColor = System.Drawing.Color.Black
        GrossLabel.Location = New System.Drawing.Point(79, 17)
        GrossLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GrossLabel.Name = "GrossLabel"
        GrossLabel.Size = New System.Drawing.Size(74, 22)
        GrossLabel.TabIndex = 0
        GrossLabel.Text = "Gross:"
        '
        'TareLabel
        '
        TareLabel.AutoSize = True
        TareLabel.ForeColor = System.Drawing.Color.Black
        TareLabel.Location = New System.Drawing.Point(90, 46)
        TareLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TareLabel.Name = "TareLabel"
        TareLabel.Size = New System.Drawing.Size(59, 22)
        TareLabel.TabIndex = 2
        TareLabel.Text = "Tare:"
        '
        'NetLabel
        '
        NetLabel.AutoSize = True
        NetLabel.ForeColor = System.Drawing.Color.Black
        NetLabel.Location = New System.Drawing.Point(103, 74)
        NetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NetLabel.Name = "NetLabel"
        NetLabel.Size = New System.Drawing.Size(47, 22)
        NetLabel.TabIndex = 4
        NetLabel.Text = "Net:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(277, 17)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 22)
        Label2.TabIndex = 6
        Label2.Text = "Lbs."
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(277, 46)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(50, 22)
        Label3.TabIndex = 7
        Label3.Text = "Lbs."
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(277, 74)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(50, 22)
        Label4.TabIndex = 8
        Label4.Text = "Lbs."
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = System.Drawing.Color.Black
        Label5.Location = New System.Drawing.Point(51, 104)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(99, 22)
        Label5.TabIndex = 9
        Label5.Text = "Net Tons:"
        '
        'Tons_Per_YardLabel
        '
        Tons_Per_YardLabel.AutoSize = True
        Tons_Per_YardLabel.ForeColor = System.Drawing.Color.Black
        Tons_Per_YardLabel.Location = New System.Drawing.Point(-1, 5)
        Tons_Per_YardLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tons_Per_YardLabel.Name = "Tons_Per_YardLabel"
        Tons_Per_YardLabel.Size = New System.Drawing.Size(149, 22)
        Tons_Per_YardLabel.TabIndex = 11
        Tons_Per_YardLabel.Text = "Tons Per Yard:"
        '
        'TicketLabel1
        '
        TicketLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        TicketLabel1.Location = New System.Drawing.Point(557, 49)
        TicketLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TicketLabel1.Name = "TicketLabel1"
        TicketLabel1.Size = New System.Drawing.Size(79, 22)
        TicketLabel1.TabIndex = 33
        TicketLabel1.Text = "Ticket:"
        '
        'Label6
        '
        Label6.ForeColor = System.Drawing.Color.Black
        Label6.Location = New System.Drawing.Point(14, 119)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(161, 22)
        Label6.TabIndex = 4
        Label6.Text = "Subtotal:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label6.Visible = False
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(97, 17)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(95, 22)
        Label7.TabIndex = 6
        Label7.Text = "Quantity:"
        '
        'Label8
        '
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(14, 121)
        Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(161, 22)
        Label8.TabIndex = 6
        Label8.Text = "Delivery:"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Label8.Click, AddressOf Me.Label8_Click
        '
        'Label9
        '
        Label9.ForeColor = System.Drawing.Color.Black
        Label9.Location = New System.Drawing.Point(14, 155)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(161, 22)
        Label9.TabIndex = 8
        Label9.Text = "Total Due:"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Label9.Click, AddressOf Me.Label9_Click
        '
        'Label14
        '
        Label14.ForeColor = System.Drawing.Color.Black
        Label14.Location = New System.Drawing.Point(14, 54)
        Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(161, 22)
        Label14.TabIndex = 13
        Label14.Text = "Subtotal:"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Label14.Click, AddressOf Me.Label14_Click
        '
        'Delivery_RateLabel
        '
        Delivery_RateLabel.AutoSize = True
        Delivery_RateLabel.ForeColor = System.Drawing.Color.Black
        Delivery_RateLabel.Location = New System.Drawing.Point(4, 51)
        Delivery_RateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Delivery_RateLabel.Name = "Delivery_RateLabel"
        Delivery_RateLabel.Size = New System.Drawing.Size(58, 22)
        Delivery_RateLabel.TabIndex = 0
        Delivery_RateLabel.Text = "Rate:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.ForeColor = System.Drawing.Color.Black
        Label10.Location = New System.Drawing.Point(22, 0)
        Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(95, 22)
        Label10.TabIndex = 8
        Label10.Text = "Quantity:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.ForeColor = System.Drawing.Color.Black
        Label11.Location = New System.Drawing.Point(156, 0)
        Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(63, 22)
        Label11.TabIndex = 10
        Label11.Text = "Total:"
        '
        'Label12
        '
        Label12.ForeColor = System.Drawing.Color.Black
        Label12.Location = New System.Drawing.Point(0, 24)
        Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(20, 20)
        Label12.TabIndex = 11
        Label12.Text = "X"
        '
        'Label13
        '
        Label13.ForeColor = System.Drawing.Color.Black
        Label13.Location = New System.Drawing.Point(122, 24)
        Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(20, 20)
        Label13.TabIndex = 12
        Label13.Text = "="
        '
        'Tax_RateLabel
        '
        Me.Tax_RateLabel.ForeColor = System.Drawing.Color.Black
        Me.Tax_RateLabel.Location = New System.Drawing.Point(14, 87)
        Me.Tax_RateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Tax_RateLabel.Name = "Tax_RateLabel"
        Me.Tax_RateLabel.Size = New System.Drawing.Size(161, 22)
        Me.Tax_RateLabel.TabIndex = 2
        Me.Tax_RateLabel.Text = "Tax Rate:"
        Me.Tax_RateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Price_Per_UOMLabel
        '
        Me.Price_Per_UOMLabel.ForeColor = System.Drawing.Color.Black
        Me.Price_Per_UOMLabel.Location = New System.Drawing.Point(14, 22)
        Me.Price_Per_UOMLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Price_Per_UOMLabel.Name = "Price_Per_UOMLabel"
        Me.Price_Per_UOMLabel.Size = New System.Drawing.Size(161, 22)
        Me.Price_Per_UOMLabel.TabIndex = 0
        Me.Price_Per_UOMLabel.Text = "Price Per Yards:"
        Me.Price_Per_UOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccountBindingSource
        '
        Me.AccountBindingSource.DataMember = "Account"
        Me.AccountBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'IRS_ScaleDataSet
        '
        Me.IRS_ScaleDataSet.DataSetName = "IRS_ScaleDataSet"
        Me.IRS_ScaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'HaulerBindingSource
        '
        Me.HaulerBindingSource.DataMember = "Hauler"
        Me.HaulerBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'HaulerTableAdapter
        '
        Me.HaulerTableAdapter.ClearBeforeFill = True
        '
        'Truck_IdComboBox
        '
        Me.Truck_IdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Truck_IdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Truck_IdComboBox.DataSource = Me.FKTrucksHaulerBindingSource
        Me.Truck_IdComboBox.DisplayMember = "Truck_Id"
        Me.Truck_IdComboBox.Enabled = False
        Me.Truck_IdComboBox.ForeColor = System.Drawing.Color.Black
        Me.Truck_IdComboBox.FormattingEnabled = True
        Me.Truck_IdComboBox.Location = New System.Drawing.Point(129, 53)
        Me.Truck_IdComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Truck_IdComboBox.MaxDropDownItems = 20
        Me.Truck_IdComboBox.Name = "Truck_IdComboBox"
        Me.Truck_IdComboBox.Size = New System.Drawing.Size(314, 30)
        Me.Truck_IdComboBox.TabIndex = 1
        Me.Truck_IdComboBox.ValueMember = "Truck_Id"
        '
        'FKTrucksHaulerBindingSource
        '
        Me.FKTrucksHaulerBindingSource.DataMember = "FK_Trucks_Hauler"
        Me.FKTrucksHaulerBindingSource.DataSource = Me.HaulerBindingSource
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'Job_NameComboBox
        '
        Me.Job_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Job_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Job_NameComboBox.DataSource = Me.FKJobAccount1BindingSource
        Me.Job_NameComboBox.DisplayMember = "Job_Name"
        Me.Job_NameComboBox.Enabled = False
        Me.Job_NameComboBox.ForeColor = System.Drawing.Color.Black
        Me.Job_NameComboBox.FormattingEnabled = True
        Me.Job_NameComboBox.Location = New System.Drawing.Point(129, 85)
        Me.Job_NameComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Job_NameComboBox.MaxDropDownItems = 20
        Me.Job_NameComboBox.Name = "Job_NameComboBox"
        Me.Job_NameComboBox.Size = New System.Drawing.Size(314, 30)
        Me.Job_NameComboBox.TabIndex = 5
        Me.Job_NameComboBox.ValueMember = "Job_Name"
        '
        'FKJobAccount1BindingSource
        '
        Me.FKJobAccount1BindingSource.DataMember = "FK_Job_Account1"
        Me.FKJobAccount1BindingSource.DataSource = Me.AccountBindingSource
        '
        'AccountTableAdapter
        '
        Me.AccountTableAdapter.ClearBeforeFill = True
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'Account_NameComboBox
        '
        Me.Account_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Account_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Account_NameComboBox.DataSource = Me.AccountBindingSource
        Me.Account_NameComboBox.DisplayMember = "Account_Name"
        Me.Account_NameComboBox.ForeColor = System.Drawing.Color.Black
        Me.Account_NameComboBox.FormattingEnabled = True
        Me.Account_NameComboBox.Location = New System.Drawing.Point(129, 52)
        Me.Account_NameComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Account_NameComboBox.MaxDropDownItems = 20
        Me.Account_NameComboBox.Name = "Account_NameComboBox"
        Me.Account_NameComboBox.Size = New System.Drawing.Size(314, 30)
        Me.Account_NameComboBox.TabIndex = 4
        Me.Account_NameComboBox.ValueMember = "Account_Name"
        '
        'Product_NameComboBox
        '
        Me.Product_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Product_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Product_NameComboBox.DataSource = Me.ProductBindingSource
        Me.Product_NameComboBox.DisplayMember = "Product_Name"
        Me.Product_NameComboBox.ForeColor = System.Drawing.Color.Black
        Me.Product_NameComboBox.FormattingEnabled = True
        Me.Product_NameComboBox.Location = New System.Drawing.Point(129, 24)
        Me.Product_NameComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Product_NameComboBox.Name = "Product_NameComboBox"
        Me.Product_NameComboBox.Size = New System.Drawing.Size(314, 30)
        Me.Product_NameComboBox.TabIndex = 7
        Me.Product_NameComboBox.ValueMember = "Product_Name"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TimeLabel.ForeColor = System.Drawing.Color.Black
        Me.TimeLabel.Location = New System.Drawing.Point(7, 49)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(440, 24)
        Me.TimeLabel.TabIndex = 26
        Me.TimeLabel.Text = "Time Label"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentTextBox.Location = New System.Drawing.Point(149, 593)
        Me.CommentTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(721, 29)
        Me.CommentTextBox.TabIndex = 16
        '
        'grpWeight
        '
        Me.grpWeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpWeight.Controls.Add(Me.SetGrossBtn)
        Me.grpWeight.Controls.Add(Me.Button1)
        Me.grpWeight.Controls.Add(Me.pnlTonsPerYard)
        Me.grpWeight.Controls.Add(Label5)
        Me.grpWeight.Controls.Add(Me.NetTonsTextBox)
        Me.grpWeight.Controls.Add(Label4)
        Me.grpWeight.Controls.Add(Label3)
        Me.grpWeight.Controls.Add(Label2)
        Me.grpWeight.Controls.Add(NetLabel)
        Me.grpWeight.Controls.Add(Me.NetTextBox)
        Me.grpWeight.Controls.Add(TareLabel)
        Me.grpWeight.Controls.Add(Me.TareTextBox)
        Me.grpWeight.Controls.Add(GrossLabel)
        Me.grpWeight.Controls.Add(Me.GrossTextBox)
        Me.grpWeight.ForeColor = System.Drawing.Color.Blue
        Me.grpWeight.Location = New System.Drawing.Point(4, 418)
        Me.grpWeight.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpWeight.Name = "grpWeight"
        Me.grpWeight.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpWeight.Size = New System.Drawing.Size(450, 170)
        Me.grpWeight.TabIndex = 3
        Me.grpWeight.TabStop = False
        Me.grpWeight.Text = "Weights"
        Me.grpWeight.Visible = False
        '
        'SetGrossBtn
        '
        Me.SetGrossBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SetGrossBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SetGrossBtn.ForeColor = System.Drawing.Color.Black
        Me.SetGrossBtn.Location = New System.Drawing.Point(333, 17)
        Me.SetGrossBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SetGrossBtn.Name = "SetGrossBtn"
        Me.SetGrossBtn.Size = New System.Drawing.Size(110, 35)
        Me.SetGrossBtn.TabIndex = 14
        Me.SetGrossBtn.TabStop = False
        Me.SetGrossBtn.Text = "Set &Gross"
        Me.SetGrossBtn.UseVisualStyleBackColor = False
        Me.SetGrossBtn.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(333, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Set &Tare"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlTonsPerYard
        '
        Me.pnlTonsPerYard.Controls.Add(Tons_Per_YardLabel)
        Me.pnlTonsPerYard.Controls.Add(Me.Tons_Per_YardTextBox)
        Me.pnlTonsPerYard.Location = New System.Drawing.Point(2, 130)
        Me.pnlTonsPerYard.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlTonsPerYard.Name = "pnlTonsPerYard"
        Me.pnlTonsPerYard.Size = New System.Drawing.Size(288, 30)
        Me.pnlTonsPerYard.TabIndex = 13
        '
        'Tons_Per_YardTextBox
        '
        Me.Tons_Per_YardTextBox.ForeColor = System.Drawing.Color.Black
        Me.Tons_Per_YardTextBox.Location = New System.Drawing.Point(153, 1)
        Me.Tons_Per_YardTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Tons_Per_YardTextBox.Name = "Tons_Per_YardTextBox"
        Me.Tons_Per_YardTextBox.ReadOnly = True
        Me.Tons_Per_YardTextBox.Size = New System.Drawing.Size(119, 29)
        Me.Tons_Per_YardTextBox.TabIndex = 12
        Me.Tons_Per_YardTextBox.TabStop = False
        Me.Tons_Per_YardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetTonsTextBox
        '
        Me.NetTonsTextBox.ForeColor = System.Drawing.Color.Black
        Me.NetTonsTextBox.Location = New System.Drawing.Point(155, 101)
        Me.NetTonsTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.NetTonsTextBox.Name = "NetTonsTextBox"
        Me.NetTonsTextBox.ReadOnly = True
        Me.NetTonsTextBox.Size = New System.Drawing.Size(119, 29)
        Me.NetTonsTextBox.TabIndex = 10
        Me.NetTonsTextBox.TabStop = False
        Me.NetTonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetTextBox
        '
        Me.NetTextBox.ForeColor = System.Drawing.Color.Black
        Me.NetTextBox.Location = New System.Drawing.Point(155, 71)
        Me.NetTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.NetTextBox.Name = "NetTextBox"
        Me.NetTextBox.ReadOnly = True
        Me.NetTextBox.Size = New System.Drawing.Size(119, 29)
        Me.NetTextBox.TabIndex = 5
        Me.NetTextBox.TabStop = False
        Me.NetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TareTextBox
        '
        Me.TareTextBox.ForeColor = System.Drawing.Color.Black
        Me.TareTextBox.Location = New System.Drawing.Point(155, 43)
        Me.TareTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TareTextBox.Name = "TareTextBox"
        Me.TareTextBox.ReadOnly = True
        Me.TareTextBox.Size = New System.Drawing.Size(119, 29)
        Me.TareTextBox.TabIndex = 3
        Me.TareTextBox.TabStop = False
        Me.TareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrossTextBox
        '
        Me.GrossTextBox.ForeColor = System.Drawing.Color.Black
        Me.GrossTextBox.Location = New System.Drawing.Point(155, 14)
        Me.GrossTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GrossTextBox.Name = "GrossTextBox"
        Me.GrossTextBox.ReadOnly = True
        Me.GrossTextBox.Size = New System.Drawing.Size(119, 29)
        Me.GrossTextBox.TabIndex = 1
        Me.GrossTextBox.TabStop = False
        Me.GrossTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpQuantity
        '
        Me.grpQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpQuantity.Controls.Add(Label7)
        Me.grpQuantity.Controls.Add(Me.QuantityTextBox)
        Me.grpQuantity.Controls.Add(Me.Unit_Of_MeasureLabel1)
        Me.grpQuantity.Enabled = False
        Me.grpQuantity.ForeColor = System.Drawing.Color.Blue
        Me.grpQuantity.Location = New System.Drawing.Point(460, 75)
        Me.grpQuantity.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpQuantity.Name = "grpQuantity"
        Me.grpQuantity.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpQuantity.Size = New System.Drawing.Size(442, 44)
        Me.grpQuantity.TabIndex = 3
        Me.grpQuantity.TabStop = False
        Me.grpQuantity.Text = "Quantity"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.ForeColor = System.Drawing.Color.Black
        Me.QuantityTextBox.Location = New System.Drawing.Point(199, 13)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.ReadOnly = True
        Me.QuantityTextBox.Size = New System.Drawing.Size(119, 29)
        Me.QuantityTextBox.TabIndex = 0
        Me.QuantityTextBox.Text = "0.00"
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Unit_Of_MeasureLabel1
        '
        Me.Unit_Of_MeasureLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Unit_Of_Measure", True))
        Me.Unit_Of_MeasureLabel1.Location = New System.Drawing.Point(323, 16)
        Me.Unit_Of_MeasureLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Unit_Of_MeasureLabel1.Name = "Unit_Of_MeasureLabel1"
        Me.Unit_Of_MeasureLabel1.Size = New System.Drawing.Size(110, 24)
        Me.Unit_Of_MeasureLabel1.TabIndex = 2
        '
        'pnlVehicle
        '
        Me.pnlVehicle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlVehicle.Controls.Add(Me.txtDriver)
        Me.pnlVehicle.Controls.Add(Me.Driver_Label)
        Me.pnlVehicle.Controls.Add(Me.Truck_IdComboBox)
        Me.pnlVehicle.Controls.Add(Me.Hauler_NameComboBox)
        Me.pnlVehicle.Controls.Add(Hauler_NameLabel)
        Me.pnlVehicle.Controls.Add(Truck_IdLabel)
        Me.pnlVehicle.ForeColor = System.Drawing.Color.Blue
        Me.pnlVehicle.Location = New System.Drawing.Point(4, 75)
        Me.pnlVehicle.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlVehicle.Name = "pnlVehicle"
        Me.pnlVehicle.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlVehicle.Size = New System.Drawing.Size(450, 119)
        Me.pnlVehicle.TabIndex = 0
        Me.pnlVehicle.TabStop = False
        Me.pnlVehicle.Text = "Vehicle Information"
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(129, 85)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(314, 29)
        Me.txtDriver.TabIndex = 2
        '
        'Driver_Label
        '
        Me.Driver_Label.AutoSize = True
        Me.Driver_Label.ForeColor = System.Drawing.Color.Black
        Me.Driver_Label.Location = New System.Drawing.Point(53, 91)
        Me.Driver_Label.Name = "Driver_Label"
        Me.Driver_Label.Size = New System.Drawing.Size(74, 22)
        Me.Driver_Label.TabIndex = 7
        Me.Driver_Label.Text = "Driver:"
        '
        'Hauler_NameComboBox
        '
        Me.Hauler_NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Hauler_NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Hauler_NameComboBox.DataSource = Me.HaulerBindingSource
        Me.Hauler_NameComboBox.DisplayMember = "Hauler_Name"
        Me.Hauler_NameComboBox.ForeColor = System.Drawing.Color.Black
        Me.Hauler_NameComboBox.FormattingEnabled = True
        Me.Hauler_NameComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Hauler_NameComboBox.Location = New System.Drawing.Point(129, 22)
        Me.Hauler_NameComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Hauler_NameComboBox.MaxDropDownItems = 20
        Me.Hauler_NameComboBox.Name = "Hauler_NameComboBox"
        Me.Hauler_NameComboBox.Size = New System.Drawing.Size(314, 30)
        Me.Hauler_NameComboBox.TabIndex = 0
        Me.Hauler_NameComboBox.ValueMember = "Hauler_Name"
        '
        'pnlAccount
        '
        Me.pnlAccount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAccount.Controls.Add(Me.Button2)
        Me.pnlAccount.Controls.Add(Me.Description_Textbox)
        Me.pnlAccount.Controls.Add(Me.Same_As_Hauler_Button)
        Me.pnlAccount.Controls.Add(Me.Job_NameComboBox)
        Me.pnlAccount.Controls.Add(DescriptionLabel1)
        Me.pnlAccount.Controls.Add(Me.Account_NameComboBox)
        Me.pnlAccount.Controls.Add(Label1)
        Me.pnlAccount.ForeColor = System.Drawing.Color.Blue
        Me.pnlAccount.Location = New System.Drawing.Point(5, 199)
        Me.pnlAccount.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pnlAccount.Size = New System.Drawing.Size(450, 156)
        Me.pnlAccount.TabIndex = 1
        Me.pnlAccount.TabStop = False
        Me.pnlAccount.Text = "Sold To"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(16, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 29)
        Me.Button2.TabIndex = 20
        Me.Button2.TabStop = False
        Me.Button2.Text = "Job / P.O."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Description_Textbox
        '
        Me.Description_Textbox.Enabled = False
        Me.Description_Textbox.Location = New System.Drawing.Point(128, 118)
        Me.Description_Textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.Description_Textbox.Name = "Description_Textbox"
        Me.Description_Textbox.Size = New System.Drawing.Size(314, 29)
        Me.Description_Textbox.TabIndex = 6
        '
        'Same_As_Hauler_Button
        '
        Me.Same_As_Hauler_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Same_As_Hauler_Button.ForeColor = System.Drawing.Color.Black
        Me.Same_As_Hauler_Button.Location = New System.Drawing.Point(128, 21)
        Me.Same_As_Hauler_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Same_As_Hauler_Button.Name = "Same_As_Hauler_Button"
        Me.Same_As_Hauler_Button.Size = New System.Drawing.Size(184, 30)
        Me.Same_As_Hauler_Button.TabIndex = 3
        Me.Same_As_Hauler_Button.TabStop = False
        Me.Same_As_Hauler_Button.Text = "Same As &Hauler"
        Me.Same_As_Hauler_Button.UseVisualStyleBackColor = False
        '
        'grpProduct
        '
        Me.grpProduct.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpProduct.Controls.Add(Me.Product_NameComboBox)
        Me.grpProduct.Controls.Add(Product_NameLabel)
        Me.grpProduct.ForeColor = System.Drawing.Color.Blue
        Me.grpProduct.Location = New System.Drawing.Point(4, 357)
        Me.grpProduct.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpProduct.Size = New System.Drawing.Size(450, 63)
        Me.grpProduct.TabIndex = 2
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "Product"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(948, 22)
        Me.lblStatus.TabIndex = 33
        Me.lblStatus.Text = "lblStatus"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FKTrucksHaulerBindingSource1
        '
        Me.FKTrucksHaulerBindingSource1.DataMember = "FK_Trucks_Hauler"
        Me.FKTrucksHaulerBindingSource1.DataSource = Me.HaulerBindingSource
        '
        'TicketTextBox
        '
        Me.TicketTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TicketTextBox.ForeColor = System.Drawing.Color.Black
        Me.TicketTextBox.Location = New System.Drawing.Point(640, 47)
        Me.TicketTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TicketTextBox.Name = "TicketTextBox"
        Me.TicketTextBox.ReadOnly = True
        Me.TicketTextBox.Size = New System.Drawing.Size(229, 29)
        Me.TicketTextBox.TabIndex = 34
        Me.TicketTextBox.TabStop = False
        Me.TicketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Price_Per_UOMTextBox
        '
        Me.Price_Per_UOMTextBox.Location = New System.Drawing.Point(181, 20)
        Me.Price_Per_UOMTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Price_Per_UOMTextBox.Name = "Price_Per_UOMTextBox"
        Me.Price_Per_UOMTextBox.Size = New System.Drawing.Size(119, 29)
        Me.Price_Per_UOMTextBox.TabIndex = 1
        Me.Price_Per_UOMTextBox.TabStop = False
        Me.Price_Per_UOMTextBox.Text = "$0.00"
        Me.Price_Per_UOMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpPrice
        '
        Me.grpPrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpPrice.Controls.Add(Label14)
        Me.grpPrice.Controls.Add(Me.Extended_Price_TextBox)
        Me.grpPrice.Controls.Add(Me.TaxableCheckBox)
        Me.grpPrice.Controls.Add(Label9)
        Me.grpPrice.Controls.Add(Me.TotalPrice_TextBox)
        Me.grpPrice.Controls.Add(Label8)
        Me.grpPrice.Controls.Add(Me.DeliveryPrice_TextBox)
        Me.grpPrice.Controls.Add(Label6)
        Me.grpPrice.Controls.Add(Me.Subtotal_Textbox)
        Me.grpPrice.Controls.Add(Me.Tax_RateLabel)
        Me.grpPrice.Controls.Add(Me.TotalTax_Textbox)
        Me.grpPrice.Controls.Add(Me.Price_Per_UOMLabel)
        Me.grpPrice.Controls.Add(Me.Price_Per_UOMTextBox)
        Me.grpPrice.ForeColor = System.Drawing.Color.Blue
        Me.grpPrice.Location = New System.Drawing.Point(7, 85)
        Me.grpPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.grpPrice.Name = "grpPrice"
        Me.grpPrice.Padding = New System.Windows.Forms.Padding(2)
        Me.grpPrice.Size = New System.Drawing.Size(420, 197)
        Me.grpPrice.TabIndex = 1
        Me.grpPrice.TabStop = False
        Me.grpPrice.Text = "Pricing"
        '
        'Extended_Price_TextBox
        '
        Me.Extended_Price_TextBox.Location = New System.Drawing.Point(181, 52)
        Me.Extended_Price_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Extended_Price_TextBox.Name = "Extended_Price_TextBox"
        Me.Extended_Price_TextBox.ReadOnly = True
        Me.Extended_Price_TextBox.Size = New System.Drawing.Size(119, 29)
        Me.Extended_Price_TextBox.TabIndex = 14
        Me.Extended_Price_TextBox.TabStop = False
        Me.Extended_Price_TextBox.Text = "$0.00"
        Me.Extended_Price_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TaxableCheckBox
        '
        Me.TaxableCheckBox.AutoSize = True
        Me.TaxableCheckBox.ForeColor = System.Drawing.Color.Black
        Me.TaxableCheckBox.Location = New System.Drawing.Point(304, 91)
        Me.TaxableCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TaxableCheckBox.Name = "TaxableCheckBox"
        Me.TaxableCheckBox.Size = New System.Drawing.Size(102, 26)
        Me.TaxableCheckBox.TabIndex = 10
        Me.TaxableCheckBox.Text = "Taxable"
        '
        'TotalPrice_TextBox
        '
        Me.TotalPrice_TextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TotalPrice_TextBox.ForeColor = System.Drawing.Color.Black
        Me.TotalPrice_TextBox.Location = New System.Drawing.Point(181, 155)
        Me.TotalPrice_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TotalPrice_TextBox.Name = "TotalPrice_TextBox"
        Me.TotalPrice_TextBox.ReadOnly = True
        Me.TotalPrice_TextBox.Size = New System.Drawing.Size(119, 29)
        Me.TotalPrice_TextBox.TabIndex = 9
        Me.TotalPrice_TextBox.TabStop = False
        Me.TotalPrice_TextBox.Text = "$0.00"
        Me.TotalPrice_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DeliveryPrice_TextBox
        '
        Me.DeliveryPrice_TextBox.Location = New System.Drawing.Point(181, 119)
        Me.DeliveryPrice_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DeliveryPrice_TextBox.Name = "DeliveryPrice_TextBox"
        Me.DeliveryPrice_TextBox.ReadOnly = True
        Me.DeliveryPrice_TextBox.Size = New System.Drawing.Size(119, 29)
        Me.DeliveryPrice_TextBox.TabIndex = 7
        Me.DeliveryPrice_TextBox.TabStop = False
        Me.DeliveryPrice_TextBox.Text = "$0.00"
        Me.DeliveryPrice_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Subtotal_Textbox
        '
        Me.Subtotal_Textbox.Location = New System.Drawing.Point(181, 118)
        Me.Subtotal_Textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.Subtotal_Textbox.Name = "Subtotal_Textbox"
        Me.Subtotal_Textbox.ReadOnly = True
        Me.Subtotal_Textbox.Size = New System.Drawing.Size(119, 29)
        Me.Subtotal_Textbox.TabIndex = 5
        Me.Subtotal_Textbox.TabStop = False
        Me.Subtotal_Textbox.Text = "$0.00"
        Me.Subtotal_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Subtotal_Textbox.Visible = False
        '
        'TotalTax_Textbox
        '
        Me.TotalTax_Textbox.Location = New System.Drawing.Point(181, 84)
        Me.TotalTax_Textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.TotalTax_Textbox.Name = "TotalTax_Textbox"
        Me.TotalTax_Textbox.ReadOnly = True
        Me.TotalTax_Textbox.Size = New System.Drawing.Size(119, 29)
        Me.TotalTax_Textbox.TabIndex = 3
        Me.TotalTax_Textbox.TabStop = False
        Me.TotalTax_Textbox.Text = "$0.00"
        Me.TotalTax_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SetupBindingSource
        '
        Me.SetupBindingSource.DataMember = "Setup"
        Me.SetupBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'SetupTableAdapter
        '
        Me.SetupTableAdapter.ClearBeforeFill = True
        '
        'grpDelivery
        '
        Me.grpDelivery.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpDelivery.Controls.Add(Me.pnlDelivery_Rate_By_Quantity)
        Me.grpDelivery.Controls.Add(Me.Delivery_Flat_RateCheckBox)
        Me.grpDelivery.Controls.Add(Delivery_RateLabel)
        Me.grpDelivery.Controls.Add(Me.Delivery_RateTextBox)
        Me.grpDelivery.ForeColor = System.Drawing.Color.Blue
        Me.grpDelivery.Location = New System.Drawing.Point(6, 0)
        Me.grpDelivery.Margin = New System.Windows.Forms.Padding(2)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Padding = New System.Windows.Forms.Padding(2)
        Me.grpDelivery.Size = New System.Drawing.Size(420, 86)
        Me.grpDelivery.TabIndex = 0
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery Charge"
        '
        'pnlDelivery_Rate_By_Quantity
        '
        Me.pnlDelivery_Rate_By_Quantity.Controls.Add(Label13)
        Me.pnlDelivery_Rate_By_Quantity.Controls.Add(Label12)
        Me.pnlDelivery_Rate_By_Quantity.Controls.Add(Label11)
        Me.pnlDelivery_Rate_By_Quantity.Controls.Add(Me.Delivery_Rate_Total_Textbox)
        Me.pnlDelivery_Rate_By_Quantity.Controls.Add(Label10)
        Me.pnlDelivery_Rate_By_Quantity.Controls.Add(Me.Delivery_Rate_Quantity_Textbox)
        Me.pnlDelivery_Rate_By_Quantity.Location = New System.Drawing.Point(170, 27)
        Me.pnlDelivery_Rate_By_Quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDelivery_Rate_By_Quantity.Name = "pnlDelivery_Rate_By_Quantity"
        Me.pnlDelivery_Rate_By_Quantity.Size = New System.Drawing.Size(245, 54)
        Me.pnlDelivery_Rate_By_Quantity.TabIndex = 4
        '
        'Delivery_Rate_Total_Textbox
        '
        Me.Delivery_Rate_Total_Textbox.ForeColor = System.Drawing.Color.Black
        Me.Delivery_Rate_Total_Textbox.Location = New System.Drawing.Point(142, 23)
        Me.Delivery_Rate_Total_Textbox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Delivery_Rate_Total_Textbox.Name = "Delivery_Rate_Total_Textbox"
        Me.Delivery_Rate_Total_Textbox.ReadOnly = True
        Me.Delivery_Rate_Total_Textbox.Size = New System.Drawing.Size(100, 29)
        Me.Delivery_Rate_Total_Textbox.TabIndex = 9
        Me.Delivery_Rate_Total_Textbox.TabStop = False
        Me.Delivery_Rate_Total_Textbox.Text = "$0.00"
        Me.Delivery_Rate_Total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Delivery_Rate_Quantity_Textbox
        '
        Me.Delivery_Rate_Quantity_Textbox.ForeColor = System.Drawing.Color.Black
        Me.Delivery_Rate_Quantity_Textbox.Location = New System.Drawing.Point(20, 23)
        Me.Delivery_Rate_Quantity_Textbox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Delivery_Rate_Quantity_Textbox.Name = "Delivery_Rate_Quantity_Textbox"
        Me.Delivery_Rate_Quantity_Textbox.ReadOnly = True
        Me.Delivery_Rate_Quantity_Textbox.Size = New System.Drawing.Size(100, 29)
        Me.Delivery_Rate_Quantity_Textbox.TabIndex = 1
        Me.Delivery_Rate_Quantity_Textbox.TabStop = False
        Me.Delivery_Rate_Quantity_Textbox.Text = "0.00"
        Me.Delivery_Rate_Quantity_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Delivery_Flat_RateCheckBox
        '
        Me.Delivery_Flat_RateCheckBox.ForeColor = System.Drawing.Color.Black
        Me.Delivery_Flat_RateCheckBox.Location = New System.Drawing.Point(20, 27)
        Me.Delivery_Flat_RateCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Delivery_Flat_RateCheckBox.Name = "Delivery_Flat_RateCheckBox"
        Me.Delivery_Flat_RateCheckBox.Size = New System.Drawing.Size(152, 22)
        Me.Delivery_Flat_RateCheckBox.TabIndex = 8
        Me.Delivery_Flat_RateCheckBox.Text = "Flat Rate"
        '
        'Delivery_RateTextBox
        '
        Me.Delivery_RateTextBox.BackColor = System.Drawing.Color.White
        Me.Delivery_RateTextBox.Location = New System.Drawing.Point(70, 49)
        Me.Delivery_RateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Delivery_RateTextBox.Name = "Delivery_RateTextBox"
        Me.Delivery_RateTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Delivery_RateTextBox.TabIndex = 9
        Me.Delivery_RateTextBox.Text = "$0.00"
        Me.Delivery_RateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Print_Receipt_Button)
        Me.GroupBox1.Controls.Add(Me.btnSaveTicket)
        Me.GroupBox1.Controls.Add(Me.lblButtonPrompt)
        Me.GroupBox1.Controls.Add(Me.Save_Vehicle_Button)
        Me.GroupBox1.Controls.Add(Me.Print_Ticket_Button)
        Me.GroupBox1.Controls.Add(Me.Cancel_Button)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 409)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(423, 161)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Print_Receipt_Button
        '
        Me.Print_Receipt_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Print_Receipt_Button.Location = New System.Drawing.Point(152, 74)
        Me.Print_Receipt_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Print_Receipt_Button.Name = "Print_Receipt_Button"
        Me.Print_Receipt_Button.Size = New System.Drawing.Size(124, 52)
        Me.Print_Receipt_Button.TabIndex = 14
        Me.Print_Receipt_Button.Text = "Print/Save &Receipt"
        Me.Print_Receipt_Button.UseVisualStyleBackColor = False
        '
        'btnSaveTicket
        '
        Me.btnSaveTicket.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveTicket.Location = New System.Drawing.Point(19, 15)
        Me.btnSaveTicket.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveTicket.Name = "btnSaveTicket"
        Me.btnSaveTicket.Size = New System.Drawing.Size(124, 52)
        Me.btnSaveTicket.TabIndex = 11
        Me.btnSaveTicket.Text = "&Save Ticket Only"
        Me.btnSaveTicket.UseVisualStyleBackColor = False
        '
        'lblButtonPrompt
        '
        Me.lblButtonPrompt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblButtonPrompt.ForeColor = System.Drawing.Color.Red
        Me.lblButtonPrompt.Location = New System.Drawing.Point(2, 133)
        Me.lblButtonPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblButtonPrompt.Name = "lblButtonPrompt"
        Me.lblButtonPrompt.Size = New System.Drawing.Size(419, 26)
        Me.lblButtonPrompt.TabIndex = 0
        Me.lblButtonPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Save_Vehicle_Button
        '
        Me.Save_Vehicle_Button.BackColor = System.Drawing.Color.Khaki
        Me.Save_Vehicle_Button.Location = New System.Drawing.Point(285, 15)
        Me.Save_Vehicle_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Save_Vehicle_Button.Name = "Save_Vehicle_Button"
        Me.Save_Vehicle_Button.Size = New System.Drawing.Size(124, 52)
        Me.Save_Vehicle_Button.TabIndex = 13
        Me.Save_Vehicle_Button.Text = "Place On Hold"
        Me.Save_Vehicle_Button.UseVisualStyleBackColor = False
        Me.Save_Vehicle_Button.Visible = False
        '
        'Print_Ticket_Button
        '
        Me.Print_Ticket_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Print_Ticket_Button.Location = New System.Drawing.Point(152, 15)
        Me.Print_Ticket_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Print_Ticket_Button.Name = "Print_Ticket_Button"
        Me.Print_Ticket_Button.Size = New System.Drawing.Size(124, 52)
        Me.Print_Ticket_Button.TabIndex = 12
        Me.Print_Ticket_Button.Text = "&Print/Save Ticket"
        Me.Print_Ticket_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Tomato
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(285, 74)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(124, 52)
        Me.Cancel_Button.TabIndex = 15
        Me.Cancel_Button.Text = "&Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'tmrButtonLabelClear
        '
        Me.tmrButtonLabelClear.Interval = 2000
        '
        'LblStatus2
        '
        Me.LblStatus2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblStatus2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblStatus2.ForeColor = System.Drawing.Color.Red
        Me.LblStatus2.Location = New System.Drawing.Point(0, 22)
        Me.LblStatus2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblStatus2.Name = "LblStatus2"
        Me.LblStatus2.Size = New System.Drawing.Size(948, 22)
        Me.LblStatus2.TabIndex = 35
        Me.LblStatus2.Text = "LblStatus2"
        Me.LblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(150, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'AccountProductsTableAdapter
        '
        Me.AccountProductsTableAdapter.ClearBeforeFill = True
        '
        'TicketTableAdapter
        '
        Me.TicketTableAdapter.ClearBeforeFill = True
        '
        'Job_ProductsTableAdapter
        '
        Me.Job_ProductsTableAdapter.ClearBeforeFill = True
        '
        'pnlPricing
        '
        Me.pnlPricing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlPricing.Controls.Add(Me.grpDelivery)
        Me.pnlPricing.Controls.Add(Me.grpPrice)
        Me.pnlPricing.Location = New System.Drawing.Point(453, 123)
        Me.pnlPricing.Name = "pnlPricing"
        Me.pnlPricing.Size = New System.Drawing.Size(449, 295)
        Me.pnlPricing.TabIndex = 4
        Me.pnlPricing.Visible = False
        '
        'JobTotalsByAccount_ByDateTableAdapter
        '
        Me.JobTotalsByAccount_ByDateTableAdapter.ClearBeforeFill = True
        '
        'JobTotalsByAccountTableAdapter
        '
        Me.JobTotalsByAccountTableAdapter.ClearBeforeFill = True
        '
        'tmrFlashRateColor
        '
        Me.tmrFlashRateColor.Enabled = True
        Me.tmrFlashRateColor.Interval = 1000
        '
        'Weigh_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(948, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlPricing)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.LblStatus2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(TicketLabel1)
        Me.Controls.Add(Me.TicketTextBox)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.grpProduct)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.pnlVehicle)
        Me.Controls.Add(Me.grpQuantity)
        Me.Controls.Add(Me.grpWeight)
        Me.Controls.Add(CommentLabel)
        Me.Controls.Add(Me.CommentTextBox)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "Weigh_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weigh Ticket"
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTrucksHaulerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKJobAccount1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWeight.ResumeLayout(False)
        Me.grpWeight.PerformLayout()
        Me.pnlTonsPerYard.ResumeLayout(False)
        Me.pnlTonsPerYard.PerformLayout()
        Me.grpQuantity.ResumeLayout(False)
        Me.grpQuantity.PerformLayout()
        Me.pnlVehicle.ResumeLayout(False)
        Me.pnlVehicle.PerformLayout()
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        Me.grpProduct.ResumeLayout(False)
        Me.grpProduct.PerformLayout()
        CType(Me.FKTrucksHaulerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrice.ResumeLayout(False)
        Me.grpPrice.PerformLayout()
        CType(Me.SetupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.pnlDelivery_Rate_By_Quantity.ResumeLayout(False)
        Me.pnlDelivery_Rate_By_Quantity.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlPricing.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents HaulerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HaulerTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter
    Friend WithEvents Truck_IdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FKTrucksHaulerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter
    Friend WithEvents Job_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.JobTableAdapter
    Friend WithEvents FKJobAccount1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Account_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Product_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpWeight As System.Windows.Forms.GroupBox
    Friend WithEvents TareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrossTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpQuantity As System.Windows.Forms.GroupBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_Of_MeasureLabel1 As System.Windows.Forms.Label
    Friend WithEvents NetTonsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlTonsPerYard As System.Windows.Forms.Panel
    Friend WithEvents Tons_Per_YardTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlVehicle As System.Windows.Forms.GroupBox
    Friend WithEvents pnlAccount As System.Windows.Forms.GroupBox
    Friend WithEvents grpProduct As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents FKTrucksHaulerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Hauler_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TicketTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Price_Per_UOMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpPrice As System.Windows.Forms.GroupBox
    Friend WithEvents SetupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SetupTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter
    Friend WithEvents Subtotal_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTax_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Price_Per_UOMLabel As System.Windows.Forms.Label
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents TotalPrice_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryPrice_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Extended_Price_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tax_RateLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblButtonPrompt As System.Windows.Forms.Label
    Friend WithEvents tmrButtonLabelClear As System.Windows.Forms.Timer
    Friend WithEvents Same_As_Hauler_Button As System.Windows.Forms.Button
    Friend WithEvents Description_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents LblStatus2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents AccountProductsTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter
    Friend WithEvents TicketTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TicketTableAdapter
    Friend WithEvents Job_ProductsTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Job_ProductsTableAdapter
    Friend WithEvents Save_Vehicle_Button As System.Windows.Forms.Button
    Friend WithEvents Print_Ticket_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents pnlDelivery_Rate_By_Quantity As System.Windows.Forms.Panel
    Friend WithEvents Delivery_Rate_Total_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Delivery_Rate_Quantity_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Delivery_Flat_RateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Delivery_RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlPricing As System.Windows.Forms.Panel
    Friend WithEvents SetGrossBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents JobTotalsByAccount_ByDateTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.JobTotalsByAccount_ByDateTableAdapter
    Friend WithEvents JobTotalsByAccountTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.JobTotalsByAccountTableAdapter
    Friend WithEvents tmrFlashRateColor As System.Windows.Forms.Timer
    Friend WithEvents btnSaveTicket As System.Windows.Forms.Button
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Driver_Label As System.Windows.Forms.Label
    Friend WithEvents Print_Receipt_Button As Button
End Class
