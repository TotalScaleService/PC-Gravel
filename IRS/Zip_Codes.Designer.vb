<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zip_Codes
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zip_Codes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.IRS_ScaleDataSet = New IRS.IRS_ScaleDataSet
        Me.Zip_CodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Zip_CodesTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.Zip_CodesTableAdapter
        Me.Zip_CodesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Zip_CodesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Zip_CodesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.State = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatesTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.StatesTableAdapter
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zip_CodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zip_CodesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Zip_CodesBindingNavigator.SuspendLayout()
        CType(Me.Zip_CodesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(358, 456)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 45)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'IRS_ScaleDataSet
        '
        Me.IRS_ScaleDataSet.DataSetName = "IRS_ScaleDataSet"
        Me.IRS_ScaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Zip_CodesBindingSource
        '
        Me.Zip_CodesBindingSource.DataMember = "Zip_Codes"
        Me.Zip_CodesBindingSource.DataSource = Me.IRS_ScaleDataSet
        '
        'Zip_CodesTableAdapter
        '
        Me.Zip_CodesTableAdapter.ClearBeforeFill = True
        '
        'Zip_CodesBindingNavigator
        '
        Me.Zip_CodesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Zip_CodesBindingNavigator.BindingSource = Me.Zip_CodesBindingSource
        Me.Zip_CodesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Zip_CodesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Zip_CodesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Zip_CodesBindingNavigatorSaveItem})
        Me.Zip_CodesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Zip_CodesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Zip_CodesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Zip_CodesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Zip_CodesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Zip_CodesBindingNavigator.Name = "Zip_CodesBindingNavigator"
        Me.Zip_CodesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Zip_CodesBindingNavigator.Size = New System.Drawing.Size(621, 25)
        Me.Zip_CodesBindingNavigator.TabIndex = 1
        Me.Zip_CodesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'Zip_CodesBindingNavigatorSaveItem
        '
        Me.Zip_CodesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Zip_CodesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Zip_CodesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Zip_CodesBindingNavigatorSaveItem.Name = "Zip_CodesBindingNavigatorSaveItem"
        Me.Zip_CodesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Zip_CodesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Zip_CodesDataGridView
        '
        Me.Zip_CodesDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Zip_CodesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Zip_CodesDataGridView.AutoGenerateColumns = False
        Me.Zip_CodesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Zip_CodesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Zip_CodesDataGridView.ColumnHeadersHeight = 46
        Me.Zip_CodesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.State})
        Me.Zip_CodesDataGridView.DataSource = Me.Zip_CodesBindingSource
        Me.Zip_CodesDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.Zip_CodesDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Zip_CodesDataGridView.Name = "Zip_CodesDataGridView"
        Me.Zip_CodesDataGridView.Size = New System.Drawing.Size(621, 423)
        Me.Zip_CodesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Zip"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 59
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn2.HeaderText = "City"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 64
        '
        'State
        '
        Me.State.DataPropertyName = "State"
        Me.State.DataSource = Me.StatesBindingSource
        Me.State.DisplayMember = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.State.ValueMember = "State"
        Me.State.Width = 78
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
        'Zip_Codes
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(621, 519)
        Me.Controls.Add(Me.Zip_CodesDataGridView)
        Me.Controls.Add(Me.Zip_CodesBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Zip_Codes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Zip Codes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.IRS_ScaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zip_CodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zip_CodesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Zip_CodesBindingNavigator.ResumeLayout(False)
        Me.Zip_CodesBindingNavigator.PerformLayout()
        CType(Me.Zip_CodesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents IRS_ScaleDataSet As IRS.IRS_ScaleDataSet
    Friend WithEvents Zip_CodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Zip_CodesTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.Zip_CodesTableAdapter
    Friend WithEvents Zip_CodesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Zip_CodesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Zip_CodesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatesTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.StatesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
