Imports System.Data.Common
Imports System.Data.SqlClient
Imports Dapper
Imports Dapper.Contrib.Extensions
Imports Microsoft.Data.Sqlite
Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Types

Namespace App.Databases
    
    Public NotInheritable Class Database 
        Inherits Singleton(Of Database)
        Implements IDatabase
        
        Public Property ConnectionString As String

        Private Sub New()
            ConnectionString = "Data Source=Database.db"
        End Sub
        
        Public Function SetConnectionString(connection As String) As IDatabase Implements IDatabase.SetConnectionString
            ConnectionString = connection
            Return Me
        End Function

        Public Function GetDatabase() As IDbConnection Implements IDatabase.GetDatabase
            Dim connection = New SqliteConnection(ConnectionString)
            SQLitePCL.raw.SetProvider(New SQLitePCL.SQLite3Provider_dynamic_cdecl())
            Return connection
        End Function

        Public Function Insert(Of T As Class)(value As T) As Long Implements IDatabase.Insert
            Using db = GetDatabase()
                Return db.Insert(value)
            End Using
        End Function

        Public Function Update(Of T As Class)(value As T) As Boolean Implements IDatabase.Update
            Using db = GetDatabase()
                Return db.Update(value)
            End Using
        End Function

        Public Function Delete(Of T As Class)(value As T) As Boolean Implements IDatabase.Delete
            Using db = GetDatabase()
                Return db.Delete(value)
            End Using
        End Function

        Public Function DeleteAll(Of T As Class)() As Boolean Implements IDatabase.DeleteAll
            Using db = GetDatabase()
                Return db.DeleteAll(Of T)()
            End Using
        End Function

        Public Function GetAll(Of T As Class)() As IEnumerable(Of T) Implements IDatabase.GetAll
            Using db = GetDatabase()
                Return db.GetAll(Of T)()
            End Using
        End Function

        Public Function [Get](Of T As Class, TIdentity)(id As TIdentity) As T Implements IDatabase.[Get]
            Using db = GetDatabase()
                Return db.Get(Of T)(id)
            End Using 
        End Function

        Public Function IDatabase_GetBy(Of T As Class)(selector As String, value As Object, tableName As String) As T Implements IDatabase.GetBy
            Using db As IDbConnection = GetDatabase()
                Return db.Query(Of T)($"select * from {tableName} where {selector}=@value", New With {value}).Single()
            End Using
        End Function

        Private Function [Select](queryText As String, Optional param() As DbParameter = Nothing) As DataTable _
            Implements IDatabase.Select
            Using sqlcmd = New SqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = queryText,
                .Connection = CType(GetDatabase(), SqlConnection)
                }

                If param IsNot Nothing Then
                    For Each t In param
                        sqlcmd.Parameters.Add(t)
                    Next
                End If

                Using da = New SqlDataAdapter(sqlcmd)
                    Dim dt = New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Function

    End Class
    
End Namespace