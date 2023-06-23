Namespace Views.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TodoDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoDialog))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.OkButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.txtTodo = New SafwanUiKit.Controls.STextBox()
            Me.txtError = New System.Windows.Forms.Label()
            Me.toolbarPanel.SuspendLayout()
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'toolbarPanel
            '
            Me.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.toolbarPanel.Controls.Add(Me.closeButton)
            Me.toolbarPanel.Controls.Add(Me.txtTitle)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.toolbarPanel.Location = New System.Drawing.Point(0, 0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.toolbarPanel.Size = New System.Drawing.Size(305, 40)
            Me.toolbarPanel.TabIndex = 1
            '
            'closeButton
            '
            Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.closeButton.Image = CType(resources.GetObject("closeButton.Image"), System.Drawing.Image)
            Me.closeButton.Location = New System.Drawing.Point(9, 7)
            Me.closeButton.Name = "closeButton"
            Me.closeButton.Size = New System.Drawing.Size(24, 24)
            Me.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.closeButton.TabIndex = 7
            Me.closeButton.TabStop = False
            '
            'txtTitle
            '
            Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTitle.AutoEllipsis = True
            Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
            Me.txtTitle.ForeColor = System.Drawing.Color.LightSlateGray
            Me.txtTitle.Location = New System.Drawing.Point(166, 8)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Size = New System.Drawing.Size(131, 20)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "تعديل المهمة"
            '
            'OkButton
            '
            Me.OkButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.OkButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.OkButton.BorderColor = System.Drawing.Color.Black
            Me.OkButton.BorderRadius = 4
            Me.OkButton.BorderSize = 1
            Me.OkButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.OkButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.OkButton.FlatAppearance.BorderSize = 0
            Me.OkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.OkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.OkButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.OkButton.ForeColor = System.Drawing.Color.White
            Me.OkButton.Location = New System.Drawing.Point(9, 175)
            Me.OkButton.Name = "OkButton"
            Me.OkButton.Size = New System.Drawing.Size(286, 37)
            Me.OkButton.TabIndex = 7
            Me.OkButton.Text = "موافق"
            Me.OkButton.TextColor = System.Drawing.Color.White
            Me.OkButton.UseVisualStyleBackColor = False
            '
            'txtTodo
            '
            Me.txtTodo.AcceptNumbersOnly = False
            Me.txtTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtTodo.BorderColor = System.Drawing.Color.Black
            Me.txtTodo.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.txtTodo.BorderRadius = 4
            Me.txtTodo.BorderSize = 1
            Me.txtTodo.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtTodo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtTodo.LabelControl = Nothing
            Me.txtTodo.Location = New System.Drawing.Point(9, 55)
            Me.txtTodo.Margin = New System.Windows.Forms.Padding(4)
            Me.txtTodo.Multiline = True
            Me.txtTodo.Name = "txtTodo"
            Me.txtTodo.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtTodo.PasswordChar = False
            Me.txtTodo.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtTodo.PlaceholderText = "نص المهمة"
            Me.txtTodo.ReadOnly = False
            Me.txtTodo.ShowLabelOnFocus = False
            Me.txtTodo.Size = New System.Drawing.Size(286, 88)
            Me.txtTodo.TabIndex = 6
            Me.txtTodo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtTodo.UnderlinedStyle = False
            Me.txtTodo.Value = ""
            '
            'txtError
            '
            Me.txtError.AutoEllipsis = True
            Me.txtError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtError.ForeColor = System.Drawing.Color.Crimson
            Me.txtError.Location = New System.Drawing.Point(9, 147)
            Me.txtError.Name = "txtError"
            Me.txtError.Size = New System.Drawing.Size(286, 18)
            Me.txtError.TabIndex = 9
            '
            'TodoDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(305, 228)
            Me.Controls.Add(Me.txtError)
            Me.Controls.Add(Me.OkButton)
            Me.Controls.Add(Me.txtTodo)
            Me.Controls.Add(Me.toolbarPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "TodoDialog"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GroupDialog"
            Me.toolbarPanel.ResumeLayout(False)
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents closeButton As PictureBox
        Friend WithEvents txtTitle As Label
        Friend WithEvents OkButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtTodo As SafwanUiKit.Controls.STextBox
        Friend WithEvents txtError As Label
    End Class
End NameSpace