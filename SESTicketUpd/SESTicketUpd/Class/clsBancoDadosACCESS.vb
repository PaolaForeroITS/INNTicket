Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbPermission
Imports System.Math
Imports System.Configuration

Public Class clsBancoDadosACCESS
    Implements IDisposable

    Dim oledbConn As OleDbConnection
    Dim oledbCommand As OleDbCommand

    Public Sub OpenConnection(ByVal sReleasePath As String)
        Dim connString As String
        connString = ConfigurationManager.ConnectionStrings("SESTicket.My.MySettings.SESTicketAccConnStr").ConnectionString
        connString = Replace(connString, "RELEASEPATH", sReleasePath)

        oledbConn = New OleDbConnection(connString)

        If Not oledbConn.State = ConnectionState.Open Then
            oledbConn.Open()
        End If

    End Sub

    Public Sub CloseConnection()
        oledbConn.Close()
        oledbConn.Dispose()
        oledbConn = Nothing
    End Sub

    Public Sub ExecuteNonSQL(str As String, Optional ByRef RowAffected As Double = 0)
        oledbCommand = New OleDbCommand(str)
        oledbCommand.Connection = oledbConn
        RowAffected = oledbCommand.ExecuteNonQuery()
        oledbCommand.Dispose()
    End Sub

    Public Sub ExecuteSQL(str As String, ByRef Ds As DataSet)

        Dim oledbAdapter As OleDbDataAdapter

        oledbCommand = oledbConn.CreateCommand
        oledbCommand.CommandText = str

        oledbAdapter = New OleDbDataAdapter(oledbCommand)
        oledbAdapter.Fill(Ds)

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
