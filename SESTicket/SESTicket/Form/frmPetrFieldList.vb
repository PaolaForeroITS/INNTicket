Public Class frmPetrFieldList

    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True
    Private Sub frmPetrFieldList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.PETRFIELD' table. You can move, or remove it, as needed.
        Me.PETRFIELDTableAdapter.Fill(Me.SESTicketSQLDataSet.PETRFIELD)

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvPetrField_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPetrField.CellContentClick

    End Sub

    Private Sub dgvPetrField_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPetrField.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmPetrFieldEdit
        With frm
            .sPetrFieldOld = dgvPetrField.CurrentRow.Cells("colPetrFieldID").Value
            .txtPetrFieldCode.Text = util.TrataDBNull(dgvPetrField.CurrentRow.Cells("colPetrFieldCode").Value)
            .txtDescription.Text = util.TrataDBNull(dgvPetrField.CurrentRow.Cells("colDescrip").Value)
            .txtPetrFieldArea.Text = util.TrataDBNull(dgvPetrField.CurrentRow.Cells("colPetrFieldArea").Value)

            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.PETRFIELD' table. You can move, or remove it, as needed.
        Me.PETRFIELDTableAdapter.Fill(Me.SESTicketSQLDataSet.PETRFIELD)
    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmPetrFieldEdit
        With frm
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.PETRFIELD' table. You can move, or remove it, as needed.
        Me.PETRFIELDTableAdapter.Fill(Me.SESTicketSQLDataSet.PETRFIELD)
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
              "and obj.OBJECTFORM = 'frmPetrFieldList' " &
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