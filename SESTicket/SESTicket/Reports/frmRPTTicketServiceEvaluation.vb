Public Class frmRPTTicketServiceEvaluation
    Dim util As New clsUtils

    Public sTicketId As String

    Public dServiceDate As Date
    Public sDescription As String

    Private Sub frmRPTTicketServiceEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateReport()
    End Sub

    Private Sub GenerateReport()

        Me.Cursor = Cursors.WaitCursor

        Dim cls As New clsRPTDocx

        Dim sql As String
        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        sql = "DELETE FROM TMP_RPT_TICKETSERVEVALSERV WHERE TICKETID='" & sTicketId & "'"
        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "INSERT INTO TMP_RPT_TICKETSERVEVALSERV (TICKETID,DATEEXT,SERVICEDESCR) VALUES ('"
        sql = sql & sTicketId & "','"
        sql = sql & cls.DateExten(dServiceDate) & "',"
        sql = sql & IIf(sDescription = "", "' '", util.SQLConvStrNull(sDescription, "s")) & ")"
        bdconnACCESS.ExecuteNonSQL(sql)

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()

        cls.Dispose()

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTHEADER_V' table. You can move, or remove it, as needed.
        Me.REPORTHEADER_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTHEADER_V)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TMP_RPT_TICKETSERVEVALSERV' table. You can move, or remove it, as needed.
        Me.TMP_RPT_TICKETSERVEVALSERVTableAdapter.Fill(Me.SESTicketAccessDataSet.TMP_RPT_TICKETSERVEVALSERV)

        Dim sFilter As String

        sFilter = "TICKETID='" & sTicketId & "'"
        REPORTHEADER_VBindingSource.Filter = sFilter
        TMP_RPT_TICKETSERVEVALSERVBindingSource.Filter = sFilter

        Me.Cursor = Cursors.Arrow

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class