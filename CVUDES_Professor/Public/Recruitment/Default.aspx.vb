Public Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            configurePage()
        End If

    End Sub

    Private Sub configurePage()

        Me.lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM  yyyy")
        ConfigureDrop_MaritalStatusType(Me.dropMaritalStatusType, 1, "1")
        ConfigureDrop_Gender(Me.dropGender, 1, "1")
        ConfigureDrop_dropCountry(Me.dropPlaceBirthCountry, 1, "1")
        ConfigureDrop_dropIdentityDocumentType(Me.dropIdentificationDocumentType, 1, "1")
        ConfigureDrop_dropCountry(Me.dropIdentificationIssuedLocationCountry, 1, "1")
        ConfigureDrop_dropCountry(Me.dropResidencePlaceCountry, 1, "1")
    End Sub


    Protected Sub dropBirthCountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles dropPlaceBirthCountry.SelectedIndexChanged
        ConfigureDrop_dropRegion(Me.dropPlaceBirthRegion, ToGuid(Me.dropPlaceBirthCountry.SelectedValue), 1, "1")
    End Sub


    Protected Sub dropBirthRegion_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles dropPlaceBirthRegion.SelectedIndexChanged
        ConfigureDrop_dropCity(Me.dropPlaceBirth, ToGuid(Me.dropPlaceBirthRegion.SelectedValue), 1, "1")
    End Sub


    Protected Sub dropExpeditionCountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles dropIdentificationIssuedLocationCountry.SelectedIndexChanged
        ConfigureDrop_dropRegion(Me.dropIdentificationIssuedLocationRegion, ToGuid(Me.dropIdentificationIssuedLocationCountry.SelectedValue), 1, "1")
    End Sub


    Protected Sub dropExpeditionRegion_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles dropIdentificationIssuedLocationRegion.SelectedIndexChanged
        ConfigureDrop_dropCity(dropIdentificationIssuedLocation, ToGuid(Me.dropIdentificationIssuedLocationRegion.SelectedValue), 1, "1")
    End Sub


    Protected Sub dropAddressCountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles dropResidencePlaceCountry.SelectedIndexChanged
        ConfigureDrop_dropRegion(Me.dropResidencePlaceRegion, ToGuid(Me.dropResidencePlaceCountry.SelectedValue), 1, "1")
    End Sub


    Protected Sub dropAddressRegion_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles dropResidencePlaceRegion.SelectedIndexChanged
        ConfigureDrop_dropCity(dropResidencePlace, ToGuid(Me.dropResidencePlaceRegion.SelectedValue), 1, "1")
    End Sub


    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        'Dim r As Random = New Random()
        Dim result = String.Empty
        Dim scriptString As String = String.Empty
        Dim objRegistration As CVUDES_Professor_Class.User = New CVUDES_Professor_Class.User
        With objRegistration
            .FirtsName = Me.txtFirstName.Text
            .MiddleName = Me.txtMiddleName.Text
            .FirtsSurname = Me.txtFirstSurname.Text
            .MiddleSurname = Me.txtMiddleSurname.Text
            .IdentificationNumber = Me.txtIdentification.Text
            .IdentificationDoumenTypeId = ToGuid(Me.dropIdentificationDocumentType.SelectedValue)
            .IdentificationIssuedLocation = Me.dropIdentificationIssuedLocation.SelectedValue
            .CellPhoneNumber = Me.txtCellPhoneNumber.Text
            .CellPhoneNumberAlternative = Me.txtCellPhoneNumberAlternative.Text
            .PhoneNumber = Me.txtPhoneNumber.Text
            .AreaPhoneNumber = Me.txtAreaPhoneNumber.text
            .BirthDate = Me.txtBirthDate.SelectedDate
            .PlaceBirth = Me.dropPlaceBirth.SelectedValue
            .ResidenceAddress = Me.txtResidenceAddress.text
            .PlaceResidenceId = ToGuid(Me.dropResidencePlace.SelectedValue)
            .Email = Me.txtEmail.Text
            .EmailVerified = False
            .WebSite = Me.txtWebSite.text
            '.FilePhoto = Byte.MaxValue
            .Password = String.Empty
            .WasVerified = False
            .Gender = Me.dropGender.SelectedValue
            .MaritalStatusTypeId = ToGuid(Me.dropMaritalStatusType.SelectedValue)
            .CreationUserName = String.Empty
            .CreationDate = DateTime.Now
            .LastChangeUser = String.Empty
            .LastChangeDate = DateTime.Now
            .IsActive = True

        End With
        result = CVUDES_Professor_Class.UserHandler.Create(objRegistration)
        If result.Equals("1") Then
            result = "Información almacenada con Éxito"
            scriptString = "alert(""" & result & """); document.location.href ='/Public/Register/SendMail.aspx?Email=" & objRegistration.Email & "';"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "RegisterStartupScript", scriptString, True)
            'result = GetGlobalResourceObject("Messages", "SaveConfirmMessage")
            'Response.Redirect("/Public/Registration/SendMail.aspx?EmailVerifiedId=" & objRegistration.EmailVerified.ToString)
        Else
            scriptString = "alert(""" & result & """); document.location.href ='/Public/Recruitment/Default.aspx';"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "RegisterStartupScript", scriptString, True)
        End If

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Dim strCancelURL As String = ConfigurationManager.AppSettings("CancelURL")
        Response.Redirect(strCancelURL)
    End Sub
End Class
