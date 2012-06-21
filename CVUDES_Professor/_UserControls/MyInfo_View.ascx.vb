Partial Public Class MyInfoViewUserControl
    Inherits System.Web.UI.UserControl

    Private _PId As String = "Home"

    Public Property PId() As String
        Get
            Return _PId
        End Get
        Set(ByVal value As String)
            _PId = value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ConfigureUserControl()
        End If
    End Sub

    Private Sub ConfigureUserControl()
        Dim objUser As CVUDES_Professor_Class.User = New CVUDES_Professor_Class.User
        objUser = CType(Session("UserSession"), CVUDES_Professor_Class.User)

        Me.lblUserCompleteName.Text = objUser.FirtsName & " " & objUser.FirtsSurname
        Me.lblEmail.Text = objUser.Email
        Me.lblUserName.Text = HttpContext.Current.User.Identity.Name
        'Me.lnkChangeMyPassword.NavigateUrl = "/ControlPanel/Public/MyInfo/SetPassword.aspx?Return=" & PId
        'Me.lnkEditMyInformation.NavigateUrl = "/ControlPanel/Public/MyInfo/Edit.aspx?Return=" & PId
        'Me.lnkViewMySessionsLog.NavigateUrl = "/ControlPanel/Public/MyInfo/View.aspx?Return=" & PId
    End Sub

End Class