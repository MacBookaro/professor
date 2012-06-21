' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:28:14
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class RolesByUserHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal rolesByUserId As Guid) As RolesByUser
        Dim objRolesByUser As RolesByUser = New RolesByUser
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolesByUser_Read")
        db.AddInParameter(dbCommand, "RolesByUserId", DbType.Guid, rolesByUserId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objRolesByUser
                    If Not Convert.IsDBNull(dataReader("RolesByUserId")) Then .RolesByUserId = dataReader("RolesByUserId")
                    If Not Convert.IsDBNull(dataReader("RoleId")) Then .RoleId = dataReader("RoleId")
                    If Not Convert.IsDBNull(dataReader("Role")) Then .Role = dataReader("Role")
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("User")) Then .User = dataReader("User")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objRolesByUser
    End Function

    Public Shared Function Create(ByVal objRolesByUser As RolesByUser) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolesByUser_Create")
        With objRolesByUser
            db.AddInParameter(dbCommand, "RolesByUserId", DbType.Guid, .RolesByUserId)
            db.AddInParameter(dbCommand, "RoleId", DbType.Guid, .RoleId)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
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

    Public Shared Function Update(ByVal objRolesByUser As RolesByUser) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolesByUser_Update")
        With objRolesByUser
            db.AddInParameter(dbCommand, "RolesByUserId", DbType.Guid, .RolesByUserId)
            db.AddInParameter(dbCommand, "RoleId", DbType.Guid, .RoleId)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
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

    Public Shared Function Delete(ByVal rolesByUserId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolesByUser_Delete")
        db.AddInParameter(dbCommand, "RolesByUserId", DbType.Guid, rolesByUserId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal rolesByUserId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolesByUser_MoveUp")
        db.AddInParameter(dbCommand, "RolesByUserId", DbType.Guid, rolesByUserId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal rolesByUserId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolesByUser_MoveDown")
        db.AddInParameter(dbCommand, "RolesByUserId", DbType.Guid, rolesByUserId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

