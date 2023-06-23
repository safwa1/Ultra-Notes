Imports Ultra_Notes.App.Controllers
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.App.Utils

Namespace Views.Components
    Public Class TodoItem
        
        Public Event TodoItemDelete As EventHandler(Of TodoEventArgs)
        Public Event TodoItemUpdate As EventHandler(Of TodoEventArgs)
        Public Event TodoItemCompleted As EventHandler(Of TodoEventArgs)

        Private _todo As Todo
        Public Property Todo As Todo
            Get
                Return _todo
            End Get
            Set
                _todo = value
                Text = value.Text
                Dim fontStyle As FontStyle = IIF(value.Completed, FontStyle.Strikeout, FontStyle.Regular)
                txtTitle.Font = New Font(txtTitle.Font.Name, txtTitle.Font.Size, fontStyle)
                editButton.Enabled = Not value.Completed
                chkComplete.Checked = value.Completed
            End Set
        End Property

        Public Overrides Property Text As String
            Get
                Return txtTitle.Text
            End Get
            Set
                txtTitle.Text = value
            End Set
        End Property

        Public Sub New(t As Todo)
            ' This call is required by the designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
            Me.Todo = t
            Me.Text = t.Text
        End Sub

        Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
            Using preview As New TodoViewer(Todo)
                preview.ShowDialog()
            End Using
        End Sub

        Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
            RaiseEvent TodoItemUpdate(Me, New TodoEventArgs(Todo))
        End Sub

        Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
            Dim confirm As DialogResult = Sure()
            If (confirm = DialogResult.OK) Then
                RaiseEvent TodoItemDelete(Me, New TodoEventArgs(Todo))
            End If
        End Sub

        Private Sub chkComplete_CheckedChanged(sender As Object, e As EventArgs) Handles chkComplete.CheckedChanged
            Me.Todo.Completed = chkComplete.Checked
            Me.Todo.UpdatedAt = Date.Now.AsString()
            Dim updated = TodoController.Instance.Update(Me.Todo)
            If (updated) Then
                ' todo: optimize it later
                Dim tmp = Me.Todo
                Me.Todo = tmp 
                RaiseEvent TodoItemCompleted(Me, New TodoEventArgs(Todo))
            End If
        End Sub
        
    End Class
End NameSpace