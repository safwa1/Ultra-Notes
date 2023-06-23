Imports Dapper.Contrib.Extensions

Namespace App.Models
    
    <Table("Groups")>
    Public Class Group
        Inherits BaseModel
        
        Public Property Name As String
        Public Property UserId As Long
        
    End Class
    
End NameSpace