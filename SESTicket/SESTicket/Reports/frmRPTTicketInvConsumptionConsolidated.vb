Public Class frmRPTTicketInvConsumptionConsolidated

    Dim util As New clsUtils

    Private Sub frmREPTicketInvConsumptionConsolidated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.TICKETINVHEADER_V' table. You can move, or remove it, as needed.
        Me.TICKETINVHEADER_VTableAdapter.Fill(Me.SESTicketSQLDataSet.TICKETINVHEADER_V)

        dtpServiceDateBegin.Value = DateSerial(Year(Now), Month(Now), 1)
        dtpServiceDateEnd.Value = DateSerial(Year(Now), Month(Now) + 1, 0)

        GenerateReport()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        GenerateReport()
    End Sub

    Private Sub GenerateReport()

        If chkOpen.Checked = False And chkClosed.Checked = False And chkCanceled.Checked = False Then
            MsgBox("Choose the Ticket Status", vbExclamation)
            Exit Sub
        End If

        Dim dServiceDateBegin As Date
        Dim dServiceDateEnd As Date
        Dim sStatusHeader As String = ""

        Dim sfilter As String = ""

        dServiceDateBegin = dtpServiceDateBegin.Value
        dServiceDateEnd = dtpServiceDateEnd.Value

        sfilter = sfilter & " DATESERVICE >= '" + dServiceDateBegin.ToString("yyyy-MM-dd") + "' AND DATESERVICE <='" + dServiceDateEnd.ToString("yyyy-MM-dd") + "' "

        Dim sTicketStatus As String = ""

        If chkCanceled.Checked = True Then
            sTicketStatus = "'Canceled'"
        End If

        If chkClosed.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "'Closed'"
        End If

        If chkOpen.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "'Open'"
        End If
        sfilter = sfilter & "AND TICKETSTATUS IN (" & sTicketStatus & ")"

        TICKETINVHEADER_VBindingSource.Filter = sfilter
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class