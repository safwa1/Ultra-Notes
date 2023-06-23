Imports SafwanUiKit.Extensions
Imports Ultra_Notes.App.Controllers
Imports Ultra_Notes.App.Extensions

Namespace Views.Auth
    Public NotInheritable Class LoginForm
        
        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow
            Me.Draggable
            toolbarPanel.Draggable
            toolbarPanel.UseCustomBorder(ColorTranslator.FromHtml("#1d263c"), width:=0, bottom:=1)
            
        End Sub

        Private Shared Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Environment.Exit(0)
        End Sub

        Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
            Dim username As String = txtUsername.Value
            Dim password As String = txtPassword.Value

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

            Dim loggedIn = AuthController.Instance.Login(username, password)

            If (loggedIn) Then
                Me.Hide()
                Dim main = New MainForm
                main.ShowDialog()
            Else
                txtError.Text = "إسم المستخدم أو كلمة المرور خطأ!"
                txtPassword.Clear()
                txtUsername.Focus()
                txtUsername.SelectAll()
            End If
        End Sub

        Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
            Using registerForm As New RegisterForm()
                If (registerForm.ShowDialog() = DialogResult.OK) Then
                    txtUsername.Value = registerForm.CreatedUser.Username
                    txtPassword.Value = registerForm.CreatedUser.Password
                End If
            End Using
        End Sub

        Private Sub txtUsername_ValueChanged(sender As Object, e As EventArgs) Handles txtUsername.ValueChanged
            If (txtUsername.Value.Length > 1) Then
                txtError.Text = String.Empty
            End If
        End Sub

        Private Sub txtPassword_ValueChanged(sender As Object, e As EventArgs) Handles txtPassword.ValueChanged
            If (txtPassword.Value.Length > 1) Then
                txtError.Text = String.Empty
            End If
        End Sub

    End Class
End Namespace