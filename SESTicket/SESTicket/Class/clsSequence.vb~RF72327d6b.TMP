Public Class clsSequenceAccess
    Implements IDisposable

    Dim sTicketId As String
    Dim util As New clsUtils

    Public Sub New(Ticket As String)
        sTicketId = Ticket
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

    Public Function TicketSalesItemNextId() As String

        Dim sSequence As String = 0
        Dim bdconnACCESS As New clsBancoDadosACCESS

        bdconnACCESS.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETSALESITEMID,3)))+1 as NEWID " &
              "FROM [TICKETSALESITEM] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketInventoryNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(right(TICKETINVENTORYID,3)))+1 as NEWID " &
              "FROM [TICKETINVENTORY] " &
              "WHERE " &
              "TICKETSALESITEMID LIKE '" & sTicketId & "%'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketWorkerNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(right(TICKETWORKERID,3)))+1 as NEWID " &
              "FROM TICKETWORKER " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketOpeRepNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(right(TICKETOPEREPID,3)))+1 as NEWID " &
              "FROM TICKETOPEREP " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketOpeRepActNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(right(TICKETOPEREPACTID,3)))+1 as NEWID " &
              "FROM TICKETOPEREPACT " &
              "WHERE " &
              "TICKETOPEREPACTID LIKE '" & sTicketId & ".%'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketOpeRepActLineOrdNextId(ByVal sTicketOpeRepId As String) As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max([LINEORDER])+1 as LINEORD " &
              "FROM TICKETOPEREPACT " &
              "WHERE " &
              "TICKETOPEREPACTID LIKE '" & sTicketId & ".%'" &
              "AND TICKETOPEREPID = '" & sTicketOpeRepId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("LINEORD").ToString) = False Then
                    If ds.Tables(0).Rows(i)("LINEORD").ToString <> "" Then
                        sSequence = ds.Tables(0).Rows(i)("LINEORD").ToString
                    Else
                        sSequence = 0
                    End If
                Else
                    sSequence = 0
                End If
            Next
        Else
            sSequence = 0
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketServEvalHSEQNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETSERVEVALID,3)))+1 as NEWID " &
              "FROM [TICKETSERVEVAL_HSEQ] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketServEvalECPNextId() As String
        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETSERVEVALECPID,3)))+1 as NEWID " &
              "FROM [TICKETSERVEVAL_ECP] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"
        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketServiceTypeNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETSERVICETYPEID,3)))+1 as NEWID " &
              "FROM [TICKETSERVICETYPE] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketInvItemHeadNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETINVHEADERID,3)))+1 as NEWID " &
              "FROM [TICKETINVHEADER] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketInvItemLineNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETINVLINEID,3)))+1 as NEWID " &
              "FROM [TICKETINVLINE] " &
              "WHERE " &
              "[TICKETINVHEADERID] IN (SELECT TICKETINVHEADERID FROM [TICKETINVHEADER] WHERE TICKETID = '" & sTicketId & "')"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketInvAdicNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETINVADICID,3)))+1 as NEWID " &
              "FROM [TICKETINVADIC] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

    Public Function TicketEquipmentNextId() As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sSequence As String = 0
        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT Max(CInt(Right(TICKETEQUIPMENTID,3)))+1 as NEWID " &
              "FROM [TICKETEQUIPMENT] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If IsDBNull(ds.Tables(0).Rows(i)("NEWID").ToString) = False Then
                    If ds.Tables(0).Rows(i)("NEWID").ToString <> "" Then
                        sSequence = sTicketId & "." & Right("000" & ds.Tables(0).Rows(i)("NEWID").ToString, 3)
                    Else
                        sSequence = sTicketId & ".001"
                    End If
                Else
                    sSequence = sTicketId & ".001"
                End If
            Next
        Else
            sSequence = sTicketId & ".001"
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return sSequence

    End Function

End Class
