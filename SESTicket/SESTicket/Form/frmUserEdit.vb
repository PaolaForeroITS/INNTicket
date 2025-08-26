Public Class frmUserEdit

    Public sUserid As String = ""
    Public sUsername As String

    Public bIsDataUpd As Boolean = False

    Private Sub frmUserEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sUserid <> "" Then
            txtUsername.ReadOnly = True
        Else
            mnuUserRight.Enabled = False
        End If
    End Sub

    Private Sub cbxRight_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtUsername.Text = "" Then
            MsgBox("Inform the Login", vbExclamation)
            Exit Sub
        End If

        If txtFullName.Text = "" Then
            MsgBox("Inform the Full Name", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        Dim util As New clsUtils

        If sUserid = "" Then

            sql = "SELECT 1 AS QDE FROM [USER] WHERE USERNAME = '" & txtUsername.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Username is being used by another User.", vbExclamation)
                ds.Dispose()
                ds = Nothing
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing
                Exit Sub
            End If
            ds.Dispose()
            ds = Nothing

            ds = New DataSet

            sql = "SELECT max(USERID)+1 as USERID FROM [USER] "
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    sUserid = ds.Tables(0).Rows(i)("USERID").ToString()
                Next
            End If
            ds.Dispose()

            sql = "INSERT INTO [USER] " &
                  "(USERID,[NAME],[USERNAME],[ACTIVE],[USERLANG]) VALUES ("

            sql = sql & sUserid & ",'"
            sql = sql & txtFullName.Text & "','"
            sql = sql & txtUsername.Text & "','"
            sql = sql & cbxActive.Text & "','" & cbxUserLang.Text & "')"

            bdconnSQL.ExecuteNonSQL(sql)

            sql = "INSERT INTO CONSEC (USERID,CONSEC,USERNAME) VALUES (" &
                  sUserid & ",0,'" & txtUsername.Text & "')"
            bdconnSQL.ExecuteNonSQL(sql)

            sql = "INSERT INTO OBJECTGROUPUSER (USERNAME,OBJECTGROUPID,[ENABLE]) " &
                 "SELECT '" & txtUsername.Text & "' as USERNAME, OBJECTGROUPID,[ENABLE] FROM OBJECTGROUP "
            bdconnSQL.ExecuteNonSQL(sql)

            sql = "INSERT INTO OBJECTGROUPITEMUSER (USERNAME,OBJECTGROUPITEMID,[ENABLE]) " &
                  "select '" & txtUsername.Text & "' as USERNAME,OBJECTGROUPITEMID,[ENABLE] from OBJECTGROUPITEM"
            bdconnSQL.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE [USER] SET  " &
                  "[NAME] = '" & txtFullName.Text & "' " &
                  ",[ACTIVE] =  '" & cbxActive.Text & "' " &
                  ",[USERLANG] =  '" & cbxUserLang.Text & "' " &
                  "WHERE USERID=" & sUserid & ""

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bIsDataUpd = True
        mnuUserRight.Enabled = True

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("USER")
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

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub mnuUserRight_Click(sender As Object, e As EventArgs) Handles mnuUserRight.Click
        Dim frm As New frmUserRightEdit
        With frm
            .sUsername = Me.sUsername
            .sUsr = txtUsername.Text
            .ShowDialog()
        End With
        If frm.bIsDataUpd = True Then
            bIsDataUpd = True
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub cbxUserLang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxUserLang.KeyPress
        e.Handled = True
    End Sub
End Class