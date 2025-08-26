Public Class frmRPTTicketJobLogLetterPortrait

    Public sTicketId As String

    Private Sub frmRPTTicketLogJobLetterPortrait_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTHEADER_V' table. You can move, or remove it, as needed.
        Me.REPORTHEADER_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTHEADER_V)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREPACT' table. You can move, or remove it, as needed.
        Me.TICKETOPEREPACTTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREPACT)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREP' table. You can move, or remove it, as needed.
        Me.TICKETOPEREPTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREP)

        GenerateReport()

    End Sub

    Public Sub Start()
        Try
          
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREP' table. You can move, or remove it, as needed.
            Me.TICKETOPEREPTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREP)

            TICKETOPEREPBindingSource.Filter = "TICKETID='" & sTicketId & "'"
            cbxJobLog.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        GenerateReport()
    End Sub

    Private Sub GenerateReport()

        If cbxJobLog.Text <> "" Then
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTHEADER_V' table. You can move, or remove it, as needed.
            Me.REPORTHEADER_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTHEADER_V)
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREPACT' table. You can move, or remove it, as needed.
            Me.TICKETOPEREPACTTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREPACT)

            LoadTmpWorkers()

            TICKETOPEREPACTBindingSource.Filter = "TICKETOPEREPID = '" & cbxJobLog.SelectedValue & "'"
            REPORTHEADER_VBindingSource.Filter = "TICKETID='" & sTicketId & "'"
            Me.ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub cbxJobLog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxJobLog.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxJobLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxJobLog.SelectedIndexChanged
        GenerateReport()
    End Sub

    Private Sub LoadTmpWorkers()

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "DELETE FROM TMP_TICKETOPEREPWORKER "
        bdconn.ExecuteNonSQL(sql)

        sql = "SELECT DISTINCT WORKER.NAME1+IIf(IsNull(WORKER.NAME2),'',' '+WORKER.NAME2)+" &
            "IIf(IsNull(WORKER.SURNAME1),'',' '+WORKER.SURNAME1)+IIf(IsNull(WORKER.SURNAME2),'',' '+WORKER.SURNAME2) AS FULLNAME " &
            "FROM TICKETWORKER INNER JOIN WORKER ON TICKETWORKER.WORKERID = WORKER.WORKERID " &
            "WHERE TICKETWORKER.TICKETID='" & sTicketId & "' " &
            "ORDER BY 1"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim Workers As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                If i > 0 Then
                    Workers = Workers & ", "
                End If

                Workers = Workers & ds.Tables(0).Rows(i)("FULLNAME")

            Next

            sql = "INSERT INTO TMP_TICKETOPEREPWORKER VALUES ('" & Workers & "')"
            bdconn.ExecuteNonSQL(sql)

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        ds.Dispose()
        ds = Nothing

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TMP_TICKETOPEREPWORKER' table. You can move, or remove it, as needed.
        Me.TMP_TICKETOPEREPWORKERTableAdapter.Fill(Me.SESTicketAccessDataSet.TMP_TICKETOPEREPWORKER)


        Me.Cursor = Cursors.Arrow

    End Sub


End Class