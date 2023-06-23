Namespace Views.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TodoListDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupDialog))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.OkButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.txtName = New SafwanUiKit.Controls.STextBox()
            Me.CancelActionButton = New SafwanUiKit.Controls.PrimaryButton()
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
            Me.toolbarPanel.Size = New System.Drawing.Size(305, 46)
            Me.toolbarPanel.TabIndex = 1
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
            'txtTitle
            '
            Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTitle.AutoEllipsis = True
            Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
            Me.txtTitle.ForeColor = System.Drawing.Color.LightSlateGray
            Me.txtTitle.Location = New System.Drawing.Point(166, 12)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Size = New System.Drawing.Size(131, 20)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "العنوان"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.DarkGray
            Me.Label2.Location = New System.Drawing.Point(226, 73)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 15)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "إسم القائمة"
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
            Me.OkButton.Location = New System.Drawing.Point(13, 156)
            Me.OkButton.Name = "OkButton"
            Me.OkButton.Size = New System.Drawing.Size(280, 37)
            Me.OkButton.TabIndex = 7
            Me.OkButton.Text = "موافق"
            Me.OkButton.TextColor = System.Drawing.Color.White
            Me.OkButton.UseVisualStyleBackColor = False
            '
            'txtName
            '
            Me.txtName.AcceptNumbersOnly = False
            Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtName.BorderColor = System.Drawing.Color.Black
            Me.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.txtName.BorderRadius = 4
            Me.txtName.BorderSize = 1
            Me.txtName.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtName.LabelControl = Nothing
            Me.txtName.Location = New System.Drawing.Point(11, 94)
            Me.txtName.Margin = New System.Windows.Forms.Padding(4)
            Me.txtName.Multiline = False
            Me.txtName.Name = "txtName"
            Me.txtName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtName.PasswordChar = False
            Me.txtName.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtName.PlaceholderText = "إسم القائمة"
            Me.txtName.ReadOnly = False
            Me.txtName.ShowLabelOnFocus = False
            Me.txtName.Size = New System.Drawing.Size(280, 34)
            Me.txtName.TabIndex = 6
            Me.txtName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtName.UnderlinedStyle = False
            Me.txtName.Value = ""
            '
            'CancelActionButton
            '
            Me.CancelActionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.CancelActionButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.CancelActionButton.BorderColor = System.Drawing.Color.Black
            Me.CancelActionButton.BorderRadius = 4
            Me.CancelActionButton.BorderSize = 1
            Me.CancelActionButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CancelActionButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.CancelActionButton.FlatAppearance.BorderSize = 0
            Me.CancelActionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.CancelActionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.CancelActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CancelActionButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.CancelActionButton.ForeColor = System.Drawing.Color.White
            Me.CancelActionButton.Location = New System.Drawing.Point(13, 199)
            Me.CancelActionButton.Name = "CancelActionButton"
            Me.CancelActionButton.Size = New System.Drawing.Size(280, 37)
            Me.CancelActionButton.TabIndex = 7
            Me.CancelActionButton.Text = "إلغاء"
            Me.CancelActionButton.TextColor = System.Drawing.Color.White
            Me.CancelActionButton.UseVisualStyleBackColor = False
            '
            'txtError
            '
            Me.txtError.AutoEllipsis = True
            Me.txtError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtError.ForeColor = System.Drawing.Color.Crimson
            Me.txtError.Location = New System.Drawing.Point(13, 132)
            Me.txtError.Name = "txtError"
            Me.txtError.Size = New System.Drawing.Size(280, 18)
            Me.txtError.TabIndex = 9
            '
            'GroupDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(305, 259)
            Me.Controls.Add(Me.txtError)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.CancelActionButton)
            Me.Controls.Add(Me.OkButton)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.toolbarPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "GroupDialog"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GroupDialog"
            Me.toolbarPanel.ResumeLayout(False)
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents closeButton As PictureBox
        Friend WithEvents txtTitle As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents OkButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtName As SafwanUiKit.Controls.STextBox
        Friend WithEvents CancelActionButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtError As Label
    End Class
End NameSpace