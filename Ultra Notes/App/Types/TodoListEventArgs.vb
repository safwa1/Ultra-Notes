Imports Ultra_Notes.App.Models

Namespace App.Types
    
    Public Class TodoListEventArgs
        Inherits EventArgs

        Sub New(todoList As TodoList, selected As Boolean)
            Me.TodoList = todoList
            Me.Selected = selected
        End Sub

        Public ReadOnly Property TodoList As TodoList
        Public ReadOnly Property Selected As Boolean
        
    End Class
    
End NameSpace