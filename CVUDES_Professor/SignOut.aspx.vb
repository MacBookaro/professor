Partial Public Class SignOutPage
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lnkSignIn.NavigateUrl = "/SignIn.aspx"
        FormsAuthentication.SignOut()
        Session.Contents.RemoveAll()
    End Sub

End Class