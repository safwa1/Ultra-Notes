Imports Ultra_Notes.App.Models
Imports Ultra_Notes.App.Types
Imports Ultra_Notes.App.Utils

Namespace Views.Components
    Public Class GroupItem
        
        Public Event BeforeSelectedChanged As EventHandler
        Public Event SelectedChanged As EventHandler(Of GroupEventArgs)
        
        Private _selected As Boolean
        Private _group As Group

        Public Property Group As Group
            Get
                Return _group
            End Get
            Set
                _group = value
                Text = value.Name
            End Set
        End Property

        Public Property Selected As Boolean
            Get
                Return _selected
            End Get
            Set
                _selected = value
                BorderColor = IIf(_selected, Colors.ActiveColor,Color.FromArgb(29, 38, 60))
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

        Public Sub New(g As Group)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.Group = g
            Me.Text = g.Name
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
            RaiseEvent SelectedChanged(Me, New GroupEventArgs(Group, Selected))
        End Sub
        
    End Class
End NameSpace