' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:12:44
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class PublicationsByProfessor
    Private _PublicationsByProfessorId As Guid
    Private _DatePublication As Datetime
    Private _Description As String
    Private _FileSupport As Byte
    Private _FileSize As Integer
    Private _FileType As String
    Private _FileName As String
    Private _PublicationTypeId As Guid
    Private _PublicationType As String
    Private _UserId As Guid
    Private _User As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("PublicationsByProfessorId")> _
    Public Property PublicationsByProfessorId() As Guid
        Get
            Return _PublicationsByProfessorId
        End Get
        Set(ByVal value As Guid)
            _PublicationsByProfessorId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("DatePublication")> _
    Public Property DatePublication() As Datetime
        Get
            Return _DatePublication
        End Get
        Set(ByVal value As Datetime)
            _DatePublication = value
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

    <Tracing.PropertyDescriptor("PublicationTypeId")> _
    Public Property PublicationTypeId() As Guid
        Get
            Return _PublicationTypeId
        End Get
        Set(ByVal value As Guid)
            _PublicationTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PublicationType")> _
    Public Property PublicationType() As String
        Get
            Return _PublicationType
        End Get
        Set(ByVal value As String)
            _PublicationType = value
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
        PublicationsByProfessorId = Guid.NewGuid
        DatePublication = Date.Now
        Description = String.Empty
        FileSize = 0
        FileType = String.Empty
        FileName = String.Empty
        PublicationTypeId = Guid.Empty
        PublicationType = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

