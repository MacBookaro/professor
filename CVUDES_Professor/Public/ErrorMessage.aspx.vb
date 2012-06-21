Partial Public Class PublicErrorMessagePage
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ConfigurePage()
        End If
    End Sub

    Private Sub ConfigurePage()
		If Request.QueryString("PId") <> String.Empty Then
			ViewState("DefaultPId") = Request.QueryString("PId")
		Else
			ViewState("DefaultPId") = "Home"
		End If

        If Session("UserSession") IsNot Nothing Then
            Dim strCookie As String = User.Identity.Name & ViewState("DefaultPId")
            Dim strParams As String = String.Empty
            If (Request.Cookies(strCookie) IsNot Nothing) Then strParams = Server.UrlDecode(Request.Cookies(strCookie).Value)
            ViewState("CancelURL") = GetURLToRedirect(Request.QueryString("PId"), Server.UrlDecode(Request.QueryString("PParams")), ViewState("DefaultPId"), strParams)
        Else
            ViewState("CancelURL") = GetURLToRedirect(Request.QueryString("PId"), Server.UrlDecode(Request.QueryString("PParams")), ViewState("DefaultPId"), String.Empty)
        End If

		Me.lblErrorMessage.Text = "Oooooooooops..... " & GetGlobalResourceObject("Messages", "ApplicationErrorUnexpected")
		Me.lblErrorDescription.Text = GetGlobalResourceObject("Messages", "ApplicationErrorDescription")
        Me.btnOk.Focus()
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Response.Redirect(ViewState("CancelURL"))
    End Sub
End Class