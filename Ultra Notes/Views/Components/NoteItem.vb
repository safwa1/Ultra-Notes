Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.App.Utils

Namespace Views.Components
    Public Class NoteItem
        
        Public Event NoteItemDelete As EventHandler(Of NoteEventArgs)
        Public Event NoteItemUpdate As EventHandler(Of NoteEventArgs)

        Private _note As Note
        Public Property Note As Note
            Get
                Return _note
            End Get
            Set
                _note = Value
                InitializeData(Value)
            End Set
        End Property

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
        End Sub

        Private Sub InitializeData(value As Note)
            txtTitle.Text = value.Title
            txtBody.Text = value.Body
            txtDate.Text = value.CreatedAt
        End Sub

        Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
            Using viewer As New NoteViewer(Me.Note)
                viewer.ShowDialog()
            End Using
        End Sub

        Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
            RaiseEvent NoteItemUpdate(Me, New NoteEventArgs(Note))
        End Sub

        Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
            Dim confirm As DialogResult = Sure()
            If (confirm = DialogResult.OK) Then
                RaiseEvent NoteItemDelete(Me, New NoteEventArgs(Note))
            End If
        End Sub
        
    End Class
End Namespace