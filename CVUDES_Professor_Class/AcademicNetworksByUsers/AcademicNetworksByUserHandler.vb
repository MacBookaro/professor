' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:04:36
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class AcademicNetworksByUserHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal academicNetworksByUserId As Guid) As AcademicNetworksByUser
        Dim objAcademicNetworksByUser As AcademicNetworksByUser = New AcademicNetworksByUser
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUser_Read")
        db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, academicNetworksByUserId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objAcademicNetworksByUser
                    If Not Convert.IsDBNull(dataReader("AcademicNetworksByUserId")) Then .AcademicNetworksByUserId = dataReader("AcademicNetworksByUserId")
                    If Not Convert.IsDBNull(dataReader("AcademicNetworkId")) Then .AcademicNetworkId = dataReader("AcademicNetworkId")
                    If Not Convert.IsDBNull(dataReader("AcademicNetwork")) Then .AcademicNetwork = dataReader("AcademicNetwork")
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
        Return objAcademicNetworksByUser
    End Function

    Public Shared Function Create(ByVal objAcademicNetworksByUser As AcademicNetworksByUser) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUser_Create")
        With objAcademicNetworksByUser
            db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, .AcademicNetworksByUserId)
            db.AddInParameter(dbCommand, "AcademicNetworkId", DbType.Guid, .AcademicNetworkId)
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

    Public Shared Function Update(ByVal objAcademicNetworksByUser As AcademicNetworksByUser) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUser_Update")
        With objAcademicNetworksByUser
            db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, .AcademicNetworksByUserId)
            db.AddInParameter(dbCommand, "AcademicNetworkId", DbType.Guid, .AcademicNetworkId)
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

    Public Shared Function Delete(ByVal academicNetworksByUserId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUser_Delete")
        db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, academicNetworksByUserId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal academicNetworksByUserId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUser_MoveUp")
        db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, academicNetworksByUserId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal academicNetworksByUserId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUser_MoveDown")
        db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, academicNetworksByUserId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

