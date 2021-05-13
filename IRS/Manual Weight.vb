Imports System.Windows.Forms

Public Class Manual_Weight

    Public CurVal As Integer

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Manual_Weight_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If CurVal < Me.numManual_Weight.Minimum Then CurVal = Me.numManual_Weight.Minimum
        If CurVal > Me.numManual_Weight.Maximum Then CurVal = Me.numManual_Weight.Maximum
        Me.numManual_Weight.Value = CurVal
        Me.numManual_Weight.Select(0, Len(Me.numManual_Weight.Value.ToString))
        Me.numManual_Weight.Focus()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim I As Integer = Me.numManual_Weight.Value
        I = I / 20
        I = I * 20
        Me.numManual_Weight.Value = I
    End Sub

    Private Sub Manual_Weight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
