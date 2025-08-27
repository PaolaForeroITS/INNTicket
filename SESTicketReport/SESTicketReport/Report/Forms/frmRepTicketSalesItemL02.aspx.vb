Imports Microsoft.Reporting.WebForms
Public Class frmRepTicketSalesItemL02
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

        End If

    End Sub
    Protected Sub btnGeneReport_Click(sender As Object, e As EventArgs)

        ReportViewer1.Visible = False

        txtServiceDateBegin.Text = Request.Form(txtServiceDateBegin.UniqueID)        txtServiceDateEnd.Text = Request.Form(txtServiceDateEnd.UniqueID)

        Dim util As New clsUtils

        If txtServiceDateBegin.Text = "" Then
            Me.MessageBox("Choose the Service Date - Begin")
            Exit Sub
        End If

        If txtServiceDateEnd.Text = "" Then
            Me.MessageBox("Choose the Service Date - End")
            Exit Sub
        End If

        If util.isDate(txtServiceDateBegin.Text) = False Then
            Me.MessageBox("Invalid Date")
            Exit Sub
        End If

        If util.isDate(txtServiceDateEnd.Text) = False Then
            Me.MessageBox("Invalid Date")
            Exit Sub
        End If

        If chkOpen.Checked = False And chkClosed.Checked = False And chkCanceled.Checked = False Then
            Me.MessageBox("Choose the Ticket Status")
            Exit Sub
        End If

        util.Dispose()
        util = Nothing

        GenerateReport()

    End Sub

    Private Sub GenerateReport()

        Dim dServiceDateBegin As Date
        Dim dServiceDateEnd As Date
        Dim sTicketId As String = ""
        Dim sCreatedBy As String = ""

        dServiceDateBegin = txtServiceDateBegin.Text
        dServiceDateEnd = txtServiceDateEnd.Text
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

        Dim util As New clsUtils


        Dim sql As String
        Dim dsData As New DataSet
        Dim dsTranslate As New DataSet

        Dim bdconn As New clsDatabaseSQL

        bdconn.OpenConnection()

        Dim sReportName As String

        sReportName = "rptTicketSalesItemL02"

        sql = "EXEC [dbo].[sp_SalesItemL02Rpt] " &
                  "" & util.SQLConvStrNull(dServiceDateBegin, "d") & "," &
                  "" & util.SQLConvStrNull(dServiceDateEnd, "d") & "," &
                  "" & util.SQLConvStrNull(txtTicketID.Text, "s") & "," &
                  "" & util.SQLConvStrNull(txtCreatedBy.Text, "s") & "," &
                  "" & util.SQLConvStrNull(sTicketStatus, "s") & ""
        bdconn.ExecuteSQL(sql, dsData)

        Dim rdsData As ReportDataSource = New ReportDataSource("DataSet1", dsData.Tables(0))

        With ReportViewer1
            .Visible = True
            .ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(rdsData)
            .ShowParameterPrompts = True
            .LocalReport.EnableHyperlinks = True
            .LocalReport.ReportPath = Server.MapPath("~/Report/Rdlc/" & sReportName & ".rdlc")
        End With

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub
    Private Sub MessageBox(ByVal msg As String)
        Dim lbl As New Label()
        lbl.Text = "<script type=""text/javascript"">" & Environment.NewLine &
               "window.alert('" + msg + "')</script>"
        Page.Controls.Add(lbl)
    End Sub
End Class