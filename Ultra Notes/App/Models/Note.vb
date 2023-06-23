Imports Dapper.Contrib.Extensions
Imports Ultra_Notes.App.Enums

Namespace App.Models
    
    <Table("Notes")>
    Public Class Note
        Inherits BaseModel
        
        Public Property GroupId As Long
        Public Property Title As String
        Public Property Body As String
        Public Property Type As NoteType
        
    End Class
    
End NameSpace