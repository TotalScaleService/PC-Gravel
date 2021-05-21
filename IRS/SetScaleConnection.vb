Imports System.Windows.Forms

Public Class SetScaleConnection

    Dim WithEvents indicator As WeightIndicator
    Dim Comport As String



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Public Sub Connect(WeightIndicator As WeightIndicator, Scalecomport As String)
        indicator = WeightIndicator
        Comport = Scalecomport
        If Comport = "" Then

            indicator.Connect()

        Else

            indicator.Connect(Comport)

        End If
    End Sub

    Private Sub SetScaleConnection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub indicator_ChangingPort(ByVal NewPort As String) Handles indicator.ChangingPort

        Me.Label1.Text = NewPort

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub indicator_FoundScale(ByVal Port As String) Handles indicator.FoundScale

        Me.BackColor = Color.Lime
        Me.Label1.Text = Port
        Me.Timer1.Start()

    End Sub

End Class
