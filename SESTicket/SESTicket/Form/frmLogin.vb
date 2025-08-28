Public Class frmLogin

    Public bIsSQLConnect As Boolean
    Public sUsername As String = ""
    Public sFullName As String = ""
    Public sUserLang As String = "en-US"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        AuthUser()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AuthUser()

        If txtUsername.Text = "" Then
            MsgBox("Inform the Username", vbExclamation)
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MsgBox("Inform the Password", vbExclamation)
            Exit Sub
        End If

        sUsername = txtUsername.Text
        sFullName = ""

        Dim bdconnACCESS As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        Dim util As New clsUtils
        Dim sUsrCript As String = util.ConvertStrMD5(txtUsername.Text.ToLower)
        Dim sHN As String = util.ConvertStrMD5(Environment.MachineName)
        Dim sPasswd As String = util.ConvertStrMD5(txtPassword.Text)

        Dim ad As New clsActiveDirectory

        bdconnACCESS.OpenConnection()

        sql = "SELECT * " & _
              "FROM [USER] " & _
              "WHERE Ucase(USERNAME) = Ucase('" & txtUsername.Text & "') "

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                sUserLang = ds.Tables(0).Rows(i)("USERLANG").ToString()
                If sUserLang = "" Then
                    sUserLang = "en-US"
                End If

                If ds.Tables(0).Rows(i)("ACTIVE").ToString = "NO" Then
                    MsgBox("User is INACTIVE", vbExclamation)
                    ds.Dispose()
                    ad.Dispose()
                    ds = Nothing
                    ad = Nothing
                    bdconnACCESS.CloseConnection()
                    bdconnACCESS.Dispose()
                    bdconnACCESS = Nothing
                    Exit Sub
                Else

                    Dim ErroNum As String = ""
                    Dim ErroMsg As String = ""

                    If bIsSQLConnect = True Then

                        If ad.AuthenticUserAD(txtUsername.Text, txtPassword.Text, ErroMsg) = False Then
                            If ErroMsg.Trim <> "The server is not operational." Then
                                MsgBox("Invalid Username and/or Password. Try it Again", vbExclamation)
                                ds.Dispose()
                                ds = Nothing
                                bdconnACCESS.CloseConnection()
                                bdconnACCESS.Dispose()
                                bdconnACCESS = Nothing
                                ad.Dispose()
                                ad = Nothing
                                Exit Sub
                            End If
                        End If

                    Else

                        Dim dsPwd As New DataSet

                        sql = "SELECT COUNT(*) AS QDE FROM USERAUTH " &
                              "WHERE Ucase(USERNAME) = Ucase('" & txtUsername.Text & "') " &
                              "AND [PASSWORD] = '" & sPasswd & "' "

                        bdconnACCESS.ExecuteSQL(sql, dsPwd)

                        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
                            If dsPwd.Tables(0).Rows(j)("QDE") = 0 Then
                                MsgBox("Invalid Username and/or Password. Try it Again", vbExclamation)
                                ds.Dispose()
                                dsPwd.Dispose()
                                ds = Nothing
                                dsPwd = Nothing
                                bdconnACCESS.CloseConnection()
                                bdconnACCESS.Dispose()
                                bdconnACCESS = Nothing
                                ad.Dispose()
                                ad = Nothing
                                Exit Sub
                            End If
                        Next

                    End If

                    Dim sSavedCred As String = "NO"

                    sql = "DELETE FROM ACREDAUX"
                    bdconnACCESS.ExecuteNonSQL(sql)

                    If chkCheckCredential.Checked = True Then
                        sSavedCred = "YES"

                        sql = "INSERT INTO ACREDAUX VALUES ('" & sUsrCript & "','" & txtPassword.Text & "','" & sHN & "')"
                        bdconnACCESS.ExecuteNonSQL(sql)
                    End If

                    sql = "DELETE FROM USERAUTH  "
                    bdconnACCESS.ExecuteNonSQL(sql)

                    sql = "INSERT INTO USERAUTH VALUES ('" & txtUsername.Text.ToUpper & "','" &
                          sPasswd & "',now(),'" & sSavedCred & "','" & sUserLang & "')"
                    bdconnACCESS.ExecuteNonSQL(sql)

                    sFullName = ds.Tables(0).Rows(i)("NAME")

                End If
            Next
        Else
            MsgBox("Invalid Username. Talk with Administrator about it.", vbExclamation)
            ds.Dispose()
            ad.Dispose()
            ds = Nothing
            ad = Nothing
            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing
            Exit Sub
        End If


        ds.Dispose()
        ad.Dispose()
        ds = Nothing
        ad = Nothing
        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Me.Dispose()


    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            AuthUser()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            AuthUser()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sysVer As New clsSystemVersion
        Me.Text = "INNTicket - Version " & sysVer.SystemVersion
        sysVer.Dispose()
        sysVer = Nothing

        '--Checking credentials saved
        CheckSavedCredentials()

    End Sub

    Private Sub CheckSavedCredentials()

        Dim bdconnACCESS As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        Dim util As New clsUtils


        Try

            bdconnACCESS.OpenConnection()

            sql = "SELECT lcase(USERNAME) AS USERNAME FROM USERAUTH WHERE SAVECREDENTIAL = 'YES' "
            bdconnACCESS.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    '--Getting Password
                    Dim sHN As String = util.ConvertStrMD5(Environment.MachineName)
                    Dim sUsernameAux As String = util.ConvertStrMD5(ds.Tables(0).Rows(i)("USERNAME").ToString)
                    Dim dsPwd As New DataSet

                    sql = "SELECT [AUX1] AS AUX1 FROM ACREDAUX WHERE [ACRED1] = '" & sUsernameAux & "' and HN = '" & sHN & "'"
                    bdconnACCESS.ExecuteSQL(sql, dsPwd)

                    If dsPwd.Tables(0).Rows.Count > 0 Then
                        chkCheckCredential.Checked = True
                        txtUsername.Text = ds.Tables(0).Rows(i)("USERNAME").ToString
                        txtPassword.Text = dsPwd.Tables(0).Rows(i)("AUX1").ToString
                    Else
                        chkCheckCredential.Checked = False
                    End If
                    dsPwd.Dispose()
                    dsPwd = Nothing

                Next
            Else
                chkCheckCredential.Checked = False
            End If

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing
            ds.Dispose()
            ds = Nothing

        Catch ex As Exception
            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            bdconnACCESS = Nothing
            ds.Dispose()
            ds = Nothing
            chkCheckCredential.Checked = False
        End Try



    End Sub


End Class