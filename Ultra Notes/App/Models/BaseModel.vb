Imports Dapper.Contrib.Extensions

Namespace App.Models
    
    Public MustInherit Class BaseModel
    
        <Key>
        Public Property Id As Long
        Public Property CreatedAt As String
        Public Property UpdatedAt As String
        
    End Class
    
End NameSpace