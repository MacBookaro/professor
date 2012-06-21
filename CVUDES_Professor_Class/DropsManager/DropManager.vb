' ==========================================================================================
' Autor:	Francisco J. Naranjo C.
' Fecha:	01/06/2012
' Notas:	Archivo de definición de colecciones de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class DropManager

    'Función que llama el procedimiento que devuelve la colección de registros de los usuarios "profesores" en el exterior
    Public Shared Function ReadAbroadProfessors(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessors_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id del registro del profesor en el exterior y llama el procedimiento que devuelve el registro en la tabla AbroadProfessors "profesor en el exterior"
    Public Shared Function ReadAbroadProfessorsWithId(ByVal AbroadProfessorId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessorsWithId_Read")
        db.AddInParameter(dbCommand, "AbroadProfessorId", DbType.Guid, AbroadProfessorId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id del usuario y llama el procedimiento que devuelve el registro del usuario "profesor" en la tabla AbroadProfessors "profesor en el exterior"
    Public Shared Function ReadAbroadProfessorsWithUserId(ByVal UserId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AbroadProfessorsWithUserId_Read")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve la colección de registros de las redes académicas
    Public Shared Function ReadAcademicNetworks(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworks_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id de la red académica y llama el procedimiento que devuelve el registro de la tabla AcademicNetworks "redes académicas"
    Public Shared Function ReadAcademicNetworksWithId(ByVal AcademicNetworkId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksWithId_Read")
        db.AddInParameter(dbCommand, "AcademicNetworkId", DbType.Guid, AcademicNetworkId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve la colección de registros de las redes académicas por usuarios
    Public Shared Function ReadAcademicNetworksByUsers(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsers_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id de la red académica y llama el procedimiento que devuelve registro de las redes académicas por usuario
    Public Shared Function ReadAcademicNetworksByUsersWithId(ByVal AcademicNetworksByUserId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUserssWithId_Read")
        db.AddInParameter(dbCommand, "AcademicNetworksByUserId", DbType.Guid, AcademicNetworksByUserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id de la red académica y el id del usuario y llama el procedimiento que devuelve registro de las red académica por usuario
    Public Shared Function ReadAcademicNetworksByUsersWithAcademicNetworkIdAndUserId(ByVal AcademicNetworkId As Guid, ByVal UserId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ReadAcademicNetworksByUsersWithAcademicNetworkIdAndUserId_Read")
        db.AddInParameter(dbCommand, "AcademicNetworkId", DbType.Guid, AcademicNetworkId)
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id del usuario y llama el procedimiento que devuelve los registros del usuario por red académica
    Public Shared Function ReadAcademicNetworksByUsersWithUserId(ByVal UserId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsersWithUserId_Read")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve la colección de registros de la información administrativa de los usuarios "profesores"
    Public Shared Function ReadAdministrativeInformations(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformations_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve la colección de registros de la información administrativa de los usuarios "profesores"
    Public Shared Function ReadAdministrativeInformationIdWithId(ByVal AdministrativeInformationId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformationIdWithId_Read")
        db.AddInParameter(dbCommand, "AdministrativeInformationId", DbType.Guid, AdministrativeInformationId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id del usuario y llama el procedimiento que devuelve el registro de la información administrativa del usuario "profesor"
    Public Shared Function ReadAdministrativeInformationsWithUserId(ByVal UserId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AdministrativeInformationsWithUserId_Read")
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id de la ciudad y llama el procedimiento que devuelve el registro de la ciudad
    Public Shared Function ReadCitiesWithId(ByVal CityId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("CitiesWithId_Read")
        db.AddInParameter(dbCommand, "CityId", DbType.Guid, CityId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el id de la región y llama el procedimiento que devuelve las ciudades que pertenecen a la región "departamento"
    Public Shared Function ReadCitiesWithRegionId(ByVal RegionId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("CitiesWithRegionId_Read")
        db.AddInParameter(dbCommand, "RegionId", DbType.Guid, RegionId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que  llama el procedimiento que devuelve todos los tipos de contrato existentes
    Public Shared Function ReadContractTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ContractTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de contrato y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadContractTypesWithId(ByVal ContractTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ContractTypesWithId_Read")
        db.AddInParameter(dbCommand, "ContractTypeId", DbType.Boolean, ContractTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los paises registrados en la tabla Countries
    Public Shared Function ReadCountries(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Countries_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del pais y llama el procedimiento que devuelve el registro del pais
    Public Shared Function ReadCountriesWithId(ByVal CountryId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("CountriesWithId_Read")
        db.AddInParameter(dbCommand, "CountryId", DbType.Boolean, CountryId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los tipos de cursos no formales registrados en la tabla CourseNonformalTypes
    Public Shared Function ReadCourseNonformalTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("CourseNonformalTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del curso no formal y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadCourseNonformalTypesWithId(ByVal CourseNonformalTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("CourseNonformalTypesWithId_Read")
        db.AddInParameter(dbCommand, "CourseNonformalTypeId", DbType.Boolean, CourseNonformalTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los temas de cursos no formales registrados en la tabla CourseTopics
    Public Shared Function ReadCourseTopics(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("CourseTopics_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del curso no formal y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadReadCourseTopicsWithId(ByVal CourseTopicId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ReadCourseTopicsWithId_Read")
        db.AddInParameter(dbCommand, "CourseTopicId", DbType.Boolean, CourseTopicId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los tipos de dedicación del usuario "profesor" registrados en la tabla DedicationProfessorTypes
    Public Shared Function ReadDedicationProfessorTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("DedicationProfessorTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de dedicación del usuario "profesor" y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadDedicationProfessorTypesWithId(ByVal DedicationProfessorTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("DedicationProfessorTypesWithId_Read")
        db.AddInParameter(dbCommand, "DedicationProfessorTypeId", DbType.Boolean, DedicationProfessorTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de fuente de financiación de la IES y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadFundingIesTypeId(ByVal FundingIesTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FundingIesTypeId_Read")
        db.AddInParameter(dbCommand, "FundingIesTypeId", DbType.Boolean, FundingIesTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los tipos de fuente de financiación de la IES registrados en la tabla FundingIesTypes
    Public Shared Function ReadFundingIesTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FundingIesTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del origen de la fuente de financiación de la IES y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadFundingSourceId(ByVal FundingSourceId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FundingSourceId_Read")
        db.AddInParameter(dbCommand, "FundingSourceId", DbType.Boolean, FundingSourceId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los origenes de las fuentes de financiación registrados en la tabla FundingSources
    Public Shared Function ReadFundingSources(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FundingSources_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del origen del tipo de fuente de financiación recibida por el usuario y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadFundingTypeId(ByVal FundingTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FundingTypeId_Read")
        db.AddInParameter(dbCommand, "FundingTypeId", DbType.Boolean, FundingTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los tipo de fuente de financiación recibida por el usuario, registrados en la tabla FundingTypes
    Public Shared Function ReadFundingTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("FundingTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del genero del usuario y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadGenderId(ByVal GenderId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("GenderId_Read")
        db.AddInParameter(dbCommand, "GenderId", DbType.Boolean, GenderId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los generos, registrados en la tabla Genders
    Public Shared Function ReadGenders(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Genders_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de identificación del usuario y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadIdentificationDocumentType_Read(ByVal IdentificationDoumenTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentType_Read")
        db.AddInParameter(dbCommand, "IdentificationDoumenTypeId", DbType.Boolean, IdentificationDoumenTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los diferentes tipos de identificación, registrados en la tabla IdentificationDocumentTypes
    Public Shared Function ReadIdentificationDocumentTypes_ReadAll(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IdentificationDocumentTypes_ReadAll")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id de la IES y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadIesId(ByVal IesId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("IesId_Read")
        db.AddInParameter(dbCommand, "IesId", DbType.Boolean, IesId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve las diferentes IES, registrados en la tabla Ies
    Public Shared Function ReadIes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Ies_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del área del conocimiento y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadKnowledgeAreaId(ByVal KnowledgeAreaId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("KnowledgeAreaId_Read")
        db.AddInParameter(dbCommand, "KnowledgeAreaId", DbType.Boolean, KnowledgeAreaId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve las áreas del conocimiento, registrados en la tabla KnowledgeArea
    Public Shared Function ReadKnowledgeArea(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("KnowledgeArea_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo del estado civíl y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadMaritalStatusTypeId(ByVal MaritalStatusTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("MaritalStatusTypeId_Read")
        db.AddInParameter(dbCommand, "MaritalStatusTypeId", DbType.Boolean, MaritalStatusTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los estados civíles, registrados en la tabla MaritalStatusTypes
    Public Shared Function ReadMaritalStatusTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("MaritalStatusTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de movilidad del usuario y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadMobilityTypeId(ByVal MobilityTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("MobilityTypeId_Read")
        db.AddInParameter(dbCommand, "MobilityTypeId", DbType.Boolean, MobilityTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los diferentes tipos de movilidad, registrados en la tabla MobilityTypes
    Public Shared Function ReadMobilityTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("MobilityTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de modalidad en la que se dicta un programa y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadModalityId(ByVal ModalityId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ModalityId_Read")
        db.AddInParameter(dbCommand, "ModalityId", DbType.Boolean, ModalityId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los diferentes tipos de modalidad de los programas, registrados en la tabla Modalities
    Public Shared Function ReadModalities(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Modalities_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del núcleo básico del conocimiento y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadNbcId(ByVal NbcId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("NbcId_Read")
        db.AddInParameter(dbCommand, "NbcId", DbType.Boolean, NbcId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los núcleos básicos del conocimiento, registrados en la tabla Nbc
    Public Shared Function ReadNbc(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Nbc_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id de la unidad organizacional y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadOrganizationalUnitTypeId(ByVal OrganizationalUnitTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitTypeId_Read")
        db.AddInParameter(dbCommand, "OrganizationalUnitTypeId", DbType.Boolean, OrganizationalUnitTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve las unidades organizacionales, registrados en la tabla OrganizationalUnitTypes
    Public Shared Function ReadOrganizationalUnitTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("OrganizationalUnitTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del programa y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadProgramId(ByVal ProgramId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ProgramId_Read")
        db.AddInParameter(dbCommand, "ProgramId", DbType.Boolean, ProgramId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los programas académicos, registrados en la tabla Programs
    Public Shared Function ReadPrograms(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Programs_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de publicación y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadPublicationTypeId(ByVal PublicationTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationTypeId_Read")
        db.AddInParameter(dbCommand, "PublicationTypeId", DbType.Boolean, PublicationTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los tipos de publicaciones, registrados en la tabla PublicationTypes
    Public Shared Function ReadPublicationTypes(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublicationTypes_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id de la publicación por profesor "PublucationsByProfessorId" y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadPublucationsByProfessorId(ByVal PublucationsByProfessorId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublucationsByProfessorId_Read")
        db.AddInParameter(dbCommand, "PublucationsByProfessorId", DbType.Boolean, PublucationsByProfessorId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve las publicaciones realizadas por los usuarios "profesor", registrados en la tabla PublucationsByProfessors
    Public Shared Function ReadPublucationsByProfessors(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublucationsByProfessors_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del tipo de publicación y llama el procedimiento que devuelve las publicaciones realizadas por los usuarios "profesor", registrados en la tabla PublucationsByProfessors
    Public Shared Function ReadPublucationsByProfessorsWithPublicationTypeId(ByVal PublicationTypeId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("PublucationsByProfessorsWithPublicationTypeId_Read")
        db.AddInParameter(dbCommand, "PublicationTypeId", DbType.Boolean, PublicationTypeId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que recibe el Id del programa y llama el procedimiento que devuelve el registro existente
    Public Shared Function ReadRegionId(ByVal RegionId As Guid, ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RegionId_Read")
        db.AddInParameter(dbCommand, "RegionId", DbType.Boolean, RegionId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    'Función que llama el procedimiento que devuelve los programas académicos, registrados en la tabla Programs
    Public Shared Function ReadP(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("Programs_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadRolId(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("RolIdId_read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadRolesByUserId(ByVal RolId As Guid, ByVal UserId As Guid, ByVal isActive As Guid) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("ReadRolesByUserId_read")
        db.AddInParameter(dbCommand, "RolId", DbType.Guid, RolId)
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadSectionalId(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("SectionalId_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadTrainingInformalByProfessorsId(ByVal TrainingTypeId As Guid, ByVal UserId As Guid, ByVal isActive As Guid) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("SupportsByUsersId_Read")
        db.AddInParameter(dbCommand, "TrainingTypeId", DbType.Guid, TrainingTypeId)
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadSupportsByUsersId(ByVal SupportId As Guid, ByVal UserId As Guid, ByVal isActive As Guid) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("SupportsByUsersId_Read")
        db.AddInParameter(dbCommand, "SupportId", DbType.Guid, SupportId)
        db.AddInParameter(dbCommand, "UserId", DbType.Guid, UserId)
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadTrainingTypeId(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("TrainingTypeId_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadStateUserTypeId(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("StateUserTypeId_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadUserId(ByVal isActive As Boolean) As DataSet
        Dim returnValue As DataSet = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("UserId_Read")
        db.AddInParameter(dbCommand, "IsActive", DbType.Boolean, isActive)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

End Class
