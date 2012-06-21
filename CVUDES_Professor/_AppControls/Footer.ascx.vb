Partial Public Class Footer
	Inherits System.Web.UI.UserControl

	Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		If Not Page.IsPostBack Then
			Me.lnkFooter.Attributes.Add("onclick", "openBrWindow('/Public/Credits.aspx','CreditsWindow','menubar=0,toolbar=0,resizable=0,scrollbars=2','530','260','true')")
			Me.lblCount.Text = CStr(Application("ActiveUsers"))
			Me.lblCulture.Text = System.Globalization.CultureInfo.CurrentCulture.ToString
		End If
	End Sub
End Class