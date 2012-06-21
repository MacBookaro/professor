' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:48:39
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class FromAbroadProfessorHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal fromAbroadProfessorId As Guid) As FromAbroadProfessor
        Dim objFromAbroadProfessor As FromAbroadProfessor = New FromAbroadProfessor
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FromAbroadProfessor_Read")
        db.AddInParameter(dbCommand, "FromAbroadProfessorId", DbType.Guid, fromAbroadProfessorId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objFromAbroadProfessor
                    If Not Convert.IsDBNull(dataReader("FromAbroadProfessorId")) Then .FromAbroadProfessorId = dataReader("FromAbroadProfessorId")
                    If Not Convert.IsDBNull(dataReader("EntityName")) Then .EntityName = dataReader("EntityName")
                    If Not Convert.IsDBNull(dataReader("FundingSourceId")) Then .FundingSourceId = dataReader("FundingSourceId")
                    If Not Convert.IsDBNull(dataReader("FundingSource")) Then .FundingSource = dataReader("FundingSource")
                    If Not Convert.IsDBNull(dataReader("CountryId")) Then .CountryId = dataReader("CountryId")
                    If Not Convert.IsDBNull(dataReader("Country")) Then .Country = dataReader("Country")
                    If Not Convert.IsDBNull(dataReader("MobilityTypeId")) Then .MobilityTypeId = dataReader("MobilityTypeId")
                    If Not Convert.IsDBNull(dataReader("MobilityType")) Then .MobilityType = dataReader("MobilityType")
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
        Return objFromAbroadProfessor
    End Function

    Public Shared Function Create(ByVal objFromAbroadProfessor As FromAbroadProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FromAbroadProfessor_Create")
        With objFromAbroadProfessor
            db.AddInParameter(dbCommand, "FromAbroadProfessorId", DbType.Guid, .FromAbroadProfessorId)
            db.AddInParameter(dbCommand, "EntityName", DbType.String, .EntityName)
            db.AddInParameter(dbCommand, "FundingSourceId", DbType.Guid, .FundingSourceId)
            db.AddInParameter(dbCommand, "CountryId", DbType.Guid, .CountryId)
            db.AddInParameter(dbCommand, "MobilityTypeId", DbType.Guid, .MobilityTypeId)
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

    Public Shared Function Update(ByVal objFromAbroadProfessor As FromAbroadProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FromAbroadProfessor_Update")
        With objFromAbroadProfessor
            db.AddInParameter(dbCommand, "FromAbroadProfessorId", DbType.Guid, .FromAbroadProfessorId)
            db.AddInParameter(dbCommand, "EntityName", DbType.String, .EntityName)
            db.AddInParameter(dbCommand, "FundingSourceId", DbType.Guid, .FundingSourceId)
            db.AddInParameter(dbCommand, "CountryId", DbType.Guid, .CountryId)
            db.AddInParameter(dbCommand, "MobilityTypeId", DbType.Guid, .MobilityTypeId)
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

    Public Shared Function Delete(ByVal fromAbroadProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FromAbroadProfessor_Delete")
        db.AddInParameter(dbCommand, "FromAbroadProfessorId", DbType.Guid, fromAbroadProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal fromAbroadProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FromAbroadProfessor_MoveUp")
        db.AddInParameter(dbCommand, "FromAbroadProfessorId", DbType.Guid, fromAbroadProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal fromAbroadProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FromAbroadProfessor_MoveDown")
        db.AddInParameter(dbCommand, "FromAbroadProfessorId", DbType.Guid, fromAbroadProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

