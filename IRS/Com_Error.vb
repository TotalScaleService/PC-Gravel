Public Class Com_Error

    Public Sub New(ByVal Message As String, ByVal ErrorMsg As String)

        ' This call is required by the designer.
        InitializeComponent()

        Label1.Text = Message
        Label2.Text = ErrorMsg

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class