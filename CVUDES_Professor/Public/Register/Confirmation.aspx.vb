Public Class Confirmation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM  yyyy")
    End Sub

End Class