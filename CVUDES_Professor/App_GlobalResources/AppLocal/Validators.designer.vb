'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option or rebuild the Visual Studio project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "10.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Validators
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources.Validators", Global.System.Reflection.[Assembly].Load("App_GlobalResources"))
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Las contraseñas no coinciden.
        '''</summary>
        Friend Shared ReadOnly Property cpvPassword() As String
            Get
                Return ResourceManager.GetString("cpvPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Correo Electronico&apos; es no tiene un formato válido de email.
        '''</summary>
        Friend Shared ReadOnly Property revEmail() As String
            Get
                Return ResourceManager.GetString("revEmail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Número Teléfono Fijo&apos; solo admite números enteros.
        '''</summary>
        Friend Shared ReadOnly Property revPhoneNumber() As String
            Get
                Return ResourceManager.GetString("revPhoneNumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Código de Área&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvAreaPhoneNumber() As String
            Get
                Return ResourceManager.GetString("rfvAreaPhoneNumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Fecha Nacimiento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvBirthDate() As String
            Get
                Return ResourceManager.GetString("rfvBirthDate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Número Teléfono Móvil&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvCellPhoneNumber() As String
            Get
                Return ResourceManager.GetString("rfvCellPhoneNumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Número Teléfono Móvil Alternativo&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvCellPhoneNumberAlternative() As String
            Get
                Return ResourceManager.GetString("rfvCellPhoneNumberAlternative", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Correo Electronico&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvEmail() As String
            Get
                Return ResourceManager.GetString("rfvEmail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Correo electrónico no valido.
        '''</summary>
        Friend Shared ReadOnly Property rfvEmail2() As String
            Get
                Return ResourceManager.GetString("rfvEmail2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Fecha de expedición&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvExpeditionDate() As String
            Get
                Return ResourceManager.GetString("rfvExpeditionDate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Primer Nombre&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvFirstName() As String
            Get
                Return ResourceManager.GetString("rfvFirstName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Primer Apellido&apos; es Obligatorio .
        '''</summary>
        Friend Shared ReadOnly Property rfvFirstSurname() As String
            Get
                Return ResourceManager.GetString("rfvFirstSurname", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Genero&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvGender() As String
            Get
                Return ResourceManager.GetString("rfvGender", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Número de Documento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvIdentification() As String
            Get
                Return ResourceManager.GetString("rfvIdentification", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Tipo de Documento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvIdentificationDocumentType() As String
            Get
                Return ResourceManager.GetString("rfvIdentificationDocumentType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Ciudad&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvIdentificationIssuedLocation() As String
            Get
                Return ResourceManager.GetString("rfvIdentificationIssuedLocation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Pais&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvIdentificationIssuedLocationCountry() As String
            Get
                Return ResourceManager.GetString("rfvIdentificationIssuedLocationCountry", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Departamento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvIdentificationIssuedLocationRegion() As String
            Get
                Return ResourceManager.GetString("rfvIdentificationIssuedLocationRegion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Código Lider&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvLeaderCode() As String
            Get
                Return ResourceManager.GetString("rfvLeaderCode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Estado Civíl&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvMaritalStatusType() As String
            Get
                Return ResourceManager.GetString("rfvMaritalStatusType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Nombre de Usuario o Nick&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvNickUserName() As String
            Get
                Return ResourceManager.GetString("rfvNickUserName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Ocupación&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvOccupation() As String
            Get
                Return ResourceManager.GetString("rfvOccupation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Contraseña&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvPassword() As String
            Get
                Return ResourceManager.GetString("rfvPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Repita la Contraseña&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvPassword2() As String
            Get
                Return ResourceManager.GetString("rfvPassword2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Numero de Telefono Fijo&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvPhoneNumber() As String
            Get
                Return ResourceManager.GetString("rfvPhoneNumber", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Ciudad de Nacimiento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvPlaceBirth() As String
            Get
                Return ResourceManager.GetString("rfvPlaceBirth", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Pais de Nacimiento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvPlaceBirthCountry() As String
            Get
                Return ResourceManager.GetString("rfvPlaceBirthCountry", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Departamento de Nacimiento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvPlaceBirthRegion() As String
            Get
                Return ResourceManager.GetString("rfvPlaceBirthRegion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Profesión&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvProfession() As String
            Get
                Return ResourceManager.GetString("rfvProfession", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Programa&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvProgram() As String
            Get
                Return ResourceManager.GetString("rfvProgram", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Dirección&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvResidenceAddress() As String
            Get
                Return ResourceManager.GetString("rfvResidenceAddress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Ciudad&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvResidencePlace() As String
            Get
                Return ResourceManager.GetString("rfvResidencePlace", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Pais&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvResidencePlaceCountry() As String
            Get
                Return ResourceManager.GetString("rfvResidencePlaceCountry", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Departamento&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvResidencePlaceRegion() As String
            Get
                Return ResourceManager.GetString("rfvResidencePlaceRegion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Usuario&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvUserName() As String
            Get
                Return ResourceManager.GetString("rfvUserName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to El Campo &apos;Código Corretaje&apos; es Obligatorio.
        '''</summary>
        Friend Shared ReadOnly Property rfvWanderingsCode() As String
            Get
                Return ResourceManager.GetString("rfvWanderingsCode", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
