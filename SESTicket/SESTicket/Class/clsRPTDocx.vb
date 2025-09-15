Imports System.Configuration
Imports Word = Microsoft.Office.Interop.Word

Public Class clsRPTDocx

    Implements IDisposable

    Dim sFilePathTmp As String = ConfigurationManager.AppSettings("FilePath").ToString & "\tmp"
    Dim util As New clsUtils

    'Public Sub ActStartFinishOpe(ByVal sType As String, ByVal sTicketId As String)

    '    Try
    '        Dim sFileOrig As String
    '        Dim sNewName As String = sFilePathTmp & "\" & Replace(System.Guid.NewGuid.ToString, "-", "") & ".docx"

    '        If sType = "ActStart" Then
    '            sFileOrig = "C:\SESTicket\app\Reports\docx\CEM-CO-SOP-09-SCF-06-StartOperation.docx"

    '        ElseIf sType = "ActFinish" Then
    '            sFileOrig = "C:\SESTicket\app\Reports\docx\CEM-CO-SOP-09-SCF-06-FinishOperation.docx"
    '        Else
    '            Exit Sub
    '        End If

    '        System.IO.File.Copy(sFileOrig, sNewName)

    '        Dim bdconnACCESS As New clsBancoDadosACCESS
    '        bdconnACCESS.OpenConnection()

    '        Dim sql As String
    '        Dim ds As New DataSet
    '        Dim result As Boolean = False

    '        sql = "SELECT " &
    '            " TICKET.TIMESTARTED   AS DATESTART " &
    '            ",TICKET.TIMECOMPLETED AS DATEFINISH " &
    '            ",WELL.NAME            AS WELL " &
    '            ",TICKET.CUSTREPRES    AS CUSTREPRES " &
    '            ",TICKET.CUSTREPRESPOSITION AS CUSTREPRESPOS " &
    '            ",CONTRACT.CONTRACTNUMBER AS CONTRACTNUM " &
    '            ",CONTRACT.DESCRIPTION AS CONTRACTDESCRIP " &
    '            ",(WORKER.[NAME1] + ' ' + WORKER.[SURNAME1])  AS CONTRACTORREPRES " &
    '            ",WORKER.APPOINTMENT AS CONTRACTORREPRESPOS " &
    '            ",CUSTOMER.NAME AS CUSTOMERNAME " &
    '            ",TICKET.JOBDESCRIPTION " &
    '            "FROM (((TICKET INNER JOIN WELL ON TICKET.WELLID = WELL.WELLID)  " &
    '            "INNER JOIN CONTRACT ON TICKET.CONTRACTID = CONTRACT.CONTRACTID)  " &
    '            "INNER JOIN CUSTOMER ON TICKET.CUSTOMERID = CUSTOMER.CUSTOMERID)  " &
    '            "INNER JOIN WORKER ON TICKET.CONTRACTORREPRESENTATIVE = WORKER.WORKERID " &
    '            "WHERE TICKET.TICKETID = '" & sTicketId & "'"

    '        bdconnACCESS.ExecuteSQL(sql, ds)

    '        If ds.Tables(0).Rows.Count > 0 Then

    '            Dim objWordApp As New Word.Application

    '            'Open an existing document.  
    '            Dim objDoc As Word.Document = objWordApp.Documents.Open(sNewName)
    '            objDoc = objWordApp.ActiveDocument

    '            objWordApp.Visible = False

    '            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

    '                Dim sValue As String
    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("JOBDESCRIPTION").ToString)

    '                objDoc.Content.Find.Execute(FindText:="@DESCRIPOPE", ReplaceWith:=sValue.ToUpper, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = ds.Tables(0).Rows(i)("CUSTOMERNAME")
    '                objDoc.Content.Find.Execute(FindText:="@CUSTOMERNAME", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = DateExten(ds.Tables(0).Rows(i)("DATESTART"))
    '                objDoc.Content.Find.Execute(FindText:="@DATESTART", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = DateExten(ds.Tables(0).Rows(i)("DATEFINISH"))
    '                objDoc.Content.Find.Execute(FindText:="@DATEFINISH", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("WELL"))
    '                objDoc.Content.Find.Execute(FindText:="@WELL", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRESPOS"))
    '                objDoc.Content.Find.Execute(FindText:="@CUSTREPRESPOS", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRES"))
    '                objDoc.Content.Find.Execute(FindText:="@CUSTREPRES", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTNUM"))
    '                objDoc.Content.Find.Execute(FindText:="@CONTRACTNUM", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTDESCRIP"))
    '                objDoc.Content.Find.Execute(FindText:="@CONTRACTDESCRIP", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTORREPRESPOS"))
    '                objDoc.Content.Find.Execute(FindText:="@CONTRACTORREPRESPOS", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTORREPRES"))
    '                objDoc.Content.Find.Execute(FindText:="@CONTRACTORREPRES", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
    '                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
    '                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
    '                End While

    '            Next

    '            objDoc.Save()
    '            objDoc.Close()
    '            objDoc = Nothing
    '            objWordApp.Quit()
    '            objWordApp = Nothing

    '            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objDoc)

    '            Process.Start(sNewName)

    '        End If

    '        bdconnACCESS.CloseConnection()
    '        bdconnACCESS.Dispose()
    '        ds.Dispose()

    '    Catch ex As Exception
    '        Console.WriteLine("Error: " & ex.Message)
    '        Console.WriteLine("StackTrace: " & ex.StackTrace)
    '    End Try

    'End Sub

    Public Sub ActStartFinishOpe(ByVal sType As String, ByVal sTicketId As String)
        Dim objWordApp As Word.Application = Nothing
        Dim objDoc As Word.Document = Nothing

        Try
            Dim sFileOrig As String
            Dim sNewName As String = sFilePathTmp & "\" & Replace(System.Guid.NewGuid.ToString, "-", "") & ".docx"

            If sType = "ActStart" Then
                sFileOrig = "C:\SESTicket\app\Reports\docx\CEM-CO-SOP-09-SCF-06-StartOperation.docx"
            ElseIf sType = "ActFinish" Then
                sFileOrig = "C:\SESTicket\app\Reports\docx\CEM-CO-SOP-09-SCF-06-FinishOperation.docx"
            Else
                Exit Sub
            End If

            System.IO.File.Copy(sFileOrig, sNewName, True)

            Dim bdconnACCESS As New clsBancoDadosACCESS
            bdconnACCESS.OpenConnection()

            Dim sql As String = "SELECT " &
            " TICKET.TIMESTARTED   AS DATESTART " &
            ",TICKET.TIMECOMPLETED AS DATEFINISH " &
            ",WELL.NAME            AS WELL " &
            ",TICKET.CUSTREPRES    AS CUSTREPRES " &
            ",TICKET.CUSTREPRESPOSITION AS CUSTREPRESPOS " &
            ",CONTRACT.CONTRACTNUMBER AS CONTRACTNUM " &
            ",CONTRACT.DESCRIPTION AS CONTRACTDESCRIP " &
            ",(WORKER.[NAME1] + ' ' + WORKER.[SURNAME1])  AS CONTRACTORREPRES " &
            ",WORKER.APPOINTMENT AS CONTRACTORREPRESPOS " &
            ",CUSTOMER.NAME AS CUSTOMERNAME " &
            ",TICKET.JOBDESCRIPTION " &
            "FROM (((TICKET INNER JOIN WELL ON TICKET.WELLID = WELL.WELLID)  " &
            "INNER JOIN CONTRACT ON TICKET.CONTRACTID = CONTRACT.CONTRACTID)  " &
            "INNER JOIN CUSTOMER ON TICKET.CUSTOMERID = CUSTOMER.CUSTOMERID)  " &
            "INNER JOIN WORKER ON TICKET.CONTRACTORREPRESENTATIVE = WORKER.WORKERID " &
            "WHERE TICKET.TICKETID = '" & sTicketId & "'"

            Dim ds As New DataSet
            bdconnACCESS.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                objWordApp = New Word.Application
                objWordApp.Visible = False

                objDoc = objWordApp.Documents.Open(sNewName)

                Dim row = ds.Tables(0).Rows(0)

                ' --- Reemplazos directos SIN bucle While ---
                ReplaceText(objDoc, "@DESCRIPOPE", util.TrataDBNull(row("JOBDESCRIPTION")).ToString.ToUpper)
                ReplaceText(objDoc, "@CUSTOMERNAME", row("CUSTOMERNAME").ToString)
                ReplaceText(objDoc, "@DATESTART", DateExten(row("DATESTART")))
                ReplaceText(objDoc, "@DATEFINISH", DateExten(row("DATEFINISH")))
                ReplaceText(objDoc, "@WELL", util.TrataDBNull(row("WELL")))
                ReplaceText(objDoc, "@CUSTREPRESPOS", util.TrataDBNull(row("CUSTREPRESPOS")))
                ReplaceText(objDoc, "@CUSTREPRES", util.TrataDBNull(row("CUSTREPRES")))
                ReplaceText(objDoc, "@CONTRACTNUM", util.TrataDBNull(row("CONTRACTNUM")))
                ReplaceText(objDoc, "@CONTRACTDESCRIP", util.TrataDBNull(row("CONTRACTDESCRIP")))
                ReplaceText(objDoc, "@CONTRACTORREPRESPOS", util.TrataDBNull(row("CONTRACTORREPRESPOS")))
                ReplaceText(objDoc, "@CONTRACTORREPRES", util.TrataDBNull(row("CONTRACTORREPRES")))

                objDoc.Save()
                objDoc.Close(False)
                Runtime.InteropServices.Marshal.ReleaseComObject(objDoc)
                objDoc = Nothing

                objWordApp.Quit()
                Runtime.InteropServices.Marshal.ReleaseComObject(objWordApp)
                objWordApp = Nothing

                GC.Collect()
                GC.WaitForPendingFinalizers()

                ' Ahora que Word está cerrado, abrimos el archivo
                Process.Start(sNewName)
            End If

            bdconnACCESS.CloseConnection()
            bdconnACCESS.Dispose()
            ds.Dispose()

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.WriteLine("StackTrace: " & ex.StackTrace)

            If objDoc IsNot Nothing Then
                objDoc.Close(False)
                Runtime.InteropServices.Marshal.ReleaseComObject(objDoc)
            End If
            If objWordApp IsNot Nothing Then
                objWordApp.Quit()
                Runtime.InteropServices.Marshal.ReleaseComObject(objWordApp)
            End If
        End Try
    End Sub

    ' Método auxiliar para simplificar los reemplazos
    Private Sub ReplaceText(doc As Word.Document, findText As String, replaceWith As String)
        doc.Content.Find.Execute(FindText:=findText,
                             ReplaceWith:=replaceWith,
                             Replace:=Word.WdReplace.wdReplaceAll,
                             Wrap:=Word.WdFindWrap.wdFindContinue)
    End Sub


    Public Function DateExten(ByVal dDate As Date) As String

        Dim sExt As String

        sExt = dDate.ToString("dd")

        If Month(dDate) = 1 Then
            sExt = sExt & " de Enero del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 2 Then
            sExt = sExt & " de Febrero del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 3 Then
            sExt = sExt & " de Marzo del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 4 Then
            sExt = sExt & " de Abril del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 5 Then
            sExt = sExt & " de Mayo del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 6 Then
            sExt = sExt & " de Junio del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 7 Then
            sExt = sExt & " de Julio del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 8 Then
            sExt = sExt & " de Agosto del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 9 Then
            sExt = sExt & " de Septiembre del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 10 Then
            sExt = sExt & " de Octubre del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 11 Then
            sExt = sExt & " de Noviembre del " & dDate.ToString("yyyy")
        ElseIf Month(dDate) = 12 Then
            sExt = sExt & " de Diciembre del " & dDate.ToString("yyyy")
        End If

        Return sExt
    End Function


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
