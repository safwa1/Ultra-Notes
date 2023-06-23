Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.App.Utils

Namespace Views.Components
    Public Class TodoListItem
        
        Public Event BeforeSelectedChanged As EventHandler
        Public Event SelectedChanged As EventHandler(Of TodoListEventArgs)
        
        Private _todoList As TodoList
        Public Property TodoList As TodoList
            Get
                Return _todoList
            End Get
            Set
                _todoList = value
                Text = value.Name
            End Set
        End Property

        Private _selected As Boolean
        Public Property Selected As Boolean
            Get
                Return _selected
            End Get
            Set
                _selected = value
                BorderColor = IIf(_selected, Colors.ActiveColor, Color.FromArgb(29, 38, 60))
                txtTitle.ForeColor = IIf(_selected, Color.DodgerBlue, Color.Silver)
            End Set
        End Property

        Public Overrides Property Text As String
            Get
                Return txtTitle.Text
            End Get
            Set(value As String)
                txtTitle.Text = value
            End Set
        End Property

        Public Sub New(list As TodoList)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.todoList = list
            Me.Text = list.Name
        End Sub

        Private Sub GroupItem_MouseEnter(sender As Object, e As EventArgs) _
            Handles MyBase.MouseEnter, txtTitle.MouseEnter, TableLayoutPanel1.MouseEnter, PictureBox1.MouseEnter
            If (Not Selected) Then
                txtTitle.ForeColor = Color.DodgerBlue
                BorderColor = Colors.ActiveColor
            End If
        End Sub

        Private Sub GroupItem_MouseLeave(sender As Object, e As EventArgs) _
            Handles MyBase.MouseLeave, txtTitle.MouseLeave, TableLayoutPanel1.MouseLeave, PictureBox1.MouseLeave
            If (Not Selected) Then
                txtTitle.ForeColor = Color.Silver
                BorderColor = Color.FromArgb(29, 38, 60)
            End If
        End Sub

        Private Sub GroupItem_Click(sender As Object, e As EventArgs) _
            Handles MyBase.Click, txtTitle.Click, TableLayoutPanel1.Click, PictureBox1.Click
            RaiseEvent BeforeSelectedChanged(Me, New EventArgs())
            Selected = Not Selected
            RaiseEvent SelectedChanged(Me, New TodoListEventArgs(Me.TodoList, Selected))
        End Sub
        
    End Class
End NameSpace