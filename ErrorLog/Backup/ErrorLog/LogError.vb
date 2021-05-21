Imports System.IO
<System.Drawing.ToolboxBitmap("C:\Documents and Settings\Sean\My Documents\Customers\Controls\ErrorLog\ErrorLog\Warning.bmp")> _
Public Class LogError
    Public Event ErrorAdded(ByVal Errormsg As String)
    Public Event ErrorsFoundAtStartup()
    Public Shared Event ErrorsCleared()



    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()
        'This call is required by the Component Designer.
        InitializeComponent()
        Try
            Using sw As StreamWriter = New StreamWriter("ErrorLog.txt", True)
                sw.Close()
            End Using
            If HasErrors() Then
                RaiseEvent ErrorsFoundAtStartup()
            End If
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

    Public Function HasErrors() As Boolean
        If GetErrors.Trim <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Clear()
        Try
            Using sw As StreamWriter = New StreamWriter("ErrorLog.txt", False)
                sw.WriteLine("")
                sw.Close()
            End Using
        Catch ex As Exception
            MsgBox("Log Error " + ex.Message)
        End Try
    End Sub

    Public Sub ShowError()
        Dim ErrorReport As New Error_Report
        ErrorReport.ShowDialog()
        If GetErrors.Trim = "" Then
            RaiseEvent ErrorsCleared()
        End If
        ErrorReport = Nothing
        GC.Collect()
    End Sub

    Public Sub Save(ByVal Errormsg As String)
        Try

            Using sw As StreamWriter = New StreamWriter("ErrorLog.txt", True)
                sw.WriteLine(DateTime.Now + " " + Errormsg)
                sw.Close()
                RaiseEvent ErrorAdded(Errormsg)
            End Using
        Catch ex As Exception
            MsgBox("Log Error " + ex.Message)
        End Try
    End Sub


End Class
