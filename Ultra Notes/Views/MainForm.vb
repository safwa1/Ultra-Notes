Imports SafwanUiKit.Controls
Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Controllers
Imports Ultra_Notes.App.Enums
Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.App.Utils
Imports Ultra_Notes.Views.Components
Imports Ultra_Notes.Views.Dialogs

Namespace Views
    Public Class MainForm
        
        Private _selectedGroup As Group
        Private _selectedGroupItem As GroupItem
        Private _groups As New List(Of Group)()
        Private ReadOnly _dark As Color = ColorTranslator.FromHtml("#1d263c")

        ' Users Controls
        Private Shared ReadOnly NotesUserControl As New NotesUserControl() With {.Dock = DockStyle.Fill}
        Private Shared ReadOnly TasksUserControl As New TasksUserControl() With {.Dock = DockStyle.Fill}

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow()
            Me.Draggable()
            toolbarPanel.Draggable()

            ' Custom Border 
            toolbarPanel.UseCustomBorder(_dark, width:=0, bottom:=1)
            RightPanelHeader.UseCustomBorder(_dark, width:=0, bottom:=1, left:=1)
            GroupSearchPanel.UseCustomBorder(_dark, width:=0, bottom:=1, left:=1)
            ContentAreaHeaderPanel.UseCustomBorder(Color.FromArgb(29, 38, 60), width:=0, bottom:=1)
            PanelDep.UseCustomBorder(Color.FromArgb(29, 38, 60), width:=0, left:=1)
            RightPanel.UseCustomBorder(_dark, width:=0, left:=1)
            RoundedPanelOfGroups.UseCustomBorder(_dark, width:=0, left:=1)
            footerPanel.UseCustomBorder(_dark, width:=0, top:=1)
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtUsername.Text = AuthController.CurrentUser.Username
            GetGroupsOfUser()
        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Environment.Exit(0)
        End Sub

#Region "-> Groups Buttons Events"
        Private Sub addGroupButton_Click(sender As Object, e As EventArgs) Handles addGroupButton.Click
            Using groupDialog As New GroupDialog()
                If (groupDialog.ShowDialog() = DialogResult.OK) Then
                    Dim g As Group = groupDialog.Group
                    CreateGroup(g)
                End If
            End Using
        End Sub

        Private Sub editGroupButton_Click(sender As Object, e As EventArgs) Handles editGroupButton.Click
            Using groupDialog As New GroupDialog(Modifier.Update, _selectedGroup)
                If (groupDialog.ShowDialog() = DialogResult.OK) Then
                    Dim g As Group = groupDialog.Group
                    UpdateGroup(g)
                End If
            End Using
        End Sub

        Private Sub deleteGroupButton_Click(sender As Object, e As EventArgs) Handles deleteGroupButton.Click
            If (Not IsNothing(_selectedGroup)) Then
                Dim yes As DialogResult = Sure()
                If (yes = DialogResult.OK) Then
                    Dim delete = GroupController.Instance.Delete(_selectedGroup)
                    If (delete) Then
                        ' TODO: remove it notes & todos
                        NoteController.Instance.DeleteNotesOf(_selectedGroup.Id)
                        TodosListController.Instance.DeleteTodosListsOf(_selectedGroup.Id)
                        ' TODO: need way to remove todos of TodoList
                        
                        ' Reset State
                        _selectedGroup = Nothing
                        _selectedGroupItem = Nothing
                        GetGroupsOfUser()
                    End If
                End If
            End If
        End Sub
#End Region

        Private Sub CreateGroup(g As Group)
            Dim inserted = GroupController.Instance.Insert(g)
            If (inserted > 0) Then
                GetGroupsOfUser()
            End If
        End Sub

        Private Sub UpdateGroup(g As Group)
            Dim updated = GroupController.Instance.Update(g)
            If (updated) Then
                _selectedGroupItem.Group = g
            End If
        End Sub

        Private Sub GetGroupsOfUser()
            _groups = GroupController.Instance.GetGroupsOf(AuthController.CurrentUser.Id)
            RoundedPanelOfGroups.Controls.Clear()
            Dim topSpace As Integer = 7
            For Each g As Group In _groups
                Dim item As New GroupItem(g) With {.Top = topSpace, .Left = 7}
                AddHandler item.BeforeSelectedChanged, AddressOf Me.BeforeGroupSelectedHandler
                AddHandler item.SelectedChanged, AddressOf Me.OnGroupItemChangeHandler
                RoundedPanelOfGroups.Controls.Add(item)
                topSpace += item.Height + 4
            Next
        End Sub

        Private Sub BeforeGroupSelectedHandler(sender As Object, e As EventArgs)
            For Each i As GroupItem In RoundedPanelOfGroups.Controls
                i.Selected = False
            Next
        End Sub

        Private Sub OnGroupItemChangeHandler(sender As Object, e As GroupEventArgs)
            ' TODO: unselect all items
            _selectedGroup = IIf(e.Selected, e.Group, Nothing)
            _selectedGroupItem = IIf(e.Selected, TryCast(sender, GroupItem), Nothing)
            If (e.Selected) Then
                txtPath.Text = "القوائم  /  " & _selectedGroup.Name
                InitializeChildrenView()
            End If
        End Sub

        Private Sub InitializeChildrenView()
            NotesUserControl.Clear()
            ContentRoundedPanel.Visible = True
            ContentRoundedPanel.Controls.Clear()
            ContentAreaHeaderPanel.Visible = True
            PanelDep.Visible = True
            SelectButton(TasksButton, False)
            SelectButton(NotesButton, False)
        End Sub

        Private Sub NotesButton_Click(sender As Object, e As EventArgs) Handles NotesButton.Click
            SelectButton(TasksButton, False)
            SelectButton(NotesButton, True)
            ShowNotesPage()
        End Sub

        Private Sub TasksButton_Click(sender As Object, e As EventArgs) Handles TasksButton.Click
            SelectButton(NotesButton, False)
            SelectButton(TasksButton, True)

            ContentRoundedPanel.Controls.Clear()
            TasksUserControl.LoadTodoListOf(_selectedGroup.Id)
            ContentRoundedPanel.Controls.Add(TasksUserControl)
        End Sub

        Private Shared Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
            Using about As New AboutDialog()
                about.ShowDialog()
            End Using
        End Sub
        
        Private Shared Sub SelectButton(button As PrimaryButton, state As Boolean)
            button.ForeColor = If(state, Color.DodgerBlue, Color.White)
            button.BorderColor = If(state, Colors.ActiveColor, Color.FromArgb(29, 38, 60))
        End Sub
        
        Private Sub ShowNotesPage()
            ContentRoundedPanel.Controls.Clear()
            NotesUserControl.LoadNotesOf(_selectedGroup.Id)
            ContentRoundedPanel.Controls.Add(NotesUserControl)
        End Sub
        
    End Class
End NameSpace