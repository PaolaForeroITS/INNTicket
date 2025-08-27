Public Class frmReportMain
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            If dgvReportAdic.Rows.Count() = 0 Then
                pnlRepAdic.Visible = False
            End If
        End If
    End Sub

    Protected Sub dgvReport_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)

        If e.CommandName = "Page" Then
            Exit Sub
        End If

        ' Retrieve the row index stored in the CommandArgument property.
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)

        ' Retrieve the row that contains the button 
        ' from the Rows collection.
        Dim grd As GridView = Nothing
        grd = dgvReport

        Dim row As GridViewRow = grd.Rows(index)
        Dim sReport As String = "~/Report/Forms/" & row.Cells(0).Text & ".aspx"

        '--Opening the Eval
        Server.Transfer(sReport, True)

    End Sub

    Protected Sub dgvReportAdic_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)

        If e.CommandName = "Page" Then
            Exit Sub
        End If

        ' Retrieve the row index stored in the CommandArgument property.
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)

        ' Retrieve the row that contains the button 
        ' from the Rows collection.
        Dim grd As GridView = Nothing
        grd = dgvReportAdic

        Dim row As GridViewRow = grd.Rows(index)
        Dim sReport As String = "~/Report/Forms/" & row.Cells(0).Text & ".aspx"

        '--Opening the Eval
        Server.Transfer(sReport, True)

    End Sub

End Class