Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbPermission
Imports System.IO
Imports System.Math

Public Class clsBancoDadosACCESS
    Implements IDisposable

    Dim oledbConn As OleDbConnection
    Dim oledbCommand As OleDbCommand

    'Public Sub OpenConnection(Optional AccessDB As String = "AccConn")
    '    Dim connString As String

    '    If AccessDB = "AccConn" Then
    '        connString = ConfigurationManager.ConnectionStrings("SESTicket.My.MySettings.SESTicketAccConnStr").ConnectionString
    '    Else
    '        connString = ConfigurationManager.ConnectionStrings("SESTicket.My.MySettings.SESTicketAccBaseConnStr").ConnectionString
    '    End If

    '    oledbConn = New OleDbConnection(connString)

    '    If Not oledbConn.State = ConnectionState.Open Then
    '        Try
    '            oledbConn.Open()
    '            Log("Conectado a base de datos: " & oledbConn.DataSource) 'PFORERO 2025
    '        Catch ex As Exception
    '            Try
    '                oledbConn.Open()
    '            Catch ex2 As Exception
    '                'MsgBox(ex2.Message)
    '                Debug.WriteLine("Error al registrar base de datos: " & ex.Message) 'PFORERO 2025
    '                MessageBox.Show("Ocurrió un error al ejecutar Access Connexión:" & vbCrLf & ex2.Message, "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End Try
    '        End Try
    '    End If

    'End Sub

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
                    MessageBox.Show("Ocurrió un error al ejecutar Access Connexión:" & vbCrLf & ex2.Message,
                                "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Try
        End If

        ' 👇 Nuevo: registra la ruta real del archivo de base de datos Access
        If oledbConn.State = ConnectionState.Open Then
            Try
                Log("Conectado a base de datos: " & oledbConn.DataSource)
            Catch ex As Exception
                Debug.WriteLine("Error al registrar base de datos: " & ex.Message)
            End Try
        End If
    End Sub


    Public Sub CloseConnection()
        oledbConn.Close()
        oledbConn.Dispose()
        oledbConn = Nothing
    End Sub

    'Public Sub ExecuteNonSQL(str As String) PAOLA FORERO 2025
    '    Try
    '        oledbCommand = New OleDbCommand(str)
    '        oledbCommand.Connection = oledbConn
    '        oledbCommand.ExecuteNonQuery()
    '        oledbCommand.Dispose()
    '        oledbCommand = Nothing
    '    Catch ex As Exception

    '        MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL:" & vbCrLf & ex.Message, "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Log("Error SQL: " & ex.ToString())

    '    End Try
    'End Sub

    Public Sub ExecuteNonSQL(str As String)
        Try
            If oledbConn.State <> ConnectionState.Open Then
                oledbConn.Open()
            End If

            ' 👇 Agrega esto para registrar el SQL real que se ejecuta
            Log("Ejecutando SQL: " & str)

            oledbCommand = New OleDbCommand(str, oledbConn)
            oledbCommand.ExecuteNonQuery()
            oledbCommand.Dispose()
            oledbCommand = Nothing

            Log("Ejecución exitosa.")

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL:" & vbCrLf & ex.Message,
                        "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log("Error SQL: " & ex.ToString())

        Finally
            If oledbConn.State = ConnectionState.Open Then
                oledbConn.Close()
            End If
        End Try
    End Sub


    Private Sub Log(msg As String)
        Try
            Dim logPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppLog.txt")
            Dim logMessage As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {msg}{Environment.NewLine}"

            File.AppendAllText(logPath, logMessage, System.Text.Encoding.UTF8)
        Catch logEx As Exception
            ' Evita que un error de logging detenga el programa
            Debug.WriteLine("Error al escribir en log: " & logEx.Message)
        End Try
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
