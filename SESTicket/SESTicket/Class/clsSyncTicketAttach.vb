Imports System.Configuration

Public Class clsSyncTicketAttach

    Implements IDisposable

    Dim util As New clsUtils

    Public Sub Log(ByVal Log As String)

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS

        Try

            bdconn.OpenConnection()

            sql = "INSERT INTO TICKETFILELOG (LOGDATETIME,LOGTEXT) VALUES (" & util.GetDateTime() & "," & util.SQLConvStrNull(Log, "s") & ")"
            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
        End Try

    End Sub

    Public Sub StartSync()
        Try
            'Kill the process
            Dim SESTicketSyncAttach() As Process = Process.GetProcessesByName("SESTicketSyncAttach")
            For Each Process As Process In SESTicketSyncAttach
                Process.Kill()
            Next
            Process.Start("C:\SESTicket\app\attach\SESTicketSyncAttach.exe")

            Log("TicketAttachSync: Starting")

            DeleteOldLogFile()

        Catch ex As Exception
            Log("StartSync: Erro Exception: " & ex.Message)
        End Try
    End Sub

    Public Sub StopSync()
        Try
            'Kill the process
            Dim SESTicketSyncAttach() As Process = Process.GetProcessesByName("SESTicketSyncAttach")
            For Each Process As Process In SESTicketSyncAttach
                Process.Kill()
            Next
            Log("TicketAttachSync: Finished")

        Catch ex As Exception
            Log("StopSync: Erro Exception: " & ex.Message)
        End Try
    End Sub

    Public Sub OpenFile(ByVal sTicketId As String, ByVal sFileName As String)
        Dim sFileOrig As String = ConfigurationManager.AppSettings("FilePath").ToString & "\" & sTicketId & "\" & sFileName
        Dim sFileDest As String = ConfigurationManager.AppSettings("FilePath").ToString & "\tmp\" & sTicketId

        If (System.IO.Directory.Exists(sFileDest) = False) Then
            System.IO.Directory.CreateDirectory(sFileDest)
        End If

        System.IO.File.Copy(sFileOrig, sFileDest & "\" & sFileName, True)

        Process.Start(sFileDest & "\" & sFileName)

    End Sub

    Public Sub ChangeAction(ByRef sTicketFileId As String, ByVal sAction As String)

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS

        Try

            bdconn.OpenConnection()

            Sql = "UPDATE TICKETFILE SET [ACTION] = '" & sAction & "' WHERE TICKETFILEID = '" & sTicketFileId & "' "
            bdconn.ExecuteNonSQL(Sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DeleteOldLogFile()

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS

        Try

            bdconn.OpenConnection()

            sql = "DELETE FROM TICKETFILELOG WHERE LOGDATETIME < (NOW() -1) "
            bdconn.ExecuteNonSQL(Sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            MsgBox(ex.Message)
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
