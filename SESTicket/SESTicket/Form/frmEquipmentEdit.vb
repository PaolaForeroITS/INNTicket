Public Class frmEquipmentEdit

    Dim sEquipmentIDold As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If txtEquipmentID.Text = "" Then
            MsgBox("Inform the EquipmentID", vbExclamation)
            Exit Sub
        End If

        If txtDescription.Text = "" Then
            MsgBox("Inform the Description", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        Dim util As New clsUtils

        If sEquipmentIDold = "" Then

            sql = "SELECT 1 AS QDE FROM [EQUIPMENT] WHERE EQUIPMENTID = '" & txtEquipmentID.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The EquipmentID is being used by another Equipment.", vbExclamation)
                ds.Dispose()
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                Exit Sub
            End If

            sql = "INSERT INTO [EQUIPMENT] " &
                  "([EQUIPMENTID],[DESCRIPTION],[MODEL],[SERIAL],[TAG],[ACTIVE],[UNIT]) VALUES ('"

            sql = sql & txtEquipmentID.Text & "','"
            sql = sql & txtDescription.Text & "',"
            sql = sql & util.SQLConvStrNull(txtModel.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSerial.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtTag.Text, "s") & ",'"
            sql = sql & cbxActive.Text & "',"
            sql = sql & util.SQLConvStrNull(txtUnit.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sEquipmentIDold <> txtEquipmentID.Text Then

                sql = "SELECT 1 AS QDE FROM [EQUIPMENT] WHERE EQUIPMENTID = '" & txtEquipmentID.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The EquipmentID is being used by another Equipment.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    Exit Sub
                End If
            End If

            sql = "UPDATE [EQUIPMENT] SET " &
                "[EQUIPMENTID] = '" & txtEquipmentID.Text & "' " &
                ",[DESCRIPTION] = '" & txtDescription.Text & "' " &
                ",[MODEL] = " & util.SQLConvStrNull(txtModel.Text, "s") & " " &
                ",[SERIAL] =" & util.SQLConvStrNull(txtSerial.Text, "s") & " " &
                ",[TAG] = " & util.SQLConvStrNull(txtTag.Text, "s") & " " &
                ",[ACTIVE] = '" & cbxActive.Text & "' " &
                ",[UNIT] = " & util.SQLConvStrNull(txtUnit.Text, "s") & " "

            If sEquipmentIDold = "" Then
                sql = sql & "WHERE [EQUIPMENTID] = '" & txtEquipmentID.Text & "'"
            Else
                sql = sql & "WHERE [EQUIPMENTID] = '" & sEquipmentIDold & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("EQUIPMENT")
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

    Private Sub frmEquipmentEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sEquipmentIDold = txtEquipmentID.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxActive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxActive.SelectedIndexChanged

    End Sub
End Class