Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbPermission
Imports System.Math
Imports System.Configuration

Public Class clsBancoDadosACCESS
    Implements IDisposable

    Dim oledbConn As OleDbConnection
    Dim oledbCommand As OleDbCommand

    Public Sub OpenConnection(Optional AccessDB As String = "AccConn")
        Dim connString As String

        If AccessDB = "AccConn" Then
            connString = ConfigurationManager.ConnectionStrings("SESTicket.My.MySettings.SESTicketAccConnStr").ConnectionString
        Else
            connString = ConfigurationManager.ConnectionStrings("SESTicket.My.MySettings.SESTicketAccBaseConnStr").ConnectionString
        End If

        oledbConn = New OleDbConnection(connString)

        If Not oledbConn.State = ConnectionState.Open Then
            Try
                oledbConn.Open()
            Catch ex As Exception
                Try
                    oledbConn.Open()
                Catch ex2 As Exception
                    MsgBox(ex2.Message)
                End Try
            End Try
        End If

    End Sub

    Public Sub CloseConnection()
        oledbConn.Close()
        oledbConn.Dispose()
        oledbConn = Nothing
    End Sub

    Public Sub ExecuteNonSQL(str As String)
        oledbCommand = New OleDbCommand(str)
        oledbCommand.Connection = oledbConn
        oledbCommand.ExecuteNonQuery()
        oledbCommand.Dispose()
        oledbCommand = Nothing
    End Sub

    Public Sub ExecuteSQL(str As String, ByRef Ds As DataSet)

        Dim oledbAdapter As OleDbDataAdapter

        oledbCommand = oledbConn.CreateCommand
        oledbCommand.CommandText = str

        oledbAdapter = New OleDbDataAdapter(oledbCommand)
        oledbAdapter.Fill(Ds)

        oledbAdapter = Nothing

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

    Public Function IsSQLOnline()
        Try
            Me.OpenConnection("AccBaseData")

            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT zSQL_VERSIONBASE.VERSIONBASE FROM zSQL_VERSIONBASE"

            Me.ExecuteSQL(sql, ds)
            ds.Dispose()
            ds = Nothing

            Me.CloseConnection()
            Return True
        Catch ex As Exception
            oledbConn.Dispose()
            oledbConn = Nothing
            Return False
        End Try
    End Function

End Class
