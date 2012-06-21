Public Class CoodinatorDefaultpage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ConfigurePage()
        End If
    End Sub

    Private Sub ConfigurePage()
        Dim strKey As String = User.Identity.Name
        Dim strCookie As String = String.Empty
        Dim strURL As String = String.Empty

        'PROFESSOR ===================================================================================================================================
        strCookie = strKey & "CoordinatorProfessorDefault"
        strURL = "/ControlPanel/Coordinator/Professor/Default.aspx"
        If (Request.Cookies(strCookie) IsNot Nothing) Then strURL = strURL & Server.UrlDecode(Request.Cookies(strCookie).Value)
        Me.lnkProfessor.NavigateUrl = strURL

        'LOADING DATA ===================================================================================================================================
        strCookie = strKey & "CoordinatorLoadingDataLoadingProfessor"
        strURL = "/ControlPanel/Coordinator/LoadingData/LoadingProfessor.aspx"
        If (Request.Cookies(strCookie) IsNot Nothing) Then strURL = strURL & Server.UrlDecode(Request.Cookies(strCookie).Value)
        Me.lnkLoadingProfessor.NavigateUrl = strURL

        strCookie = strKey & "CoordinatorLoadingDataLoadingInformationAdmin"
        strURL = "/ControlPanel/Coordinator/LoadingData/LoadingInformationAdmin.aspx"
        If (Request.Cookies(strCookie) IsNot Nothing) Then strURL = strURL & Server.UrlDecode(Request.Cookies(strCookie).Value)
        Me.lnkLoadingInfoAdmin.NavigateUrl = strURL

        'REPORTS SNIES ===================================================================================================================================
        strCookie = strKey & "CoordinatorReportSniesDefault"
        strURL = "/ControlPanel/Coordinator/ReportSnies/Default.aspx"
        If (Request.Cookies(strCookie) IsNot Nothing) Then strURL = strURL & Server.UrlDecode(Request.Cookies(strCookie).Value)
        Me.lnkReports.NavigateUrl = strURL

    End Sub

End Class