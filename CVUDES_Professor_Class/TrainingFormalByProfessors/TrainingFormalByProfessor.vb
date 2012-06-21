' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:51:30
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class TrainingFormalByProfessor
    Private _TrainingFormalByProfessorId As Guid
    Private _IesId As Guid
    Private _Ies As String
    Private _StartDate As Datetime
    Private _EndingDate As Datetime
    Private _StudyLevelId As Guid
    Private _StudyLevel As String
    Private _UserId As Guid
    Private _User As String
    Private _CountryId As Guid
    Private _Country As String
    Private _NbcId As Guid
    Private _Nbc As String
    Private _DegreeFrom As String
    Private _AnotherUniversity As String
    Private _FileSupport As Byte
    Private _FileSize As Integer
    Private _FileType As String
    Private _FileName As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("TrainingFormalByProfessorId")> _
    Public Property TrainingFormalByProfessorId() As Guid
        Get
            Return _TrainingFormalByProfessorId
        End Get
        Set(ByVal value As Guid)
            _TrainingFormalByProfessorId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("IesId")> _
    Public Property IesId() As Guid
        Get
            Return _IesId
        End Get
        Set(ByVal value As Guid)
            _IesId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Ies")> _
    Public Property Ies() As String
        Get
            Return _Ies
        End Get
        Set(ByVal value As String)
            _Ies = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StartDate")> _
    Public Property StartDate() As Datetime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As Datetime)
            _StartDate = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("EndingDate")> _
    Public Property EndingDate() As Datetime
        Get
            Return _EndingDate
        End Get
        Set(ByVal value As Datetime)
            _EndingDate = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StudyLevelId")> _
    Public Property StudyLevelId() As Guid
        Get
            Return _StudyLevelId
        End Get
        Set(ByVal value As Guid)
            _StudyLevelId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StudyLevel")> _
    Public Property StudyLevel() As String
        Get
            Return _StudyLevel
        End Get
        Set(ByVal value As String)
            _StudyLevel = value
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

    <Tracing.PropertyDescriptor("NbcId")> _
    Public Property NbcId() As Guid
        Get
            Return _NbcId
        End Get
        Set(ByVal value As Guid)
            _NbcId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Nbc")> _
    Public Property Nbc() As String
        Get
            Return _Nbc
        End Get
        Set(ByVal value As String)
            _Nbc = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("DegreeFrom")> _
    Public Property DegreeFrom() As String
        Get
            Return _DegreeFrom
        End Get
        Set(ByVal value As String)
            _DegreeFrom = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("AnotherUniversity")> _
    Public Property AnotherUniversity() As String
        Get
            Return _AnotherUniversity
        End Get
        Set(ByVal value As String)
            _AnotherUniversity = value
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
        TrainingFormalByProfessorId = Guid.NewGuid
        IesId = Guid.Empty
        Ies = String.Empty
        StartDate = Date.Now
        EndingDate = Date.Now
        StudyLevelId = Guid.Empty
        StudyLevel = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CountryId = Guid.Empty
        Country = String.Empty
        NbcId = Guid.Empty
        Nbc = String.Empty
        DegreeFrom = String.Empty
        AnotherUniversity = String.Empty
        FileSize = 0
        FileType = String.Empty
        FileName = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

