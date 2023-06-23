Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NoteViewer
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteViewer))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.txtBody = New System.Windows.Forms.Label()
            Me.txtDate = New System.Windows.Forms.Label()
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
            Me.toolbarPanel.Size = New System.Drawing.Size(800, 41)
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
            Me.txtTitle.Location = New System.Drawing.Point(180, 9)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Size = New System.Drawing.Size(612, 20)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "معاينة"
            '
            'txtBody
            '
            Me.txtBody.AutoEllipsis = True
            Me.txtBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtBody.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtBody.ForeColor = System.Drawing.Color.Silver
            Me.txtBody.Location = New System.Drawing.Point(0, 41)
            Me.txtBody.Name = "txtBody"
            Me.txtBody.Padding = New System.Windows.Forms.Padding(16, 16, 20, 10)
            Me.txtBody.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtBody.Size = New System.Drawing.Size(800, 540)
            Me.txtBody.TabIndex = 10
            Me.txtBody.Text = "النص"
            '
            'txtDate
            '
            Me.txtDate.AutoEllipsis = True
            Me.txtDate.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.txtDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtDate.ForeColor = System.Drawing.Color.Silver
            Me.txtDate.Location = New System.Drawing.Point(0, 581)
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Padding = New System.Windows.Forms.Padding(6, 3, 3, 6)
            Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtDate.Size = New System.Drawing.Size(800, 24)
            Me.txtDate.TabIndex = 9
            Me.txtDate.Text = "{{DateTime}}"
            Me.txtDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'NoteViewer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(800, 605)
            Me.Controls.Add(Me.txtBody)
            Me.Controls.Add(Me.txtDate)
            Me.Controls.Add(Me.toolbarPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "NoteViewer"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "NoteViewer"
            Me.toolbarPanel.ResumeLayout(False)
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents closeButton As PictureBox
        Friend WithEvents txtTitle As Label
        Friend WithEvents txtBody As Label
        Friend WithEvents txtDate As Label
    End Class
End NameSpace