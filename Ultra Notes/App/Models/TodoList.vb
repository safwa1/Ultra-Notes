Imports Dapper.Contrib.Extensions

Namespace App.Models
    
    <Table("TodoList")>
    Public Class TodoList
        Inherits BaseModel
        
        Public Property Name As String
        Public Property GroupId As Long
    
    End Class
End NameSpace