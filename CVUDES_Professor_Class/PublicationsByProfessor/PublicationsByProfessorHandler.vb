' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 16:12:44
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class PublicationsByProfessorHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal publicationsByProfessorId As Guid) As PublicationsByProfessor
        Dim objPublicationsByProfessor As PublicationsByProfessor = New PublicationsByProfessor
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationsByProfessor_Read")
        db.AddInParameter(dbCommand, "PublicationsByProfessorId", DbType.Guid, publicationsByProfessorId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objPublicationsByProfessor
                    If Not Convert.IsDBNull(dataReader("PublicationsByProfessorId")) Then .PublicationsByProfessorId = dataReader("PublicationsByProfessorId")
                    If Not Convert.IsDBNull(dataReader("DatePublication")) Then .DatePublication = dataReader("DatePublication")
                    If Not Convert.IsDBNull(dataReader("Description")) Then .Description = dataReader("Description")
                    If Not Convert.IsDBNull(dataReader("FileSupport")) Then .FileSupport = dataReader("FileSupport")
                    If Not Convert.IsDBNull(dataReader("FileSize")) Then .FileSize = dataReader("FileSize")
                    If Not Convert.IsDBNull(dataReader("FileType")) Then .FileType = dataReader("FileType")
                    If Not Convert.IsDBNull(dataReader("FileName")) Then .FileName = dataReader("FileName")
                    If Not Convert.IsDBNull(dataReader("PublicationTypeId")) Then .PublicationTypeId = dataReader("PublicationTypeId")
                    If Not Convert.IsDBNull(dataReader("PublicationType")) Then .PublicationType = dataReader("PublicationType")
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
        Return objPublicationsByProfessor
    End Function

    Public Shared Function Create(ByVal objPublicationsByProfessor As PublicationsByProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationsByProfessor_Create")
        With objPublicationsByProfessor
            db.AddInParameter(dbCommand, "PublicationsByProfessorId", DbType.Guid, .PublicationsByProfessorId)
            db.AddInParameter(dbCommand, "DatePublication", DbType.Datetime, .DatePublication)
            db.AddInParameter(dbCommand, "Description", DbType.String, .Description)
            db.AddInParameter(dbCommand, "FileSupport", DbType.Binary, .FileSupport)
            db.AddInParameter(dbCommand, "FileSize", DbType.Int32, .FileSize)
            db.AddInParameter(dbCommand, "FileType", DbType.String, .FileType)
            db.AddInParameter(dbCommand, "FileName", DbType.String, .FileName)
            db.AddInParameter(dbCommand, "PublicationTypeId", DbType.Guid, .PublicationTypeId)
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

    Public Shared Function Update(ByVal objPublicationsByProfessor As PublicationsByProfessor) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationsByProfessor_Update")
        With objPublicationsByProfessor
            db.AddInParameter(dbCommand, "PublicationsByProfessorId", DbType.Guid, .PublicationsByProfessorId)
            db.AddInParameter(dbCommand, "DatePublication", DbType.Datetime, .DatePublication)
            db.AddInParameter(dbCommand, "Description", DbType.String, .Description)
            db.AddInParameter(dbCommand, "FileSupport", DbType.Binary, .FileSupport)
            db.AddInParameter(dbCommand, "FileSize", DbType.Int32, .FileSize)
            db.AddInParameter(dbCommand, "FileType", DbType.String, .FileType)
            db.AddInParameter(dbCommand, "FileName", DbType.String, .FileName)
            db.AddInParameter(dbCommand, "PublicationTypeId", DbType.Guid, .PublicationTypeId)
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

    Public Shared Function Delete(ByVal publicationsByProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationsByProfessor_Delete")
        db.AddInParameter(dbCommand, "PublicationsByProfessorId", DbType.Guid, publicationsByProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal publicationsByProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationsByProfessor_MoveUp")
        db.AddInParameter(dbCommand, "PublicationsByProfessorId", DbType.Guid, publicationsByProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal publicationsByProfessorId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationsByProfessor_MoveDown")
        db.AddInParameter(dbCommand, "PublicationsByProfessorId", DbType.Guid, publicationsByProfessorId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

