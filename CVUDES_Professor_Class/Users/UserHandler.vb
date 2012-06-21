' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 10:05:51
' Notas:	Archivo de definición de manejador de clase
' Modifico: Francisco J. Naranjo | MacBookaro
' Fecha:	15/06/2012 09:04:51
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class UserHandler

    Private Sub New()
    End Sub

    Public Shared Function Read(ByVal userId As Guid) As User
        Dim objUser As User = New User
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_Read")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, userId)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objUser
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("UserName")) Then .UserName = dataReader("UserName")
                    If Not Convert.IsDBNull(dataReader("FirtsName")) Then .FirtsName = dataReader("FirtsName")
                    If Not Convert.IsDBNull(dataReader("MiddleName")) Then .MiddleName = dataReader("MiddleName")
                    If Not Convert.IsDBNull(dataReader("FirtsSurname")) Then .FirtsSurname = dataReader("FirtsSurname")
                    If Not Convert.IsDBNull(dataReader("MiddleSurname")) Then .MiddleSurname = dataReader("MiddleSurname")
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenTypeId")) Then .IdentificationDoumenTypeId = dataReader("IdentificationDoumenTypeId")
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenType")) Then .IdentificationDoumenType = dataReader("IdentificationDoumenType")
                    If Not Convert.IsDBNull(dataReader("IdentificationNumber")) Then .IdentificationNumber = dataReader("IdentificationNumber")
                    If Not Convert.IsDBNull(dataReader("IdentificationIssuedLocationId")) Then .IdentificationIssuedLocationId = dataReader("IdentificationIssuedLocationId")
                    If Not Convert.IsDBNull(dataReader("IdentificationIssuedLocation")) Then .IdentificationIssuedLocation = dataReader("IdentificationIssuedLocation")
                    If Not Convert.IsDBNull(dataReader("CellPhoneNumber")) Then .CellPhoneNumber = dataReader("CellPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("CellPhoneNumberAlternative")) Then .CellPhoneNumberAlternative = dataReader("CellPhoneNumberAlternative")
                    If Not Convert.IsDBNull(dataReader("PhoneNumber")) Then .PhoneNumber = dataReader("PhoneNumber")
                    If Not Convert.IsDBNull(dataReader("AreaPhoneNumber")) Then .AreaPhoneNumber = dataReader("AreaPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("FaxPhoneNumber")) Then .FaxPhoneNumber = dataReader("FaxPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("BirthDate")) Then .BirthDate = dataReader("BirthDate")
                    If Not Convert.IsDBNull(dataReader("PlaceBirthId")) Then .PlaceBirthId = dataReader("PlaceBirthId")
                    If Not Convert.IsDBNull(dataReader("PlaceBirth")) Then .PlaceBirth = dataReader("PlaceBirth")
                    If Not Convert.IsDBNull(dataReader("ResidenceAddress")) Then .ResidenceAddress = dataReader("ResidenceAddress")
                    If Not Convert.IsDBNull(dataReader("ResidenceNeighborhood")) Then .ResidenceNeighborhood = dataReader("ResidenceNeighborhood")
                    If Not Convert.IsDBNull(dataReader("PlaceResidenceId")) Then .PlaceResidenceId = dataReader("PlaceResidenceId")
                    If Not Convert.IsDBNull(dataReader("PlaceResidence")) Then .PlaceResidence = dataReader("PlaceResidence")
                    If Not Convert.IsDBNull(dataReader("Email")) Then .Email = dataReader("Email")
                    If Not Convert.IsDBNull(dataReader("EmailAlternative")) Then .EmailAlternative = dataReader("EmailAlternative")
                    If Not Convert.IsDBNull(dataReader("EmailVerified")) Then .EmailVerified = dataReader("EmailVerified")
                    If Not Convert.IsDBNull(dataReader("WebSite")) Then .WebSite = dataReader("WebSite")
                    If Not Convert.IsDBNull(dataReader("Password")) Then .Password = dataReader("Password")
                    If Not Convert.IsDBNull(dataReader("WasVerified")) Then .WasVerified = dataReader("WasVerified")
                    If Not Convert.IsDBNull(dataReader("GenderId")) Then .GenderId = dataReader("GenderId")
                    If Not Convert.IsDBNull(dataReader("Gender")) Then .Gender = dataReader("Gender")
                    If Not Convert.IsDBNull(dataReader("MaritalStatusTypeId")) Then .MaritalStatusTypeId = dataReader("MaritalStatusTypeId")
                    If Not Convert.IsDBNull(dataReader("MaritalStatusType")) Then .MaritalStatusType = dataReader("MaritalStatusType")
                    If Not Convert.IsDBNull(dataReader("StateUserTypeId")) Then .StateUserTypeId = dataReader("StateUserTypeId")
                    If Not Convert.IsDBNull(dataReader("StateUserType")) Then .StateUserType = dataReader("StateUserType")
                    If Not Convert.IsDBNull(dataReader("SectionalId")) Then .SectionalId = dataReader("SectionalId")
                    If Not Convert.IsDBNull(dataReader("Sectional")) Then .Sectional = dataReader("Sectional")
                    If Not Convert.IsDBNull(dataReader("IsForeign")) Then .IsForeign = dataReader("IsForeign")
                    If Not Convert.IsDBNull(dataReader("ForeingCity")) Then .ForeingCity = dataReader("ForeingCity")
                    If Not Convert.IsDBNull(dataReader("ForeingRegion")) Then .ForeingRegion = dataReader("ForeingRegion")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                    'Para recuperar el Soporte
                    If Not Convert.IsDBNull(dataReader("FilePhoto")) Then .FilePhoto = dataReader("FilePhoto")
                    If Not Convert.IsDBNull(dataReader("FileSize")) Then .FileSize = dataReader("FileSize")
                    If Not Convert.IsDBNull(dataReader("FileType")) Then .FileType = dataReader("FileType")
                    If Not Convert.IsDBNull(dataReader("FileName")) Then .FileName = dataReader("FileName")
                    'Roles Por Usuario
                    If Not Convert.IsDBNull(dataReader("RolesList")) Then .RolesList = dataReader("RolesList")
                End With
            End If
        End Using
        Return objUser
    End Function

    Public Shared Function Read(ByVal userName As String) As User
        Dim objUser As User = New User
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("UserByUserName_Read")
        db.AddInParameter(dbCommand, "userName", DbType.String, userName)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objUser
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("UserName")) Then .UserName = dataReader("UserName")
                    If Not Convert.IsDBNull(dataReader("FirtsName")) Then .FirtsName = dataReader("FirtsName")
                    If Not Convert.IsDBNull(dataReader("MiddleName")) Then .MiddleName = dataReader("MiddleName")
                    If Not Convert.IsDBNull(dataReader("FirtsSurname")) Then .FirtsSurname = dataReader("FirtsSurname")
                    If Not Convert.IsDBNull(dataReader("MiddleSurname")) Then .MiddleSurname = dataReader("MiddleSurname")
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenTypeId")) Then .IdentificationDoumenTypeId = dataReader("IdentificationDoumenTypeId")
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenType")) Then .IdentificationDoumenType = dataReader("IdentificationDoumenType")
                    If Not Convert.IsDBNull(dataReader("IdentificationNumber")) Then .IdentificationNumber = dataReader("IdentificationNumber")
                    If Not Convert.IsDBNull(dataReader("IdentificationIssuedLocationId")) Then .IdentificationIssuedLocationId = dataReader("IdentificationIssuedLocationId")
                    If Not Convert.IsDBNull(dataReader("IdentificationIssuedLocation")) Then .IdentificationIssuedLocation = dataReader("IdentificationIssuedLocation")
                    If Not Convert.IsDBNull(dataReader("CellPhoneNumber")) Then .CellPhoneNumber = dataReader("CellPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("CellPhoneNumberAlternative")) Then .CellPhoneNumberAlternative = dataReader("CellPhoneNumberAlternative")
                    If Not Convert.IsDBNull(dataReader("PhoneNumber")) Then .PhoneNumber = dataReader("PhoneNumber")
                    If Not Convert.IsDBNull(dataReader("AreaPhoneNumber")) Then .AreaPhoneNumber = dataReader("AreaPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("FaxPhoneNumber")) Then .FaxPhoneNumber = dataReader("FaxPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("BirthDate")) Then .BirthDate = dataReader("BirthDate")
                    If Not Convert.IsDBNull(dataReader("PlaceBirthId")) Then .PlaceBirthId = dataReader("PlaceBirthId")
                    If Not Convert.IsDBNull(dataReader("PlaceBirth")) Then .PlaceBirth = dataReader("PlaceBirth")
                    If Not Convert.IsDBNull(dataReader("ResidenceAddress")) Then .ResidenceAddress = dataReader("ResidenceAddress")
                    If Not Convert.IsDBNull(dataReader("ResidenceNeighborhood")) Then .ResidenceNeighborhood = dataReader("ResidenceNeighborhood")
                    If Not Convert.IsDBNull(dataReader("PlaceResidenceId")) Then .PlaceResidenceId = dataReader("PlaceResidenceId")
                    If Not Convert.IsDBNull(dataReader("PlaceResidence")) Then .PlaceResidence = dataReader("PlaceResidence")
                    If Not Convert.IsDBNull(dataReader("Email")) Then .Email = dataReader("Email")
                    If Not Convert.IsDBNull(dataReader("EmailAlternative")) Then .EmailAlternative = dataReader("EmailAlternative")
                    If Not Convert.IsDBNull(dataReader("EmailVerified")) Then .EmailVerified = dataReader("EmailVerified")
                    If Not Convert.IsDBNull(dataReader("WebSite")) Then .WebSite = dataReader("WebSite")
                    If Not Convert.IsDBNull(dataReader("Password")) Then .Password = dataReader("Password")
                    If Not Convert.IsDBNull(dataReader("WasVerified")) Then .WasVerified = dataReader("WasVerified")
                    If Not Convert.IsDBNull(dataReader("GenderId")) Then .GenderId = dataReader("GenderId")
                    If Not Convert.IsDBNull(dataReader("Gender")) Then .Gender = dataReader("Gender")
                    If Not Convert.IsDBNull(dataReader("MaritalStatusTypeId")) Then .MaritalStatusTypeId = dataReader("MaritalStatusTypeId")
                    If Not Convert.IsDBNull(dataReader("MaritalStatusType")) Then .MaritalStatusType = dataReader("MaritalStatusType")
                    If Not Convert.IsDBNull(dataReader("StateUserTypeId")) Then .StateUserTypeId = dataReader("StateUserTypeId")
                    If Not Convert.IsDBNull(dataReader("StateUserType")) Then .StateUserType = dataReader("StateUserType")
                    If Not Convert.IsDBNull(dataReader("SectionalId")) Then .SectionalId = dataReader("SectionalId")
                    If Not Convert.IsDBNull(dataReader("Sectional")) Then .Sectional = dataReader("Sectional")
                    If Not Convert.IsDBNull(dataReader("IsForeign")) Then .IsForeign = dataReader("IsForeign")
                    If Not Convert.IsDBNull(dataReader("ForeingCity")) Then .ForeingCity = dataReader("ForeingCity")
                    If Not Convert.IsDBNull(dataReader("ForeingRegion")) Then .ForeingRegion = dataReader("ForeingRegion")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                    'Para recuperar el Soporte
                    If Not Convert.IsDBNull(dataReader("FilePhoto")) Then .FilePhoto = dataReader("FilePhoto")
                    If Not Convert.IsDBNull(dataReader("FileSize")) Then .FileSize = dataReader("FileSize")
                    If Not Convert.IsDBNull(dataReader("FileType")) Then .FileType = dataReader("FileType")
                    If Not Convert.IsDBNull(dataReader("FileName")) Then .FileName = dataReader("FileName")
                    'Roles Por Usuario
                    If Not Convert.IsDBNull(dataReader("RolesList")) Then .RolesList = dataReader("RolesList")
                End With
            End If
        End Using
        Return objUser
    End Function

    Public Shared Function ReadUserByEmail(ByVal Email As String) As User
        Dim objUser As User = New User
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("UserByEmail_Read")
        db.AddInParameter(dbCommand, "Email", DbType.String, Email)
        Using dataReader As IDataReader = db.ExecuteReader(dbCommand)
            If (dataReader.Read()) Then
                With objUser
                    If Not Convert.IsDBNull(dataReader("UserId")) Then .UserId = dataReader("UserId")
                    If Not Convert.IsDBNull(dataReader("UserName")) Then .UserName = dataReader("UserName")
                    If Not Convert.IsDBNull(dataReader("FirtsName")) Then .FirtsName = dataReader("FirtsName")
                    If Not Convert.IsDBNull(dataReader("MiddleName")) Then .MiddleName = dataReader("MiddleName")
                    If Not Convert.IsDBNull(dataReader("FirtsSurname")) Then .FirtsSurname = dataReader("FirtsSurname")
                    If Not Convert.IsDBNull(dataReader("MiddleSurname")) Then .MiddleSurname = dataReader("MiddleSurname")
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenTypeId")) Then .IdentificationDoumenTypeId = dataReader("IdentificationDoumenTypeId")
                    If Not Convert.IsDBNull(dataReader("IdentificationDoumenType")) Then .IdentificationDoumenType = dataReader("IdentificationDoumenType")
                    If Not Convert.IsDBNull(dataReader("IdentificationNumber")) Then .IdentificationNumber = dataReader("IdentificationNumber")
                    If Not Convert.IsDBNull(dataReader("IdentificationIssuedLocationId")) Then .IdentificationIssuedLocationId = dataReader("IdentificationIssuedLocationId")
                    If Not Convert.IsDBNull(dataReader("IdentificationIssuedLocation")) Then .IdentificationIssuedLocation = dataReader("IdentificationIssuedLocation")
                    If Not Convert.IsDBNull(dataReader("CellPhoneNumber")) Then .CellPhoneNumber = dataReader("CellPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("CellPhoneNumberAlternative")) Then .CellPhoneNumberAlternative = dataReader("CellPhoneNumberAlternative")
                    If Not Convert.IsDBNull(dataReader("PhoneNumber")) Then .PhoneNumber = dataReader("PhoneNumber")
                    If Not Convert.IsDBNull(dataReader("AreaPhoneNumber")) Then .AreaPhoneNumber = dataReader("AreaPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("FaxPhoneNumber")) Then .FaxPhoneNumber = dataReader("FaxPhoneNumber")
                    If Not Convert.IsDBNull(dataReader("BirthDate")) Then .BirthDate = dataReader("BirthDate")
                    If Not Convert.IsDBNull(dataReader("PlaceBirthId")) Then .PlaceBirthId = dataReader("PlaceBirthId")
                    If Not Convert.IsDBNull(dataReader("PlaceBirth")) Then .PlaceBirth = dataReader("PlaceBirth")
                    If Not Convert.IsDBNull(dataReader("ResidenceAddress")) Then .ResidenceAddress = dataReader("ResidenceAddress")
                    If Not Convert.IsDBNull(dataReader("ResidenceNeighborhood")) Then .ResidenceNeighborhood = dataReader("ResidenceNeighborhood")
                    If Not Convert.IsDBNull(dataReader("PlaceResidenceId")) Then .PlaceResidenceId = dataReader("PlaceResidenceId")
                    If Not Convert.IsDBNull(dataReader("PlaceResidence")) Then .PlaceResidence = dataReader("PlaceResidence")
                    If Not Convert.IsDBNull(dataReader("Email")) Then .Email = dataReader("Email")
                    If Not Convert.IsDBNull(dataReader("EmailAlternative")) Then .EmailAlternative = dataReader("EmailAlternative")
                    If Not Convert.IsDBNull(dataReader("EmailVerified")) Then .EmailVerified = dataReader("EmailVerified")
                    If Not Convert.IsDBNull(dataReader("WebSite")) Then .WebSite = dataReader("WebSite")
                    If Not Convert.IsDBNull(dataReader("Password")) Then .Password = dataReader("Password")
                    If Not Convert.IsDBNull(dataReader("WasVerified")) Then .WasVerified = dataReader("WasVerified")
                    If Not Convert.IsDBNull(dataReader("GenderId")) Then .GenderId = dataReader("GenderId")
                    If Not Convert.IsDBNull(dataReader("Gender")) Then .Gender = dataReader("Gender")
                    If Not Convert.IsDBNull(dataReader("MaritalStatusTypeId")) Then .MaritalStatusTypeId = dataReader("MaritalStatusTypeId")
                    If Not Convert.IsDBNull(dataReader("MaritalStatusType")) Then .MaritalStatusType = dataReader("MaritalStatusType")
                    If Not Convert.IsDBNull(dataReader("StateUserTypeId")) Then .StateUserTypeId = dataReader("StateUserTypeId")
                    If Not Convert.IsDBNull(dataReader("StateUserType")) Then .StateUserType = dataReader("StateUserType")
                    If Not Convert.IsDBNull(dataReader("SectionalId")) Then .SectionalId = dataReader("SectionalId")
                    If Not Convert.IsDBNull(dataReader("Sectional")) Then .Sectional = dataReader("Sectional")
                    If Not Convert.IsDBNull(dataReader("IsForeign")) Then .IsForeign = dataReader("IsForeign")
                    If Not Convert.IsDBNull(dataReader("ForeingCity")) Then .ForeingCity = dataReader("ForeingCity")
                    If Not Convert.IsDBNull(dataReader("ForeingRegion")) Then .ForeingRegion = dataReader("ForeingRegion")
                    If Not Convert.IsDBNull(dataReader("CreationUserName")) Then .CreationUserName = dataReader("CreationUserName")
                    If Not Convert.IsDBNull(dataReader("CreationDate")) Then .CreationDate = dataReader("CreationDate")
                    If Not Convert.IsDBNull(dataReader("LastChangeUser")) Then .LastChangeUser = dataReader("LastChangeUser")
                    If Not Convert.IsDBNull(dataReader("LastChangeDate")) Then .LastChangeDate = dataReader("LastChangeDate")
                    If Not Convert.IsDBNull(dataReader("IsActive")) Then .IsActive = dataReader("IsActive")
                    'Para recuperar el Soporte
                    If Not Convert.IsDBNull(dataReader("FilePhoto")) Then .FilePhoto = dataReader("FilePhoto")
                    If Not Convert.IsDBNull(dataReader("FileSize")) Then .FileSize = dataReader("FileSize")
                    If Not Convert.IsDBNull(dataReader("FileType")) Then .FileType = dataReader("FileType")
                    If Not Convert.IsDBNull(dataReader("FileName")) Then .FileName = dataReader("FileName")
                    'Roles Por Usuario
                    If Not Convert.IsDBNull(dataReader("RolesList")) Then .RolesList = dataReader("RolesList")
                End With
            End If
        End Using
        Return objUser
    End Function

    Public Shared Function PreRegister(ByVal objUser As User) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_PreRegister")
        With objUser
            db.AddInParameter(dbCommand, "UserName", DbType.String, .UserName)
            db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, .IdentificationDoumenTypeId)
            db.AddInParameter(dbCommand, "IdentificationNumber", DbType.String, .IdentificationNumber)
            db.AddInParameter(dbCommand, "Email", DbType.String, .Email)
            db.AddInParameter(dbCommand, "Password", DbType.String, .Password)
            db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        End With
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function Create(ByVal objUser As User) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_Create")
        With objUser
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "UserName", DbType.String, .UserName)
            db.AddInParameter(dbCommand, "FirtsName", DbType.String, .FirtsName)
            db.AddInParameter(dbCommand, "MiddleName", DbType.String, .MiddleName)
            db.AddInParameter(dbCommand, "FirtsSurname", DbType.String, .FirtsSurname)
            db.AddInParameter(dbCommand, "MiddleSurname", DbType.String, .MiddleSurname)
            db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, .IdentificationDoumenTypeId)
            db.AddInParameter(dbCommand, "IdentificationNumber", DbType.String, .IdentificationNumber)
            db.AddInParameter(dbCommand, "IdentificationIssuedLocationId", DbType.Guid, .IdentificationIssuedLocationId)
            db.AddInParameter(dbCommand, "CellPhoneNumber", DbType.String, .CellPhoneNumber)
            db.AddInParameter(dbCommand, "CellPhoneNumberAlternative", DbType.String, .CellPhoneNumberAlternative)
            db.AddInParameter(dbCommand, "PhoneNumber", DbType.String, .PhoneNumber)
            db.AddInParameter(dbCommand, "AreaPhoneNumber", DbType.String, .AreaPhoneNumber)
            db.AddInParameter(dbCommand, "FaxPhoneNumber", DbType.String, .FaxPhoneNumber)
            db.AddInParameter(dbCommand, "BirthDate", DbType.Datetime, .BirthDate)
            db.AddInParameter(dbCommand, "PlaceBirthId", DbType.Guid, .PlaceBirthId)
            db.AddInParameter(dbCommand, "ResidenceAddress", DbType.String, .ResidenceAddress)
            db.AddInParameter(dbCommand, "ResidenceNeighborhood", DbType.String, .ResidenceNeighborhood)
            db.AddInParameter(dbCommand, "PlaceResidenceId", DbType.Guid, .PlaceResidenceId)
            db.AddInParameter(dbCommand, "Email", DbType.String, .Email)
            db.AddInParameter(dbCommand, "EmailAlternative", DbType.String, .EmailAlternative)
            db.AddInParameter(dbCommand, "EmailVerified", DbType.Boolean, .EmailVerified)
            db.AddInParameter(dbCommand, "WebSite", DbType.String, .WebSite)

            db.AddInParameter(dbCommand, "FilePhoto", DbType.Binary, .FilePhoto)
            db.AddInParameter(dbCommand, "SizePhoto", DbType.Int16, .FileSize)
            db.AddInParameter(dbCommand, "TypePhoto", DbType.String, .FileType)
            db.AddInParameter(dbCommand, "NamePhoto", DbType.String, .FileName)

            db.AddInParameter(dbCommand, "Password", DbType.String, .Password)
            db.AddInParameter(dbCommand, "WasVerified", DbType.Boolean, .WasVerified)
            db.AddInParameter(dbCommand, "GenderId", DbType.Guid, .GenderId)
            db.AddInParameter(dbCommand, "MaritalStatusTypeId", DbType.Guid, .MaritalStatusTypeId)
            db.AddInParameter(dbCommand, "StateUserTypeId", DbType.Guid, .StateUserTypeId)
            db.AddInParameter(dbCommand, "SectionalId", DbType.Guid, .SectionalId)
            db.AddInParameter(dbCommand, "IsForeign", DbType.Boolean, .IsForeign)
            db.AddInParameter(dbCommand, "ForeingCity", DbType.String, .ForeingCity)
            db.AddInParameter(dbCommand, "ForeingRegion", DbType.String, .ForeingRegion)
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

    Public Shared Function Update(ByVal objUser As User) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_Update")
        With objUser
            db.AddInParameter(dbCommand, "UserId", DbType.Guid, .UserId)
            db.AddInParameter(dbCommand, "UserName", DbType.String, .UserName)
            db.AddInParameter(dbCommand, "FirtsName", DbType.String, .FirtsName)
            db.AddInParameter(dbCommand, "MiddleName", DbType.String, .MiddleName)
            db.AddInParameter(dbCommand, "FirtsSurname", DbType.String, .FirtsSurname)
            db.AddInParameter(dbCommand, "MiddleSurname", DbType.String, .MiddleSurname)
            db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Guid, .IdentificationDoumenTypeId)
            db.AddInParameter(dbCommand, "IdentificationNumber", DbType.String, .IdentificationNumber)
            db.AddInParameter(dbCommand, "IdentificationIssuedLocationId", DbType.Guid, .IdentificationIssuedLocationId)
            db.AddInParameter(dbCommand, "CellPhoneNumber", DbType.String, .CellPhoneNumber)
            db.AddInParameter(dbCommand, "CellPhoneNumberAlternative", DbType.String, .CellPhoneNumberAlternative)
            db.AddInParameter(dbCommand, "PhoneNumber", DbType.String, .PhoneNumber)
            db.AddInParameter(dbCommand, "AreaPhoneNumber", DbType.String, .AreaPhoneNumber)
            db.AddInParameter(dbCommand, "FaxPhoneNumber", DbType.String, .FaxPhoneNumber)
            db.AddInParameter(dbCommand, "BirthDate", DbType.Datetime, .BirthDate)
            db.AddInParameter(dbCommand, "PlaceBirthId", DbType.Guid, .PlaceBirthId)
            db.AddInParameter(dbCommand, "ResidenceAddress", DbType.String, .ResidenceAddress)
            db.AddInParameter(dbCommand, "ResidenceNeighborhood", DbType.String, .ResidenceNeighborhood)
            db.AddInParameter(dbCommand, "PlaceResidenceId", DbType.Guid, .PlaceResidenceId)
            db.AddInParameter(dbCommand, "Email", DbType.String, .Email)
            db.AddInParameter(dbCommand, "EmailAlternative", DbType.String, .EmailAlternative)
            db.AddInParameter(dbCommand, "EmailVerified", DbType.Boolean, .EmailVerified)
            db.AddInParameter(dbCommand, "WebSite", DbType.String, .WebSite)
            db.AddInParameter(dbCommand, "FilePhoto", DbType.Binary, .FilePhoto)
            db.AddInParameter(dbCommand, "SizePhoto", DbType.Int16, .FileSize)
            db.AddInParameter(dbCommand, "TypePhoto", DbType.String, .FileType)
            db.AddInParameter(dbCommand, "NamePhoto", DbType.String, .FileName)
            db.AddInParameter(dbCommand, "Password", DbType.String, .Password)
            db.AddInParameter(dbCommand, "WasVerified", DbType.Boolean, .WasVerified)
            db.AddInParameter(dbCommand, "GenderId", DbType.Guid, .GenderId)
            db.AddInParameter(dbCommand, "MaritalStatusTypeId", DbType.Guid, .MaritalStatusTypeId)
            db.AddInParameter(dbCommand, "StateUserTypeId", DbType.Guid, .StateUserTypeId)
            db.AddInParameter(dbCommand, "SectionalId", DbType.Guid, .SectionalId)
            db.AddInParameter(dbCommand, "IsForeign", DbType.Boolean, .IsForeign)
            db.AddInParameter(dbCommand, "ForeingCity", DbType.String, .ForeingCity)
            db.AddInParameter(dbCommand, "ForeingRegion", DbType.String, .ForeingRegion)
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

    Public Shared Function Update(ByVal Email As String) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("UserActivation_Update")
        db.AddInParameter(dbCommand, "Email", DbType.String, Email)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function Delete(ByVal userId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_Delete")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, userId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveUp(ByVal userId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_MoveUp")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, userId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function MoveDown(ByVal userId As Guid) As Boolean
        Dim returnValue As Boolean = False
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("User_MoveDown")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, userId)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Boolean, 0)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function ValidateSession(ByVal UserName As String, ByVal Password As String) As String
        Dim returnValue As String = String.Empty
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Users_ValidateSession")
        db.AddInParameter(dbCommand, "UserName", DbType.String, UserName)
        db.AddInParameter(dbCommand, "Password", DbType.String, Password)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.String, 100)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

    Public Shared Function CheckUserName(ByVal UserName As String) As Integer
        Dim returnValue As Integer = 1
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Users_CheckUserName")
        db.AddInParameter(dbCommand, "UserName", DbType.String, UserName)
        db.AddOutParameter(dbCommand, "ReturnValue", DbType.Int32, 10)
        db.ExecuteNonQuery(dbCommand)
        returnValue = db.GetParameterValue(dbCommand, "ReturnValue")
        Return returnValue
    End Function

End Class

