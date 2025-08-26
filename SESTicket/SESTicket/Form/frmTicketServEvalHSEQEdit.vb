Public Class frmTicketServEvalHSEQEdit

    Dim util As New clsUtils

    Public sTicketId As String = ""
    Public sTicketServEvalId As String = ""

    Private Sub frmTicketServEvalHSEQEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        util.DateTimePickerFormat(dtpServiceDate)
    End Sub

    Private Sub cbxEvalPersonal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalPersonal.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalEquip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalEquip.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalComun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalComun.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalHSEQPerf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalHSEQPerf.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalGeneralPercep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalGeneralPercep.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtServiceDescr.Text = "" Then
            MsgBox("Inform the Service Description", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim dServiceDate As Date = dtpServiceDate.Value

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String

        bdconn.OpenConnection()

        If sTicketServEvalId = "" Then

            Dim seq As New clsSequenceAccess(sTicketId)

            sql = "INSERT INTO [TICKETSERVEVAL_HSEQ] " & _
                  "([TICKETSERVEVALID],[TICKETID],[SERVICEDATE] " & _
                  ",[SERVDESCRIP],[EVAL_PERSONAL],[EVAL_EQUIPMENT] " & _
                  ",[EVAL_COMUNICATION],[EVAL_HSEQ_PERF],[EVAL_GENERALPERCEP] " & _
                  ",[OBS],[ACTIVE]) VALUES ("

            sql = sql & "'" & seq.TicketServEvalHSEQNextId & "',"
            sql = sql & "'" & sTicketId & "',"
            sql = sql & "'" & dServiceDate.ToString("yyyy-MM-dd") & "',"
            sql = sql & "" & util.SQLConvStrNull(txtServiceDescr.Text, "s") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalPersonal.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalEquip.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalComun.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalHSEQPerf.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalGeneralPercep.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(txtObs.Text, "s") & ","
            sql = sql & "'YES')"

            bdconn.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE [TICKETSERVEVAL_HSEQ] SET " &
                " [SERVICEDATE]           = '" & dServiceDate.ToString("yyyy-MM-dd") & "' " &
                ",[SERVDESCRIP]           = " & util.SQLConvStrNull(txtServiceDescr.Text, "s") & " " &
                ",[EVAL_PERSONAL]         = " & util.SQLConvStrNull(cbxEvalPersonal.SelectedValue, "n") & " " &
                ",[EVAL_EQUIPMENT]        = " & util.SQLConvStrNull(cbxEvalEquip.SelectedValue, "n") & " " &
                ",[EVAL_COMUNICATION]     = " & util.SQLConvStrNull(cbxEvalComun.SelectedValue, "n") & " " &
                ",[EVAL_HSEQ_PERF]        = " & util.SQLConvStrNull(cbxEvalHSEQPerf.SelectedValue, "n") & " " &
                ",[EVAL_GENERALPERCEP]    = " & util.SQLConvStrNull(cbxEvalGeneralPercep.SelectedValue, "n") & " " &
                ",[OBS] 				  = " & util.SQLConvStrNull(txtObs.Text, "s") & " " &
                "WHERE [TICKETSERVEVALID] = '" & sTicketServEvalId & "' "

            bdconn.ExecuteNonSQL(sql)

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow
        Me.Dispose()

    End Sub

    Public Sub Init()
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.HSEQ_ANSWERS' table. You can move, or remove it, as needed.
        Me.HSEQ_ANSWERSTableAdapter.Fill(Me.SESTicketAccessDataSet.HSEQ_ANSWERS)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class