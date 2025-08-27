Imports System.Configuration

Public Class clsSyncAttach
    Implements IDisposable

    Dim util As New clsUtils

    Public Sub Log(ByVal Log As String)

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS

        bdconn.OpenConnection()

        sql = "INSERT INTO TICKETFILELOG (LOGDATETIME,LOGTEXT) VALUES (NOW()," & util.SQLConvStrNull(Log, "s") & ")"
        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Public Sub SyncFile()

        Dim sql As String
        Dim ds As New DataSet
        Dim bdconn As New clsBancoDadosACCESS

        Try

            bdconn.OpenConnection()

            Sql = "SELECT * FROM TICKETFILE WHERE ACTION IS NOT NULL AND ACTION <> 'DELETE' "
            bdconn.ExecuteSQL(Sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sTicketFileId As String = ""
                Dim sTicketId As String = ""
                Dim sFileName As String = ""
                Dim sAction As String = ""
                Dim nSize As Double = 0

                Dim sLog As String = ""

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sTicketFileId = ds.Tables(0).Rows(i)("TICKETFILEID").ToString
                    sTicketId = ds.Tables(0).Rows(i)("TICKETID").ToString
                    sFileName = ds.Tables(0).Rows(i)("TICKETFILENAME").ToString
                    sAction = ds.Tables(0).Rows(i)("ACTION").ToString
                    nSize = ds.Tables(0).Rows(i)("FILESIZE")

                    Log("SyncFile: Ticket: " & sTicketId & " Sync File: " & sFileName & " Action: " & sAction & " Copy: Started.")
                    sLog = CopyFile(sTicketId, sFileName, sAction, nSize)

                    If sLog = "" Then

                        Log("SyncFile: Ticket: " & sTicketId & " Sync File: " & sFileName & " Action: " & sAction & " Copy: Finished.")

                        If sAction = "UPLOAD" Then
                            sql = "INSERT INTO zSQL_TICKETFILE ( TICKETFILEID, TICKETID, TICKETFILENAME, FILESIZE, " &
                                    "CREATEDBY, CREATEDDATETIME, COMMENT ) " &
                                    "SELECT TICKETFILE.TICKETFILEID, TICKETFILE.TICKETID, TICKETFILE.TICKETFILENAME,  " &
                                    "TICKETFILE.FILESIZE, TICKETFILE.CREATEDBY, TICKETFILE.CREATEDDATETIME, TICKETFILE.COMMENT " &
                                    "FROM TICKETFILE WHERE TICKETFILE.TICKETFILEID = '" & sTicketFileId & "' " &
                                    "AND TICKETFILE.TICKETFILEID NOT IN ( " &
                                    "SELECT TICKETFILEID FROM zSQL_TICKETFILE) "
                            bdconn.ExecuteNonSQL(Sql)
                        End If

                        Sql = "UPDATE TICKETFILE SET " &
                              "[LOCATION] = 'LOCAL\SERVER' " &
                              ",[ACTION] = NULL " &
                              "WHERE TICKETFILEID = '" & sTicketFileId & "' "
                        bdconn.ExecuteNonSQL(Sql)
                    Else
                        Log("SyncFile: Ticket: " & sTicketId & " Sync File: " & sFileName &
                            " Action: " & sAction & Environment.NewLine & sLog)
                    End If

                Next
            End If

            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
        Catch ex As Exception
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            Log("SyncFile: Erro Exception: " & ex.Message)
        End Try

    End Sub

    Public Function CopyFile(ByVal sTicketId As String, ByVal sFileName As String, ByVal sAction As String, ByVal nSize As Double) As String

        Try

            Dim sLocalFilePath As String = ConfigurationManager.AppSettings("FilePath").ToString & "\" & sTicketId
            Dim sRemoteFilePath As String = ConfigurationManager.AppSettings("RemoteAttachFolder").ToString & "\" & sTicketId

            If sAction = "UPLOAD" Then
                If (System.IO.Directory.Exists(sRemoteFilePath) = False) Then
                    System.IO.Directory.CreateDirectory(sRemoteFilePath)
                End If
            ElseIf sAction = "DOWNLOAD" Then
                If (System.IO.Directory.Exists(sLocalFilePath) = False) Then
                    System.IO.Directory.CreateDirectory(sLocalFilePath)
                End If
            End If

            Dim sOrig As String = ""
            Dim sDest As String = ""

            If sAction = "UPLOAD" Then
                sOrig = sLocalFilePath & "\" & sFileName
                sDest = sRemoteFilePath & "\" & sFileName
            ElseIf sAction = "DOWNLOAD" Then
                sOrig = sRemoteFilePath & "\" & sFileName
                sDest = sLocalFilePath & "\" & sFileName
            End If

            System.IO.File.Copy(sOrig, sDest, True)

            If My.Computer.FileSystem.GetFileInfo(sDest).Length <> nSize Then
                Return "The File Size is not the Same"
            Else
                Return ""
            End If

        Catch ex As Exception
            Return "Erro during the Copy: " & ex.Message
        End Try

    End Function

    Public Sub SyncTable()

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS

        Try

            bdconn.OpenConnection()

            'Deleting registry with ACTION = 'DELETE'
            Sql = "DELETE FROM zSQL_TICKETFILE " &
                  "WHERE " &
                  "EXISTS (SELECT 1 " &
                  "FROM TICKETFILE " &
                  "WHERE TICKETFILE.[ACTION] = 'DELETE' " &
                  "AND TICKETFILE.TICKETFILEID = zSQL_TICKETFILE.TICKETFILEID)"
            bdconn.ExecuteNonSQL(Sql)

            Sql = "DELETE FROM TICKETFILE WHERE TICKETFILE.[ACTION] = 'DELETE' "
            bdconn.ExecuteNonSQL(Sql)

            'Deleting Local Attach that not exists on BD
            Sql = "DELETE FROM TICKETFILE " &
                  "WHERE NOT EXISTS (SELECT 1 " &
                  "FROM zSQL_TICKETFILE " &
                  "WHERE TICKETFILE.TICKETID = zSQL_TICKETFILE.TICKETID " &
                  "AND TICKETFILE.TICKETFILEID = zSQL_TICKETFILE.TICKETFILEID) " &
                  "AND TICKETFILE.LOCATION IN ('LOCAL\SERVER','SERVER')  "
            bdconn.ExecuteNonSQL(Sql)

            'Deleting Local Attach without Ticket Local
            'Obs: JUST ONLY WITH STATUS = 'LOCAL\SERVER', otherwise, sync first!
            Sql = "DELETE FROM TICKETFILE " &
                  "WHERE NOT EXISTS (SELECT 1 " &
                  "FROM TICKET " &
                  "WHERE TICKETFILE.TICKETID = TICKET.TICKETID) " &
                  "AND TICKETFILE.LOCATION IN ('LOCAL\SERVER','SERVER')  "
            bdconn.ExecuteNonSQL(Sql)

            'Bring new Registry from DB to Local
            Sql = "INSERT INTO TICKETFILE ( " &
                "[TICKETFILEID],[TICKETID],[TICKETFILENAME],[FILESIZE] " &
                ",[CREATEDBY],[CREATEDDATETIME],[COMMENT], [LOCATION]) " &
                "SELECT [TICKETFILEID] " &
                ",[TICKETID],[TICKETFILENAME],[FILESIZE] " &
                ",[CREATEDBY],[CREATEDDATETIME],[COMMENT], 'SERVER' AS LOC " &
                "FROM zSQL_TICKETFILE " &
                "WHERE " &
                "NOT EXISTS (SELECT 1 " &
                "FROM TICKETFILE " &
                "WHERE zSQL_TICKETFILE.TICKETID = TICKETFILE.TICKETID " &
                "AND zSQL_TICKETFILE.TICKETFILEID = TICKETFILE.TICKETFILEID) " &
                "AND EXISTS (SELECT 1 " &
                "FROM TICKET  " &
                "WHERE TICKET.TICKETID = zSQL_TICKETFILE.TICKETID) "
            bdconn.ExecuteNonSQL(Sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            Log("SyncTable: Erro Exception: " & ex.Message)
        End Try

    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
