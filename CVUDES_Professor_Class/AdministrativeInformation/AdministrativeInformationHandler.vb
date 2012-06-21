' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:10:33
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class AdministrativeInformationHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal administrativeInformationId As Guid) As AdministrativeInformation
        Dim objAdministrativeInformation As AdministrativeInformation = New AdministrativeInformation
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformation_Read")
        db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, administrativeInformationId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objAdministrativeInformation
                    If Not Convert.IsDBNull(dataReader("AdministrativeInformationId")) Then .AdministrativeInformationId = dataReader("AdministrativeInformationId")
                    If Not Convert.IsDBNull(dataReader("ContractDuration")) Then .ContractDuration = dataReader("ContractDuration")
                    If Not Convert.IsDBNull(dataReader("ProfessorCeres")) Then .ProfessorCeres = dataReader("ProfessorCeres")
                    If Not Convert.IsDBNull(dataReader("AdmissionDate")) Then .AdmissionDate = dataReader("AdmissionDate")
                    If Not Convert.IsDBNull(dataReader("PercentageAdministrative")) Then .PercentageAdministrative = dataReader("PercentageAdministrative")
                    If Not Convert.IsDBNull(dataReader("PercentageTeaching")) Then .PercentageTeaching = dataReader("PercentageTeaching")
                    If Not Convert.IsDBNull(dataReader("PercentageResearch")) Then .PercentageResearch = dataReader("PercentageResearch")
                    If Not Convert.IsDBNull(dataReader("PercentageWelfare")) Then .PercentageWelfare = dataReader("PercentageWelfare")
                    If Not Convert.IsDBNull(dataReader("PercentegeEducation")) Then .PercentegeEducation = dataReader("PercentegeEducation")
                    If Not Convert.IsDBNull(dataReader("PercentegePaidProyect")) Then .PercentegePaidProyect = dataReader("PercentegePaidProyect")
                    If Not Convert.IsDBNull(dataReader("PercentegeUnpaidProyect")) Then .PercentegeUnpaidProyect = dataReader("PercentegeUnpaidProyect")
                    If Not Convert.IsDBNull(dataReader("PercentageOtherActivities")) Then .PercentageOtherActivities = dataReader("PercentageOtherActivities")
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("User")) Then .User = dataReader("User")
                    If Not Convert.IsDBNull(dataReader("ProgramId")) Then .ProgramId = dataReader("ProgramId")
                    If Not Convert.IsDBNull(dataReader("Program")) Then .Program = dataReader("Program")
                    If Not Convert.IsDBNull(dataReader("ContractTypeId")) Then .ContractTypeId = dataReader("ContractTypeId")
                    If Not Convert.IsDBNull(dataReader("ContractType")) Then .ContractType = dataReader("ContractType")
                    If Not Convert.IsDBNull(dataReader("OrganizationalUnitTypeId")) Then .OrganizationalUnitTypeId = dataReader("OrganizationalUnitTypeId")
                    If Not Convert.IsDBNull(dataReader("OrganizationalUnitType")) Then .OrganizationalUnitType = dataReader("OrganizationalUnitType")
                    If Not Convert.IsDBNull(dataReader("DedicationProfessorTypeId")) Then .DedicationProfessorTypeId = dataReader("DedicationProfessorTypeId")
                    If Not Convert.IsDBNull(dataReader("DedicationProfessorType")) Then .DedicationProfessorType = dataReader("DedicationProfessorType")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objAdministrativeInformation
    End Function

    Public Shared Function Create(ByVal objAdministrativeInformation As AdministrativeInformation) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformation_Create")
        With objAdministrativeInformation
            db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, .AdministrativeInformationId)
            db.AddInParameter(dbCommand, "ContractDuration", DbType.Int32, .ContractDuration)
            db.AddInParameter(dbCommand, "ProfessorCeres", DbType.String, .ProfessorCeres)
            db.AddInParameter(dbCommand, "AdmissionDate", DbType.Datetime, .AdmissionDate)
            db.AddInParameter(dbCommand, "PercentageAdministrative", DbType.Int32, .PercentageAdministrative)
            db.AddInParameter(dbCommand, "PercentageTeaching", DbType.Int32, .PercentageTeaching)
            db.AddInParameter(dbCommand, "PercentageResearch", DbType.Int32, .PercentageResearch)
            db.AddInParameter(dbCommand, "PercentageWelfare", DbType.Int32, .PercentageWelfare)
            db.AddInParameter(dbCommand, "PercentegeEducation", DbType.Int32, .PercentegeEducation)
            db.AddInParameter(dbCommand, "PercentegePaidProyect", DbType.Int32, .PercentegePaidProyect)
            db.AddInParameter(dbCommand, "PercentegeUnpaidProyect", DbType.Int32, .PercentegeUnpaidProyect)
            db.AddInParameter(dbCommand, "PercentageOtherActivities", DbType.Int32, .PercentageOtherActivities)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, .ProgramId)
            db.AddInParameter(dbCommand, "ContractTypeId", DbType.Guid, .ContractTypeId)
            db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, .OrganizationalUnitTypeId)
            db.AddInParameter(dbCommand, "DedicationProfessorTypeId", DbType.Guid, .DedicationProfessorTypeId)
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

    Public Shared Function Update(ByVal objAdministrativeInformation As AdministrativeInformation) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformation_Update")
        With objAdministrativeInformation
            db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, .AdministrativeInformationId)
            db.AddInParameter(dbCommand, "ContractDuration", DbType.Int32, .ContractDuration)
            db.AddInParameter(dbCommand, "ProfessorCeres", DbType.String, .ProfessorCeres)
            db.AddInParameter(dbCommand, "AdmissionDate", DbType.Datetime, .AdmissionDate)
            db.AddInParameter(dbCommand, "PercentageAdministrative", DbType.Int32, .PercentageAdministrative)
            db.AddInParameter(dbCommand, "PercentageTeaching", DbType.Int32, .PercentageTeaching)
            db.AddInParameter(dbCommand, "PercentageResearch", DbType.Int32, .PercentageResearch)
            db.AddInParameter(dbCommand, "PercentageWelfare", DbType.Int32, .PercentageWelfare)
            db.AddInParameter(dbCommand, "PercentegeEducation", DbType.Int32, .PercentegeEducation)
            db.AddInParameter(dbCommand, "PercentegePaidProyect", DbType.Int32, .PercentegePaidProyect)
            db.AddInParameter(dbCommand, "PercentegeUnpaidProyect", DbType.Int32, .PercentegeUnpaidProyect)
            db.AddInParameter(dbCommand, "PercentageOtherActivities", DbType.Int32, .PercentageOtherActivities)
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, .ProgramId)
            db.AddInParameter(dbCommand, "ContractTypeId", DbType.Guid, .ContractTypeId)
            db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Guid, .OrganizationalUnitTypeId)
            db.AddInParameter(dbCommand, "DedicationProfessorTypeId", DbType.Guid, .DedicationProfessorTypeId)
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

    Public Shared Function Delete(ByVal administrativeInformationId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformation_Delete")
        db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, administrativeInformationId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal administrativeInformationId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformation_MoveUp")
        db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, administrativeInformationId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal administrativeInformationId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformation_MoveDown")
        db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, administrativeInformationId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class


