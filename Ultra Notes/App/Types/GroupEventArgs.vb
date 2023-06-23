Imports Ultra_Notes.App.Models

Namespace App.Types
    
    Public Class GroupEventArgs
        Inherits EventArgs

        Sub New(group As Group, selected As Boolean)
            Me.Group = group
            Me.Selected = selected
        End Sub

        Public ReadOnly Property Group As Group
        Public ReadOnly Property Selected As Boolean
        
    End Class
    
End NameSpace