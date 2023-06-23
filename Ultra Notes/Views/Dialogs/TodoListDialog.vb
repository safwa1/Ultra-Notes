Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models

Namespace Views.Dialogs
    
    Public Class TodoListDialog
        
        Public Property TodoList As TodoList
        Private ReadOnly _modifier As Modifier

        Public Sub New(ByVal Optional modifier As Modifier = Modifier.Create, ByVal Optional list As TodoList = Nothing)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow()
            Me.Draggable()
            toolbarPanel.Draggable()

            ' Set values
            _modifier = modifier

            If (_modifier = Modifier.Update)
                Me.TodoList = list
                txtName.Value = Me.TodoList.Name
            End If
        End Sub

        Private Sub GroupDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtTitle.Text = If(_modifier = Modifier.Create, "إنشاء قائمة", "تعديل القائمة")
        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub

        Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
            If (txtName.Value.IsBlank()) Then
                txtError.Text = "اكتب إسم القائمة أولاً"
                txtName.Focus()
                Return
            End If

            If (_modifier = Modifier.Create)
                Me.TodoList = New TodoList() _
                    With {.Name = txtName.Value, .CreatedAt = Date.Now.AsString()}
            Else
                Me.TodoList.Name = txtName.Value
                Me.TodoList.UpdatedAt = Date.Now.AsString()
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