Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TodoViewer
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoViewer))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.txtTodo = New System.Windows.Forms.Label()
            Me.RoundedPanel1 = New SafwanUiKit.Controls.RoundedPanel()
            Me.RoundedPanel2 = New SafwanUiKit.Controls.RoundedPanel()
            Me.txtStatus = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.RoundedPanel3 = New SafwanUiKit.Controls.RoundedPanel()
            Me.txtCreatedAt = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.RoundedPanel4 = New SafwanUiKit.Controls.RoundedPanel()
            Me.txtUpdatedAt = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.toolbarPanel.SuspendLayout()
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RoundedPanel1.SuspendLayout()
            Me.RoundedPanel2.SuspendLayout()
            Me.RoundedPanel3.SuspendLayout()
            Me.RoundedPanel4.SuspendLayout()
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
            Me.toolbarPanel.Size = New System.Drawing.Size(388, 41)
            Me.toolbarPanel.TabIndex = 2
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
            Me.txtTitle.Location = New System.Drawing.Point(-232, 9)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Size = New System.Drawing.Size(612, 20)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "معاينة"
            '
            'txtTodo
            '
            Me.txtTodo.AutoEllipsis = True
            Me.txtTodo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtTodo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtTodo.ForeColor = System.Drawing.Color.White
            Me.txtTodo.Location = New System.Drawing.Point(6, 6)
            Me.txtTodo.Name = "txtTodo"
            Me.txtTodo.Padding = New System.Windows.Forms.Padding(8)
            Me.txtTodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtTodo.Size = New System.Drawing.Size(335, 125)
            Me.txtTodo.TabIndex = 10
            Me.txtTodo.Text = "النص"
            '
            'RoundedPanel1
            '
            Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel1.BorderRadius = 6
            Me.RoundedPanel1.BorderSize = 0
            Me.RoundedPanel1.BottomLeftRadius = True
            Me.RoundedPanel1.BottomRightRadius = True
            Me.RoundedPanel1.Controls.Add(Me.txtTodo)
            Me.RoundedPanel1.ForeColor = System.Drawing.Color.Black
            Me.RoundedPanel1.Location = New System.Drawing.Point(21, 69)
            Me.RoundedPanel1.Name = "RoundedPanel1"
            Me.RoundedPanel1.Padding = New System.Windows.Forms.Padding(6)
            Me.RoundedPanel1.Size = New System.Drawing.Size(347, 137)
            Me.RoundedPanel1.TabIndex = 11
            Me.RoundedPanel1.TopLeftRadius = True
            Me.RoundedPanel1.TopRightRadius = True
            '
            'RoundedPanel2
            '
            Me.RoundedPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel2.BorderRadius = 6
            Me.RoundedPanel2.BorderSize = 0
            Me.RoundedPanel2.BottomLeftRadius = True
            Me.RoundedPanel2.BottomRightRadius = True
            Me.RoundedPanel2.Controls.Add(Me.txtStatus)
            Me.RoundedPanel2.Controls.Add(Me.Label2)
            Me.RoundedPanel2.ForeColor = System.Drawing.Color.Black
            Me.RoundedPanel2.Location = New System.Drawing.Point(21, 211)
            Me.RoundedPanel2.Name = "RoundedPanel2"
            Me.RoundedPanel2.Size = New System.Drawing.Size(347, 33)
            Me.RoundedPanel2.TabIndex = 12
            Me.RoundedPanel2.TopLeftRadius = True
            Me.RoundedPanel2.TopRightRadius = True
            '
            'txtStatus
            '
            Me.txtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtStatus.ForeColor = System.Drawing.Color.Gray
            Me.txtStatus.Location = New System.Drawing.Point(9, 8)
            Me.txtStatus.Name = "txtStatus"
            Me.txtStatus.Size = New System.Drawing.Size(146, 15)
            Me.txtStatus.TabIndex = 7
            Me.txtStatus.Text = "Status"
            Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(302, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 15)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "الحالة"
            '
            'RoundedPanel3
            '
            Me.RoundedPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel3.BorderRadius = 6
            Me.RoundedPanel3.BorderSize = 0
            Me.RoundedPanel3.BottomLeftRadius = True
            Me.RoundedPanel3.BottomRightRadius = True
            Me.RoundedPanel3.Controls.Add(Me.txtCreatedAt)
            Me.RoundedPanel3.Controls.Add(Me.Label1)
            Me.RoundedPanel3.ForeColor = System.Drawing.Color.Black
            Me.RoundedPanel3.Location = New System.Drawing.Point(21, 249)
            Me.RoundedPanel3.Name = "RoundedPanel3"
            Me.RoundedPanel3.Size = New System.Drawing.Size(347, 33)
            Me.RoundedPanel3.TabIndex = 12
            Me.RoundedPanel3.TopLeftRadius = True
            Me.RoundedPanel3.TopRightRadius = True
            '
            'txtCreatedAt
            '
            Me.txtCreatedAt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCreatedAt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtCreatedAt.ForeColor = System.Drawing.Color.Gray
            Me.txtCreatedAt.Location = New System.Drawing.Point(9, 8)
            Me.txtCreatedAt.Name = "txtCreatedAt"
            Me.txtCreatedAt.Size = New System.Drawing.Size(146, 15)
            Me.txtCreatedAt.TabIndex = 7
            Me.txtCreatedAt.Text = "CreatedAt"
            Me.txtCreatedAt.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(271, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 15)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "تاريخ الإنشاء"
            '
            'RoundedPanel4
            '
            Me.RoundedPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.RoundedPanel4.BorderRadius = 6
            Me.RoundedPanel4.BorderSize = 0
            Me.RoundedPanel4.BottomLeftRadius = True
            Me.RoundedPanel4.BottomRightRadius = True
            Me.RoundedPanel4.Controls.Add(Me.txtUpdatedAt)
            Me.RoundedPanel4.Controls.Add(Me.Label3)
            Me.RoundedPanel4.ForeColor = System.Drawing.Color.Black
            Me.RoundedPanel4.Location = New System.Drawing.Point(21, 287)
            Me.RoundedPanel4.Name = "RoundedPanel4"
            Me.RoundedPanel4.Size = New System.Drawing.Size(347, 33)
            Me.RoundedPanel4.TabIndex = 12
            Me.RoundedPanel4.TopLeftRadius = True
            Me.RoundedPanel4.TopRightRadius = True
            '
            'txtUpdatedAt
            '
            Me.txtUpdatedAt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUpdatedAt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtUpdatedAt.ForeColor = System.Drawing.Color.Gray
            Me.txtUpdatedAt.Location = New System.Drawing.Point(9, 8)
            Me.txtUpdatedAt.Name = "txtUpdatedAt"
            Me.txtUpdatedAt.Size = New System.Drawing.Size(146, 15)
            Me.txtUpdatedAt.TabIndex = 7
            Me.txtUpdatedAt.Text = "UpdatedAt"
            Me.txtUpdatedAt.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(256, 8)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 15)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "تاريخ آخر تعديل"
            '
            'TodoViewer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(388, 352)
            Me.Controls.Add(Me.RoundedPanel4)
            Me.Controls.Add(Me.RoundedPanel3)
            Me.Controls.Add(Me.RoundedPanel2)
            Me.Controls.Add(Me.RoundedPanel1)
            Me.Controls.Add(Me.toolbarPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "TodoViewer"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "NoteViewer"
            Me.toolbarPanel.ResumeLayout(False)
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RoundedPanel1.ResumeLayout(False)
            Me.RoundedPanel2.ResumeLayout(False)
            Me.RoundedPanel2.PerformLayout()
            Me.RoundedPanel3.ResumeLayout(False)
            Me.RoundedPanel3.PerformLayout()
            Me.RoundedPanel4.ResumeLayout(False)
            Me.RoundedPanel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents closeButton As PictureBox
        Friend WithEvents txtTitle As Label
        Friend WithEvents txtTodo As Label
        Friend WithEvents RoundedPanel1 As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents RoundedPanel2 As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents txtStatus As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents RoundedPanel3 As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents txtCreatedAt As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents RoundedPanel4 As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents txtUpdatedAt As Label
        Friend WithEvents Label3 As Label
    End Class
End NameSpace