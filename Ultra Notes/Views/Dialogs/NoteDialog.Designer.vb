Namespace Views.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NoteDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteDialog))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.OkButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.txtNoteTitle = New SafwanUiKit.Controls.STextBox()
            Me.CancelActionButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.txtError = New System.Windows.Forms.Label()
            Me.txtNoteBody = New SafwanUiKit.Controls.STextBox()
            Me.Label1 = New System.Windows.Forms.Label()
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
            Me.toolbarPanel.Size = New System.Drawing.Size(358, 46)
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
            Me.txtTitle.Location = New System.Drawing.Point(219, 12)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Size = New System.Drawing.Size(131, 20)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "العنوان"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
            Me.Label2.ForeColor = System.Drawing.Color.DarkGray
            Me.Label2.Location = New System.Drawing.Point(244, 66)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(101, 19)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "عنوان الملاحضة"
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
            Me.OkButton.Location = New System.Drawing.Point(23, 452)
            Me.OkButton.Name = "OkButton"
            Me.OkButton.Size = New System.Drawing.Size(85, 37)
            Me.OkButton.TabIndex = 3
            Me.OkButton.Text = "موافق"
            Me.OkButton.TextColor = System.Drawing.Color.White
            Me.OkButton.UseVisualStyleBackColor = False
            '
            'txtNoteTitle
            '
            Me.txtNoteTitle.AcceptNumbersOnly = False
            Me.txtNoteTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtNoteTitle.BorderColor = System.Drawing.Color.Black
            Me.txtNoteTitle.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.txtNoteTitle.BorderRadius = 4
            Me.txtNoteTitle.BorderSize = 1
            Me.txtNoteTitle.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtNoteTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtNoteTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtNoteTitle.LabelControl = Nothing
            Me.txtNoteTitle.Location = New System.Drawing.Point(11, 90)
            Me.txtNoteTitle.Margin = New System.Windows.Forms.Padding(4)
            Me.txtNoteTitle.Multiline = False
            Me.txtNoteTitle.Name = "txtNoteTitle"
            Me.txtNoteTitle.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtNoteTitle.PasswordChar = False
            Me.txtNoteTitle.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtNoteTitle.PlaceholderText = "العنوان"
            Me.txtNoteTitle.ReadOnly = False
            Me.txtNoteTitle.ShowLabelOnFocus = False
            Me.txtNoteTitle.Size = New System.Drawing.Size(334, 35)
            Me.txtNoteTitle.TabIndex = 1
            Me.txtNoteTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtNoteTitle.UnderlinedStyle = False
            Me.txtNoteTitle.Value = ""
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
            Me.CancelActionButton.Location = New System.Drawing.Point(114, 452)
            Me.CancelActionButton.Name = "CancelActionButton"
            Me.CancelActionButton.Size = New System.Drawing.Size(85, 37)
            Me.CancelActionButton.TabIndex = 4
            Me.CancelActionButton.Text = "إلغاء"
            Me.CancelActionButton.TextColor = System.Drawing.Color.White
            Me.CancelActionButton.UseVisualStyleBackColor = False
            '
            'txtError
            '
            Me.txtError.AutoEllipsis = True
            Me.txtError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtError.ForeColor = System.Drawing.Color.Crimson
            Me.txtError.Location = New System.Drawing.Point(36, 413)
            Me.txtError.Name = "txtError"
            Me.txtError.Size = New System.Drawing.Size(308, 18)
            Me.txtError.TabIndex = 9
            '
            'txtNoteBody
            '
            Me.txtNoteBody.AcceptNumbersOnly = False
            Me.txtNoteBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtNoteBody.BorderColor = System.Drawing.Color.Black
            Me.txtNoteBody.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.txtNoteBody.BorderRadius = 4
            Me.txtNoteBody.BorderSize = 1
            Me.txtNoteBody.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtNoteBody.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtNoteBody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtNoteBody.LabelControl = Nothing
            Me.txtNoteBody.Location = New System.Drawing.Point(11, 164)
            Me.txtNoteBody.Margin = New System.Windows.Forms.Padding(4)
            Me.txtNoteBody.Multiline = True
            Me.txtNoteBody.Name = "txtNoteBody"
            Me.txtNoteBody.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtNoteBody.PasswordChar = False
            Me.txtNoteBody.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtNoteBody.PlaceholderText = "اكتب النص هنا"
            Me.txtNoteBody.ReadOnly = False
            Me.txtNoteBody.ShowLabelOnFocus = False
            Me.txtNoteBody.Size = New System.Drawing.Size(334, 245)
            Me.txtNoteBody.TabIndex = 2
            Me.txtNoteBody.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtNoteBody.UnderlinedStyle = False
            Me.txtNoteBody.Value = ""
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
            Me.Label1.ForeColor = System.Drawing.Color.DarkGray
            Me.Label1.Location = New System.Drawing.Point(253, 140)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(92, 19)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "نص الملاحضة"
            '
            'NoteDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(358, 516)
            Me.Controls.Add(Me.txtError)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.CancelActionButton)
            Me.Controls.Add(Me.OkButton)
            Me.Controls.Add(Me.txtNoteBody)
            Me.Controls.Add(Me.txtNoteTitle)
            Me.Controls.Add(Me.toolbarPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "NoteDialog"
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
        Friend WithEvents txtNoteTitle As SafwanUiKit.Controls.STextBox
        Friend WithEvents CancelActionButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtError As Label
        Friend WithEvents txtNoteBody As SafwanUiKit.Controls.STextBox
        Friend WithEvents Label1 As Label
    End Class
End NameSpace