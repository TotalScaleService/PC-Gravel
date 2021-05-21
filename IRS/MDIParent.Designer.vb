<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlWeights = New System.Windows.Forms.Panel()
        Me.btnChangeLight = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnScaleSelect = New System.Windows.Forms.Button()
        Me.lblSelectScale = New System.Windows.Forms.Label()
        Me.btnSplitAgain = New System.Windows.Forms.Button()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpStored3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStored3 = New System.Windows.Forms.Label()
        Me.grpStored2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStored2 = New System.Windows.Forms.Label()
        Me.grpStored1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStored1 = New System.Windows.Forms.Label()
        Me.grpScaleWeight = New System.Windows.Forms.GroupBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblMotion = New System.Windows.Forms.Label()
        Me.btnSplitWeigh = New System.Windows.Forms.Button()
        Me.btnLockWeight = New System.Windows.Forms.Button()
        Me.btnManualWeight = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.HSSimulate = New System.Windows.Forms.HScrollBar()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tmrMotion = New System.Windows.Forms.Timer(Me.components)
        Me.TrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IrS_ScaleDataSet1 = New IRS.IRS_ScaleDataSet()
        Me.SetupTableAdapter1 = New IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter()
        Me.TrucksTableAdapter = New IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter()
        Me.StatusStrip.SuspendLayout()
        Me.pnlWeights.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotal.SuspendLayout()
        Me.grpStored3.SuspendLayout()
        Me.grpStored2.SuspendLayout()
        Me.grpStored1.SuspendLayout()
        Me.grpScaleWeight.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IrS_ScaleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 712)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 24, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        Me.StatusStrip.Visible = False
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'pnlWeights
        '
        Me.pnlWeights.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlWeights.Controls.Add(Me.btnChangeLight)
        Me.pnlWeights.Controls.Add(Me.PictureBox1)
        Me.pnlWeights.Controls.Add(Me.btnScaleSelect)
        Me.pnlWeights.Controls.Add(Me.lblSelectScale)
        Me.pnlWeights.Controls.Add(Me.btnSplitAgain)
        Me.pnlWeights.Controls.Add(Me.grpTotal)
        Me.pnlWeights.Controls.Add(Me.grpStored3)
        Me.pnlWeights.Controls.Add(Me.grpStored2)
        Me.pnlWeights.Controls.Add(Me.grpStored1)
        Me.pnlWeights.Controls.Add(Me.grpScaleWeight)
        Me.pnlWeights.Controls.Add(Me.btnSplitWeigh)
        Me.pnlWeights.Controls.Add(Me.btnLockWeight)
        Me.pnlWeights.Controls.Add(Me.btnManualWeight)
        Me.pnlWeights.Controls.Add(Me.ZeroButton)
        Me.pnlWeights.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlWeights.Location = New System.Drawing.Point(0, 51)
        Me.pnlWeights.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlWeights.Name = "pnlWeights"
        Me.pnlWeights.Size = New System.Drawing.Size(1264, 73)
        Me.pnlWeights.TabIndex = 9
        '
        'btnChangeLight
        '
        Me.btnChangeLight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChangeLight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeLight.Location = New System.Drawing.Point(1157, 7)
        Me.btnChangeLight.Name = "btnChangeLight"
        Me.btnChangeLight.Size = New System.Drawing.Size(60, 59)
        Me.btnChangeLight.TabIndex = 72
        Me.btnChangeLight.Text = "Change Light"
        Me.btnChangeLight.UseVisualStyleBackColor = False
        Me.btnChangeLight.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1090, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 59)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btnScaleSelect
        '
        Me.btnScaleSelect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScaleSelect.Location = New System.Drawing.Point(12, 29)
        Me.btnScaleSelect.Name = "btnScaleSelect"
        Me.btnScaleSelect.Size = New System.Drawing.Size(139, 33)
        Me.btnScaleSelect.TabIndex = 70
        Me.btnScaleSelect.Text = "Little Scale"
        Me.btnScaleSelect.UseVisualStyleBackColor = True
        '
        'lblSelectScale
        '
        Me.lblSelectScale.AutoSize = True
        Me.lblSelectScale.Location = New System.Drawing.Point(27, 7)
        Me.lblSelectScale.Name = "lblSelectScale"
        Me.lblSelectScale.Size = New System.Drawing.Size(125, 24)
        Me.lblSelectScale.TabIndex = 69
        Me.lblSelectScale.Text = "Select Scale"
        '
        'btnSplitAgain
        '
        Me.btnSplitAgain.BackColor = System.Drawing.SystemColors.Control
        Me.btnSplitAgain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitAgain.Location = New System.Drawing.Point(275, 21)
        Me.btnSplitAgain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSplitAgain.Name = "btnSplitAgain"
        Me.btnSplitAgain.Size = New System.Drawing.Size(112, 28)
        Me.btnSplitAgain.TabIndex = 68
        Me.btnSplitAgain.TabStop = False
        Me.btnSplitAgain.Text = "Split Again"
        Me.btnSplitAgain.UseVisualStyleBackColor = False
        Me.btnSplitAgain.Visible = False
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.Label4)
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotal.Location = New System.Drawing.Point(916, 3)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(134, 63)
        Me.grpTotal.TabIndex = 67
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Total Weight"
        Me.grpTotal.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 25)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(29, 18)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 29)
        Me.lblTotal.TabIndex = 58
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpStored3
        '
        Me.grpStored3.Controls.Add(Me.Label3)
        Me.grpStored3.Controls.Add(Me.lblStored3)
        Me.grpStored3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStored3.Location = New System.Drawing.Point(782, 3)
        Me.grpStored3.Name = "grpStored3"
        Me.grpStored3.Size = New System.Drawing.Size(134, 63)
        Me.grpStored3.TabIndex = 65
        Me.grpStored3.TabStop = False
        Me.grpStored3.Text = "Stored Weight #3"
        Me.grpStored3.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 25)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "+"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStored3
        '
        Me.lblStored3.BackColor = System.Drawing.Color.White
        Me.lblStored3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStored3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStored3.Location = New System.Drawing.Point(29, 18)
        Me.lblStored3.Name = "lblStored3"
        Me.lblStored3.Size = New System.Drawing.Size(99, 29)
        Me.lblStored3.TabIndex = 58
        Me.lblStored3.Text = "0"
        Me.lblStored3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpStored2
        '
        Me.grpStored2.Controls.Add(Me.Label2)
        Me.grpStored2.Controls.Add(Me.lblStored2)
        Me.grpStored2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStored2.Location = New System.Drawing.Point(648, 3)
        Me.grpStored2.Name = "grpStored2"
        Me.grpStored2.Size = New System.Drawing.Size(134, 63)
        Me.grpStored2.TabIndex = 66
        Me.grpStored2.TabStop = False
        Me.grpStored2.Text = "Stored Weight #2"
        Me.grpStored2.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 25)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "+"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStored2
        '
        Me.lblStored2.BackColor = System.Drawing.Color.White
        Me.lblStored2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStored2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStored2.Location = New System.Drawing.Point(29, 18)
        Me.lblStored2.Name = "lblStored2"
        Me.lblStored2.Size = New System.Drawing.Size(99, 29)
        Me.lblStored2.TabIndex = 58
        Me.lblStored2.Text = "0"
        Me.lblStored2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpStored1
        '
        Me.grpStored1.Controls.Add(Me.Label1)
        Me.grpStored1.Controls.Add(Me.lblStored1)
        Me.grpStored1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStored1.Location = New System.Drawing.Point(514, 3)
        Me.grpStored1.Name = "grpStored1"
        Me.grpStored1.Size = New System.Drawing.Size(134, 63)
        Me.grpStored1.TabIndex = 65
        Me.grpStored1.TabStop = False
        Me.grpStored1.Text = "Stored Weight #1"
        Me.grpStored1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "+"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStored1
        '
        Me.lblStored1.BackColor = System.Drawing.Color.White
        Me.lblStored1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStored1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStored1.Location = New System.Drawing.Point(28, 18)
        Me.lblStored1.Name = "lblStored1"
        Me.lblStored1.Size = New System.Drawing.Size(99, 29)
        Me.lblStored1.TabIndex = 58
        Me.lblStored1.Text = "0"
        Me.lblStored1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpScaleWeight
        '
        Me.grpScaleWeight.Controls.Add(Me.lblWeight)
        Me.grpScaleWeight.Controls.Add(Me.lblMotion)
        Me.grpScaleWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpScaleWeight.Location = New System.Drawing.Point(402, 3)
        Me.grpScaleWeight.Name = "grpScaleWeight"
        Me.grpScaleWeight.Size = New System.Drawing.Size(112, 63)
        Me.grpScaleWeight.TabIndex = 64
        Me.grpScaleWeight.TabStop = False
        Me.grpScaleWeight.Text = "Scale Weight"
        '
        'lblWeight
        '
        Me.lblWeight.BackColor = System.Drawing.Color.White
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeight.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(7, 18)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(99, 29)
        Me.lblWeight.TabIndex = 58
        Me.lblWeight.Text = "0"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMotion
        '
        Me.lblMotion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblMotion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotion.ForeColor = System.Drawing.Color.Red
        Me.lblMotion.Location = New System.Drawing.Point(15, 47)
        Me.lblMotion.Name = "lblMotion"
        Me.lblMotion.Size = New System.Drawing.Size(83, 13)
        Me.lblMotion.TabIndex = 29
        Me.lblMotion.Text = "Motion"
        Me.lblMotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSplitWeigh
        '
        Me.btnSplitWeigh.BackColor = System.Drawing.SystemColors.Control
        Me.btnSplitWeigh.Enabled = False
        Me.btnSplitWeigh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitWeigh.Location = New System.Drawing.Point(275, 3)
        Me.btnSplitWeigh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSplitWeigh.Name = "btnSplitWeigh"
        Me.btnSplitWeigh.Size = New System.Drawing.Size(112, 28)
        Me.btnSplitWeigh.TabIndex = 55
        Me.btnSplitWeigh.TabStop = False
        Me.btnSplitWeigh.Text = "Straight Weigh"
        Me.btnSplitWeigh.UseVisualStyleBackColor = False
        '
        'btnLockWeight
        '
        Me.btnLockWeight.BackColor = System.Drawing.SystemColors.Control
        Me.btnLockWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLockWeight.Location = New System.Drawing.Point(275, 35)
        Me.btnLockWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLockWeight.Name = "btnLockWeight"
        Me.btnLockWeight.Size = New System.Drawing.Size(112, 28)
        Me.btnLockWeight.TabIndex = 52
        Me.btnLockWeight.TabStop = False
        Me.btnLockWeight.Text = "Lock Weight"
        Me.btnLockWeight.UseVisualStyleBackColor = False
        '
        'btnManualWeight
        '
        Me.btnManualWeight.BackColor = System.Drawing.SystemColors.Control
        Me.btnManualWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManualWeight.Location = New System.Drawing.Point(157, 35)
        Me.btnManualWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnManualWeight.Name = "btnManualWeight"
        Me.btnManualWeight.Size = New System.Drawing.Size(112, 28)
        Me.btnManualWeight.TabIndex = 30
        Me.btnManualWeight.TabStop = False
        Me.btnManualWeight.Text = "Enter Weight"
        Me.btnManualWeight.UseVisualStyleBackColor = False
        Me.btnManualWeight.Visible = False
        '
        'ZeroButton
        '
        Me.ZeroButton.BackColor = System.Drawing.SystemColors.Control
        Me.ZeroButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZeroButton.Location = New System.Drawing.Point(157, 3)
        Me.ZeroButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(112, 28)
        Me.ZeroButton.TabIndex = 31
        Me.ZeroButton.TabStop = False
        Me.ZeroButton.Text = "Zero Scale"
        Me.ZeroButton.UseVisualStyleBackColor = False
        '
        'HSSimulate
        '
        Me.HSSimulate.Dock = System.Windows.Forms.DockStyle.Top
        Me.HSSimulate.LargeChange = 4
        Me.HSSimulate.Location = New System.Drawing.Point(0, 34)
        Me.HSSimulate.Maximum = 200
        Me.HSSimulate.Name = "HSSimulate"
        Me.HSSimulate.Size = New System.Drawing.Size(1264, 17)
        Me.HSSimulate.TabIndex = 11
        Me.HSSimulate.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.SetupToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(58, 28)
        Me.FileMenu.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.SetupToolStripMenuItem.Text = "System Setup"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(68, 28)
        Me.HelpMenu.Text = "&Help"
        Me.HelpMenu.Visible = False
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(262, 28)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(262, 28)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(262, 28)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(259, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(262, 28)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1264, 34)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'tmrMotion
        '
        Me.tmrMotion.Interval = 500
        '
        'TrucksBindingSource
        '
        Me.TrucksBindingSource.DataMember = "Trucks"
        Me.TrucksBindingSource.DataSource = Me.IrS_ScaleDataSet1
        '
        'IrS_ScaleDataSet1
        '
        Me.IrS_ScaleDataSet1.DataSetName = "IRS_ScaleDataSet"
        Me.IrS_ScaleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SetupTableAdapter1
        '
        Me.SetupTableAdapter1.ClearBeforeFill = True
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'MDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 762)
        Me.Controls.Add(Me.pnlWeights)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.HSSimulate)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MDIParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC-Gravel"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.pnlWeights.ResumeLayout(False)
        Me.pnlWeights.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotal.ResumeLayout(False)
        Me.grpStored3.ResumeLayout(False)
        Me.grpStored2.ResumeLayout(False)
        Me.grpStored1.ResumeLayout(False)
        Me.grpScaleWeight.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IrS_ScaleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents IrS_ScaleDataSet1 As IRS.IRS_ScaleDataSet
    Friend WithEvents SetupTableAdapter1 As IRS.IRS_ScaleDataSetTableAdapters.SetupTableAdapter
    Friend WithEvents pnlWeights As System.Windows.Forms.Panel
    Friend WithEvents ZeroButton As System.Windows.Forms.Button
    Friend WithEvents btnManualWeight As System.Windows.Forms.Button
    Friend WithEvents lblMotion As System.Windows.Forms.Label
    Friend WithEvents btnLockWeight As System.Windows.Forms.Button
    Friend WithEvents btnSplitWeigh As System.Windows.Forms.Button
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As IRS.IRS_ScaleDataSetTableAdapters.TrucksTableAdapter
    Friend WithEvents grpScaleWeight As System.Windows.Forms.GroupBox
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grpStored3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStored3 As System.Windows.Forms.Label
    Friend WithEvents grpStored2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStored2 As System.Windows.Forms.Label
    Friend WithEvents grpStored1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStored1 As System.Windows.Forms.Label
    Friend WithEvents btnSplitAgain As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tmrMotion As System.Windows.Forms.Timer
    Friend WithEvents btnScaleSelect As Button
    Friend WithEvents lblSelectScale As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnChangeLight As Button
    Friend WithEvents HSSimulate As HScrollBar
End Class
