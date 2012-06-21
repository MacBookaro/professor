Public Class Notification
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM  yyyy")
    End Sub

    Protected Sub btnSignIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSignIn.Click
        Response.Redirect(ConfigurationManager.AppSettings("urlWebApp").ToString())
    End Sub
End Class