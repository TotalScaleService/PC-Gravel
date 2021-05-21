Public Class Setup
    Dim SetupTblAdapter As New IRS_ScaleDataSetTableAdapters.SetupTableAdapter
    Dim SetupTbl As New IRS_ScaleDataSet.SetupDataTable
    Public SetupItems As IRS_ScaleDataSet.SetupRow

    Public Sub New()
        Me.SetupTblAdapter.Fill(Me.SetupTbl)
        If Me.SetupTbl.Count = 0 Then
            Me.SetupItems = Me.SetupTbl.NewRow
            With Me.SetupItems
                .Company_Name = "Default Company Name"
                .Header1 = ""
                .Header2 = ""
                .Header3 = ""
                .Tax_Rate = 0.05
                .Simulate_Scale = True
                .Default_Hauler = ""
                .Comm_Port = ""
                .Print_To_Screen = False
                .Show_Price_By_Default = True
                .Pit_Name = ""
                .Show_SplitWeigh_Button = True
                .Station_Number = 1
            End With
            Me.SetupTbl.AddSetupRow(SetupItems)
        Else

            SetupItems = Me.SetupTbl(0)

            SetupItems.Comm_Port = My.Settings.First_Scale_ComPort
            SetupItems.Station_Number = My.Settings.StationID
            SetupItems.Report_Printer = My.Settings.ReportPrinter
            SetupItems.Ticket_Printer = My.Settings.TicketPrinter
            SetupItems.Simulate_Scale = My.Settings.SimulateScale

        End If
        With SetupItems
            If .IsTicket_NumberNull Then .Ticket_Number = 0
            If .IsHeader1Null Then .Header1 = ""
            If .IsHeader2Null Then .Header2 = ""
            If .IsHeader3Null Then .Header3 = ""
            If .IsDefault_HaulerNull Then .Default_Hauler = ""

            If .IsComm_PortNull Then .Comm_Port = ""
            If .IsStation_NumberNull Then .Station_Number = 1
            If .IsReport_PrinterNull Then .Report_Printer = ""
            If .IsTicket_PrinterNull Then .Ticket_Printer = ""

            If .IsPrint_To_ScreenNull Then .Print_To_Screen = False
            If .IsShow_Price_By_DefaultNull Then .Show_Price_By_Default = True
            If .IsPit_NameNull Then .Pit_Name = ""
            If .IsShow_SplitWeigh_ButtonNull Then .Show_SplitWeigh_Button = True
            If .IsShow_State_Ticket_ButtonNull Then .Show_State_Ticket_Button = True
            If .IsTicket_Copies_Per_PageNull Then .Ticket_Copies_Per_Page = 1
            If .IsTicket_CopiesNull Then .Ticket_Copies = 1
            If .IsTicket_PaperNull Then .Ticket_Paper = ""
            If .IsTicket_WidthNull Then .Ticket_Width = 0
            If .IsTicket_HeightNull Then .Ticket_Height = 0
            If .IsTicket_Raw_KindNull Then .Ticket_Raw_Kind = 0


        End With
        Me.SetupTblAdapter.Update(Me.SetupTbl)
    End Sub


    Public Sub SaveTicket(ByVal Ticket As String)
        Dim IntTicket As Integer = 0
        Try
            IntTicket = CType(Ticket, Integer)
        Catch ex As Exception
            IntTicket = 0
        End Try
        Me.SetupItems.Ticket_Number = IntTicket
        Me.SetupTblAdapter.Update(Me.SetupTbl)
    End Sub



End Class
