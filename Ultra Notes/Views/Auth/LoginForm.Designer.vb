Namespace Views.Auth
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial NotInheritable Class LoginForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtUsername = New SafwanUiKit.Controls.STextBox()
            Me.txtPassword = New SafwanUiKit.Controls.STextBox()
            Me.LoginButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.registerButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.txtError = New System.Windows.Forms.Label()
            Me.toolbarPanel.SuspendLayout()
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'toolbarPanel
            '
            Me.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.toolbarPanel.Controls.Add(Me.closeButton)
            Me.toolbarPanel.Controls.Add(Me.Label3)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.toolbarPanel.Location = New System.Drawing.Point(0, 0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.toolbarPanel.Size = New System.Drawing.Size(349, 46)
            Me.toolbarPanel.TabIndex = 0
            '
            'closeButton
            '
            Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.closeButton.Image = CType(resources.GetObject("closeButton.Image"), System.Drawing.Image)
            Me.closeButton.Location = New System.Drawing.Point(9, 10)
            Me.closeButton.Name = "closeButton"
            Me.closeButton.Size = New System.Drawing.Size(24, 24)
            Me.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.closeButton.TabIndex = 7
            Me.closeButton.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(246, 10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 19)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "تسجيل الدخول"
            '
            'txtUsername
            '
            Me.txtUsername.AcceptNumbersOnly = False
            Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.txtUsername.BorderRadius = 4
            Me.txtUsername.BorderSize = 1
            Me.txtUsername.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtUsername.LabelControl = Nothing
            Me.txtUsername.Location = New System.Drawing.Point(15, 233)
            Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
            Me.txtUsername.Multiline = False
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtUsername.PasswordChar = False
            Me.txtUsername.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtUsername.PlaceholderText = "إسم المستخدم"
            Me.txtUsername.ReadOnly = False
            Me.txtUsername.ShowLabelOnFocus = False
            Me.txtUsername.Size = New System.Drawing.Size(316, 34)
            Me.txtUsername.TabIndex = 1
            Me.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtUsername.UnderlinedStyle = False
            Me.txtUsername.Value = ""
            '
            'txtPassword
            '
            Me.txtPassword.AcceptNumbersOnly = False
            Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.txtPassword.BorderRadius = 4
            Me.txtPassword.BorderSize = 1
            Me.txtPassword.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtPassword.LabelControl = Nothing
            Me.txtPassword.Location = New System.Drawing.Point(17, 303)
            Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
            Me.txtPassword.Multiline = False
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtPassword.PasswordChar = True
            Me.txtPassword.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtPassword.PlaceholderText = "كلمة المرور"
            Me.txtPassword.ReadOnly = False
            Me.txtPassword.ShowLabelOnFocus = False
            Me.txtPassword.Size = New System.Drawing.Size(316, 34)
            Me.txtPassword.TabIndex = 2
            Me.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtPassword.UnderlinedStyle = False
            Me.txtPassword.Value = ""
            '
            'LoginButton
            '
            Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.LoginButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.LoginButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.LoginButton.BorderRadius = 4
            Me.LoginButton.BorderSize = 2
            Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.LoginButton.FlatAppearance.BorderSize = 0
            Me.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.LoginButton.ForeColor = System.Drawing.Color.White
            Me.LoginButton.Location = New System.Drawing.Point(17, 368)
            Me.LoginButton.Name = "LoginButton"
            Me.LoginButton.Size = New System.Drawing.Size(316, 39)
            Me.LoginButton.TabIndex = 3
            Me.LoginButton.Text = "تسجـــــــيل الدخـــــــــــــــــول"
            Me.LoginButton.TextColor = System.Drawing.Color.White
            Me.LoginButton.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(12, 281)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 15)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "كلمة المرور"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(12, 211)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(78, 15)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "إسم المستخدم"
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(120, 85)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(109, 99)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 6
            Me.PictureBox1.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.Panel1.Location = New System.Drawing.Point(74, 428)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(200, 2)
            Me.Panel1.TabIndex = 90
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(156, 416)
            Me.Label4.Name = "Label4"
            Me.Label4.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.Label4.Size = New System.Drawing.Size(40, 19)
            Me.Label4.TabIndex = 91
            Me.Label4.Text = "أو"
            '
            'registerButton
            '
            Me.registerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.registerButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.registerButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.registerButton.BorderRadius = 4
            Me.registerButton.BorderSize = 2
            Me.registerButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.registerButton.FlatAppearance.BorderSize = 0
            Me.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.registerButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.registerButton.ForeColor = System.Drawing.Color.White
            Me.registerButton.Location = New System.Drawing.Point(15, 450)
            Me.registerButton.Name = "registerButton"
            Me.registerButton.Size = New System.Drawing.Size(316, 38)
            Me.registerButton.TabIndex = 92
            Me.registerButton.Text = "إنشاء حساب جديد"
            Me.registerButton.TextColor = System.Drawing.Color.White
            Me.registerButton.UseVisualStyleBackColor = False
            '
            'txtError
            '
            Me.txtError.AutoEllipsis = True
            Me.txtError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtError.ForeColor = System.Drawing.Color.Crimson
            Me.txtError.Location = New System.Drawing.Point(15, 341)
            Me.txtError.Name = "txtError"
            Me.txtError.Size = New System.Drawing.Size(316, 18)
            Me.txtError.TabIndex = 93
            '
            'LoginForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(349, 518)
            Me.Controls.Add(Me.txtError)
            Me.Controls.Add(Me.registerButton)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LoginButton)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.toolbarPanel)
            Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "LoginForm"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.RightToLeftLayout = True
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "LoginForm"
            Me.toolbarPanel.ResumeLayout(False)
            Me.toolbarPanel.PerformLayout()
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents txtUsername As SafwanUiKit.Controls.STextBox
        Friend WithEvents txtPassword As SafwanUiKit.Controls.STextBox
        Friend WithEvents LoginButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents closeButton As PictureBox
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label4 As Label
        Friend WithEvents registerButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtError As Label
    End Class
End NameSpace