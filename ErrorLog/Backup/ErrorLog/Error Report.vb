Imports System.Windows.Forms
Imports System.IO

Public Class Error_Report
    Private Sub Error_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RichTextBox1.Text = GetErrors()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClearLogErrors()
        Me.RichTextBox1.Text = GetErrors()

    End Sub



    Public Sub ClearLogErrors()
        Try
            Using sw As StreamWriter = New StreamWriter("ErrorLog.txt", False)
                sw.WriteLine("")
                sw.Close()
            End Using
        Catch ex As Exception
            MsgBox("Log Error " + ex.Message)
        End Try
    End Sub

    Public Function GetErrors() As String
        Dim Errors As String = ""
        Try
            ' Create an instance of StreamReader to read from a file.
            Using sr As StreamReader = New StreamReader("ErrorLog.txt")
                Dim line As String
                ' Read and display the lines from the file until the end 
                ' of the file is reached.
                Do
                    line = sr.ReadLine()
                    Errors += line + vbCrLf
                Loop Until line Is Nothing
                sr.Close()
            End Using
        Catch E As Exception
            ' Let the user know what went wrong.
            Errors = "The file could not be read:" + E.Message
        End Try
        Return Errors
    End Function
End Class
