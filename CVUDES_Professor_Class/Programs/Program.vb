' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 15:47:38
' Notas:	Archivo de definición de clase
' ==========================================================================================

<Serializable()> Public Class Program
    Private _ProgramId As Guid
    Private _Name As String
    Private _ProConsecutive As String
    Private _StateProgramId As String
    Private _StateProgram As String
    Private _ModalitiyId As Guid
    Private _Modalitiy As String
    Private _CityId As Guid
    Private _City As String
    Private _CreationUserName As String
    Private _CreationDate As Datetime
    Private _LastChangeUser As String
    Private _LastChangeDate As Datetime
    Private _IsActive As Boolean

    <Tracing.PropertyDescriptor("ProgramId")> _
    Public Property ProgramId() As Guid
        Get
            Return _ProgramId
        End Get
        Set(ByVal value As Guid)
            _ProgramId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Name")> _
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ProConsecutive")> _
    Public Property ProConsecutive() As String
        Get
            Return _ProConsecutive
        End Get
        Set(ByVal value As String)
            _ProConsecutive = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StateProgramId")> _
    Public Property StateProgramId() As String
        Get
            Return _StateProgramId
        End Get
        Set(ByVal value As String)
            _StateProgramId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("StateProgram")> _
    Public Property StateProgram() As String
        Get
            Return _StateProgram
        End Get
        Set(ByVal value As String)
            _StateProgram = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("ModalitiyId")> _
    Public Property ModalitiyId() As Guid
        Get
            Return _ModalitiyId
        End Get
        Set(ByVal value As Guid)
            _ModalitiyId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("Modalitiy")> _
    Public Property Modalitiy() As String
        Get
            Return _Modalitiy
        End Get
        Set(ByVal value As String)
            _Modalitiy = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("CityId")> _
    Public Property CityId() As Guid
        Get
            Return _CityId
        End Get
        Set(ByVal value As Guid)
            _CityId = value
        End Set
    End Property

    <Tracing.PropertyDescriptor("City")> _
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
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
        ProgramId = Guid.NewGuid
        Name = String.Empty
        ProConsecutive = String.Empty
        StateProgramId = String.Empty
        StateProgram = String.Empty
        ModalitiyId = Guid.Empty
        Modalitiy = String.Empty
        CityId = Guid.Empty
        City = String.Empty
        CreationUserName = String.Empty
        CreationDate = Date.Now
        LastChangeUser = String.Empty
        LastChangeDate = Date.Now
        IsActive = False
    End Sub

End Class

