Imports System.Windows.Forms

Public Class Archive_Date_Range

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim SelectDate As Date = Me.MonthCalendar1.SelectionStart
        Dim ArchiveTableAdapter As New IRS_ScaleDataSetTableAdapters.ArchiveTableAdapter
        Try
            ArchiveTableAdapter.Archive_Transactions(SelectDate)
            MsgBox("Transactions Archived")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Archive_Date_Range_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MonthCalendar1.SetDate(Now)


    End Sub
End Class
