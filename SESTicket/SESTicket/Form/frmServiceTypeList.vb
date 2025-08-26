Public Class frmServiceTypeList

    Dim util As New clsUtils

    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmServiceTypeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICETYPE' table. You can move, or remove it, as needed.
        Me.SERVICETYPETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICETYPE)
        Filter()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvServiceType_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceType.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmServiceTypeEdit
        With frm
            .txtDescription.Text = dgvServiceType.CurrentRow.Cells("colDescription").Value
            .cbxActive.Text = dgvServiceType.CurrentRow.Cells("colActive").Value.ToString
            .txtCode.Text = util.TrataDBNull(dgvServiceType.CurrentRow.Cells("colServiceTypeCode").Value)
            .sServiceTypeId = dgvServiceType.CurrentRow.Cells("colServiceTypeID").Value
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICETYPE' table. You can move, or remove it, as needed.
        Me.SERVICETYPETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICETYPE)
        Filter()

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmServiceTypeEdit
        With frm
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICETYPE' table. You can move, or remove it, as needed.
        Me.SERVICETYPETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICETYPE)
        Filter()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvServiceType.Rows.Count - 1
            If dgvServiceType.Rows(i).Cells("colActive").Value = "YES" Then
                dgvServiceType.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                With dgvServiceType.Rows(i)
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

        SERVICETYPEBindingSource.Filter = sfilter
        dgvServiceType.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

    Private Sub dgvServiceType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceType.CellContentClick

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
              "and obj.OBJECTFORM = 'frmServiceTypeList' " &
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

#End Region


End Class