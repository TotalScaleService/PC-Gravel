<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUpSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartUpSplashScreen))
        Me.ApplicationTitle = New System.Windows.Forms.Label
        Me.Version = New System.Windows.Forms.Label
        Me.Copyright = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.AliceBlue
        Me.ApplicationTitle.Location = New System.Drawing.Point(0, 0)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(573, 80)
        Me.ApplicationTitle.TabIndex = 1
        Me.ApplicationTitle.Text = "ApplicationTitle"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.AliceBlue
        Me.Version.Location = New System.Drawing.Point(30, 119)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(408, 40)
        Me.Version.TabIndex = 2
        Me.Version.Text = "Version {0}.{1:00}"
        '
        'Copyright
        '
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.AliceBlue
        Me.Copyright.Location = New System.Drawing.Point(45, 159)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(369, 21)
        Me.Copyright.TabIndex = 3
        Me.Copyright.Text = "Copyright"
        '
        'StartUpSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(573, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartUpSplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label

End Class
