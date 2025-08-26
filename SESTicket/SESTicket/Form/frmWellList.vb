Public Class frmWellList

    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmWellList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.WELL' table. You can move, or remove it, as needed.
        Me.WELLTableAdapter.Fill(Me.SESTicketSQLDataSet.WELL)
        Filter()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvWell_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWell.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim frm As New frmWellEdit
        With frm
            .CarregaCbx()
            .txtWellID.Text = dgvWell.CurrentRow.Cells("colWellId").Value
            .txtName.Text = dgvWell.CurrentRow.Cells("colName").Value
            .cbxSite.Text = dgvWell.CurrentRow.Cells("colSiteName").Value
            .cbxCountry.Text = dgvWell.CurrentRow.Cells("colCountry").Value
            .cbxState.Text = dgvWell.CurrentRow.Cells("colState").Value
            .cbxCity.Text = dgvWell.CurrentRow.Cells("colCity").Value
            .cbxActive.Text = dgvWell.CurrentRow.Cells("colActive").Value
            .cbxField.Text = dgvWell.CurrentRow.Cells("colPetrFieldId").Value
        End With

        If util.TrataDBNull(dgvWell.CurrentRow.Cells("colRigId").Value) = "" Then
            frmWellEdit.cbxRig.SelectedValue = -1
        Else
            frmWellEdit.cbxRig.SelectedValue = dgvWell.CurrentRow.Cells("colRigId").Value
        End If

        Me.Cursor = Cursors.Arrow

        With frm
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        Me.WELLTableAdapter.Fill(Me.SESTicketSQLDataSet.WELL)
        Filter()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvWell.Rows.Count - 1
            If dgvWell.Rows(i).Cells("colActive").Value = "YES" Then
                dgvWell.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                With dgvWell.Rows(i)
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

        WELLBindingSource.Filter = sfilter
        dgvWell.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

    Private Sub mnuNewItem_Click_1(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmWellEdit
        With frm
            .CarregaCbx()
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        Me.WELLTableAdapter.Fill(Me.SESTicketSQLDataSet.WELL)
        Filter()
    End Sub

    Private Sub mnuExportData_Click(sender As Object, e As EventArgs) Handles mnuExportData.Click
        Dim frm As New frmDataExpLayout
        frm.sLayoutType = "WELL"
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub mnuImportData_Click(sender As Object, e As EventArgs) Handles mnuImportData.Click
        Dim frm As New frmDataImp
        frm.sLayoutType = "WELL"
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.WELL' table. You can move, or remove it, as needed.
        Me.WELLTableAdapter.Fill(Me.SESTicketSQLDataSet.WELL)
        Filter()
    End Sub

    Private Sub dgvWell_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWell.CellContentClick

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
              "and obj.OBJECTFORM = 'frmWellList' " &
              "and usr.USERNAME = '" & Me.sUsername & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bPermitInsUpd" Then
                    mnuNewItem.Enabled = False
                    bPermitInsUpd = False
                ElseIf sObject = "bPermitExpImpData" Then
                    mnuExportData.Enabled = False
                    mnuImportData.Enabled = False
                End If
            Next

        End If

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

#End Region

End Class