Imports System.Configuration
Imports System.Text
Imports System.ComponentModel
Imports System.Web.HttpContext

Module DropsApp

    Public Sub ConfigureDrop_Gender(ByVal objDrop As Telerik.Web.UI.RadComboBox, ByVal Type As Integer, ByVal IsActive As String)
        objDrop.Items.Clear()
        Dim dstTemp As DataSet
        dstTemp = CVUDES_Professor_Class.DropManager.ReadGenders(IsActive)
        If dstTemp.Tables(0).Rows.Count > 0 Then
            objDrop.DataSource = dstTemp
            objDrop.DataTextField = "Name"
            objDrop.DataValueField = "GenderId"
            objDrop.DataBind()
        End If
        Select Case Type
            Case 1
                objDrop.Items.Insert(0, New Telerik.Web.UI.RadComboBoxItem(GetGlobalResourceObject("Strings", "strSelect"), Integer.MinValue.ToString))
        End Select
    End Sub


    Public Sub ConfigureDrop_MaritalStatusType(ByVal objDrop As Telerik.Web.UI.RadComboBox, ByVal Type As Integer, ByVal IsActive As String)
        objDrop.Items.Clear()
        Dim dstTemp As DataSet
        dstTemp = CVUDES_Professor_Class.DropManager.ReadMaritalStatusTypes(IsActive)

        If dstTemp.Tables(0).Rows.Count > 0 Then
            objDrop.DataSource = dstTemp
            objDrop.DataTextField = "Name"
            objDrop.DataValueField = "MaritalStatusTypeId"
            objDrop.DataBind()
        End If
        Select Case Type
            Case 1
                objDrop.Items.Insert(0, New Telerik.Web.UI.RadComboBoxItem(GetGlobalResourceObject("Strings", "strSelect"), Integer.MinValue.ToString))
        End Select
    End Sub


    Public Sub ConfigureDrop_dropCountry(ByVal objDrop As Telerik.Web.UI.RadComboBox, ByVal Type As Integer, ByVal IsActive As String)
        objDrop.Items.Clear()
        Dim dstTemp As DataSet
        dstTemp = CVUDES_Professor_Class.DropManager.ReadCountries(IsActive)
        If dstTemp.Tables(0).Rows.Count > 0 Then
            objDrop.DataSource = dstTemp
            objDrop.DataTextField = "Name"
            objDrop.DataValueField = "CountryId"
            objDrop.DataBind()
        End If
        Select Case Type
            Case 1
                objDrop.Items.Insert(0, New Telerik.Web.UI.RadComboBoxItem(GetGlobalResourceObject("Strings", "strSelect"), Integer.MinValue.ToString))
        End Select
    End Sub


    Public Sub ConfigureDrop_dropRegion(ByVal objDrop As Telerik.Web.UI.RadComboBox, ByVal CountryId As Guid, ByVal Type As Integer, ByVal IsActive As Boolean)
        objDrop.Items.Clear()
        Dim dstTemp As DataSet
        dstTemp = CVUDES_Professor_Class.DropManager.ReadRegionId(CountryId, IsActive) 'CORREGIIIIR
        If dstTemp.Tables(0).Rows.Count > 0 Then
            objDrop.DataSource = dstTemp
            objDrop.DataTextField = "Name"
            objDrop.DataValueField = "RegionId"
            objDrop.DataBind()
        End If
        Select Case Type
            Case 1
                objDrop.Items.Insert(0, New Telerik.Web.UI.RadComboBoxItem(GetGlobalResourceObject("Strings", "strSelect"), Integer.MinValue.ToString))
        End Select
    End Sub


    Public Sub ConfigureDrop_dropCity(ByVal objDrop As Telerik.Web.UI.RadComboBox, ByVal RegionId As Guid, ByVal Type As Integer, ByVal IsActive As Boolean)
        objDrop.Items.Clear()
        Dim dstTemp As DataSet
        dstTemp = CVUDES_Professor_Class.DropManager.ReadCitiesWithRegionId(RegionId, IsActive)
        If dstTemp.Tables(0).Rows.Count > 0 Then
            objDrop.DataSource = dstTemp
            objDrop.DataTextField = "Name"
            objDrop.DataValueField = "CityId"
            objDrop.DataBind()
        End If
        Select Case Type
            Case 1
                objDrop.Items.Insert(0, New Telerik.Web.UI.RadComboBoxItem(GetGlobalResourceObject("Strings", "strSelect"), Integer.MinValue.ToString))
        End Select
    End Sub


    Public Sub ConfigureDrop_dropIdentityDocumentType(ByVal objDrop As Telerik.Web.UI.RadComboBox, ByVal Type As Integer, ByVal IsActive As String)
        objDrop.Items.Clear()
        Dim dstTemp As DataSet
        dstTemp = CVUDES_Professor_Class.DropManager.ReadIdentificationDocumentTypes_ReadAll(IsActive)
        If dstTemp.Tables(0).Rows.Count > 0 Then
            objDrop.DataSource = dstTemp
            objDrop.DataTextField = "Description"
            objDrop.DataValueField = "IdentificationDoumenTypeId"
            objDrop.DataBind()
        End If
        Select Case Type
            Case 1
                objDrop.Items.Insert(0, New Telerik.Web.UI.RadComboBoxItem(GetGlobalResourceObject("Strings", "strSelect"), Integer.MinValue.ToString))
        End Select
    End Sub

End Module
