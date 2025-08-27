Public Class mspDefault
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            UserAuthentication()
        End If
    End Sub

    Private Sub UserAuthentication()

        Dim bValidUser As Boolean = False

        Dim sql As String
        Dim ds As New DataSet
        Dim bdconn As New clsDatabaseSQL

        bdconn.OpenConnection()

        sql = "SELECT NAME " &
              "FROM [USER] " &
              "WHERE LTRIM(RTRIM(LOWER(USERNAME))) = '" & Replace(System.Security.Principal.WindowsIdentity.GetCurrent().Name, "SUPERIOR\", "").ToLower.Trim & "' " &
              "AND ACTIVE = 'YES' "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                lblWelcome.Text = "Welcome: " & ds.Tables(0).Rows(i)("NAME")
                bValidUser = True
            Next
        Else
            bValidUser = False
        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing
        ds.Dispose()
        ds = Nothing

        If bValidUser = False Then
            Session.Clear()
            Session.Abandon()
            Session.RemoveAll()
            Response.Redirect("~/Forms/frmInvalidUser.aspx", False)
        End If

    End Sub


End Class