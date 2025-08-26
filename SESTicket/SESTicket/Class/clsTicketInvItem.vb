
Public Class clsTicketInvItem
    Implements IDisposable

    Dim util As New clsUtils

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

    Private Sub RefreshHead(ByVal sTicketInvHeaderId As String)

        Dim qde As Double = 0

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT SUM(ITEMQTY) as QDE " &
            "FROM TICKETINVLINE " &
            "WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "'"
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            qde = util.TrataDBNull(ds.Tables(0).Rows(0)("QDE"))
        End If
        ds.Dispose()
        ds = Nothing

        If qde > 0 Then
            sql = "UPDATE TICKETINVHEADER SET " &
            "CONSUMPTION = " & util.SQLConvStrNull(qde, "n") & " " &
            ",RETURNED = DESPATCHED - " & util.SQLConvStrNull(qde, "n") & " " &
            "WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "' "
            bdconn.ExecuteNonSQL(sql)

            sql = "UPDATE TICKETINVHEADER SET RETURNED = 0 " &
            "WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "' AND  RETURNED < 0 "
            bdconn.ExecuteNonSQL(sql)

        Else
            sql = "DELETE FROM TICKETINVHEADER WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "'"
            bdconn.ExecuteNonSQL(sql)
        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub
    Public Sub DeleteInvItemLineSales(ByVal sTicketId As String, ByVal sTicketSalesItemId As String)

        Dim sTicketInvHeaderId As String

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT TICKETINVHEADERID FROM [TICKETINVHEADER] " &
              "WHERE TICKETID = '" & sTicketId & "' " &
              "AND INVENTORYITEMID IN " &
              "(SELECT INVENTORYITEMID FROM TICKETINVLINE WHERE TICKETSALESITEMID= '" & sTicketSalesItemId & "')"
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sTicketInvHeaderId = ds.Tables(0).Rows(0)("TICKETINVHEADERID").ToString()

                sql = "DELETE FROM TICKETINVLINE WHERE TICKETSALESITEMID= '" & sTicketSalesItemId & "'"
                bdconn.ExecuteNonSQL(sql)

                'Refresh Header values
                RefreshHead(sTicketInvHeaderId)

                Dim ds2 As New DataSet

                sql = "SELECT COUNT(*) AS QDE FROM [TICKETINVHEADER] " &
                      "WHERE TICKETID = '" & sTicketId & "'"
                bdconn.ExecuteSQL(sql, ds2)

                If ds2.Tables(0).Rows(0)("QDE") = 0 Then
                    sql = "UPDATE TICKET SET NOINVITEM=0 WHERE TICKETID='" & sTicketId & "'"
                    bdconn.ExecuteNonSQL(sql)
                End If
                ds2.Dispose()
                ds2 = Nothing

            Next
        End If
        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

    End Sub

    Public Sub RefreshInvItemTicket()

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT H.TICKETID, TI.TICKETSALESITEMID " &
        "From TICKETINVLINE TI, TICKETINVHEADER H " &
        "WHERE " &
        "TI.TICKETINVHEADERID = H.TICKETINVHEADERID " &
        "AND TI.TICKETSALESITEMID NOT IN( " &
        "Select T2.TICKETSALESITEMID From TICKETSALESITEM T2) "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Me.DeleteInvItemLineSales(ds.Tables(0).Rows(i)("TICKETID").ToString, ds.Tables(0).Rows(i)("TICKETSALESITEMID").ToString)
            Next
        End If
        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

End Class
