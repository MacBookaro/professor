' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:10:33
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class AdministrativeInformation
    Private _AdministrativeInformationId As Guid
    Private _ContractDuration As Integer
    Private _ProfessorCeres As String
    Private _AdmissionDate As Datetime
    Private _PercentageAdministrative As Integer
    Private _PercentageTeaching As Integer
    Private _PercentageResearch As Integer
    Private _PercentageWelfare As Integer
    Private _PercentegeEducation As Integer
    Private _PercentegePaidProyect As Integer
    Private _PercentegeUnpaidProyect As Integer
    Private _PercentageOtherActivities As Integer
    Private _UserId As Guid
    Private _User As String
    Private _ProgramId As Guid
    Private _Program As String
    Private _ContractTypeId As Guid
    Private _ContractType As String
    Private _OrganizationalUnitTypeId As Guid
    Private _OrganizationalUnitType As String
    Private _DedicationProfessorTypeId As Guid
    Private _DedicationProfessorType As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("AdministrativeInformationId")> _
    Public Property AdministrativeInformationId() As Guid
        Get
            Return _AdministrativeInformationId
        End Get
        Set(ByVal value As Guid)
            _AdministrativeInformationId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ContractDuration")> _
    Public Property ContractDuration() As Integer
        Get
            Return _ContractDuration
        End Get
        Set(ByVal value As Integer)
            _ContractDuration = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ProfessorCeres")> _
    Public Property ProfessorCeres() As String
        Get
            Return _ProfessorCeres
        End Get
        Set(ByVal value As String)
            _ProfessorCeres = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("AdmissionDate")> _
    Public Property AdmissionDate() As Datetime
        Get
            Return _AdmissionDate
        End Get
        Set(ByVal value As Datetime)
            _AdmissionDate = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentageAdministrative")> _
    Public Property PercentageAdministrative() As Integer
        Get
            Return _PercentageAdministrative
        End Get
        Set(ByVal value As Integer)
            _PercentageAdministrative = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentageTeaching")> _
    Public Property PercentageTeaching() As Integer
        Get
            Return _PercentageTeaching
        End Get
        Set(ByVal value As Integer)
            _PercentageTeaching = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentageResearch")> _
    Public Property PercentageResearch() As Integer
        Get
            Return _PercentageResearch
        End Get
        Set(ByVal value As Integer)
            _PercentageResearch = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentageWelfare")> _
    Public Property PercentageWelfare() As Integer
        Get
            Return _PercentageWelfare
        End Get
        Set(ByVal value As Integer)
            _PercentageWelfare = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentegeEducation")> _
    Public Property PercentegeEducation() As Integer
        Get
            Return _PercentegeEducation
        End Get
        Set(ByVal value As Integer)
            _PercentegeEducation = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentegePaidProyect")> _
    Public Property PercentegePaidProyect() As Integer
        Get
            Return _PercentegePaidProyect
        End Get
        Set(ByVal value As Integer)
            _PercentegePaidProyect = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentegeUnpaidProyect")> _
    Public Property PercentegeUnpaidProyect() As Integer
        Get
            Return _PercentegeUnpaidProyect
        End Get
        Set(ByVal value As Integer)
            _PercentegeUnpaidProyect = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("PercentageOtherActivities")> _
    Public Property PercentageOtherActivities() As Integer
        Get
            Return _PercentageOtherActivities
        End Get
        Set(ByVal value As Integer)
            _PercentageOtherActivities = value
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

    <Tracing.PropertyDescriptor("ProgramId")> _
    Public Property ProgramId() As Guid
        Get
            Return _ProgramId
        End Get
        Set(ByVal value As Guid)
            _ProgramId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Program")> _
    Public Property Program() As String
        Get
            Return _Program
        End Get
        Set(ByVal value As String)
            _Program = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ContractTypeId")> _
    Public Property ContractTypeId() As Guid
        Get
            Return _ContractTypeId
        End Get
        Set(ByVal value As Guid)
            _ContractTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ContractType")> _
    Public Property ContractType() As String
        Get
            Return _ContractType
        End Get
        Set(ByVal value As String)
            _ContractType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("OrganizationalUnitTypeId")> _
    Public Property OrganizationalUnitTypeId() As Guid
        Get
            Return _OrganizationalUnitTypeId
        End Get
        Set(ByVal value As Guid)
            _OrganizationalUnitTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("OrganizationalUnitType")> _
    Public Property OrganizationalUnitType() As String
        Get
            Return _OrganizationalUnitType
        End Get
        Set(ByVal value As String)
            _OrganizationalUnitType = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("DedicationProfessorTypeId")> _
    Public Property DedicationProfessorTypeId() As Guid
        Get
            Return _DedicationProfessorTypeId
        End Get
        Set(ByVal value As Guid)
            _DedicationProfessorTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("DedicationProfessorType")> _
    Public Property DedicationProfessorType() As String
        Get
            Return _DedicationProfessorType
        End Get
        Set(ByVal value As String)
            _DedicationProfessorType = value
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
        AdministrativeInformationId = Guid.NewGuid
        ContractDuration = 0
        ProfessorCeres = String.Empty
        AdmissionDate = Date.Now
        PercentageAdministrative = 0
        PercentageTeaching = 0
        PercentageResearch = 0
        PercentageWelfare = 0
        PercentegeEducation = 0
        PercentegePaidProyect = 0
        PercentegeUnpaidProyect = 0
        PercentageOtherActivities = 0
        UserId = Guid.Empty
        User = String.Empty
        ProgramId = Guid.Empty
        Program = String.Empty
        ContractTypeId = Guid.Empty
        ContractType = String.Empty
        OrganizationalUnitTypeId = Guid.Empty
        OrganizationalUnitType = String.Empty
        DedicationProfessorTypeId = Guid.Empty
        DedicationProfessorType = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

