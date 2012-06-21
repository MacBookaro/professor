Imports System.Web.SessionState
Imports System.Threading
Imports System.Globalization

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        Application("ActiveUsers") = 0
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
        Application.Lock()
        Application("ActiveUsers") = CInt(Application("ActiveUsers")) + 1
        Application.UnLock()
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
        Dim strOldCulture As String = CultureInfo.CurrentCulture.ToString
        Dim strNewCulture As String = CultureInfo.CurrentCulture.ToString
        If (Request.Cookies(ConfigurationManager.AppSettings("ApplicationId") & "UserCulture") IsNot Nothing) Then
            strNewCulture = Request.Cookies(ConfigurationManager.AppSettings("ApplicationId") & "UserCulture").Value
        End If

        Try
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(strNewCulture)
        Catch ex As Exception
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(strOldCulture)
        End Try
        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture

        ' Formato de numeros, monedas y porcentajes. Separador de miles = , Separador de Centavos = .
        Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Thread.CurrentThread.CurrentCulture.NumberFormat.PercentDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.PercentGroupSeparator = ","
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
        If Not IsNothing(HttpContext.Current.User) Then
            If (HttpContext.Current.User.Identity.IsAuthenticated) Then
                If TypeOf HttpContext.Current.User.Identity Is FormsIdentity Then
                    Dim Id As System.Web.Security.FormsIdentity
                    Id = CType(HttpContext.Current.User.Identity, FormsIdentity)
                    Dim fatTicket As FormsAuthenticationTicket
                    fatTicket = Id.Ticket
                    Dim strUserData As String
                    Dim strRole() As String
                    strUserData = fatTicket.UserData
                    strRole = strUserData.Split(",")
                    HttpContext.Current.User = New System.Security.Principal.GenericPrincipal(Id, strRole)
                End If
            End If
        End If
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
        If ConfigurationManager.AppSettings("ShowErrorMessages") = "0" Then
            Dim ErrorException As System.Exception = Server.GetLastError.GetBaseException
            'Applications.ErrorEventHandler.RegisterEvent(ErrorException.Message.ToString, ErrorException.StackTrace.ToString, HttpContext.Current.User.Identity.Name, _
            'Request.Url.OriginalString, Request.Url.ToString, Request.Browser.Platform, Request.Browser.Browser, Request.Browser.Version)
            Server.ClearError()
            Dim strURL As String = "/Public/ErrorMessage.aspx?Error=GLOBAL"
            If Request.QueryString("PId") <> String.Empty Then strURL = strURL & "&PId=" & Request.QueryString("PId")
            If Request.QueryString("PParams") <> String.Empty Then strURL = strURL & "&PParams=" & Server.UrlEncode(Request.QueryString("PParams"))
            Response.Redirect(strURL)
        End If
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
        Application.Lock()
        Application("ActiveUsers") = CInt(Application("ActiveUsers")) - 1
        Application.UnLock()
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class