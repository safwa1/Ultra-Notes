Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Controllers
Imports Ultra_Notes.App.Extensions
Imports Ultra_Notes.App.Models

Namespace Views.Auth

    Public Class RegisterForm

        Public Property CreatedUser As User

        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow
            Me.Draggable
            toolbarPanel.Draggable
            toolbarPanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, bottom:=1)
        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub

        Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click

            Dim uname As String = txtName.Value
            Dim username As String = txtUsername.Value
            Dim password As String = txtPassword.Value

            If (uname.IsBlank()) Then
                txtError.Text = "الإسم مفقود"
                txtName.Focus()
                Return
            End If

            If (username.IsBlank()) Then
                txtError.Text = "إسم المستخدم مفقود"
                txtUsername.Focus()
                Return
            End If

            If (password.IsBlank()) Then
                txtError.Text = "كلمة المرور مفقودة"
                txtPassword.Focus()
                Return
            End If

            Dim user As New User With {.Name = uname, .Username = username, .Password = password}

            Dim registered = AuthController.Instance.Register(user)

            If (registered) Then
                Me.CreatedUser = user
                MsgBox("تم إنشاء الحساب بنجاح")
                Me.DialogResult = DialogResult.OK
                registerButton.DialogResult = DialogResult.OK
            End If

        End Sub

    End Class
End Namespace