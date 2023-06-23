Imports System.Data.Common

Namespace App.Contracts

    Public Interface IDatabase
        Function SetConnectionString(ByVal connectionString As String) As IDatabase
        Function GetDatabase() As IDbConnection
        Function Insert(Of T As Class)(ByVal value As T) As Long
        Function Update(Of T As Class)(ByVal value As T) As Boolean
        Function Delete(Of T As Class)(ByVal value As T) As Boolean
        Function DeleteAll(Of T As Class)() As Boolean
        Function GetAll(Of T As Class)() As IEnumerable(Of T)
        Function [Get](Of T As Class, TIdentity)(ByVal id As TIdentity) As T
        Function GetBy(Of T As Class)(ByVal selector As String, ByVal value As Object, ByVal tableName As String) As T
        Function [Select](ByVal queryText As String, Optional ByVal param As DbParameter() = Nothing) As DataTable
    End Interface
    
End NameSpace