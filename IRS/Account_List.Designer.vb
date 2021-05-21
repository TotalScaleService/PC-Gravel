<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboAccount = New System.Windows.Forms.ToolStripComboBox()
        Me.AccountDataGridView = New System.Windows.Forms.DataGridView()
        Me.HaulerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AccountTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter()
        Me.HaulerTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter()
        Me.EditBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Account_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Show_Price = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Show_Price_On_Ticket = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Default_Hauler = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Email_Ticket = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountBindingNavigator.SuspendLayout()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountBindingNavigator
        '
        Me.AccountBindingNavigator.AddNewItem = Nothing
        Me.AccountBindingNavigator.BindingSource = Me.AccountBindingSource
        Me.AccountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AccountBindingNavigator.DeleteItem = Nothing
        Me.AccountBindingNavigator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.tsEdit, Me.BindingNavigatorDeleteItem, Me.AccountBindingNavigatorSaveItem, Me.ToolStripLabel1, Me.cboAccount})
        Me.AccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AccountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AccountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AccountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AccountBindingNavigator.Name = "AccountBindingNavigator"
        Me.AccountBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.AccountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AccountBindingNavigator.Size = New System.Drawing.Size(823, 25)
        Me.AccountBindingNavigator.TabIndex = 0
        Me.AccountBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(81, 23)
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New Account"
        '
        'tsEdit
        '
        Me.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEdit.Image = Global.IRS.My.Resources.Resources.EditCodeHS
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(23, 22)
        Me.tsEdit.Text = "Edit Account"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete Account"
        '
        'AccountBindingNavigatorSaveItem
        '
        Me.AccountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AccountBindingNavigatorSaveItem.Image = CType(resources.GetObject("AccountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AccountBindingNavigatorSaveItem.Name = "AccountBindingNavigatorSaveItem"
        Me.AccountBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AccountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel1.Text = "Filter By Account"
        '
        'cboAccount
        '
        Me.cboAccount.DropDownHeight = 200
        Me.cboAccount.DropDownWidth = 200
        Me.cboAccount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccount.IntegralHeight = False
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(200, 25)
        '
        'AccountDataGridView
        '
        Me.AccountDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AccountDataGridView.AutoGenerateColumns = False
        Me.AccountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AccountDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AccountDataGridView.ColumnHeadersHeight = 45
        Me.AccountDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EditBtn, Me.Account_Name, Me.Show_Price, Me.Show_Price_On_Ticket, Me.Default_Hauler, Me.Email_Ticket, Me.Email})
        Me.AccountDataGridView.DataSource = Me.AccountBindingSource
        Me.AccountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountDataGridView.Location = New System.Drawing.Point(0, 92)
        Me.AccountDataGridView.Margin = New System.Windows.Forms.Padding(5)
        Me.AccountDataGridView.Name = "AccountDataGridView"
        Me.AccountDataGridView.Size = New System.Drawing.Size(823, 423)
        Me.AccountDataGridView.TabIndex = 0
        '
        'HaulerBindingSource
        '
        Me.HaulerBindingSource.DataMember = "Hauler"
        Me.HaulerBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 67)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(0, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(823, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(405, 41)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(23, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save and Close"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(225, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        '
        'AccountTableAdapter
        '
        Me.AccountTableAdapter.ClearBeforeFill = True
        '
        'HaulerTableAdapter
        '
        Me.HaulerTableAdapter.ClearBeforeFill = True
        '
        'EditBtn
        '
        Me.EditBtn.DataPropertyName = "EditBtn"
        Me.EditBtn.FillWeight = 20.0!
        Me.EditBtn.HeaderText = ""
        Me.EditBtn.MinimumWidth = 55
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.ReadOnly = True
        Me.EditBtn.Width = 55
        '
        'Account_Name
        '
        Me.Account_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Account_Name.DataPropertyName = "Account_Name"
        Me.Account_Name.HeaderText = "Customer Name"
        Me.Account_Name.MinimumWidth = 150
        Me.Account_Name.Name = "Account_Name"
        '
        'Show_Price
        '
        Me.Show_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Show_Price.DataPropertyName = "Show_Price"
        Me.Show_Price.FillWeight = 50.0!
        Me.Show_Price.HeaderText = "Show Price"
        Me.Show_Price.Name = "Show_Price"
        Me.Show_Price.Width = 94
        '
        'Show_Price_On_Ticket
        '
        Me.Show_Price_On_Ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Show_Price_On_Ticket.DataPropertyName = "Show_Price_On_Ticket"
        Me.Show_Price_On_Ticket.FillWeight = 50.0!
        Me.Show_Price_On_Ticket.HeaderText = "Show Price On Ticket"
        Me.Show_Price_On_Ticket.Name = "Show_Price_On_Ticket"
        Me.Show_Price_On_Ticket.Width = 123
        '
        'Default_Hauler
        '
        Me.Default_Hauler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Default_Hauler.DataPropertyName = "Default_Hauler"
        Me.Default_Hauler.DataSource = Me.HaulerBindingSource
        Me.Default_Hauler.DisplayMember = "Hauler_Name"
        Me.Default_Hauler.HeaderText = "Default Hauler"
        Me.Default_Hauler.Name = "Default_Hauler"
        Me.Default_Hauler.ValueMember = "Hauler_Name"
        Me.Default_Hauler.Visible = False
        Me.Default_Hauler.Width = 119
        '
        'Email_Ticket
        '
        Me.Email_Ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Email_Ticket.DataPropertyName = "Email_Ticket"
        Me.Email_Ticket.HeaderText = "Email Ticket"
        Me.Email_Ticket.Name = "Email_Ticket"
        Me.Email_Ticket.Width = 101
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 300
        Me.Email.Name = "Email"
        Me.Email.Width = 300
        '
        'Account_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.AccountDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AccountBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Account_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_List"
        CType(Me.AccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountBindingNavigator.ResumeLayout(False)
        Me.AccountBindingNavigator.PerformLayout()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HaulerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents AccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.AccountTableAdapter
    Friend WithEvents AccountBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents AccountDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboAccount As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents HaulerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HaulerTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.HaulerTableAdapter
    Friend WithEvents EditBtn As DataGridViewButtonColumn
    Friend WithEvents Account_Name As DataGridViewTextBoxColumn
    Friend WithEvents Show_Price As DataGridViewCheckBoxColumn
    Friend WithEvents Show_Price_On_Ticket As DataGridViewCheckBoxColumn
    Friend WithEvents Default_Hauler As DataGridViewComboBoxColumn
    Friend WithEvents Email_Ticket As DataGridViewCheckBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
End Class
