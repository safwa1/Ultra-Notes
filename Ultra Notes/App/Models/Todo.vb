Imports Dapper.Contrib.Extensions

Namespace App.Models
    
    <Table("Todos")>
    Public Class Todo
        Inherits BaseModel
        
        Public Property Text As String
        Public Property Completed As Boolean
        Public Property TodoListId As Long
        
    End Class
    
End NameSpace