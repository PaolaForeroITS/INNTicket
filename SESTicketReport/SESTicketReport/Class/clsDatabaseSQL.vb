Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsDatabaseSQL
    Implements IDisposable

    Dim sqlConn As SqlConnection
    Dim sqlCommand As SqlCommand

    Public Sub OpenConnection()
        Dim connString As String

        connString = ConfigurationManager.ConnectionStrings("SESTicketSQLConnStr").ConnectionString
        sqlConn = New SqlConnection(connString)

        If Not sqlConn.State = ConnectionState.Open Then
            sqlConn.Open()
        End If

    End Sub

    Public Sub CloseConnection()
        sqlConn.Close()
    End Sub

    Public Sub ExecuteNonSQL(str As String)
        sqlCommand = New SqlCommand(str)
        sqlCommand.Connection = sqlConn
        sqlCommand.ExecuteNonQuery()
        sqlCommand.Dispose()
    End Sub

    Public Sub ExecuteSQL(str As String, ByRef Ds As DataSet)

        Dim SqlAdapter As SqlDataAdapter

        sqlCommand = sqlConn.CreateCommand
        sqlCommand.CommandText = str

        SqlAdapter = New SqlDataAdapter(sqlCommand)
        SqlAdapter.Fill(Ds)

        SqlAdapter.Dispose()

    End Sub

    Public Function IsOpen() As Boolean
        If sqlConn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsSQLOnline()
        Try
            Me.OpenConnection()

            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT 1 as QDE"

            Me.ExecuteSQL(sql, ds)
            ds.Dispose()

            Me.CloseConnection()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                sqlConn.Dispose()
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
