Public Class frmSiteList

    Dim util As New clsUtils
    Public sUsername As String
    Dim bPermitInsUpd As Boolean = True

    Private Sub frmSiteList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SITES' table. You can move, or remove it, as needed.
        Me.SITESTableAdapter.Fill(Me.SESTicketSQLDataSet.SITES)

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvSite_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSite.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmSiteEdit
        With frm
            .CarregaCbx()
            .txtSiteID.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colSiteID").Value)
            .txtName.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colName").Value)
            .txtDescription.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colDescription").Value)
            .txtAddress.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colAddress").Value)
            .txtAttention.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colAttention").Value)
            .cbxCountry.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colCountry").Value)
            .cbxState.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colState").Value)
            .cbxCity.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colCity").Value)
            .txtPhone.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colPhone").Value)
            .txtFax.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colFax").Value)
            .txtEmail.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colEmail").Value)
            .txtGoodAccount.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colGoodsAccount").Value)
            .txtGoodsSubAccount.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colGoodsSubAccount").Value)
            .txtInvAccount.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colInventoryAccount").Value)
            .txtInvSubAccount.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colInventorySubAccount").Value)
            .txtSalesAccount.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colSalesAccount").Value)
            .txtSalesSubAccount.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colSalesSubAccount").Value)
            .txtAlias.Text = util.TrataDBNull(dgvSite.CurrentRow.Cells("colAlias").Value)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SITES' table. You can move, or remove it, as needed.
        Me.SITESTableAdapter.Fill(Me.SESTicketSQLDataSet.SITES)
    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmSiteEdit
        With frm
            .CarregaCbx()
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SITES' table. You can move, or remove it, as needed.
        Me.SITESTableAdapter.Fill(Me.SESTicketSQLDataSet.SITES)
    End Sub

    Private Sub dgvSite_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSite.CellContentClick

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
              "and obj.OBJECTFORM = 'frmSiteList' " &
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

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

#End Region

End Class