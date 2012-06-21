' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 15:42:35
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class OrganizationalUnitTypeHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal organizationalUnitTypeId As Guid) As OrganizationalUnitType
        Dim objOrganizationalUnitType As OrganizationalUnitType = New OrganizationalUnitType
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitType_Read")
        db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, organizationalUnitTypeId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objOrganizationalUnitType
                    If Not Convert.IsDBNull(dataReader("OrganizationalUnitTypeId")) Then .OrganizationalUnitTypeId = dataReader("OrganizationalUnitTypeId")
                    If Not Convert.IsDBNull(dataReader("Code")) Then .Code = dataReader("Code")
                    If Not Convert.IsDBNull(dataReader("Description")) Then .Description = dataReader("Description")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objOrganizationalUnitType
    End Function

    Public Shared Function Create(ByVal objOrganizationalUnitType As OrganizationalUnitType) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitType_Create")
        With objOrganizationalUnitType
            db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, .OrganizationalUnitTypeId)
            db.AddInParameter(dbCommand, "Code", DbType.String, .Code)
            db.AddInParameter(dbCommand, "Description", DbType.String, .Description)
            db.AddInParameter(dbCommand, "CreationUserName", DbType.String, .CreationUserName)
            db.AddInParameter(dbCommand, "CreationDate", DbType.Datetime, .CreationDate)
            db.AddInParameter(dbCommand, "LastChangeUser", DbType.String, .LastChangeUser)
            db.AddInParameter(dbCommand, "LastChangeDate", DbType.Datetime, .LastChangeDate)
            db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, .IsActive)
            db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        End With
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function Update(ByVal objOrganizationalUnitType As OrganizationalUnitType) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitType_Update")
        With objOrganizationalUnitType
            db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, .OrganizationalUnitTypeId)
            db.AddInParameter(dbCommand, "Code", DbType.String, .Code)
            db.AddInParameter(dbCommand, "Description", DbType.String, .Description)
            db.AddInParameter(dbCommand, "CreationUserName", DbType.String, .CreationUserName)
            db.AddInParameter(dbCommand, "CreationDate", DbType.Datetime, .CreationDate)
            db.AddInParameter(dbCommand, "LastChangeUser", DbType.String, .LastChangeUser)
            db.AddInParameter(dbCommand, "LastChangeDate", DbType.Datetime, .LastChangeDate)
            db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, .IsActive)
            db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        End With
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function Delete(ByVal organizationalUnitTypeId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitType_Delete")
        db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, organizationalUnitTypeId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal organizationalUnitTypeId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitType_MoveUp")
        db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, organizationalUnitTypeId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal organizationalUnitTypeId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitType_MoveDown")
        db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, organizationalUnitTypeId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

