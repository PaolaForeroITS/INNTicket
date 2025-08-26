
Public Class clsDataImp
    Implements IDisposable

    Dim util As New clsUtils
    Public sUsername As String

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

    Public Function ContractPriceList(ByVal sFile As String, ByVal sContractId As String) As Boolean

        Try

            'Copying the file to WorkArea
            Dim sFileDest As String = "C:\SESTicket\file\tmp\CONTRACTPRICELIST.xlsx"
            System.IO.File.Copy(sFile, sFileDest, True)

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM IMP_CONTRACTPRICELIST"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO IMP_CONTRACTPRICELIST ( " &
            " [CONTRACTPRICELISTID],[TABGROUP],[GROUPORDER] " &
            ",[CUSTCODEITEM],[DESCRIPTION] " &
            ",[SALES_PRICE],[UNIT_SALE] " &
            ",[INVENTORYCLASSID],[CONTRACTED_QTY] " &
            ",[ISHEADER],[EXIBITONREPORT] " &
            ",[SHOWCUSTITEMREPORT],[ACTIVE],[PRICEBASE],[PRICEUTILITY],[PERMITUPDATEDESCRIP],[PERMITUPDATEPRICEUNIT],[PERMITNEGATIVE]) " &
            "SELECT  " &
            " zXLS_CONTRACTPRICELIST.[CONTRACTPRICELISTID*] " &
            ",zXLS_CONTRACTPRICELIST.[TABGROUP*] " &
            ",zXLS_CONTRACTPRICELIST.[GROUPORDER*] " &
            ",zXLS_CONTRACTPRICELIST.[CUSTCODEITEM*] " &
            ",zXLS_CONTRACTPRICELIST.DESCRIPTION " &
            ",zXLS_CONTRACTPRICELIST.[SALES_PRICE*] " &
            ",zXLS_CONTRACTPRICELIST.UNIT_SALE " &
            ",zXLS_CONTRACTPRICELIST.[INVENTORYCLASSID*] " &
            ",zXLS_CONTRACTPRICELIST.[CONTRACTED_QTY*] " &
            ",zXLS_CONTRACTPRICELIST.[ISHEADER*] " &
            ",zXLS_CONTRACTPRICELIST.[EXIBITONREPORT*] " &
            ",zXLS_CONTRACTPRICELIST.[SHOWCUSTITEMREPORT*] " &
            ",zXLS_CONTRACTPRICELIST.[ACTIVE*] " &
            ",zXLS_CONTRACTPRICELIST.[PRICEBASE] " &
            ",zXLS_CONTRACTPRICELIST.[PRICEUTILITY] " &
            ",zXLS_CONTRACTPRICELIST.[PERMITUPDATEDESCRIP*] " &
            ",zXLS_CONTRACTPRICELIST.[PERMITUPDATEPRICEUNIT*] " &
            ",zXLS_CONTRACTPRICELIST.[PERMITNEGATIVE*] " &
            "FROM zXLS_CONTRACTPRICELIST " &
            "WHERE " &
            "zXLS_CONTRACTPRICELIST.[INVENTORYCLASSID*] <> 'AAAAAA' " &
            "AND zXLS_CONTRACTPRICELIST.[ACTIVE*] <> 'AAA' "

            bdconn.ExecuteNonSQL(sql)

            Dim msg As String

            'Checking CONTRACTPRICELIST exists on the Database
            msg = "Error: CONTRACTPRICELISTID is not exists or not a number"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = '" & msg & "' + '#' + chr(10) " &
                  "WHERE NOT EXISTS (SELECT 1 " &
                  "FROM CONTRACTPRICELIST " &
                  "WHERE IMP_CONTRACTPRICELIST.CONTRACTPRICELISTID = cstr(CONTRACTPRICELIST.CONTRACTPRICELISTID) " &
                  "AND CONTRACTPRICELIST.CONTRACTID=" & sContractId & ") " &
                  "AND IMP_CONTRACTPRICELIST.CONTRACTPRICELISTID <> '' AND IMP_CONTRACTPRICELIST.CONTRACTPRICELISTID IS NOT NULL "
            bdconn.ExecuteNonSQL(sql)

            'Checking TABGROUP
            msg = "Error: TABGROUP is Empty or length greater than 50 chars"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TABGROUP IS NULL) OR  (LTRIM(RTRIM(TABGROUP)) = '') OR (LEN(TABGROUP) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking GROUPORDER
            msg = "Error: GROUPORDER is Empty or not a number"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(GROUPORDER) = FALSE) OR (GROUPORDER IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking CUSTCODEITEM
            msg = "Error: CUSTCODEITEM is Empty or length greater than 30 chars"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (CUSTCODEITEM IS NULL) OR  (LTRIM(RTRIM(CUSTCODEITEM)) = '') OR (LEN(CUSTCODEITEM) > 30) "
            bdconn.ExecuteNonSQL(sql)

            'Checking DESCRIPTION
            msg = "Error: DESCRIPTION length is greater than 900 chars"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(DESCRIPTION) > 900) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SALES_PRICE
            msg = "Error: SALES_PRICE is Empty or not a number"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(SALES_PRICE) = FALSE) OR (SALES_PRICE IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking UNIT_SALE
            msg = "Error: UNIT_SALE is greater than 40 chars"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(UNIT_SALE) > 40) "
            bdconn.ExecuteNonSQL(sql)

            'Checking INVENTORYCLASSID
            msg = "Error: INVENTORYCLASSID is Empty or not exists"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                "WHERE NOT EXISTS (SELECT 1 FROM INVENTORYCLASS   " &
                "WHERE IMP_CONTRACTPRICELIST.INVENTORYCLASSID = INVENTORYCLASS.INVENTORYCLASSID) "
            bdconn.ExecuteNonSQL(sql)

            'Checking CONTRACTED_QTY
            msg = "Error: CONTRACTED_QTY is Empty or not a number or zero low"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(CONTRACTED_QTY) = FALSE) OR (CONTRACTED_QTY IS NULL) OR (CONTRACTED_QTY < 0)"
            bdconn.ExecuteNonSQL(sql)

            'Checking ISHEADER
            msg = "Error: ISHEADER is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(ISHEADER) NOT IN ('YES','NO')) OR (ISHEADER IS NULL) OR (TRIM(ISHEADER) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking EXIBITONREPORT
            msg = "Error: EXIBITONREPORT is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(EXIBITONREPORT) NOT IN ('YES','NO')) OR (EXIBITONREPORT IS NULL) OR (TRIM(EXIBITONREPORT) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking SHOWCUSTITEMREPORT
            msg = "Error: SHOWCUSTITEMREPORT is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(SHOWCUSTITEMREPORT) NOT IN ('YES','NO')) OR (SHOWCUSTITEMREPORT IS NULL) OR (TRIM(SHOWCUSTITEMREPORT) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking ACTIVE
            msg = "Error: ACTIVE is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(ACTIVE) NOT IN ('YES','NO')) OR (ACTIVE IS NULL) OR (TRIM(ACTIVE) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking PRICEBASE
            msg = "Error: PRICEBASE is not a number"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(PRICEBASE) = FALSE) "
            bdconn.ExecuteNonSQL(sql)

            'Checking PRICEUTILITY
            msg = "Error: PRICEUTILITY is not a number"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(PRICEUTILITY) = FALSE) "
            bdconn.ExecuteNonSQL(sql)

            'Checking PERMITUPDATEDESCRIP
            msg = "Error: PERMITUPDATEDESCRIP is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(PERMITUPDATEDESCRIP) NOT IN ('YES','NO')) OR (PERMITUPDATEDESCRIP IS NULL) OR (TRIM(PERMITUPDATEDESCRIP) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking PERMITUPDATEPRICEUNIT
            msg = "Error: PERMITUPDATEPRICEUNIT is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(PERMITUPDATEPRICEUNIT) NOT IN ('YES','NO')) OR (PERMITUPDATEPRICEUNIT IS NULL) OR (TRIM(PERMITUPDATEPRICEUNIT) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking PERMITNEGATIVE
            msg = "Error: PERMITNEGATIVE is Empty or invalid value"
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(PERMITNEGATIVE) NOT IN ('YES','NO')) OR (PERMITNEGATIVE IS NULL) OR (TRIM(PERMITNEGATIVE) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking if some PERMITNEGATIVE=NO and PRICEUNIT < 0
            msg = "Error: PERMITNEGATIVE=NO and SALES_PRICE IS NEGATIVE "
            sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE PERMITNEGATIVE = 'NO' AND (SALES_PRICE IS NOT NULL AND SALES_PRICE < 0) "
            bdconn.ExecuteNonSQL(sql)

            Dim ds As New DataSet

            sql = "SELECT COUNT(*) AS QDE FROM IMP_CONTRACTPRICELIST WHERE IMPSTATUS LIKE 'Error%'"
            bdconn.ExecuteSQL(sql, ds)

            Dim nErro As Integer = 0

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    nErro = ds.Tables(0).Rows(i)("QDE")
                Next
            End If
            ds.Dispose()
            ds = Nothing

            If nErro > 0 Then
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                Return False
                Exit Function
            End If

            ds = New DataSet

            sql = "SELECT * FROM IMP_CONTRACTPRICELIST ORDER BY ID"
            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sDesc As String = ""
                Dim bdconnSQL As New clsBancoDadosSQL

                bdconnSQL.OpenConnection()

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sDesc = ""

                    Try
                        If IsDBNull(ds.Tables(0).Rows(i)("CONTRACTPRICELISTID")) = False Then

                            sql = "UPDATE CONTRACTPRICELIST SET " &
                            " [CUSTCODEITEM]       = '" & ds.Tables(0).Rows(i)("CUSTCODEITEM") & "' " &
                            ",[DESCRIPTION]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DESCRIPTION"), "s") & " " &
                            ",[SALES_PRICE]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALES_PRICE"), "n") & " " &
                            ",[UNIT_SALE]          = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("UNIT_SALE"), "s") & " " &
                            ",[INVENTORYCLASSID]   = '" & ds.Tables(0).Rows(i)("INVENTORYCLASSID") & "' " &
                            ",[CONTRACTED_QTY]     = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("CONTRACTED_QTY"), "n") & " " &
                            ",[ACTIVE]             = '" & Trim(ds.Tables(0).Rows(i)("ACTIVE").ToString.ToUpper) & "' " &
                            ",[ISHEADER]           = '" & Trim(ds.Tables(0).Rows(i)("ISHEADER").ToString.ToUpper) & "' " &
                            ",[EXIBITONREPORT]     = '" & Trim(ds.Tables(0).Rows(i)("EXIBITONREPORT").ToString.ToUpper) & "' " &
                            ",[TABGROUP]           = '" & ds.Tables(0).Rows(i)("TABGROUP") & "' " &
                            ",[SHOWCUSTITEMREPORT] = '" & ds.Tables(0).Rows(i)("SHOWCUSTITEMREPORT").ToString.ToUpper & "' " &
                            ",[UPDATEDDATETIME] = getdate() " &
                            ",[UPDATEDUSER] = " & util.SQLConvStrNull(sUsername.ToLower, "s") & " " &
                            ",[GROUPORDER]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("GROUPORDER"), "n") & " " &
                            ",[PRICEBASE]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PRICEBASE"), "n") & " " &
                            ",[PRICEUTILITY]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PRICEUTILITY"), "n") & " " &
                            ",[PERMITUPDATEDESCRIP]    = '" & Trim(ds.Tables(0).Rows(i)("PERMITUPDATEDESCRIP").ToString.ToUpper) & "' " &
                            ",[PERMITUPDATEPRICEUNIT]  = '" & Trim(ds.Tables(0).Rows(i)("PERMITUPDATEPRICEUNIT").ToString.ToUpper) & "' " &
                            ",[PERMITNEGATIVE]         = '" & Trim(ds.Tables(0).Rows(i)("PERMITNEGATIVE").ToString.ToUpper) & "' " &
                            "WHERE CONTRACTPRICELISTID = " & ds.Tables(0).Rows(i)("CONTRACTPRICELISTID") & " " &
                            "AND CONTRACTID = " & sContractId & " "

                            sDesc = "OK - Updated"


                        Else

                            sql = "INSERT INTO [CONTRACTPRICELIST]  " &
                                "([CONTRACTID],[CUSTCODEITEM],[DESCRIPTION] " &
                                ",[SALES_PRICE],[UNIT_SALE],[INVENTORYCLASSID] " &
                                ",[CONTRACTED_QTY],[ACTIVE],[ISHEADER] " &
                                ",[EXIBITONREPORT],[TABGROUP],[SHOWCUSTITEMREPORT],CREATEDDATETIME,[CREATEDUSER],GROUPORDER,PRICEBASE,PRICEUTILITY," &
                                "PERMITUPDATEDESCRIP, PERMITUPDATEPRICEUNIT, PERMITNEGATIVE) VALUES (" &
                                sContractId &
                                ",'" & ds.Tables(0).Rows(i)("CUSTCODEITEM") & "' " &
                                ", " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DESCRIPTION"), "s") & " " &
                                ", " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALES_PRICE"), "n") & " " &
                                ", " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("UNIT_SALE"), "s") & " " &
                                ",'" & ds.Tables(0).Rows(i)("INVENTORYCLASSID") & "' " &
                                ", " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("CONTRACTED_QTY"), "n") & " " &
                                ",'" & Trim(ds.Tables(0).Rows(i)("ACTIVE").ToString.ToUpper) & "' " &
                                ",'" & Trim(ds.Tables(0).Rows(i)("ISHEADER").ToString.ToUpper) & "' " &
                                ",'" & Trim(ds.Tables(0).Rows(i)("EXIBITONREPORT").ToString.ToUpper) & "' " &
                                ",'" & ds.Tables(0).Rows(i)("TABGROUP") & "' " &
                                ",'" & ds.Tables(0).Rows(i)("SHOWCUSTITEMREPORT").ToString.ToUpper & "',getdate(),'" & sUsername.ToLower & "'" &
                                "," & util.SQLConvStrNull(ds.Tables(0).Rows(i)("GROUPORDER"), "n") & " " &
                                "," & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PRICEBASE"), "n") & " " &
                                "," & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PRICEUTILITY"), "n") & " " &
                                ",'" & Trim(ds.Tables(0).Rows(i)("PERMITUPDATEDESCRIP").ToString.ToUpper) & "' " &
                                ",'" & Trim(ds.Tables(0).Rows(i)("PERMITUPDATEPRICEUNIT").ToString.ToUpper) & "' " &
                                ",'" & Trim(ds.Tables(0).Rows(i)("PERMITNEGATIVE").ToString.ToUpper) & "')"

                            sDesc = "OK - Inserted"

                        End If

                        bdconnSQL.ExecuteNonSQL(sql)


                    Catch ex As Exception
                        sDesc = "Erro: " & ex.Message
                    End Try

                    sql = "UPDATE IMP_CONTRACTPRICELIST SET IMPSTATUS = " & util.SQLConvStrNull(sDesc, "s") & " " &
                          "WHERE ID = " & ds.Tables(0).Rows(i)("ID")
                    bdconn.ExecuteNonSQL(sql)

                Next

                sql = "UPDATE CONTRACTPRICELIST SET PRICEUNITDECIMAL = [dbo].[fnGetNumberDecimal] (SALES_PRICE) "
                bdconnSQL.ExecuteNonSQL(sql)


                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing

            End If
            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("CONTRACTPRICELIST")
            syn.Dispose()
            syn = Nothing

            Dim frm As New frmSyncBaseData
            frmSyncBaseData.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            Return True

        Catch ex As Exception
            MsgBox("Some problems had ocurred during the import process: " + ex.Message, vbInformation)
            Return False
        End Try

    End Function

    Public Function Equipment(ByVal sFile As String) As Boolean

        Try

            'Copying the file to WorkArea
            Dim sFileDest As String = "C:\SESTicket\file\tmp\EQUIPMENT.xlsx"
            System.IO.File.Copy(sFile, sFileDest, True)

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM IMP_EQUIPMENT"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO IMP_EQUIPMENT ( EQUIPMENTID, DESCRIPTION, MODEL, SERIAL, TAG, ACTIVE, UNIT ) " &
            "SELECT zXLS_EQUIPMENT.[EQUIPMENTID*], zXLS_EQUIPMENT.[DESCRIPTION*], zXLS_EQUIPMENT.MODEL," &
            "zXLS_EQUIPMENT.SERIAL, zXLS_EQUIPMENT.TAG, zXLS_EQUIPMENT.[ACTIVE*], zXLS_EQUIPMENT.[UNIT] " &
            "FROM zXLS_EQUIPMENT " &
            "WHERE " &
            "zXLS_EQUIPMENT.[EQUIPMENTID*] <> 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA' "
            bdconn.ExecuteNonSQL(sql)

            Dim msg As String

            'Checking EQUIPMENTID
            msg = "Error: EQUIPMENTID is Empty or length greater than 60 chars"
            sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (EQUIPMENTID IS NULL) OR  (LTRIM(RTRIM(EQUIPMENTID)) = '') OR (LEN(TRIM(EQUIPMENTID)) > 60) "
            bdconn.ExecuteNonSQL(sql)

            'Checking DESCRIPTION
            msg = "Error: DESCRIPTION is Empty or length greater than 200 chars"
            sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (DESCRIPTION IS NULL) OR  (LTRIM(RTRIM(DESCRIPTION)) = '') OR (LEN(TRIM(DESCRIPTION)) > 200) "
            bdconn.ExecuteNonSQL(sql)

            'Checking MODEL
            msg = "Error: MODEL length greater than 60 chars"
            sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(MODEL)) > 60) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SERIAL
            msg = "Error: SERIAL length greater than 60 chars"
            sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SERIAL)) > 60) "
            bdconn.ExecuteNonSQL(sql)

            'Checking TAG
            msg = "Error: TAG length greater than 60 chars"
            sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(TAG)) > 60) "
            bdconn.ExecuteNonSQL(sql)

            'Checking ACTIVE
            msg = "Error: ACTIVE is Empty or invalid value"
            sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(ACTIVE) NOT IN ('YES','NO')) OR (ACTIVE IS NULL) OR (TRIM(TRIM(ACTIVE)) = '')"
            bdconn.ExecuteNonSQL(sql)

            Dim ds As New DataSet

            sql = "SELECT COUNT(*) AS QDE FROM IMP_EQUIPMENT WHERE IMPSTATUS LIKE 'Error%'"
            bdconn.ExecuteSQL(sql, ds)

            Dim nErro As Integer = 0

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    nErro = ds.Tables(0).Rows(i)("QDE")
                Next
            End If
            ds.Dispose()

            If nErro > 0 Then
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                Return False
                Exit Function
            End If

            ds = New DataSet

            sql = "SELECT IMP_EQUIPMENT.* " &
                ",(SELECT COUNT(*) FROM EQUIPMENT " &
                "WHERE TRIM(IMP_EQUIPMENT.EQUIPMENTID) = EQUIPMENT.EQUIPMENTID ) AS OPE " &
                "FROM IMP_EQUIPMENT " &
                "ORDER BY IMP_EQUIPMENT.ID "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sDesc As String = ""
                Dim bdconnSQL As New clsBancoDadosSQL

                bdconnSQL.OpenConnection()

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sDesc = ""

                    Try
                        If ds.Tables(0).Rows(i)("OPE") = 0 Then

                            sql = "INSERT INTO [EQUIPMENT] " &
                            "([EQUIPMENTID],[DESCRIPTION] ,[MODEL] " &
                            ",[SERIAL],[TAG],[ACTIVE],[UNIT]) VALUES ("

                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("EQUIPMENTID").ToString.Trim) & "',"
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DESCRIPTION").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MODEL").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SERIAL").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("TAG").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("UNIT").ToString.Trim, "s") & ")"

                            sDesc = "OK - Inserted"

                        Else

                            sql = "UPDATE [EQUIPMENT]  SET " &
                                " [DESCRIPTION] = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DESCRIPTION").ToString.Trim, "s") & " " &
                                ",[MODEL]       = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MODEL").ToString.Trim, "s") & " " &
                                ",[SERIAL]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SERIAL").ToString.Trim, "s") & " " &
                                ",[TAG]         = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("TAG").ToString.Trim, "s") & " " &
                                ",[ACTIVE]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim.ToUpper, "s") & " " &
                                ",[UNIT]         = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("UNIT").ToString.Trim, "s") & " " &
                                "WHERE [EQUIPMENTID] = '" & ds.Tables(0).Rows(i)("EQUIPMENTID").ToString.Trim & "' "

                            sDesc = "OK - Updated"

                        End If

                        bdconnSQL.ExecuteNonSQL(sql)


                    Catch ex As Exception
                        sDesc = "Erro: " & ex.Message
                    End Try

                    sql = "UPDATE IMP_EQUIPMENT SET IMPSTATUS = '" & sDesc & "' " &
                          "WHERE ID = " & ds.Tables(0).Rows(i)("ID")
                    bdconn.ExecuteNonSQL(sql)

                Next

                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing

            End If
            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("EQUIPMENT")
            syn.Dispose()
            syn = Nothing

            Dim frm As New frmSyncBaseData
            frmSyncBaseData.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            Return True

        Catch ex As Exception
            MsgBox("Some problems had ocurred during the import process: " + ex.Message, vbInformation)
            Return False
        End Try

    End Function

    Public Function Worker(ByVal sFile As String) As Boolean

        Try

            'Copying the file to WorkArea
            Dim sFileDest As String = "C:\SESTicket\file\tmp\WORKER.xlsx"
            System.IO.File.Copy(sFile, sFileDest, True)

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM IMP_WORKER"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO IMP_WORKER ( WORKERID, NAME1, NAME2, SURNAME1, SURNAME2, " &
            "APPOINTMENT, SUBACCOUNT, EMAIL, BONUSVALUE, MANHOURVALUE, PHONE, ACTIVE ) " &
            "SELECT zXLS_WORKER.[WORKERID*], zXLS_WORKER.[NAME1*], zXLS_WORKER.NAME2, " &
            "zXLS_WORKER.[SURNAME1*], zXLS_WORKER.SURNAME2, zXLS_WORKER.[APPOINTMENT*], " &
            "zXLS_WORKER.[SUBACCOUNT*], zXLS_WORKER.EMAIL, zXLS_WORKER.[BONUSVALUE*], " &
            "zXLS_WORKER.[MANHOURVALUE*], zXLS_WORKER.PHONE, zXLS_WORKER.[ACTIVE*] " &
            "FROM zXLS_WORKER " &
            "WHERE " &
            "zXLS_WORKER.[WORKERID*] <> 'AAAAAAAAAAAA' "
            bdconn.ExecuteNonSQL(sql)

            Dim msg As String

            'Checking WORKERID
            msg = "Error: WORKERID is Empty or length greater than 12 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (WORKERID IS NULL) OR  (LTRIM(RTRIM(WORKERID)) = '') OR (LEN(TRIM(WORKERID)) > 12) "
            bdconn.ExecuteNonSQL(sql)

            'Checking NAME1
            msg = "Error: NAME1 is Empty or length greater than 25 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (NAME1 IS NULL) OR  (LTRIM(RTRIM(NAME1)) = '') OR (LEN(TRIM(NAME1)) > 25) "
            bdconn.ExecuteNonSQL(sql)

            'Checking NAME2
            msg = "Error: NAME2 length greater than 25 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(NAME2)) > 25) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SURNAME1
            msg = "Error: SURNAME1 is Empty or length greater than 25 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (SURNAME1 IS NULL) OR  (LTRIM(RTRIM(SURNAME1)) = '') OR (LEN(TRIM(SURNAME1)) > 25) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SURNAME2
            msg = "Error: SURNAME2 length greater than 25 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SURNAME2)) > 25) "
            bdconn.ExecuteNonSQL(sql)

            'Checking APPOINTMENT
            msg = "Error: APPOINTMENT is Empty or length greater than 80 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (APPOINTMENT IS NULL) OR  (LTRIM(RTRIM(APPOINTMENT)) = '') OR (LEN(TRIM(APPOINTMENT)) > 80) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SUBACCOUNT
            msg = "Error: SUBACCOUNT is Empty or length greater than 30 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (SUBACCOUNT IS NULL) OR  (LTRIM(RTRIM(SUBACCOUNT)) = '') OR (LEN(TRIM(SUBACCOUNT)) > 30) "
            bdconn.ExecuteNonSQL(sql)

            'Checking EMAIL
            msg = "Error: SURNAME2 length greater than 150 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SURNAME2)) > 150) "
            bdconn.ExecuteNonSQL(sql)

            'Checking BONUSVALUE
            msg = "Error: BONUSVALUE is Empty or not a number"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(BONUSVALUE) = FALSE) OR (BONUSVALUE IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking MANHOURVALUE
            msg = "Error: MANHOURVALUE is Empty or not a number"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(MANHOURVALUE) = FALSE) OR (MANHOURVALUE IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking PHONE
            msg = "Error: SURNAME2 length greater than 100 chars"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(PHONE)) > 100) "
            bdconn.ExecuteNonSQL(sql)

            'Checking ACTIVE
            msg = "Error: ACTIVE is Empty or invalid value"
            sql = "UPDATE IMP_WORKER SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(ACTIVE) NOT IN ('YES','NO')) OR (ACTIVE IS NULL) OR (TRIM(TRIM(ACTIVE)) = '')"
            bdconn.ExecuteNonSQL(sql)

            Dim ds As New DataSet

            sql = "SELECT COUNT(*) AS QDE FROM IMP_WORKER WHERE IMPSTATUS LIKE 'Error%'"
            bdconn.ExecuteSQL(sql, ds)

            Dim nErro As Integer = 0

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    nErro = ds.Tables(0).Rows(i)("QDE")
                Next
            End If
            ds.Dispose()

            If nErro > 0 Then
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                Return False
                Exit Function
            End If

            ds = New DataSet

            sql = "SELECT IMP_WORKER.* " &
                ",(SELECT COUNT(*) FROM WORKER " &
                "WHERE TRIM(IMP_WORKER.WORKERID) = WORKER.WORKERID ) AS OPE " &
                "FROM IMP_WORKER " &
                "ORDER BY IMP_WORKER.ID "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sDesc As String = ""
                Dim bdconnSQL As New clsBancoDadosSQL

                bdconnSQL.OpenConnection()

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sDesc = ""

                    Try
                        If ds.Tables(0).Rows(i)("OPE") = 0 Then

                            sql = "INSERT INTO [WORKER] " &
                                "([WORKERID],[NAME1],[NAME2],[SURNAME1] " &
                                ",[SURNAME2],[APPOINTMENT],[SUBACCOUNT],[EMAIL] " &
                                ",[BONUSVALUE],[MANHOURVALUE],[PHONE] " &
                                ",[ACTIVE]) VALUES ("

                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("WORKERID").ToString.Trim) & "',"
                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("NAME1").ToString.Trim) & "',"
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("NAME2").ToString.Trim, "s") & ","
                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("SURNAME1").ToString.Trim) & "',"
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SURNAME2").ToString.Trim, "s") & ","
                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("APPOINTMENT").ToString.Trim) & "',"
                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("SUBACCOUNT").ToString.Trim) & "',"
                            sql = sql & "'" & Trim(ds.Tables(0).Rows(i)("EMAIL").ToString.Trim) & "',"
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("BONUSVALUE"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MANHOURVALUE"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PHONE").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim, "s") & ")"

                            sDesc = "OK - Inserted"

                        Else

                            sql = "UPDATE [WORKER] SET " &
                            "[NAME1]        = '" & Trim(ds.Tables(0).Rows(i)("NAME1").ToString.Trim) & "' " &
                            ",[NAME2]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("NAME2").ToString.Trim, "s") & " " &
                            ",[SURNAME1]     = '" & Trim(ds.Tables(0).Rows(i)("SURNAME1").ToString.Trim) & "' " &
                            ",[SURNAME2]     = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SURNAME2").ToString.Trim, "s") & " " &
                            ",[APPOINTMENT]  = '" & Trim(ds.Tables(0).Rows(i)("APPOINTMENT").ToString.Trim) & "' " &
                            ",[SUBACCOUNT]   = '" & Trim(ds.Tables(0).Rows(i)("SUBACCOUNT").ToString.Trim) & "' " &
                            ",[EMAIL]        = '" & Trim(ds.Tables(0).Rows(i)("EMAIL").ToString.Trim) & "' " &
                            ",[BONUSVALUE]   = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("BONUSVALUE"), "n") & " " &
                            ",[MANHOURVALUE] = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MANHOURVALUE"), "n") & " " &
                            ",[PHONE]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PHONE").ToString.Trim, "s") & " " &
                            ",[ACTIVE]       = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim, "s") & " " &
                            "WHERE [WORKERID] = '" & ds.Tables(0).Rows(i)("WORKERID").ToString.Trim & "' "

                            sDesc = "OK - Updated"

                        End If

                        bdconnSQL.ExecuteNonSQL(sql)


                    Catch ex As Exception
                        sDesc = "Erro: " & ex.Message
                    End Try

                    sql = "UPDATE IMP_WORKER SET IMPSTATUS = '" & sDesc & "' " &
                          "WHERE ID = " & ds.Tables(0).Rows(i)("ID")
                    bdconn.ExecuteNonSQL(sql)

                Next

                'FULLNAME update
                sql = "UPDATE WORKER SET " &
                      "FULLNAME = dbo.[fnStringFirstUpper](LTrim(NAME1) + IIf(SURNAME1 IS NOT NULL, + ' ' + LTRIM(SURNAME1),''))"
                bdconnSQL.ExecuteNonSQL(sql)

                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing

            End If
            ds.Dispose()

            ds = Nothing
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("WORKER")
            syn.Dispose()
            syn = Nothing

            Dim frm As New frmSyncBaseData
            frmSyncBaseData.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            Return True

        Catch ex As Exception
            MsgBox("Some problems had ocurred during the import process: " + ex.Message, vbInformation)
            Return False
        End Try

    End Function

    Public Function InventoryItem(ByVal sFile As String) As Boolean

        Try

            'Copying the file to WorkArea
            Dim sFileDest As String = "C:\SESTicket\file\tmp\INVENTORYITEM.xlsx"
            System.IO.File.Copy(sFile, sFileDest, True)

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM IMP_INVENTORYITEM"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO IMP_INVENTORYITEM ( INVENTORYITEMID, ABBREVIATION, DESCRIPTION, INVENTORYCLASSID, LASTCOST, " &
            "AVERAGECOST, LISTPRICE, DEFAULTSITEID, STORAGEUNIT, COSTOFGOODSACCOUNT, COSTOFGOODSSUBACCOUNT, SALESACCOUNT, " &
            "SALESACCOUNTAIU, SALESACCOUNTUBR, SALESACCOUNTUBRAIU, SALESSUBACCOUNT, INVENTORYACCOUNT, INVENTORYSUBACCOUNT, " &
            "MINONHAND, MAXONHAND, ACTIVE,VENDORNAME,VENDORID,BRAND ) " &
            "SELECT zXLS_INVENTORYITEM.[INVENTORYITEMID*], zXLS_INVENTORYITEM.ABBREVIATION, zXLS_INVENTORYITEM.DESCRIPTION,  " &
            "zXLS_INVENTORYITEM.[INVENTORYCLASSID*], zXLS_INVENTORYITEM.[LASTCOST*], zXLS_INVENTORYITEM.[AVERAGECOST*],  " &
            "zXLS_INVENTORYITEM.[LISTPRICE*], zXLS_INVENTORYITEM.[DEFAULTSITEID*], zXLS_INVENTORYITEM.[STORAGEUNIT*],  " &
            "zXLS_INVENTORYITEM.COSTOFGOODSACCOUNT, zXLS_INVENTORYITEM.COSTOFGOODSSUBACCOUNT, zXLS_INVENTORYITEM.SALESACCOUNT,  " &
            "zXLS_INVENTORYITEM.SALESACCOUNTAIU, zXLS_INVENTORYITEM.SALESACCOUNTUBR, zXLS_INVENTORYITEM.SALESACCOUNTUBRAIU,  " &
            "zXLS_INVENTORYITEM.SALESSUBACCOUNT, zXLS_INVENTORYITEM.INVENTORYACCOUNT, zXLS_INVENTORYITEM.INVENTORYSUBACCOUNT, " &
            "zXLS_INVENTORYITEM.[MINONHAND*], zXLS_INVENTORYITEM.[MAXONHAND*], zXLS_INVENTORYITEM.[ACTIVE*], zXLS_INVENTORYITEM.VENDORNAME, zXLS_INVENTORYITEM.VENDORID,zXLS_INVENTORYITEM.BRAND " &
            "FROM zXLS_INVENTORYITEM " &
            "WHERE " &
            "zXLS_INVENTORYITEM.[INVENTORYITEMID*] <> 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA' "
            bdconn.ExecuteNonSQL(sql)

            Dim msg As String

            'Checking INVENTORYITEMID
            msg = "Error: INVENTORYITEMID is Empty or length greater than 30 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (INVENTORYITEMID IS NULL) OR  (LTRIM(RTRIM(INVENTORYITEMID)) = '') OR (LEN(TRIM(INVENTORYITEMID)) > 30) "
            bdconn.ExecuteNonSQL(sql)

            'Checking ABBREVIATION
            msg = "Error: ABBREVIATION length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(ABBREVIATION)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking DESCRIPTION
            msg = "Error: DESCRIPTION length greater than 350 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(DESCRIPTION)) > 350) "
            bdconn.ExecuteNonSQL(sql)

            'Checking INVENTORYCLASSID
            msg = "Error: INVENTORYCLASSID is invalid"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM INVENTORYCLASS " &
                  "WHERE IMP_INVENTORYITEM.INVENTORYCLASSID = INVENTORYCLASS.INVENTORYCLASSID)"
            bdconn.ExecuteNonSQL(sql)

            'Checking LASTCOST
            msg = "Error: LASTCOST is Empty or not a number"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(LASTCOST) = FALSE) OR (LASTCOST IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking AVERAGECOST
            msg = "Error: AVERAGECOST is Empty or not a number"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(AVERAGECOST) = FALSE) OR (AVERAGECOST IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking LISTPRICE
            msg = "Error: LISTPRICE is Empty or not a number"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(LISTPRICE) = FALSE) OR (LISTPRICE IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking DEFAULTSITEID
            msg = "Error: DEFAULTSITEID is invalid"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM [SITE] " &
                  "WHERE IMP_INVENTORYITEM.DEFAULTSITEID = [SITE].SITEID)"
            bdconn.ExecuteNonSQL(sql)

            'Checking STORAGEUNIT
            msg = "Error: STORAGEUNIT is Empty or length greater than 30 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (STORAGEUNIT IS NULL) OR  (LTRIM(RTRIM(STORAGEUNIT)) = '') OR (LEN(TRIM(STORAGEUNIT)) > 10) "
            bdconn.ExecuteNonSQL(sql)

            'Checking COSTOFGOODSACCOUNT
            msg = "Error: COSTOFGOODSACCOUNT length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(COSTOFGOODSACCOUNT)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking COSTOFGOODSSUBACCOUNT
            msg = "Error: COSTOFGOODSSUBACCOUNT length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(COSTOFGOODSSUBACCOUNT)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SALESACCOUNT
            msg = "Error: SALESACCOUNT length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SALESACCOUNT)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SALESACCOUNTAIU
            msg = "Error: SALESACCOUNTAIU length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SALESACCOUNTAIU)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SALESACCOUNTUBR
            msg = "Error: SALESACCOUNTUBR length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SALESACCOUNTUBR)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SALESACCOUNTUBRAIU
            msg = "Error: SALESACCOUNTUBRAIU length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SALESACCOUNTUBRAIU)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SALESSUBACCOUNT
            msg = "Error: SALESSUBACCOUNT length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(SALESSUBACCOUNT)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking INVENTORYACCOUNT
            msg = "Error: INVENTORYACCOUNT length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(INVENTORYACCOUNT)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking INVENTORYSUBACCOUNT
            msg = "Error: INVENTORYSUBACCOUNT length greater than 50 chars"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (LEN(TRIM(INVENTORYSUBACCOUNT)) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking MINONHAND
            msg = "Error: MINONHAND is Empty or not a number"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(MINONHAND) = FALSE) OR (MINONHAND IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking MAXONHAND
            msg = "Error: MAXONHAND is Empty or not a number"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (ISNUMERIC(MAXONHAND) = FALSE) OR (MAXONHAND IS NULL)"
            bdconn.ExecuteNonSQL(sql)

            'Checking ACTIVE
            msg = "Error: ACTIVE is Empty or invalid value"
            sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(ACTIVE) NOT IN ('YES','NO')) OR (ACTIVE IS NULL) OR (TRIM(TRIM(ACTIVE)) = '')"
            bdconn.ExecuteNonSQL(sql)

            Dim ds As New DataSet

            sql = "SELECT COUNT(*) AS QDE FROM IMP_INVENTORYITEM WHERE IMPSTATUS LIKE 'Error%'"
            bdconn.ExecuteSQL(sql, ds)

            Dim nErro As Integer = 0

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    nErro = ds.Tables(0).Rows(i)("QDE")
                Next
            End If
            ds.Dispose()

            If nErro > 0 Then
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                Return False
                Exit Function
            End If

            ds = New DataSet

            sql = "SELECT IMP_INVENTORYITEM.* " &
                ",(SELECT COUNT(*) FROM INVENTORYITEM " &
                "WHERE TRIM(IMP_INVENTORYITEM.INVENTORYITEMID) = INVENTORYITEM.INVENTORYITEMID ) AS OPE " &
                "FROM IMP_INVENTORYITEM " &
                "ORDER BY IMP_INVENTORYITEM.ID "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sDesc As String = ""
                Dim bdconnSQL As New clsBancoDadosSQL

                bdconnSQL.OpenConnection()

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sDesc = ""

                    Try
                        If ds.Tables(0).Rows(i)("OPE") = 0 Then

                            sql = "INSERT INTO [INVENTORYITEM] " &
                                  "([INVENTORYITEMID],[DESCRIPTION],[INVENTORYCLASSID] " &
                                  ",[LASTCOST],[AVERAGECOST],[LISTPRICE],[DEFAULTSITEID],[STORAGEUNIT] " &
                                  ",[DEFAULTSALESUNIT],[DEFAULTPURCHASEUNIT],[COSTOFGOODSACCOUNT],[COSTOFGOODSSUBACCOUNT] " &
                                  ",[SALESACCOUNT],[SALESACCOUNTAIU],[SALESACCOUNTUBR],[SALESACCOUNTUBRAIU],[SALESSUBACCOUNT] " &
                                  ",[INVENTORYACCOUNT],[INVENTORYSUBACCOUNT],[MINONHAND],[MAXONHAND] " &
                                  ",[ABBREVIATION],[ACTIVE],VENDOR,BRAND,VENDORID) VALUES ("

                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYITEMID").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DESCRIPTION").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYCLASSID").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("LASTCOST"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("AVERAGECOST"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("LISTPRICE"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DEFAULTSITEID").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STORAGEUNIT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STORAGEUNIT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STORAGEUNIT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("COSTOFGOODSACCOUNT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("COSTOFGOODSSUBACCOUNT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNTAIU").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNTUBR").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNTUBRAIU").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESSUBACCOUNT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYACCOUNT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYSUBACCOUNT").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MINONHAND"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MAXONHAND"), "n") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ABBREVIATION").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim.ToUpper, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("VENDORNAME"), "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("BRAND"), "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("VENDORID"), "s") & ")"
                            sDesc = "OK - Inserted"

                        Else

                            sql = "UPDATE [INVENTORYITEM] SET " &
                            " [DESCRIPTION]           = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DESCRIPTION").ToString.Trim, "s") & " " &
                            ",[INVENTORYCLASSID]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYCLASSID").ToString.Trim, "s") & " " &
                            ",[LASTCOST]              = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("LASTCOST"), "n") & " " &
                            ",[AVERAGECOST]           = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("AVERAGECOST"), "n") & " " &
                            ",[LISTPRICE]             = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("LISTPRICE"), "n") & " " &
                            ",[DEFAULTSITEID]         = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("DEFAULTSITEID").ToString.Trim, "s") & " " &
                            ",[STORAGEUNIT]           = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STORAGEUNIT").ToString.Trim, "s") & " " &
                            ",[DEFAULTSALESUNIT]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STORAGEUNIT").ToString.Trim, "s") & " " &
                            ",[DEFAULTPURCHASEUNIT]   = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STORAGEUNIT").ToString.Trim, "s") & " " &
                            ",[COSTOFGOODSACCOUNT]    = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("COSTOFGOODSACCOUNT").ToString.Trim, "s") & " " &
                            ",[COSTOFGOODSSUBACCOUNT] = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("COSTOFGOODSSUBACCOUNT").ToString.Trim, "s") & " " &
                            ",[SALESACCOUNT]          = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNT").ToString.Trim, "s") & " " &
                            ",[SALESACCOUNTAIU]       = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNTAIU").ToString.Trim, "s") & " " &
                            ",[SALESACCOUNTUBR]       = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNTUBR").ToString.Trim, "s") & " " &
                            ",[SALESACCOUNTUBRAIU]    = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESACCOUNTUBRAIU").ToString.Trim, "s") & " " &
                            ",[SALESSUBACCOUNT]       = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SALESSUBACCOUNT").ToString.Trim, "s") & " " &
                            ",[INVENTORYACCOUNT]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYACCOUNT").ToString.Trim, "s") & " " &
                            ",[INVENTORYSUBACCOUNT]   = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("INVENTORYSUBACCOUNT").ToString.Trim, "s") & " " &
                            ",[MINONHAND]             = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MINONHAND"), "n") & " " &
                            ",[MAXONHAND]             = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("MAXONHAND"), "n") & " " &
                            ",[ABBREVIATION]          = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ABBREVIATION").ToString.Trim, "s") & " " &
                            ",[ACTIVE]                = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim.ToUpper, "s") & " " &
                            ",[VENDOR]                = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("VENDORNAME"), "s") & " " &
                            ",[BRAND]                 = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("BRAND"), "s") & " " &
                            ",[VENDORID]              = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("VENDORID"), "s") & " " &
                            "WHERE INVENTORYITEMID = '" & ds.Tables(0).Rows(i)("INVENTORYITEMID").ToString.Trim & "' "

                            sDesc = "OK - Updated"

                        End If

                        bdconnSQL.ExecuteNonSQL(sql)


                    Catch ex As Exception
                        sDesc = "Erro: " & ex.Message
                    End Try

                    sql = "UPDATE IMP_INVENTORYITEM SET IMPSTATUS = '" & sDesc & "' " &
                          "WHERE ID = " & ds.Tables(0).Rows(i)("ID")
                    bdconn.ExecuteNonSQL(sql)

                Next

                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing

            End If
            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("INVENTORYITEM")
            syn.Dispose()
            syn = Nothing

            Dim frm As New frmSyncBaseData
            frmSyncBaseData.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            Return True

        Catch ex As Exception
            MsgBox("Some problems had ocurred during the import process: " + ex.Message, vbInformation)
            Return False
        End Try

    End Function

    Public Function Well(ByVal sFile As String) As Boolean

        Try

            'Copying the file to WorkArea
            Dim sFileDest As String = "C:\SESTicket\file\tmp\WELL.xlsx"
            System.IO.File.Copy(sFile, sFileDest, True)

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM IMP_WELL"
            bdconn.ExecuteNonSQL(sql)

            sql = "INSERT INTO IMP_WELL ( WELLID, NAME, PETRFIELDID, COUNTRY, " &
            "STATE, CITY, SITEID, ACTIVE,RIGID ) " &
            "SELECT zXLS_WELL.[WELLID*], zXLS_WELL.[NAME*], zXLS_WELL.[PETRFIELDID*], " &
            "zXLS_WELL.[COUNTRY*], zXLS_WELL.[STATE*], zXLS_WELL.[CITY*], " &
            "zXLS_WELL.[SITEID*], zXLS_WELL.[ACTIVE*], zXLS_WELL.[RIGID] " &
            "FROM zXLS_WELL " &
            "WHERE " &
            "zXLS_WELL.[WELLID*] <> 'AAAAAAAAAAAAAAA' "

            bdconn.ExecuteNonSQL(sql)

            Dim msg As String

            'Checking WELLID
            msg = "Error: WELLID is Empty or length greater than 15 chars"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (WELLID IS NULL) OR (LTRIM(RTRIM(WELLID)) = '') OR (LEN(TRIM(WELLID)) > 15) "
            bdconn.ExecuteNonSQL(sql)

            'Checking NAME
            msg = "Error: NAME is Empty or length greater than 50 chars"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE ([NAME] IS NULL) OR (LTRIM(RTRIM([NAME])) = '') OR (LEN(TRIM([NAME])) > 50) "
            bdconn.ExecuteNonSQL(sql)

            'Checking PETRFIELDID
            msg = "Error: PETRFIELDID is invalid"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM PETRFIELD " &
                  "WHERE TRIM(IMP_WELL.PETRFIELDID) = PETRFIELD.PETRFIELDID)"
            bdconn.ExecuteNonSQL(sql)

            'Checking COUNTRY
            msg = "Error: COUNTRY is invalid"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM COUNTRY " &
                  "WHERE TRIM(IMP_WELL.COUNTRY) = COUNTRY.NAME) "
            bdconn.ExecuteNonSQL(sql)

            'Checking STATE
            msg = "Error: STATE is invalid"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM STATE " &
                  "WHERE TRIM(IMP_WELL.STATE) = STATE.NAME) "
            bdconn.ExecuteNonSQL(sql)

            'Checking CITY
            msg = "Error: CITY is invalid"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM CITY " &
                  "WHERE TRIM(IMP_WELL.CITY) = CITY.NAME) "
            bdconn.ExecuteNonSQL(sql)

            'Checking SITEID
            msg = "Error: SITEID is invalid"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM [SITE] " &
                  "WHERE IMP_WELL.SITEID = [SITE].SITEID)"
            bdconn.ExecuteNonSQL(sql)

            'Checking ACTIVE
            msg = "Error: ACTIVE is Empty or invalid value"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE (TRIM(ACTIVE) NOT IN ('YES','NO')) OR (ACTIVE IS NULL) OR (TRIM(TRIM(ACTIVE)) = '')"
            bdconn.ExecuteNonSQL(sql)

            'Checking RIGID
            msg = "Error: RIGID is invalid"
            sql = "UPDATE IMP_WELL SET IMPSTATUS = " &
                  " IIF(ISNULL(IMPSTATUS)=TRUE,'" & msg & "' + '#' + chr(10), IMPSTATUS + '" & msg & "' + '#' + chr(10)) " &
                  "WHERE NOT EXISTS (SELECT 1 FROM RIG " &
                  "WHERE TRIM(IMP_WELL.RIGID) = RIG.RIGID) and TRIM(TRIM(RIGID)) <> '' "
            bdconn.ExecuteNonSQL(sql)

            Dim ds As New DataSet

            sql = "SELECT COUNT(*) AS QDE FROM IMP_WELL WHERE IMPSTATUS LIKE 'Error%'"
            bdconn.ExecuteSQL(sql, ds)

            Dim nErro As Integer = 0

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    nErro = ds.Tables(0).Rows(i)("QDE")
                Next
            End If
            ds.Dispose()

            If nErro > 0 Then
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                Return False
                Exit Function
            End If

            ds = New DataSet

            sql = "SELECT IMP_WELL.* " &
                ",(SELECT COUNT(*) FROM WELL " &
                "WHERE TRIM(IMP_WELL.WELLID) = WELL.WELLID ) AS OPE " &
                "FROM IMP_WELL " &
                "ORDER BY IMP_WELL.ID "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sDesc As String = ""

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sDesc = ""

                    Try
                        If ds.Tables(0).Rows(i)("OPE") = 0 Then

                            sql = "INSERT INTO [zSQL_WELL] " &
                                "([WELLID],[NAME],[PETRFIELDID],[COUNTRY],[STATE],[CITY],[SITEID],[ACTIVE],[RIGID]) VALUES ("

                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("WELLID").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("NAME").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PETRFIELDID").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("COUNTRY").ToString.Trim.ToUpper, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STATE").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("CITY").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SITEID").ToString.Trim, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim.ToUpper, "s") & ","
                            sql = sql & util.SQLConvStrNull(ds.Tables(0).Rows(i)("RIGID").ToString.Trim, "s") & ")"

                            sDesc = "OK - Inserted"

                        Else

                            sql = "UPDATE [zSQL_WELL] SET " &
                            " [NAME]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("NAME").ToString.Trim, "s") & " " &
                            ",[PETRFIELDID] = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("PETRFIELDID").ToString.Trim, "s") & " " &
                            ",[COUNTRY]     = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("COUNTRY").ToString.Trim.ToUpper, "s") & " " &
                            ",[STATE]       = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("STATE").ToString.Trim, "s") & " " &
                            ",[CITY]        = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("CITY").ToString.Trim, "s") & " " &
                            ",[SITEID]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("SITEID").ToString.Trim, "s") & " " &
                            ",[ACTIVE]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("ACTIVE").ToString.Trim.ToUpper, "s") & " " &
                            ",[RIGID]      = " & util.SQLConvStrNull(ds.Tables(0).Rows(i)("RIGID").ToString.Trim, "s") & " " &
                            "WHERE WELLID = '" & ds.Tables(0).Rows(i)("WELLID").ToString.Trim & "' "

                            sDesc = "OK - Updated"

                        End If

                        bdconn.ExecuteNonSQL(sql)


                    Catch ex As Exception
                        sDesc = "Erro: " & ex.Message
                    End Try

                    sql = "UPDATE IMP_WELL SET IMPSTATUS = '" & sDesc & "' " &
                          "WHERE ID = " & ds.Tables(0).Rows(i)("ID")
                    bdconn.ExecuteNonSQL(sql)

                Next

            End If
            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("WELL")
            syn.Dispose()
            syn = Nothing

            Dim frm As New frmSyncBaseData
            frmSyncBaseData.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            Return True

        Catch ex As Exception
            MsgBox("Some problems had ocurred during the import process: " + ex.Message, vbInformation)
            Return False
        End Try

    End Function




End Class
