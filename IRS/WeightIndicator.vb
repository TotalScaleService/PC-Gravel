Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text



Public Class WeightIndicator
    Dim WithEvents UpdateTimer As New Windows.Forms.Timer
    Dim WithEvents tmrCheckScaleConnection As New Windows.Forms.Timer
    Dim WithEvents tmrMotionUpdate As New Windows.Forms.Timer
    Dim WithEvents ScalePort As New System.IO.Ports.SerialPort
    Dim WithEvents ScalePort2 As New System.IO.Ports.SerialPort
    Dim WithEvents tmrTryPort As New Windows.Forms.Timer

    Public PauseSerial As Boolean = False
    Public PlayAlarm As Boolean = False
    Public ComPort As String = ""

    Public Enum Scaletype
        Simulate
        Serial
        Network
    End Enum

    Public Enum ScaleStatus
        NotConnected
        CommError
        Motion
        Ok
        OutOfRange
    End Enum


    Public Structure ScaleData
        Dim IndicatorType As Scaletype
        Dim Weight As Long
        Dim Status As ScaleStatus
        Dim StatusString As String
        Dim Units As String
    End Structure


    Private Const ScaleMotion As String = "Motion"
    Private Const ScaleComError As String = "Comm Error"
    Private Const ScaleOk As String = ""
    Private Const ScaleOutOfRange As String = "Out Of Range"
    Private Const ScaleNotConnected As String = "Not Connected"


    Private ConnectionState As String

    Private DataString As String

    Private Instring As String ' Incomming String From The Scale
    Private ScaleInformation As ScaleData


    Event DataRecieved(ByVal RecievedString As String)
    Event Weight_Change(ByVal Data As ScaleData, ByVal Simulate As Boolean)
    Event ChangingPort(ByVal NewPort As String)
    Event FoundScale(ByVal Port As String)


    Public Sub New()
        Try
            UpdateTimer.Enabled = True
            UpdateTimer.Interval = 500
            Me.tmrCheckScaleConnection.Interval = 5000
            UpdateTimer.Start()

            Me.tmrCheckScaleConnection.Start()
            Me.ScalePort.BaudRate = 9600
            Me.ScalePort.NewLine = Chr(10)
            Me.ScaleInformation.IndicatorType = Scaletype.Simulate
            ScaleInformation.Weight = 0
            ScaleInformation.Status = ScaleStatus.Ok

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Property ConnectionType() As Scaletype
        Get
            ConnectionType = Me.ScaleInformation.IndicatorType
        End Get
        Set(ByVal value As Scaletype)
            If Me.ScaleInformation.IndicatorType <> value Then
                Me.ScaleInformation.IndicatorType = value
                If Me.ScaleInformation.IndicatorType = Scaletype.Simulate Then
                    Me.tmrTryPort.Stop()

                End If

            End If

        End Set
    End Property






    Public Property CommPort()
        Get
            CommPort = Me.ScalePort.PortName
        End Get
        Set(ByVal value)
            If value = "" Then Exit Property
            If Me.ScaleInformation.IndicatorType = Scaletype.Serial Then
                Try
                    If Me.ScalePort.IsOpen Then
                        Me.ScalePort.Close()
                    End If
                    Me.ScalePort.PortName = value
                    Me.ScalePort.Open()
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    Dim ComError As New Com_Error("Unable to open Port: " + value, ex.Message)
                    ComError.ShowDialog()

                    ComError.Close()

                End Try
            End If
        End Set
    End Property


    Private Function StatusString(ByVal Status As ScaleStatus) As String
        Select Case (Status)
            Case ScaleStatus.Motion
                StatusString = ScaleMotion
            Case ScaleStatus.Ok
                StatusString = ScaleOk
            Case ScaleStatus.OutOfRange
                StatusString = ScaleOutOfRange
            Case ScaleStatus.CommError
                StatusString = ScaleComError
            Case ScaleStatus.NotConnected
                StatusString = ScaleNotConnected
            Case Else
                StatusString = ScaleOk
        End Select
    End Function


    Public Sub Connect()
        If Me.ComPort.Trim <> "" Then Exit Sub
        Me.ScaleInformation.IndicatorType = Scaletype.Serial
        Static OriginalPort As String = Me.ScalePort.PortName
        If My.Computer.Ports.SerialPortNames.Count = 0 Then
            RaiseEvent ChangingPort("No Valid Serial Ports To Connect To")
            Exit Sub
        End If
        If Me.ScalePort.IsOpen Then Me.ScalePort.Close()
        If My.Computer.Ports.SerialPortNames.Count = 1 Then
            Me.ScalePort.PortName = My.Computer.Ports.SerialPortNames(0)
            Try
                Me.ScalePort.Open()
                RaiseEvent ChangingPort("Attempting to connect to scale on port " + My.Computer.Ports.SerialPortNames(0))
            Catch ex As Exception
                RaiseEvent ChangingPort(My.Computer.Ports.SerialPortNames(0) + " Error " + ex.Message)
            End Try

        End If
        Static LastCheckedPort As Integer

        If LastCheckedPort >= My.Computer.Ports.SerialPortNames.Count Then
            LastCheckedPort = 0
        End If


        Dim PortToCheck As Integer

        For PortToCheck = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            If PortToCheck < LastCheckedPort Then PortToCheck = LastCheckedPort + 1
            If PortToCheck >= My.Computer.Ports.SerialPortNames.Count Then PortToCheck = 0
            LastCheckedPort = PortToCheck
            Dim portName As String = My.Computer.Ports.SerialPortNames.Item(PortToCheck)
            If OriginalPort <> portName Then
                Me.ScalePort.PortName = portName
                Try

                    RaiseEvent ChangingPort("Attempting to connect to scale on port " + portName)
                    ' My.Application.DoEvents()
                    Me.ScalePort.Open()
                    Me.ScalePort.DiscardInBuffer()
                    Instring = ""
                    Me.tmrTryPort.Interval = 2000
                    Me.tmrTryPort.Start()
                    Exit For
                Catch ex As Exception
                End Try

            End If
        Next
        OriginalPort = Me.ScalePort.PortName
    End Sub


    Public Sub Connect(Comm_Port as String )
        Me.ScaleInformation.IndicatorType = Scaletype.Serial
        Static OriginalPort As String = Comm_Port
        If My.Computer.Ports.SerialPortNames.Count = 0 Then
            RaiseEvent ChangingPort("No Valid Serial Ports To Connect To")
            Exit Sub
        End If
        If Me.ScalePort.IsOpen Then Me.ScalePort.Close()

        Me.ScalePort.PortName = Comm_Port
        Try
            Me.ScalePort.Open()
            RaiseEvent ChangingPort("Attempting to connect to scale on port " + CommPort)
        Catch ex As Exception
            RaiseEvent ChangingPort(My.Computer.Ports.SerialPortNames(0) + " Error " + ex.Message)
        End Try
    End Sub

    ' Original Routine by Sean - This will work for a manual Condec created by ZM scales
    'Private Sub UpdateTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateTimer.Tick
    '    Static OldWeight As Double
    '    Static OldStatus As ScaleStatus

    '    Dim Weight As Double
    '    Dim Status As ScaleStatus
    '    Debug.Print("Instring " + Instring)
    '    Debug.Print(Me.ScalePort.IsOpen)
    '    If Me.ScaleInformation.IndicatorType <> Scaletype.Simulate And Me.PauseSerial = False Then
    '        Dim Location As Integer
    '        Dim WeightString As String = ""
    '        Location = InStr(Instring, "G")
    '        If Instring.Length < 7 Or Location = 0 Then Exit Sub
    '        Dim Wt As Array = Instring.ToCharArray

    '        For Each OneChar As Char In Wt
    '            Dim I As Integer
    '            If Integer.TryParse(OneChar, I) Then
    '                WeightString += I.ToString

    '            End If
    '        Next

    '        If InStr(WeightString, "__") > 0 Or InStr(WeightString, "--") _
    '        Or InStr(Instring, "O") > 0 Or InStr(Instring, "I") Then
    '            Status = ScaleStatus.OutOfRange
    '            Weight = 0
    '        Else
    '            If InStr(Instring, "K") > 0 Then
    '                ScaleInformation.Units = "kgs."
    '            ElseIf InStr(Instring, "L") > 0 Then
    '                ScaleInformation.Units = "lbs."
    '            End If

    '            Try
    '                Weight = CType(WeightString, Double)
    '                If InStr(Instring, "-") > 0 Then Weight = Weight * -1
    '                If InStr(Instring, "M") Then
    '                    Status = ScaleStatus.Motion
    '                Else
    '                    Status = ScaleStatus.Ok
    '                End If

    '                RaiseEvent FoundScale("Sucessfully Connected To Port " + Me.ScalePort.PortName)


    '                Me.tmrTryPort.Stop()

    '            Catch ex As Exception
    '                Status = ScaleStatus.CommError
    '                Weight = 0
    '            End Try
    '            Me.ScaleInformation.Weight = Weight
    '        End If
    '        Me.ScaleInformation.Status = Status
    '        Me.ScaleInformation.StatusString = StatusString(Status)

    '        If Weight > 2000 And PlayAlarm = False Then
    '            If My.Settings.PlayAudio <> "" Then
    '                My.Computer.Audio.Play(My.Settings.PlayAudio)
    '                PlayAlarm = True
    '            End If

    '        ElseIf Weight < 500 Then
    '            My.Computer.Audio.Stop()
    '            PlayAlarm = False
    '        End If

    '    End If
    '    'If Weight <> OldWeight Or OldStatus <> Status Then
    '    RaiseEvent Weight_Change(Me.ScaleInformation, False)
    '    'End If
    '    OldWeight = Weight
    '    OldStatus = Status

    '    'If Me.ScalePort.IsOpen Then Me.ScalePort.WriteLine(Instring)
    '    Me.tmrCheckScaleConnection.Stop()
    '    Me.tmrCheckScaleConnection.Start()
    '    Instring = ""

    'End Sub


    ' Routine by Matt - This should pickup most codec strings.  Had issues with ZM scales and used above routine for them.
    Private Sub UpdateTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateTimer.Tick

        Static OldWeight As Double
        Static OldStatus As ScaleStatus

        Dim Weight As Double
        Dim Status As ScaleStatus

        If Me.ScaleInformation.IndicatorType <> Scaletype.Simulate And Me.PauseSerial = False Then
            Dim Location As Integer
            Dim WeightString As String
            Location = InStr(Instring, Chr(2))
            If Instring = "" Or Location = 0 Then Exit Sub
            WeightString = Trim(Mid(Instring, Location + 2, 7))
            If InStr(WeightString, "__") > 0 Or InStr(WeightString, "--") _
            Or InStr(Instring, "O") > 0 Or InStr(Instring, "I") Then
                Status = ScaleStatus.OutOfRange
                Weight = 0
            Else
                If InStr(Instring, "K") > 0 Then
                    ScaleInformation.Units = "kgs."
                ElseIf InStr(Instring, "L") > 0 Then
                    ScaleInformation.Units = "lbs."
                End If

                Try
                    Weight = CType(WeightString, Double)
                    If InStr(Instring, "-") > 0 Then Weight = Weight * -1
                    If InStr(Instring, "M") Then
                        Status = ScaleStatus.Motion
                    Else
                        Status = ScaleStatus.Ok
                    End If

                    RaiseEvent FoundScale("Sucessfully Connected To Port " + Me.ScalePort.PortName)


                    Me.tmrTryPort.Stop()

                Catch ex As Exception
                    MsgBox("Com Error = " + ex.Message)
                    Status = ScaleStatus.CommError
                    Weight = 0
                End Try
                Me.ScaleInformation.Weight = Weight
            End If
            Me.ScaleInformation.Status = Status
            Me.ScaleInformation.StatusString = StatusString(Status)

            If Weight > 2000 And PlayAlarm = False Then
                If My.Settings.PlayAudio <> "" Then
                    My.Computer.Audio.Play(My.Settings.PlayAudio)
                    PlayAlarm = True
                End If

            ElseIf Weight < 500 Then
                My.Computer.Audio.Stop()
                PlayAlarm = False
            End If

        End If
        'If Weight <> OldWeight Or OldStatus <> Status Then
        RaiseEvent Weight_Change(Me.ScaleInformation, False)
        'End If
        OldWeight = Weight
        OldStatus = Status

        'If Me.ScalePort.IsOpen Then Me.ScalePort.WriteLine(Instring)
        Me.tmrCheckScaleConnection.Stop()
        Me.tmrCheckScaleConnection.Start()
        Instring = ""

    End Sub



    Public WriteOnly Property CheckConnection() As Boolean
        Set(ByVal value As Boolean)
            Me.tmrCheckScaleConnection.Enabled = value
        End Set
    End Property


    Public Sub SimulateDataRecieved(ByVal Weight As Long, ByVal status As ScaleStatus)
        Me.ScaleInformation.Weight = Weight
        Me.ScaleInformation.Status = status
        Me.ScaleInformation.StatusString = StatusString(status)
        Me.tmrMotionUpdate.Interval = 1500
        Me.tmrMotionUpdate.Start()
        RaiseEvent Weight_Change(Me.ScaleInformation, True)
    End Sub


    Public Sub SimulateStatusChange(ByVal status As ScaleStatus)

        Me.ScaleInformation.Status = status
        Me.ScaleInformation.StatusString = StatusString(status)
        RaiseEvent Weight_Change(Me.ScaleInformation, True)

    End Sub


    Private Sub ScalePort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles ScalePort.DataReceived

        If Me.PauseSerial Then Exit Sub

        Try

            If Me.ScalePort.IsOpen Then

                Me.Instring = Me.ScalePort.ReadLine
                Dim CleanString As String = Me.ScalePort.ReadExisting()
            End If

        Catch ex As Exception
            'MsgBox("Scale Error" + ex.Message)
        End Try

    End Sub


    Public Sub ZeroScale()
        If Me.ScaleInformation.IndicatorType = Scaletype.Simulate Then
            SimulateDataRecieved(0, ScaleStatus.Ok)
        ElseIf Me.ScaleInformation.IndicatorType = Scaletype.Serial Then
            Me.ScalePort.Write("K")
            Me.ScalePort.Write("Z")
            Me.ScalePort.Write("E")
            Me.ScalePort.Write("R")
            Me.ScalePort.Write("O")
            Me.ScalePort.Write(Chr(13))
            Me.ScalePort.Write(Chr(10))
        End If

    End Sub

    Public Sub ClosePort()
        If Me.ScalePort.IsOpen Then Me.ScalePort.Close()
    End Sub
    Private Sub tmrMotionUpdate_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrMotionUpdate.Tick
        Me.tmrMotionUpdate.Stop()
        Me.SimulateStatusChange(ScaleStatus.Ok)
    End Sub

    Private Sub tmrCheckScaleConnection_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCheckScaleConnection.Tick

        If Me.ScaleInformation.IndicatorType = Scaletype.Serial Then
            If Me.PauseSerial = False Then
                Me.ScaleInformation.Status = ScaleStatus.CommError
                Me.ScaleInformation.Weight = 0
                Me.ScaleInformation.StatusString = StatusString(ScaleStatus.CommError)
                RaiseEvent Weight_Change(Me.ScaleInformation, True)

            End If
        End If

    End Sub

    Private Sub tmrTryPort_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTryPort.Tick

        If Me.ComPort.Trim = "" Then
            Connect()
        Else
            Connect(ComPort)
        End If

    End Sub

End Class
