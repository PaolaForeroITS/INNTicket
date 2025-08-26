Public Class frmTicketFile

    Public sTicketId As String
    Public sUsername As String
    Dim sTicketFileId As String
    Dim sAvailable As String
    Dim sFileName As String
    Dim util As New clsUtils

    Private Sub frmTicketFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            RefreshGrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtTicketId.Text = sTicketId

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click

        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            Dim frm As New frmTicketFileNew
            With frm
                .sTicketId = Me.sTicketId
                .sUsername = Me.sUsername
                .sFullFileOrig = OpenFileDialog1.FileName
                .sFileOrigName = OpenFileDialog1.SafeFileName
                .ShowDialog()
                .Dispose()
            End With
            RefreshGrid()
            frm = Nothing

        End If
    End Sub

    Private Sub mnuRefresh_Click(sender As Object, e As EventArgs) Handles mnuRefresh.Click
        Try
            RefreshGrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuLog_Click(sender As Object, e As EventArgs) Handles mnuLog.Click
        Dim frm As New frmTicketFileLog
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        RefreshGrid()
    End Sub

    Private Sub dgvTicketFile_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTicketFile.SelectionChanged
        ChangeLine()
    End Sub

    Private Sub ChangeLine()
        If dgvTicketFile.RowCount > 0 Then
            If IsNothing(util.TrataDBNull(dgvTicketFile.CurrentRow.Cells("colTicketFileId").Value)) = False Then
                sTicketFileId = dgvTicketFile.CurrentRow.Cells("colTicketFileId").Value.ToString
            Else
                sTicketFileId = ""
            End If
            If IsNothing(util.TrataDBNull(dgvTicketFile.CurrentRow.Cells("colTicketFileName").Value)) = False Then
                sFileName = dgvTicketFile.CurrentRow.Cells("colTicketFileName").Value.ToString
            Else
                sFileName = ""
            End If

            If IsDBNull(dgvTicketFile.CurrentRow.Cells("colAvailable").Value) = False Then
                If IsNothing(dgvTicketFile.CurrentRow.Cells("colAvailable").Value) = False Then
                    sAvailable = dgvTicketFile.CurrentRow.Cells("colAvailable").Value.ToString
                Else
                    sAvailable = "NO"
                End If
            Else
                sAvailable = "NO"
            End If
        Else
            sTicketFileId = ""
            sAvailable = "NO"
        End If
    End Sub

    Private Sub mnuOpenFile_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click
        If sTicketFileId <> "" Then
            If sAvailable = "YES" Then
                Dim cls As New clsSyncTicketAttach
                cls.OpenFile(sTicketId, sFileName)
                cls.Dispose()
                cls = Nothing
            Else
                Dim sMsg As String = "The file is not available." & Environment.NewLine & "Do you want get the file from server?" & Environment.NewLine
                If MsgBox(sMsg, vbYesNo) = vbYes Then
                    Dim cls As New clsSyncTicketAttach
                    cls.ChangeAction(sTicketFileId, "DOWNLOAD")
                    cls.Dispose()
                    cls = Nothing
                    MsgBox("The file is in queue. Check after some minutes.", vbInformation)
                    RefreshGrid()
                End If
            End If
        End If
    End Sub

    Private Sub RefreshGrid()
        Me.TICKETFILETableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETFILE)
        TICKETFILEBindingSource.Filter = "TICKETID = '" & sTicketId & "' AND ([ACTION] IN ('UPLOAD','DOWNLOAD') OR [ACTION] IS NULL) "
        dgvTicketFile.Refresh()

    End Sub

    Private Sub mnuDeleteFile_Click(sender As Object, e As EventArgs) Handles mnuDeleteFile.Click
        If sTicketFileId <> "" Then
            Dim sMsg As String = "Do you want Delete this file? This action is irreversible."
            If MsgBox(sMsg, vbYesNo) = vbYes Then
                Dim cls As New clsSyncTicketAttach
                cls.ChangeAction(sTicketFileId, "DELETE")
                cls.Dispose()
                cls = Nothing
                RefreshGrid()
            End If
        End If
    End Sub
End Class