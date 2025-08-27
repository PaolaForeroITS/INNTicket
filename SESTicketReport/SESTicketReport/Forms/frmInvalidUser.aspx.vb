Public Class frmInvalidUser
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblUser.Text = "User: " & System.Security.Principal.WindowsIdentity.GetCurrent().Name
    End Sub

End Class