Public Class frmSyncTicket

    Public sUsername As String
    Dim slog As String

    Private Sub frmSyncTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClose.Visible = False
        Me.Show()
        Me.Start()
    End Sub

    Public Sub Log(ByVal Log As String, Optional ByVal bNewLine As Boolean = False)
        slog = slog & Log
        If bNewLine = True Then
            slog = slog & Environment.NewLine
        End If
        txtLog.Text = slog
        Me.Refresh()
    End Sub

    Private Sub Start()

        Dim bErroProc As Boolean = False

        Try

            Me.Cursor = Cursors.WaitCursor
            Me.Refresh()

            Log("Starting the process..." & DateTime.Now.ToString, True)
            Log("--------------------------------------", True)

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection()

            Dim sql As String
            Dim ds As New DataSet

            Log("Checking Tickets...", True)

            sql = "SELECT * FROM TICKETSYNC_V "

            bdconnACCESS.ExecuteSQL(sql, ds)

            Dim sync As New clsSyncTicket
            sync.sUsername = Me.sUsername

            If ds.Tables(0).Rows.Count > 0 Then

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    If sync.bErro = False Then

                        Log("Synchronizing Ticket """ & ds.Tables(0).Rows(i)("TICKETID").ToString() & """...")
                        sync.SendTicket(ds.Tables(0).Rows(i)("TICKETID").ToString(), ds.Tables(0).Rows(i)("DBDEST").ToString())

                        If sync.bErro = True Then
                            Log(sync.sLog, True)
                            bErroProc = True
                        Else
                            Log("Ok", True)
                        End If

                    End If

                Next

            Else
                Log("No Tickets to Synchronize", True)
            End If

            ds.Dispose()
            ds = Nothing
            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            Log("Update TICKETSYNC Datetime..")
            sync.UpdateUserTicketSync()
            If sync.bErro = True Then
                Log(sync.sLog, True)
                bErroProc = True
            Else
                Log("Ok", True)
            End If

            sync.Dispose()

            Log("Updating CONSEC table...")

            Dim syncBase As New clsSyncBaseData
            syncBase.Consec(Me.sUsername)

            If syncBase.bErro = True Then
                Log(syncBase.sLog, True)
                bErroProc = True
            Else
                Log("Ok", True)
            End If
            syncBase.Dispose()
            syncBase = Nothing

            Log("--------------------------------------", True)
            Log("End process..." & DateTime.Now.ToString)

            Me.Cursor = Cursors.Arrow
            Me.Refresh()

            If bErroProc = False Then
                MsgBox("The Tickets are Synchronized", vbInformation)
                Me.Dispose()
            Else
                btnClose.Visible = True
                MsgBox("Some erros ocurred during the process. Contact the Administrator", vbExclamation)
            End If

        Catch ex As Exception
            btnClose.Visible = True
            Me.Cursor = Cursors.Arrow
            Log(ex.Message)
            MsgBox("Some erros ocurred during the process. Contact the Administrator", vbExclamation)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

End Class