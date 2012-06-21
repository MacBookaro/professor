
Partial Public Class SignInPage
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not Page.IsPostBack Then
        '    'Si el usuario esta autenticado y el querystring es diferente a vacio, entonces es acceso a pagina no autorizado
        '    If User.Identity.IsAuthenticated And Request.QueryString("ReturnUrl") <> String.Empty Then Response.Redirect("/ControlPanel/NotAllowed.aspx")
        '    'Si el usuario esta autenticado, entonces es que llego al login por error, debe redireccionar a la pagina de verificacion de roles
        '    If User.Identity.IsAuthenticated Then Response.Redirect("/ControlPanel/Default.aspx")
        '    'Si el usuario no esta autenticado
        '    If Not User.Identity.IsAuthenticated Then
        '        Me.txtUserName.Focus()
        '        Dim strCookie As String = "USR" & ConfigurationManager.AppSettings("ApplicationId") 'REVISAR
        '        If (Request.Cookies(strCookie) IsNot Nothing) Then
        '            Me.txtUserName.Text = Server.UrlDecode(Request.Cookies(strCookie).Value)
        '            Me.txtPassword.Focus()
        '        End If
        '    End If

        '    If ConfigurationManager.AppSettings("AllowPasswordReset") = "1" Then
        '        Me.lnkPasswordReset.Visible = True
        '        Me.lnkPasswordReset.NavigateUrl = "/Services/PasswordReset/Default.aspx"
        '    Else
        '        Me.lnkPasswordReset.Visible = False
        '    End If
        'Else
        '    Dim strCookie As String = "USR" & ConfigurationManager.AppSettings("ApplicationId") 'REVISAR
        '    Dim objCookie As HttpCookie = New HttpCookie(strCookie)
        '    objCookie.Value = Server.UrlEncode(Me.txtUserName.Text)
        '    objCookie.Expires = Now.AddDays(10)
        '    Response.Cookies.Add(objCookie)
        'End If
    End Sub

    Private Sub btnSignIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If Page.IsValid Then
            Me.xpnlScript.ResponseScripts.Clear()
            Dim strUserName As String = Me.txtUserName.Text
            Dim strPassword As String = generateMD5(Me.txtPassword.Text)
            Dim strValidateSession As String = String.Empty

            strValidateSession = CVUDES_Professor_Class.UserHandler.ValidateSession(strUserName, strPassword)
            Select Case strValidateSession
                Case "0"
                    Me.TableMessage.Visible = True
                    Me.txtPassword.Focus()
                Case "1"
                    AllowUserAuthentication(strUserName)
            End Select
        End If
    End Sub

    Private Sub AllowUserAuthentication(ByVal UserName As String)
        Dim strSessionTime As String = ConfigurationManager.AppSettings("SessionTime")
        Dim intSessionTime As Integer = 30
        If strSessionTime <> String.Empty Then
            intSessionTime = CInt(strSessionTime)
        End If

        Dim objUserSession As CVUDES_Professor_Class.User = New CVUDES_Professor_Class.User
        objUserSession = CVUDES_Professor_Class.UserHandler.Read(UserName)
        Session("UserSession") = objUserSession
        Dim strRoles As String = objUserSession.RolesList
        Dim fatTicket As FormsAuthenticationTicket
        Dim strCookie As String
        Dim ck As HttpCookie
        fatTicket = New FormsAuthenticationTicket(1, UserName, DateTime.Now, DateTime.Now.AddMinutes(intSessionTime), False, strRoles)
        strCookie = FormsAuthentication.Encrypt(fatTicket)
        ck = New HttpCookie(FormsAuthentication.FormsCookieName(), strCookie)
        objUserSession = Nothing
        Response.Cookies.Add(ck)
        If Request.QueryString("ReturnUrl") <> String.Empty Then
            Response.Redirect("/ControlPanel/Default.aspx?ReturnUrl=" & Server.UrlEncode(Request.QueryString("ReturnUrl")))
        Else
            Response.Redirect("/ControlPanel/Default.aspx")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim strCancelURL As String = ConfigurationManager.AppSettings("CancelURL")
        Response.Redirect(strCancelURL)
    End Sub

End Class