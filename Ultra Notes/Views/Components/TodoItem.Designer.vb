Namespace Views.Components
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TodoItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodoItem))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.viewButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.chkComplete = New SafwanUiKit.Controls.SToggleButton()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.deleteButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.editButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 5
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.Controls.Add(Me.viewButton, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.chkComplete, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.txtTitle, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.deleteButton, 4, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.editButton, 3, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(522, 43)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'viewButton
            '
            Me.viewButton.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.viewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.BorderRadius = 6
            Me.viewButton.BorderSize = 2
            Me.viewButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.viewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.viewButton.FlatAppearance.BorderSize = 0
            Me.viewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.viewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.viewButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.viewButton.ForeColor = System.Drawing.Color.White
            Me.viewButton.Image = CType(resources.GetObject("viewButton.Image"), System.Drawing.Image)
            Me.viewButton.Location = New System.Drawing.Point(81, 5)
            Me.viewButton.Name = "viewButton"
            Me.viewButton.Size = New System.Drawing.Size(33, 33)
            Me.viewButton.TabIndex = 5
            Me.viewButton.TextColor = System.Drawing.Color.White
            Me.viewButton.UseVisualStyleBackColor = False
            '
            'chkComplete
            '
            Me.chkComplete.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.chkComplete.AutoSize = True
            Me.chkComplete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chkComplete.LabelControl = Nothing
            Me.chkComplete.Location = New System.Drawing.Point(465, 10)
            Me.chkComplete.MinimumSize = New System.Drawing.Size(45, 22)
            Me.chkComplete.Name = "chkComplete"
            Me.chkComplete.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(108, Byte), Integer))
            Me.chkComplete.OffToggleColor = System.Drawing.Color.Gainsboro
            Me.chkComplete.OnBackColor = System.Drawing.Color.RoyalBlue
            Me.chkComplete.OnToggleColor = System.Drawing.Color.WhiteSmoke
            Me.chkComplete.Size = New System.Drawing.Size(45, 22)
            Me.chkComplete.TabIndex = 13
            Me.chkComplete.UseVisualStyleBackColor = True
            '
            'txtTitle
            '
            Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTitle.AutoEllipsis = True
            Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtTitle.ForeColor = System.Drawing.Color.Silver
            Me.txtTitle.Location = New System.Drawing.Point(120, 12)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
            Me.txtTitle.Size = New System.Drawing.Size(329, 18)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "العنوان"
            '
            'deleteButton
            '
            Me.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.BorderRadius = 6
            Me.deleteButton.BorderSize = 2
            Me.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteButton.FlatAppearance.BorderSize = 0
            Me.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.deleteButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.deleteButton.ForeColor = System.Drawing.Color.White
            Me.deleteButton.Image = CType(resources.GetObject("deleteButton.Image"), System.Drawing.Image)
            Me.deleteButton.Location = New System.Drawing.Point(3, 5)
            Me.deleteButton.Name = "deleteButton"
            Me.deleteButton.Size = New System.Drawing.Size(33, 33)
            Me.deleteButton.TabIndex = 16
            Me.deleteButton.TextColor = System.Drawing.Color.White
            Me.deleteButton.UseVisualStyleBackColor = False
            '
            'editButton
            '
            Me.editButton.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.editButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.BorderRadius = 6
            Me.editButton.BorderSize = 2
            Me.editButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editButton.FlatAppearance.BorderSize = 0
            Me.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.editButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.editButton.ForeColor = System.Drawing.Color.White
            Me.editButton.Image = CType(resources.GetObject("editButton.Image"), System.Drawing.Image)
            Me.editButton.Location = New System.Drawing.Point(42, 5)
            Me.editButton.Name = "editButton"
            Me.editButton.Size = New System.Drawing.Size(33, 33)
            Me.editButton.TabIndex = 15
            Me.editButton.TextColor = System.Drawing.Color.White
            Me.editButton.UseVisualStyleBackColor = False
            '
            'TodoItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.BorderRadius = 5
            Me.BorderSize = 1
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Name = "TodoItem"
            Me.Padding = New System.Windows.Forms.Padding(4)
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Size = New System.Drawing.Size(530, 50)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents txtTitle As Label
        Friend WithEvents chkComplete As SafwanUiKit.Controls.SToggleButton
        Friend WithEvents editButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents deleteButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents viewButton As SafwanUiKit.Controls.PrimaryButton
    End Class
End NameSpace