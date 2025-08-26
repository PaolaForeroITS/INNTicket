Public Class frmRigEdit

    Public sRigId As String

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtRig.Text.Trim = "" Then
            MsgBox("Inform the Rig", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection("AccBaseData")

        If sRigId = "" Then

            sql = "SELECT 1 AS QDE FROM zSQL_RIG WHERE [RIGID]= '" & txtRig.Text.Trim & "'"
            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Me.Cursor = Cursors.Arrow
                MsgBox("The Rig is being used by another one.", vbExclamation)
                ds.Dispose()
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                ds = Nothing
                Exit Sub
            End If

            sql = "INSERT INTO zSQL_RIG " & _
                "([RIGID]) VALUES ('" & txtRig.Text.Trim & "')"

            bdconn.ExecuteNonSQL(sql)

        Else

            If sRigId <> txtRig.Text.Trim Then

                sql = "SELECT 1 AS QDE FROM zSQL_RIG WHERE [RIGID]= '" & txtRig.Text.Trim & "'"
                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Rig is being used by another one.", vbExclamation)
                    ds.Dispose()
                    bdconn.CloseConnection()
                    bdconn.Dispose()
                    Exit Sub
                End If

                sql = "UPDATE zSQL_RIG SET " & _
                    " [RIGID]  = '" & txtRig.Text.Trim & "' " & _
                    "WHERE [RIGID] = '" & sRigId & "'"
                bdconn.ExecuteNonSQL(sql)

                sql = "UPDATE zSQL_WELL SET RIGID = '" & txtRig.Text.Trim & "' " & _
                      "WHERE [RIGID] = '" & sRigId & "'"
                bdconn.ExecuteNonSQL(sql)

            End If

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("RIG")

        If sRigId <> "" Then
            syn.UpdateVersionBaseSQL("WELL")
        End If
        syn.Dispose()
        syn = Nothing
        '------
        ' Me.Hide()
        Me.Cursor = Cursors.Arrow

        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Dispose()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmRigEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If sRigId = "" Then
            mnuDelete.Visible = False
        End If

    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        If MsgBox("Do you want DELETE the Rig?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection("AccBaseData")

        sql = "DELETE FROM zSQL_RIG WHERE [RIGID] = '" & sRigId & "'"
        bdconn.ExecuteNonSQL(sql)

        sql = "UPDATE zSQL_WELL SET RIGID = NULL " & _
              "WHERE [RIGID] = '" & sRigId & "'"
        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        ds.Dispose()
        bdconn = Nothing
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("RIG")
        syn.UpdateVersionBaseSQL("WELL")
        syn.Dispose()
        syn = Nothing

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