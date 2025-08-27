Public Class clsRefreshDB
    Implements IDisposable

    Public sReleasePath As String
    Private sLog As String

    Private Sub Log(ByVal Log As String)
        sLog = sLog & Log
    End Sub

    Public Function CreateInsertTab(ByVal sTable As String) As String

        Dim sql As String
        Dim str As String
        Dim sInsert As String = ""
        Dim sColuna As String = ""
        Dim ds As New DataSet

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection(sReleasePath)

        sql = "SELECT '[' + COLUNA + ']' as COLUNA " & _
              "FROM OLD_ZCOLUMN " & _
              "WHERE " & _
              "TABELA = '" & sTable & "' "

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                If i = 0 Then
                    str = ds.Tables(0).Rows(i)("COLUNA").ToString()
                Else
                    str = "," & ds.Tables(0).Rows(i)("COLUNA").ToString()
                End If
                sColuna = sColuna & str
            Next
        End If

        ds.Dispose()
        ds.Clear()
        ds = Nothing
        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        sInsert = "INSERT INTO " & sTable & "(" & sColuna & ") SELECT " & sColuna & " FROM OLD_" & sTable

        Return sInsert


    End Function

    Private Sub CopyTableRow(ByVal sTable As String, ByRef bErro As Boolean, ByRef sReturn As String, Optional ByRef NumRows As Integer = 0)
        Try
            Dim sInsert As String = Me.CreateInsertTab(sTable)
            Dim bdconnACCESS As New clsBancoDadosACCESS

            bdconnACCESS.OpenConnection(sReleasePath)

            bdconnACCESS.ExecuteNonSQL("DELETE FROM " & sTable)
            bdconnACCESS.ExecuteNonSQL(sInsert)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            bErro = False

        Catch ex As Exception
            bErro = True
            sReturn = ex.Message
            NumRows = 0
        End Try

    End Sub

    Public Function CopyTable(ByVal sTable As String, ByRef log As String) As Boolean

        Try
            Dim bErro As Boolean = False
            Dim sReturn As String = Nothing
            Dim nNumRows As Integer = 0

            sLog = ""

            Me.Log("Updating " & sTable & " Table...")

            Me.CopyTableRow(sTable, bErro, sReturn, nNumRows)

            If bErro = True Then
                Me.Log("ERROR! " & Environment.NewLine & sReturn)
            Else
                Me.Log("Success!")
            End If
            log = sLog
            Return bErro

        Catch ex As Exception
            Me.Log("Error: " & ex.Message)
            log = sLog
            Return True
        End Try

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
