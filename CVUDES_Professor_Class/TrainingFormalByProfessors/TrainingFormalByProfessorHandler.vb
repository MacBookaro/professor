' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:51:30
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class TrainingFormalByProfessorHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal trainingFormalByProfessorId As Guid) As TrainingFormalByProfessor
        Dim objTrainingFormalByProfessor As TrainingFormalByProfessor = New TrainingFormalByProfessor
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingFormalByProfessor_Read")
        db.AddInParameter(dbCommand, "TrainingFormalByProfessorId", DbType.Guid, trainingFormalByProfessorId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objTrainingFormalByProfessor
                    If Not Convert.IsDBNull(dataReader("TrainingFormalByProfessorId")) Then .TrainingFormalByProfessorId = dataReader("TrainingFormalByProfessorId")
                    If Not Convert.IsDBNull(dataReader("IesId")) Then .IesId = dataReader("IesId")
                    If Not Convert.IsDBNull(dataReader("Ies")) Then .Ies = dataReader("Ies")
                    If Not Convert.IsDBNull(dataReader("StartDate")) Then .StartDate = dataReader("StartDate")
                    If Not Convert.IsDBNull(dataReader("EndingDate")) Then .EndingDate = dataReader("EndingDate")
                    If Not Convert.IsDBNull(dataReader("StudyLevelId")) Then .StudyLevelId = dataReader("StudyLevelId")
                    If Not Convert.IsDBNull(dataReader("StudyLevel")) Then .StudyLevel = dataReader("StudyLevel")
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("User")) Then .User = dataReader("User")
                    If Not Convert.IsDBNull(dataReader("CountryId")) Then .CountryId = dataReader("CountryId")
                    If Not Convert.IsDBNull(dataReader("Country")) Then .Country = dataReader("Country")
                    If Not Convert.IsDBNull(dataReader("NbcId")) Then .NbcId = dataReader("NbcId")
                    If Not Convert.IsDBNull(dataReader("Nbc")) Then .Nbc = dataReader("Nbc")
                    If Not Convert.IsDBNull(dataReader("DegreeFrom")) Then .DegreeFrom = dataReader("DegreeFrom")
                    If Not Convert.IsDBNull(dataReader("AnotherUniversity")) Then .AnotherUniversity = dataReader("AnotherUniversity")
                    If Not Convert.IsDBNull(dataReader("FileSupport")) Then .FileSupport = dataReader("FileSupport")
                    If Not Convert.IsDBNull(dataReader("FileSize")) Then .FileSize = dataReader("FileSize")
                    If Not Convert.IsDBNull(dataReader("FileType")) Then .FileType = dataReader("FileType")
                    If Not Convert.IsDBNull(dataReader("FileName")) Then .FileName = dataReader("FileName")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objTrainingFormalByProfessor
    End Function

    Public Shared Function Create(ByVal objTrainingFormalByProfessor As TrainingFormalByProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingFormalByProfessor_Create")
        With objTrainingFormalByProfessor
            db.AddInParameter(dbCommand, "TrainingFormalByProfessorId", DbType.Guid, .TrainingFormalByProfessorId)
            db.AddInParameter(dbCommand, "IesId", DbType.Guid, .IesId)
            db.AddInParameter(dbCommand, "StartDate", DbType.Datetime, .StartDate)
            db.AddInParameter(dbCommand, "EndingDate", DbType.Datetime, .EndingDate)
            db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, .StudyLevelId)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "CountryId", DbType.Guid, .CountryId)
            db.AddInParameter(dbCommand, "NbcId", DbType.Guid, .NbcId)
            db.AddInParameter(dbCommand, "DegreeFrom", DbType.String, .DegreeFrom)
            db.AddInParameter(dbCommand, "AnotherUniversity", DbType.String, .AnotherUniversity)
            db.AddInParameter(dbCommand, "FileSupport", DbType.Binary, .FileSupport)
            db.AddInParameter(dbCommand, "FileSize", DbType.Int32, .FileSize)
            db.AddInParameter(dbCommand, "FileType", DbType.String, .FileType)
            db.AddInParameter(dbCommand, "FileName", DbType.String, .FileName)
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

    Public Shared Function Update(ByVal objTrainingFormalByProfessor As TrainingFormalByProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingFormalByProfessor_Update")
        With objTrainingFormalByProfessor
            db.AddInParameter(dbCommand, "TrainingFormalByProfessorId", DbType.Guid, .TrainingFormalByProfessorId)
            db.AddInParameter(dbCommand, "IesId", DbType.Guid, .IesId)
            db.AddInParameter(dbCommand, "StartDate", DbType.Datetime, .StartDate)
            db.AddInParameter(dbCommand, "EndingDate", DbType.Datetime, .EndingDate)
            db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, .StudyLevelId)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "CountryId", DbType.Guid, .CountryId)
            db.AddInParameter(dbCommand, "NbcId", DbType.Guid, .NbcId)
            db.AddInParameter(dbCommand, "DegreeFrom", DbType.String, .DegreeFrom)
            db.AddInParameter(dbCommand, "AnotherUniversity", DbType.String, .AnotherUniversity)
            db.AddInParameter(dbCommand, "FileSupport", DbType.Binary, .FileSupport)
            db.AddInParameter(dbCommand, "FileSize", DbType.Int32, .FileSize)
            db.AddInParameter(dbCommand, "FileType", DbType.String, .FileType)
            db.AddInParameter(dbCommand, "FileName", DbType.String, .FileName)
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

    Public Shared Function Delete(ByVal trainingFormalByProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingFormalByProfessor_Delete")
        db.AddInParameter(dbCommand, "TrainingFormalByProfessorId", DbType.Guid, trainingFormalByProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal trainingFormalByProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingFormalByProfessor_MoveUp")
        db.AddInParameter(dbCommand, "TrainingFormalByProfessorId", DbType.Guid, trainingFormalByProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal trainingFormalByProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingFormalByProfessor_MoveDown")
        db.AddInParameter(dbCommand, "TrainingFormalByProfessorId", DbType.Guid, trainingFormalByProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class


