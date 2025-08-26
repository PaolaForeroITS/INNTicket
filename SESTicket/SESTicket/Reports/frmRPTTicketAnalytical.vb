Public Class frmRPTTicketAnalytical
    Dim util As New clsUtils

    Private Sub frmRPTTicketAnalytical_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpServiceDateBegin.Value = DateSerial(Year(Now), Month(Now), 1)
        dtpServiceDateEnd.Value = DateSerial(Year(Now), Month(Now) + 1, 0)

        GenerateReport()
    End Sub

    Private Sub GenerateReport()

        If chkOpen.Checked = False And chkClosed.Checked = False And chkCanceled.Checked = False Then
            MsgBox("Choose the Ticket Status", vbExclamation)
            Exit Sub
        End If

        Dim dServiceDateBegin As Date
        Dim dServiceDateEnd As Date
        Dim sTicketId As String = ""
        Dim sCreatedBy As String = ""

        dServiceDateBegin = dtpServiceDateBegin.Value
        dServiceDateEnd = dtpServiceDateEnd.Value
        sTicketId = txtTicketID.Text
        sCreatedBy = txtCreatedBy.Text

        Dim sTicketStatus As String = ""

        If chkCanceled.Checked = True Then
            sTicketStatus = "Canceled"
        End If

        If chkClosed.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "Closed"
        End If

        If chkOpen.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "Open"
        End If

        If chkOpenByInvoice.Checked = False Then
            ReportViewer1.Visible = True
            ReportViewer2.Visible = False

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_TicketHeaderRpt' table. You can move, or remove it, as needed.
            Me.sp_TicketHeaderRptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_TicketHeaderRpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            Me.ReportViewer1.RefreshReport()

        Else

            ReportViewer1.Visible = False
            ReportViewer2.Visible = True

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_TicketHeaderByInvoiceRpt' table. You can move, or remove it, as needed.
            Me.sp_TicketHeaderByInvoiceRptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_TicketHeaderByInvoiceRpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            Me.ReportViewer2.RefreshReport()
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        GenerateReport()
    End Sub
End Class