Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models

Namespace Views.Dialogs
    Public Class TodoDialog
        
        Public Property Todo As Todo
        
        Public Sub New(task As Todo)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow()
            Me.Draggable()
            toolbarPanel.Draggable()

            ' Set values
            Me.Todo = task
            txtTodo.Value = task.Text

        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub

        Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
            If (txtTodo.Value.IsBlank()) Then
                txtError.Text = "نص المهمة غير موجود"
                txtTodo.Focus()
                Return
            End If
            Me.Todo.Text = txtTodo.Value
            Me.Todo.UpdatedAt = Date.Now.AsString()
            OkResult()
        End Sub
        
        Private Sub OkResult()
            DialogResult = DialogResult.OK
            OkButton.DialogResult = DialogResult.OK
        End Sub
        
    End Class
End Namespace