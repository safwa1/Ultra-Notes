Imports Dapper
Imports Ultra_Notes.App.Contracts
Imports Ultra_Notes.App.Databases
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types

Namespace App.Controllers
    
    Public NotInheritable Class AuthController
        Inherits Singleton(Of AuthController)
        
        Private ReadOnly Dim _database As IDatabase

        Private Sub New()
            _database = Database.Instance
        End Sub

        Public Function Login(ByVal username As String, ByVal password As String) As Boolean
            Dim result As Integer
            Using db = _database.GetDatabase()
                result =
                    db.Query (Of User)("select * from Users where Username=@username and Password=@password", New With{ username, password }).Count()
            End Using
            If (result > 0) Then
                CurrentUser = _database.GetBy (Of User)("Username", username, "Users")
                Return True
            End If
            Return False
        End Function

        Public Function Register(user As User) As Boolean
            Dim newUser As New User With {
                .Name = user.Name,
                .Username = user.Username,
                .Password = user.Password,
                .Type = IIf(HasAdminUser() = True, UserType.User, UserType.Admin),
                .CreatedAt = Date.Now.AsString()
            }
            Dim id = UserController.Instance.Insert(newUser)
            Return id > 0
        End Function


        Private Function HasAdminUser() As Boolean
            Dim result As Integer
            Const type = UserType.Admin
            Using db = _database.GetDatabase()
                result = db.Query (Of User)("select * from Users where Type=@type", New With{ type }).Count()
            End Using
            Return result > 0
        End Function

        Public Shared Property CurrentUser As User
    End Class
End NameSpace
