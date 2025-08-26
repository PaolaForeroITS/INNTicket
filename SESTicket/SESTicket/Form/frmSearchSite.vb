Public Class frmSearchSite

    Public sSiteId As String = ""
    Public sSiteAlias As String = ""

    Private Sub frmSearchSite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.SITES' table. You can move, or remove it, as needed.
        Me.SITESTableAdapter.Fill(Me.SESTicketAccessDataSet.SITES)
        FormatGrid()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub FormatGrid()
        For l As Integer = 0 To Me.dgvSite.RowCount - 1
            With dgvSite.Rows(l)
                .DefaultCellStyle.ForeColor = Color.Blue
            End With
        Next
    End Sub


    Private Sub dgvSite_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSite.CellDoubleClick
        If dgvSite.RowCount > 0 Then

            Dim util As New clsUtils

            sSiteId = util.TrataDBNull(dgvSite.CurrentRow.Cells("colSiteId").Value)
            sSiteAlias = util.TrataDBNull(dgvSite.CurrentRow.Cells("colSiteAlias").Value)

            Me.Dispose()
        End If
    End Sub
End Class