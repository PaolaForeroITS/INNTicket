Public Class frmPetrFieldEdit

    Public sPetrFieldOld As String
    Dim util As New clsUtils

    Private Sub frmPetrFieldEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtPetrFieldCode.Text = "" Then
            MsgBox("Inform the Petroleum Field", vbExclamation)
            Exit Sub
        End If

        If txtDescription.Text = "" Then
            MsgBox("Inform the Description", vbExclamation)
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection("AccBaseData")

        If sPetrFieldOld = "" Then

            sql = "INSERT INTO zSQL_PETRFIELD " &
                "([PETRFIELDCODE],DESCRIP,PETRFIELDAREA) VALUES ("

            sql = sql & util.SQLConvStrNull(txtPetrFieldCode.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtPetrFieldArea.Text, "s") & ")"

            bdconn.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE zSQL_PETRFIELD SET " &
                " [PETRFIELDCODE]  = " & util.SQLConvStrNull(txtPetrFieldCode.Text, "s") & " " &
                " ,[DESCRIP]  = " & util.SQLConvStrNull(txtDescription.Text, "s") & " " &
                " ,[PETRFIELDAREA]  = " & util.SQLConvStrNull(txtPetrFieldArea.Text, "s") & " " &
                " WHERE [PETRFIELDID] = " & sPetrFieldOld & ""
            bdconn.ExecuteNonSQL(sql)

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("PETRFIELD")
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
End Class