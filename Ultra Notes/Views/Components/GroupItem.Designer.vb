Namespace Views.Components
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class GroupItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupItem))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.txtTitle = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.txtTitle, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(275, 32)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'txtTitle
            '
            Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTitle.AutoEllipsis = True
            Me.txtTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtTitle.ForeColor = System.Drawing.Color.Silver
            Me.txtTitle.Location = New System.Drawing.Point(3, 7)
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
            Me.txtTitle.Size = New System.Drawing.Size(233, 18)
            Me.txtTitle.TabIndex = 6
            Me.txtTitle.Text = "العنوان"
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(242, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PictureBox1.TabIndex = 1
            Me.PictureBox1.TabStop = False
            '
            'GroupItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.BorderRadius = 5
            Me.BorderSize = 1
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Name = "GroupItem"
            Me.Padding = New System.Windows.Forms.Padding(4)
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Size = New System.Drawing.Size(283, 40)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents txtTitle As Label
    End Class
End NameSpace