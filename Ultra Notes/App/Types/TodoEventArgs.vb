Imports Ultra_Notes.App.Models

Namespace App.Types
    
    Public Class TodoEventArgs
        Inherits EventArgs

        Sub New(todo As Todo)
            Me.Todo = todo
        End Sub

        Public ReadOnly Property Todo As Todo
        
    End Class
    
End NameSpace