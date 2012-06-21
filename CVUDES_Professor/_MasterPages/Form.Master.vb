Public Class Form
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = GetGlobalResourceObject("AppResources", "ApplicationName")
        If Not Page.IsPostBack Then
            Me.litScript.Text = GetMasterPageScript()
        End If
    End Sub

End Class