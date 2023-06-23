Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Controllers
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.App.Utils
Imports Ultra_Notes.Views.Components
Imports Ultra_Notes.Views.Dialogs

Namespace Views
    Public Class TasksUserControl

        Private _todos As New List(Of Todo)
        Private _todosList As New List(Of TodoList)
        
        Private _selectedTodoList As TodoList
        Private _selectedTodoListItem As TodoListItem

        Private Property GroupId As Long
        
        Private _todoType As TodoType = TodoType.UnCompleted
        Private Property TodoType As TodoType
            Get
                Return _todoType
            End Get
            Set
                _todoType = value
                LoadTodos()
            End Set
        End Property

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            toolbarPanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, bottom:=1)
            CreateTodoTablePanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, top:=1)
            TodoControlsPanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, bottom:=1)

            TodosPanel.AutoScroll = True
            RightPanelHeader.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, bottom:=1)
            RightPanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, left:=1)
        End Sub

        Public Sub LoadTodoListOf(theGroupId As Long)
            Me.GroupId = theGroupId
            LoadTodosLists()
        End Sub

        Public Sub Clear()
            _todosList.Clear()
            ListsPanel.Controls.Clear()
        End Sub

        Private Sub LoadTodosLists()
            _todosList = TodosListController.Instance.GetTodosListOf(Me.GroupId)
            LoadTodosListsToUi()
        End Sub

        Private Sub LoadTodosListsToUi()
            ListsPanel.Controls.Clear()
            Dim topSpace As Integer = 7
            For Each n As TodoList In _todosList
                Dim todoListItem As New TodoListItem(n) With {.Top = topSpace, .Left = 5}
                ' -> events
                AddHandler todoListItem.BeforeSelectedChanged, AddressOf Me.BeforeTodoListItemSelectedChangeHandler
                AddHandler todoListItem.SelectedChanged, AddressOf Me.TodoListItemSelectedChangeHandler
                ListsPanel.Controls.Add(todoListItem)
                topSpace += todoListItem.Height + 4
            Next
        End Sub

        Private Sub TodoListItemSelectedChangeHandler(sender As Object, e As TodoListEventArgs)
            ' TODO: unselect all items
            _selectedTodoList = IIf(e.Selected, e.TodoList, Nothing)
            _selectedTodoListItem = IIf(e.Selected, TryCast(sender, TodoListItem), Nothing)
            If (e.Selected) Then
                ' show it
                ShowTodosControls()
                ' load todos
                LoadTodos()
            End If
        End Sub
        
        Private Sub LoadTodos() 
            _todos = TodoController.Instance.GetTodosOf(_selectedTodoList.Id, Me.TodoType)
            TodosPanel.Controls.Clear()
            Dim topSpace = 7
            For Each t As Todo In _todos
                Dim item As New TodoItem(t) With{.Top = topSpace, .Left = 7}
                AddHandler item.TodoItemUpdate, AddressOf Me.TodoUpdateHandler
                AddHandler item.TodoItemDelete, AddressOf Me.TodoDeleteHandler
                AddHandler item.TodoItemCompleted, AddressOf Me.TodoCompletedHandler
                TodosPanel.Controls.Add(item)
                topSpace += item.Height + 4
            Next
        End Sub

        Private Sub TodoCompletedHandler(sender As Object, e As TodoEventArgs)
            Me.TodoType = TodoType.UnCompleted
        End Sub

        Private Sub TodoDeleteHandler(sender As Object, e As TodoEventArgs)
            Dim deleted = TodoController.Instance.Delete(e.Todo)
            If(deleted)
                LoadTodos()
            End If
        End Sub

        Private Sub TodoUpdateHandler(sender As Object, e As TodoEventArgs)
            Using todoDialog As New TodoDialog(e.Todo)
                If(todoDialog.ShowDialog() = DialogResult.OK)
                    Dim updated = TodoController.Instance.Update(todoDialog.Todo)
                    If(updated)
                        Dim item = TryCast(sender, TodoItem)
                        item.Todo = todoDialog.Todo
                    End If
                End If
            End Using
        End Sub

        Private Sub ShowTodosControls()
            _todos.Clear()
            TodosPanel.Controls.Clear()
            TodosPanel.Visible = True
            CreateTodoTablePanel.Visible = True
            TodoControlsPanel.Visible = True
        End Sub

        Private Sub BeforeTodoListItemSelectedChangeHandler(sender As Object, e As EventArgs)
            For Each i As TodoListItem In ListsPanel.Controls
                i.Selected = False
            Next
        End Sub

        Private Sub addListButton_Click(sender As Object, e As EventArgs) Handles addListButton.Click
            Using todoListDialog As New TodoListDialog()
                If (todoListDialog.ShowDialog() = DialogResult.OK) Then
                    Dim list = todoListDialog.TodoList
                    list.GroupId = Me.GroupId
                    CreateTodoList(list)
                End If
            End Using
        End Sub

        Private Sub editListButton_Click(sender As Object, e As EventArgs) Handles editListButton.Click
            Using todoListDialog As New TodoListDialog(Modifier.Update, _selectedTodoList)
                If (todoListDialog.ShowDialog() = DialogResult.OK) Then
                    Dim list = todoListDialog.TodoList
                    list.UpdatedAt = Date.Now.AsString()
                    UpdateTodoList(list)
                End If
            End Using
        End Sub

        Private Sub deleteListButton_Click(sender As Object, e As EventArgs) Handles deleteListButton.Click
            If (Not IsNothing(_selectedTodoList)) Then
                Dim yes As DialogResult = Messages.Sure()
                If (yes = DialogResult.OK) Then
                    Dim delete = TodosListController.Instance.Delete(_selectedTodoList)
                    If (delete) Then
                        ' Todo: remove it todos
                        TodoController.Instance.DeleteTodosOf(todoListId:=_selectedTodoList.Id)
                        ' Reset State
                        _selectedTodoList = Nothing
                        _selectedTodoListItem = Nothing
                        LoadTodosLists()
                    End If
                End If
            End If
        End Sub

        Private Sub CreateTodoList(todoList As TodoList)
            Dim inserted = TodosListController.Instance.Insert(todoList)
            If (inserted > 0) Then
                LoadTodosLists()
            End If
        End Sub

        Private Sub UpdateTodoList(todoList As TodoList)
            Dim updated = TodosListController.Instance.Update(todoList)
            If (updated) Then
                _selectedTodoListItem.TodoList = todoList
            End If
        End Sub

        Private Sub createTodoButton_Click(sender As Object, e As EventArgs) Handles createTodoButton.Click
            Dim todoText = txtTodo.Value
            If(todoText.IsBlank())
                txtTodo.Focus()
                Return
            End If
            Dim todo As New Todo With { .TodoListId = _selectedTodoList.Id, .Text = todoText, .Completed = False, .CreatedAt = Date.Now.AsString() }
            Dim create = TodoController.Instance.Insert(todo)
            If(create > 0)
                txtTodo.Clear()
                ' load uncompleted todos
                Me.TodoType = TodoType.UnCompleted
            End If
            
        End Sub

        Private Sub unCompletedTodosButton_Click(sender As Object, e As EventArgs) Handles unCompletedTodosButton.Click
            Me.TodoType = TodoType.UnCompleted
        End Sub

        Private Sub completedTodosButton_Click(sender As Object, e As EventArgs) Handles completedTodosButton.Click
            Me.TodoType = TodoType.Completed
        End Sub

        Private Sub allTodosButton_Click(sender As Object, e As EventArgs) Handles allTodosButton.Click
            Me.TodoType = TodoType.Nano
        End Sub
        
    End Class
End Namespace