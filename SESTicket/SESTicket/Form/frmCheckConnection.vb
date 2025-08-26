Imports System.Configuration

Public Class frmCheckConnection

    Public bIsSQLConnect As Boolean = False

    Private Sub frmCheckConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Refresh()
        CheckPaths()
        TestConnection()

    End Sub

    Private Sub CheckPaths()

        Me.Cursor = Cursors.WaitCursor

        lblMessage.Text = "Checking Path. Please wait."
        Me.Refresh()

        Dim sPathTmp As String = ConfigurationManager.AppSettings("FilePath").ToString & "\tmp"
        If (Not System.IO.Directory.Exists(sPathTmp)) Then
            System.IO.Directory.CreateDirectory(sPathTmp)
        End If

        lblMessage.Text = "Deleting Temporary Files. Please wait."
        Me.Refresh()

        Try

            Dim arrStr As String() = {}
            arrStr = System.IO.Directory.GetFiles(sPathTmp, "*.docx")

            For i As Integer = 0 To arrStr.Length - 1
                Try
                    System.IO.File.Delete(arrStr(i))
                Catch ExIO As Exception
                    Debug.Print(ExIO.Message)
                End Try
            Next i

        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub TestConnection()
        Me.Cursor = Cursors.WaitCursor

        lblMessage.Text = "Checking your connection. Please wait."
        Me.Refresh()

        Dim TestConn As New clsBancoDadosACCESS

        If TestConn.IsSQLOnline = True Then
            Try

                lblMessage.Text = "Checking your version. Please wait."
                Me.Refresh()

                Dim sCheckVersion As String = ConfigurationManager.AppSettings("CheckVersion").ToString

                If LCase(sCheckVersion) = "true" Then
                    Dim sysVer As New clsSystemVersion
                    sysVer.isSQLConnect = True

                    If sysVer.isAppVersionUpdated = False Then
                        If MsgBox("You App version is Out-to-Date." & Chr(10) & "The update is strongly recomended." & Chr(10) & "Do you want update the system?", vbYesNo) = vbYes Then
                            Process.Start(sysVer.sAppUpdLocal & "\SESTicketUpd.exe")
                            End
                        End If
                    End If
                    sysVer.Dispose()
                    sysVer = Nothing
                End If

                lblMessage.Text = "Refreshing User information. Please wait."
                Me.Refresh()
                Dim sync As New clsSyncBaseData
                sync.User()
                If sync.bErro = True Then
                    MsgBox("Some error ocurred during USER update:" & sync.sLog, vbExclamation)
                End If
                sync.Dispose()
                sync = Nothing

                Dim synAttach As New clsSyncTicketAttach
                synAttach.StopSync()
                synAttach.Dispose()
                synAttach = Nothing

                bIsSQLConnect = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            bIsSQLConnect = False
            MsgBox("You are not connected!" & Chr(10) & "The network connect is necessary to data synchronize." & Chr(10) & "The Tickets information will storage only on your local machine.", vbInformation)
        End If

        TestConn.Dispose()
        TestConn = Nothing
        Me.Cursor = Cursors.Arrow
        Me.Dispose()

    End Sub




End Class