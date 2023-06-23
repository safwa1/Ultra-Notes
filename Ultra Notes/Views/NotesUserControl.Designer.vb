Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NotesUserControl
        Inherits System.Windows.Forms.UserControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotesUserControl))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.txtSearch = New SafwanUiKit.Controls.STextBox()
            Me.addButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.ContentPanel = New SafwanUiKit.Controls.RoundedPanel()
            Me.toolbarPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolbarPanel
            '
            Me.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.toolbarPanel.Controls.Add(Me.txtSearch)
            Me.toolbarPanel.Controls.Add(Me.addButton)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.toolbarPanel.Location = New System.Drawing.Point(0, 0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.toolbarPanel.Size = New System.Drawing.Size(788, 42)
            Me.toolbarPanel.TabIndex = 3
            '
            'txtSearch
            '
            Me.txtSearch.AcceptNumbersOnly = False
            Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(136, Byte), Integer))
            Me.txtSearch.BorderRadius = 4
            Me.txtSearch.BorderSize = 1
            Me.txtSearch.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtSearch.LabelControl = Nothing
            Me.txtSearch.Location = New System.Drawing.Point(4, 4)
            Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
            Me.txtSearch.Multiline = False
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtSearch.PasswordChar = False
            Me.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtSearch.PlaceholderText = "بحث..."
            Me.txtSearch.ReadOnly = True
            Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtSearch.ShowLabelOnFocus = False
            Me.txtSearch.Size = New System.Drawing.Size(223, 32)
            Me.txtSearch.TabIndex = 4
            Me.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtSearch.UnderlinedStyle = False
            Me.txtSearch.Value = ""
            '
            'addButton
            '
            Me.addButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addButton.BorderRadius = 6
            Me.addButton.BorderSize = 2
            Me.addButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addButton.FlatAppearance.BorderSize = 0
            Me.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.addButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.addButton.ForeColor = System.Drawing.Color.White
            Me.addButton.Image = CType(resources.GetObject("addButton.Image"), System.Drawing.Image)
            Me.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.addButton.Location = New System.Drawing.Point(695, 3)
            Me.addButton.Name = "addButton"
            Me.addButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
            Me.addButton.Size = New System.Drawing.Size(90, 33)
            Me.addButton.TabIndex = 4
            Me.addButton.Text = "   إنشاء"
            Me.addButton.TextColor = System.Drawing.Color.White
            Me.addButton.UseVisualStyleBackColor = False
            '
            'ContentPanel
            '
            Me.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ContentPanel.BorderColor = System.Drawing.Color.DarkGray
            Me.ContentPanel.BorderRadius = 0
            Me.ContentPanel.BorderSize = 0
            Me.ContentPanel.BottomLeftRadius = True
            Me.ContentPanel.BottomRightRadius = True
            Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentPanel.ForeColor = System.Drawing.Color.Black
            Me.ContentPanel.Location = New System.Drawing.Point(0, 42)
            Me.ContentPanel.Name = "ContentPanel"
            Me.ContentPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ContentPanel.Size = New System.Drawing.Size(788, 652)
            Me.ContentPanel.TabIndex = 4
            Me.ContentPanel.TopLeftRadius = True
            Me.ContentPanel.TopRightRadius = True
            '
            'NotesUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.Controls.Add(Me.ContentPanel)
            Me.Controls.Add(Me.toolbarPanel)
            Me.Name = "NotesUserControl"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Size = New System.Drawing.Size(788, 694)
            Me.toolbarPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents addButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtSearch As SafwanUiKit.Controls.STextBox
        Friend WithEvents ContentPanel As SafwanUiKit.Controls.RoundedPanel
    End Class
End NameSpace