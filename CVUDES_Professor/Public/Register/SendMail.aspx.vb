Imports System.Net.Mail

Public Class SendMail
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            configurePage()
        End If
    End Sub

    Private Sub configurePage()
        Dim myBody As String = String.Empty
        Dim objRegistration As CVUDES_Professor_Class.User = New CVUDES_Professor_Class.User
        objRegistration = CVUDES_Professor_Class.UserHandler.ReadUserByEmail(Request.QueryString("Email"))
        With objRegistration
            myBody = GetGlobalResourceObject("MailMessages", "Email_VerificationRequest")
            myBody = myBody.Replace("@@UserName@@", .UserName)
            myBody = myBody.Replace("@@urlActivation@@", ConfigurationManager.AppSettings("urlActivation").ToString())
            myBody = myBody.Replace("@@Email@@", .Email)
        End With
        SendEmail("Confirmacion Cuenta Correo", myBody, True, objRegistration)
        Response.Redirect("/Public/Register/Confirmation.aspx")
    End Sub

    Public Sub SendEmail(ByVal Subject As String, ByVal Body As String, ByVal esHtml As Boolean, ByVal objRegistration As CVUDES_Professor_Class.User)
        Dim mensaje As New MailMessage()
        Dim MailSend As String = ConfigurationManager.AppSettings("AccountMail").ToString()
        Dim Recipients As String = objRegistration.Email
        mensaje.From = New System.Net.Mail.MailAddress(MailSend)
        For Each mail As String In Recipients.Split(New Char() {","c})
            mensaje.To.Add(New System.Net.Mail.MailAddress(mail))
        Next
        mensaje.Subject = Subject
        mensaje.Body = Body
        mensaje.IsBodyHtml = esHtml
        Dim SmtpCliente As String = ConfigurationManager.AppSettings("SmtpClient").ToString()
        Dim AccountMail As String = MailSend
        Dim PassMail As String = ConfigurationManager.AppSettings("PassMail").ToString()

        Dim SmtpClient As New Net.Mail.SmtpClient(SmtpCliente, 587)
        SmtpClient.EnableSsl = True
        SmtpClient.Credentials = New Net.NetworkCredential(AccountMail, PassMail)
        SmtpClient.Send(mensaje)
    End Sub

End Class