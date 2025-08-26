
Public Class frmTicketOperRepDateEdit

    Public sTicketOpeRepId As String = ""
    Public sTicketId As String

    Dim util As New clsUtils
    Dim sServiceDescrOld As String

    Private Sub frmTicketOperRepDateEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        util.DateTimePickerFormat(dtpActivityDate)

        If sTicketOpeRepId = "" Then
            dtpActivityDate.Value = DateTime.Now
            btnCancelDelete.Text = "Cancel"
        Else
            btnCancelDelete.Text = "Delete"
            sServiceDescrOld = txtServiceDescription.Text
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtServiceDescription.Text = "" Then
            MsgBox("The Service Description is obrigatory", vbExclamation)
            Exit Sub
        End If

        Dim bdconnAccess As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet
        Dim cls As New clsRPTDocx


        bdconnAccess.OpenConnection()

        If sTicketOpeRepId = "" Then

            sql = "SELECT 1 FROM TICKETOPEREP " & _
                  "WHERE TICKETID = '" & sTicketId & "' " & _
                  "AND SERVICEDESCR = '" & txtServiceDescription.Text & "' " & _
                  "AND ACTIVITYDATE = #" & dtpActivityDate.Value.ToString("yyyy-MM-dd") & "# "

            bdconnAccess.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Item is already in use.", vbExclamation)
                ds.Dispose()
                ds = Nothing
                bdconnAccess.CloseConnection()
                bdconnAccess.Dispose()
                bdconnAccess = Nothing

                Exit Sub
            Else
                ds.Dispose()
                ds = Nothing
            End If

            Dim seq As New clsSequenceAccess(sTicketId)

            sql = "INSERT INTO TICKETOPEREP (TICKETOPEREPID, TICKETID, ACTIVITYDATE, SERVICEDESCR, COMMENTS, ACTIVITYDATEDESC) VALUES ('"
            sql = sql & seq.TicketOpeRepNextId & "','"
            sql = sql & sTicketId & "',#"
            sql = sql & dtpActivityDate.Value.ToString("yyyy-MM-dd") & "#,"
            sql = sql & util.SQLConvStrNull(txtServiceDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtComments.Text, "s") & ",'"
            sql = sql & cls.DateExten(dtpActivityDate.Value) & "')"

            bdconnAccess.ExecuteNonSQL(sql)

        Else

            If sServiceDescrOld <> txtServiceDescription.Text Then

                sql = "SELECT 1 FROM TICKETOPEREP " & _
                      "WHERE TICKETID = '" & sTicketId & "' " & _
                      "AND SERVICEDESCR = '" & txtServiceDescription.Text & "' " & _
                      "AND ACTIVITYDATE = #" & dtpActivityDate.Value.ToString("yyyy-MM-dd") & "# "

                bdconnAccess.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Item is already in use.", vbExclamation)
                    ds.Dispose()
                    ds = Nothing
                    bdconnAccess.CloseConnection()
                    bdconnAccess.Dispose()
                    bdconnAccess = Nothing
                    Exit Sub
                Else
                    ds.Dispose()
                End If

            End If

            sql = "UPDATE TICKETOPEREP SET " & _
                  "ACTIVITYDATE = #" & dtpActivityDate.Value.ToString("yyyy-MM-dd") & "# " & _
                  ",COMMENTS = " & util.SQLConvStrNull(txtComments.Text, "s") & " " & _
                  ",SERVICEDESCR = " & util.SQLConvStrNull(txtServiceDescription.Text, "s") & " " & _
                  ",ACTIVITYDATEDESC = '" & cls.DateExten(dtpActivityDate.Value) & "' " & _
                  "WHERE TICKETOPEREPID = '" & sTicketOpeRepId & "'"

            bdconnAccess.ExecuteNonSQL(sql)

            End If

        bdconnAccess.CloseConnection()
        bdconnAccess.Dispose()
        bdconnAccess = Nothing

        cls.Dispose()
        cls = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Dispose()

    End Sub

    Private Sub btnCancelDelete_Click(sender As Object, e As EventArgs) Handles btnCancelDelete.Click
        If btnCancelDelete.Text = "Cancel" Then
            Me.Dispose()
        Else
            If MsgBox("Are you want DELETE this item? This action is Irreversivel", MsgBoxStyle.YesNo) = vbYes Then

                Dim bdconnAccess As New clsBancoDadosACCESS
                Dim sql As String

                bdconnAccess.OpenConnection()

                sql = "DELETE FROM TICKETOPEREPACT WHERE TICKETOPEREPID = '" & sTicketOpeRepId & "' "
                bdconnAccess.ExecuteNonSQL(sql)

                sql = "DELETE FROM TICKETOPEREP WHERE TICKETOPEREPID = '" & sTicketOpeRepId & "' "
                bdconnAccess.ExecuteNonSQL(sql)

                bdconnAccess.CloseConnection()
                bdconnAccess.Dispose()
                bdconnAccess = Nothing

                Dim sync As New clsSyncTicket
                sync.UpdateSyncDateTime(sTicketId, "ACCESS")
                sync.Dispose()
                sync = Nothing

                Me.Dispose()

            Else
                Exit Sub
            End If
        End If

    End Sub
End Class