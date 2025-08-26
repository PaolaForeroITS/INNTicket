Public Class frmUserRightEdit

    Public sUsername As String
    Public sUsr As String

    Dim sGrid As String = ""
    Dim bUpd As Boolean = False

    Public bIsDataUpd As Boolean = False
    Private Sub frmUserRightEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshdgvObjGroup()
    End Sub

    Private Sub dgvObjGroup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObjGroup.CellClick
        RefreshdgvObjGroupItem()
    End Sub

    Private Sub dgvObjGroup_SelectionChanged(sender As Object, e As EventArgs) Handles dgvObjGroup.SelectionChanged
        If bUpd = True Then
            Exit Sub
        End If
        RefreshdgvObjGroupItem()
    End Sub

    Private Sub RefreshdgvObjGroupItem()

        Try

            txtSubGroup.Text = dgvObjGroup.CurrentRow.Cells("colSubGroup").Value

            Dim ObjGroupId As Integer = dgvObjGroup.CurrentRow.Cells("colObjectGroupId").Value
            Me.OBJECTGROUPITEM_VTableAdapter.Fill(Me.SESTicketSQLDataSet.OBJECTGROUPITEM_V, sUsr, ObjGroupId)

            FormatdgvObjGroupItem()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormatdgvObjGroupItem()
        For i = 0 To dgvObjGroupItem.Rows.Count - 1

            If dgvObjGroupItem.Rows(i).Cells("colEnableOpt").Value = "YES" Then
                dgvObjGroupItem.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                dgvObjGroupItem.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub FormatdgvObjGroup()
        For i = 0 To dgvObjGroup.Rows.Count - 1
            If dgvObjGroup.Rows(i).Cells("colEnable").Value = "YES" Then
                dgvObjGroup.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                dgvObjGroup.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub RefreshdgvObjGroup()
        Try
            bUpd = True
            Me.OBJECTGROUP_VTableAdapter.Fill(Me.SESTicketSQLDataSet.OBJECTGROUP_V, sUsr)
            FormatdgvObjGroup()
            RefreshdgvObjGroupItem()
            bUpd = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChangeGrants(ByVal sSender As String)

        Dim grd As DataGridView

        If sGrid = "dgvObjGroup" Then
            grd = dgvObjGroup
        ElseIf sGrid = "dgvObjGroupItem" Then
            grd = dgvObjGroupItem
        Else
            Exit Sub
        End If

        If grd.SelectedRows.Count = 0 Then
            MsgBox("Select Item", vbInformation)
            Exit Sub
        End If


        Dim bdconn As New clsBancoDadosSQL

        Try

            Me.Cursor = Cursors.WaitCursor

            Dim sEnable As String

            If sSender = "Grant" Then
                sEnable = "YES"
            Else
                sEnable = "NO"
            End If

            bdconn.OpenConnection()

            Dim sql As String

            For Each row As DataGridViewRow In grd.SelectedRows

                If sGrid = "dgvObjGroup" Then
                    sql = "UPDATE OBJECTGROUPUSER SET ENABLE='" & sEnable & "' " &
                           "WHERE OBJECTGROUPUSERID = " & row.Cells("colObjectGroupUserId").Value.ToString
                    bdconn.ExecuteNonSQL(sql)

                    sql = "UPDATE OBJECTGROUPITEMUSER SET [ENABLE] = '" & sEnable & "' " &
                        "FROM OBJECTGROUPITEMUSER  " &
                        "WHERE USERNAME = '" & sUsr & "' " &
                        "AND OBJECTGROUPITEMID IN (SELECT OBJECTGROUPITEMID FROM OBJECTGROUPITEM WHERE OBJECTGROUPID=" & row.Cells("colObjectGroupId").Value.ToString() & ") "
                    bdconn.ExecuteNonSQL(sql)
                ElseIf sGrid = "dgvObjGroupItem" Then
                    sql = "UPDATE OBJECTGROUPITEMUSER Set ENABLE='" & sEnable & "' " &
                        "WHERE OBJECTGROUPITEMUSERID = " & row.Cells("colObjectGroupItemUserId").Value.ToString

                    bdconn.ExecuteNonSQL(sql)
                End If

            Next

            If sGrid = "dgvObjGroup" Then
                RefreshdgvObjGroup()
            ElseIf sGrid = "dgvObjGroupItem" Then
                RefreshdgvObjGroupItem()
            End If

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("USER")
            syn.Dispose()
            syn = Nothing

            bIsDataUpd = True

            Me.Cursor = Cursors.Arrow

        Catch ex As System.Exception
            Me.Cursor = Cursors.Arrow
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PermitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermitToolStripMenuItem.Click
        ChangeGrants("Grant")
    End Sub

    Private Sub DenyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DenyToolStripMenuItem.Click
        Dim a As String = sender.ToString()
        ChangeGrants("Deny")
    End Sub

    Private Sub dgvObjGroup_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvObjGroup.MouseClick
        sGrid = "dgvObjGroup"
    End Sub

    Private Sub dgvObjGroup_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvObjGroup.MouseDown
        sGrid = "dgvObjGroup"
    End Sub

    Private Sub dgvObjGroupItem_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvObjGroupItem.MouseClick
        sGrid = "dgvObjGroupItem"
    End Sub

    Private Sub dgvObjGroupItem_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvObjGroupItem.CellMouseDown
        sGrid = "dgvObjGroupItem"
    End Sub

    Private Sub mnuCopyFromUser_Click(sender As Object, e As EventArgs) Handles mnuCopyFromUser.Click
        Dim frm As New frmUserRightEditClone
        With frm
            .sUsername = Me.susername
            .sUsr = Me.sUsr
            .ShowDialog()
        End With
        If frm.bIsDataUpd = True Then
            bIsDataUpd = True
            RefreshdgvObjGroup()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub
End Class