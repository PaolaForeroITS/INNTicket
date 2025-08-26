Public Class clsSalesItemTotal
    Implements IDisposable

    Public Sub UpdateTotal(sTicket As String, sLayout As String)
        If sLayout = "L01" Then
            Me.UpdateTotalL01(sTicket)
        ElseIf sLayout = "L02" Then
            Me.UpdateTotalML02Mat(sTicket)
            Me.UpdateTotalML02Serv(sTicket)
        End If
    End Sub

    Public Sub UpdateTotalL01(sTicket As String)

        Dim sql As String
        Dim bdconnACCESS As New clsBancoDadosACCESS

        bdconnACCESS.OpenConnection()

        sql = "delete from SALESITEM_TOTAL_L01 " & _
              "where TICKETID = '" & sTicket & "' "
        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L01 (ORD,TICKETID,[DESCRIBE],AMOUNTUSD,PORTIONVALUEUSD,PORTIONVALUECOP) " & _
        "select " & _
        " 1 AS ORD " & _
        ",TICKETID, 'SubTotal' as [DESCRIBE]  " & _
        ",SUM(ITEMAMOUNTUSD) AS AMOUNTUSD  " & _
        ",SUM(PORTIONVALUEUSD) AS PORTIONVALUEUSD1  " & _
        ",SUM(PORTIONVALUECOP) AS PORTIONVALUECOP1   " & _
        "from [SALESITEM_V]  " & _
        "where   " & _
        "EXIBITONREPORT='YES'  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "GROUP BY TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L01 (ORD,TICKETID,[DESCRIBE],AMOUNTUSD,PORTIONVALUEUSD,PORTIONVALUECOP) " & _
        "select  " & _
        " 2 AS ORD  " & _
        ",TICKETID, 'Utilidad '+ CSTR(SERVICE_UTILITY_PERC) + '%' as [DESCRIBE]  " & _
        ",SUM(ITEMAMOUNTUSD) * SERVICE_UTILITY_PERC_ADJ AS AMOUNTUSD  " & _
        ",SUM(PORTIONVALUEUSD) * SERVICE_UTILITY_PERC_ADJ   AS PORTIONVALUEUSD1  " & _
        ",SUM(PORTIONVALUECOP) * SERVICE_UTILITY_PERC_ADJ   AS PORTIONVALUECOP1   " & _
        "from [SALESITEM_V]  " & _
        "where  " & _
        "EXIBITONREPORT='YES'  " & _
        "AND SERVICE_UTILITY = 0  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "GROUP BY TICKETID,SERVICE_UTILITY_PERC_ADJ,SERVICE_UTILITY_PERC  "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L01 (ORD, TICKETID, [DESCRIBE] ,AMOUNTUSD,PORTIONVALUEUSD,PORTIONVALUECOP) " & _
        "select  " & _
        " 3 AS ORD  " & _
        ",TICKETID, 'IVA '  + CSTR(SERVICE_IVA_PERC) + '%' as [DESCRIBE]  " & _
        ",(SUM(ITEMAMOUNTUSD) * SERVICE_UTILITY_PERC_ADJ) * SERVICE_IVA_PERC/100 AS AMOUNTUSD  " & _
        ",(SUM(PORTIONVALUEUSD) * SERVICE_UTILITY_PERC_ADJ) * SERVICE_IVA_PERC/100   AS PORTIONVALUEUSD1  " & _
        ",(SUM(PORTIONVALUECOP) * SERVICE_UTILITY_PERC_ADJ) * SERVICE_IVA_PERC/100   AS PORTIONVALUECOP1   " & _
        "from [SALESITEM_V]  " & _
        "where  " & _
        "EXIBITONREPORT='YES'  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "GROUP BY TICKETID,SERVICE_UTILITY_PERC_ADJ,SERVICE_IVA_PERC "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L01 (ORD, TICKETID, [DESCRIBE],AMOUNTUSD,PORTIONVALUEUSD,PORTIONVALUECOP) " & _
        "select  " & _
        " 4 AS ORD  " & _
        ",TICKETID, 'Total' as [DESCRIBE]  " & _
        ",SUM(ITEMAMOUNTUSD) + ((SUM(ITEMAMOUNTUSD) * SERVICE_UTILITY_PERC_ADJ) * SERVICE_IVA_PERC/100) AS AMOUNTUSD  " & _
        ",SUM(PORTIONVALUEUSD) + ((SUM(PORTIONVALUEUSD) * SERVICE_UTILITY_PERC_ADJ) * SERVICE_IVA_PERC/100)   AS PORTIONVALUEUSD1  " & _
        ",SUM(PORTIONVALUECOP) + ((SUM(PORTIONVALUECOP) * SERVICE_UTILITY_PERC_ADJ) * SERVICE_IVA_PERC/100)   AS PORTIONVALUECOP1   " & _
        "from [SALESITEM_V]   " & _
        "where  " & _
        "EXIBITONREPORT='YES'  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "GROUP BY TICKETID,SERVICE_UTILITY_PERC_ADJ,SERVICE_IVA_PERC "

        bdconnACCESS.ExecuteNonSQL(sql)

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing


    End Sub

    Public Sub UpdateTotalML02Mat(sTicket As String)

        Dim sql As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        sql = "delete from SALESITEM_TOTAL_L02_MAT " & _
              "where TICKETID = '" & sTicket & "' "
        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_MAT (ORD,TICKETID,[DESCRIBE],AMOUNTCOP,AMOUNTUSD) " & _
        "select " & _
        " 1 AS ORD " & _
        ",TICKETID, 'SubTotal without IVA' as [DESCRIBE] " & _
        ",SUM(ITEMAMOUNTNODISC) AS AMOUNTCOP " & _
        ",SUM(ITEMAMOUNTNODISCUSD) AS AMOUNTUSD " & _
        "from [SALESITEM_V] " & _
        "where " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Material' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_MAT (ORD,TICKETID,[DESCRIBE],AMOUNTCOP,AMOUNTUSD) " & _
        "select  " & _
        " 2 AS ORD  " & _
        ",TICKETID, 'Discount' as [DESCRIBE]  " & _
        ",SUM(ITEMDISCVALUE) AS COP  " & _
        ",SUM(ITEMDISCVALUEUSD) AS USD  " & _
        "from [SALESITEM_V]  " & _
        "where  " & _
        "EXIBITONREPORT='YES'  AND [TYPE] = 'Material'  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_MAT (ORD,TICKETID,[DESCRIBE],AMOUNTCOP,AMOUNTUSD) " & _
        "select  " & _
        " 3 AS ORD  " & _
        ",TICKETID, 'SubTotal without IVA (Discount)' as [DESCRIBE]  " & _
        ",SUM(ITEMAMOUNT) AS COP  " & _
        ",SUM(ITEMAMOUNTUSD) AS USD  " & _
        "from [SALESITEM_V]  " & _
        "where  " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Material' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_MAT (ORD,TICKETID,[DESCRIBE],AMOUNTCOP,AMOUNTUSD) " & _
        "select  " & _
        " 4 AS ORD  " & _
        ",TICKETID, cstr(MATERIAL_IVA_PERC) + '% IVA' as [DESCRIBE]  " & _
        ",SUM(ITEMAMOUNT)* MATERIAL_IVA_PERC/100 AS COP  " & _
        ",SUM(ITEMAMOUNTUSD)* MATERIAL_IVA_PERC/100 AS USD  " & _
        "from [SALESITEM_V]  " & _
        "where  " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Material'  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID,MATERIAL_IVA_PERC "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_MAT (ORD,TICKETID,[DESCRIBE],AMOUNTCOP,AMOUNTUSD) " & _
        "select  " & _
        " 5 AS ORD  " & _
        ",TICKETID, 'Total with IVA' as [DESCRIBE]  " & _
        ",SUM(ITEMAMOUNT) + (SUM(ITEMAMOUNT)* MATERIAL_IVA_PERC/100) AS COP  " & _
        ",SUM(ITEMAMOUNTUSD) + (SUM(ITEMAMOUNTUSD)* MATERIAL_IVA_PERC/100) AS USD  " & _
        "from [SALESITEM_V]  " & _
        "where  " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Material'  " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID,MATERIAL_IVA_PERC  "

        bdconnACCESS.ExecuteNonSQL(sql)

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

    End Sub

    Public Sub UpdateTotalML02Serv(sTicket As String)

        Dim sql As String

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        sql = "delete from SALESITEM_TOTAL_L02_SERV " & _
              "where TICKETID = '" & sTicket & "' "
        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_SERV (ORD, TICKETID, [DESCRIBE], AMOUNTCOP, AMOUNTUSD) " & _
        "select " & _
        " 1 AS ORD " & _
        ",TICKETID, 'SubTotal without IVA' as [DESCRIBE] " & _
        ",SUM(ITEMAMOUNTNODISC) AS AMOUNTCOP " & _
        ",SUM(ITEMAMOUNTNODISCUSD) AS AMOUNTUSD " & _
        "from [SALESITEM_V] " & _
        "where " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Service' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_SERV (ORD, TICKETID, [DESCRIBE], AMOUNTCOP, AMOUNTUSD) " & _
        "select " & _
        " 2 AS ORD " & _
        ",TICKETID, 'Discount' as [DESCRIBE] " & _
        ",SUM(ITEMDISCVALUE) AS COP " & _
        ",SUM(ITEMDISCVALUEUSD) AS USD " & _
        "from [SALESITEM_V] " & _
        "where " & _
        "EXIBITONREPORT='YES'  AND [TYPE] = 'Service' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_SERV (ORD, TICKETID, [DESCRIBE], AMOUNTCOP, AMOUNTUSD) " & _
        "select " & _
        " 3 AS ORD " & _
        ",TICKETID, 'SubTotal without IVA (Discount)' as [DESCRIBE] " & _
        ",SUM(ITEMAMOUNT) AS COP " & _
        ",SUM(ITEMAMOUNTUSD) AS USD " & _
        "from [SALESITEM_V] " & _
        "where " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Service' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_SERV (ORD, TICKETID, [DESCRIBE], AMOUNTCOP, AMOUNTUSD) " & _
        "select " & _
        " 4 AS ORD " & _
        ",TICKETID, 'Utilidad ' + cstr(SERVICE_UTILITY_PERC) + '%' as [DESCRIBE] " & _
        ",SUM(ITEMAMOUNT) * SERVICE_UTILITY_PERC_ADJ AS COP " & _
        ",SUM(ITEMAMOUNTUSD) * SERVICE_UTILITY_PERC_ADJ AS USD " & _
        "from [SALESITEM_V] " & _
        "where " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Service' " & _
        "AND SERVICE_UTILITY = 0 " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID,SERVICE_UTILITY,SERVICE_UTILITY_PERC,SERVICE_UTILITY_PERC_ADJ "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_SERV (ORD, TICKETID, [DESCRIBE], AMOUNTCOP, AMOUNTUSD) " & _
        "select " & _
        " 5 AS ORD " & _
        ",TICKETID, cstr(SERVICE_IVA_PERC ) + '% IVA' as [DESCRIBE] " & _
        ",(SUM(ITEMAMOUNT) * SERVICE_UTILITY_PERC_ADJ)*SERVICE_IVA_PERC/100 AS COP " & _
        ",(SUM(ITEMAMOUNTUSD) * SERVICE_UTILITY_PERC_ADJ )*SERVICE_IVA_PERC/100 AS USD " & _
        "from [SALESITEM_V] " & _
        "where " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Service' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID,SERVICE_UTILITY,SERVICE_UTILITY_PERC_ADJ,SERVICE_IVA_PERC "

        bdconnACCESS.ExecuteNonSQL(sql)

        sql = "insert into SALESITEM_TOTAL_L02_SERV (ORD, TICKETID, [DESCRIBE], AMOUNTCOP, AMOUNTUSD) " & _
        "select " & _
        " 6 AS ORD " & _
        ",TICKETID, 'Valor Total con IVA' as [DESCRIBE] " & _
        ",SUM(ITEMAMOUNT) + ((SUM(ITEMAMOUNT) * SERVICE_UTILITY_PERC_ADJ )*SERVICE_IVA_PERC/100) AS COP " & _
        ",SUM(ITEMAMOUNTUSD) + ((SUM(ITEMAMOUNTUSD) * SERVICE_UTILITY_PERC_ADJ)*SERVICE_IVA_PERC/100) AS USD  " & _
        "from [SALESITEM_V] " & _
        "where  " & _
        "EXIBITONREPORT='YES' AND [TYPE] = 'Service' " & _
        "AND TICKETID = '" & sTicket & "' " & _
        "group by TICKETID,SERVICE_UTILITY,SERVICE_UTILITY_PERC_ADJ,SERVICE_IVA_PERC "

        bdconnACCESS.ExecuteNonSQL(sql)

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

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
