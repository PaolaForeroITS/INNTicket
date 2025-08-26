Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsBancoDadosSQL
    Implements IDisposable

    Dim sqlConn As SqlConnection
    Dim sqlCommand As SqlCommand

    Public Sub OpenConnection(Optional TimeOut As String = "")
        Dim connString As String
        Dim sTimeOut As String

        sTimeOut = ConfigurationManager.AppSettings("SQLTimeOut").ToString

        connString = ConfigurationManager.ConnectionStrings("SESTicket.My.MySettings.SESTicketSQLConnStr").ConnectionString
        connString = connString & ";Connection Timeout=" & sTimeOut & ";"

        sqlConn = New SqlConnection(connString)

        If Not sqlConn.State = ConnectionState.Open Then
            sqlConn.Open()
        End If

    End Sub

    Public Sub CloseConnection()
        If Not sqlConn.State = ConnectionState.Open Then
            sqlConn.Close()
            sqlConn.Dispose()
            sqlConn = Nothing
        End If

    End Sub

    Public Sub ExecuteNonSQL(str As String)
        sqlCommand = New SqlCommand(str)
        sqlCommand.Connection = sqlConn
        sqlCommand.ExecuteNonQuery()
        sqlCommand.Dispose()
        sqlCommand = Nothing
    End Sub

    Public Sub ExecuteSQL(str As String, ByRef Ds As DataSet)

        Dim SqlAdapter As SqlDataAdapter

        sqlCommand = sqlConn.CreateCommand
        sqlCommand.CommandText = str

        SqlAdapter = New SqlDataAdapter(sqlCommand)
        SqlAdapter.Fill(Ds)

        SqlAdapter.Dispose()
        SqlAdapter = Nothing

    End Sub

    Public Function IsOpen() As Boolean
        If sqlConn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If

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
