Public Class frmWorkerList

    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True
    Dim bPermitBonusManHourValue As Boolean = True

    Private Sub frmWorkerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.WORKER' table. You can move, or remove it, as needed.
        Me.WORKERTableAdapter.Fill(Me.SESTicketSQLDataSet.WORKER)
        Filter()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvWorker_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorker.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmWorkerEdit

        With frm
            .txtWorkerID.Text = dgvWorker.CurrentRow.Cells("colWorkerID").Value
            .txtName1.Text = dgvWorker.CurrentRow.Cells("colName1").Value
            .txtName2.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colName2").Value)
            .txtSurname1.Text = dgvWorker.CurrentRow.Cells("colSurname1").Value
            .txtSurname2.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colSurname2").Value)
            .txtAppointment.Text = dgvWorker.CurrentRow.Cells("colAppointment").Value
            .txtSubAccount.Text = dgvWorker.CurrentRow.Cells("colSubAccount").Value
            .txtEmail.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colEmail").Value)
            .txtBonusValue.Text = util.ConcatDecimalStr(dgvWorker.CurrentRow.Cells("colBonusValue").Value)
            .txtManHourValue.Text = util.ConcatDecimalStr(dgvWorker.CurrentRow.Cells("colManHourValue").Value)
            .cbxActive.Text = dgvWorker.CurrentRow.Cells("colActive").Value
            .txtPhone.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colPhone").Value)
            .bPermitBonusManHourValue = Me.bPermitBonusManHourValue
        End With

        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.WORKERTableAdapter.Fill(Me.SESTicketSQLDataSet.WORKER)
        Filter()

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmWorkerEdit
        frm.bPermitBonusManHourValue = Me.bPermitBonusManHourValue
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.WORKERTableAdapter.Fill(Me.SESTicketSQLDataSet.WORKER)
        Filter()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvWorker.Rows.Count - 1
            If dgvWorker.Rows(i).Cells("colActive").Value = "YES" Then
                dgvWorker.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                With dgvWorker.Rows(i)
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

        WORKERBindingSource.Filter = sfilter
        dgvWorker.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

    Private Sub mnuExportData_Click(sender As Object, e As EventArgs) Handles mnuExportData.Click
        Dim frm As New frmDataExpLayout
        frm.sLayoutType = "WORKER"
        frm.Size = New Size(398, 93)
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub mnuImportData_Click(sender As Object, e As EventArgs) Handles mnuImportData.Click
        Dim frm As New frmDataImp
        frm.sLayoutType = "WORKER"
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        Me.WORKERTableAdapter.Fill(Me.SESTicketSQLDataSet.WORKER)
        Filter()
    End Sub

    Private Sub dgvWorker_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorker.CellContentClick

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
              "and obj.OBJECTFORM = 'frmWorkerList' " &
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
                ElseIf sObject = "bPermitBonusManHourValue" Then
                    dgvWorker.Columns("colBonusValue").Visible = False
                    dgvWorker.Columns("colManHourValue").Visible = False
                    bPermitBonusManHourValue = False

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