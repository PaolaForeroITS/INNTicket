Public Class frmRPTTicketSalesItem
    Dim util As New clsUtils

    Private Sub frmRPTSalesItemL01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_SalesItemL01Rpt' table. You can move, or remove it, as needed.
            Me.sp_SalesItemL01RptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_SalesItemL01Rpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_SalesItemL02Rpt' table. You can move, or remove it, as needed.
            Me.sp_SalesItemL02RptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_SalesItemL02Rpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_SalesItemTotalL01Rpt' table. You can move, or remove it, as needed.
            Me.sp_SalesItemTotalL01RptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_SalesItemTotalL01Rpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_SalesItemTotalL02ServRpt' table. You can move, or remove it, as needed.
            Me.sp_SalesItemTotalL02ServRptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_SalesItemTotalL02ServRpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.sp_SalesItemTotalL02MatRpt' table. You can move, or remove it, as needed.
            Me.sp_SalesItemTotalL02MatRptTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_SalesItemTotalL02MatRpt, dServiceDateBegin, dServiceDateEnd, sTicketId, sCreatedBy, sTicketStatus)

            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.RefreshReport()
            Me.ReportViewer3.RefreshReport()
            Me.ReportViewer4.RefreshReport()
            Me.ReportViewer5.RefreshReport()

            Me.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        GenerateReport()
    End Sub

End Class