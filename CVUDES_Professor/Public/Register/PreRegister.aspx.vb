Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.IO

Public Class PreRegister
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            configurePage()
        End If
    End Sub

    Private Sub configurePage()
        ConfigureDrop_dropIdentityDocumentType(Me.dropIdentificationDocumentType, 1, "1")
        Me.divUserNameAvailable.Visible = False
        Me.divUserNameNotAvailable.Visible = False
        Me.divUserNameRequired.Visible = False
        Me.btnRegister.Enabled = False
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Dim strCancelURL As String = ConfigurationManager.AppSettings("CancelURL")
        Response.Redirect(strCancelURL)
    End Sub

    Protected Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        Dim result = String.Empty
        Dim scriptString As String = String.Empty
        Dim objRegistration As CVUDES_Professor_Class.User = New CVUDES_Professor_Class.User
        With objRegistration
            .UserName = Me.txtUserName.Text
            .IdentificationNumber = Me.txtIdentification.Text
            .IdentificationDoumenTypeId = ToGuid(Me.dropIdentificationDocumentType.SelectedValue)
            .Email = Me.txtEmail.Text
            .Password = generateMD5(Me.txtPassword.Text)
        End With
        result = CVUDES_Professor_Class.UserHandler.PreRegister(objRegistration)
        If result Then
            result = "Información básica agregada con éxito "
            scriptString = "alert(""" & result & """); document.location.href ='/Public/Register/SendMail.aspx?Email=" & objRegistration.Email & "';"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "RegisterStartupScript", scriptString, True)
        Else
            result = "Candidato No agregado "
            scriptString = "alert(""" & result & """); document.location.href ='/SignIn.aspx';"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "RegisterStartupScript", scriptString, True)
        End If
    End Sub

    Protected Sub btnCheckUserName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheckUserName.Click
        Me.divUserNameAvailable.Visible = False
        Me.divUserNameNotAvailable.Visible = False
        Me.divUserNameRequired.Visible = False

        If Me.txtUserName.Text <> String.Empty Then
            Dim UserId As Integer = CVUDES_Professor_Class.UserHandler.CheckUserName(Me.txtUserName.Text)
            If UserId = 0 Then
                Me.divUserNameAvailable.Visible = True
                Me.btnRegister.Enabled = True
            Else
                Me.divUserNameNotAvailable.Visible = True
                Me.btnRegister.Enabled = False
                'Me.lnkViewUser.NavigateUrl = "/ControlPanel/Accounting/Users/View.aspx?UserId=" & UserId.ToString
            End If
        Else
            Me.divUserNameRequired.Visible = True
            Me.btnRegister.Enabled = False
        End If
        'CType(Me.Master.FindControl("RadAjaxManager1"), Telerik.Web.UI.RadAjaxManager).FocusControl(Me.txtUserName)
        Me.txtUserName.Focus()
    End Sub
End Class