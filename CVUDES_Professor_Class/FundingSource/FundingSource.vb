' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 14:11:38
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class FundingSource
    Private _FundingSourceId As Guid
    Private _Code As String
    Private _Description As String
    Private _FundingTypeId As Guid
    Private _FundingType As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("FundingSourceId")> _
    Public Property FundingSourceId() As Guid
        Get
            Return _FundingSourceId
        End Get
        Set(ByVal value As Guid)
            _FundingSourceId = value
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

    <Tracing.PropertyDescriptor("Description")> _
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
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
        FundingSourceId = Guid.NewGuid
        Code = String.Empty
        Description = String.Empty
        FundingTypeId = Guid.Empty
        FundingType = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

