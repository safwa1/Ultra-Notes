Namespace Views.Components
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NoteItem
        Inherits SafwanUiKit.Controls.SUserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteItem))
            Me.RightPanelHeader = New System.Windows.Forms.Panel()
            Me.deleteButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.editButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.viewButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.txtDate = New System.Windows.Forms.Label()
            Me.txtBody = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.RightPanelHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'RightPanelHeader
            '
            Me.RightPanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.RightPanelHeader.Controls.Add(Me.deleteButton)
            Me.RightPanelHeader.Controls.Add(Me.editButton)
            Me.RightPanelHeader.Controls.Add(Me.viewButton)
            Me.RightPanelHeader.Controls.Add(Me.txtTitle)
            Me.RightPanelHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.RightPanelHeader.Location = New System.Drawing.Point(3, 3)
            Me.RightPanelHeader.Name = "RightPanelHeader"
            Me.RightPanelHeader.Size = New System.Drawing.Size(763, 41)
            Me.RightPanelHeader.TabIndex = 3
            '
            'deleteButton
            '
            Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.BorderRadius = 6
            Me.deleteButton.BorderSize = 2
            Me.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteButton.FlatAppearance.BorderSize = 0
            Me.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.deleteButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.deleteButton.ForeColor = System.Drawing.Color.White
            Me.deleteButton.Image = CType(resources.GetObject("deleteButton.Image"), System.Drawing.Image)
            Me.deleteButton.Location = New System.Drawing.Point(4, 3)
            Me.deleteButton.Name = "deleteButton"
            Me.deleteButton.Size = New System.Drawing.Size(33, 33)
            Me.deleteButton.TabIndex = 4
            Me.deleteButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.deleteButton, "حذف")
            Me.deleteButton.UseVisualStyleBackColor = False
            '
            'editButton
            '
            Me.editButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.BorderRadius = 6
            Me.editButton.BorderSize = 2
            Me.editButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editButton.FlatAppearance.BorderSize = 0
            Me.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.editButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.editButton.ForeColor = System.Drawing.Color.White
            Me.editButton.Image = CType(resources.GetObject("editButton.Image"), System.Drawing.Image)
            Me.editButton.Location = New System.Drawing.Point(39, 3)
            Me.editButton.Name = "editButton"
            Me.editButton.Size = New System.Drawing.Size(33, 33)
            Me.editButton.TabIndex = 4
            Me.editButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.editButton, "تعديل")
            Me.editButton.UseVisualStyleBackColor = False
            '
            'viewButton
            '
            Me.viewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.BorderRadius = 6
            Me.viewButton.BorderSize = 2
            Me.viewButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.viewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.viewButton.FlatAppearance.BorderSize = 0
            Me.viewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.viewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.viewButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.viewButton.ForeColor = System.Drawing.Color.White
            Me.viewButton.Image = CType(resources.GetObject("viewButton.Image"), System.Drawing.Image)
            Me.viewButton.Location = New System.Drawing.Point(74, 3)
            Me.viewButton.Name = "viewButton"
            Me.viewButton.Size = New System.Drawing.Size(33, 33)
            Me.viewButton.TabIndex = 4
            Me.viewButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.viewButton, "عرض")
            Me.viewButton.UseVisualStyleBackColor = False
            '
            'txtTitle
            '
            Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTitle.AutoEllipsis = True
            Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtTitle.ForeColor = System.Drawing.Color.White
            Me.txtTitle.Location = New System.Drawing.Point(148, 11)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtTitle.Size = New System.Drawing.Size(603, 15)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "العنوان"
            '
            'txtDate
            '
            Me.txtDate.AutoEllipsis = True
            Me.txtDate.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.txtDate.ForeColor = System.Drawing.Color.DimGray
            Me.txtDate.Location = New System.Drawing.Point(3, 96)
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Padding = New System.Windows.Forms.Padding(3)
            Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtDate.Size = New System.Drawing.Size(763, 21)
            Me.txtDate.TabIndex = 7
            Me.txtDate.Text = "{{DateTime}}"
            Me.txtDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBody
            '
            Me.txtBody.AutoEllipsis = True
            Me.txtBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtBody.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtBody.ForeColor = System.Drawing.Color.Gray
            Me.txtBody.Location = New System.Drawing.Point(3, 44)
            Me.txtBody.Name = "txtBody"
            Me.txtBody.Padding = New System.Windows.Forms.Padding(16, 16, 20, 10)
            Me.txtBody.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtBody.Size = New System.Drawing.Size(763, 52)
            Me.txtBody.TabIndex = 8
            Me.txtBody.Text = "النص"
            '
            'NoteItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.BorderRadius = 6
            Me.BorderSize = 1
            Me.Controls.Add(Me.txtBody)
            Me.Controls.Add(Me.txtDate)
            Me.Controls.Add(Me.RightPanelHeader)
            Me.Name = "NoteItem"
            Me.Padding = New System.Windows.Forms.Padding(3)
            Me.Size = New System.Drawing.Size(769, 120)
            Me.RightPanelHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RightPanelHeader As Panel
        Friend WithEvents deleteButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents editButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents viewButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtTitle As Label
        Friend WithEvents txtDate As Label
        Friend WithEvents txtBody As Label
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End NameSpace