Imports System.Windows.Forms

Public Class Apply_Price_Change
    Public Job As String
    Public Account As String
    Public Price As Double
    Public AccountPrice As Double
    Public JobPrice As Double
    Public ProductPrice As Double


    Public Enum RetVal
        job
        Account
        Ticket

    End Enum

    Public Response As RetVal

    Private FlatRateType As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(DeliveryPrice As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If DeliveryPrice = True Then

            Me.Label1.Text = "The Delivery Price Of" + vbCrLf + Format$(Price, "$0.00") + vbCrLf + "Will Be Applied To"

        Else

            FlatRateType = True

            If Price = 0 Then  'Flat Rate Charge is not applied
                Me.Label1.Text = "Apply a Calculated Delivery Charge To"
            Else
                Me.Label1.Text = "Apply a FLAT RATE Delivery Charge To"
            End If

        End If

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Apply_Price_Change_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BtnAccount.Visible = Not Me.Account = ""
        Me.BtnJob.Visible = Not Me.Job = ""
        Me.BtnAccount.Text = "This Account" + vbCrLf + Account
        Me.BtnJob.Text = "This Job" + vbCrLf + Job

        If FlatRateType = False Then

            Me.Label1.Text = "The Price Change Of" + vbCrLf + Format$(Price, "$0.00") + vbCrLf + "Will Be Applied To"
            Me.lblEnteredPrice.Text = Format$(Price, "$0.00")
            Me.lblProductPrice.Text = Format(ProductPrice, "$0.00")
            Me.lblAccountPrice.Text = Format$(AccountPrice, "$0.00")
            If JobPrice > -1 Then
                Me.lblJobPrice.Text = Format$(JobPrice, "$0.00")
            Else
                Me.lblJobPrice.Text = "No Entry"
            End If

        Else

            If Price = 0 Then
                Me.lblEnteredPrice.Text = "Use FLAT Delivery Rate"
            Else
                Me.lblEnteredPrice.Text = "Use Calculated Delivery Rate"
            End If

            If ProductPrice = 0 Then
                Me.lblProductPrice.Text = "Calculated"
            ElseIf ProductPrice = 1 Then
                Me.lblProductPrice.Text = "Flat"
            Else
                Me.lblProductPrice.Text = "No Entry"
            End If

            If AccountPrice = 0 Then
                Me.lblAccountPrice.Text = "Calculated"
            ElseIf AccountPrice = 1 Then
                Me.lblAccountPrice.Text = "Flat"
            Else
                Me.lblAccountPrice.Text = "No Entry"
            End If

            If JobPrice = 0 Then
                Me.lblJobPrice.Text = "Calculated"
            ElseIf JobPrice = 1 Then
                Me.lblJobPrice.Text = "Flat"
            Else
                Me.lblJobPrice.Text = "No Entry"
            End If

        End If

    End Sub

    Private Sub btnTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTicket.Click
        Me.Response = RetVal.Ticket
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Enter, btnTicket.Enter, BtnJob.Enter, BtnAccount.Enter
        sender.backcolor = Color.Lime

    End Sub

    Private Sub Button1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Leave, btnTicket.Leave, BtnJob.Leave, BtnAccount.Leave
        sender.backcolor = Color.WhiteSmoke
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJob.Click
        Me.Response = RetVal.job
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub BtnAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccount.Click
        Me.Response = RetVal.Account
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class
