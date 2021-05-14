<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class System_Setup
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
        Dim Company_NameLabel As System.Windows.Forms.Label
        Dim Header1Label As System.Windows.Forms.Label
        Dim Header2Label As System.Windows.Forms.Label
        Dim Header3Label As System.Windows.Forms.Label
        Dim Tax_RateLabel As System.Windows.Forms.Label
        Dim Simulate_ScaleLabel As System.Windows.Forms.Label
        Dim Default_HaulerLabel As System.Windows.Forms.Label
        Dim Comm_PortLabel As System.Windows.Forms.Label
        Dim Print_To_ScreenLabel As System.Windows.Forms.Label
        Dim Show_Price_By_DefaultLabel As System.Windows.Forms.Label
        Dim Pit_NameLabel As System.Windows.Forms.Label
        Dim Show_SplitWeigh_ButtonLabel As System.Windows.Forms.Label
        Dim Station_NumberLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Report_PrinterLabel As System.Windows.Forms.Label
        Dim Ticket_PrinterLabel As System.Windows.Forms.Label
        Dim Ticket_NumberLabel As System.Windows.Forms.Label
        Dim Ticket_Copies_Per_PageLabel As System.Windows.Forms.Label
        Dim Ticket_CopiesLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Ticket_PaperLabel As System.Windows.Forms.Label
        Dim Comm_PortLabel2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SetupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.SetupTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatesTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.StatesTableAdapter()
        Me.Company_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Header1TextBox = New System.Windows.Forms.TextBox()
        Me.Header2TextBox = New System.Windows.Forms.TextBox()
        Me.Header3TextBox = New System.Windows.Forms.TextBox()
        Me.Tax_RateNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Simulate_ScaleCheckBox = New System.Windows.Forms.CheckBox()
        Me.Default_HaulerComboBox = New System.Windows.Forms.ComboBox()
        Me.HaulerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comm_PortComboBox = New System.Windows.Forms.ComboBox()
        Me.Print_To_ScreenCheckBox = New System.Windows.Forms.CheckBox()
        Me.Show_Price_By_DefaultCheckBox = New System.Windows.Forms.CheckBox()
        Me.Pit_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Show_SplitWeigh_ButtonCheckBox = New System.Windows.Forms.CheckBox()
        Me.Station_NumberNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HaulerTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Report_PrinterTextBox = New System.Windows.Forms.TextBox()
        Me.Ticket_PrinterTextBox = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Ticket_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Ticket_Copies_Per_PageNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Ticket_CopiesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ckFlashDeliveryRate = New System.Windows.Forms.CheckBox()
        Me.Ticket_PaperTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ckDualScale = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtScale1Name = New System.Windows.Forms.TextBox()
        Me.txtScale2Name = New System.Windows.Forms.TextBox()
        Me.Comm_PortComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Comm_PortComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ckAllowEmail = New System.Windows.Forms.CheckBox()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.txtSmtpPass = New System.Windows.Forms.TextBox()
        Me.txtSmtpUser = New System.Windows.Forms.TextBox()
        Me.numSMTPPort = New System.Windows.Forms.NumericUpDown()
        Me.txtSMTPServer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Company_NameLabel = New System.Windows.Forms.Label()
        Header1Label = New System.Windows.Forms.Label()
        Header2Label = New System.Windows.Forms.Label()
        Header3Label = New System.Windows.Forms.Label()
        Tax_RateLabel = New System.Windows.Forms.Label()
        Simulate_ScaleLabel = New System.Windows.Forms.Label()
        Default_HaulerLabel = New System.Windows.Forms.Label()
        Comm_PortLabel = New System.Windows.Forms.Label()
        Print_To_ScreenLabel = New System.Windows.Forms.Label()
        Show_Price_By_DefaultLabel = New System.Windows.Forms.Label()
        Pit_NameLabel = New System.Windows.Forms.Label()
        Show_SplitWeigh_ButtonLabel = New System.Windows.Forms.Label()
        Station_NumberLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Report_PrinterLabel = New System.Windows.Forms.Label()
        Ticket_PrinterLabel = New System.Windows.Forms.Label()
        Ticket_NumberLabel = New System.Windows.Forms.Label()
        Ticket_Copies_Per_PageLabel = New System.Windows.Forms.Label()
        Ticket_CopiesLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Ticket_PaperLabel = New System.Windows.Forms.Label()
        Comm_PortLabel2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SetupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tax_RateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Station_NumberNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ticket_Copies_Per_PageNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ticket_CopiesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmail.SuspendLayout()
        CType(Me.numSMTPPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Company_NameLabel
        '
        Company_NameLabel.Location = New System.Drawing.Point(81, 52)
        Company_NameLabel.Name = "Company_NameLabel"
        Company_NameLabel.Size = New System.Drawing.Size(139, 20)
        Company_NameLabel.TabIndex = 8
        Company_NameLabel.Text = "Company Name:"
        Company_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Header1Label
        '
        Header1Label.Location = New System.Drawing.Point(137, 84)
        Header1Label.Name = "Header1Label"
        Header1Label.Size = New System.Drawing.Size(83, 20)
        Header1Label.TabIndex = 10
        Header1Label.Text = "Header1:"
        Header1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Header2Label
        '
        Header2Label.Location = New System.Drawing.Point(137, 116)
        Header2Label.Name = "Header2Label"
        Header2Label.Size = New System.Drawing.Size(83, 20)
        Header2Label.TabIndex = 12
        Header2Label.Text = "Header2:"
        Header2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Header3Label
        '
        Header3Label.Location = New System.Drawing.Point(137, 148)
        Header3Label.Name = "Header3Label"
        Header3Label.Size = New System.Drawing.Size(83, 20)
        Header3Label.TabIndex = 14
        Header3Label.Text = "Header3:"
        Header3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tax_RateLabel
        '
        Tax_RateLabel.Location = New System.Drawing.Point(329, 181)
        Tax_RateLabel.Name = "Tax_RateLabel"
        Tax_RateLabel.Size = New System.Drawing.Size(86, 20)
        Tax_RateLabel.TabIndex = 16
        Tax_RateLabel.Text = "Tax Rate:"
        Tax_RateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Simulate_ScaleLabel
        '
        Simulate_ScaleLabel.Location = New System.Drawing.Point(280, 344)
        Simulate_ScaleLabel.Name = "Simulate_ScaleLabel"
        Simulate_ScaleLabel.Size = New System.Drawing.Size(134, 20)
        Simulate_ScaleLabel.TabIndex = 18
        Simulate_ScaleLabel.Text = "Simulate Scale:"
        Simulate_ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Default_HaulerLabel
        '
        Default_HaulerLabel.Location = New System.Drawing.Point(90, 309)
        Default_HaulerLabel.Name = "Default_HaulerLabel"
        Default_HaulerLabel.Size = New System.Drawing.Size(131, 20)
        Default_HaulerLabel.TabIndex = 20
        Default_HaulerLabel.Text = "Default Hauler:"
        Default_HaulerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Comm_PortLabel
        '
        Comm_PortLabel.Location = New System.Drawing.Point(533, 384)
        Comm_PortLabel.Name = "Comm_PortLabel"
        Comm_PortLabel.Size = New System.Drawing.Size(102, 20)
        Comm_PortLabel.TabIndex = 22
        Comm_PortLabel.Text = "Comm Port:"
        Comm_PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Print_To_ScreenLabel
        '
        Print_To_ScreenLabel.Location = New System.Drawing.Point(276, 454)
        Print_To_ScreenLabel.Name = "Print_To_ScreenLabel"
        Print_To_ScreenLabel.Size = New System.Drawing.Size(138, 20)
        Print_To_ScreenLabel.TabIndex = 24
        Print_To_ScreenLabel.Text = "Print To Screen:"
        Print_To_ScreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Show_Price_By_DefaultLabel
        '
        Show_Price_By_DefaultLabel.Location = New System.Drawing.Point(27, 453)
        Show_Price_By_DefaultLabel.Name = "Show_Price_By_DefaultLabel"
        Show_Price_By_DefaultLabel.Size = New System.Drawing.Size(192, 20)
        Show_Price_By_DefaultLabel.TabIndex = 26
        Show_Price_By_DefaultLabel.Text = "Show Price By Default:"
        Show_Price_By_DefaultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Pit_NameLabel
        '
        Pit_NameLabel.Location = New System.Drawing.Point(132, 488)
        Pit_NameLabel.Name = "Pit_NameLabel"
        Pit_NameLabel.Size = New System.Drawing.Size(86, 20)
        Pit_NameLabel.TabIndex = 28
        Pit_NameLabel.Text = "Pit Name:"
        Pit_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Show_SplitWeigh_ButtonLabel
        '
        Show_SplitWeigh_ButtonLabel.Location = New System.Drawing.Point(480, 344)
        Show_SplitWeigh_ButtonLabel.Name = "Show_SplitWeigh_ButtonLabel"
        Show_SplitWeigh_ButtonLabel.Size = New System.Drawing.Size(213, 20)
        Show_SplitWeigh_ButtonLabel.TabIndex = 30
        Show_SplitWeigh_ButtonLabel.Text = "Show Split Weigh Button:"
        Show_SplitWeigh_ButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Station_NumberLabel
        '
        Station_NumberLabel.Location = New System.Drawing.Point(81, 180)
        Station_NumberLabel.Name = "Station_NumberLabel"
        Station_NumberLabel.Size = New System.Drawing.Size(139, 20)
        Station_NumberLabel.TabIndex = 32
        Station_NumberLabel.Text = "Station Number:"
        Station_NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(499, 185)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 37
        Label2.Text = " .05=15% "
        '
        'Report_PrinterLabel
        '
        Report_PrinterLabel.AutoSize = True
        Report_PrinterLabel.Location = New System.Drawing.Point(92, 212)
        Report_PrinterLabel.Name = "Report_PrinterLabel"
        Report_PrinterLabel.Size = New System.Drawing.Size(127, 20)
        Report_PrinterLabel.TabIndex = 37
        Report_PrinterLabel.Text = "Report Printer:"
        '
        'Ticket_PrinterLabel
        '
        Ticket_PrinterLabel.AutoSize = True
        Ticket_PrinterLabel.Location = New System.Drawing.Point(99, 244)
        Ticket_PrinterLabel.Name = "Ticket_PrinterLabel"
        Ticket_PrinterLabel.Size = New System.Drawing.Size(120, 20)
        Ticket_PrinterLabel.TabIndex = 38
        Ticket_PrinterLabel.Text = "Ticket Printer:"
        '
        'Ticket_NumberLabel
        '
        Ticket_NumberLabel.AutoSize = True
        Ticket_NumberLabel.Location = New System.Drawing.Point(90, 19)
        Ticket_NumberLabel.Name = "Ticket_NumberLabel"
        Ticket_NumberLabel.Size = New System.Drawing.Size(129, 20)
        Ticket_NumberLabel.TabIndex = 41
        Ticket_NumberLabel.Text = "Ticket Number:"
        '
        'Ticket_Copies_Per_PageLabel
        '
        Ticket_Copies_Per_PageLabel.AutoSize = True
        Ticket_Copies_Per_PageLabel.Location = New System.Drawing.Point(19, 273)
        Ticket_Copies_Per_PageLabel.Name = "Ticket_Copies_Per_PageLabel"
        Ticket_Copies_Per_PageLabel.Size = New System.Drawing.Size(200, 20)
        Ticket_Copies_Per_PageLabel.TabIndex = 42
        Ticket_Copies_Per_PageLabel.Text = "Ticket Copies Per Page:"
        '
        'Ticket_CopiesLabel
        '
        Ticket_CopiesLabel.AutoSize = True
        Ticket_CopiesLabel.Location = New System.Drawing.Point(292, 273)
        Ticket_CopiesLabel.Name = "Ticket_CopiesLabel"
        Ticket_CopiesLabel.Size = New System.Drawing.Size(122, 20)
        Ticket_CopiesLabel.TabIndex = 43
        Ticket_CopiesLabel.Text = "Pages to Print"
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(480, 453)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(212, 20)
        Label3.TabIndex = 46
        Label3.Text = "Flash Delivery Rate Box:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ticket_PaperLabel
        '
        Ticket_PaperLabel.AutoSize = True
        Ticket_PaperLabel.Location = New System.Drawing.Point(509, 273)
        Ticket_PaperLabel.Name = "Ticket_PaperLabel"
        Ticket_PaperLabel.Size = New System.Drawing.Size(114, 20)
        Ticket_PaperLabel.TabIndex = 46
        Ticket_PaperLabel.Text = "Ticket Paper:"
        '
        'Comm_PortLabel2
        '
        Comm_PortLabel2.Location = New System.Drawing.Point(533, 416)
        Comm_PortLabel2.Name = "Comm_PortLabel2"
        Comm_PortLabel2.Size = New System.Drawing.Size(102, 20)
        Comm_PortLabel2.TabIndex = 54
        Comm_PortLabel2.Text = "Comm Port:"
        Comm_PortLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(551, 180)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(124, 20)
        Label5.TabIndex = 56
        Label5.Text = "Receipt Port:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(19, 527)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(192, 20)
        Label6.TabIndex = 58
        Label6.Text = "Allow Email:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(464, 709)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(348, 62)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(11, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(151, 49)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save and Close"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(185, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(151, 49)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'SetupBindingSource
        '
        Me.SetupBindingSource.DataMember = "Setup"
        Me.SetupBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'IRS_ScaleDataSet
        '
        Me.IRS_ScaleDataSet.DataSetName = "IRS_ScaleDataSet"
        Me.IRS_ScaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SetupTableAdapter
        '
        Me.SetupTableAdapter.ClearBeforeFill = True
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'Company_NameTextBox
        '
        Me.Company_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Company_Name", True))
        Me.Company_NameTextBox.Location = New System.Drawing.Point(225, 49)
        Me.Company_NameTextBox.Name = "Company_NameTextBox"
        Me.Company_NameTextBox.Size = New System.Drawing.Size(504, 26)
        Me.Company_NameTextBox.TabIndex = 9
        '
        'Header1TextBox
        '
        Me.Header1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Header1", True))
        Me.Header1TextBox.Location = New System.Drawing.Point(225, 81)
        Me.Header1TextBox.Name = "Header1TextBox"
        Me.Header1TextBox.Size = New System.Drawing.Size(504, 26)
        Me.Header1TextBox.TabIndex = 11
        '
        'Header2TextBox
        '
        Me.Header2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Header2", True))
        Me.Header2TextBox.Location = New System.Drawing.Point(225, 113)
        Me.Header2TextBox.Name = "Header2TextBox"
        Me.Header2TextBox.Size = New System.Drawing.Size(504, 26)
        Me.Header2TextBox.TabIndex = 13
        '
        'Header3TextBox
        '
        Me.Header3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Header3", True))
        Me.Header3TextBox.Location = New System.Drawing.Point(225, 145)
        Me.Header3TextBox.Name = "Header3TextBox"
        Me.Header3TextBox.Size = New System.Drawing.Size(504, 26)
        Me.Header3TextBox.TabIndex = 15
        '
        'Tax_RateNumericUpDown
        '
        Me.Tax_RateNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SetupBindingSource, "Tax_Rate", True))
        Me.Tax_RateNumericUpDown.DecimalPlaces = 2
        Me.Tax_RateNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Tax_RateNumericUpDown.Location = New System.Drawing.Point(420, 178)
        Me.Tax_RateNumericUpDown.Name = "Tax_RateNumericUpDown"
        Me.Tax_RateNumericUpDown.Size = New System.Drawing.Size(73, 26)
        Me.Tax_RateNumericUpDown.TabIndex = 17
        Me.Tax_RateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Simulate_ScaleCheckBox
        '
        Me.Simulate_ScaleCheckBox.Location = New System.Drawing.Point(419, 342)
        Me.Simulate_ScaleCheckBox.Name = "Simulate_ScaleCheckBox"
        Me.Simulate_ScaleCheckBox.Size = New System.Drawing.Size(34, 24)
        Me.Simulate_ScaleCheckBox.TabIndex = 19
        '
        'Default_HaulerComboBox
        '
        Me.Default_HaulerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Default_Hauler", True))
        Me.Default_HaulerComboBox.DataSource = Me.HaulerBindingSource
        Me.Default_HaulerComboBox.DisplayMember = "Hauler_Name"
        Me.Default_HaulerComboBox.FormattingEnabled = True
        Me.Default_HaulerComboBox.Location = New System.Drawing.Point(226, 305)
        Me.Default_HaulerComboBox.Name = "Default_HaulerComboBox"
        Me.Default_HaulerComboBox.Size = New System.Drawing.Size(504, 28)
        Me.Default_HaulerComboBox.TabIndex = 21
        Me.Default_HaulerComboBox.ValueMember = "Hauler_Name"
        '
        'HaulerBindingSource
        '
        Me.HaulerBindingSource.DataMember = "Hauler"
        Me.HaulerBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'Comm_PortComboBox
        '
        Me.Comm_PortComboBox.FormattingEnabled = True
        Me.Comm_PortComboBox.Location = New System.Drawing.Point(640, 379)
        Me.Comm_PortComboBox.Name = "Comm_PortComboBox"
        Me.Comm_PortComboBox.Size = New System.Drawing.Size(73, 28)
        Me.Comm_PortComboBox.TabIndex = 23
        '
        'Print_To_ScreenCheckBox
        '
        Me.Print_To_ScreenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SetupBindingSource, "Print_To_Screen", True))
        Me.Print_To_ScreenCheckBox.Location = New System.Drawing.Point(419, 453)
        Me.Print_To_ScreenCheckBox.Name = "Print_To_ScreenCheckBox"
        Me.Print_To_ScreenCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Print_To_ScreenCheckBox.TabIndex = 25
        '
        'Show_Price_By_DefaultCheckBox
        '
        Me.Show_Price_By_DefaultCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SetupBindingSource, "Show_Price_By_Default", True))
        Me.Show_Price_By_DefaultCheckBox.Location = New System.Drawing.Point(223, 452)
        Me.Show_Price_By_DefaultCheckBox.Name = "Show_Price_By_DefaultCheckBox"
        Me.Show_Price_By_DefaultCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Show_Price_By_DefaultCheckBox.TabIndex = 27
        '
        'Pit_NameTextBox
        '
        Me.Pit_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Pit_Name", True))
        Me.Pit_NameTextBox.Location = New System.Drawing.Point(223, 485)
        Me.Pit_NameTextBox.Name = "Pit_NameTextBox"
        Me.Pit_NameTextBox.Size = New System.Drawing.Size(504, 26)
        Me.Pit_NameTextBox.TabIndex = 29
        '
        'Show_SplitWeigh_ButtonCheckBox
        '
        Me.Show_SplitWeigh_ButtonCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SetupBindingSource, "Show_SplitWeigh_Button", True))
        Me.Show_SplitWeigh_ButtonCheckBox.Location = New System.Drawing.Point(698, 342)
        Me.Show_SplitWeigh_ButtonCheckBox.Name = "Show_SplitWeigh_ButtonCheckBox"
        Me.Show_SplitWeigh_ButtonCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Show_SplitWeigh_ButtonCheckBox.TabIndex = 31
        '
        'Station_NumberNumericUpDown
        '
        Me.Station_NumberNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SetupBindingSource, "Station_Number", True))
        Me.Station_NumberNumericUpDown.Location = New System.Drawing.Point(225, 177)
        Me.Station_NumberNumericUpDown.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Station_NumberNumericUpDown.Name = "Station_NumberNumericUpDown"
        Me.Station_NumberNumericUpDown.Size = New System.Drawing.Size(73, 26)
        Me.Station_NumberNumericUpDown.TabIndex = 33
        Me.Station_NumberNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HaulerTableAdapter
        '
        Me.HaulerTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 709)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 36)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Zip Code List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Report_PrinterTextBox
        '
        Me.Report_PrinterTextBox.Location = New System.Drawing.Point(225, 209)
        Me.Report_PrinterTextBox.Name = "Report_PrinterTextBox"
        Me.Report_PrinterTextBox.Size = New System.Drawing.Size(450, 26)
        Me.Report_PrinterTextBox.TabIndex = 38
        '
        'Ticket_PrinterTextBox
        '
        Me.Ticket_PrinterTextBox.Location = New System.Drawing.Point(225, 241)
        Me.Ticket_PrinterTextBox.Name = "Ticket_PrinterTextBox"
        Me.Ticket_PrinterTextBox.Size = New System.Drawing.Size(450, 26)
        Me.Ticket_PrinterTextBox.TabIndex = 39
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(684, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 26)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(684, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 26)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Ticket_NumberTextBox
        '
        Me.Ticket_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Ticket_Number", True))
        Me.Ticket_NumberTextBox.Location = New System.Drawing.Point(225, 16)
        Me.Ticket_NumberTextBox.Name = "Ticket_NumberTextBox"
        Me.Ticket_NumberTextBox.Size = New System.Drawing.Size(151, 26)
        Me.Ticket_NumberTextBox.TabIndex = 42
        Me.Ticket_NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Ticket_Copies_Per_PageNumericUpDown
        '
        Me.Ticket_Copies_Per_PageNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SetupBindingSource, "Ticket_Copies_Per_Page", True))
        Me.Ticket_Copies_Per_PageNumericUpDown.Location = New System.Drawing.Point(225, 273)
        Me.Ticket_Copies_Per_PageNumericUpDown.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Ticket_Copies_Per_PageNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ticket_Copies_Per_PageNumericUpDown.Name = "Ticket_Copies_Per_PageNumericUpDown"
        Me.Ticket_Copies_Per_PageNumericUpDown.Size = New System.Drawing.Size(33, 26)
        Me.Ticket_Copies_Per_PageNumericUpDown.TabIndex = 43
        Me.Ticket_Copies_Per_PageNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Ticket_CopiesNumericUpDown
        '
        Me.Ticket_CopiesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SetupBindingSource, "Ticket_Copies", True))
        Me.Ticket_CopiesNumericUpDown.Location = New System.Drawing.Point(420, 273)
        Me.Ticket_CopiesNumericUpDown.Name = "Ticket_CopiesNumericUpDown"
        Me.Ticket_CopiesNumericUpDown.Size = New System.Drawing.Size(59, 26)
        Me.Ticket_CopiesNumericUpDown.TabIndex = 44
        '
        'ckFlashDeliveryRate
        '
        Me.ckFlashDeliveryRate.AutoSize = True
        Me.ckFlashDeliveryRate.Location = New System.Drawing.Point(698, 457)
        Me.ckFlashDeliveryRate.Name = "ckFlashDeliveryRate"
        Me.ckFlashDeliveryRate.Size = New System.Drawing.Size(15, 14)
        Me.ckFlashDeliveryRate.TabIndex = 45
        Me.ckFlashDeliveryRate.UseVisualStyleBackColor = True
        '
        'Ticket_PaperTextBox
        '
        Me.Ticket_PaperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "Ticket_Paper", True))
        Me.Ticket_PaperTextBox.Location = New System.Drawing.Point(629, 273)
        Me.Ticket_PaperTextBox.Name = "Ticket_PaperTextBox"
        Me.Ticket_PaperTextBox.Size = New System.Drawing.Size(101, 26)
        Me.Ticket_PaperTextBox.TabIndex = 47
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(390, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(274, 30)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Archive Transactions"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'ckDualScale
        '
        Me.ckDualScale.AutoSize = True
        Me.ckDualScale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckDualScale.Location = New System.Drawing.Point(118, 343)
        Me.ckDualScale.Name = "ckDualScale"
        Me.ckDualScale.Size = New System.Drawing.Size(120, 24)
        Me.ckDualScale.TabIndex = 49
        Me.ckDualScale.Text = "Dual Scale:"
        Me.ckDualScale.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Scale 1 Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Scale 2 Name :"
        '
        'txtScale1Name
        '
        Me.txtScale1Name.Location = New System.Drawing.Point(239, 381)
        Me.txtScale1Name.Name = "txtScale1Name"
        Me.txtScale1Name.Size = New System.Drawing.Size(254, 26)
        Me.txtScale1Name.TabIndex = 52
        '
        'txtScale2Name
        '
        Me.txtScale2Name.Location = New System.Drawing.Point(239, 413)
        Me.txtScale2Name.Name = "txtScale2Name"
        Me.txtScale2Name.Size = New System.Drawing.Size(254, 26)
        Me.txtScale2Name.TabIndex = 53
        '
        'Comm_PortComboBox2
        '
        Me.Comm_PortComboBox2.FormattingEnabled = True
        Me.Comm_PortComboBox2.Location = New System.Drawing.Point(640, 411)
        Me.Comm_PortComboBox2.Name = "Comm_PortComboBox2"
        Me.Comm_PortComboBox2.Size = New System.Drawing.Size(73, 28)
        Me.Comm_PortComboBox2.TabIndex = 55
        '
        'Comm_PortComboBox3
        '
        Me.Comm_PortComboBox3.FormattingEnabled = True
        Me.Comm_PortComboBox3.Location = New System.Drawing.Point(684, 176)
        Me.Comm_PortComboBox3.Name = "Comm_PortComboBox3"
        Me.Comm_PortComboBox3.Size = New System.Drawing.Size(116, 28)
        Me.Comm_PortComboBox3.TabIndex = 57
        '
        'ckAllowEmail
        '
        Me.ckAllowEmail.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SetupBindingSource, "AllowEmail", True))
        Me.ckAllowEmail.Location = New System.Drawing.Point(215, 526)
        Me.ckAllowEmail.Name = "ckAllowEmail"
        Me.ckAllowEmail.Size = New System.Drawing.Size(22, 24)
        Me.ckAllowEmail.TabIndex = 59
        '
        'pnlEmail
        '
        Me.pnlEmail.Controls.Add(Me.TextBox1)
        Me.pnlEmail.Controls.Add(Me.Label11)
        Me.pnlEmail.Controls.Add(Me.txtSmtpPass)
        Me.pnlEmail.Controls.Add(Me.txtSmtpUser)
        Me.pnlEmail.Controls.Add(Me.numSMTPPort)
        Me.pnlEmail.Controls.Add(Me.txtSMTPServer)
        Me.pnlEmail.Controls.Add(Me.Label10)
        Me.pnlEmail.Controls.Add(Me.Label9)
        Me.pnlEmail.Controls.Add(Me.Label8)
        Me.pnlEmail.Controls.Add(Me.Label7)
        Me.pnlEmail.Location = New System.Drawing.Point(235, 526)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(565, 159)
        Me.pnlEmail.TabIndex = 60
        Me.pnlEmail.Visible = False
        '
        'txtSmtpPass
        '
        Me.txtSmtpPass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "SMTPPass", True))
        Me.txtSmtpPass.Location = New System.Drawing.Point(123, 73)
        Me.txtSmtpPass.Name = "txtSmtpPass"
        Me.txtSmtpPass.Size = New System.Drawing.Size(411, 26)
        Me.txtSmtpPass.TabIndex = 7
        '
        'txtSmtpUser
        '
        Me.txtSmtpUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "SMTPUser", True))
        Me.txtSmtpUser.Location = New System.Drawing.Point(123, 43)
        Me.txtSmtpUser.Name = "txtSmtpUser"
        Me.txtSmtpUser.Size = New System.Drawing.Size(411, 26)
        Me.txtSmtpUser.TabIndex = 6
        '
        'numSMTPPort
        '
        Me.numSMTPPort.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SetupBindingSource, "SMTPPort", True))
        Me.numSMTPPort.Location = New System.Drawing.Point(449, 7)
        Me.numSMTPPort.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numSMTPPort.Name = "numSMTPPort"
        Me.numSMTPPort.Size = New System.Drawing.Size(85, 26)
        Me.numSMTPPort.TabIndex = 5
        Me.numSMTPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSMTPServer
        '
        Me.txtSMTPServer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "SMTPServer", True))
        Me.txtSMTPServer.Location = New System.Drawing.Point(123, 7)
        Me.txtSMTPServer.Name = "txtSMTPServer"
        Me.txtSMTPServer.Size = New System.Drawing.Size(253, 26)
        Me.txtSMTPServer.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "SMTP Pass:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "SMTP User:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Port:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SMTP Server:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupBindingSource, "SMTPFromEmail", True))
        Me.TextBox1.Location = New System.Drawing.Point(123, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(411, 26)
        Me.TextBox1.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "From Email:"
        '
        'System_Setup
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(833, 794)
        Me.Controls.Add(Me.pnlEmail)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.ckAllowEmail)
        Me.Controls.Add(Me.Comm_PortComboBox3)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Comm_PortLabel2)
        Me.Controls.Add(Me.Comm_PortComboBox2)
        Me.Controls.Add(Me.txtScale2Name)
        Me.Controls.Add(Me.txtScale1Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckDualScale)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Ticket_PaperLabel)
        Me.Controls.Add(Me.Ticket_PaperTextBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ckFlashDeliveryRate)
        Me.Controls.Add(Ticket_CopiesLabel)
        Me.Controls.Add(Me.Ticket_CopiesNumericUpDown)
        Me.Controls.Add(Ticket_Copies_Per_PageLabel)
        Me.Controls.Add(Me.Ticket_Copies_Per_PageNumericUpDown)
        Me.Controls.Add(Ticket_NumberLabel)
        Me.Controls.Add(Me.Ticket_NumberTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Ticket_PrinterLabel)
        Me.Controls.Add(Me.Ticket_PrinterTextBox)
        Me.Controls.Add(Report_PrinterLabel)
        Me.Controls.Add(Me.Report_PrinterTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Company_NameLabel)
        Me.Controls.Add(Me.Company_NameTextBox)
        Me.Controls.Add(Header1Label)
        Me.Controls.Add(Me.Header1TextBox)
        Me.Controls.Add(Header2Label)
        Me.Controls.Add(Me.Header2TextBox)
        Me.Controls.Add(Header3Label)
        Me.Controls.Add(Me.Header3TextBox)
        Me.Controls.Add(Tax_RateLabel)
        Me.Controls.Add(Me.Tax_RateNumericUpDown)
        Me.Controls.Add(Simulate_ScaleLabel)
        Me.Controls.Add(Me.Simulate_ScaleCheckBox)
        Me.Controls.Add(Default_HaulerLabel)
        Me.Controls.Add(Me.Default_HaulerComboBox)
        Me.Controls.Add(Comm_PortLabel)
        Me.Controls.Add(Me.Comm_PortComboBox)
        Me.Controls.Add(Print_To_ScreenLabel)
        Me.Controls.Add(Me.Print_To_ScreenCheckBox)
        Me.Controls.Add(Show_Price_By_DefaultLabel)
        Me.Controls.Add(Me.Show_Price_By_DefaultCheckBox)
        Me.Controls.Add(Pit_NameLabel)
        Me.Controls.Add(Me.Pit_NameTextBox)
        Me.Controls.Add(Show_SplitWeigh_ButtonLabel)
        Me.Controls.Add(Me.Show_SplitWeigh_ButtonCheckBox)
        Me.Controls.Add(Station_NumberLabel)
        Me.Controls.Add(Me.Station_NumberNumericUpDown)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "System_Setup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SetupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tax_RateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Station_NumberNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ticket_Copies_Per_PageNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ticket_CopiesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmail.ResumeLayout(False)
        Me.pnlEmail.PerformLayout()
        CType(Me.numSMTPPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents SetupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SetupTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter
    Friend WithEvents StatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatesTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.StatesTableAdapter
    Friend WithEvents Company_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Header1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Header2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Header3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tax_RateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Simulate_ScaleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Default_HaulerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Comm_PortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Print_To_ScreenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Show_Price_By_DefaultCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Pit_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Show_SplitWeigh_ButtonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Station_NumberNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HaulerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HaulerTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Report_PrinterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ticket_PrinterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Ticket_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ticket_Copies_Per_PageNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Ticket_CopiesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ckFlashDeliveryRate As System.Windows.Forms.CheckBox
    Friend WithEvents Ticket_PaperTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ckDualScale As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtScale1Name As TextBox
    Friend WithEvents txtScale2Name As TextBox
    Friend WithEvents Comm_PortComboBox2 As ComboBox
    Friend WithEvents Comm_PortComboBox3 As ComboBox
    Friend WithEvents ckAllowEmail As CheckBox
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents txtSmtpPass As TextBox
    Friend WithEvents txtSmtpUser As TextBox
    Friend WithEvents numSMTPPort As NumericUpDown
    Friend WithEvents txtSMTPServer As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
End Class
