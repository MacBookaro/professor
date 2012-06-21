' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 15:47:38
' Notas:	Archivo de definición de manejador de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class ProgramHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal programId As Guid) As Program
        Dim objProgram As Program = New Program
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Program_Read")
        db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, programId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objProgram
                    If Not Convert.IsDBNull(dataReader("ProgramId")) Then .ProgramId = dataReader("ProgramId")
                    If Not Convert.IsDBNull(dataReader("Name")) Then .Name = dataReader("Name")
                    If Not Convert.IsDBNull(dataReader("ProConsecutive")) Then .ProConsecutive = dataReader("ProConsecutive")
                    If Not Convert.IsDBNull(dataReader("StateProgramId")) Then .StateProgramId = dataReader("StateProgramId")
                    If Not Convert.IsDBNull(dataReader("StateProgram")) Then .StateProgram = dataReader("StateProgram")
                    If Not Convert.IsDBNull(dataReader("ModalitiyId")) Then .ModalitiyId = dataReader("ModalitiyId")
                    If Not Convert.IsDBNull(dataReader("Modalitiy")) Then .Modalitiy = dataReader("Modalitiy")
                    If Not Convert.IsDBNull(dataReader("CityId")) Then .CityId = dataReader("CityId")
                    If Not Convert.IsDBNull(dataReader("City")) Then .City = dataReader("City")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                End With
            End If
        End Using
        Return objProgram
    End Function

    Public Shared Function Create(ByVal objProgram As Program) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Program_Create")
        With objProgram
            db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, .ProgramId)
            db.AddInParameter(dbCommand, "Name", DbType.String, .Name)
            db.AddInParameter(dbCommand, "ProConsecutive", DbType.String, .ProConsecutive)
            db.AddInParameter(dbCommand, "StateProgramId", DbType.String, .StateProgramId)
            db.AddInParameter(dbCommand, "ModalitiyId", DbType.Guid, .ModalitiyId)
            db.AddInParameter(dbCommand, "CityId", DbType.Guid, .CityId)
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

    Public Shared Function Update(ByVal objProgram As Program) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Program_Update")
        With objProgram
            db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, .ProgramId)
            db.AddInParameter(dbCommand, "Name", DbType.String, .Name)
            db.AddInParameter(dbCommand, "ProConsecutive", DbType.String, .ProConsecutive)
            db.AddInParameter(dbCommand, "StateProgramId", DbType.String, .StateProgramId)
            db.AddInParameter(dbCommand, "ModalitiyId", DbType.Guid, .ModalitiyId)
            db.AddInParameter(dbCommand, "CityId", DbType.Guid, .CityId)
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

    Public Shared Function Delete(ByVal programId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Program_Delete")
        db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, programId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal programId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Program_MoveUp")
        db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, programId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal programId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Program_MoveDown")
        db.AddInParameter(dbCommand, "ProgramId", DbType.Guid, programId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

