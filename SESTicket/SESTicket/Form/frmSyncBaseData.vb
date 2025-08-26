Public Class frmSyncBaseData

    Public sUsername As String
    Dim slog As String

    Private Sub frmSyncBaseData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClose.Visible = False
        Me.Show()
        Me.Start()
    End Sub

    Public Sub Log(ByVal Log As String, Optional ByVal bNewLine As Boolean = False)
        slog = slog & Log
        If bNewLine = True Then
            slog = slog & Environment.NewLine
        End If
        txtLog.Text = slog
        Me.Refresh()
    End Sub

    Public Sub Start()
        Try

            Me.Cursor = Cursors.WaitCursor
            Me.Refresh()

            Dim sync As New clsSyncBaseData
            Log("Starting the process..." & DateTime.Now.ToString, True)
            Log("--------------------------------------", True)
            Log("Checking changes...", True)

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection("AccBaseData")

            Dim sql As String
            Dim ds As New DataSet
            Dim result As Boolean = False

            sql = "SELECT BASEDATATABLE_V.TABLENAME  " & _
                  "FROM BASEDATATABLE_V  " & _
                  "WHERE (((BASEDATATABLE_V.UPDATED)=0))"

            bdconnACCESS.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then

                Dim sTableName As String = ""

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    sTableName = ds.Tables(0).Rows(i)("TABLENAME")

                    If sTableName = "WORKER" Then
                        If sync.bErro = False Then
                            Log("Updating WORKER table...")
                            sync.Worker()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "SITE" Then
                        If sync.bErro = False Then
                            Log("Updating SITE table...")
                            sync.Site()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "CASING" Then
                        If sync.bErro = False Then
                            Log("Updating CASING table...")
                            sync.Casing()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "REPORTPARAM" Then
                        If sync.bErro = False Then
                            Log("Updating REPORTPARAM table...")
                            sync.ReportParam()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "CONTRACT" Then
                        If sync.bErro = False Then
                            Log("Updating CONTRACT table...")
                            sync.Contract()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "CONTRACTPRICELIST" Then
                        If sync.bErro = False Then
                            Log("Updating CONTRACTPRICELIST table...")
                            sync.ContractPriceList()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                UpdateCustCodeItemLocal()
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "CONTRACTAIUINVENTORYCLASS" Then
                        If sync.bErro = False Then
                            Log("Updating CONTRACTAIUINVENTORYCLASS table...")
                            sync.ContractAIUInventoryClass()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If

                    ElseIf sTableName = "CONTRACTREPLAYOUT" Then
                        If sync.bErro = False Then
                            Log("Updating CONTRACTREPLAYOUT table...")
                            sync.ContractRepLayout()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If

                    ElseIf sTableName = "CUSTOMER" Then
                        If sync.bErro = False Then
                            Log("Updating CUSTOMER table...")
                            sync.Customer()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "EQUIPMENT" Then
                        If sync.bErro = False Then
                            Log("Updating EQUIPMENT table...")
                            sync.Equipment()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "INVENTORYCLASS" Then
                        If sync.bErro = False Then
                            Log("Updating INVENTORYCLASS table...")
                            sync.InventoryClass()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "INVENTORYITEM" Then
                        If sync.bErro = False Then
                            Log("Updating INVENTORYITEM table...")
                            sync.InventoryItem()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "INVENTORYUNIT" Then
                        If sync.bErro = False Then
                            Log("Updating INVENTORYUNIT table...")
                            sync.InventoryUnit()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "PETRFIELD" Then
                        If sync.bErro = False Then
                            Log("Updating PETRFIELD table...")
                            sync.PetrField()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "SERVICETYPE" Then
                        If sync.bErro = False Then
                            Log("Updating SERVICETYPE table...")
                            sync.ServiceType()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "TUBING" Then
                        If sync.bErro = False Then
                            Log("Updating TUBING table...")
                            sync.Tubing()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "WELL" Then
                        If sync.bErro = False Then
                            Log("Updating WELL table...")
                            sync.Well()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "USER" Then
                        If sync.bErro = False Then
                            Log("Updating USER table...")
                            sync.User()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "SERVICELINE" Then
                        If sync.bErro = False Then
                            Log("Updating SERVICELINE table...")
                            sync.ServiceLine()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    ElseIf sTableName = "RIG" Then
                        If sync.bErro = False Then
                            Log("Updating RIG table...")
                            sync.Rig()
                            If sync.bErro = True Then
                                Log(sync.sLog, True)
                            Else
                                Log("Ok", True)
                            End If
                        End If
                    End If

                Next
            End If

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing

            ds.Dispose()
            ds = Nothing

            If sync.bErro = False Then
                Log("Updating CONSEC table...")
                sync.Consec(frmMain.sUsername)
                If sync.bErro = True Then
                    Log(sync.sLog, True)
                Else
                    Log("Ok", True)
                End If
            End If
            If sync.bErro = False Then
                Log("Updating Local BASESYNCDATETIME...")
                sync.UpdateDatetimeBaseSync()
                If sync.bErro = True Then
                    Log(sync.sLog, True)
                Else
                    Log("Ok", True)
                End If
            End If
            If sync.bErro = False Then
                Log("Updating USER BaseDataSync...")
                sync.UpdateUserBaseDataSync(frmMain.sUsername)
                If sync.bErro = True Then
                    Log(sync.sLog, True)
                Else
                    Log("Ok", True)
                End If
            End If

            Log("--------------------------------------", True)
            Log("End process..." & DateTime.Now.ToString)

            Me.Cursor = Cursors.Arrow
            Me.Refresh()

            If sync.bErro = False Then
                MsgBox("BaseData Synchronized", vbInformation)
                Me.Dispose()
            Else
                btnClose.Visible = True
                MsgBox("Some erros ocurred during the process. Contact the Administrator", vbExclamation)
            End If

            sync.Dispose()
            sync = Nothing

        Catch ex As Exception
            btnClose.Visible = True
            Me.Cursor = Cursors.Arrow
            Log(ex.Message)
            MsgBox("Some erros ocurred during the process. Contact the Administrator", vbExclamation)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub UpdateCustCodeItemLocal()
        Dim sync2 As New clsSyncTicket
        sync2.UpdateCustCodeItemLocal()
        sync2.Dispose()
        sync2 = Nothing
    End Sub
End Class