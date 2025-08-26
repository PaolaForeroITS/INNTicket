Public Class frmTicketServEvalECPEdit

    Dim util As New clsUtils
    Public sTicketId As String = ""
    Public sTicketServEvalEcpId As String = ""

    Private Sub frmTicketServEvalECPEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        util.DateTimePickerFormat(dtpServiceDate)
    End Sub

    Private Sub cbxEvalT1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalT1.KeyPress
        e.Handled = True
    End Sub
    Private Sub cbxEvalT2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalT2.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalT3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalT3.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalT4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalT4.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalC1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalC1.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalQ1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalQ1.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalQ2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalQ2.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalP1.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalP2.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalP3.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEvalP4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEvalP4.KeyPress
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
        If sTicketServEvalEcpId = "" Then

            Dim seq As New clsSequenceAccess(sTicketId)
            sql = "INSERT INTO [TICKETSERVEVAL_ECP] " &
                  "([TICKETSERVEVALECPID],[TICKETID],[SERVICEDATE] " &
                  ",[SERVDESCRIP],[EVAL_TIME1_1],[EVAL_TIME1_2] " &
                  ",[EVAL_TIME1_3],[EVAL_TIME1_4],[EVAL_COST1_5] " &
                  ",[EVAL_QUALITY1_6],[EVAL_QUALITY1_7],[EVAL_PS2_1] " &
                  ",[EVAL_PS2_2],[EVAL_PS2_3],[EVAL_PS2_4] " &
                  ",[OBS_C1],[OBS_C2],[ACTIVE]) VALUES ("

            sql = sql & "'" & seq.TicketServEvalECPNextId & "',"
            sql = sql & "'" & sTicketId & "',"
            sql = sql & "'" & dServiceDate.ToString("yyyy-MM-dd") & "',"
            sql = sql & "" & util.SQLConvStrNull(txtServiceDescr.Text, "s") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalT1.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalT2.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalT3.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalT4.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalC1.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalQ1.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalQ2.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalP1.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalP2.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalP3.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(cbxEvalP4.SelectedValue, "n") & ","
            sql = sql & "" & util.SQLConvStrNull(txtObsEO.Text, "s") & ","
            sql = sql & "" & util.SQLConvStrNull(txtObsPS.Text, "s") & ","
            sql = sql & "'YES')"

            bdconn.ExecuteNonSQL(sql)
        Else

            sql = "UPDATE [TICKETSERVEVAL_ECP] SET " &
                " [SERVICEDATE]           = '" & dServiceDate.ToString("yyyy-MM-dd") & "' " &
                ",[SERVDESCRIP]           = " & util.SQLConvStrNull(txtServiceDescr.Text, "s") & " " &
                ",[EVAL_TIME1_1]          = " & util.SQLConvStrNull(cbxEvalT1.SelectedValue, "n") & " " &
                ",[EVAL_TIME1_2]          = " & util.SQLConvStrNull(cbxEvalT2.SelectedValue, "n") & " " &
                ",[EVAL_TIME1_3]          = " & util.SQLConvStrNull(cbxEvalT3.SelectedValue, "n") & " " &
                ",[EVAL_TIME1_4]          = " & util.SQLConvStrNull(cbxEvalT4.SelectedValue, "n") & " " &
                ",[EVAL_COST1_5]          = " & util.SQLConvStrNull(cbxEvalC1.SelectedValue, "n") & " " &
                ",[EVAL_QUALITY1_6]       = " & util.SQLConvStrNull(cbxEvalQ1.SelectedValue, "n") & " " &
                ",[EVAL_QUALITY1_7]       = " & util.SQLConvStrNull(cbxEvalQ2.SelectedValue, "n") & " " &
                ",[EVAL_PS2_1]            = " & util.SQLConvStrNull(cbxEvalP1.SelectedValue, "n") & " " &
                ",[EVAL_PS2_2]            = " & util.SQLConvStrNull(cbxEvalP2.SelectedValue, "n") & " " &
                ",[EVAL_PS2_3]            = " & util.SQLConvStrNull(cbxEvalP3.SelectedValue, "n") & " " &
                ",[EVAL_PS2_4]            = " & util.SQLConvStrNull(cbxEvalP4.SelectedValue, "n") & " " &
                ",[OBS_C1] 				  = " & util.SQLConvStrNull(txtObsEO.Text, "s") & " " &
                ",[OBS_C2] 				  = " & util.SQLConvStrNull(txtObsPS.Text, "s") & " " &
                "WHERE [TICKETSERVEVALECPID] = '" & sTicketServEvalEcpId & "' "

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