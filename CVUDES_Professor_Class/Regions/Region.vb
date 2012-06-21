' ==========================================================================================
' Autor:	Sergio Mejia Arenas
' Fecha:	05/06/2012 16:16:57
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class Region
    Private _RegionId As Guid
    Private _Name As String
    Private _Code As String
    Private _CountryId As Guid
    Private _Country As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("RegionId")> _
    Public Property RegionId() As Guid
        Get
            Return _RegionId
        End Get
        Set(ByVal value As Guid)
            _RegionId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Name")> _
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Code")> _
    Public Property Code() As String
        Get
            Return _Code
        End Get
        Set(ByVal value As String)
            _Code = value
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
        RegionId = Guid.NewGuid
        Name = String.Empty
        Code = String.Empty
        CountryId = Guid.Empty
        Country = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

