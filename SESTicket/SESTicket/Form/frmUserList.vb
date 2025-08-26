Public Class frmUserList

    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

#Region "Default Methods"

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.USER' table. You can move, or remove it, as needed.
            Me.USERTableAdapter.Fill(Me.SESTicketSQLDataSet.USER)
            Filter()

            '--User Grants
            FormUserGrant()

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try

    End Sub

    Private Sub dgvUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        If dgvUser.RowCount > 0 Then
            Dim frm As New frmUserEdit
            With frm
                .sUserid = dgvUser.CurrentRow.Cells("colUserID").Value
                .txtUsername.Text = dgvUser.CurrentRow.Cells("colUsername").Value
                .txtFullName.Text = dgvUser.CurrentRow.Cells("colName").Value
                .cbxActive.Text = dgvUser.CurrentRow.Cells("colActive").Value
                .cbxUserLang.Text = dgvUser.CurrentRow.Cells("colUserLang").Value
                .txtUsername.Enabled = False
            End With

            frm.ShowDialog()

            If frm.bIsDataUpd = True Then
                Me.USERTableAdapter.Fill(Me.SESTicketSQLDataSet.USER)
                Filter()
            End If
            frm.Dispose()
            frm = Nothing

        End If
    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmUserEdit
        frm.ShowDialog()

        If frm.bIsDataUpd = True Then
            Me.USERTableAdapter.Fill(Me.SESTicketSQLDataSet.USER)
            Filter()
        End If
        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvUser.Rows.Count - 1
            If dgvUser.Rows(i).Cells("colActive").Value = "YES" Then
                dgvUser.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                With dgvUser.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Red
                End With
            End If
        Next
    End Sub

    Private Sub Filter()
        Dim sfilter As String = ""
        Dim sActive As String = ""

        If chkYes.Checked = True Then
            sActive = "'YES'"
        End If

        If chkNo.Checked = True Then
            If sActive <> "" Then
                sActive = sActive & ","
            End If
            sActive = sActive & "'NO'"
        End If

        If sActive <> "" Then
            sfilter = sfilter & "ACTIVE IN (" & sActive & ")"
        Else
            sfilter = sfilter & "ACTIVE IN ('NOTHING')"
        End If

        USERBindingSource.Filter = sfilter
        dgvUser.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

#End Region

#Region "FormUserGrants"

    Private Sub FormUserGrant()

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet


        sql = "SELECT obj.OBJECTNAME, obj.OBJECTTYPE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and usr.ENABLE = 'NO'  " &
              "and obj.OBJECTFORM = 'frmUserList' " &
              "and usr.USERNAME = '" & Me.sUsername & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bPermitInsUpd" Then
                    mnuNewItem.Enabled = False
                    bPermitInsUpd = False
                End If
            Next

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvUser_Sorted(sender As Object, e As EventArgs) Handles dgvUser.Sorted
        ChangeColorGrid()
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick

    End Sub

#End Region

End Class