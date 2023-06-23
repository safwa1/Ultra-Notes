Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models

Namespace Views.Dialogs
    Public Class NoteDialog
        
        Public Property Note As Note
        Private ReadOnly _modifier As Modifier

        Public Sub New(ByVal Optional modifier As Modifier = Modifier.Create, ByVal Optional n As Note = Nothing)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow()
            Me.Draggable()
            toolbarPanel.Draggable()

            ' Set values
            _modifier = modifier

            If (_modifier = Modifier.Update)
                Me.Note = n
                BindData()
            End If
        End Sub

        Private Sub BindData()
            txtNoteTitle.Value = Me.Note.Title
            txtNoteBody.Value = Me.Note.Body
        End Sub

        Private Sub GroupDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtTitle.Text = IIf(_modifier = Modifier.Create, "إنشاء الملاحضة", "تعديل الملاحضة")
        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub

        Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
            If (txtNoteTitle.Value.IsBlank()) Then
                txtError.Text = "اكتب العنوان أولاً"
                txtNoteTitle.Focus()
                Return
            End If

            If (txtNoteBody.Value.IsBlank()) Then
                txtError.Text = "اكتب نص الملاحضة أولاً"
                txtNoteBody.Focus()
                Return
            End If
            
            If (_modifier = Modifier.Create)
                Me.Note = New Note() _
                    With { .Title = txtNoteTitle.Value, .Body = txtNoteBody.Value, .CreatedAt = Date.Now.AsString() }
            Else
                Me.Note.Title = txtNoteTitle.Value
                Me.Note.Body = txtNoteBody.Value
                Me.Note.UpdatedAt = Date.Now.AsString()
            End If
            OkResult()
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelActionButton.Click
            Me.Close()
        End Sub

        Private Sub OkResult()
            DialogResult = DialogResult.OK
            OkButton.DialogResult = DialogResult.OK
        End Sub
        
    End Class
End Namespace