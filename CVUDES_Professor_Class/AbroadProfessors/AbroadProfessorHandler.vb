' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 10:49:27
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class AbroadProfessorHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal abroadProfessorId As Guid) As AbroadProfessor
        Dim objAbroadProfessor As AbroadProfessor = New AbroadProfessor
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessor_Read")
        db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, abroadProfessorId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objAbroadProfessor
                    If Not Convert.IsDBNull(dataReader("AbroadProfessorId")) Then .AbroadProfessorId = dataReader("AbroadProfessorId")
                    If Not Convert.IsDBNull(dataReader("StartDate")) Then .StartDate = dataReader("StartDate")
                    If Not Convert.IsDBNull(dataReader("EndingDate")) Then .EndingDate = dataReader("EndingDate")
                    If Not Convert.IsDBNull(dataReader("WorthTrip")) Then .WorthTrip = dataReader("WorthTrip")
                    If Not Convert.IsDBNull(dataReader("AmountFinanced")) Then .AmountFinanced = dataReader("AmountFinanced")
                    If Not Convert.IsDBNull(dataReader("FinancingEntityName")) Then .FinancingEntityName = dataReader("FinancingEntityName")
                    If Not Convert.IsDBNull(dataReader("FundingTypeId")) Then .FundingTypeId = dataReader("FundingTypeId")
                    If Not Convert.IsDBNull(dataReader("FundingType")) Then .FundingType = dataReader("FundingType")
                    If Not Convert.IsDBNull(dataReader("MobilityTypeId")) Then .MobilityTypeId = dataReader("MobilityTypeId")
                    If Not Convert.IsDBNull(dataReader("MobilityType")) Then .MobilityType = dataReader("MobilityType")
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("User")) Then .User = dataReader("User")
                    If Not Convert.IsDBNull(dataReader("CountryIdDestination")) Then .CountryIdDestination = dataReader("CountryIdDestination")
                    If Not Convert.IsDBNull(dataReader("CountryIdFunder")) Then .CountryIdFunder = dataReader("CountryIdFunder")
                    If Not Convert.IsDBNull(dataReader("FundingSourceId")) Then .FundingSourceId = dataReader("FundingSourceId")
                    If Not Convert.IsDBNull(dataReader("FundingSource")) Then .FundingSource = dataReader("FundingSource")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objAbroadProfessor
    End Function

    Public Shared Function Create(ByVal objAbroadProfessor As AbroadProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessor_Create")
        With objAbroadProfessor
            db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, .AbroadProfessorId)
            db.AddInParameter(dbCommand, "StartDate", DbType.Datetime, .StartDate)
            db.AddInParameter(dbCommand, "EndingDate", DbType.Datetime, .EndingDate)
            db.AddInParameter(dbCommand, "WorthTrip", DbType.Int32, .WorthTrip)
            db.AddInParameter(dbCommand, "AmountFinanced", DbType.Int32, .AmountFinanced)
            db.AddInParameter(dbCommand, "FinancingEntityName", DbType.String, .FinancingEntityName)
            db.AddInParameter(dbCommand, "FundingTypeId", DbType.Guid, .FundingTypeId)
            db.AddInParameter(dbCommand, "MobilityTypeId", DbType.Guid, .MobilityTypeId)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "CountryIdDestination", DbType.Guid, .CountryIdDestination)
            db.AddInParameter(dbCommand, "CountryIdFunder", DbType.Guid, .CountryIdFunder)
            db.AddInParameter(dbCommand, "FundingSourceId", DbType.Guid, .FundingSourceId)
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

    Public Shared Function Update(ByVal objAbroadProfessor As AbroadProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessor_Update")
        With objAbroadProfessor
            db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, .AbroadProfessorId)
            db.AddInParameter(dbCommand, "StartDate", DbType.Datetime, .StartDate)
            db.AddInParameter(dbCommand, "EndingDate", DbType.Datetime, .EndingDate)
            db.AddInParameter(dbCommand, "WorthTrip", DbType.Int32, .WorthTrip)
            db.AddInParameter(dbCommand, "AmountFinanced", DbType.Int32, .AmountFinanced)
            db.AddInParameter(dbCommand, "FinancingEntityName", DbType.String, .FinancingEntityName)
            db.AddInParameter(dbCommand, "FundingTypeId", DbType.Guid, .FundingTypeId)
            db.AddInParameter(dbCommand, "MobilityTypeId", DbType.Guid, .MobilityTypeId)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "CountryIdDestination", DbType.Guid, .CountryIdDestination)
            db.AddInParameter(dbCommand, "CountryIdFunder", DbType.Guid, .CountryIdFunder)
            db.AddInParameter(dbCommand, "FundingSourceId", DbType.Guid, .FundingSourceId)
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

    Public Shared Function Delete(ByVal abroadProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessor_Delete")
        db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, abroadProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal abroadProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessor_MoveUp")
        db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, abroadProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal abroadProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessor_MoveDown")
        db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, abroadProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

