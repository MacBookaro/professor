' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 10:05:51
' Notas:	Archivo de definición de clase
' Modificó: Francisco J. Naranjo - MacBookaro
' Fecha:	14/06/2012 11:05:51
' ==========================================================================================

<Serializable()> Public Class User
    Private _UserId As Guid
    Private _UserName As String
    Private _FirtsName As String
    Private _MiddleName As String
    Private _FirtsSurname As String
    Private _MiddleSurname As String
    Private _IdentificationDoumenTypeId As Guid
    Private _IdentificationDoumenType As String
    Private _IdentificationNumber As String
    Private _IdentificationIssuedLocationId As Guid
    Private _IdentificationIssuedLocation As String
    Private _CellPhoneNumber As String
    Private _CellPhoneNumberAlternative As String
    Private _PhoneNumber As String
    Private _AreaPhoneNumber As String
    Private _FaxPhoneNumber As String
    Private _BirthDate As Datetime
    Private _PlaceBirthId As Guid
    Private _PlaceBirth As String
    Private _ResidenceAddress As String
    Private _ResidenceNeighborhood As String
    Private _PlaceResidenceId As Guid
    Private _PlaceResidence As String
    Private _Email As String
    Private _EmailAlternative As String
    Private _EmailVerified As Boolean
    Private _WebSite As String
    Private _Password As String
    Private _WasVerified As Boolean
    Private _GenderId As Guid
    Private _Gender As String
    Private _MaritalStatusTypeId As Guid
    Private _MaritalStatusType As String
    Private _StateUserTypeId As Guid
    Private _StateUserType As String
    Private _SectionalId As Guid
    Private _Sectional As String
    Private _IsForeign As Boolean
    Private _ForeingCity As String
    Private _ForeingRegion As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean
    'Para guardar el archivo en la BD
    Private _FilePhoto() As Byte
    Private _FileSize As Integer
    Private _FileType As String
    Private _FileName As String
    'Roles del Ususario
    Private _RolesList As String
    'Fecha Inicio Sesión
    Private _CurrentSessionDate As String

    <Tracing.PropertyDescriptor("UserId")> _
    Public Property UserId() As Guid
        Get
            Return _UserId
        End Get
        Set(ByVal value As Guid)
            _UserId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("UserName")> _
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FirtsName")> _
    Public Property FirtsName() As String
        Get
            Return _FirtsName
        End Get
        Set(ByVal value As String)
            _FirtsName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("MiddleName")> _
    Public Property MiddleName() As String
        Get
            Return _MiddleName
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FirtsSurname")> _
    Public Property FirtsSurname() As String
        Get
            Return _FirtsSurname
        End Get
        Set(ByVal value As String)
            _FirtsSurname = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("MiddleSurname")> _
    Public Property MiddleSurname() As String
        Get
            Return _MiddleSurname
        End Get
        Set(ByVal value As String)
            _MiddleSurname = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IdentificationDoumenTypeId")> _
    Public Property IdentificationDoumenTypeId() As Guid
        Get
            Return _IdentificationDoumenTypeId
        End Get
        Set(ByVal value As Guid)
            _IdentificationDoumenTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IdentificationDoumenType")> _
    Public Property IdentificationDoumenType() As String
        Get
            Return _IdentificationDoumenType
        End Get
        Set(ByVal value As String)
            _IdentificationDoumenType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IdentificationNumber")> _
    Public Property IdentificationNumber() As String
        Get
            Return _IdentificationNumber
        End Get
        Set(ByVal value As String)
            _IdentificationNumber = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IdentificationIssuedLocationId")> _
    Public Property IdentificationIssuedLocationId() As Guid
        Get
            Return _IdentificationIssuedLocationId
        End Get
        Set(ByVal value As Guid)
            _IdentificationIssuedLocationId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IdentificationIssuedLocation")> _
    Public Property IdentificationIssuedLocation() As String
        Get
            Return _IdentificationIssuedLocation
        End Get
        Set(ByVal value As String)
            _IdentificationIssuedLocation = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CellPhoneNumber")> _
    Public Property CellPhoneNumber() As String
        Get
            Return _CellPhoneNumber
        End Get
        Set(ByVal value As String)
            _CellPhoneNumber = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CellPhoneNumberAlternative")> _
    Public Property CellPhoneNumberAlternative() As String
        Get
            Return _CellPhoneNumberAlternative
        End Get
        Set(ByVal value As String)
            _CellPhoneNumberAlternative = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PhoneNumber")> _
    Public Property PhoneNumber() As String
        Get
            Return _PhoneNumber
        End Get
        Set(ByVal value As String)
            _PhoneNumber = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("AreaPhoneNumber")> _
    Public Property AreaPhoneNumber() As String
        Get
            Return _AreaPhoneNumber
        End Get
        Set(ByVal value As String)
            _AreaPhoneNumber = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FaxPhoneNumber")> _
    Public Property FaxPhoneNumber() As String
        Get
            Return _FaxPhoneNumber
        End Get
        Set(ByVal value As String)
            _FaxPhoneNumber = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("BirthDate")> _
    Public Property BirthDate() As Datetime
        Get
            Return _BirthDate
        End Get
        Set(ByVal value As Datetime)
            _BirthDate = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PlaceBirthId")> _
    Public Property PlaceBirthId() As Guid
        Get
            Return _PlaceBirthId
        End Get
        Set(ByVal value As Guid)
            _PlaceBirthId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PlaceBirth")> _
    Public Property PlaceBirth() As String
        Get
            Return _PlaceBirth
        End Get
        Set(ByVal value As String)
            _PlaceBirth = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ResidenceAddress")> _
    Public Property ResidenceAddress() As String
        Get
            Return _ResidenceAddress
        End Get
        Set(ByVal value As String)
            _ResidenceAddress = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ResidenceNeighborhood")> _
    Public Property ResidenceNeighborhood() As String
        Get
            Return _ResidenceNeighborhood
        End Get
        Set(ByVal value As String)
            _ResidenceNeighborhood = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PlaceResidenceId")> _
    Public Property PlaceResidenceId() As Guid
        Get
            Return _PlaceResidenceId
        End Get
        Set(ByVal value As Guid)
            _PlaceResidenceId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PlaceResidence")> _
    Public Property PlaceResidence() As String
        Get
            Return _PlaceResidence
        End Get
        Set(ByVal value As String)
            _PlaceResidence = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Email")> _
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("EmailAlternative")> _
    Public Property EmailAlternative() As String
        Get
            Return _EmailAlternative
        End Get
        Set(ByVal value As String)
            _EmailAlternative = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("EmailVerified")> _
    Public Property EmailVerified() As Boolean
        Get
            Return _EmailVerified
        End Get
        Set(ByVal value As Boolean)
            _EmailVerified = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("WebSite")> _
    Public Property WebSite() As String
        Get
            Return _WebSite
        End Get
        Set(ByVal value As String)
            _WebSite = value
        End Set
    End Property

    'Para Guardar el soporte en la BD
    <Tracing.PropertyDescriptor("FilePhoto")> _
    Public Property FilePhoto() As Byte()
        Get
            Return _FilePhoto
        End Get
        Set(ByVal value As Byte())
            _FilePhoto = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileSize")> _
    Public Property FileSize As Integer
        Get
            Return Me._FileSize
        End Get
        Set(ByVal value As Integer)
            Me._FileSize = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileType")> _
    Public Property FileType As String
        Get
            Return Me._FileType
        End Get
        Set(ByVal value As String)
            Me._FileType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileName")> _
    Public Property FileName As String
        Get
            Return Me._FileName
        End Get
        Set(ByVal value As String)
            Me._FileName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Password")> _
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("WasVerified")> _
    Public Property WasVerified() As Boolean
        Get
            Return _WasVerified
        End Get
        Set(ByVal value As Boolean)
            _WasVerified = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("GenderId")> _
    Public Property GenderId() As Guid
        Get
            Return _GenderId
        End Get
        Set(ByVal value As Guid)
            _GenderId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Gender")> _
    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("MaritalStatusTypeId")> _
    Public Property MaritalStatusTypeId() As Guid
        Get
            Return _MaritalStatusTypeId
        End Get
        Set(ByVal value As Guid)
            _MaritalStatusTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("MaritalStatusType")> _
    Public Property MaritalStatusType() As String
        Get
            Return _MaritalStatusType
        End Get
        Set(ByVal value As String)
            _MaritalStatusType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StateUserTypeId")> _
    Public Property StateUserTypeId() As Guid
        Get
            Return _StateUserTypeId
        End Get
        Set(ByVal value As Guid)
            _StateUserTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StateUserType")> _
    Public Property StateUserType() As String
        Get
            Return _StateUserType
        End Get
        Set(ByVal value As String)
            _StateUserType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("SectionalId")> _
    Public Property SectionalId() As Guid
        Get
            Return _SectionalId
        End Get
        Set(ByVal value As Guid)
            _SectionalId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Sectional")> _
    Public Property Sectional() As String
        Get
            Return _Sectional
        End Get
        Set(ByVal value As String)
            _Sectional = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IsForeign")> _
    Public Property IsForeign() As Boolean
        Get
            Return _IsForeign
        End Get
        Set(ByVal value As Boolean)
            _IsForeign = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ForeingCity")> _
    Public Property ForeingCity() As String
        Get
            Return _ForeingCity
        End Get
        Set(ByVal value As String)
            _ForeingCity = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ForeingRegion")> _
    Public Property ForeingRegion() As String
        Get
            Return _ForeingRegion
        End Get
        Set(ByVal value As String)
            _ForeingRegion = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CreationUserName")> _
    Public Property CreationUserName() As String
        Get
            Return _CreationUserName
        End Get
        Set(ByVal value As String)
            _CreationUserName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CreationDate")> _
    Public Property CreationDate() As Datetime
        Get
            Return _CreationDate
        End Get
        Set(ByVal value As Datetime)
            _CreationDate = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("LastChangeUser")> _
    Public Property LastChangeUser() As String
        Get
            Return _LastChangeUser
        End Get
        Set(ByVal value As String)
            _LastChangeUser = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("LastChangeDate")> _
    Public Property LastChangeDate() As Datetime
        Get
            Return _LastChangeDate
        End Get
        Set(ByVal value As Datetime)
            _LastChangeDate = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IsActive")> _
    Public Property IsActive() As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property

    'Roles por Usuario
    <Tracing.PropertyDescriptor("RolesList")> _
    Public Property RolesList() As String
        Get
            Return _RolesList
        End Get
        Set(ByVal value As String)
            _RolesList = value
        End Set
    End Property

    'Fecha de Inicio de la sesión
    <Tracing.PropertyDescriptor("CurrentSessionDate")> _
    Public Property CurrentSessionDate() As String
        Get
            Return _CurrentSessionDate
        End Get
        Set(ByVal value As String)
            _CurrentSessionDate = value
        End Set
    End Property


    Public Sub New()
        UserId = Guid.NewGuid
        UserName = String.Empty
        FirtsName = String.Empty
        MiddleName = String.Empty
        FirtsSurname = String.Empty
        MiddleSurname = String.Empty
        IdentificationDoumenTypeId = Guid.Empty
        IdentificationDoumenType = String.Empty
        IdentificationNumber = String.Empty
        IdentificationIssuedLocationId = Guid.Empty
        IdentificationIssuedLocation = String.Empty
        CellPhoneNumber = String.Empty
        CellPhoneNumberAlternative = String.Empty
        PhoneNumber = String.Empty
        AreaPhoneNumber = String.Empty
        FaxPhoneNumber = String.Empty
        BirthDate = Date.Now
        PlaceBirthId = Guid.Empty
        PlaceBirth = String.Empty
        ResidenceAddress = String.Empty
        ResidenceNeighborhood = String.Empty
        PlaceResidenceId = Guid.Empty
        PlaceResidence = String.Empty
        Email = String.Empty
        EmailAlternative = String.Empty
        EmailVerified = False
        WebSite = String.Empty
        Password = String.Empty
        WasVerified = False
        GenderId = Guid.Empty
        Gender = String.Empty
        MaritalStatusTypeId = Guid.Empty
        MaritalStatusType = String.Empty
        StateUserTypeId = Guid.Empty
        StateUserType = String.Empty
        SectionalId = Guid.Empty
        Sectional = String.Empty
        IsForeign = False
        ForeingCity = String.Empty
        ForeingRegion = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
        'Para guardar el soporte en la BD
        ' El campo FilePhoto no se incluye en el constructor
        FileSize = 0
        FileType = String.Empty
        FileName = String.Empty
        'Roles por Usuario
        RolesList = String.Empty
        'Fecha de Inicio de la sesión
        CurrentSessionDate = Date.Now
    End Sub

End Class


