' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:48:39
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class FromAbroadProfessor
    Private _FromAbroadProfessorId As Guid
    Private _EntityName As String
    Private _FundingSourceId As Guid
    Private _FundingSource As String
    Private _CountryId As Guid
    Private _Country As String
    Private _MobilityTypeId As Guid
    Private _MobilityType As String
    Private _UserId As Guid
    Private _User As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("FromAbroadProfessorId")> _
    Public Property FromAbroadProfessorId() As Guid
        Get
            Return _FromAbroadProfessorId
        End Get
        Set(ByVal value As Guid)
            _FromAbroadProfessorId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("EntityName")> _
    Public Property EntityName() As String
        Get
            Return _EntityName
        End Get
        Set(ByVal value As String)
            _EntityName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FundingSourceId")> _
    Public Property FundingSourceId() As Guid
        Get
            Return _FundingSourceId
        End Get
        Set(ByVal value As Guid)
            _FundingSourceId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FundingSource")> _
    Public Property FundingSource() As String
        Get
            Return _FundingSource
        End Get
        Set(ByVal value As String)
            _FundingSource = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CountryId")> _
    Public Property CountryId() As Guid
        Get
            Return _CountryId
        End Get
        Set(ByVal value As Guid)
            _CountryId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Country")> _
    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("MobilityTypeId")> _
    Public Property MobilityTypeId() As Guid
        Get
            Return _MobilityTypeId
        End Get
        Set(ByVal value As Guid)
            _MobilityTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("MobilityType")> _
    Public Property MobilityType() As String
        Get
            Return _MobilityType
        End Get
        Set(ByVal value As String)
            _MobilityType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("UserId")> _
    Public Property UserId() As Guid
        Get
            Return _UserId
        End Get
        Set(ByVal value As Guid)
            _UserId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("User")> _
    Public Property User() As String
        Get
            Return _User
        End Get
        Set(ByVal value As String)
            _User = value
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

    Public Sub New()
        FromAbroadProfessorId = Guid.NewGuid
        EntityName = String.Empty
        FundingSourceId = Guid.Empty
        FundingSource = String.Empty
        CountryId = Guid.Empty
        Country = String.Empty
        MobilityTypeId = Guid.Empty
        MobilityType = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class


