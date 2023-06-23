Imports Dapper
Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types

Namespace App.Controllers
    
    Public NotInheritable Class NoteController
        Inherits Singleton(Of NoteController)
        Implements IController(Of Note)
        
        Private ReadOnly _database As IDatabase
        
        Private Sub New()
            _database = Databases.Database.Instance
        End Sub

        Public Function Insert(value As Note) As Long Implements IController(Of Note).Insert
            Return _database.Insert(value)
        End Function

        Public Function Update(value As Note) As Boolean Implements IController(Of Note).Update
            Return _database.Update(value)
        End Function

        Public Function Delete(value As Note) As Boolean Implements IController(Of Note).Delete
            Return _database.Delete(value)
        End Function

        Public Function DeleteAll() As Boolean Implements IController(Of Note).DeleteAll
            Return _database.DeleteAll(Of Note)
        End Function

        Public Function GetAll() As IEnumerable(Of Note) Implements IController(Of Note).GetAll
            Return _database.GetAll(Of Note)
        End Function

        Public Function [Get] (Of TIdentity)(id As TIdentity) As Note Implements IController(Of Note).[Get]
            Return _database.Get(Of Note, TIdentity)(id)
        End Function
        
        Public Function GetNotesOf(ByVal groupId As Long) As IEnumerable(Of Note)
            Using db = _database.GetDatabase()
                Return db.Query (Of Note)("select * from Notes where GroupId=@groupId", New With{ groupId })
            End Using
        End Function
        
        Public Sub DeleteNotesOf(groupId As Long)
            Using db = _database.GetDatabase()
                 db.Execute("delete from Notes where GroupId=@groupId", New With{ groupId })
            End Using
        End Sub
        
    End Class
    
End NameSpace