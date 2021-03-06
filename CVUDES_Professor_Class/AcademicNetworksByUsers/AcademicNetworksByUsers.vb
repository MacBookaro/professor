﻿' ==========================================================================================
' Autor:	Carlos Alberto Quiñonez Tellez
' Fecha:	05/06/2012 11:04:36
' Notas:	Archivo de definición de colecciones de clase 
' ==========================================================================================

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public NotInheritable Class AcademicNetworksByUsers

    Private Sub New()
    End Sub

    Public Shared Function ReadPaged(ByVal pageIndex As Integer, ByVal records As Integer, ByVal orderField As String, ByVal orderDirection As String) As Dataset
        Dim returnValue As Dataset = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsers_ReadPaged")
        db.AddInParameter(dbCommand, "PageIndex", DbType.Int32, pageIndex)
        db.AddInParameter(dbCommand, "Records", DbType.Int16, records)
        db.AddInParameter(dbCommand, "OrderField", DbType.String, orderField)
        db.AddInParameter(dbCommand, "OrderDirection", DbType.String, orderDirection)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadPagedCount() As Integer
        Dim returnValue As Integer = 0
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsers_ReadPagedCount")
        returnValue = db.ExecuteScalar(dbCommand)
        Return returnValue
    End Function

    Public Shared Function ReadAll() As DataSet
        Dim returnValue As Dataset = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsers_ReadAll")
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function QuickSearch(ByVal pageIndex As Integer, ByVal records As Integer, ByVal orderField As String, ByVal orderDirection As String, ByVal searchField As String, ByVal searchText As String) As DataSet
        Dim returnValue As Dataset = Nothing
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsers_QuickSearch")
        db.AddInParameter(dbCommand, "PageIndex", DbType.Int32, pageIndex)
        db.AddInParameter(dbCommand, "Records", DbType.Int16, records)
        db.AddInParameter(dbCommand, "OrderField", DbType.String, orderField)
        db.AddInParameter(dbCommand, "OrderDirection", DbType.String, orderDirection)
        db.AddInParameter(dbCommand, "SearchField", DbType.String, searchField)
        db.AddInParameter(dbCommand, "SearchText", DbType.String, searchText)
        returnValue = db.ExecuteDataSet(dbCommand)
        Return returnValue
    End Function

    Public Shared Function QuickSearchCount(ByVal searchField As String, ByVal searchText As String) As Integer
        Dim returnValue As Integer = 0
        Dim db As Database = DatabaseFactory.CreateDatabase("ConexionDB")
        Dim dbCommand As DbCommand = db.GetStoredProcCommand("AcademicNetworksByUsers_QuickSearchCount")
        db.AddInParameter(dbCommand, "SearchField", DbType.String, searchField)
        db.AddInParameter(dbCommand, "SearchText", DbType.String, searchText)
        returnValue = db.ExecuteScalar(dbCommand)
        Return returnValue
    End Function

End Class


