Public Class frmUserRightEditClone

    Public sUsername As String
    Public sUsr As String
    Public bIsDataUpd As Boolean = False

    Private Sub frmUserRightEditClone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.CbxUserCloneRightTableAdapter.Fill(Me.SESTicketSQLDataSet.cbxUserCloneRight, sUsr)
            Me.Cursor = Cursors.Arrow
        Catch ex As System.Exception
            Me.Cursor = Cursors.Arrow
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If MsgBox("Do you want clone the Righs from " & cbxUserCloneRight1.Text & " to user " & sUsr & "?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Dim bdconn As New clsBancoDadosSQL
        Dim sql As String

        Try

            Me.Cursor = Cursors.WaitCursor

            bdconn.OpenConnection()

            sql = "DELETE FROM OBJECTGROUPUSER WHERE USERNAME = '" & sUsr & "'"
            bdconn.ExecuteNonSQL(sql)

            sql = "DELETE FROM OBJECTGROUPITEMUSER WHERE USERNAME = '" & sUsr & "'"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO OBJECTGROUPUSER (USERNAME,OBJECTGROUPID,ENABLE) " &
                 "SELECT '" & sUsr & "',U.OBJECTGROUPID,U.ENABLE " &
                 "FROM OBJECTGROUPUSER U " &
                 "WHERE U.USERNAME = '" & cbxUserCloneRight1.SelectedValue & "'"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO OBJECTGROUPITEMUSER (USERNAME,OBJECTGROUPITEMID,ENABLE) " &
                  "SELECT '" & sUsr & "',U.OBJECTGROUPITEMID,U.ENABLE " &
                  "FROM OBJECTGROUPITEMUSER U " &
                  "WHERE U.USERNAME = '" & cbxUserCloneRight1.SelectedValue & "'"
            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("USER")
            syn.Dispose()
            syn = Nothing

            Me.Cursor = Cursors.Arrow

            bIsDataUpd = True

            Me.Dispose()

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
        End Try

    End Sub


    Private Sub cbxUserCloneRight1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxUserCloneRight1.KeyPress
        e.Handled = True
    End Sub
End Class