Imports Dapper
Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Databases
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types

Namespace App.Controllers
    
    Public NotInheritable Class GroupController
        Inherits Singleton(Of GroupController)
        Implements IController(Of Group)
        
        ReadOnly Dim _database As IDatabase

        Private Sub New()
            _database = Database.Instance
        End Sub

        Public Function Insert(value As Group) As Long Implements IController(Of Group).Insert
            Return _database.Insert(value := value)
        End Function

        Public Function Update(value As Group) As Boolean Implements IController(Of Group).Update
            Return _database.Update(value := value)
        End Function

        Public Function Delete(value As Group) As Boolean Implements IController(Of Group).Delete
            Return _database.Delete(value := value)
        End Function

        Public Function DeleteAll() As Boolean Implements IController(Of Group).DeleteAll
            Return _database.DeleteAll(Of Group)
        End Function

        Public Function GetAll() As IEnumerable(Of Group) Implements IController(Of Group).GetAll
            Return _database.GetAll(Of Group)
        End Function

        Public Function [Get] (Of TIdentity)(id As TIdentity) As Group Implements IController(Of Group).[Get]
            Return _database.Get(Of Group, TIdentity)(id := id) 
        End Function
        
        Public Function GetGroupsOf(ByVal userId As Long) As IEnumerable(Of Group)
            Using db = _database.GetDatabase()
               Return db.Query (Of Group)("select * from Groups where UserId=@userId", New With{ userId })
            End Using
        End Function
        
    End Class
    
End NameSpace