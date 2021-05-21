Imports System.Windows.Forms

Public Class MDIParent
    Public Const SimulateMultliplier As Integer = 580
    Const SplitWeigh As String = "Split Weigh"
    Const Straight_Weigh As String = "Straight Weigh"

    Public WithEvents Indicator As New WeightIndicator
    Public WithEvents Indicator1 As New WeightIndicator
    Public Weight As Double
    Public WeightLocked As Boolean
    Public PrintToScreen As Boolean = False
    Public Setup As Setup
    Public ComPort As String = ""
    Public Comport1 As String = ""
    Public TrucksOnHold As New Trucks_On_Hold
    Public MotionCount As Integer = 0
    Dim NoMotionCount As Integer
    Dim RedLight As Boolean

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        Close()
    End Sub

    Private Sub SetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        Dim frmPass As New Password
        If frmPass.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If My.Forms.System_Setup.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.GetSetup()
            End If
        End If
    End Sub

    
    Private Sub MDIParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Rpt As New CrystalReport
        Rpt.LoadReport(CrystalReport.enReportType.Ticket)
        Me.SetToStraightWeigh()
        GetSetup()
        RedLight = True
        ChangeLight()

    End Sub

    Private Sub GetSetup()
        Try

            Setup = New Setup

            Me.PrintToScreen = Setup.SetupItems.Print_To_Screen

            If Setup.SetupItems.Simulate_Scale = False Then


                Me.Indicator.ConnectionType = WeightIndicator.Scaletype.Serial
                Me.Indicator.CommPort = Setup.SetupItems.Comm_Port
                Me.ComPort = Me.Indicator.CommPort

                Using frm As New SetScaleConnection()
                    frm.Connect(Indicator, Me.ComPort)
                    If frm.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                        Me.Indicator.ConnectionType = WeightIndicator.Scaletype.Simulate
                        Me.Indicator.SimulateDataRecieved(0, WeightIndicator.ScaleStatus.Ok)
                    End If
                End Using

                If My.Settings.Second_Scale = True Then

                    'Need to do same as above but pass 2nd indicator.
                    Me.Indicator1.ConnectionType = WeightIndicator.Scaletype.Serial
                    Me.Indicator1.CommPort = My.Settings.Second_Scale_ComPort
                    Me.Comport1 = Me.Indicator1.CommPort

                    Using frm As New SetScaleConnection()
                        frm.Connect(Indicator1, Me.Comport1)
                        If frm.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                            Me.Indicator1.ConnectionType = WeightIndicator.Scaletype.Simulate
                            Me.Indicator1.SimulateDataRecieved(0, WeightIndicator.ScaleStatus.Ok)
                        End If
                    End Using

                    My.Forms.MDIParent.lblSelectScale.Visible = True
                    My.Forms.MDIParent.btnScaleSelect.Text = My.Settings.FirstScaleName
                    My.Forms.MDIParent.btnScaleSelect.Visible = True

                Else

                    My.Forms.MDIParent.lblSelectScale.Visible = False
                    My.Forms.MDIParent.btnScaleSelect.Visible = False

                End If

            Else

                If My.Settings.Second_Scale = True Then

                    My.Forms.MDIParent.lblSelectScale.Visible = True
                    My.Forms.MDIParent.btnScaleSelect.Text = My.Settings.FirstScaleName
                    My.Forms.MDIParent.btnScaleSelect.Visible = True

                Else

                    Me.Indicator.ConnectionType = WeightIndicator.Scaletype.Simulate
                    My.Forms.MDIParent.lblSelectScale.Visible = False
                    My.Forms.MDIParent.btnScaleSelect.Visible = False

                End If

            End If

            If Me.Indicator.ConnectionType = WeightIndicator.Scaletype.Simulate Then
                ToolStripStatusLabel.Text = "Simulate"
                Me.Text += "  SIMULATE MODE"
                Me.HSSimulate.Visible = True
            Else
                ToolStripStatusLabel.Text = ""
                Me.HSSimulate.Visible = False
            End If

            Me.btnSplitWeigh.Visible = Setup.SetupItems.Show_SplitWeigh_Button

        Catch ex As Exception


        End Try

        'TrucksOnHold.WindowState = FormWindowState.Maximized
        Trucks_On_Hold.FormBorderStyle = FormBorderStyle.None
        TrucksOnHold.MdiParent = Me
        TrucksOnHold.Show()
        TrucksOnHold.Dock = DockStyle.Fill
    End Sub

    Public Sub ChangeLight()

        Try

            If RedLight = False Then

                RedLight = True
                Me.PictureBox1.BackgroundImage = My.Resources.Red

            Else

                RedLight = False
                Me.PictureBox1.BackgroundImage = My.Resources.Green

            End If
        Catch ex As Exception

            MsgBox("Error - " + ex.Message)

        End Try
    End Sub
    Private Sub btnManualWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManualWeight.Click
        My.Forms.Manual_Weight.Label2.Text = "Key In Weight"
        My.Forms.Manual_Weight.Label1.Text = "Then Press Enter Or Click Ok "
        My.Forms.Manual_Weight.Text = "Manual Weight"
        My.Forms.Manual_Weight.CurVal = Me.Weight
        If My.Forms.Manual_Weight.ShowDialog = Windows.Forms.DialogResult.OK Then
            LockWeight()
            Dim NewValue As Integer = My.Forms.Manual_Weight.numManual_Weight.Value
            If NewValue > 120000 Then NewValue = 120000
            Me.Indicator.SimulateDataRecieved(NewValue, WeightIndicator.ScaleStatus.Ok)
            NewValue = NewValue \ SimulateMultliplier
            If NewValue > Me.HSSimulate.Maximum Then NewValue = Me.HSSimulate.Maximum
            Me.HSSimulate.Value = NewValue
        End If

        Try
            For Each form As Form In Me.MdiChildren
                form.Focus()
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub LockWeight()
        Me.btnLockWeight.BackColor = Color.Yellow
        Me.btnLockWeight.Text = "Unlock Weight"
        Me.Indicator.PauseSerial = True
        WeightLocked = True
    End Sub

    Public Sub UnlockWeight()
        Me.btnLockWeight.BackColor = Me.btnManualWeight.BackColor
        Me.btnLockWeight.Text = "Lock Weight"
        Me.Indicator.PauseSerial = False
        WeightLocked = False
    End Sub

    Private Sub btnLockWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockWeight.Click
        If Me.WeightLocked Then
            UnlockWeight()
        Else
            LockWeight()
        End If
    End Sub

    Private Sub Indicator_Weight_Change1(ByVal Data As WeightIndicator.ScaleData, ByVal Simulate As Boolean) Handles Indicator.Weight_Change

        'Added by Matt Burkett  8/15/17  to work with 2 scales.
        If btnScaleSelect.Text = My.Settings.FirstScaleName Or btnScaleSelect.Visible = False Then
            ' end of change
            If Me.WeightLocked = False Or Simulate = True Then
                Me.lblWeight.Text = Data.Weight.ToString
                Me.lblMotion.Text = Data.StatusString
                If Me.btnSplitWeigh.Text = SplitWeigh Then
                    Me.btnSplitWeigh.Enabled = Data.Weight > 1000
                Else
                    Me.btnSplitWeigh.Enabled = True
                End If

                SetWeight()

            End If

        End If

    End Sub

    Private Sub Indicator_Weight_Change2(ByVal Data As WeightIndicator.ScaleData, ByVal Simulate As Boolean) Handles Indicator1.Weight_Change

        'Added by Matt Burkett  8/15/17  to work with 2 scales.
        If btnScaleSelect.Text = My.Settings.SecondScaleName Then
            ' end of change
            If Me.WeightLocked = False Or Simulate = True Then
                Me.lblWeight.Text = Data.Weight.ToString
                Me.lblMotion.Text = Data.StatusString
                If Me.btnSplitWeigh.Text = SplitWeigh Then
                    Me.btnSplitWeigh.Enabled = Data.Weight > 1000
                Else
                    Me.btnSplitWeigh.Enabled = True
                End If

                SetWeight()

            End If

        End If

    End Sub

    Private Sub SetWeight()
        If Me.lblWeight.Text = "" Then Me.lblWeight.Text = 0
        If Me.lblStored1.Text = "" Then Me.lblStored1.Text = 0
        If Me.lblStored2.Text = "" Then Me.lblStored2.Text = 0
        If Me.lblStored3.Text = "" Then Me.lblStored3.Text = 0
        Dim Stored1, Stored2, Stored3, ScaleWeight As Integer
        Stored1 = CType(Me.lblStored1.Text, Integer)
        Stored2 = CType(Me.lblStored2.Text, Integer)
        Stored3 = CType(Me.lblStored3.Text, Integer)
        ScaleWeight = CType(Me.lblWeight.Text, Integer)
        Me.Weight = Stored1 + Stored2 + Stored3 + ScaleWeight
        Me.lblTotal.Text = Me.Weight
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZeroButton.Click
        Me.Indicator.ZeroScale()
        Me.HSSimulate.Value = 0
        Try
            For Each form As Form In Me.MdiChildren
                form.Focus()
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowCompletedTrucks()
    End Sub

    Private Sub ShowCompletedTrucks()
        Dim Trans_List As New Ticket_List
        Trans_List.WindowState = FormWindowState.Maximized

        Trans_List.ShowDialog()

    End Sub

    Private Sub HSSimulate_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HSSimulate.Scroll
        Me.Indicator.SimulateDataRecieved(Me.HSSimulate.Value * SimulateMultliplier, WeightIndicator.ScaleStatus.Motion)
    End Sub

    Public Sub SetToStraightWeigh()
        Me.btnSplitWeigh.Text = SplitWeigh
        Me.lblStored1.Text = 0
        Me.lblStored2.Text = 0
        Me.lblStored3.Text = 0
        Me.lblTotal.Text = Me.lblWeight.Text
        Me.grpStored1.Visible = False
        Me.grpStored2.Visible = False
        Me.grpStored3.Visible = False
        Me.grpTotal.Visible = False
        Me.btnSplitAgain.Visible = False
        Me.SetWeight()
        Me.Indicator.SimulateDataRecieved(Me.Weight, WeightIndicator.ScaleStatus.Motion)
    End Sub

    Private Sub SplitCheckForMotion()




        If Me.lblMotion.Text = "Motion" Then


            MotionCount = 0
            tmrMotion.Start()

        Else

            SetToSplitWeigh()

        End If
    End Sub

    Private Sub SetToSplitWeigh()
        Me.btnSplitWeigh.Text = Straight_Weigh
        Dim NextSplit As Windows.Forms.GroupBox
        Dim Location As Point

        
        If Me.grpStored1.Visible = False Then
            NextSplit = Me.grpStored1
            Location = NextSplit.Location
        ElseIf Me.grpStored2.Visible = False Then
            NextSplit = Me.grpStored2
            Location = grpStored1.Location
        ElseIf Me.grpStored3.Visible = False Then
            NextSplit = Me.grpStored3
            Location = grpStored2.Location
        Else
            Exit Sub
        End If
        If Not NextSplit Is Me.grpStored1 Then
            Location.X += NextSplit.Size.Width
            NextSplit.Location = Location
        End If
        NextSplit.Visible = True
        Location.X += NextSplit.Size.Width
        Me.grpTotal.Location = Location
        Me.grpTotal.Visible = True

        If Not NextSplit Is Me.grpStored3 Then
            Location.X += NextSplit.Size.Width + 10

            Me.btnSplitAgain.Visible = True
            Location.Y = (NextSplit.Height / 2) - (Me.btnSplitAgain.Height / 2)
            Me.btnSplitAgain.Location = Location
        Else
            Me.btnSplitAgain.Visible = False
        End If
        If NextSplit Is Me.grpStored1 Then
            Me.lblStored1.Text = Me.lblWeight.Text
        ElseIf NextSplit Is Me.grpStored2 Then
            Me.lblStored2.Text = Me.lblWeight.Text
        Else
            Me.lblStored3.Text = Me.lblWeight.Text
        End If
        Me.SetWeight()
        Me.Indicator.SimulateDataRecieved(Me.lblWeight.Text, WeightIndicator.ScaleStatus.Motion)

    End Sub

    
    Private Sub btnSplitWeigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitWeigh.Click

        If Me.btnSplitWeigh.Text = SplitWeigh Then
            SplitCheckForMotion()
        Else
            SetToStraightWeigh()
        End If

    End Sub

    Private Sub btnSplitAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitAgain.Click

        Me.SplitCheckForMotion()

    End Sub



    Private Sub pnlWeights_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlWeights.VisibleChanged
        Me.HSSimulate.Visible = Me.pnlWeights.Visible And Me.Indicator.ConnectionType = WeightIndicator.Scaletype.Simulate
    End Sub

    Private Sub ViewArchivedTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New Report_Preview(True)
        f.WindowState = FormWindowState.Maximized
        f.ShowDialog()

    End Sub


    Private Sub tmrMotion_Tick(sender As Object, e As EventArgs) Handles tmrMotion.Tick
        If Me.lblMotion.Text = "Motion" Then

            NoMotionCount = 0

            If MotionCount < 10 Then

                MotionCount = MotionCount + 1

            Else

                tmrMotion.Stop()
                MsgBox("Unable to Weigh, SCALE IN MOTION")

            End If

        Else

            NoMotionCount = NoMotionCount + 1

            If NoMotionCount > 1 Then

                NoMotionCount = 0
                MotionCount = 0
                tmrMotion.Stop()
                SetToSplitWeigh()

            End If

        End If

    End Sub

    Private Sub btnScaleSelect_Click(sender As Object, e As EventArgs) Handles btnScaleSelect.Click

        If btnScaleSelect.Text = My.Settings.FirstScaleName Then

            Me.ComPort = Me.Indicator1.CommPort
            btnScaleSelect.Text = My.Settings.SecondScaleName

        Else

            Me.ComPort = Me.Indicator.CommPort
            btnScaleSelect.Text = My.Settings.FirstScaleName

        End If
    End Sub

    Private Sub btnChangeLight_Click(sender As Object, e As EventArgs) Handles btnChangeLight.Click

        ChangeLight()

    End Sub

    Private Sub MDIParent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.SimulateScale = False Then
            Indicator.ClosePort()
        End If

        If My.Settings.Second_Scale = True Then
            Indicator1.ClosePort()
        End If
    End Sub
End Class
