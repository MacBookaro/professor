' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 10:50:55
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class AbroadProfessor
    Private _AbroadProfessorId As Guid
    Private _StartDate As Datetime
    Private _EndingDate As Datetime
    Private _WorthTrip As Integer
    Private _AmountFinanced As Integer
    Private _FinancingEntityName As String
    Private _FundingTypeId As Guid
    Private _FundingType As String
    Private _MobilityTypeId As Guid
    Private _MobilityType As String
    Private _UserId As Guid
    Private _User As String
    Private _CountryIdDestination As Guid
    Private _CountryIdFunder As Guid
    Private _FundingSourceId As Guid
    Private _FundingSource As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("AbroadProfessorId")> _
    Public Property AbroadProfessorId() As Guid
        Get
            Return _AbroadProfessorId
        End Get
        Set(ByVal value As Guid)
            _AbroadProfessorId = value
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

    <Tracing.PropertyDescriptor("WorthTrip")> _
    Public Property WorthTrip() As Integer
        Get
            Return _WorthTrip
        End Get
        Set(ByVal value As Integer)
            _WorthTrip = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("AmountFinanced")> _
    Public Property AmountFinanced() As Integer
        Get
            Return _AmountFinanced
        End Get
        Set(ByVal value As Integer)
            _AmountFinanced = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FinancingEntityName")> _
    Public Property FinancingEntityName() As String
        Get
            Return _FinancingEntityName
        End Get
        Set(ByVal value As String)
            _FinancingEntityName = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FundingTypeId")> _
    Public Property FundingTypeId() As Guid
        Get
            Return _FundingTypeId
        End Get
        Set(ByVal value As Guid)
            _FundingTypeId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("FundingType")> _
    Public Property FundingType() As String
        Get
            Return _FundingType
        End Get
        Set(ByVal value As String)
            _FundingType = value
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

    <Tracing.PropertyDescriptor("CountryIdDestination")> _
    Public Property CountryIdDestination() As Guid
        Get
            Return _CountryIdDestination
        End Get
        Set(ByVal value As Guid)
            _CountryIdDestination = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CountryIdFunder")> _
    Public Property CountryIdFunder() As Guid
        Get
            Return _CountryIdFunder
        End Get
        Set(ByVal value As Guid)
            _CountryIdFunder = value
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
        AbroadProfessorId = Guid.NewGuid
        StartDate = Date.Now
        EndingDate = Date.Now
        WorthTrip = 0
        AmountFinanced = 0
        FinancingEntityName = String.Empty
        FundingTypeId = Guid.Empty
        FundingType = String.Empty
        MobilityTypeId = Guid.Empty
        MobilityType = String.Empty
        UserId = Guid.Empty
        User = String.Empty
        CountryIdDestination = Guid.Empty
        CountryIdFunder = Guid.Empty
        FundingSourceId = Guid.Empty
        FundingSource = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

