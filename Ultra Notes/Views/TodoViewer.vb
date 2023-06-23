Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Models

Namespace Views
    Public Class TodoViewer

        Public Sub New(todo As Todo)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow
            Me.Draggable
            toolbarPanel.Draggable

            txtTodo.Text = todo.Text
            txtCreatedAt.Text = todo.CreatedAt
            txtUpdatedAt.Text = todo.UpdatedAt
            txtStatus.Text = IIf(todo.Completed, "مكتملة", "غير مكتملة")

        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub
        
    End Class
End Namespace