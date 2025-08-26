Public Class frmRigList

    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmRigList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRig()

        'User Grants
        FormUserGrant()
    End Sub

    Private Sub LoadRig()
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.RIG' table. You can move, or remove it, as needed.
        Me.RIGTableAdapter.Fill(Me.SESTicketSQLDataSet.RIG)
        RIGBindingSource.Filter = "RIGID <> ''"
        dgvRig.Refresh()

    End Sub

    Private Sub dgvRig_DoubleClick(sender As Object, e As EventArgs) Handles dgvRig.DoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        If dgvRig.RowCount > 0 Then

            Me.Cursor = Cursors.WaitCursor

            Dim frm As New frmRigEdit
            With frm
                .sRigId = dgvRig.CurrentRow.Cells("colRigId").Value
                .txtRig.Text = dgvRig.CurrentRow.Cells("colRigId").Value
                .ShowDialog()
                .Dispose()
            End With
            frm = Nothing
            Me.Cursor = Cursors.Arrow

            LoadRig()

        End If


    End Sub

    Private Sub dgvRig_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRig.CellContentClick

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmRigEdit
        With frm
            .sRigId = ""
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        LoadRig()

    End Sub

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
              "and obj.OBJECTFORM = 'frmRigList' " &
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

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

#End Region

End Class