Imports System
Imports System.Configuration
Imports System.DirectoryServices

'Its necessary References "System.DirectoryServices" in Project

Public Class clsActiveDirectory
    Implements IDisposable

    Public Function AuthenticUserAD(ByVal Username As String, ByVal Password As String, Optional ByRef ResultMsg As String = "", Optional ByRef ErroNum As String = "") As Boolean
        'Responsible for Authenticate the User using Active Directory credentials

        Dim UserValid As Boolean
        Dim sADDomain As String = ConfigurationManager.AppSettings("ActiveDirectoryDomain")

        If sADDomain = "" Then
            ResultMsg = "Active Directory Domain Invalid. Please, check Config file"
            UserValid = False
        Else
            Try
                Dim oAD As DirectoryEntry = New DirectoryEntry(sADDomain, Username, Password)
                ResultMsg = oAD.Name
                UserValid = True

            Catch ex As Exception
                ErroNum = ex.HResult.ToString
                ResultMsg = ex.Message
                UserValid = False
            End Try

        End If

        Return UserValid

    End Function


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
