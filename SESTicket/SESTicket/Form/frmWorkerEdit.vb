Public Class frmWorkerEdit
    Dim util As New clsUtils
    Dim sWorkerIDOld As String = ""

    Public bPermitBonusManHourValue As Boolean = True

    Private Sub txtBonusValue_TextChanged(sender As Object, e As EventArgs) Handles txtBonusValue.TextChanged
        util.TextBoxMoeda(txtBonusValue)
    End Sub

    Private Sub txtManHourValue_TextChanged(sender As Object, e As EventArgs) Handles txtManHourValue.TextChanged
        util.TextBoxMoeda(txtManHourValue)
    End Sub

    Private Sub frmWorkerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sWorkerIDOld = txtWorkerID.Text

        If sWorkerIDOld = "" Then
            txtBonusValue.Text = 0
            txtManHourValue.Text = 0
        End If

        If bPermitBonusManHourValue = False Then
            txtBonusValue.Visible = False
            txtManHourValue.Visible = False
            lblBonus.Visible = False
            lblManHour.Visible = False
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtWorkerID.Text = "" Then
            MsgBox("Inform the WorkerID", vbExclamation)
            Exit Sub
        End If

        If txtName1.Text = "" Then
            MsgBox("Inform the Name1", vbExclamation)
            Exit Sub
        End If

        If txtSurname1.Text = "" Then
            MsgBox("Inform the Surname1", vbExclamation)
            Exit Sub
        End If

        If txtAppointment.Text = "" Then
            MsgBox("Inform the Appointment", vbExclamation)
            Exit Sub
        End If

        If txtSubAccount.Text = "" Then
            MsgBox("Inform the SubAccount", vbExclamation)
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        If sWorkerIDOld = "" Then

            sql = "SELECT 1 AS QDE FROM [WORKER] WHERE WORKERID = '" & txtWorkerID.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Me.Cursor = Cursors.Arrow
                MsgBox("The WorkerID is being used by another Worker.", vbExclamation)
                ds.Dispose()
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing
                Exit Sub
            End If

            sql = "INSERT INTO [WORKER] " & _
                "([WORKERID],[NAME1],[NAME2],[SURNAME1],[SURNAME2],[APPOINTMENT] " & _
                ",[SUBACCOUNT],[EMAIL],[BONUSVALUE],[MANHOURVALUE],[ACTIVE],[PHONE]) VALUES ('"

            sql = sql & txtWorkerID.Text & "','"
            sql = sql & txtName1.Text & "',"
            sql = sql & util.SQLConvStrNull(txtName2.Text, "s") & ",'"
            sql = sql & txtSurname1.Text & "',"
            sql = sql & util.SQLConvStrNull(txtSurname2.Text, "s") & ",'"
            sql = sql & txtAppointment.Text & "','"
            sql = sql & txtSubAccount.Text & "',"
            sql = sql & util.SQLConvStrNull(txtEmail.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtBonusValue.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtManHourValue.Text, "n") & ",'"
            sql = sql & cbxActive.Text & "',"
            sql = sql & util.SQLConvStrNull(txtPhone.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sWorkerIDOld <> txtWorkerID.Text Then

                sql = "SELECT 1 AS QDE FROM [WORKER] WHERE WORKERID = '" & txtWorkerID.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Me.Cursor = Cursors.Arrow
                    MsgBox("The WorkerID is being used by another Worker.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    bdconnSQL = Nothing
                    ds = Nothing
                    Exit Sub
                End If
            End If

            sql = "UPDATE [WORKER] SET " & _
                " [WORKERID] = '" & txtWorkerID.Text & "' " & _
                ",[NAME1] = '" & txtName1.Text & "' " & _
                ",[NAME2] = " & util.SQLConvStrNull(txtName2.Text, "s") & " " & _
                ",[SURNAME1] = '" & txtSurname1.Text & "' " & _
                ",[SURNAME2] = " & util.SQLConvStrNull(txtSurname2.Text, "s") & " " & _
                ",[APPOINTMENT] = '" & txtAppointment.Text & "' " & _
                ",[SUBACCOUNT] = '" & txtSubAccount.Text & "' " & _
                ",[EMAIL] = " & util.SQLConvStrNull(txtEmail.Text, "s") & " " & _
                ",[BONUSVALUE] = " & util.SQLConvStrNull(txtBonusValue.Text, "n") & " " & _
                ",[MANHOURVALUE] = " & util.SQLConvStrNull(txtManHourValue.Text, "n") & " " & _
                ",[ACTIVE] = '" & cbxActive.Text & "' "
            sql = sql & ",[PHONE] = " & util.SQLConvStrNull(txtPhone.Text, "s") & " "

            If sWorkerIDOld <> "" Then
                sql = sql & "WHERE [WORKERID] = '" & sWorkerIDOld & "'"
            Else
                sql = sql & "WHERE [WORKERID] = '" & txtWorkerID.Text & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        'FULLNAME update
        sql = "UPDATE WORKER SET " &
              "FULLNAME = dbo.[fnStringFirstUpper](LTrim(NAME1) + IIf(SURNAME1 IS NOT NULL, + ' ' + LTRIM(SURNAME1),''))"
        bdconnSQL.ExecuteNonSQL(sql)

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        ds = Nothing
        bdconnSQL = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("WORKER")
        syn.Dispose()
        syn = Nothing

        '------
        'Me.Hide()
        Me.Cursor = Cursors.Arrow


        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Dispose()

    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxActive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxActive.SelectedIndexChanged

    End Sub
End Class