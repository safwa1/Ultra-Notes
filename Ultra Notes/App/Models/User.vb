Imports Dapper.Contrib.Extensions
Imports Ultra_Notes.App.Enums

Namespace App.Models
    
    <Table("Users")>
    Public Class User
        Inherits BaseModel
        
        Public Property Name As String
        Public Property Username As String
        Public Property Password As String
        Public Property Type As UserType
        
    End Class
    
End NameSpace