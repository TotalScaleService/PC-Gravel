<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Edit_Account
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
        Dim Account_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim TermsLabel As System.Windows.Forms.Label
        Dim TaxableLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Edit_Account))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.AccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter()
        Me.Account_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityComboBox = New System.Windows.Forms.ComboBox()
        Me.DistinctCitiesFromZipCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.DistinctStatesFromZipCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZipComboBox = New System.Windows.Forms.ComboBox()
        Me.DistinctZipCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TermsComboBox = New System.Windows.Forms.ComboBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Distinct_Cities_From_Zip_CodeTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Distinct_Cities_From_Zip_CodeTableAdapter()
        Me.Distinct_States_From_Zip_CodeTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Distinct_States_From_Zip_CodeTableAdapter()
        Me.Distinct_Zip_CodesTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Distinct_Zip_CodesTableAdapter()
        Me.Zip_CodesTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.Zip_CodesTableAdapter()
        Me.TaxableCheckBox = New System.Windows.Forms.CheckBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.AccountProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountProductsTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter()
        Me.AccountProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter()
        Account_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        TermsLabel = New System.Windows.Forms.Label()
        TaxableLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountBindingNavigator.SuspendLayout()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistinctCitiesFromZipCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistinctStatesFromZipCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistinctZipCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Account_NameLabel
        '
        Account_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Account_NameLabel.Location = New System.Drawing.Point(31, 85)
        Account_NameLabel.Name = "Account_NameLabel"
        Account_NameLabel.Size = New System.Drawing.Size(131, 20)
        Account_NameLabel.TabIndex = 2
        Account_NameLabel.Text = "Customer Name:"
        Account_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneLabel
        '
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(31, 118)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(131, 20)
        PhoneLabel.TabIndex = 4
        PhoneLabel.Text = "Phone:"
        PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(31, 152)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(131, 20)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CityLabel
        '
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(31, 252)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(131, 20)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StateLabel
        '
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(31, 218)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(131, 20)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ZipLabel
        '
        ZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZipLabel.Location = New System.Drawing.Point(31, 184)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(131, 20)
        ZipLabel.TabIndex = 12
        ZipLabel.Text = "Zip:"
        ZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TermsLabel
        '
        TermsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TermsLabel.Location = New System.Drawing.Point(31, 286)
        TermsLabel.Name = "TermsLabel"
        TermsLabel.Size = New System.Drawing.Size(131, 20)
        TermsLabel.TabIndex = 14
        TermsLabel.Text = "Terms:"
        TermsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TaxableLabel
        '
        TaxableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TaxableLabel.Location = New System.Drawing.Point(320, 118)
        TaxableLabel.Name = "TaxableLabel"
        TaxableLabel.Size = New System.Drawing.Size(76, 20)
        TaxableLabel.TabIndex = 16
        TaxableLabel.Text = "Taxable:"
        TaxableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(435, 595)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 45)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(5, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(111, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(126, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(112, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'AccountBindingNavigator
        '
        Me.AccountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AccountBindingNavigator.BindingSource = Me.AccountBindingSource
        Me.AccountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AccountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AccountBindingNavigatorSaveItem})
        Me.AccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AccountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AccountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AccountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AccountBindingNavigator.Name = "AccountBindingNavigator"
        Me.AccountBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.AccountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AccountBindingNavigator.Size = New System.Drawing.Size(701, 25)
        Me.AccountBindingNavigator.TabIndex = 1
        Me.AccountBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(81, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AccountBindingNavigatorSaveItem
        '
        Me.AccountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AccountBindingNavigatorSaveItem.Image = CType(resources.GetObject("AccountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AccountBindingNavigatorSaveItem.Name = "AccountBindingNavigatorSaveItem"
        Me.AccountBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AccountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccountTableAdapter
        '
        Me.AccountTableAdapter.ClearBeforeFill = True
        '
        'Account_NameTextBox
        '
        Me.Account_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "Account_Name", True))
        Me.Account_NameTextBox.Location = New System.Drawing.Point(168, 79)
        Me.Account_NameTextBox.Name = "Account_NameTextBox"
        Me.Account_NameTextBox.Size = New System.Drawing.Size(368, 26)
        Me.Account_NameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(168, 149)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(473, 26)
        Me.AddressTextBox.TabIndex = 2
        '
        'CityComboBox
        '
        Me.CityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CityComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "City", True))
        Me.CityComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AccountBindingSource, "City", True))
        Me.CityComboBox.DataSource = Me.DistinctCitiesFromZipCodeBindingSource
        Me.CityComboBox.DisplayMember = "City"
        Me.CityComboBox.FormattingEnabled = True
        Me.CityComboBox.Location = New System.Drawing.Point(168, 249)
        Me.CityComboBox.Name = "CityComboBox"
        Me.CityComboBox.Size = New System.Drawing.Size(472, 28)
        Me.CityComboBox.TabIndex = 5
        Me.CityComboBox.ValueMember = "City"
        '
        'DistinctCitiesFromZipCodeBindingSource
        '
        Me.DistinctCitiesFromZipCodeBindingSource.DataMember = "Distinct_Cities_From_Zip_Code"
        Me.DistinctCitiesFromZipCodeBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'StateComboBox
        '
        Me.StateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "State", True))
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AccountBindingSource, "State", True))
        Me.StateComboBox.DataSource = Me.DistinctStatesFromZipCodeBindingSource
        Me.StateComboBox.DisplayMember = "State"
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(168, 215)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(239, 28)
        Me.StateComboBox.TabIndex = 4
        Me.StateComboBox.ValueMember = "State"
        '
        'DistinctStatesFromZipCodeBindingSource
        '
        Me.DistinctStatesFromZipCodeBindingSource.DataMember = "Distinct_States_From_Zip_Code"
        Me.DistinctStatesFromZipCodeBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'ZipComboBox
        '
        Me.ZipComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ZipComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ZipComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "Zip", True))
        Me.ZipComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AccountBindingSource, "Zip", True))
        Me.ZipComboBox.DataSource = Me.DistinctZipCodesBindingSource
        Me.ZipComboBox.DisplayMember = "Zip"
        Me.ZipComboBox.FormattingEnabled = True
        Me.ZipComboBox.Location = New System.Drawing.Point(168, 181)
        Me.ZipComboBox.Name = "ZipComboBox"
        Me.ZipComboBox.Size = New System.Drawing.Size(239, 28)
        Me.ZipComboBox.TabIndex = 3
        Me.ZipComboBox.ValueMember = "Zip"
        '
        'DistinctZipCodesBindingSource
        '
        Me.DistinctZipCodesBindingSource.DataMember = "Distinct_Zip_Codes"
        Me.DistinctZipCodesBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'TermsComboBox
        '
        Me.TermsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TermsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TermsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "Terms", True))
        Me.TermsComboBox.FormattingEnabled = True
        Me.TermsComboBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.TermsComboBox.Location = New System.Drawing.Point(168, 283)
        Me.TermsComboBox.Name = "TermsComboBox"
        Me.TermsComboBox.Size = New System.Drawing.Size(239, 28)
        Me.TermsComboBox.TabIndex = 6
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "Phone", True))
        Me.PhoneMaskedTextBox.HidePromptOnLeave = True
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(168, 117)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(133, 26)
        Me.PhoneMaskedTextBox.TabIndex = 1
        '
        'Distinct_Cities_From_Zip_CodeTableAdapter
        '
        Me.Distinct_Cities_From_Zip_CodeTableAdapter.ClearBeforeFill = True
        '
        'Distinct_States_From_Zip_CodeTableAdapter
        '
        Me.Distinct_States_From_Zip_CodeTableAdapter.ClearBeforeFill = True
        '
        'Distinct_Zip_CodesTableAdapter
        '
        Me.Distinct_Zip_CodesTableAdapter.ClearBeforeFill = True
        '
        'Zip_CodesTableAdapter1
        '
        Me.Zip_CodesTableAdapter1.ClearBeforeFill = True
        '
        'TaxableCheckBox
        '
        Me.TaxableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AccountBindingSource, "Taxable", True))
        Me.TaxableCheckBox.Location = New System.Drawing.Point(402, 116)
        Me.TaxableCheckBox.Name = "TaxableCheckBox"
        Me.TaxableCheckBox.Size = New System.Drawing.Size(32, 24)
        Me.TaxableCheckBox.TabIndex = 8
        Me.TaxableCheckBox.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblPrompt.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPrompt.Location = New System.Drawing.Point(0, 25)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(701, 51)
        Me.lblPrompt.TabIndex = 17
        Me.lblPrompt.Text = "Edit Customer Information"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccountProductsBindingSource
        '
        Me.AccountProductsBindingSource.DataMember = "FK_AccountProducts_Account1"
        Me.AccountProductsBindingSource.DataSource = Me.AccountBindingSource
        '
        'AccountProductsTableAdapter
        '
        Me.AccountProductsTableAdapter.ClearBeforeFill = True
        '
        'AccountProductsDataGridView
        '
        Me.AccountProductsDataGridView.AutoGenerateColumns = False
        Me.AccountProductsDataGridView.ColumnHeadersHeight = 50
        Me.AccountProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
        Me.AccountProductsDataGridView.DataSource = Me.AccountProductsBindingSource
        Me.AccountProductsDataGridView.Location = New System.Drawing.Point(51, 317)
        Me.AccountProductsDataGridView.Name = "AccountProductsDataGridView"
        Me.AccountProductsDataGridView.Size = New System.Drawing.Size(609, 256)
        Me.AccountProductsDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.ProductBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "Product_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "Product_Name"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Price"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Delivery_Rate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Delivery Rate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Flat_Rate"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Flat Rate"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Add_Edit_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(701, 664)
        Me.Controls.Add(Me.AccountProductsDataGridView)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Account_NameLabel)
        Me.Controls.Add(Me.PhoneMaskedTextBox)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.Account_NameTextBox)
        Me.Controls.Add(TaxableLabel)
        Me.Controls.Add(Me.TaxableCheckBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityComboBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipComboBox)
        Me.Controls.Add(TermsLabel)
        Me.Controls.Add(Me.TermsComboBox)
        Me.Controls.Add(Me.AccountBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Edit_Account"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountBindingNavigator.ResumeLayout(False)
        Me.AccountBindingNavigator.PerformLayout()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistinctCitiesFromZipCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistinctStatesFromZipCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistinctZipCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents AccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter
    Friend WithEvents AccountBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AccountBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Account_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ZipComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TermsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DistinctCitiesFromZipCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Distinct_Cities_From_Zip_CodeTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Distinct_Cities_From_Zip_CodeTableAdapter
    Friend WithEvents DistinctStatesFromZipCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Distinct_States_From_Zip_CodeTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Distinct_States_From_Zip_CodeTableAdapter
    Friend WithEvents DistinctZipCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Distinct_Zip_CodesTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Distinct_Zip_CodesTableAdapter
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Zip_CodesTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.Zip_CodesTableAdapter
    Friend WithEvents TaxableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents AccountProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountProductsTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.AccountProductsTableAdapter
    Friend WithEvents AccountProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
