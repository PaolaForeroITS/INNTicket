Imports System.Configuration
Imports System.IO
Imports Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel

Public Class clsRPTXlsx
    Implements IDisposable

    Dim sFilePathTmp As String = Directory.GetCurrentDirectory().Replace("\app", "\") & "\file\tmp"
    Dim util As New clsUtils
    Const xlValues = -4163 'required for .Find lookups

    Public Sub GenerateEcopetrolTicket(ByVal sTicketId As String, ByVal ReportParamId As Integer, byval IsService As Boolean)

        Dim sFileOrig As String
        Dim sNewName As String = sFilePathTmp & "\" & Replace(System.Guid.NewGuid.ToString, "-", "") & ".xlsx"

        sFileOrig = "C:\SESTicket\app\Reports\xlsx\ticketecopetrol.xlsx"

        If (System.IO.Directory.Exists(sFilePathTmp) = False) Then
            System.IO.Directory.CreateDirectory(sFilePathTmp)
        End If

        System.IO.File.Copy(sFileOrig, sNewName)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = False

        'REPORTHEADER_V
        sql = "SELECT TICKET.TICKETID, TICKET.DATESERVICE, TICKET.TIMEARRIVED, TICKET.TIMESTARTED, " &
              "TICKET.TIMECOMPLETED, CUSTOMER.CUSTOMERID, CUSTOMER.NAME AS CUSTOMERNAME, CUSTOMER.PHONE AS CUSTOMERPHONE, " &
              "CONTRACT.CONTRACTNUMBER, CONTRACT.CURRENCY AS CONTRACTCUR, CONTRACT.START_DATE AS CONTRACT_START_DATE, " &
              "CONTRACT.COMPLETION_DATE AS CONTRACT_END_DATE, WELL.NAME AS WELL_NAME, WELL.PETRFIELDID, PETRFIELD.PETRFIELDCODE, " &
              "PETRFIELD.DESCRIP AS PETRFIELDDESC, WELL.CITY+' / '+WELL.STATE AS WELL_LOCATION, TICKET.JOBDESCRIPTION, " &
              "WORKER.NAME1+' '+WORKER.SURNAME1 AS CONTRACTOR_NAME, WORKER.APPOINTMENT AS CONTRACTOR_POSITION, " &
              "WORKER.EMAIL AS CONTRACTOR_EMAIL, TICKET.CUSTCOMMENTS, TICKET.CONTRACTCOMMENTS, TICKET.EXCHANGERATE, " &
              "TICKET.RIGID AS RIG, WORKER.PHONE, CONTRACT.SERVICE_UTILITY, CONTRACT.SERVICE_UTILITY_PERC, CONTRACT.SERVICE_IVA_PERC, " &
              "CONTRACT.MATERIAL_IVA_PERC, CONTRACT.PORTIONUSD, CONTRACT.PORTIONCOP, TICKET.CUSTREPRES, TICKET.CUSTREPRESPOSITION, " &
              "TICKET.CUSTREPRESASSIST, TICKET.CUSTREPRESASSISTPOSITION, TICKET.INVOICENUMBER, CONTRACT.NAME AS CONTRACTNAME, " &
              "TICKET.SERVICETYPEGRPTEXT AS SERVICETYPE, CONTRACT.DESCRIPTION AS CONTRACTDESCRIPTION,TICKET.RIGID
              FROM (((((TICKET INNER JOIN CUSTOMER ON TICKET.CUSTOMERID = CUSTOMER.CUSTOMERID) " &
              "INNER JOIN CONTRACT ON TICKET.CONTRACTID = CONTRACT.CONTRACTID) LEFT JOIN WELL ON TICKET.WELLID = WELL.WELLID) " &
              "LEFT JOIN WORKER ON TICKET.CONTRACTORREPRESENTATIVE = WORKER.WORKERID) LEFT JOIN REPORTPARAM ON CONTRACT.REPORTPARAMID = REPORTPARAM.REPORTPARAMID) " &
              "LEFT JOIN PETRFIELD ON WELL.PETRFIELDID = PETRFIELD.PETRFIELDID " &
              "WHERE TICKET.TICKETID = '" & sTicketId & "'"

        bdconn.ExecuteSQL(sql, ds)

        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlWorkSheets As Excel.Sheets = Nothing
        Dim xlCells As Excel.Range = Nothing

        xlApp = New Excel.Application
        xlApp.DisplayAlerts = False
        xlWorkBooks = xlApp.Workbooks
        xlWorkBook = xlWorkBooks.Open(sNewName)
        xlApp.Visible = False
        xlWorkSheets = xlWorkBook.Sheets

        'Open an existing document.  
        xlWorkSheet = CType(xlWorkSheets(1), Excel.Worksheet)

        Dim sValue As Object
        Dim sText As String

        If ds.Tables(0).Rows.Count > 0 Then

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                '========
                ReplaceExcelText(xlApp, "!TICKETID", "'" & ds.Tables(0).Rows(i)("TICKETID"))

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTNUMBER").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTNUMBER", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTNAME").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTNAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTDESCRIPTION").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTDESCRIPTION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACT_START_DATE").ToString.Replace("  00:00:00", ""))
                ReplaceExcelText(xlApp, "!CONTRACT_START_DATE", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACT_END_DATE").ToString.Replace("  00:00:00", ""))
                ReplaceExcelText(xlApp, "!CONTRACT_END_DATE", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_NAME").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_NAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_POSITION").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_POSITION", sValue)

                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("PHONE").ToString)
                ReplaceExcelText(xlApp, "!PHONE", sValue.ToUpper)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_EMAIL").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_EMAIL", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("WELL_NAME").ToString)
                ReplaceExcelText(xlApp, "!WELL_NAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("WELL_LOCATION").ToString)
                ReplaceExcelText(xlApp, "!WELL_LOCATION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("PETRFIELDDESC").ToString)
                ReplaceExcelText(xlApp, "!PETRFIELDDESC", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("DATESERVICE").ToString)
                ReplaceExcelText(xlApp, "!DATESERVICE", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("SERVICETYPE").ToString)
                ReplaceExcelText(xlApp, "!SERVICETYPE", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("TIMESTARTED").ToString)
                ReplaceExcelText(xlApp, "!TIMESTARTED", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("TIMECOMPLETED").ToString)
                ReplaceExcelText(xlApp, "!TIMECOMPLETED", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("JOBDESCRIPTION").ToString)
                ReplaceExcelText(xlApp, "!JOBDESCRIPTION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRESPOSITION").ToString)
                ReplaceExcelText(xlApp, "!CUSTREPRESPOSITION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRES").ToString)
                ReplaceExcelText(xlApp, "!CUSTREPRES", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTCOMMENTS").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTCOMMENTS", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTCOMMENTS").ToString)
                ReplaceExcelText(xlApp, "!CUSTCOMMENTS", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("RIGID").ToString)
                ReplaceExcelText(xlApp, "!RIGID", sValue)

            Next

        End If
        ds.Dispose()
        ds = Nothing

        'LINES
        Dim nCount As Integer = 1
        Dim sField As String = ""
        Dim nRowNumber As Integer = 27 'Begin Row Lines

        ds = New DataSet
        sql = "SELECT *, REPORTLINE_V.* " &
              "FROM REPORTLINE_V " &
              "WHERE REPORTLINE_V.TICKETID = '" & sTicketId & "' "

        If IsService = True Then
            sql = sql & "AND ITEMTYPE = 'Service' "
        Else
            sql = sql & "AND ITEMTYPE = 'Material' "
        End If

        sql = sql & "ORDER BY REPORTLINE_V.TICKETID, REPORTLINE_V.TABGROUP, REPORTLINE_V.GROUPORDER, REPORTLINE_V.CUSTCODEITEM "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                'sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("DESCRIPTION"))
                'sField = "!ITEMDESCRIPTION" & nCount.ToString("00")
                'ReplaceExcelText(xlApp, sField, sValue)

                'sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("DESCRIPTION"))
                sText = util.TrataDBNull(ds.Tables(0).Rows(i)("DESCRIPTION").ToString)
                sField = "!ITEMDESCRIPTION" & nCount.ToString("00")
                ReplaceExcelTextLarge(xlApp, sField, sText)


                If (ds.Tables(0).Rows(i)("HEADER") = 0) Then

                    sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTCODEITEM"))
                    sField = "!CUSTCODEITEM" & nCount.ToString("00")
                    ReplaceExcelText(xlApp, sField, sValue)

                    sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("UNIT_SALE"))
                    sField = "!ITEMUNIT" & nCount.ToString("00")
                    ReplaceExcelText(xlApp, sField, sValue)

                    sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("ITEMQTY"))
                    sField = "!ITEMQTY" & nCount.ToString("00")
                    ReplaceExcelText(xlApp, sField, sValue)

                Else
                    ChangeFillColor(xlApp, "B" & nRowNumber, "K" & nRowNumber, Color.LightGray)
                    SetBold(xlApp, "B" & nRowNumber, "K" & nRowNumber, True)
                End If

                nCount = nCount + 1
                nRowNumber = nRowNumber + 1

            Next
        End If


        For i As Integer = 1 To 30
            sValue = ""

            sField = "!CUSTCODEITEM" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            'sField = "!ITEMDESCRIPTION" & i.ToString("00")
            'ReplaceExcelText(xlApp, sField, sValue.ToUpper)


            sText = CStr(sValue)
            sField = "!ITEMDESCRIPTION" & nCount.ToString("00")
            ReplaceExcelTextLarge(xlApp, sField, sText)

            sField = "!ITEMUNIT" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!ITEMQTY" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)
        Next
        ReplaceExcelTextLargeCleanup(xlApp)

        ds.Dispose()
        ds = Nothing

        'COMPANY
        ds = New DataSet
        sql = "SELECT * " &
              "FROM REPORTPARAM " &
              "WHERE REPORTPARAMID = " & ReportParamId.ToString() & " "
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                If (ds.Tables(0).Rows(i)("DESCRIP") = "ITS - NIT: 900.162.414-5") Then
                    xlWorkSheet.Shapes(4).delete()
                Else
                    xlWorkSheet.Shapes(3).delete()
                End If

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("HEAD2"))
                sField = "!SESCOMPANY"
                ReplaceExcelText(xlApp, sField, sValue)

            Next
        End If
        ds.Dispose()
        ds = Nothing

        xlWorkBook.Save()
        xlWorkBook.Close()
        xlApp.UserControl = True
        xlApp.Quit()
        ' ↓ bug fix for SR992870 ↓

        If xlCells IsNot Nothing Then
            ReleaseComObject(xlCells)
        End If

        ' ↑ bug fix for SR992870 ↑
        ReleaseComObject(xlWorkSheets)
        ReleaseComObject(xlWorkSheet)
        ReleaseComObject(xlWorkBook)
        ReleaseComObject(xlWorkBooks)
        ReleaseComObject(xlApp)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Process.Start(sNewName)


    End Sub

    Public Sub ReleaseComObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Public Sub ReplaceExcelText(ByRef xlApp As Excel.Application, FindText As String, ReplaceText As Object)

        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing

        Dim xlsRange As Excel.Range = xlApp.Range("A1", "P500")
        xlsRange.Replace(FindText, ReplaceText)

    End Sub

    Public Sub ReplaceExcelTextLarge(ByRef xlApp As Excel.Application, FindText As String, ReplaceText As String)

        Dim ReplaceCell As Excel.Range


        With xlApp.Range("A1", "P500")
            ReplaceCell = .Find(FindText, LookIn:=xlValues)
            If ReplaceCell IsNot Nothing Then
                ReplaceCell.Value = ReplaceText
            End If
        End With


    End Sub

    Public Sub ReplaceExcelTextLargeCleanup(ByRef xlApp As Excel.Application)
        ' remove remaining text that wasn't matched in ReplaceExcelTextLarge
        Dim ReplaceCell As Excel.Range


        With xlApp.Range("A1", "P500")
            ReplaceCell = .Find("!ITEMDESCRIPTION", LookIn:=xlValues)
            If ReplaceCell IsNot Nothing Then
                Do
                    ReplaceCell.Value = Nothing
                    ReplaceCell = .FindNext(ReplaceCell)
                Loop While ReplaceCell IsNot Nothing
            End If
        End With

    End Sub

    Public Sub ChangeFillColor(ByRef xlApp As Excel.Application, RangeBegin As String, RangeEnd As String, NewColor As Color)

        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing

        Dim xlsRange As Excel.Range = xlApp.Range(RangeBegin, RangeEnd)
        xlsRange.Interior.Color = NewColor

    End Sub

    Public Sub SetBold(ByRef xlApp As Excel.Application, RangeBegin As String, RangeEnd As String, IsBold As Boolean)

        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing

        Dim xlsRange As Excel.Range = xlApp.Range(RangeBegin, RangeEnd)
        xlsRange.Font.Bold = IsBold


    End Sub

    Public Sub GenerateEcopetrolServEval(ByVal sTicketId As String, ByVal ServiceDate As Date, ByVal ServiceDesc As String, ByVal ReportParamId As Integer)

        Dim sFileOrig As String
        Dim sNewName As String = sFilePathTmp & "\" & Replace(System.Guid.NewGuid.ToString, "-", "") & ".xlsx"
        Dim cls As New clsRPTDocx

        sFileOrig = "C: \SESTicket\app\Reports\xlsx\servevalecopetrol.xlsx"

        If (System.IO.Directory.Exists(sFilePathTmp) = False) Then
            System.IO.Directory.CreateDirectory(sFilePathTmp)
        End If

        System.IO.File.Copy(sFileOrig, sNewName)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = False

        'REPORTHEADER_V
        sql = "SELECT TICKET.TICKETID, TICKET.DATESERVICE, TICKET.TIMEARRIVED, TICKET.TIMESTARTED, " &
              "TICKET.TIMECOMPLETED, CUSTOMER.CUSTOMERID, CUSTOMER.NAME AS CUSTOMERNAME, CUSTOMER.PHONE AS CUSTOMERPHONE, " &
              "CONTRACT.CONTRACTNUMBER, CONTRACT.CURRENCY AS CONTRACTCUR, CONTRACT.START_DATE AS CONTRACT_START_DATE, " &
              "CONTRACT.COMPLETION_DATE AS CONTRACT_END_DATE, WELL.NAME AS WELL_NAME, WELL.PETRFIELDID, PETRFIELD.PETRFIELDCODE, " &
              "PETRFIELD.DESCRIP AS PETRFIELDDESC, WELL.CITY+' / '+WELL.STATE AS WELL_LOCATION, TICKET.JOBDESCRIPTION, " &
              "WORKER.NAME1+' '+WORKER.SURNAME1 AS CONTRACTOR_NAME, WORKER.APPOINTMENT AS CONTRACTOR_POSITION, " &
              "WORKER.EMAIL AS CONTRACTOR_EMAIL, TICKET.CUSTCOMMENTS, TICKET.CONTRACTCOMMENTS, TICKET.EXCHANGERATE, " &
              "TICKET.RIGID AS RIG, WORKER.PHONE, CONTRACT.SERVICE_UTILITY, CONTRACT.SERVICE_UTILITY_PERC, CONTRACT.SERVICE_IVA_PERC, " &
              "CONTRACT.MATERIAL_IVA_PERC, CONTRACT.PORTIONUSD, CONTRACT.PORTIONCOP, TICKET.CUSTREPRES, TICKET.CUSTREPRESPOSITION, " &
              "TICKET.CUSTREPRESASSIST, TICKET.CUSTREPRESASSISTPOSITION, TICKET.INVOICENUMBER, CONTRACT.NAME AS CONTRACTNAME, " &
              "TICKET.SERVICETYPEGRPTEXT AS SERVICETYPE, CONTRACT.DESCRIPTION AS CONTRACTDESCRIPTION 
              FROM (((((TICKET INNER JOIN CUSTOMER ON TICKET.CUSTOMERID = CUSTOMER.CUSTOMERID) " &
              "INNER JOIN CONTRACT ON TICKET.CONTRACTID = CONTRACT.CONTRACTID) LEFT JOIN WELL ON TICKET.WELLID = WELL.WELLID) " &
              "LEFT JOIN WORKER ON TICKET.CONTRACTORREPRESENTATIVE = WORKER.WORKERID) LEFT JOIN REPORTPARAM ON CONTRACT.REPORTPARAMID = REPORTPARAM.REPORTPARAMID) " &
              "LEFT JOIN PETRFIELD ON WELL.PETRFIELDID = PETRFIELD.PETRFIELDID " &
              "WHERE TICKET.TICKETID = '" & sTicketId & "'"

        bdconn.ExecuteSQL(sql, ds)

        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlWorkSheets As Excel.Sheets = Nothing
        Dim xlCells As Excel.Range = Nothing

        xlApp = New Excel.Application
        xlApp.DisplayAlerts = False
        xlWorkBooks = xlApp.Workbooks
        xlWorkBook = xlWorkBooks.Open(sNewName)
        xlApp.Visible = False
        xlWorkSheets = xlWorkBook.Sheets

        'Open an existing document.  
        xlWorkSheet = CType(xlWorkSheets(1), Excel.Worksheet)

        Dim sValue As Object

        If ds.Tables(0).Rows.Count > 0 Then

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                '========
                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_NAME").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_NAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("WELL_NAME").ToString)
                ReplaceExcelText(xlApp, "!WELL_NAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("RIG").ToString)
                ReplaceExcelText(xlApp, "!RIG", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRES").ToString)
                ReplaceExcelText(xlApp, "!CUSTREPRES", sValue)


                sValue = util.TrataDBNull(cls.DateExten(ServiceDate))
                ReplaceExcelText(xlApp, "!DATESERVICE", sValue)

            Next

        End If
        ds.Dispose()
        ds = Nothing

        Dim sField As String = ""
        'COMPANY
        ds = New DataSet
        sql = "SELECT * " &
              "FROM REPORTPARAM " &
              "WHERE REPORTPARAMID = " & ReportParamId.ToString() & " "
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("HEAD1"))
                sField = "!SESCOMPANY"
                ReplaceExcelText(xlApp, sField, sValue)

            Next
        End If
        ds.Dispose()
        ds = Nothing


        xlWorkBook.Save()
        xlWorkBook.Close()
        xlApp.UserControl = True
        xlApp.Quit()
        ReleaseComObject(xlCells)
        ReleaseComObject(xlWorkSheets)
        ReleaseComObject(xlWorkSheet)
        ReleaseComObject(xlWorkBook)
        ReleaseComObject(xlWorkBooks)
        ReleaseComObject(xlApp)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Process.Start(sNewName)


    End Sub


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
End Class
