Imports System.Configuration

Public Class clsSyncBaseData
    Implements IDisposable

    Dim util As New clsUtils
    Public sLog As String = ""
    Public bErro As Boolean = False

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

    Public Sub Site()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [SITE]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO SITE ( SITEID, NAME, DESCRIPTION, ADDRESS, ATENTION, CITY " &
            ",COUNTRY, PHONE, FAX, EMAIL, COSTOFGOODSACCOUNT, COSTOFGOODSSUBACCOUNT " &
            ",SALESACCOUNT, SALESSUBACCOUNT, INVENTORYACCOUNT, INVENTORYSUBACCOUNT " &
            ", STATE, ALIAS ) " &
            "SELECT zSQL_SITE.SITEID, zSQL_SITE.NAME, zSQL_SITE.DESCRIPTION, " &
            "zSQL_SITE.ADDRESS, zSQL_SITE.ATENTION, zSQL_SITE.CITY, zSQL_SITE.COUNTRY, " &
            "zSQL_SITE.PHONE, zSQL_SITE.FAX, zSQL_SITE.EMAIL, zSQL_SITE.COSTOFGOODSACCOUNT, " &
            "zSQL_SITE.COSTOFGOODSSUBACCOUNT, zSQL_SITE.SALESACCOUNT, zSQL_SITE.SALESSUBACCOUNT, " &
            "zSQL_SITE.INVENTORYACCOUNT, zSQL_SITE.INVENTORYSUBACCOUNT,   " &
            "zSQL_SITE.STATE, zSQL_SITE.ALIAS " &
            "FROM zSQL_SITE "

            bdconnACCESS.ExecuteNonSQL(sql)

            'Inserting cbxSite
            sql = "DELETE FROM cbxSite"
            bdconnACCESS.ExecuteNonSQL(sql)
            sql = "INSERT INTO cbxSite (ORD,SITEID,NAME,ALIAS) SELECT 0 as ORD, SITE.SITEID, SITE.NAME, SITE.ALIAS FROM SITE "
            bdconnACCESS.ExecuteNonSQL(sql)
            sql = "INSERT INTO cbxSite (ORD,SITEID,NAME,ALIAS) VALUES (-1, -1,'All','All') "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("SITE")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Casing()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [CASING]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO CASING ( SIZEINC, WEIGHTFT, GRADE ) " &
            "SELECT zSQL_CASING.SIZEINC, zSQL_CASING.WEIGHTFT, zSQL_CASING.GRADE " &
            "FROM zSQL_CASING "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("CASING")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Contract()

        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [CONTRACT]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO CONTRACT ( CONTRACTID, CONTRACTNUMBER, NAME, DESCRIPTION, " &
            "CUSTOMERID, START_DATE, COMPLETION_DATE, [CURRENCY], SALESACCOUNT, " &
            "SALESSUBACCOUNT, COSTOFGOODSACCOUNT, COSTOFGOODSSUBACCOUNT, ACTIVE, " &
            "SERVICE_UTILITY, SERVICE_UTILITY_PERC, SERVICE_IVA_PERC, " &
            "MATERIAL_IVA_PERC, PORTIONUSD, PORTIONCOP,LAYOUTTYPE, EXCHANGERATE, ENABLEEXCHANGERATE, " &
            "ENABLEDISCOUNT,SPLITAMOUNTMATSERV,SERVICELINEID, REPORTPARAMID  ) " &
            "SELECT CONTRACTID, CONTRACTNUMBER, " &
            "NAME, DESCRIPTION, CUSTOMERID, " &
            "START_DATE, COMPLETION_DATE, CURRENCY, " &
            "SALESACCOUNT, SALESSUBACCOUNT, " &
            "COSTOFGOODSACCOUNT, COSTOFGOODSSUBACCOUNT, " &
            "ACTIVE, SERVICE_UTILITY, SERVICE_UTILITY_PERC, " &
            "SERVICE_IVA_PERC, MATERIAL_IVA_PERC, PORTIONUSD, " &
            "PORTIONCOP, LAYOUTTYPE,EXCHANGERATE,ENABLEEXCHANGERATE,ENABLEDISCOUNT,SPLITAMOUNTMATSERV, " &
            "SERVICELINEID, REPORTPARAMID " &
            "FROM zSQL_CONTRACT "

            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("CONTRACT")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub ContractPriceList()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [CONTRACTPRICELIST]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO CONTRACTPRICELIST ( CONTRACTPRICELISTID, CONTRACTID, CUSTCODEITEM, DESCRIPTION, SALES_PRICE, UNIT_SALE, INVENTORYCLASSID, CONTRACTED_QTY, ACTIVE, ISHEADER, EXIBITONREPORT, TABGROUP, SHOWCUSTITEMREPORT,GROUPORDER,PRICEBASE,PRICEUTILITY, " &
                " PERMITUPDATEDESCRIP,PERMITUPDATEPRICEUNIT,PERMITNEGATIVE,PRICEUNITDECIMAL)" &
                "SELECT zSQL_CONTRACTPRICELIST.CONTRACTPRICELISTID, zSQL_CONTRACTPRICELIST.CONTRACTID, zSQL_CONTRACTPRICELIST.CUSTCODEITEM, zSQL_CONTRACTPRICELIST.DESCRIPTION, zSQL_CONTRACTPRICELIST.SALES_PRICE," &
                "zSQL_CONTRACTPRICELIST.UNIT_SALE, zSQL_CONTRACTPRICELIST.INVENTORYCLASSID, zSQL_CONTRACTPRICELIST.CONTRACTED_QTY, zSQL_CONTRACTPRICELIST.ACTIVE, zSQL_CONTRACTPRICELIST.ISHEADER," &
                "zSQL_CONTRACTPRICELIST.EXIBITONREPORT, zSQL_CONTRACTPRICELIST.TABGROUP, zSQL_CONTRACTPRICELIST.SHOWCUSTITEMREPORT,zSQL_CONTRACTPRICELIST.GROUPORDER,zSQL_CONTRACTPRICELIST.PRICEBASE,zSQL_CONTRACTPRICELIST.PRICEUTILITY, " &
                "zSQL_CONTRACTPRICELIST.PERMITUPDATEDESCRIP,zSQL_CONTRACTPRICELIST.PERMITUPDATEPRICEUNIT,zSQL_CONTRACTPRICELIST.PERMITNEGATIVE, zSQL_CONTRACTPRICELIST.PRICEUNITDECIMAL " &
                "FROM zSQL_CONTRACTPRICELIST "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("CONTRACTPRICELIST")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub ContractAIUInventoryClass()

        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [CONTRACTAIUINVENTORYCLASS]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO CONTRACTAIUINVENTORYCLASS ( CONTRACTID, INVENTORYCLASSID ) " &
            "SELECT zSQL_CONTRACTAIUINVENTORYCLASS.CONTRACTID,  " &
            "zSQL_CONTRACTAIUINVENTORYCLASS.INVENTORYCLASSID  " &
            "FROM zSQL_CONTRACTAIUINVENTORYCLASS"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("CONTRACTAIUINVENTORYCLASS")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub ContractRepLayout()

        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [CONTRACTREPLAYOUT]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO CONTRACTREPLAYOUT ( CONTRACTREPLAYOUT, CONTRACTID, REPORTCODE ) " &
                  "SELECT zSQL_CONTRACTREPLAYOUT.CONTRACTREPLAYOUT, zSQL_CONTRACTREPLAYOUT.CONTRACTID, zSQL_CONTRACTREPLAYOUT.REPORTCODE " &
                  "FROM zSQL_CONTRACTREPLAYOUT"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("CONTRACTREPLAYOUT")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Customer()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [CUSTOMER]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO CUSTOMER ( CUSTOMERID, NAME, ADDRESS1, " &
            "ADDRESS2, CITY, STATE, " &
            "COUNTRY, PHONE, FAX, EMAIL, OBS, SALESACCOUNT, SALESSUBACCOUNT,  " &
            "ARACCOUNT, ARSUBACCOUNT )  " &
            "SELECT zSQL_CUSTOMER.CUSTOMERID, zSQL_CUSTOMER.NAME, zSQL_CUSTOMER.ADDRESS1,  " &
            "zSQL_CUSTOMER.ADDRESS2, zSQL_CUSTOMER.CITY, zSQL_CUSTOMER.STATE, " &
            "zSQL_CUSTOMER.COUNTRY, zSQL_CUSTOMER.PHONE, zSQL_CUSTOMER.FAX,  " &
            "zSQL_CUSTOMER.EMAIL, zSQL_CUSTOMER.OBS, zSQL_CUSTOMER.SALESACCOUNT,  " &
            "zSQL_CUSTOMER.SALESSUBACCOUNT, zSQL_CUSTOMER.ARACCOUNT,  " &
            "zSQL_CUSTOMER.ARSUBACCOUNT  " &
            "FROM zSQL_CUSTOMER "
            bdconnACCESS.ExecuteNonSQL(sql)

            'Inserting cbxCustomer
            sql = "DELETE FROM cbxCustomer"
            bdconnACCESS.ExecuteNonSQL(sql)
            sql = "INSERT INTO cbxCustomer (ORD,CUSTOMERID,NAME) SELECT 0 AS ORD,CUSTOMER.CUSTOMERID, CUSTOMER.NAME FROM CUSTOMER "
            bdconnACCESS.ExecuteNonSQL(sql)
            sql = "INSERT INTO cbxCustomer (ORD,CUSTOMERID,NAME) VALUES (-1,-1,'All') "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("CUSTOMER")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Equipment()
        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [EQUIPMENT]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO EQUIPMENT ( EQUIPMENTID, DESCRIPTION, MODEL, SERIAL, TAG, ACTIVE,UNIT ) " &
            "SELECT zSQL_EQUIPMENT.EQUIPMENTID, zSQL_EQUIPMENT.DESCRIPTION, " &
            "zSQL_EQUIPMENT.MODEL, zSQL_EQUIPMENT.SERIAL, zSQL_EQUIPMENT.TAG, " &
            "zSQL_EQUIPMENT.ACTIVE,zSQL_EQUIPMENT.UNIT " &
            "FROM zSQL_EQUIPMENT "

            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("EQUIPMENT")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub InventoryClass()

        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [INVENTORYCLASS]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO INVENTORYCLASS ( INVENTORYCLASSID, TYPE, DESCRIPTION, COSTOFGOODSACCOUNT, " &
            "COSTOFGOODSSUBACCOUNT, SALESACCOUNT, SALESACCOUNTAIU, SALESACCOUNTUBR, " &
            "SALESACCOUNTUBRAIU, SALESSUBACCOUNT, INVENTORYACCOUNT, INVENTORYSUBACCOUNT )  " &
            "SELECT zSQL_INVENTORYCLASS.INVENTORYCLASSID, zSQL_INVENTORYCLASS.TYPE,  " &
            "zSQL_INVENTORYCLASS.DESCRIPTION, zSQL_INVENTORYCLASS.COSTOFGOODSACCOUNT,  " &
            "zSQL_INVENTORYCLASS.COSTOFGOODSSUBACCOUNT, zSQL_INVENTORYCLASS.SALESACCOUNT, " &
            "zSQL_INVENTORYCLASS.SALESACCOUNTAIU, zSQL_INVENTORYCLASS.SALESACCOUNTUBR,  " &
            "zSQL_INVENTORYCLASS.SALESACCOUNTUBRAIU, zSQL_INVENTORYCLASS.SALESSUBACCOUNT,  " &
            "zSQL_INVENTORYCLASS.INVENTORYACCOUNT, zSQL_INVENTORYCLASS.INVENTORYSUBACCOUNT  " &
            "FROM zSQL_INVENTORYCLASS "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("INVENTORYCLASS")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub InventoryItem()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [INVENTORYITEM]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO INVENTORYITEM ( INVENTORYITEMID, DESCRIPTION, INVENTORYCLASSID, " &
            "LASTCOST, AVERAGECOST, BUYERID, LISTPRICE, DEFAULTSITEID, STORAGEUNIT, " &
            "DEFAULTSALESUNIT, DEFAULTPURCHASEUNIT, COSTOFGOODSACCOUNT, COSTOFGOODSSUBACCOUNT, " &
            "SALESACCOUNT, SALESACCOUNTAIU, SALESACCOUNTUBR, SALESACCOUNTUBRAIU, SALESSUBACCOUNT, " &
            "INVENTORYACCOUNT, INVENTORYSUBACCOUNT, MINONHAND, MAXONHAND, ACTIVE,ABBREVIATION,VENDORID,VENDOR,BRAND ) " &
            "SELECT zSQL_INVENTORYITEM.INVENTORYITEMID, zSQL_INVENTORYITEM.DESCRIPTION, " &
            "zSQL_INVENTORYITEM.INVENTORYCLASSID, zSQL_INVENTORYITEM.LASTCOST, " &
            "zSQL_INVENTORYITEM.AVERAGECOST, zSQL_INVENTORYITEM.BUYERID, " &
            "zSQL_INVENTORYITEM.LISTPRICE, zSQL_INVENTORYITEM.DEFAULTSITEID,  " &
            "zSQL_INVENTORYITEM.STORAGEUNIT, zSQL_INVENTORYITEM.DEFAULTSALESUNIT,  " &
            "zSQL_INVENTORYITEM.DEFAULTPURCHASEUNIT, zSQL_INVENTORYITEM.COSTOFGOODSACCOUNT,  " &
            "zSQL_INVENTORYITEM.COSTOFGOODSSUBACCOUNT, zSQL_INVENTORYITEM.SALESACCOUNT, " &
            "zSQL_INVENTORYITEM.SALESACCOUNTAIU, zSQL_INVENTORYITEM.SALESACCOUNTUBR, " &
            "zSQL_INVENTORYITEM.SALESACCOUNTUBRAIU, zSQL_INVENTORYITEM.SALESSUBACCOUNT, " &
            "zSQL_INVENTORYITEM.INVENTORYACCOUNT, zSQL_INVENTORYITEM.INVENTORYSUBACCOUNT,  " &
            "zSQL_INVENTORYITEM.MINONHAND, zSQL_INVENTORYITEM.MAXONHAND, zSQL_INVENTORYITEM.ACTIVE, zSQL_INVENTORYITEM.ABBREVIATION, " &
            "zSQL_INVENTORYITEM.VENDORID,zSQL_INVENTORYITEM.VENDOR,zSQL_INVENTORYITEM.BRAND " &
            "FROM zSQL_INVENTORYITEM"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("INVENTORYITEM")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub InventoryUnit()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [INVENTORYUNIT]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO INVENTORYUNIT ( INVENTORYUNITID, STORAGEUNIT, ALTERNATIVEUNIT, " &
                    "OPERATIONCONVERSION, FACTORCONVERSION ) " &
                    "SELECT zSQL_INVENTORYUNIT.INVENTORYUNITID, zSQL_INVENTORYUNIT.STORAGEUNIT,  " &
                    "zSQL_INVENTORYUNIT.ALTERNATIVEUNIT, zSQL_INVENTORYUNIT.OPERATIONCONVERSION,  " &
                    "zSQL_INVENTORYUNIT.FACTORCONVERSION  " &
                    "FROM zSQL_INVENTORYUNIT"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("INVENTORYUNIT")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub PetrField()

        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [PETRFIELD]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO PETRFIELD ( PETRFIELDID,PETRFIELDCODE,DESCRIP,PETRFIELDAREA ) " &
                    "SELECT PETRFIELDID,PETRFIELDCODE,DESCRIP,PETRFIELDAREA " &
                    "FROM zSQL_PETRFIELD"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("PETRFIELD")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub ServiceType()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [SERVICETYPE]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO SERVICETYPE ( SERVICETYPEID, DESCRIPTION, ACTIVE, SERVICETYPECODE ) " &
            "SELECT zSQL_SERVICETYPE.SERVICETYPEID, zSQL_SERVICETYPE.DESCRIPTION, zSQL_SERVICETYPE.ACTIVE, zSQL_SERVICETYPE.SERVICETYPECODE " &
            "FROM zSQL_SERVICETYPE"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("SERVICETYPE")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Tubing()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [TUBING]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO TUBING ( TUBINGID, DRILL_PIPE, WEIGHT, GRADE ) " &
            "SELECT zSQL_TUBING.TUBINGID, zSQL_TUBING.DRILL_PIPE, zSQL_TUBING.WEIGHT, zSQL_TUBING.GRADE " &
            "FROM zSQL_TUBING"
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("TUBING")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Well()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [WELL]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO WELL ( WELLID, NAME, PETRFIELDID, COUNTRY, STATE, CITY, SITEID, ACTIVE,RIGID ) " &
                "SELECT zSQL_WELL.WELLID, zSQL_WELL.NAME, zSQL_WELL.PETRFIELDID, zSQL_WELL.COUNTRY, zSQL_WELL.STATE, zSQL_WELL.CITY, zSQL_WELL.SITEID, zSQL_WELL.ACTIVE, zSQL_WELL.RIGID " &
                "FROM zSQL_WELL "

            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("WELL")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Worker()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [WORKER]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO [WORKER] " &
            "([WORKERID],[NAME1],[NAME2],[SURNAME1],[SURNAME2],[APPOINTMENT] " &
            ",[SUBACCOUNT],[EMAIL],[BONUSVALUE],[MANHOURVALUE],[ACTIVE],[PHONE],[FULLNAME]) " &
            "SELECT zSQL_WORKER.WORKERID,zSQL_WORKER.NAME1,zSQL_WORKER.NAME2,zSQL_WORKER.SURNAME1 " &
            ",zSQL_WORKER.SURNAME2,zSQL_WORKER.APPOINTMENT,zSQL_WORKER.SUBACCOUNT " &
            ",zSQL_WORKER.EMAIL,zSQL_WORKER.BONUSVALUE, zSQL_WORKER.MANHOURVALUE " &
            ",zSQL_WORKER.ACTIVE,zSQL_WORKER.PHONE, zSQL_WORKER.FULLNAME " &
            "FROM zSQL_WORKER "

            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("WORKER")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub ServiceLine()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [SERVICELINE]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO SERVICELINE ( SERVICELINEID, NAME, ACTIVE ) " &
            "SELECT zSQL_SERVICELINE.SERVICELINEID, zSQL_SERVICELINE.NAME, zSQL_SERVICELINE.ACTIVE " &
            "FROM zSQL_SERVICELINE "

            bdconnACCESS.ExecuteNonSQL(sql)

            'Inserting cbxServiceLine
            sql = "DELETE FROM cbxServiceLine"
            bdconnACCESS.ExecuteNonSQL(sql)
            sql = "INSERT INTO cbxServiceLine (ORD,SERVICELINEID,NAME,ACTIVE) SELECT 0 AS ORD, SERVICELINE.SERVICELINEID, SERVICELINE.NAME,SERVICELINE.ACTIVE FROM SERVICELINE "
            bdconnACCESS.ExecuteNonSQL(sql)
            sql = "INSERT INTO cbxServiceLine (ORD,SERVICELINEID,NAME,ACTIVE) VALUES ( -1,-1,'All','YES') "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("SERVICELINE")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub ReportParam()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [REPORTPARAM]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO REPORTPARAM ( REPORTPARAMID, DESCRIP, HEAD1, HEAD2, SESLOGO, AUXLOGO  ) " &
            "SELECT REPORTPARAMID, DESCRIP, HEAD1, HEAD2, SESLOGO, AUXLOGO " &
            "FROM zSQL_REPORTPARAM "

            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            Dim sReportFilesRemote As String = ConfigurationManager.AppSettings("RemoteAttachFolder").ToString & "\ReportFiles"
            Dim sReportFilesLocal As String = ConfigurationManager.AppSettings("ReportFilesLocal").ToString & ""

            My.Computer.FileSystem.CopyDirectory(sReportFilesRemote, sReportFilesLocal, True)

            UpdateDatetimeVersionBaseTable("REPORTPARAM")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub Rig()

        Try

            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBase")

            Dim sql As String

            sql = "DELETE FROM [RIG]"
            bdconnACCESS.ExecuteNonSQL(sql)

            sql = "INSERT INTO RIG ( RIGID ) " &
            "SELECT RIGID " &
            "FROM zSQL_RIG "

            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            UpdateDatetimeVersionBaseTable("RIG")

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub User()

        Try

            sLog = ""
            bErro = False

            If IsBaseDataTableUpToDate("USER") = False Then

                Dim bdconnACCESS As New clsBancoDadosACCESS
                bdconnACCESS.OpenConnection("AccBase")

                Dim sql As String

                sql = "DELETE FROM [USER]"
                bdconnACCESS.ExecuteNonSQL(sql)

                sql = "INSERT INTO [USER] ( USERID, NAME, USERNAME, ACTIVE, USERLANG ) " &
                "SELECT zSQL_USER.USERID, zSQL_USER.NAME, zSQL_USER.USERNAME, zSQL_USER.ACTIVE,  zSQL_USER.USERLANG " &
                "FROM zSQL_USER"
                bdconnACCESS.ExecuteNonSQL(sql)

                sql = "DELETE FROM [OBJECTGROUPUSER]"
                bdconnACCESS.ExecuteNonSQL(sql)

                sql = "INSERT INTO OBJECTGROUPUSER (OBJECTGROUPUSERID,USERNAME,OBJECTGROUPID,[ENABLE]) " &
                      "SELECT OBJECTGROUPUSERID,USERNAME,OBJECTGROUPID,[ENABLE] FROM zSQL_OBJECTGROUPUSER "
                bdconnACCESS.ExecuteNonSQL(sql)

                sql = "DELETE FROM [OBJECTGROUPITEMUSER]"
                bdconnACCESS.ExecuteNonSQL(sql)

                sql = "INSERT INTO OBJECTGROUPITEMUSER (OBJECTGROUPITEMUSERID,USERNAME,OBJECTGROUPITEMID,[ENABLE]) " &
                    "SELECT OBJECTGROUPITEMUSERID,USERNAME,OBJECTGROUPITEMID,[ENABLE] FROM zSQL_OBJECTGROUPITEMUSER "
                bdconnACCESS.ExecuteNonSQL(sql)

                bdconnACCESS.CloseConnection()
                bdconnACCESS.Dispose()
                bdconnACCESS = Nothing

                UpdateDatetimeVersionBaseTable("USER")

            End If

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try


    End Sub

    Public Sub Consec(ByVal Username As String)

        Try

            sLog = ""
            bErro = False

            Dim bdconn As New clsBancoDadosACCESS

            bdconn.OpenConnection()

            Dim sql As String
            Dim dsSQL As New DataSet
            Dim dsACCESS As New DataSet

            sql = "SELECT USERID, CONSEC FROM CONSEC WHERE USERNAME = '" & Username & "' "
            bdconn.ExecuteSQL(sql, dsACCESS)

            If dsACCESS.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To dsACCESS.Tables(0).Rows.Count - 1

                    sql = "SELECT USERID, CONSEC FROM zSQL_CONSEC WHERE USERNAME = '" & Username & "' "
                    bdconn.ExecuteSQL(sql, dsSQL)

                    If dsSQL.Tables(0).Rows.Count > 0 Then
                        For j As Integer = 0 To dsSQL.Tables(0).Rows.Count - 1

                            If dsACCESS.Tables(0).Rows(i)("CONSEC") > dsSQL.Tables(0).Rows(j)("CONSEC") Then

                                sql = "UPDATE zSQL_CONSEC SET CONSEC = " & dsACCESS.Tables(0).Rows(i)("CONSEC") & " " &
                                      "WHERE USERNAME = '" & Username & "' "

                                bdconn.ExecuteNonSQL(sql)

                            ElseIf dsACCESS.Tables(0).Rows(i)("CONSEC") < dsSQL.Tables(0).Rows(j)("CONSEC") Then

                                sql = "UPDATE CONSEC SET CONSEC = " & dsSQL.Tables(0).Rows(j)("CONSEC") & " " &
                                      "WHERE USERNAME = '" & Username & "' "

                                bdconn.ExecuteNonSQL(sql)

                            End If

                        Next
                    End If
                Next
            End If

            dsSQL.Dispose()
            dsSQL = Nothing
            dsACCESS.Dispose()
            dsACCESS = Nothing
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try
    End Sub

#Region "BaseTable Datetime Control Version"

    Public Sub UpdateVersionBaseSQL(ByVal sBaseTableName As String)

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        bdconn.OpenConnection("AccBaseData")

        Dim DateTimeUTC As String = util.GetDateTimeUTC()

        sql = "UPDATE zSQL_VERSIONBASE SET zSQL_VERSIONBASE.VERSIONBASE = " & DateTimeUTC & " "
        bdconn.ExecuteNonSQL(sql)

        sql = "UPDATE vSQL_VERSIONBASETABLE SET vSQL_VERSIONBASETABLE.SYNCDATETIME = " & DateTimeUTC & " " &
              "WHERE vSQL_VERSIONBASETABLE.TABLENAME = '" & sBaseTableName & "' "

        sql = "UPDATE zSQL_VERSIONBASETABLE SET zSQL_VERSIONBASETABLE.SYNCDATETIME = " & DateTimeUTC & " " &
              "WHERE (((zSQL_VERSIONBASETABLE.TABLENAME)='" & sBaseTableName & "'))"

        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Public Sub UpdateDatetimeBaseSync()
        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBaseData")

            Dim sql As String

            Dim DateTimeUTC As String = util.GetDateTimeUTC()

            sql = "UPDATE SYNCBASEDATA, zSQL_VERSIONBASE SET SYNCBASEDATA.DATESYNC = " & DateTimeUTC & ", SYNCBASEDATA.VERSIONBASE = [zSQL_VERSIONBASE].[VERSIONBASE] "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub

    Public Sub UpdateDatetimeVersionBaseTable(ByVal sBaseDataTable As String)

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection("AccBaseData")

        Dim sql As String

        sql = "UPDATE zSQL_VERSIONBASETABLE INNER JOIN VERSIONBASETABLE ON zSQL_VERSIONBASETABLE.TABLENAME = VERSIONBASETABLE.TABLENAME SET VERSIONBASETABLE.SYNCDATETIME = [zSQL_VERSIONBASETABLE]![SYNCDATETIME] " &
              "WHERE (([VERSIONBASETABLE]![TABLENAME]='" & sBaseDataTable & "')) "

        bdconnACCESS.ExecuteNonSQL(sql)

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

    End Sub

    Function GetDateTimeBaseSyncBase() As DateTime

        Dim dDateSync As DateTime = Now()
        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT * FROM [SYNCBASEDATA]"
        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                dDateSync = ds.Tables(0).Rows(i)("VERSIONBASE")
            Next
        End If

        ds.Dispose()
        ds = Nothing

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Return dDateSync

    End Function

    Public Function IsBaseDataUpToDate() As Boolean
        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection("AccBaseData")

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = False

        sql = "SELECT COUNT(*) AS QDE " &
              "FROM zSQL_VERSIONBASE " &
              "INNER JOIN SYNCBASEDATA  " &
              "ON zSQL_VERSIONBASE.VERSIONBASE = SYNCBASEDATA.VERSIONBASE "

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i)("QDE") = 0 Then
                    result = False
                Else
                    result = True
                End If
            Next
        End If

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing
        ds.Dispose()
        ds = Nothing

        Return result

    End Function

    Public Function IsBaseDataTableUpToDate(ByVal sBaseDataTable As String) As Boolean
        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection("AccBaseData")

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = False

        sql = "SELECT BASEDATATABLE_V.UPDATED  " &
              "FROM BASEDATATABLE_V  " &
              "WHERE BASEDATATABLE_V.TABLENAME = '" & sBaseDataTable & "' "

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i)("UPDATED") = 0 Then
                    result = False
                Else
                    result = True
                End If
            Next
        End If

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing
        ds.Dispose()
        ds = Nothing

        Return result
    End Function

    Public Sub UpdateUserBaseDataSync(ByVal sUsername As String)
        Try
            sLog = ""
            bErro = False

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBaseData")

            Dim sql As String


            sql = "UPDATE zSQL_USER SET zSQL_USER.BASEDATASYNC = " & util.GetDateTime() & " WHERE USERNAME = '" & sUsername & "' "
            bdconnACCESS.ExecuteNonSQL(sql)

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

        Catch ex As Exception
            bErro = True
            sLog = "Error: " & ex.Message
        End Try

    End Sub


#End Region

End Class
