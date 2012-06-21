﻿' ==========================================================================================
' Autor:	Sergio Mejia Arenas
' Fecha:	05/06/2012 16:54:51
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class TrainingInformalByProfessor
    Private _TrainingInformalByProfessorsId As Guid
    Private _DegreeFrom As String
    Private _TrainingTypeId As Guid
    Private _TrainingType As String
    Private _FundingIesTypeId As Guid
    Private _FundingIesType As String
    Private _CourseTopicId As Guid
    Private _CourseTopic As String
    Private _CountryId As Guid
    Private _Country As String
    Private _IesId As Guid
    Private _Ies As String
    Private _CourseNonformalTypeId As Guid
    Private _CourseNonformalType As String
    Private _DateTraining As Datetime
    Private _OtherIes As String
    Private _UserId As Guid
    Private _User As String
    Private _FileSupport As Byte
    Private _FileSize As Integer
    Private _FileType As String
    Private _FileName As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("TrainingInformalByProfessorsId")> _
    Public Property TrainingInformalByProfessorsId() As Guid
        Get
            Return _TrainingInformalByProfessorsId
        End Get
        Set(ByVal value As Guid)
            _TrainingInformalByProfessorsId = value
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

    <Tracing.PropertyDescriptor("TrainingTypeId")> _
    Public Property TrainingTypeId() As Guid
        Get
            Return _TrainingTypeId
        End Get
        Set(ByVal value As Guid)
            _TrainingTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("TrainingType")> _
    Public Property TrainingType() As String
        Get
            Return _TrainingType
        End Get
        Set(ByVal value As String)
            _TrainingType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FundingIesTypeId")> _
    Public Property FundingIesTypeId() As Guid
        Get
            Return _FundingIesTypeId
        End Get
        Set(ByVal value As Guid)
            _FundingIesTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FundingIesType")> _
    Public Property FundingIesType() As String
        Get
            Return _FundingIesType
        End Get
        Set(ByVal value As String)
            _FundingIesType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CourseTopicId")> _
    Public Property CourseTopicId() As Guid
        Get
            Return _CourseTopicId
        End Get
        Set(ByVal value As Guid)
            _CourseTopicId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CourseTopic")> _
    Public Property CourseTopic() As String
        Get
            Return _CourseTopic
        End Get
        Set(ByVal value As String)
            _CourseTopic = value
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

    <Tracing.PropertyDescriptor("CourseNonformalTypeId")> _
    Public Property CourseNonformalTypeId() As Guid
        Get
            Return _CourseNonformalTypeId
        End Get
        Set(ByVal value As Guid)
            _CourseNonformalTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CourseNonformalType")> _
    Public Property CourseNonformalType() As String
        Get
            Return _CourseNonformalType
        End Get
        Set(ByVal value As String)
            _CourseNonformalType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("DateTraining")> _
    Public Property DateTraining() As Datetime
        Get
            Return _DateTraining
        End Get
        Set(ByVal value As Datetime)
            _DateTraining = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("OtherIes")> _
    Public Property OtherIes() As String
        Get
            Return _OtherIes
        End Get
        Set(ByVal value As String)
            _OtherIes = value
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
        TrainingInformalByProfessorsId = Guid.NewGuid
        DegreeFrom = String.Empty
        TrainingTypeId = Guid.Empty
        TrainingType = String.Empty
        FundingIesTypeId = Guid.Empty
        FundingIesType = String.Empty
        CourseTopicId = Guid.Empty
        CourseTopic = String.Empty
        CountryId = Guid.Empty
        Country = String.Empty
        IesId = Guid.Empty
        Ies = String.Empty
        CourseNonformalTypeId = Guid.Empty
        CourseNonformalType = String.Empty
        DateTraining = Date.Now
        OtherIes = String.Empty
        UserId = Guid.Empty
        User = String.Empty
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

