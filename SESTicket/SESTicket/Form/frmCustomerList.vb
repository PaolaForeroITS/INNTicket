Public Class frmCustomerList

    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
        ChangeColorGrid()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmCustomerEdit
        With frm
            .CarregaCbx()
            .txtCustomerID.Text = dgvCustomer.CurrentRow.Cells("colCustomerID").Value
            .txtName.Text = dgvCustomer.CurrentRow.Cells("colName").Value
            .txtAddress1.Text = dgvCustomer.CurrentRow.Cells("colAddress1").Value
            .txtAddress2.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colAddress2").Value)
            .cbxCountry.Text = dgvCustomer.CurrentRow.Cells("colCountry").Value
            .cbxState.Text = dgvCustomer.CurrentRow.Cells("colState").Value
            .cbxCity.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colCity").Value)
            .txtPhone.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colPhone").Value)
            .txtFax.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colFax").Value)
            .txtEmail.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colEmail").Value)
            .txtObs.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colObs").Value)
            .txtSalesAccount.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colSalesAccount").Value)
            .txtSalesSubAccount.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colSalesSubAccount").Value)
            .txtARAccount.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colARAccount").Value)
            .txtARSubAccount.Text = util.TrataDBNull(dgvCustomer.CurrentRow.Cells("colARSubAccount").Value)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
        ChangeColorGrid()
    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmCustomerEdit
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
        ChangeColorGrid()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvCustomer.Rows.Count - 1 
            dgvCustomer.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
        Next
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
              "and obj.OBJECTFORM = 'frmCustomerList' " &
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