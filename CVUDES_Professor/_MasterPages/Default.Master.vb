Partial Public Class DefaultMaster
	Inherits System.Web.UI.MasterPage

	Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Page.Title = GetGlobalResourceObject("AppResources", "ApplicationName")
		If Not Page.IsPostBack Then
			Me.litScript.Text = GetMasterPageScript()
		End If
	End Sub

    Private Sub ScriptManager1_AsyncPostBackError(ByVal sender As Object, ByVal e As System.Web.UI.AsyncPostBackErrorEventArgs) Handles ScriptManager1.AsyncPostBackError
        If ConfigurationManager.AppSettings("ShowErrorMessages") = "0" Then
            Dim ErrorException As System.Exception = Server.GetLastError.GetBaseException
            'Applications.ErrorEventHandler.RegisterEvent(ErrorException.Message.ToString, ErrorException.StackTrace.ToString, HttpContext.Current.User.Identity.Name, _
            'Request.Url.OriginalString, Request.Url.ToString, Request.Browser.Platform, Request.Browser.Browser, Request.Browser.Version)
            Server.ClearError()
            Dim strURL As String = "/Public/ErrorMessage.aspx?Error=AJAX"
            If Request.QueryString("PId") <> String.Empty Then strURL = strURL & "&PId=" & Request.QueryString("PId")
            If Request.QueryString("PParams") <> String.Empty Then strURL = strURL & "&PParams=" & Server.UrlEncode(Request.QueryString("PParams"))
            Response.Redirect(strURL)
        End If
    End Sub
End Class