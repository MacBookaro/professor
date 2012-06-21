' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:44:46
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class SupportsByUser
    Private _SupportsByUsersId As Guid
    Private _Description As String
    Private _FileSupport As Byte
    Private _FileSize As Integer
    Private _FileType As String
    Private _FileName As String
    Private _IdentificationDoumenTypeId As Guid
    Private _IdentificationDoumenType As String
    Private _UserId As Guid
    Private _User As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("SupportsByUsersId")> _
    Public Property SupportsByUsersId() As Guid
        Get
            Return _SupportsByUsersId
        End Get
        Set(ByVal value As Guid)
            _SupportsByUsersId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Description")> _
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileSupport")> _
    Public Property FileSupport() As Byte
        Get
            Return _FileSupport
        End Get
        Set(ByVal value As Byte)
            _FileSupport = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileSize")> _
    Public Property FileSize() As Integer
        Get
            Return _FileSize
        End Get
        Set(ByVal value As Integer)
            _FileSize = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileType")> _
    Public Property FileType() As String
        Get
            Return _FileType
        End Get
        Set(ByVal value As String)
            _FileType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FileName")> _
    Public Property FileName() As String
        Get
            Return _FileName
        End Get
        Set(ByVal value As String)
            _FileName = value
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
        SupportsByUsersId = Guid.NewGuid
        Description = String.Empty
        FileSize = 0
        FileType = String.Empty
        FileName = String.Empty
        IdentificationDoumenTypeId = Guid.Empty
        IdentificationDoumenType = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

