Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Models

Namespace Views
    Public Class NoteViewer

        Public Sub New(note As Note)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow
            Me.Draggable
            toolbarPanel.Draggable

            txtTitle.Text = note.Title
            txtBody.Text = note.Body
            txtDate.Text = note.CreatedAt

        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub
        
    End Class
End Namespace