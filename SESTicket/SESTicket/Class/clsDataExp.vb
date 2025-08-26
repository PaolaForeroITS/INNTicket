Imports Excel = Microsoft.Office.Interop.excel

Public Class clsDataExp
    Implements IDisposable

#Region "Default Methods"

    Public Sub ExpLayout(ByVal sLayoutType As String, ByVal sFileDest As String)

        Dim sFileOrig As String = ""

        If sLayoutType = "CONTRACTPRICELIST" Then
            sFileOrig = "C:\SESTicket\app\Excel\contractpricelist.xlsx"
        ElseIf sLayoutType = "EQUIPMENT" Then
            sFileOrig = "C:\SESTicket\app\Excel\equipment.xlsx"
        ElseIf sLayoutType = "WORKER" Then
            sFileOrig = "C:\SESTicket\app\Excel\worker.xlsx"
        ElseIf sLayoutType = "INVENTORYITEM" Then
            sFileOrig = "C:\SESTicket\app\Excel\inventoryitem.xlsx"
        ElseIf sLayoutType = "WELL" Then
            sFileOrig = "C:\SESTicket\app\Excel\well.xlsx"
        ElseIf sLayoutType = "frmInvoiceList" Then
            sFileOrig = "C:\SESTicket\app\Excel\frmInvoiceList.xlsx"
        End If

        System.IO.File.Copy(sFileOrig, sFileDest, True)

    End Sub

#End Region

#Region "FormsExport"

    Public Sub frmInvoiceList(ByVal sFileDest As String, ByRef grd As DataGridView, Optional bShowServiceTicketARG As Boolean = True)

        If grd.Rows.Count = 0 Then
            Exit Sub
        End If

        Try

            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet

            workbook = excelApp.Workbooks.Open(sFileDest)
            worksheet = workbook.Sheets("data")

            Dim nLine As Integer = 2

            For i As Integer = 0 To grd.Rows.Count - 1

                With worksheet
                    .Range("A" & nLine.ToString).Value = grd.Rows(i).Cells("colTicketId").Value
                    .Range("B" & nLine.ToString).Value = grd.Rows(i).Cells("colCreatedBy").Value
                    .Range("C" & nLine.ToString).Value = grd.Rows(i).Cells("colServiceDate").Value
                    .Range("D" & nLine.ToString).Value = grd.Rows(i).Cells("colClosedDate").Value
                    .Range("E" & nLine.ToString).Value = grd.Rows(i).Cells("colSuperiorNum").Value

                    .Range("F" & nLine.ToString).Value = grd.Rows(i).Cells("colSuperiorSupervName").Value

                    .Range("G" & nLine.ToString).Value = grd.Rows(i).Cells("colServiceOrderNum").Value
                    .Range("H" & nLine.ToString).Value = grd.Rows(i).Cells("colJobNumber").Value
                    .Range("I" & nLine.ToString).Value = grd.Rows(i).Cells("colDM").Value

                    .Range("J" & nLine.ToString).Value = grd.Rows(i).Cells("colLineType").Value
                    .Range("K" & nLine.ToString).Value = grd.Rows(i).Cells("colTicketStatus").Value
                    .Range("L" & nLine.ToString).Value = grd.Rows(i).Cells("colInvoiceStatus").Value
                    .Range("M" & nLine.ToString).Value = grd.Rows(i).Cells("colInvoiceDate").Value
                    .Range("N" & nLine.ToString).Value = grd.Rows(i).Cells("colInvoiceDetail").Value
                    .Range("O" & nLine.ToString).Value = grd.Rows(i).Cells("colServiceLine").Value
                    .Range("P" & nLine.ToString).Value = grd.Rows(i).Cells("colCustomer").Value
                    .Range("Q" & nLine.ToString).Value = grd.Rows(i).Cells("colContract").Value
                    .Range("R" & nLine.ToString).Value = grd.Rows(i).Cells("colSite").Value
                    .Range("S" & nLine.ToString).Value = grd.Rows(i).Cells("colWell").Value
                    .Range("T" & nLine.ToString).Value = grd.Rows(i).Cells("colServiceTypeGrpCode").Value
                    .Range("U" & nLine.ToString).Value = grd.Rows(i).Cells("colServiceType").Value
                    .Range("V" & nLine.ToString).Value = grd.Rows(i).Cells("colCurrency").Value
                    .Range("W" & nLine.ToString).Value = grd.Rows(i).Cells("colSubTotal").Value
                    .Range("X" & nLine.ToString).Value = grd.Rows(i).Cells("colDiscount").Value
                    .Range("Y" & nLine.ToString).Value = grd.Rows(i).Cells("colTicketTotal").Value
                    .Range("Z" & nLine.ToString).Value = grd.Rows(i).Cells("colInvoiceTotal").Value
                    .Range("AA" & nLine.ToString).Value = grd.Rows(i).Cells("colDif").Value
                End With
                nLine = nLine + 1
            Next

            If bShowServiceTicketARG = False Then
                worksheet.Columns(5).Delete()
                worksheet.Columns(5).Delete()
                worksheet.Columns(5).Delete()
                worksheet.Columns(5).Delete()
            End If


            'fecha a pasta de trabalho e o Excel
            workbook.Close(True)
            excelApp.Quit()
            workbook = Nothing
            excelApp = Nothing
            worksheet = Nothing

        Catch ex As Exception
            MsgBox("Some problems occurred during export: " & ex.Message, vbInformation)
        End Try

    End Sub

#End Region

#Region "ExportTool"

    Public Sub ContractPriceList(ByVal sFileDest As String, ByVal bExpInactData As Boolean, sContractId As String)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT CONTRACTPRICELISTID, " &
            "CONTRACTID, GROUPORDER, CUSTCODEITEM, DESCRIPTION, SALES_PRICE, UNIT_SALE, INVENTORYCLASSID, " &
            "CONTRACTED_QTY, ACTIVE, ISHEADER, EXIBITONREPORT, TABGROUP, SHOWCUSTITEMREPORT, PRICEBASE, PRICEUTILITY,  " &
            "PERMITUPDATEDESCRIP, PERMITUPDATEPRICEUNIT, PERMITNEGATIVE " &
            "FROM zSQL_CONTRACTPRICELIST " &
            "WHERE (((CONTRACTID)=" & sContractId & ")) " &
            "AND ACTIVE IN ('YES'" & IIf(bExpInactData = True, ",'NO')", ")") & " " &
            "ORDER BY CONTRACTPRICELISTID "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet

            workbook = excelApp.Workbooks.Open(sFileDest)
            worksheet = workbook.Sheets("data")

            Dim nLine As Integer = 3

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                With worksheet
                    .Range("A" & nLine.ToString).Value = ds.Tables(0).Rows(i)("CONTRACTPRICELISTID")
                    .Range("B" & nLine.ToString).Value = ds.Tables(0).Rows(i)("TABGROUP")
                    .Range("C" & nLine.ToString).Value = ds.Tables(0).Rows(i)("GROUPORDER").ToString
                    .Range("D" & nLine.ToString).Value = ds.Tables(0).Rows(i)("CUSTCODEITEM").ToString
                    .Range("E" & nLine.ToString).Value = ds.Tables(0).Rows(i)("DESCRIPTION")
                    .Range("F" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SALES_PRICE")
                    .Range("G" & nLine.ToString).Value = ds.Tables(0).Rows(i)("UNIT_SALE")
                    .Range("H" & nLine.ToString).Value = ds.Tables(0).Rows(i)("INVENTORYCLASSID")
                    .Range("I" & nLine.ToString).Value = ds.Tables(0).Rows(i)("CONTRACTED_QTY")
                    .Range("J" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ISHEADER")
                    .Range("K" & nLine.ToString).Value = ds.Tables(0).Rows(i)("EXIBITONREPORT")
                    .Range("L" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SHOWCUSTITEMREPORT")
                    .Range("M" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ACTIVE")
                    .Range("N" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PRICEBASE")
                    .Range("O" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PRICEUTILITY")

                    .Range("P" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PERMITUPDATEDESCRIP")
                    .Range("Q" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PERMITUPDATEPRICEUNIT")
                    .Range("R" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PERMITNEGATIVE")

                End With
                nLine = nLine + 1
            Next

            'fecha a pasta de trabalho e o Excel
            workbook.Close(True)
            excelApp.Quit()
            workbook = Nothing
            excelApp = Nothing
            worksheet = Nothing

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Public Sub Equipment(ByVal sFileDest As String, ByVal bExpInactData As Boolean)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT zSQL_EQUIPMENT.EQUIPMENTID, zSQL_EQUIPMENT.DESCRIPTION, zSQL_EQUIPMENT.MODEL, " &
            "zSQL_EQUIPMENT.SERIAL, zSQL_EQUIPMENT.TAG, zSQL_EQUIPMENT.ACTIVE, zSQL_EQUIPMENT.UNIT " &
            "FROM zSQL_EQUIPMENT " &
            "WHERE ACTIVE IN ('YES'" & IIf(bExpInactData = True, ",'NO')", ")") & " " &
            "ORDER BY zSQL_EQUIPMENT.EQUIPMENTID "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet

            workbook = excelApp.Workbooks.Open(sFileDest)
            worksheet = workbook.Sheets("data")

            Dim nLine As Integer = 3

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                With worksheet
                    .Range("A" & nLine.ToString).Value = ds.Tables(0).Rows(i)("EQUIPMENTID").ToString
                    .Range("B" & nLine.ToString).Value = ds.Tables(0).Rows(i)("DESCRIPTION").ToString
                    .Range("C" & nLine.ToString).Value = ds.Tables(0).Rows(i)("MODEL").ToString
                    .Range("D" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SERIAL").ToString
                    .Range("E" & nLine.ToString).Value = ds.Tables(0).Rows(i)("TAG").ToString
                    .Range("F" & nLine.ToString).Value = ds.Tables(0).Rows(i)("UNIT").ToString
                    .Range("G" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ACTIVE").ToString
                End With
                nLine = nLine + 1
            Next

            'fecha a pasta de trabalho e o Excel
            workbook.Close(True)
            excelApp.Quit()

            workbook = Nothing
            excelApp = Nothing
            worksheet = Nothing

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Public Sub Worker(ByVal sFileDest As String, ByVal bExpInactData As Boolean)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT zSQL_WORKER.WORKERID, zSQL_WORKER.NAME1, zSQL_WORKER.NAME2, " &
        "zSQL_WORKER.SURNAME1, zSQL_WORKER.SURNAME2, zSQL_WORKER.APPOINTMENT, " &
        "zSQL_WORKER.SUBACCOUNT, zSQL_WORKER.EMAIL, zSQL_WORKER.BONUSVALUE, zSQL_WORKER.MANHOURVALUE,  " &
        "zSQL_WORKER.PHONE, zSQL_WORKER.ACTIVE  " &
        "FROM zSQL_WORKER  " &
        "WHERE ACTIVE IN ('YES'" & IIf(bExpInactData = True, ",'NO')", ")") & " " &
        "ORDER BY zSQL_WORKER.NAME1 "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet

            workbook = excelApp.Workbooks.Open(sFileDest)
            worksheet = workbook.Sheets("data")

            Dim nLine As Integer = 3

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                With worksheet
                    .Range("A" & nLine.ToString).Value = ds.Tables(0).Rows(i)("WORKERID").ToString
                    .Range("B" & nLine.ToString).Value = ds.Tables(0).Rows(i)("NAME1").ToString
                    .Range("C" & nLine.ToString).Value = ds.Tables(0).Rows(i)("NAME2").ToString
                    .Range("D" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SURNAME1").ToString
                    .Range("E" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SURNAME2").ToString
                    .Range("F" & nLine.ToString).Value = ds.Tables(0).Rows(i)("APPOINTMENT").ToString
                    .Range("G" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SUBACCOUNT").ToString
                    .Range("H" & nLine.ToString).Value = ds.Tables(0).Rows(i)("EMAIL").ToString
                    .Range("I" & nLine.ToString).Value = ds.Tables(0).Rows(i)("BONUSVALUE")
                    .Range("J" & nLine.ToString).Value = ds.Tables(0).Rows(i)("MANHOURVALUE")
                    .Range("K" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PHONE").ToString
                    .Range("L" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ACTIVE").ToString
                End With
                nLine = nLine + 1
            Next

            'fecha a pasta de trabalho e o Excel
            workbook.Close(True)
            excelApp.Quit()

            workbook = Nothing
            excelApp = Nothing
            worksheet = Nothing

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Public Sub InventoryItem(ByVal sFileDest As String, ByVal bExpInactData As Boolean)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT INVENTORYITEMID,ABBREVIATION,DESCRIPTION,INVENTORYCLASSID " &
        ",LASTCOST,AVERAGECOST,LISTPRICE,DEFAULTSITEID,STORAGEUNIT " &
        ",COSTOFGOODSACCOUNT,COSTOFGOODSSUBACCOUNT,SALESACCOUNT " &
        ",SALESACCOUNTAIU,SALESACCOUNTUBR,SALESACCOUNTUBRAIU " &
        ",SALESSUBACCOUNT,INVENTORYACCOUNT,INVENTORYSUBACCOUNT " &
        ",MINONHAND,MAXONHAND,ACTIVE,VENDOR,BRAND,VENDORID " &
        "FROM zSQL_INVENTORYITEM " &
        "WHERE ACTIVE IN ('YES'" & IIf(bExpInactData = True, ",'NO')", ")") & " " &
        "ORDER BY INVENTORYITEMID "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet

            workbook = excelApp.Workbooks.Open(sFileDest)
            worksheet = workbook.Sheets("data")

            Dim nLine As Integer = 3

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                With worksheet
                    .Range("A" & nLine.ToString).Value = ds.Tables(0).Rows(i)("INVENTORYITEMID").ToString
                    .Range("B" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ABBREVIATION").ToString
                    .Range("C" & nLine.ToString).Value = ds.Tables(0).Rows(i)("DESCRIPTION").ToString
                    .Range("D" & nLine.ToString).Value = ds.Tables(0).Rows(i)("INVENTORYCLASSID").ToString
                    .Range("E" & nLine.ToString).Value = ds.Tables(0).Rows(i)("VENDORID")

                    .Range("F" & nLine.ToString).Value = ds.Tables(0).Rows(i)("VENDOR")
                    .Range("G" & nLine.ToString).Value = ds.Tables(0).Rows(i)("BRAND")
                    .Range("H" & nLine.ToString).Value = ds.Tables(0).Rows(i)("LASTCOST")
                    .Range("I" & nLine.ToString).Value = ds.Tables(0).Rows(i)("AVERAGECOST")
                    .Range("J" & nLine.ToString).Value = ds.Tables(0).Rows(i)("LISTPRICE")
                    .Range("K" & nLine.ToString).Value = ds.Tables(0).Rows(i)("DEFAULTSITEID").ToString
                    .Range("L" & nLine.ToString).Value = ds.Tables(0).Rows(i)("STORAGEUNIT").ToString
                    .Range("M" & nLine.ToString).Value = ds.Tables(0).Rows(i)("COSTOFGOODSACCOUNT").ToString
                    .Range("N" & nLine.ToString).Value = ds.Tables(0).Rows(i)("COSTOFGOODSSUBACCOUNT").ToString
                    .Range("O" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SALESACCOUNT").ToString
                    .Range("P" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SALESACCOUNTAIU").ToString
                    .Range("Q" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SALESACCOUNTUBR").ToString
                    .Range("R" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SALESACCOUNTUBRAIU").ToString
                    .Range("S" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SALESSUBACCOUNT").ToString
                    .Range("T" & nLine.ToString).Value = ds.Tables(0).Rows(i)("INVENTORYACCOUNT").ToString
                    .Range("U" & nLine.ToString).Value = ds.Tables(0).Rows(i)("INVENTORYSUBACCOUNT").ToString
                    .Range("V" & nLine.ToString).Value = ds.Tables(0).Rows(i)("MINONHAND")
                    .Range("W" & nLine.ToString).Value = ds.Tables(0).Rows(i)("MAXONHAND")
                    .Range("X" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ACTIVE").ToString
                End With
                nLine = nLine + 1
            Next

            'fecha a pasta de trabalho e o Excel
            workbook.Close(True)
            excelApp.Quit()

            workbook = Nothing
            excelApp = Nothing
            worksheet = Nothing

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Public Sub Well(ByVal sFileDest As String, ByVal bExpInactData As Boolean)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT zSQL_WELL.WELLID, zSQL_WELL.NAME, zSQL_WELL.PETRFIELDID, " &
        "zSQL_WELL.COUNTRY, zSQL_WELL.STATE, zSQL_WELL.CITY, " &
        "zSQL_WELL.SITEID, zSQL_WELL.ACTIVE, zSQL_WELL.RIGID " &
        "FROM zSQL_WELL " &
        "WHERE ACTIVE IN ('YES'" & IIf(bExpInactData = True, ",'NO')", ")") & " " &
        "ORDER BY zSQL_WELL.WELLID "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet

            workbook = excelApp.Workbooks.Open(sFileDest)
            worksheet = workbook.Sheets("data")

            Dim nLine As Integer = 3

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                With worksheet
                    .Range("A" & nLine.ToString).Value = ds.Tables(0).Rows(i)("WELLID").ToString
                    .Range("B" & nLine.ToString).Value = ds.Tables(0).Rows(i)("NAME").ToString
                    .Range("C" & nLine.ToString).Value = ds.Tables(0).Rows(i)("PETRFIELDID").ToString
                    .Range("D" & nLine.ToString).Value = ds.Tables(0).Rows(i)("COUNTRY").ToString
                    .Range("E" & nLine.ToString).Value = ds.Tables(0).Rows(i)("STATE").ToString
                    .Range("F" & nLine.ToString).Value = ds.Tables(0).Rows(i)("CITY").ToString
                    .Range("G" & nLine.ToString).Value = ds.Tables(0).Rows(i)("SITEID").ToString
                    .Range("H" & nLine.ToString).Value = ds.Tables(0).Rows(i)("ACTIVE").ToString
                    .Range("I" & nLine.ToString).Value = ds.Tables(0).Rows(i)("RIGID").ToString
                End With
                nLine = nLine + 1
            Next

            'fecha a pasta de trabalho e o Excel
            workbook.Close(True)
            excelApp.Quit()

            workbook = Nothing
            excelApp = Nothing
            worksheet = Nothing

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

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
