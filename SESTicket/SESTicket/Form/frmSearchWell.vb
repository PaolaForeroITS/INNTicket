Public Class frmSearchWell

    Dim sFilter As String

    Public _WellID As String = ""
    Public _WellName As String = ""
    Public _Rig As String = ""
    Public _SiteId As String = ""
    Public _SiteAlias As String = ""

    Dim nLoadForm As Boolean = True

    Private Sub frmSearchWell_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Cursor = Cursors.WaitCursor

        Me.Size = New System.Drawing.Size(733, 583)

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet1.WELL_V' table. You can move, or remove it, as needed.
        Me.WELL_VTableAdapter.Fill(Me.SESTicketAccessDataSet1.WELL_V)
        FormatGrid()
        nLoadForm = False

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvWell_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWell.CellDoubleClick
        If dgvWell.RowCount > 0 Then

            Dim util As New clsUtils

            _WellID = dgvWell.CurrentRow.Cells("colWellId").Value
            _WellName = util.TrataDBNull(dgvWell.CurrentRow.Cells("colWellName").Value)
            _Rig = util.TrataDBNull(dgvWell.CurrentRow.Cells("colRigId").Value)
            _SiteId = util.TrataDBNull(dgvWell.CurrentRow.Cells("colSiteId").Value)
            _SiteAlias = util.TrataDBNull(dgvWell.CurrentRow.Cells("colSiteAlias").Value)

            Me.Dispose()
        End If
    End Sub

    Private Sub FormatGrid()
        For l As Integer = 0 To Me.dgvWell.RowCount - 1
            With dgvWell.Rows(l)
                .DefaultCellStyle.ForeColor = Color.Blue
            End With
        Next
    End Sub

    Private Sub Filter()

        Dim sField As String = ""

        If cbxSearch.Text = "WellID" Then
            sField = "WELLID"
        ElseIf cbxSearch.Text = "Name" Then
            sField = "NAME"
        ElseIf cbxSearch.Text = "Petroleum Field" Then
            sField = "PETRFIELDID"
        ElseIf cbxSearch.Text = "Rig" Then
            sField = "RIGID"
        ElseIf cbxSearch.Text = "Site" Then
            sField = "SITENAME"
        End If
        sFilter = sField & " LIKE '%" & txtSearch.Text & "%'"

        WELLVBindingSource1.Filter = sFilter
        dgvWell.Refresh()
        FormatGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Filter()
    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged
        If nLoadForm = False Then
            Filter()
        End If
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Text = ""
        Filter()
    End Sub

End Class