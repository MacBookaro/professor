Partial Public Class Header
	Inherits System.Web.UI.UserControl

	Private Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
		'Verificar Session de Usuario
		If HttpContext.Current.User.Identity.IsAuthenticated Then
			If Session("UserSession") Is Nothing Then
				'Crear la sesion de inicio de sesion
                Dim objUserSession As CVUDES_Professor_Class.User = New CVUDES_Professor_Class.User
                objUserSession = CVUDES_Professor_Class.UserHandler.Read(HttpContext.Current.User.Identity.Name)
				Session("UserSession") = objUserSession
			End If
            'lblUserName.Text = CType(Session("UserSession"), CVUDES_Professor_Class.User).UserName & " " & CType(Session("UserSession"), CVUDES_Professor_Class.User).FirtsSurname
            lblUserName.Text = CType(Session("UserSession"), CVUDES_Professor_Class.User).UserName
		End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lnkSignOut.NavigateUrl = "/SignOut.aspx"
        'Configurar seleccion de idioma
        Dim blnAllow As Boolean = False
        blnAllow = CBool(ConfigurationManager.AppSettings("AllowLanguageSelection"))
        Me.lblSep1.Visible = blnAllow
        '.Visible = blnAllow
        If blnAllow Then
            'Me.foLanguages.AttachTo = "lnkLanguages"
            'Me.lnkEnglish.NavigateUrl = "/Public/Tools/Languages.aspx?Lang=en-US"
            'Me.lnkSpanish.NavigateUrl = "/Public/Tools/Languages.aspx?Lang=es-CO"
            'Me.lnkFrench.NavigateUrl = "/Public/Tools/Languages.aspx?Lang=fr-FR"
        End If

        'Configurar Roles del Usuario
        Dim cellOption As HtmlTableCell
        Dim strMainDirectory As String
        Dim strNotAllowedMessage As String = GetGlobalResourceObject("Messages", "ApplicationAccessNotAllowed")

        If HttpContext.Current.User.IsInRole("USR_ADMINISTRATOR") Then
            Me.lnkAdministrator.NavigateUrl = "/ControlPanel/Administrator/Default.aspx"
        Else
            Me.lnkAdministrator.NavigateUrl = "javascript:;"
            Me.lnkAdministrator.Attributes.Add("onclick", "alert('" & strNotAllowedMessage & "');")
        End If

        If HttpContext.Current.User.IsInRole("USR_COORDINATOR") Or HttpContext.Current.User.IsInRole("USR_ADMINISTRATOR") Then
            Me.lnkCoordinator.NavigateUrl = "/ControlPanel/Coordinator/Default.aspx"
        Else
            Me.lnkCoordinator.NavigateUrl = "javascript:;"
            Me.lnkCoordinator.Attributes.Add("onclick", "alert('" & strNotAllowedMessage & "');")
        End If

        If HttpContext.Current.User.IsInRole("USR_PROFESSOR") Or HttpContext.Current.User.IsInRole("USR_ADMINISTRATOR") Then
            Me.lnkProfessor.NavigateUrl = "/ControlPanel/Professor/Default.aspx"
        Else
            Me.lnkProfessor.NavigateUrl = "javascript:;"
            Me.lnkProfessor.Attributes.Add("onclick", "alert('" & strNotAllowedMessage & "');")
        End If

        If HttpContext.Current.User.IsInRole("USR_CANDIDATE") Or HttpContext.Current.User.IsInRole("USR_ADMINISTRATOR") Then
            Me.lnkCandidate.NavigateUrl = "/ControlPanel/Candidate/Default.aspx"
        Else
            Me.lnkCandidate.NavigateUrl = "javascript:;"
            Me.lnkCandidate.Attributes.Add("onclick", "alert('" & strNotAllowedMessage & "');")
        End If

        strMainDirectory = GetMainDirectory(Request.Url.AbsolutePath)
        cellOption = FindControl("Tab" & strMainDirectory)
        If cellOption IsNot Nothing Then
            cellOption.Attributes.Add("Class", "HeaderMenuSelected")
        End If
    End Sub

    Protected Function GetMainDirectory(ByVal Path As String) As String
        Dim strResult As String = String.Empty
        Dim strPathItems() As String
        If Path <> String.Empty Then
            strPathItems = Path.Split("/")
            strResult = strPathItems(2)
        End If
        Return strResult
    End Function

End Class