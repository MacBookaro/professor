' ==========================================================================================
' Autor:	Sergio Mejia Arenas
' Fecha:	05/06/2012 16:54:51
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class TrainingInformalByProfessorHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal trainingInformalByProfessorsId As Guid) As TrainingInformalByProfessor
        Dim objTrainingInformalByProfessor As TrainingInformalByProfessor = New TrainingInformalByProfessor
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingInformalByProfessor_Read")
        db.AddInParameter(dbCommand, "TrainingInformalByProfessorsId", DbType.Guid, trainingInformalByProfessorsId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objTrainingInformalByProfessor
                    If Not Convert.IsDBNull(dataReader("TrainingInformalByProfessorsId")) Then .TrainingInformalByProfessorsId = dataReader("TrainingInformalByProfessorsId")
                    If Not Convert.IsDBNull(dataReader("DegreeFrom")) Then .DegreeFrom = dataReader("DegreeFrom")
                    If Not Convert.IsDBNull(dataReader("TrainingTypeId")) Then .TrainingTypeId = dataReader("TrainingTypeId")
                    If Not Convert.IsDBNull(dataReader("TrainingType")) Then .TrainingType = dataReader("TrainingType")
                    If Not Convert.IsDBNull(dataReader("FundingIesTypeId")) Then .FundingIesTypeId = dataReader("FundingIesTypeId")
                    If Not Convert.IsDBNull(dataReader("FundingIesType")) Then .FundingIesType = dataReader("FundingIesType")
                    If Not Convert.IsDBNull(dataReader("CourseTopicId")) Then .CourseTopicId = dataReader("CourseTopicId")
                    If Not Convert.IsDBNull(dataReader("CourseTopic")) Then .CourseTopic = dataReader("CourseTopic")
                    If Not Convert.IsDBNull(dataReader("CountryId")) Then .CountryId = dataReader("CountryId")
                    If Not Convert.IsDBNull(dataReader("Country")) Then .Country = dataReader("Country")
                    If Not Convert.IsDBNull(dataReader("IesId")) Then .IesId = dataReader("IesId")
                    If Not Convert.IsDBNull(dataReader("Ies")) Then .Ies = dataReader("Ies")
                    If Not Convert.IsDBNull(dataReader("CourseNonformalTypeId")) Then .CourseNonformalTypeId = dataReader("CourseNonformalTypeId")
                    If Not Convert.IsDBNull(dataReader("CourseNonformalType")) Then .CourseNonformalType = dataReader("CourseNonformalType")
                    If Not Convert.IsDBNull(dataReader("DateTraining")) Then .DateTraining = dataReader("DateTraining")
                    If Not Convert.IsDBNull(dataReader("OtherIes")) Then .OtherIes = dataReader("OtherIes")
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("User")) Then .User = dataReader("User")
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
        Return objTrainingInformalByProfessor
    End Function

    Public Shared Function Create(ByVal objTrainingInformalByProfessor As TrainingInformalByProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingInformalByProfessor_Create")
        With objTrainingInformalByProfessor
            db.AddInParameter(dbCommand, "TrainingInformalByProfessorsId", DbType.Guid, .TrainingInformalByProfessorsId)
            db.AddInParameter(dbCommand, "DegreeFrom", DbType.String, .DegreeFrom)
            db.AddInParameter(dbCommand, "TrainingTypeId", DbType.Guid, .TrainingTypeId)
            db.AddInParameter(dbCommand, "FundingIesTypeId", DbType.Guid, .FundingIesTypeId)
            db.AddInParameter(dbCommand, "CourseTopicId", DbType.Guid, .CourseTopicId)
            db.AddInParameter(dbCommand, "CountryId", DbType.Guid, .CountryId)
            db.AddInParameter(dbCommand, "IesId", DbType.Guid, .IesId)
            db.AddInParameter(dbCommand, "CourseNonformalTypeId", DbType.Guid, .CourseNonformalTypeId)
            db.AddInParameter(dbCommand, "DateTraining", DbType.Datetime, .DateTraining)
            db.AddInParameter(dbCommand, "OtherIes", DbType.String, .OtherIes)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
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

    Public Shared Function Update(ByVal objTrainingInformalByProfessor As TrainingInformalByProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingInformalByProfessor_Update")
        With objTrainingInformalByProfessor
            db.AddInParameter(dbCommand, "TrainingInformalByProfessorsId", DbType.Guid, .TrainingInformalByProfessorsId)
            db.AddInParameter(dbCommand, "DegreeFrom", DbType.String, .DegreeFrom)
            db.AddInParameter(dbCommand, "TrainingTypeId", DbType.Guid, .TrainingTypeId)
            db.AddInParameter(dbCommand, "FundingIesTypeId", DbType.Guid, .FundingIesTypeId)
            db.AddInParameter(dbCommand, "CourseTopicId", DbType.Guid, .CourseTopicId)
            db.AddInParameter(dbCommand, "CountryId", DbType.Guid, .CountryId)
            db.AddInParameter(dbCommand, "IesId", DbType.Guid, .IesId)
            db.AddInParameter(dbCommand, "CourseNonformalTypeId", DbType.Guid, .CourseNonformalTypeId)
            db.AddInParameter(dbCommand, "DateTraining", DbType.Datetime, .DateTraining)
            db.AddInParameter(dbCommand, "OtherIes", DbType.String, .OtherIes)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
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

    Public Shared Function Delete(ByVal trainingInformalByProfessorsId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingInformalByProfessor_Delete")
        db.AddInParameter(dbCommand, "TrainingInformalByProfessorsId", DbType.Guid, trainingInformalByProfessorsId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal trainingInformalByProfessorsId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingInformalByProfessor_MoveUp")
        db.AddInParameter(dbCommand, "TrainingInformalByProfessorsId", DbType.Guid, trainingInformalByProfessorsId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal trainingInformalByProfessorsId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingInformalByProfessor_MoveDown")
        db.AddInParameter(dbCommand, "TrainingInformalByProfessorsId", DbType.Guid, trainingInformalByProfessorsId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

