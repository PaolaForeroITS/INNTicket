Public Class frmSearchRig

    Dim sFilter As String

    Public _RigId As String = ""

    Private Sub frmSearchRig_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Cursor = Cursors.WaitCursor

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.RIG' table. You can move, or remove it, as needed.
        Me.RIGTableAdapter.Fill(Me.SESTicketAccessDataSet.RIG)

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvRig_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRig.CellContentClick

    End Sub

    Private Sub dgvRig_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRig.CellDoubleClick
        If dgvRig.RowCount > 0 Then
            Dim util As New clsUtils
            _RigId = util.TrataDBNull(dgvRig.CurrentRow.Cells("colRigId").Value)
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvRig_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRig.CellFormatting
        For l As Integer = 0 To Me.dgvRig.RowCount - 1
            With dgvRig.Rows(l)
                .DefaultCellStyle.ForeColor = Color.Blue
            End With
        Next
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Filter()
    End Sub

    Private Sub Filter()

        Dim sField As String = ""
        sFilter = sField & "RIGID LIKE '%" & txtSearch.Text & "%'"

        RIGBindingSource.Filter = sFilter
        dgvRig.Refresh()

    End Sub

End Class