Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Databases
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types

Namespace App.Controllers
    
    Public NotInheritable Class UserController
        Inherits Singleton(Of UserController)
        Implements IController(Of User)

        ReadOnly Dim _database As IDatabase

        Private Sub New()
            _database = Database.Instance
        End Sub
        
        Public Function Insert(value As User) As Long Implements IController(Of User).Insert
            Return _database.Insert(value := value)
        End Function

        Public Function Update(value As User) As Boolean Implements IController(Of User).Update
            Return _database.Update(value := value)
        End Function

        Public Function Delete(value As User) As Boolean Implements IController(Of User).Delete
            Return _database.Delete(value := value)
        End Function

        Public Function DeleteAll() As Boolean Implements IController(Of User).DeleteAll
            Return _database.DeleteAll(Of User)
        End Function

        Public Function GetAll() As IEnumerable(Of User) Implements IController(Of User).GetAll
            Return _database.GetAll(Of User)
        End Function

        Public Function [Get] (Of TIdentity)(id As TIdentity) As User Implements IController(Of User).[Get]
            Return _database.Get(Of User, TIdentity)(id := id) 
        End Function
        
    End Class
    
End NameSpace