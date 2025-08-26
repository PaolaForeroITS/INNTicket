Public Class frmTicketOperReport

    Dim util As New clsUtils

    Public sTicketID As String
    Public sUsername As String
    Public bTicketReadOnly As Boolean
    Dim sTicketOpeRepId As String
    Dim sTicketOpeRepActId As String

    Private Sub frmTicketOperReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReloadOperDateGrid()

        If bTicketReadOnly = True Then
            btnNewActivity.Enabled = False
            btnDeleteActivity.Enabled = False
            btnNewOperDate.Enabled = False
            dgvActivityLine.ReadOnly = True
        Else
            btnNewActivity.Enabled = True
            btnDeleteActivity.Enabled = True
            dgvActivityLine.ReadOnly = False
        End If

    End Sub

    Private Sub ReloadOperDateGrid()
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREP' table. You can move, or remove it, as needed.
        Me.TICKETOPEREPTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREP)

        TICKETOPEREPBindingSource.Filter = "TICKETID='" & sTicketID & "' "
        dgvOperDate.Refresh()

        If dgvOperDate.RowCount > 0 Then
            ReloadActivityLineGrid()
            dgvOperDateChangeLine()

            If bTicketReadOnly = True Then
                btnNewActivity.Enabled = False
                btnDeleteActivity.Enabled = False
                dgvActivityLine.ReadOnly = True
            Else
                btnNewActivity.Enabled = True
                btnDeleteActivity.Enabled = True
                dgvActivityLine.ReadOnly = False
            End If
        Else
            btnNewActivity.Enabled = False
            btnDeleteActivity.Enabled = False

        End If

    End Sub

    Private Sub ReloadActivityLineGrid()
        If dgvOperDate.RowCount > 0 Then
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREPACT' table. You can move, or remove it, as needed.
            Me.TICKETOPEREPACTTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREPACT)
            TICKETOPEREPACTBindingSource.Filter = "TICKETOPEREPID='" & dgvOperDate.CurrentRow.Cells("colTicketOpeRepId").Value & "' "
            dgvActivityLine.Refresh()

        Else
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEREPACT' table. You can move, or remove it, as needed.
            Me.TICKETOPEREPACTTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEREPACT)
            TICKETOPEREPACTBindingSource.Filter = "TICKETOPEREPID='999999' "
            dgvActivityLine.Refresh()

        End If
    End Sub

    Private Sub btnNewOperDate_Click(sender As Object, e As EventArgs) Handles btnNewOperDate.Click
        Dim frm As New frmTicketOperRepDateEdit
        frm.sTicketId = Me.sTicketID
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        ReloadOperDateGrid()

    End Sub

    Private Sub dgvOperDate_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperDate.CellDoubleClick

        If bTicketReadOnly = False And dgvOperDate.RowCount > 0 Then

            Dim frm As New frmTicketOperRepDateEdit
            With frm
                .sTicketId = sTicketID
                .sTicketOpeRepId = dgvOperDate.CurrentRow.Cells("colTicketOpeRepId").Value
                .dtpActivityDate.Value = dgvOperDate.CurrentRow.Cells("colActivityDate").Value
                .txtComments.Text = util.TrataDBNull(dgvOperDate.CurrentRow.Cells("colComments").Value)
                .txtServiceDescription.Text = util.TrataDBNull(dgvOperDate.CurrentRow.Cells("colServiceDescrip").Value)
                .ShowDialog()
                .Dispose()
            End With
            frm = Nothing

            ReloadOperDateGrid()

        End If

    End Sub

    Private Sub dgvOperDate_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOperDate.SelectionChanged
        dgvOperDateChangeLine()
    End Sub

    Private Sub dgvActivityLine_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivityLine.CellClick
        If dgvActivityLine.RowCount > 0 Then
            dgvActivityChangeLine()
        End If
    End Sub

    Private Sub dgvOperDateChangeLine()
        If dgvOperDate.RowCount > 0 Then
            If IsNothing(util.TrataDBNull(dgvOperDate.CurrentRow.Cells("colComments").Value)) = False Then
                txtComments.Text = dgvOperDate.CurrentRow.Cells("colComments").Value.ToString
            Else
                txtComments.Text = ""
            End If

            If IsNothing(util.TrataDBNull(dgvOperDate.CurrentRow.Cells("colTicketOpeRepId").Value)) = False Then
                sTicketOpeRepId = dgvOperDate.CurrentRow.Cells("colTicketOpeRepId").Value.ToString
            Else
                sTicketOpeRepId = ""
            End If
        Else
            sTicketOpeRepId = ""
            txtComments.Text = ""
        End If

        ReloadActivityLineGrid()
    End Sub

    Private Sub dgvActivityChangeLine()
        If dgvActivityLine.RowCount > 0 Then
            If IsNothing(util.TrataDBNull(dgvActivityLine.CurrentRow.Cells("colTicketOpeRepActId").Value)) = False Then
                sTicketOpeRepActId = dgvActivityLine.CurrentRow.Cells("colTicketOpeRepActId").Value.ToString
            Else
                sTicketOpeRepActId = ""
            End If
        Else
            sTicketOpeRepActId = ""
        End If

    End Sub

    Private Sub btnNewActivity_Click(sender As Object, e As EventArgs) Handles btnNewActivity.Click

        If sTicketOpeRepId = "" Then
            MsgBox("Select the Job Description", vbInformation)
            Exit Sub
        End If

        Dim bdconnAccess As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconnAccess.OpenConnection()

        Dim seq As New clsSequenceAccess(sTicketID)

        sql = "INSERT INTO [TICKETOPEREPACT] ([TICKETOPEREPACTID],[TICKETOPEREPID],[LINEORDER],[BOLD],[ALIGHMENT]) VALUES ('"
        sql = sql & seq.TicketOpeRepActNextId & "','"
        sql = sql & sTicketOpeRepId & "',"
        sql = sql & seq.TicketOpeRepActLineOrdNextId(sTicketOpeRepId) & ","
        sql = sql & "false,'Left')"
        bdconnAccess.ExecuteNonSQL(sql)

        bdconnAccess.CloseConnection()
        bdconnAccess.Dispose()
        bdconnAccess = Nothing

        seq.Dispose()
        seq = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketID, "ACCESS")
        sync.Dispose()
        sync = Nothing

        ReloadActivityLineGrid()

    End Sub

    Private Sub btnDeleteActivity_Click(sender As Object, e As EventArgs) Handles btnDeleteActivity.Click

        If dgvActivityLine.RowCount > 0 Then

            If sTicketOpeRepActId = "" Then
                MsgBox("Select the item", vbInformation)
                Exit Sub
            End If

            Dim bdconnAccess As New clsBancoDadosACCESS
            Dim sql As String

            bdconnAccess.OpenConnection()

            sql = "DELETE FROM TICKETOPEREPACT WHERE TICKETOPEREPACTID = '" & sTicketOpeRepActId & "' "
            bdconnAccess.ExecuteNonSQL(sql)

            bdconnAccess.CloseConnection()
            bdconnAccess.Dispose()
            bdconnAccess = Nothing

            Dim sync As New clsSyncTicket
            sync.UpdateSyncDateTime(sTicketID, "ACCESS")
            sync.Dispose()
            sync = Nothing

            sTicketOpeRepActId = ""

            ReloadActivityLineGrid()

        End If

    End Sub

    Private Sub dgvActivityLine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivityLine.CellContentClick
        dgvActivityChangeLine()
    End Sub

    Private Sub dgvActivityLine_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivityLine.CellEndEdit
        SaveActivityGrid()
    End Sub

    Private Sub dgvActivityLine_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvActivityLine.CellValidating
        If e.ColumnIndex = 2 Then
            If (Not IsNumeric(e.FormattedValue)) Then
                MessageBox.Show("Enter valid numeric data")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SaveActivityGrid()

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketID, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Validate()
        Me.TICKETOPEREPACTBindingSource.EndEdit()
        Me.TICKETOPEREPACTTableAdapter.Update(Me.SESTicketAccessDataSet)

    End Sub

    Private Sub dgvOperDate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperDate.CellContentClick

    End Sub
End Class