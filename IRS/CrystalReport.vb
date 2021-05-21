Public Class CrystalReport

    Public Report As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Public Enum enReportType
        Ticket
        Two_Part_Ticket
        Three_Part_Ticket
        Basic
        Report
        ProductReport
        ProductByTicket
    End Enum

    Public Sub LoadReport(ByVal ReportType As enReportType)

        'set database before parameters

        Select Case ReportType
            Case enReportType.Ticket
                Report.Load("Reports\Ticket.rpt")
            Case enReportType.Two_Part_Ticket
                Report.Load("Reports\Ticket_2_Part.rpt")
                'Report.Load("Reports\Ticket_2_Part.rpt")
            Case enReportType.Basic
                Report.Load("Reports\BasicTicket.rpt")
            Case enReportType.Report
                Report.Load("Reports\Report.rpt")
            Case enReportType.ProductReport
                Report.Load("Reports\ProductReport.rpt")
            Case enReportType.Three_Part_Ticket
                Report.Load("Reports\Ticket_3_Part.rpt")
            Case enReportType.ProductByTicket
                Report.Load("Reports\ProductTransactions.rpt")
        End Select

    End Sub


    Public WriteOnly Property Suppress_Details() As Boolean
        Set(ByVal value As Boolean)
            Report.SetParameterValue("SuppressDetails", value)
        End Set
    End Property


    Public Sub SetParameters(ByVal param As String)
        Dim intCounter As Integer
        'Parameter value object of crystal report 
        ' parameters used for adding the value to parameter.
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue

        'Current parameter value object(collection) of crystal report parameters.
        Dim currValue As CrystalDecisions.Shared.ParameterValues


        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        'Check if there are parameters or not in report.
        intCounter = Report.DataDefinition.ParameterFields.Count

        'As parameter fields collection also picks the selection 
        ' formula which is not the parameter
        ' so if total parameter count is 1 then we check whether 
        ' its a parameter or selection formula.

        If intCounter = 1 Then
            If InStr(Report.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
                intCounter = 0
            End If
        End If

        'If there are parameters in report and 
        'user has passed them then split the 
        'parameter string and Apply the values 
        'to their concurrent parameters.

        If intCounter > 0 And Trim(param) <> "" Then
            strParValPair = param.Split("&")

            For index = 0 To UBound(strParValPair)
                If InStr(strParValPair(index), "=") > 0 Then
                    strVal = strParValPair(index).Split("=")
                    paraValue.Value = strVal(1)
                    currValue = Report.DataDefinition.ParameterFields(strVal(0)).CurrentValues
                    currValue.Add(paraValue)
                    Report.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
                End If
            Next
        End If

    End Sub


End Class
