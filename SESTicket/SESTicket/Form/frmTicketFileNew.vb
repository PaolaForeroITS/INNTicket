Imports System.Configuration

Public Class frmTicketFileNew

    Public sTicketId As String
    Public sUsername As String

    Public sFullFileOrig As String
    Public sFileOrigName As String

    Dim util As New clsUtils

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmTicketFileNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFile.Text = sFullFileOrig
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If MsgBox("Do you want copy this file?" + Environment.NewLine + "Remember: This file will be copied to server when connect in Superior network.", vbYesNo) = vbNo Then
            Me.Dispose()
            Exit Sub
        End If

        Try

            Me.Cursor = Cursors.WaitCursor

            'Verifing if the file exists on the base
            Dim sql As String
            Dim ds As New DataSet
            Dim bdconn As New clsBancoDadosACCESS

            bdconn.OpenConnection()

            sql = "SELECT COUNT(*) AS QDE FROM TICKETFILE " & _
                  "WHERE TICKETID = '" & sTicketId & "' " & _
                  "AND TICKETFILENAME = '" & sFileOrigName & "' AND ACTION <> 'DELETE' "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    If ds.Tables(0).Rows(i)("QDE") > 0 Then
                        Me.Cursor = Cursors.Arrow
                        MsgBox("This file already exists on Ticket", vbInformation)
                        bdconn.Dispose()
                        bdconn = Nothing
                        ds.Dispose()
                        ds = Nothing
                        Exit Sub
                    End If
                Next
            End If

            ds.Dispose()
            ds = Nothing

            'Insert new Line
            sql = "INSERT INTO TICKETFILE (TICKETFILEID,TICKETID,TICKETFILENAME," & _
                  "FILESIZE,CREATEDBY,CREATEDDATETIME, COMMENT,LOCATION, [ACTION]) VALUES ("

            sql = sql & "'" & GenerateTicketFileId() & "',"
            sql = sql & "'" & sTicketId & "',"
            sql = sql & "'" & sFileOrigName & "',"
            sql = sql & "" & CopyFileLocal().ToString & ","
            sql = sql & "'" & sUsername.ToLower & "',"
            sql = sql & "NOW(),"
            sql = sql & util.SQLConvStrNull(txtComments.Text, "s") & ","
            sql = sql & "'LOCAL','UPLOAD')"

            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Me.Cursor = Cursors.Arrow
            Me.Dispose()

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MsgBox("Error: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Function CopyFileLocal() As Double

        Try

            Dim sFilePath As String = ConfigurationManager.AppSettings("FilePath").ToString

            If (System.IO.Directory.Exists(sFilePath & "\" & sTicketId) = False) Then
                System.IO.Directory.CreateDirectory(sFilePath & "\" & sTicketId)
            End If

            'Copy new file to Destiny compacting
            Dim sFullFileName As String = sFilePath & "\" & sTicketId & "\" & sFileOrigName
            System.IO.File.Copy(sFullFileOrig, sFullFileName, True)

            Return My.Computer.FileSystem.GetFileInfo(sFullFileName).Length

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return 0
            Exit Function
        End Try

    End Function

    Private Function GenerateTicketFileId() As String
        Dim sName As String
        sName = sTicketId.Replace(".", "") & "_" & DateTime.UtcNow.ToString.Replace("/", "").Replace(":", "").Replace(" ", "")
        Return sName.Replace("PM", "").Replace("AM", "")
    End Function

End Class