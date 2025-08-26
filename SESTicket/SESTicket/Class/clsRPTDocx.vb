Imports System.Configuration
Imports Word = Microsoft.Office.Interop.Word

Public Class clsRPTDocx

    Implements IDisposable

    Dim sFilePathTmp As String = ConfigurationManager.AppSettings("FilePath").ToString & "\tmp"
    Dim util As New clsUtils

    Public Sub ActStartFinishOpe(ByVal sType As String, ByVal sTicketId As String)

        Dim sFileOrig As String
        Dim sNewName As String = sFilePathTmp & "\" & Replace(System.Guid.NewGuid.ToString, "-", "") & ".docx"

        If sType = "ActStart" Then
            sFileOrig = "C:\SESTicket\app\Reports\docx\CEM-CO-SOP-09-SCF-06-StartOperation.docx"

        ElseIf sType = "ActFinish" Then
            sFileOrig = "C:\SESTicket\app\Reports\docx\CEM-CO-SOP-09-SCF-06-FinishOperation.docx"
        Else
            Exit Sub
        End If

        System.IO.File.Copy(sFileOrig, sNewName)

        Dim bdconnACCESS As New clsBancoDadosACCESS
        bdconnACCESS.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = False

        sql = "SELECT " & _
            " TICKET.TIMESTARTED   AS DATESTART " & _
            ",TICKET.TIMECOMPLETED AS DATEFINISH " & _
            ",WELL.NAME            AS WELL " & _
            ",TICKET.CUSTREPRES    AS CUSTREPRES " & _
            ",TICKET.CUSTREPRESPOSITION AS CUSTREPRESPOS " & _
            ",CONTRACT.CONTRACTNUMBER AS CONTRACTNUM " & _
            ",CONTRACT.DESCRIPTION AS CONTRACTDESCRIP " & _
            ",(WORKER.[NAME1] + ' ' + WORKER.[SURNAME1])  AS CONTRACTORREPRES " & _
            ",WORKER.APPOINTMENT AS CONTRACTORREPRESPOS " & _
            ",CUSTOMER.NAME AS CUSTOMERNAME " & _
            ",TICKET.JOBDESCRIPTION " & _
            "FROM (((TICKET INNER JOIN WELL ON TICKET.WELLID = WELL.WELLID)  " & _
            "INNER JOIN CONTRACT ON TICKET.CONTRACTID = CONTRACT.CONTRACTID)  " & _
            "INNER JOIN CUSTOMER ON TICKET.CUSTOMERID = CUSTOMER.CUSTOMERID)  " & _
            "INNER JOIN WORKER ON TICKET.CONTRACTORREPRESENTATIVE = WORKER.WORKERID " & _
            "WHERE TICKET.TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then

            Dim objWordApp As New Word.Application

            'Open an existing document.  
            Dim objDoc As Word.Document = objWordApp.Documents.Open(sNewName)
            objDoc = objWordApp.ActiveDocument

            objWordApp.Visible = False

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                Dim sValue As String
                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("JOBDESCRIPTION").ToString)

                objDoc.Content.Find.Execute(FindText:="@DESCRIPOPE", ReplaceWith:=sValue.ToUpper, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = ds.Tables(0).Rows(i)("CUSTOMERNAME")
                objDoc.Content.Find.Execute(FindText:="@CUSTOMERNAME", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = DateExten(ds.Tables(0).Rows(i)("DATESTART"))
                objDoc.Content.Find.Execute(FindText:="@DATESTART", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = DateExten(ds.Tables(0).Rows(i)("DATEFINISH"))
                objDoc.Content.Find.Execute(FindText:="@DATEFINISH", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("WELL"))
                objDoc.Content.Find.Execute(FindText:="@WELL", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRESPOS"))
                objDoc.Content.Find.Execute(FindText:="@CUSTREPRESPOS", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRES"))
                objDoc.Content.Find.Execute(FindText:="@CUSTREPRES", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTNUM"))
                objDoc.Content.Find.Execute(FindText:="@CONTRACTNUM", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTDESCRIP"))
                objDoc.Content.Find.Execute(FindText:="@CONTRACTDESCRIP", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTORREPRESPOS"))
                objDoc.Content.Find.Execute(FindText:="@CONTRACTORREPRESPOS", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTORREPRES"))
                objDoc.Content.Find.Execute(FindText:="@CONTRACTORREPRES", ReplaceWith:=sValue, Replace:=Word.WdReplace.wdReplaceAll)
                While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
                    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
                End While

            Next

            objDoc.Save()
            objDoc.Close()
            objDoc = Nothing
            objWordApp.Quit()
            objWordApp = Nothing

            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objDoc)

            Process.Start(sNewName)

        End If

        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        ds.Dispose()

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
