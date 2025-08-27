Imports System.Configuration
Imports System.IO.Compression
Imports System.IO

Public Class clsSESTicketUpd
    Implements IDisposable

    Dim sLog As String = ""
    Public bErro As Boolean = False
    Dim sVersion As String = ""
    Dim sOldTicket As String
    Dim sReleasePathServer As String = ""

    Dim sUpdatePath As String = "C:\SESTicket\update"
    Dim sReleasePathLocal As String = sUpdatePath & "\release"
    Dim sReleasePathFile As String = ""
    Dim sReleaseFile As String = ""
    Dim sSESTicketRemote As String = ""
    Dim sSESTicketLocal As String = "C:\SESTicket"

    Dim sBkpPath As String = sUpdatePath & "\bkp"

    Public Sub Log(ByVal Log As String)
        sLog = sLog & Log & Environment.NewLine
        frmSESTicketUpd.txtLog.Text = sLog
        frmSESTicketUpd.Refresh()
    End Sub

    Public Sub Start()
        Log("Starting the process..." & DateTime.Now.ToString)
        If bErro = False Then
            GetVersion()
        End If
        If bErro = False Then
            GetOldVersion()
        End If
        If bErro = False Then
            CheckRequisites()
        End If
        If bErro = False Then
            CopyReleaseFileToLocal()
        End If
        If bErro = False Then
            TransferDataOldDbToNew()
        End If
        If bErro = False Then
            BackupSESTicketFiles()
        End If
        If bErro = False Then
            RefreshSESTicketFiles()
        End If

        Log("End process..." & DateTime.Now.ToString)

        GenerateLogFile()

        If bErro = True Then
            MsgBox("Some errors happened during the update process" & Environment.NewLine & _
                "Please, copy the text and send to Administrator", vbExclamation)
            Exit Sub
        Else
            MsgBox("The SESTicket is updated." & Environment.NewLine & "Please, open the application again.", vbInformation)
            End
        End If

    End Sub

    Public Sub GetVersion()

        Try

            Log("Getting the Version Information...")

            Dim sql As String
            Dim ds As New DataSet

            Dim bdconnSQL As New clsBancoDadosSQL
            bdconnSQL.OpenConnection()

            sql = "select VERSIONSYSTEM, 'SESTicket_v' + VERSIONSYSTEM as VERSIONNAME, REMOTEPATH,RELEASEFILE from [VERSIONSYSTEM]"

            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    sVersion = ds.Tables(0).Rows(i)("VERSIONSYSTEM").ToString()
                    sSESTicketRemote = ds.Tables(0).Rows(i)("REMOTEPATH").ToString()
                    sReleasePathServer = sSESTicketRemote & "\Release"
                    sReleaseFile = ds.Tables(0).Rows(i)("RELEASEFILE").ToString()
                    sReleasePathFile = sReleasePathLocal & "\" & ds.Tables(0).Rows(i)("VERSIONNAME").ToString()
                Next
            Else
                bErro = True
                Log("Error: Variable not set")
            End If

            ds.Dispose()
            ds.Clear()
            ds = Nothing
            bdconnSQL.CloseConnection()
            bdconnSQL.Dispose()
            bdconnSQL = Nothing

            Log("Version: " & sVersion)


        Catch ex As Exception
            bErro = True
            Log("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub GetOldVersion()

        Try

            Log("Getting the Old Version Information...")

            Dim sql As String
            Dim ds As New DataSet
            Dim bdconnACCESS As New clsBancoDadosACCESS

            bdconnACCESS.OpenConnection("C:\")

            sql = "SELECT VERSIONSYSTEM.VERSIONSYSTEM as VERSIONSYS FROM VERSIONSYSTEM"
            bdconnACCESS.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    sOldTicket = ds.Tables(0).Rows(i)("VERSIONSYS").ToString()
                Next
            Else
                bErro = True
                Log("Error: Variable not set")
            End If

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing
            ds.Dispose()
            ds = Nothing
            Log("Old Version: " & sOldTicket)

        Catch ex As Exception
            bErro = True
            Log("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub CheckRequisites()

        Try

            Log("Checking the requisites...")

            Log("Checking Log path...")
            If (Not System.IO.Directory.Exists(sUpdatePath & "\log")) Then
                System.IO.Directory.CreateDirectory(sUpdatePath & "\log")
            End If
            Log("Checking Release path...")
            If (Not System.IO.Directory.Exists(sReleasePathLocal)) Then
                System.IO.Directory.CreateDirectory(sReleasePathLocal)
            End If
            Log("Checking Bkp path...")
            If (Not System.IO.Directory.Exists(sBkpPath)) Then
                System.IO.Directory.CreateDirectory(sBkpPath)
            End If

        Catch ex As Exception
            bErro = True
            Log("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub CopyReleaseFileToLocal()

        Dim sFullFileSource As String = sReleasePathServer & "\" & sReleaseFile
        Dim sFullFileDest As String = sReleasePathLocal & "\" & sReleaseFile

        Try
            Log("Deleting previosly files...")
            If System.IO.File.Exists(sFullFileDest) = True Then
                System.IO.File.Delete(sFullFileDest)
            End If
            If System.IO.Directory.Exists(sReleasePathFile) = True Then
                System.IO.Directory.Delete(sReleasePathFile, True)
            End If

            Log("Getting the File...")
            Log("Source: " & sFullFileSource)
            Log("Destination: " & sReleasePathLocal)

            'Checking if the Release File is available on the Server
            If System.IO.File.Exists(sFullFileSource) = True Then
                System.IO.File.Copy(sFullFileSource, sFullFileDest)
            Else
                bErro = True
                Log("Error: The Release file does not Exists")
            End If

            'Uncompressing the File
            Log("Uncompressing file " & sFullFileDest & "...")
            ZipFile.ExtractToDirectory(sFullFileDest, sReleasePathFile)

        Catch ex As Exception
            bErro = True
            Log("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub TransferDataOldDbToNew()

        Dim slogRet As String = ""

        Dim cl As New clsRefreshDB
        cl.sReleasePath = Me.sReleasePathFile

        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("CONSEC", slogRet)
            Log(slogRet)
        End If
        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKET", slogRet)
            Log(slogRet)
        End If
        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKETEQUIPMENT", slogRet)
            Log(slogRet)
        End If

        If sOldTicket = "5.0.3" Or sOldTicket = "5.0.2" Or sOldTicket = "5.0.1" Then
            slogRet = ""
            If bErro = False Then
                bErro = cl.CopyTable("TICKETINVENTORY", slogRet)
                Log(slogRet)
            End If
        End If

        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKETSALESITEM", slogRet)
            Log(slogRet)
        End If
        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKETWORKER", slogRet)
            Log(slogRet)
        End If
        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKETOPEREP", slogRet)
            Log(slogRet)
        End If
        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKETOPEREPACT", slogRet)
            Log(slogRet)
        End If
        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("TICKETFILE", slogRet)
            Log(slogRet)
        End If

        If sOldTicket <> "4.0.8" Then
            slogRet = ""
            If bErro = False Then
                bErro = cl.CopyTable("TICKETSERVEVAL_HSEQ", slogRet)
                Log(slogRet)
            End If
        End If

        slogRet = ""
        If sOldTicket = "5.0.3" Or sOldTicket = "5.0.2" Or sOldTicket = "5.0.1" Then

            Try

                Dim sql As String

                Dim bdconn As New clsBancoDadosACCESS
                bdconn.OpenConnection(Me.sReleasePathFile)

                sql = "UPDATE TICKETWORKER Set HOUROPERATION=HOURQDE "
                Log("---" & sql & "---")
                bdconn.ExecuteNonSQL(sql)
                Log("---ok---")

                sql = "INSERT INTO TICKETSERVICETYPE ([TICKETSERVICETYPEID],[TICKETID],[SERVICETYPEID]) SELECT TICKETID + '.001',TICKETID,SERVICETYPEID from TICKET"
                Log("---INSERT INTO TICKETSERVICETYPE---")
                bdconn.ExecuteNonSQL(sql)
                Log("---ok---")

                sql = "INSERT INTO TICKETINVHEADER (TICKETINVHEADERID,[TICKETID] " &
                      ",[INVENTORYITEMID],[DESCRIPTION],[CREATEDUSER],[CREATEDDATETIME]) " &
                        "SELECT DISTINCT " &
                        "(SELECT MIN(TI2.TICKETINVENTORYID) " &
                        "FROM TICKETINVENTORY TI2  " &
                        "WHERE MID(TI2.TICKETINVENTORYID,1,LEN(TI2.TICKETINVENTORYID)-4) =  " &
                        "MID(TI.TICKETINVENTORYID,1,LEN(TI.TICKETINVENTORYID)-4) " &
                        "AND TI.INVENTORYITEMID = TI2.INVENTORYITEMID) " &
                        ",MID(TI.TICKETINVENTORYID,1,LEN(TI.TICKETINVENTORYID)-4) AS TICKETID " &
                        ",TI.INVENTORYITEMID " &
                        ",TI.[DESCRIPTION] " &
                        ",TI.[CREATEDUSER] " &
                        ",NOW() " &
                        "FROM TICKETINVENTORY TI "

                Log("---INSERT INTO TICKETINVHEADER---")
                bdconn.ExecuteNonSQL(sql)
                Log("---ok---")

                sql = "INSERT INTO TICKETINVLINE " &
                    "(TICKETINVLINEID,TICKETINVHEADERID,[TICKETSALESITEMID] " &
                    ",[ITEMQTY],[COMMENTS],[CREATEDUSER],[CREATEDDATETIME] " &
                    ",[UPDATEDDATETIME],[UPDATEDUSER]) " &
                    "SELECT TI.TICKETINVENTORYID AS TICKETINVLINEID " &
                    ",(SELECT TI2.TICKETINVHEADERID FROM TICKETINVHEADER TI2 " &
                    "WHERE TI2.TICKETID = MID(TI.TICKETINVENTORYID,1,LEN(TI.TICKETINVENTORYID)-4) " &
                    "AND TI.INVENTORYITEMID = TI2.INVENTORYITEMID " &
                    ") AS TICKETINVHEADERID " &
                    ",TI.TICKETSALESITEMID  " &
                    ",TI.ITEMQTY  " &
                    ",TI.COMMENTS  " &
                    ",TI.CREATEDUSER  " &
                    ",TI.CREATEDDATETIME  " &
                    ",TI.[UPDATEDDATETIME]  " &
                    ",TI.UPDATEDUSER  " &
                    "FROM [TICKETINVENTORY] TI "

                Log("---INSERT INTO TICKETINVLINE---")
                bdconn.ExecuteNonSQL(sql)
                Log("---ok---")


                Log("---UPDATE TICKETINVHEADER SET CONSUMPTION---")
                Dim ds As New DataSet

                sql = "SELECT TICKETINVLINE.TICKETINVHEADERID, Sum(TICKETINVLINE.ITEMQTY) AS QTY " &
                    "FROM TICKETINVLINE " &
                    "GROUP BY TICKETINVLINE.TICKETINVHEADERID"
                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        sql = "UPDATE TICKETINVHEADER SET " &
                            "CONSUMPTION = " & ds.Tables(0).Rows(i)("QTY").ToString.Replace(",", ".") & " " &
                            "WHERE TICKETINVHEADERID = '" & ds.Tables(0).Rows(i)("TICKETINVHEADERID") & "' "
                        bdconn.ExecuteNonSQL(sql)
                    Next
                End If
                ds.Dispose()
                ds = Nothing
                Log("---ok---")

                Log("---UPDATE TICKET SET SERVICELINEID---")
                ds = New DataSet

                sql = "SELECT CONTRACTID,SERVICELINEID " &
                    "FROM CONTRACT "
                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        sql = "UPDATE TICKET SET " &
                            "SERVICELINEID = " & ds.Tables(0).Rows(i)("SERVICELINEID") & " " &
                            "WHERE CONTRACTID = " & ds.Tables(0).Rows(i)("CONTRACTID") & " "
                        bdconn.ExecuteNonSQL(sql)
                    Next
                End If
                ds.Dispose()
                ds = Nothing
                Log("---ok---")


                Log("---UPDATE TICKET SET SYNCDATETIME = now(), SyncDB=FALSE---")
                sql = "UPDATE TICKET SET SYNCDATETIME = now(), SyncDB=FALSE "
                bdconn.ExecuteNonSQL(sql)
                Log("---ok---")

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

            Catch ex As Exception
                bErro = True
                slogRet = ex.Message
                Log(ex.Message)
            End Try

        End If

        slogRet = ""
        If sOldTicket = "6.0.0" Or sOldTicket = "6.0.1" Or sOldTicket = "6.0.2" Or sOldTicket = "6.0.3" Then

            Try
                Dim sql As String

                Dim bdconn As New clsBancoDadosACCESS
                bdconn.OpenConnection(Me.sReleasePathFile)


                Log("---UPDATE TICKET SET SITEID---")
                Dim ds As New DataSet

                sql = "SELECT TICKET.TICKETID, SITE.SITEID " &
                     "FROM (TICKET INNER JOIN WELL ON TICKET.WELLID = WELL.WELLID) INNER JOIN SITE ON WELL.SITEID = SITE.SITEID"

                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        sql = "UPDATE TICKET SET " &
                            "SITEID = '" & ds.Tables(0).Rows(i)("SITEID") & "' " &
                            ",[HOURTRAVEL]=0,[HOUROPERATION]=0,[HOURSTANDBY]=0,[HOURLOST]=0,[HOURQDE]=0 " &
                            "WHERE TICKETID = '" & ds.Tables(0).Rows(i)("TICKETID") & "' "
                        bdconn.ExecuteNonSQL(sql)
                    Next
                End If
                ds.Dispose()
                ds = Nothing
                Log("---ok---")


                Log("---UPDATE TICKET SET SYNCDATETIME = now(), SyncDB=FALSE---")
                sql = "UPDATE TICKET SET SYNCDATETIME = now(), SyncDB=FALSE "
                bdconn.ExecuteNonSQL(sql)
                Log("---ok---")

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

            Catch ex As Exception
                bErro = True
                slogRet = ex.Message
                Log(ex.Message)
            End Try

        End If

        If sOldTicket = "6.0.0" Or sOldTicket = "6.0.1" Or sOldTicket = "6.0.2" Or sOldTicket = "6.0.3" Or sOldTicket = "6.0.4" Then

            Dim sql As String

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection(Me.sReleasePathFile)

            Try

                Log("---UPDATE TICKETEQUIPMENT---")
                Dim ds As New DataSet

                sql = "SELECT TICKETID,EQUIPMENTID " &
                "From [TICKETEQUIPMENT] " &
                "WHERE " &
                "TICKETEQUIPMENTID IS NULL " &
                "ORDER BY TICKETID"

                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                        Dim sSeq As String = Me.TicketEquipmentNextId(ds.Tables(0).Rows(i)("TICKETID"))

                        sql = "UPDATE TICKETEQUIPMENT SET TICKETEQUIPMENTID = '" & sSeq & "', CONSUMPTION = 0 " &
                            "WHERE TICKETID='" & ds.Tables(0).Rows(i)("TICKETID") & "' " &
                            "AND EQUIPMENTID = '" & ds.Tables(0).Rows(i)("EQUIPMENTID") & "'"
                        bdconn.ExecuteNonSQL(sql)
                    Next
                End If
                ds.Dispose()
                ds = Nothing
                Log("---ok---")

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

            Catch ex As Exception
                bErro = True
                slogRet = ex.Message
                Log(ex.Message)
            End Try

        End If

        If sOldTicket = "6.0.0" Or sOldTicket = "6.0.1" Or sOldTicket = "6.0.2" Or sOldTicket = "6.0.3" Or sOldTicket = "6.0.4" Or sOldTicket = "7.0.0" Then

            Dim sql As String

            Dim bdconn As New clsBancoDadosACCESS
            bdconn.OpenConnection(Me.sReleasePathFile)

            Try

                Log("---UPDATE TICKET CLOSED---")

                sql = "UPDATE TICKET SET CLOSEDDATE=DATESERVICE, CLOSEDUSER=CREATEDUSER " &
                      " WHERE TICKETSTATUS='Closed'"
                bdconn.ExecuteNonSQL(sql)

                Log("---ok---")

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

            Catch ex As Exception
                bErro = True
                slogRet = ex.Message
                Log(ex.Message)
            End Try

        End If

        slogRet = ""
        If sOldTicket <> "5.0.3" And sOldTicket <> "5.0.2" And sOldTicket <> "5.0.1" Then
            slogRet = ""
            If bErro = False Then
                bErro = cl.CopyTable("TICKETSERVICETYPE", slogRet)
                Log(slogRet)
            End If
            slogRet = ""
            If bErro = False Then
                bErro = cl.CopyTable("TICKETINVHEADER", slogRet)
                Log(slogRet)
            End If
            If bErro = False Then
                bErro = cl.CopyTable("TICKETINVLINE", slogRet)
                Log(slogRet)
            End If
            If bErro = False Then
                bErro = cl.CopyTable("TICKETINVADIC", slogRet)
                Log(slogRet)
            End If
        End If

        slogRet = ""
        If bErro = False Then
            bErro = cl.CopyTable("USERAUTH", slogRet)
            Log(slogRet)
        End If
        cl.Dispose()
        cl = Nothing

    End Sub

    Private Sub BackupSESTicketFiles()

        Try
            Dim sBackupDest As String = sBkpPath & "\bkp_" & DateTime.Now.ToString("ddMMyyyy_HHmmss")

            Log("Creating a Backup Folder " & sBackupDest)
            If System.IO.Directory.Exists(sBackupDest) = False Then
                System.IO.Directory.CreateDirectory(sBackupDest)
                System.IO.Directory.CreateDirectory(sBackupDest & "\app")
                System.IO.Directory.CreateDirectory(sBackupDest & "\data")
            End If

            Log("Backup app Folder...")
            If System.IO.Directory.Exists(sSESTicketLocal & "\app") = True Then
                My.Computer.FileSystem.CopyDirectory(sSESTicketLocal & "\app", sBackupDest & "\app")
            End If

            Log("Backup data Folder...")
            If System.IO.Directory.Exists(sSESTicketLocal & "\data") = True Then
                My.Computer.FileSystem.CopyDirectory(sSESTicketLocal & "\data", sBackupDest & "\data")
            End If

        Catch ex As Exception
            bErro = True
            Log("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub RefreshSESTicketFiles()

        Try
            Log("Updating app Folder...")
            If System.IO.Directory.Exists(sSESTicketLocal & "\app") = True Then
                My.Computer.FileSystem.CopyDirectory(sReleasePathFile & "\SESTicket\app", sSESTicketLocal & "\app", True)
            End If

            Log("Updating data Folder...")
            If System.IO.Directory.Exists(sSESTicketLocal & "\data") = True Then
                My.Computer.FileSystem.CopyDirectory(sReleasePathFile & "\SESTicket\data", sSESTicketLocal & "\data", True)
            End If

        Catch ex As Exception
            bErro = True
            Log("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub GenerateLogFile()

        Try

            If System.IO.Directory.Exists(sUpdatePath & "\log") = False Then
                System.IO.Directory.CreateDirectory(sUpdatePath & "\log")
            End If

            Dim LogFile As String = sUpdatePath & "\log\log_" & DateTime.Now.ToString("ddMMyyyy_HHmmss") & ".txt"

            Dim oWrite As System.IO.StreamWriter
            oWrite = File.CreateText(LogFile)
            oWrite.WriteLine(sLog)
            oWrite.Close()
            oWrite = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


#Region "Temporary Methods"
    Public Function TicketEquipmentNextId(ByVal sTicketId As String) As String

        Dim sSequence As String = 0

        Dim sql As String
        Dim ds As New DataSet

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection(Me.sReleasePathFile)

        sql = "SELECT Max(CInt(Right(IIF(TICKETEQUIPMENTID IS NULL,0,TICKETEQUIPMENTID),3)))+1 as NEWID " &
              "FROM [TICKETEQUIPMENT] " &
              "WHERE " &
              "TICKETID = '" & sTicketId & "'"

        bdconn.ExecuteSQL(sql, ds)

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
        ds.Clear()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Return sSequence

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
