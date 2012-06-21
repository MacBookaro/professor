' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:41:53
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class StudyLevelHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal studyLevelId As Guid) As StudyLevel
        Dim objStudyLevel As StudyLevel = New StudyLevel
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StudyLevel_Read")
        db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, studyLevelId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objStudyLevel
                    If Not Convert.IsDBNull(dataReader("StudyLevelId")) Then .StudyLevelId = dataReader("StudyLevelId")
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
        Return objStudyLevel
    End Function

    Public Shared Function Create(ByVal objStudyLevel As StudyLevel) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StudyLevel_Create")
        With objStudyLevel
            db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, .StudyLevelId)
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

    Public Shared Function Update(ByVal objStudyLevel As StudyLevel) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StudyLevel_Update")
        With objStudyLevel
            db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, .StudyLevelId)
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

    Public Shared Function Delete(ByVal studyLevelId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StudyLevel_Delete")
        db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, studyLevelId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal studyLevelId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StudyLevel_MoveUp")
        db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, studyLevelId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal studyLevelId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StudyLevel_MoveDown")
        db.AddInParameter(dbCommand, "StudyLevelId", DbType.Guid, studyLevelId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

