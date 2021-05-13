Imports System.Windows.Forms

Public Class Warning_Box

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Enter, Cancel_Button.Enter
        sender.backcolor = Color.Lime

    End Sub


    Private Sub Button_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel_Button.Leave, OK_Button.Leave
        sender.backcolor = Me.BackColor
    End Sub
End Class
