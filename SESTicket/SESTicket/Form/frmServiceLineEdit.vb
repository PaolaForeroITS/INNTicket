Public Class frmServiceLineEdit

    Dim util As New clsUtils
    Public sServiceLineNameOld As String

    Private Sub frmServiceLineEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sServiceLineNameOld = txtName.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtName.Text = "" Then
            MsgBox("Inform the Service Line", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection("AccBaseData")

        If sServiceLineNameOld = "" Then

            sql = "SELECT 1 AS QDE FROM zSQL_SERVICELINE WHERE [NAME]= " & util.SQLConvStrNull(txtName.Text.ToUpper, "s") & " "
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Service Line is already exists.", vbExclamation)
                ds.Dispose()
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                ds = Nothing
                bdconnSQL = Nothing
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            sql = "INSERT INTO zSQL_SERVICELINE " & _
                "([NAME],[ACTIVE]) VALUES ("

            sql = sql & util.SQLConvStrNull(txtName.Text.ToUpper, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxActive.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sServiceLineNameOld <> txtName.Text Then

                sql = "SELECT 1 AS QDE FROM zSQL_SERVICELINE WHERE [NAME]= " & util.SQLConvStrNull(txtName.Text.ToUpper, "s") & " "
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Me.Cursor = Cursors.Arrow
                    MsgBox("The Service Line is already exists.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    ds = Nothing
                    bdconnSQL = Nothing
                    Me.Cursor = Cursors.Arrow
                    Exit Sub
                End If

            End If

            sql = "UPDATE zSQL_SERVICELINE SET " & _
                " [NAME]  = " & util.SQLConvStrNull(txtName.Text.ToUpper, "s") & " " & _
                " ,[ACTIVE]  = " & util.SQLConvStrNull(cbxActive.Text, "s") & " "

            If sServiceLineNameOld <> "" Then
                sql = sql & "WHERE [NAME] = " & util.SQLConvStrNull(sServiceLineNameOld, "s") & " "
            Else
                sql = sql & "WHERE [NAME] = " & util.SQLConvStrNull(txtName.Text.ToUpper, "s") & " "
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        ds = Nothing
        bdconnSQL = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("SERVICELINE")
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
End Class