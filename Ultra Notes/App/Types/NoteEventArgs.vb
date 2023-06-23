Imports Ultra_Notes.App.Models

Namespace App.Types
    
    Public Class NoteEventArgs
        Inherits EventArgs

        Sub New(note As Note)
            Me.Note = note
        End Sub

        Public ReadOnly Property Note As Note
        
    End Class
    
End NameSpace