' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:28:14
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class RolesByUser
    Private _RolesByUserId As Guid
    Private _RoleId As Guid
    Private _Role As String
    Private _UserId As Guid
    Private _User As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("RolesByUserId")> _
    Public Property RolesByUserId() As Guid
        Get
            Return _RolesByUserId
        End Get
        Set(ByVal value As Guid)
            _RolesByUserId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("RoleId")> _
    Public Property RoleId() As Guid
        Get
            Return _RoleId
        End Get
        Set(ByVal value As Guid)
            _RoleId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Role")> _
    Public Property Role() As String
        Get
            Return _Role
        End Get
        Set(ByVal value As String)
            _Role = value
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
        RolesByUserId = Guid.NewGuid
        RoleId = Guid.Empty
        Role = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

