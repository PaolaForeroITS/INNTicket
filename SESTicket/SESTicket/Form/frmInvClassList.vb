Public Class frmInvClassList

    Public sUsername As String
    Dim bPermitInsUpd As Boolean = True

    Dim util As New clsUtils

    Private Sub frmInvClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.INVENTORYCLASS' table. You can move, or remove it, as needed.
        Me.INVENTORYCLASSTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYCLASS)

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvInvClass_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvClass.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmInvClassEdit

        With frm
            .txtInvClassID.Text = dgvInvClass.CurrentRow.Cells("colInvClassID").Value
            .cbxType.Text = dgvInvClass.CurrentRow.Cells("coltype").Value
            .txtDescription.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colDescription").Value)
            .txtGoodAccount.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colCostOfGoodsAccount").Value)
            .txtGoodsSubAccount.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colCostOfGoodsSubAccount").Value)
            .txtInvAccount.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colInventoryAccount").Value)
            .txtInvSubAccount.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colInventorySubAccount").Value)
            .txtSalesAccount.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colSalesAccount").Value)
            .txtSalesSubAccount.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colSalesSubAccount").Value)
            .txtSalesAccountAIU.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colSalesAccountAIU").Value)
            .txtSalesAccountUBR.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colSalesAccountUBR").Value)
            .txtSalesAccountUBRAIU.Text = util.TrataDBNull(dgvInvClass.CurrentRow.Cells("colSalesAccountUBRAIU").Value)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        Me.INVENTORYCLASSTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYCLASS)

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmInvClassEdit
        With frm
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        Me.INVENTORYCLASSTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYCLASS)
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
              "and obj.OBJECTFORM = 'frmInvClassList' " &
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