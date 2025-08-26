Imports System.Configuration
Imports System.IO.Compression
Imports System.IO

Public Class clsSystemVersion
    Implements IDisposable

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

    Public sUsername As String
    Public isSQLConnect As Boolean
    Public sRemotePath As String
    Dim sVersionAppUpd As String
    Public sAppUpdLocal As String = ConfigurationManager.AppSettings("AppUpdLocal").ToString

    Public Function SystemVersion() As String
        Return "7.2.1"
    End Function

    Public Sub UpdateAppVersionUpdate()
        If isSQLConnect = True Then
            Me.ControlVersionSQL("APPVERSION", Me.SystemVersion)
        End If
    End Sub

    Public Function isAppVersionUpdated() As Boolean

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = True

        If isSQLConnect = True Then

            Dim bdconnSQL As New clsBancoDadosSQL
            bdconnSQL.OpenConnection()

            sql = "SELECT VERSIONSYSTEM,[REMOTEPATH],VERSIONAPPUPDATE " & _
                  "FROM VERSIONSYSTEM "

            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    sRemotePath = ds.Tables(0).Rows(i)("REMOTEPATH").ToString
                    sVersionAppUpd = ds.Tables(0).Rows(i)("VERSIONAPPUPDATE").ToString
                    If ds.Tables(0).Rows(i)("VERSIONSYSTEM") = Me.SystemVersion Then
                        result = True
                    Else
                        result = False
                    End If
                Next
            End If

            bdconnSQL.CloseConnection()
            bdconnSQL.Dispose()
            bdconnSQL = Nothing

            ds.Dispose()
            ds = Nothing

            GetToolUpdate()

        End If

        Return result

    End Function

    Private Sub GetToolUpdate()
        Try
            If IsUpdateToolUpdated() = False Then
                If (System.IO.Directory.Exists(sAppUpdLocal) = True) Then
                    System.IO.Directory.Delete(sAppUpdLocal, True)
                End If
                System.IO.Directory.CreateDirectory(sAppUpdLocal)

                'Copy the new appupd version
                System.IO.File.Copy(sRemotePath & "\SESTicketUpd\SESTicketUpd.zip", sAppUpdLocal & "\SESTicketUpd.zip", True)
                ZipFile.ExtractToDirectory(sAppUpdLocal & "\SESTicketUpd.zip", sAppUpdLocal)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub

    Private Function IsUpdateToolUpdated() As Boolean

        Try

            If System.IO.File.Exists(sAppUpdLocal & "\SESTicketUpd.txt") = True Then

                Dim LocalVersion As String

                ' Open the file using a stream reader.
                Dim line As String
                Using sr As New StreamReader(sAppUpdLocal & "\SESTicketUpd.txt")
                    ' Read the stream to a string and write the string to the console.
                    line = sr.ReadToEnd()
                End Using
                LocalVersion = line

                If LocalVersion = sVersionAppUpd Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
            End
        End Try

    End Function


    Public Function isAccTicketUpdated() As Boolean

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        ds = New DataSet

        sql = "SELECT VERSIONSYSTEM " & _
              "FROM VERSIONSYSTEM "

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If isSQLConnect = True Then
                    Me.ControlVersionSQL("BDTICKETVERSION", ds.Tables(0).Rows(i)("VERSIONSYSTEM").ToString)
                End If

                If ds.Tables(0).Rows(i)("VERSIONSYSTEM") = Me.SystemVersion Then
                    result = True
                Else
                    result = False
                End If
            Next
        End If

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing
        ds.Dispose()
        ds = Nothing

        Return result

    End Function

    Public Function isAccBaseDataUpdated() As Boolean

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection("AccBaseData")

        ds = New DataSet

        sql = "SELECT VERSIONSYSTEM " & _
              "FROM VERSIONSYSTEM "

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If isSQLConnect = True Then
                    Me.ControlVersionSQL("BDBASEDATAVERSION", ds.Tables(0).Rows(i)("VERSIONSYSTEM").ToString)
                End If

                If ds.Tables(0).Rows(i)("VERSIONSYSTEM") = Me.SystemVersion Then
                    result = True
                Else
                    result = False
                End If
            Next
        End If

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing
        ds.Dispose()
        ds = Nothing

        Return result

    End Function

    Private Sub ControlVersionSQL(sOrigin As String, sVersion As String)

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        bdconnSQL.OpenConnection()

        sql = "UPDATE [USER] SET " & sOrigin & " = '" & sVersion & "' " & _
              "WHERE USERNAME = '" & sUsername & "' "

        bdconnSQL.ExecuteNonSQL(sql)
        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing

    End Sub

End Class
