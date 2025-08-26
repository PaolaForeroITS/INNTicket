Public Class frmServiceTypeEdit

    Dim util As New clsUtils

    Public sServiceTypeId As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmServiceTypeEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtDescription.Text = "" Then
            MsgBox("Inform the Service Type", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection("AccBaseData")

        If sServiceTypeId = "" Then

            sql = "INSERT INTO zSQL_SERVICETYPE " &
                "([DESCRIPTION],ACTIVE,SERVICETYPECODE) VALUES ("

            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxActive.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtCode.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE zSQL_SERVICETYPE SET " &
                " [DESCRIPTION]  = " & util.SQLConvStrNull(txtDescription.Text, "s") & " " &
                " ,[ACTIVE]  = " & util.SQLConvStrNull(cbxActive.Text, "s") & " " &
                " ,[SERVICETYPECODE]  = " & util.SQLConvStrNull(txtCode.Text, "s") & " "
            sql = sql & "WHERE [SERVICETYPEID] = " & sServiceTypeId & " "

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        ds = Nothing
        bdconnSQL = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("SERVICETYPE")
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

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub
End Class