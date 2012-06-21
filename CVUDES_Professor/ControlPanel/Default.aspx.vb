Public Class ControlPanelDefaultPage
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString("ReturnUrl") <> String.Empty Then
            Response.Redirect(Server.UrlDecode(Request.QueryString("ReturnUrl")))
        Else
            Dim strUserRoles As String = CType(Session("UserSession"), CVUDES_Professor_Class.User).RolesList
            Dim arrUserRoles() As String
            Dim strRole As String = String.Empty
            Dim strPath As String = String.Empty
            arrUserRoles = strUserRoles.Split(",")

            Select Case arrUserRoles(0)
                Case "USR_ADMINISTRATOR"
                    strRole = "USR_ADMINISTRATOR"
                    strPath = "Administrator"
                Case "USR_CANDIDATE"
                    strRole = "USR_CANDIDATE"
                    strPath = "Candidate"
                Case "USR_COORDINATOR"
                    strRole = "USR_COORDINATOR"
                    strPath = "Coordinator"
                Case "USR_PROFESSOR"
                    strRole = "USR_PROFESSOR"
                    strPath = "Professor"
            End Select

            If HttpContext.Current.User.IsInRole(strRole) Then
                Response.Redirect(String.Format("/ControlPanel/{0}/Default.aspx", strPath))
            Else
                Response.Redirect("/SignOut.aspx?Reason=ROLENOTFOUND")
            End If
        End If
    End Sub

End Class