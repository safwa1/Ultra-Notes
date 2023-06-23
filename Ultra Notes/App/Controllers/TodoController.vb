Imports Dapper
Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Databases
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types

Namespace App.Controllers
    
    Public NotInheritable Class TodoController
        Inherits Singleton(Of TodoController)
        Implements IController(Of Todo)
        
        Private ReadOnly _database As IDatabase
        
        Private Sub New()
            _database = Database.Instance
        End Sub

        Public Function Insert(value As Todo) As Long Implements IController(Of Todo).Insert
            Return _database.Insert(value)
        End Function

        Public Function Update(value As Todo) As Boolean Implements IController(Of Todo).Update
            Return _database.Update(value)
        End Function

        Public Function Delete(value As Todo) As Boolean Implements IController(Of Todo).Delete
            Return _database.Delete(value)
        End Function

        Public Function DeleteAll() As Boolean Implements IController(Of Todo).DeleteAll
            Return _database.DeleteAll(Of Todo)
        End Function

        Public Function GetAll() As IEnumerable(Of Todo) Implements IController(Of Todo).GetAll
            Return _database.GetAll(Of Todo)
        End Function

        Public Function [Get] (Of TIdentity)(id As TIdentity) As Todo Implements IController(Of Todo).[Get]
            Throw New NotImplementedException
        End Function
        
        Public Function GetTodosOf(ByVal todoListId As Long, ByVal Optional type As TodoType = TodoType.UnCompleted) As IEnumerable(Of Todo)
            Dim condition As String = String.Empty
            Select Case type
                Case TodoType.Completed
                    condition = " and Completed=true"
                Case TodoType.UnCompleted
                    condition = " and Completed=false"
                Case TodoType.Nano
                    condition = String.Empty
            End Select
            Using db = _database.GetDatabase()
                Return db.Query (Of Todo)("select * from Todos where TodoListId=@todoListId" & condition, New With{ todoListId })
            End Using
        End Function
        
        Public Sub DeleteTodosOf(todoListId As Long)
            Using db = _database.GetDatabase()
                db.Execute("delete from Todos where TodoListId=@todoListId", New With{ todoListId })
            End Using
        End Sub
        
    End Class
End NameSpace