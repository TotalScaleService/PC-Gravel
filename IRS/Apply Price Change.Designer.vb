<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apply_Price_Change
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTicket = New System.Windows.Forms.Button()
        Me.BtnJob = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEnteredPrice = New System.Windows.Forms.Label()
        Me.lblAccountPrice = New System.Windows.Forms.Label()
        Me.lblJobPrice = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Changes To The Price Will Apply To"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTicket
        '
        Me.btnTicket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicket.Location = New System.Drawing.Point(363, 101)
        Me.btnTicket.Name = "btnTicket"
        Me.btnTicket.Size = New System.Drawing.Size(329, 68)
        Me.btnTicket.TabIndex = 0
        Me.btnTicket.Text = "Just This Ticket"
        Me.btnTicket.UseVisualStyleBackColor = False
        '
        'BtnJob
        '
        Me.BtnJob.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJob.Location = New System.Drawing.Point(363, 253)
        Me.BtnJob.Name = "BtnJob"
        Me.BtnJob.Size = New System.Drawing.Size(329, 68)
        Me.BtnJob.TabIndex = 2
        Me.BtnJob.Text = "Just This Job"
        Me.BtnJob.UseVisualStyleBackColor = False
        '
        'BtnAccount
        '
        Me.BtnAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccount.Location = New System.Drawing.Point(363, 177)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(329, 68)
        Me.BtnAccount.TabIndex = 1
        Me.BtnAccount.Text = "Just This Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12345"
        Me.BtnAccount.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(363, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 68)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel Price Changes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price Entered :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Account Price :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Job Price :"
        '
        'lblEnteredPrice
        '
        Me.lblEnteredPrice.AutoSize = True
        Me.lblEnteredPrice.Location = New System.Drawing.Point(205, 119)
        Me.lblEnteredPrice.Name = "lblEnteredPrice"
        Me.lblEnteredPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblEnteredPrice.TabIndex = 7
        Me.lblEnteredPrice.Text = "$3.60"
        '
        'lblAccountPrice
        '
        Me.lblAccountPrice.AutoSize = True
        Me.lblAccountPrice.Location = New System.Drawing.Point(205, 271)
        Me.lblAccountPrice.Name = "lblAccountPrice"
        Me.lblAccountPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblAccountPrice.TabIndex = 8
        Me.lblAccountPrice.Text = "$3.50"
        '
        'lblJobPrice
        '
        Me.lblJobPrice.AutoSize = True
        Me.lblJobPrice.Location = New System.Drawing.Point(205, 347)
        Me.lblJobPrice.Name = "lblJobPrice"
        Me.lblJobPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblJobPrice.TabIndex = 9
        Me.lblJobPrice.Text = "$3.45"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(205, 195)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(76, 29)
        Me.lblProductPrice.TabIndex = 11
        Me.lblProductPrice.Text = "$3.50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Product Price :"
        '
        'Apply_Price_Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(704, 420)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblJobPrice)
        Me.Controls.Add(Me.lblAccountPrice)
        Me.Controls.Add(Me.lblEnteredPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAccount)
        Me.Controls.Add(Me.BtnJob)
        Me.Controls.Add(Me.btnTicket)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Apply_Price_Change"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apply_Price_Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTicket As System.Windows.Forms.Button
    Friend WithEvents BtnJob As System.Windows.Forms.Button
    Friend WithEvents BtnAccount As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEnteredPrice As Label
    Friend WithEvents lblAccountPrice As Label
    Friend WithEvents lblJobPrice As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents Label6 As Label
End Class
