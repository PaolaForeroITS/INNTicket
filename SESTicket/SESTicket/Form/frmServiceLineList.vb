Public Class frmServiceLineList

    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmServiceLineList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICELINE' table. You can move, or remove it, as needed.
        Me.SERVICELINETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICELINE)
        Filter()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvServiceLine.Rows.Count - 1
            If dgvServiceLine.Rows(i).Cells("colActive").Value = "YES" Then
                dgvServiceLine.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            Else
                With dgvServiceLine.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Red
                End With
            End If
        Next
    End Sub

    Private Sub dgvServiceLine_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ChangeColorGrid()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
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

        SERVICELINEBindingSource.Filter = sfilter
        dgvServiceLine.Refresh()

        ChangeColorGrid()

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmServiceLineEdit
        With frm
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICETYPE' table. You can move, or remove it, as needed.
        Me.SERVICELINETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICELINE)
        Filter()
    End Sub


    Private Sub dgvServiceLine_CellDoubleClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceLine.CellDoubleClick
        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmServiceLineEdit
        With frm
            .sServiceLineNameOld = dgvServiceLine.CurrentRow.Cells("colName").Value
            .txtName.Text = dgvServiceLine.CurrentRow.Cells("colName").Value
            .cbxActive.Text = dgvServiceLine.CurrentRow.Cells("colActive").Value.ToString
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICETYPE' table. You can move, or remove it, as needed.
        Me.SERVICELINETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICELINE)
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
              "and obj.OBJECTFORM = 'frmServiceLineList' " &
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