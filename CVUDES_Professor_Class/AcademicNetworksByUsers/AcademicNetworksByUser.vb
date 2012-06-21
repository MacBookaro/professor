' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:04:36
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class AcademicNetworksByUser
    Private _AcademicNetworksByUserId As Guid
    Private _AcademicNetworkId As Guid
    Private _AcademicNetwork As String
    Private _UserId As Guid
    Private _User As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("AcademicNetworksByUserId")> _
    Public Property AcademicNetworksByUserId() As Guid
        Get
            Return _AcademicNetworksByUserId
        End Get
        Set(ByVal value As Guid)
            _AcademicNetworksByUserId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("AcademicNetworkId")> _
    Public Property AcademicNetworkId() As Guid
        Get
            Return _AcademicNetworkId
        End Get
        Set(ByVal value As Guid)
            _AcademicNetworkId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("AcademicNetwork")> _
    Public Property AcademicNetwork() As String
        Get
            Return _AcademicNetwork
        End Get
        Set(ByVal value As String)
            _AcademicNetwork = value
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
        AcademicNetworksByUserId = Guid.NewGuid
        AcademicNetworkId = Guid.Empty
        AcademicNetwork = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

