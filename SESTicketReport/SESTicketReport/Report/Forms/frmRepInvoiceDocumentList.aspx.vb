Imports Microsoft.Reporting.WebForms

Public Class rptInvoiceDocumentList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

        End If

    End Sub

    Protected Sub btnGeneReport_Click(sender As Object, e As EventArgs)

        ReportViewer1.Visible = False

        Dim util As New clsUtils

        txtInvoiceDateBegin.Text = Request.Form(txtInvoiceDateBegin.UniqueID)
        txtInvoiceDateEnd.Text = Request.Form(txtInvoiceDateEnd.UniqueID)

        If txtInvoiceDateBegin.Text = "" Then
            Me.MessageBox("Choose the Invoice Date - Begin")
            Exit Sub
        End If

        If txtInvoiceDateEnd.Text = "" Then
            Me.MessageBox("Choose the Invoice Date - End")
            Exit Sub
        End If

        util.Dispose()
        util = Nothing

        GenerateReport()

    End Sub

    Private Sub GenerateReport()

        Dim dDateBegin As Date
        Dim dDateEnd As Date

        'dDateBegin = txtInvoiceDateBegin.Text
        'dDateEnd = txtInvoiceDateEnd.Text

        dDateBegin = Date.ParseExact(txtInvoiceDateBegin.Text, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)

        dDateEnd = Date.ParseExact(txtInvoiceDateEnd.Text, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)

        Dim util As New clsUtils

        Dim sql As String
        Dim dsData As New DataSet
        Dim dsTranslate As New DataSet

        Dim bdconn As New clsDatabaseSQL

        bdconn.OpenConnection()

        Dim sReportName As String

        sReportName = "rptInvoiceDocumentList"

        sql = "EXEC [dbo].[sp_RptInvoiceDocumentList] " &
                  "" & util.SQLConvStrNull(dDateBegin, "d") & "," &
                  "" & util.SQLConvStrNull(dDateEnd, "d")

        bdconn.ExecuteSQL(sql, dsData)

        Dim rdsData As ReportDataSource = New ReportDataSource("dsHeader", dsData.Tables(0))

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