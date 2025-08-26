Public Class frmEquipmentList

    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmEquipmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.EQUIPMENT' table. You can move, or remove it, as needed.
        Me.EQUIPMENTTableAdapter.Fill(Me.SESTicketSQLDataSet.EQUIPMENT)
        Filter()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvEquipment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipment.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmEquipmentEdit

        With frm
            .txtEquipmentID.Text = dgvEquipment.CurrentRow.Cells("colEquipmentID").Value
            .txtDescription.Text = dgvEquipment.CurrentRow.Cells("colDescription").Value
            .txtModel.Text = util.TrataDBNull(dgvEquipment.CurrentRow.Cells("colModel").Value)
            .txtSerial.Text = util.TrataDBNull(dgvEquipment.CurrentRow.Cells("colSerial").Value)
            .txtTag.Text = util.TrataDBNull(dgvEquipment.CurrentRow.Cells("colTag").Value)
            .cbxActive.Text = util.TrataDBNull(dgvEquipment.CurrentRow.Cells("colActive").Value)
            .txtUnit.Text = util.TrataDBNull(dgvEquipment.CurrentRow.Cells("colUnit").Value)
        End With

        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.EQUIPMENTTableAdapter.Fill(Me.SESTicketSQLDataSet.EQUIPMENT)
        Filter()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvEquipment.Rows.Count - 1
            If dgvEquipment.Rows(i).Cells("colActive").Value = "YES" Then
                dgvEquipment.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                With dgvEquipment.Rows(i)
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

        EQUIPMENTBindingSource.Filter = sfilter
        dgvEquipment.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

    Private Sub mnuNewItem_Click_1(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmEquipmentEdit
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.EQUIPMENTTableAdapter.Fill(Me.SESTicketSQLDataSet.EQUIPMENT)
        Filter()
    End Sub

    Private Sub mnuExportData_Click(sender As Object, e As EventArgs) Handles mnuExportData.Click
        Dim frm As New frmDataExpLayout
        frm.sLayoutType = "EQUIPMENT"
        frm.AutoSize = False
        frm.Size = New Size(398, 93)
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub mnuImportData_Click(sender As Object, e As EventArgs) Handles mnuImportData.Click
        Dim frm As New frmDataImp
        frm.sLayoutType = "EQUIPMENT"
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.EQUIPMENTTableAdapter.Fill(Me.SESTicketSQLDataSet.EQUIPMENT)
        Filter()
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
              "and obj.OBJECTFORM = 'frmEquipmentList' " &
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

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvEquipment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipment.CellContentClick

    End Sub

#End Region

End Class