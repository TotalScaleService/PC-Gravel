Imports System.Windows.Forms

Public Class Password

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.txtPass.Text = "123" Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.Label1.Text = "Invalid Password"
            Me.txtPass.Focus()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.GotFocus
        sender.backcolor = Color.Yellow
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.LostFocus
        sender.backcolor = Color.White
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub OK_Button_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.GotFocus, Cancel_Button.GotFocus
        sender.backcolor = Color.Yellow
    End Sub

    Private Sub Cancel_Button_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel_Button.LostFocus, OK_Button.LostFocus
        sender.backcolor = Me.BackColor
    End Sub
End Class
