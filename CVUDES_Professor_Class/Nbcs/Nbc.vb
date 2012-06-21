' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 15:39:39
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class Nbc
    Private _NbcId As Guid
    Private _Description As String
    Private _Code As String
    Private _Specific As String
    Private _KnowledgeAreaId As Guid
    Private _KnowledgeArea As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("NbcId")> _
    Public Property NbcId() As Guid
        Get
            Return _NbcId
        End Get
        Set(ByVal value As Guid)
            _NbcId = value
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

    <Tracing.PropertyDescriptor("Code")> _
    Public Property Code() As String
        Get
            Return _Code
        End Get
        Set(ByVal value As String)
            _Code = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Specific")> _
    Public Property Specific() As String
        Get
            Return _Specific
        End Get
        Set(ByVal value As String)
            _Specific = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("KnowledgeAreaId")> _
    Public Property KnowledgeAreaId() As Guid
        Get
            Return _KnowledgeAreaId
        End Get
        Set(ByVal value As Guid)
            _KnowledgeAreaId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("KnowledgeArea")> _
    Public Property KnowledgeArea() As String
        Get
            Return _KnowledgeArea
        End Get
        Set(ByVal value As String)
            _KnowledgeArea = value
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
        NbcId = Guid.NewGuid
        Description = String.Empty
        Code = String.Empty
        Specific = String.Empty
        KnowledgeAreaId = Guid.Empty
        KnowledgeArea = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

