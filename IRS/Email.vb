Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Threading
Imports CrystalDecisions.Shared

Public Class Email


    Public Shared Sub EmailTicket(ByVal TransactionRow As IRS_ScaleDataSet.TransactionsRow)
        Try

            Dim thread As Thread = New Thread(Sub() PrepareTicketforEmail(TransactionRow))
            thread.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Shared Function IsValidEmail(ByVal email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function




    Private Shared Sub PrepareTicketforEmail(TransactionRow As IRS_ScaleDataSet.TransactionsRow)
        Try


            Using accountsTableAdapter As New IRS_ScaleDataSetTableAdapters.AccountTableAdapter()
                Using accountTable As New IRS_ScaleDataSet.AccountDataTable()
                    If accountsTableAdapter.FillByAccountName(accountTable, TransactionRow.Account_Name) > 0 Then
                        Dim row As IRS_ScaleDataSet.AccountRow = accountTable(0)
                        If row.Email_Ticket And Not String.IsNullOrEmpty(row.Email) Then

                            If TransactionRow.IsJob_DescriptionNull() Then TransactionRow.Job_Description = ""

                            Dim Message As String = String.Format("{0} Job:{1}: Ticket:{2}", TransactionRow.Account_Name, TransactionRow.Job_Description, TransactionRow.Ticket) & System.Environment.NewLine
                            Dim stream As MemoryStream = CreateTicket(TransactionRow)
                            Dim words As String() = row.Email.Replace(";", " ").Split(" "c)
                            Dim Recipients As String = ""

                            For Each email As String In words
                                Dim emailAddress As String = email.Trim()
                                emailAddress = emailAddress.Trim()

                                If IsValidEmail(emailAddress) Then
                                    If Not String.IsNullOrEmpty(Recipients) Then Recipients += ";"
                                    Recipients += emailAddress
                                End If
                            Next

                            If Not String.IsNullOrWhiteSpace(Recipients) Then SendPDFMail(Recipients, stream, String.Format("{0}.pdf", TransactionRow.Ticket), String.Format("Ticket {0}", TransactionRow.Ticket), Message)
                        End If
                    End If


                End Using
            End Using

        Catch ex As Exception
        End Try
    End Sub




    Private Shared Function CreateTicket(TransactionRow As IRS_ScaleDataSet.TransactionsRow) As MemoryStream
        Dim stream As MemoryStream = New MemoryStream()

        Try

            Using ticketRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                ticketRpt.Load("Reports\ETicket.rpt")
                Using IRS_ScaleDataSet As New IRS_ScaleDataSet()
                    Using JobTotalsByAccount_ByDateTableAdapter As New IRS_ScaleDataSetTableAdapters.JobTotalsByAccount_ByDateTableAdapter()
                        Using JobTotalsByAccountTableAdapter As New IRS_ScaleDataSetTableAdapters.JobTotalsByAccountTableAdapter()
                            Using TransactionsTableAdapter As New IRS_ScaleDataSetTableAdapters.TransactionsTableAdapter()
                                Using SetupTableAdapter As New IRS_ScaleDataSetTableAdapters.SetupTableAdapter()

                                    JobTotalsByAccount_ByDateTableAdapter.FillByJobProduct(IRS_ScaleDataSet.JobTotalsByAccount_ByDate, Now, Now, TransactionRow.Job_Name, TransactionRow.Account_Name, TransactionRow.Product_Name)
                                    JobTotalsByAccountTableAdapter.FillByJobProduct(IRS_ScaleDataSet.JobTotalsByAccount, TransactionRow.Job_Name, TransactionRow.Account_Name, TransactionRow.Product_Name)
                                    TransactionsTableAdapter.FillByTicket(IRS_ScaleDataSet.Transactions, TransactionRow.Ticket)
                                    TransactionRow = IRS_ScaleDataSet.Transactions(0)

                                    SetupTableAdapter.Fill(IRS_ScaleDataSet.Setup)
                                    ticketRpt.SetDataSource(IRS_ScaleDataSet)



                                    Dim exportOpts As ExportOptions = New ExportOptions()
                                    exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat
                                    Dim exportFormatOptions As PdfRtfWordFormatOptions = New PdfRtfWordFormatOptions()
                                    exportFormatOptions.FirstPageNumber = 1
                                    exportFormatOptions.LastPageNumber = 1
                                    exportFormatOptions.UsePageRange = True
                                    exportOpts.ExportFormatOptions = exportFormatOptions
                                    exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat
                                    Dim req As ExportRequestContext = New ExportRequestContext()
                                    req.ExportInfo = exportOpts
                                    Dim s As Stream = ticketRpt.FormatEngine.ExportToStream(req)
                                    s.CopyTo(stream)
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        Catch ocrap As Exception
            MessageBox.Show("Error Emailing Ticket " + ocrap.Message)
        End Try
        Return stream
    End Function




    Private Shared Function SendPDFMail(ByVal Recipient As String, ByVal stream As MemoryStream, ByVal FileName As String, ByVal Subject As String, ByVal Message As String) As Boolean
        Try
            stream.Seek(0, SeekOrigin.Begin)
            Dim mailAttachment As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(stream, New System.Net.Mime.ContentType("application/pdf"))
            mailAttachment.Name = FileName
            Dim Attchments As List(Of System.Net.Mail.Attachment) = New List(Of System.Net.Mail.Attachment)()
            Attchments.Add(mailAttachment)
            SendMail(Recipient, Subject, Message, Attchments)
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Private Shared Function SendMail(ByVal Recipient As String, ByVal Subject As String, ByVal Message As String, ByVal Attachments As List(Of Attachment)) As Boolean
        Try
            Dim setup As New Setup()
            Dim smtpClient As SmtpClient = New SmtpClient()
            smtpClient.Host = Setup.SetupItems.SMTPServer
            smtpClient.Port = setup.SetupItems.SMTPPort
            smtpClient.EnableSsl = True
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
            smtpClient.UseDefaultCredentials = False

            smtpClient.Credentials = New NetworkCredential(setup.SetupItems.SMTPUser, setup.SetupItems.SMTPPass)
            Dim msg As MailMessage = New MailMessage()
            msg.From = New MailAddress(setup.SetupItems.SMTPFromEmail)
            Dim addresses = Recipient.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
            Dim address As Object
            For Each address In addresses
                msg.[To].Add(address)
            Next

            msg.Subject = Subject
            msg.Body = Message

            If Attachments IsNot Nothing AndAlso Attachments.Count > 0 Then

                For Each attchment As Attachment In Attachments
                    msg.Attachments.Add(attchment)
                Next
            End If

            smtpClient.Timeout = 240000
            smtpClient.Send(msg)
            Return True
        Catch ex As Exception



            Return False
        End Try
    End Function
End Class
