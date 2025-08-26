
Public Class clsUpdSalesItemTicket

    Implements IDisposable

    Dim util As New clsUtils

    Public sTicketId As String
    Public sUsername As String

    Dim sCurrency As String
    Dim nExchangeRate As Double
    Dim nSalesPrice As Double
    Dim nPriceUnit As Double
    Dim nItemQty As Double
    Dim nItemDisc As Double
    Dim sDiscType As String
    Dim nDiscValue As Double
    Dim nDiscValueUSD As Double

    Dim nTotalNoDisc As Double
    Dim nTotal As Double

    Public Sub Refresh()

        Dim bdconn As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT TICKETSALESITEM.TICKETSALESITEMID " & _
        ",[CONTRACT].CURRENCY " & _
        ",TICKET.EXCHANGERATE " & _
        ",CPL.SALES_PRICE " & _
        ",TICKETSALESITEM.ITEMQTY " & _
        ",TICKETSALESITEM.ITEMDISC " & _
        ",TICKETSALESITEM.DISCTYPE " & _
        ",TICKETSALESITEM.DISCVALUE " & _
        ",TICKETSALESITEM.DISCVALUEUSD " & _
        "FROM TICKET " & _
        "INNER JOIN TICKETSALESITEM ON (TICKET.TICKETID = TICKETSALESITEM.TICKETID) " & _
        "INNER JOIN [CONTRACT] ON ([CONTRACT].CONTRACTID = TICKET.CONTRACTID) " & _
        "INNER JOIN [CONTRACTPRICELIST] CPL ON (CPL.CONTRACTPRICELISTID = TICKETSALESITEM.CONTRACTPRICELISTID) " & _
        "WHERE " & _
        "TICKET.TICKETID = '" & sTicketId & "' "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                sCurrency = ""
                nExchangeRate = 0
                nSalesPrice = 0
                nItemQty = 0
                nItemDisc = 0
                sDiscType = ""
                nDiscValue = 0
                nDiscValueUSD = 0
                nPriceUnit = 0
                nTotalNoDisc = 0
                nTotal = 0

                sCurrency = ds.Tables(0).Rows(i)("CURRENCY").ToString()
                nExchangeRate = ds.Tables(0).Rows(i)("EXCHANGERATE")
                nSalesPrice = ds.Tables(0).Rows(i)("SALES_PRICE")
                nPriceUnit = ds.Tables(0).Rows(i)("SALES_PRICE")
                nItemQty = ds.Tables(0).Rows(i)("ITEMQTY")
                nItemDisc = ds.Tables(0).Rows(i)("ITEMDISC")
                sDiscType = ds.Tables(0).Rows(i)("DISCTYPE")
                nDiscValue = ds.Tables(0).Rows(i)("DISCVALUE")
                nDiscValueUSD = ds.Tables(0).Rows(i)("DISCVALUEUSD")

                'ITEMAMOUNTNODISC
                nTotalNoDisc = nPriceUnit * nItemQty

                'DISCVALUE ITEMDISC
                If sDiscType = "PCT" Then
                    nDiscValue = nTotalNoDisc * (nItemDisc / 100)
                Else
                    nItemDisc = (nDiscValue / nTotalNoDisc) * 100
                End If

                'ITEMAMOUNT
                nTotal = nTotalNoDisc - nDiscValue

                sql = "UPDATE [TICKETSALESITEM] SET " & _
                    " [SALES_PRICE]         = " & util.SQLConvStrNull(nSalesPrice, "n") & " " & _
                    ",[PRICEUNIT]           = " & util.SQLConvStrNull(CalcPriceUnitCOP(), "n") & " " & _
                    ",[PRICEUNITUSD]        = " & util.SQLConvStrNull(CalcPriceUnitUSD(), "n") & " " & _
                    ",[ITEMDISC]            = " & util.SQLConvStrNull(nItemDisc, "n") & " " & _
                    ",[ITEMAMOUNTNODISC]    = " & util.SQLConvStrNull(CalcAmountNoDiscCOP(), "n") & " " & _
                    ",[ITEMAMOUNTNODISCUSD] = " & util.SQLConvStrNull(CalcAmountNoDiscUSD(), "n") & " " & _
                    ",[ITEMAMOUNT]          = " & util.SQLConvStrNull(CalcAmountCOP(), "n") & " " & _
                    ",[ITEMAMOUNTUSD]       = " & util.SQLConvStrNull(CalcAmountUSD(), "n") & " " & _
                    ",[DISCVALUE]           = " & util.SQLConvStrNull(CalcDiscValueCOP(), "n") & " " & _
                    ",[DISCVALUEUSD]        = " & util.SQLConvStrNull(CalcDiscValueUSD(), "n") & " " & _
                    ",[UPDATEDDATETIME]     = getdate() " & _
                    ",[UPDATEDUSER]         = " & util.SQLConvStrNull(sUsername, "s") & " " & _
                    "WHERE " & _
                    "[TICKETSALESITEMID] = '" & ds.Tables(0).Rows(i)("TICKETSALESITEMID").ToString() & "' "
                bdconn.ExecuteNonSQL(sql)

                'Update DateSync
                Dim sync As New clsSyncTicket
                sync.UpdateSyncDateTime(sTicketId, "SQL")
                sync.Dispose()
                sync = Nothing

            Next
        End If

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

#Region "ok"
    Private Function CalcPriceUnitCOP() As String
        If sCurrency <> "USD" Then
            Return nPriceUnit.ToString("n4")
        Else
            Dim nCOP As Double
            nCOP = (nPriceUnit * nExchangeRate)
            Return nCOP.ToString("n4")
        End If

    End Function

    Private Function CalcPriceUnitUSD() As String
        If sCurrency = "USD" Then
            Return nPriceUnit.ToString("n4")
        Else
            Dim nUSD As Double
            nUSD = (nPriceUnit / nExchangeRate)
            Return nUSD.ToString("n4")
        End If
    End Function

    Private Function CalcAmountNoDiscCOP() As String
        If sCurrency <> "USD" Then
            Return nTotalNoDisc.ToString("n4")
        Else
            Dim nCOB As Double
            nCOB = CDbl(CalcPriceUnitCOP()) * nItemQty
            Return nCOB.ToString("n4")
        End If
    End Function

    Private Function CalcAmountNoDiscUSD() As String
        If sCurrency = "USD" Then
            Return nTotalNoDisc.ToString("n4")
        Else
            Dim nUSD As Double
            nUSD = CDbl(CalcPriceUnitUSD()) * nItemQty
            Return nUSD.ToString("n4")
        End If
    End Function

#End Region

#Region "Converting Values"

    Private Function CalcAmountCOP() As String
        If sCurrency <> "USD" Then
            Return nTotal.ToString("n4")
        Else
            Dim nCOP As Double
            nCOP = (nTotal * nExchangeRate)
            Return nCOP.ToString("n4")
        End If
    End Function

    Private Function CalcAmountUSD() As String
        If sCurrency = "USD" Then
            Return nTotal.ToString("n4")
        Else
            Dim nUSD As Double
            nUSD = (nTotal * nExchangeRate)
            Return nUSD.ToString("n4")
        End If
    End Function

    Private Function CalcDiscValueCOP() As String
        If sCurrency <> "USD" Then
            Return nDiscValue.ToString("n4")
        Else
            Dim nCOP As Double
            Dim nAmountNoDiscN As Double = CDbl(CalcAmountNoDiscCOP())
            Dim nAmountDiscN As Double = CDbl(CalcAmountCOP())
            nCOP = nAmountNoDiscN - nAmountDiscN
            Return nCOP.ToString("n4")
        End If
    End Function

    Private Function CalcDiscValueUSD() As String
        If sCurrency = "USD" Then
            Return nDiscValue.ToString("n4")
        Else
            Dim nUSD As Double
            Dim nAmountNoDiscN As Double = CDbl(CalcAmountNoDiscUSD())
            Dim nAmountDiscN As Double = CDbl(CalcAmountUSD())
            nUSD = nAmountNoDiscN - nAmountDiscN
            Return nUSD.ToString("n4")
        End If
    End Function

#End Region



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
