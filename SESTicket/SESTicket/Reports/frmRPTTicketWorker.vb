Public Class frmRPTTicketWorker

    Dim util As New clsUtils

    Private Sub frmRPTTicketWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Try
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_TicketWorkerRpt' table. You can move, or remove it, as needed.
            Me.sp_TicketWorkerRptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_TicketWorkerRpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_TicketWorkerTotalRpt' table. You can move, or remove it, as needed.
            Me.sp_TicketWorkerTotalRptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_TicketWorkerTotalRpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)

            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.RefreshReport()

            Me.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        GenerateReport()
    End Sub

End Class