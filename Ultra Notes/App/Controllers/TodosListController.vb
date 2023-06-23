Imports Dapper
Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Databases
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types

Namespace App.Controllers
    
    Public NotInheritable Class TodosListController
        Inherits Singleton(Of TodosListController)
        Implements IController(Of TodoList)
        
        Private ReadOnly _database As IDatabase
        
        Public Sub New()
            _database = Database.Instance
        End Sub

        Public Function Insert(value As TodoList) As Long Implements IController(Of TodoList).Insert
            Return _database.Insert(value)
        End Function

        Public Function Update(value As TodoList) As Boolean Implements IController(Of TodoList).Update
            Return _database.Update(value)
        End Function

        Public Function Delete(value As TodoList) As Boolean Implements IController(Of TodoList).Delete
            Return _database.Delete(value)
        End Function

        Public Function DeleteAll() As Boolean Implements IController(Of TodoList).DeleteAll
            Return _database.DeleteAll(Of TodoList)
        End Function

        Public Function GetAll() As IEnumerable(Of TodoList) Implements IController(Of TodoList).GetAll
            Return _database.GetAll(Of TodoList)
        End Function

        Public Function [Get] (Of TIdentity)(id As TIdentity) As TodoList Implements IController(Of TodoList).[Get]
            Return _database.Get(Of TodoList, TIdentity)(id)
        End Function
        
        Public Function GetTodosListOf(ByVal groupId As Long) As IEnumerable(Of TodoList)
            Using db = _database.GetDatabase()
                Return db.Query (Of TodoList)("select * from TodoList where GroupId=@groupId", New With{ groupId })
            End Using
        End Function
        
        Public Sub DeleteTodosListsOf(groupId As Long)
            Using db = _database.GetDatabase()
                db.Execute("delete from TodoList where GroupId=@groupId", New With{ groupId })
            End Using
        End Sub
        
    End Class
    
End NameSpace