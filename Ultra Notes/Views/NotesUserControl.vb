Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Controllers
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.Views.Components
Imports Ultra_Notes.Views.Dialogs

Namespace Views
    Public Class NotesUserControl
        Private Property GroupId As Long
        Private _notes As New List(Of Note)

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            toolbarPanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, bottom:=1)

            ContentPanel.AutoScroll = True

        End Sub

        Public Sub LoadNotesOf(theGroupId As Long)
            Me.GroupId = theGroupId
            LoadNotes()
        End Sub
        
        Public Sub Clear()
            _notes.Clear()
            ContentPanel.Controls.Clear()
        End Sub

        Private Sub LoadNotes()
            _notes = NoteController.Instance.GetNotesOf(Me.GroupId)
            LoadToUi()
        End Sub

        Private Sub LoadToUi()
            ContentPanel.Controls.Clear()
            Dim topSpace As Integer = 10
            For Each n As Note In _notes
                Dim noteItem As New NoteItem() With {.Top = topSpace, .Left = 9, .Note = n}
                AddHandler noteItem.NoteItemDelete, AddressOf Me.DeleteNoteHandler
                AddHandler noteItem.NoteItemUpdate, AddressOf Me.UpdateNoteHandler
                ContentPanel.Controls.Add(noteItem)
                topSpace += noteItem.Height + 7
            Next
        End Sub

        Private Sub UpdateNoteHandler(sender As Object, e As NoteEventArgs)
            Using noteDialog As New NoteDialog(Modifier.Update, e.Note)
                If (noteDialog.ShowDialog() = DialogResult.OK) Then
                    UpdateNote(noteDialog.Note, TryCast(sender, NoteItem))
                End If
            End Using
        End Sub

        Private Sub DeleteNoteHandler(sender As Object, e As NoteEventArgs)
            Dim deleted = NoteController.Instance.Delete(e.Note)
            If(deleted)
                LoadNotes()
            End If
        End Sub

        Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
            Using noteDialog As New NoteDialog()
                If (noteDialog.ShowDialog() = DialogResult.OK) Then
                    CreateNote(noteDialog.Note)
                End If
            End Using
        End Sub

        Private Sub CreateNote(note As Note)
            Dim n = note
            n.GroupId = Me.GroupId
            Dim inserted = NoteController.Instance.Insert(n)
            If (inserted > 0) Then
                LoadNotes()
            End If
        End Sub
        
        Private Sub UpdateNote(note As Note, noteItem As NoteItem)
            Dim n = note
            n.GroupId = Me.GroupId
            n.UpdatedAt = Date.Now.AsString()
            Dim updated = NoteController.Instance.Update(n)
            If (updated) Then
                noteItem.Note = note
            End If
        End Sub
        
    End Class
End Namespace