﻿' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 14:29:23
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class IdentificationDocumentTypeHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal identificationDoumenTypeId As Guid) As IdentificationDocumentType
        Dim objIdentificationDocumentType As IdentificationDocumentType = New IdentificationDocumentType
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_Read")
        db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, identificationDoumenTypeId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objIdentificationDocumentType
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenTypeId")) Then .IdentificationDoumenTypeId = dataReader("IdentificationDoumenTypeId")
                    If Not Convert.IsDBNull(dataReader("Description")) Then .Description = dataReader("Description")
                    If Not Convert.IsDBNull(dataReader("Code")) Then .Code = dataReader("Code")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objIdentificationDocumentType
    End Function

    Public Shared Function Create(ByVal objIdentificationDocumentType As IdentificationDocumentType) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_Create")
        With objIdentificationDocumentType
            db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, .IdentificationDoumenTypeId)
            db.AddInParameter(dbCommand, "Description", DbType.String, .Description)
            db.AddInParameter(dbCommand, "Code", DbType.String, .Code)
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

    Public Shared Function Update(ByVal objIdentificationDocumentType As IdentificationDocumentType) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_Update")
        With objIdentificationDocumentType
            db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, .IdentificationDoumenTypeId)
            db.AddInParameter(dbCommand, "Description", DbType.String, .Description)
            db.AddInParameter(dbCommand, "Code", DbType.String, .Code)
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

    Public Shared Function Delete(ByVal identificationDoumenTypeId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_Delete")
        db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, identificationDoumenTypeId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal identificationDoumenTypeId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_MoveUp")
        db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, identificationDoumenTypeId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal identificationDoumenTypeId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_MoveDown")
        db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, identificationDoumenTypeId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

