Public Class frmChangeSupSupervisor

    Public sUsername As String
    Public bReloadGrid As Boolean = False
    Public sSource As String
    Dim grd As DataGridView

    Public bIsSQLConnect As Boolean

    Dim sSuperiorSupervisorId As String = ""

    Public Sub LoadGrid(ByRef grd1 As DataGridView, Optional Source As String = "")
        grd = grd1
        sSource = Source
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmChangeSupSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If grd.SelectedRows.Count = 0 Then
            MsgBox("Select Item", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

        Dim nCount As Integer = 0

        For Each row As DataGridViewRow In grd.SelectedRows
            nCount = 1
            lstTickets.Items.Add(row.Cells("colTicketId").Value)
        Next

        If nCount = 0 Then
            MsgBox("The Selected Lines are not Ticked Status Closed", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

    End Sub


    Private Sub btnSearchSupervisor_Click(sender As Object, e As EventArgs) Handles btnSearchSupervisor.Click
        Dim frm As New frmSearchWorker
        With frm
            .ShowDialog()
        End With

        If frm.WorkerId <> "" Then
            sSuperiorSupervisorId = frm.WorkerId
            txtSuperiorSupervisor.Text = frm.FullName
        End If

        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub mnuChangeSupervisor_Click(sender As Object, e As EventArgs) Handles mnuChangeSupervisor.Click

        If sSuperiorSupervisorId = "" Then
            MsgBox("Select the new Supervisor", vbInformation)
            Exit Sub
        End If

        If MsgBox("Do you want change the Superior´s Supervisor of these Tickets?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Dim bError As Boolean = False

        lstTickets.Items.Clear()

        Dim sTicketId As String

        Dim bSync As Boolean = False

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In grd.SelectedRows

            sTicketId = row.Cells("colTicketID").Value.ToString

            Try
                Dim sResult As String
                sResult = Me.ChangeSupervisor(sTicketId)

                If sResult.Contains("Ok:") And bSync = False Then
                    bSync = True
                End If

                If sResult.Contains("Canceled") And bError = False Then
                    bError = True
                End If

                lstTickets.Items.Add(sResult)

            Catch ex As Exception
                lstTickets.Items.Add(sTicketId & " - Error - " & ex.Message)
                bError = True
            End Try

        Next

        If bSync = True And sSource = "SQL" Then
            Dim frm As New frmSyncTicket
            frm.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Cursor = Cursors.Arrow

        bReloadGrid = True

        If bError = True Then
            Me.Cursor = Cursors.Arrow
            MsgBox("Some error happened during the process", vbExclamation)
        Else
            Me.Dispose()
        End If


    End Sub

    Public Function ChangeSupervisor(ByVal sTicketId As String) As String

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim bdconnACCESS As New clsBancoDadosACCESS

        If sSource = "SQL" Then
            bdconnSQL.OpenConnection()
        Else
            bdconnACCESS.OpenConnection()
        End If

        Dim util As New clsUtils

        Dim sql As String
        Dim ds As New DataSet

        Dim sReturn As String = ""

        sql = "UPDATE TICKET SET SYNCDATETIME = " & util.GetDateTimeUTC() & " " &
              ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
              ",[UPDATEDUSER] = '" & sUsername.ToLower & "' " &
              ",[SUPERIORSUPERVISOR] = '" & sSuperiorSupervisorId & "' "

        If sSource <> "SQL" Then
            sql = sql & ",SyncDB=FALSE "
        End If

        sql = sql & "WHERE TICKETID = '" & sTicketId & "'"

        If sSource = "SQL" Then
            bdconnSQL.ExecuteNonSQL(sql)
        Else
            bdconnACCESS.ExecuteNonSQL(sql)
        End If

        sReturn = sTicketId & " - Ok: Supervisor updated"

        If sSource = "SQL" Then
            bdconnSQL.CloseConnection()
            bdconnSQL.Dispose()
        Else
            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
        End If

        bdconnSQL = Nothing
        bdconnACCESS = Nothing

        Return sReturn

    End Function


End Class