Public Class Ticket_Number

    Dim IrsScaleDataset As New IRS_ScaleDataSet
    Dim TransactionTbladapter As New IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter
    Dim LastTruckInTableAdapter As New IRS_ScaleDataSetTableAdapters.LAstTruckInTableAdapter




    Public Function New_Ticket_Number()
        'Get a ticket number

        'Me.LastTruckInTableAdapter.Fill(Me.IrsScaleDataset.LAstTruckIn)
        'Dim LastTruck As Integer = 0
        'If Me.IrsScaleDataset.LAstTruckIn.Count > 0 Then
        '    LastTruck = CType(Me.IrsScaleDataset.LAstTruckIn(0).LastTruck, Integer)
        'End If
        'LastTruck += 1
        Dim Y As String = Now.Year.ToString.Substring(2, 2)
        Dim D As String = Now.DayOfYear.ToString.PadLeft(3, "0")
        Dim Setup As New Setup


        Dim Station As String = Setup.SetupItems.Station_Number.ToString.PadLeft(2, "0")
        Dim Ticket As String = (Setup.SetupItems.Ticket_Number + 1).ToString
        Do
            'Ticket = Y & Station & D & LastTruck.ToString.PadLeft(4, "0")
            Me.TransactionTbladapter.FillByTicket(Me.IrsScaleDataset.Transactions, Ticket)
            If Me.IrsScaleDataset.Transactions.Count > 0 Then
                Ticket = (Ticket + 1).ToString
            Else
                Exit Do
            End If
        Loop
        Return Ticket


    End Function



End Class
