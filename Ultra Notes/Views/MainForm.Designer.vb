Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.closeButton = New System.Windows.Forms.PictureBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.RightPanel = New System.Windows.Forms.Panel()
            Me.RoundedPanelOfGroups = New SafwanUiKit.Controls.RoundedPanel()
            Me.GroupSearchPanel = New System.Windows.Forms.Panel()
            Me.RightPanelHeader = New System.Windows.Forms.Panel()
            Me.deleteGroupButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.editGroupButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.addGroupButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.txtFindGroup = New SafwanUiKit.Controls.STextBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.aboutButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.footerPanel = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.Label()
            Me.ContentAreaHeaderPanel = New System.Windows.Forms.Panel()
            Me.txtPath = New System.Windows.Forms.Label()
            Me.ContentRoundedPanel = New SafwanUiKit.Controls.RoundedPanel()
            Me.PanelDep = New System.Windows.Forms.Panel()
            Me.TasksButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.NotesButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.toolbarPanel.SuspendLayout()
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RightPanel.SuspendLayout()
            Me.RightPanelHeader.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.footerPanel.SuspendLayout()
            Me.ContentAreaHeaderPanel.SuspendLayout()
            Me.PanelDep.SuspendLayout()
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
            Me.toolbarPanel.Size = New System.Drawing.Size(1277, 46)
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
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(1206, 10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(59, 20)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "الرئيسية"
            '
            'RightPanel
            '
            Me.RightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.RightPanel.Controls.Add(Me.RoundedPanelOfGroups)
            Me.RightPanel.Controls.Add(Me.GroupSearchPanel)
            Me.RightPanel.Controls.Add(Me.RightPanelHeader)
            Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.RightPanel.Location = New System.Drawing.Point(0, 46)
            Me.RightPanel.Name = "RightPanel"
            Me.RightPanel.Size = New System.Drawing.Size(299, 678)
            Me.RightPanel.TabIndex = 3
            '
            'RoundedPanelOfGroups
            '
            Me.RoundedPanelOfGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.RoundedPanelOfGroups.BorderColor = System.Drawing.Color.DarkGray
            Me.RoundedPanelOfGroups.BorderRadius = 0
            Me.RoundedPanelOfGroups.BorderSize = 0
            Me.RoundedPanelOfGroups.BottomLeftRadius = True
            Me.RoundedPanelOfGroups.BottomRightRadius = True
            Me.RoundedPanelOfGroups.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RoundedPanelOfGroups.ForeColor = System.Drawing.Color.Black
            Me.RoundedPanelOfGroups.Location = New System.Drawing.Point(0, 86)
            Me.RoundedPanelOfGroups.Name = "RoundedPanelOfGroups"
            Me.RoundedPanelOfGroups.Size = New System.Drawing.Size(299, 592)
            Me.RoundedPanelOfGroups.TabIndex = 4
            Me.RoundedPanelOfGroups.TopLeftRadius = True
            Me.RoundedPanelOfGroups.TopRightRadius = True
            '
            'GroupSearchPanel
            '
            Me.GroupSearchPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.GroupSearchPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupSearchPanel.Location = New System.Drawing.Point(0, 41)
            Me.GroupSearchPanel.Name = "GroupSearchPanel"
            Me.GroupSearchPanel.Size = New System.Drawing.Size(299, 45)
            Me.GroupSearchPanel.TabIndex = 3
            '
            'RightPanelHeader
            '
            Me.RightPanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.RightPanelHeader.Controls.Add(Me.deleteGroupButton)
            Me.RightPanelHeader.Controls.Add(Me.editGroupButton)
            Me.RightPanelHeader.Controls.Add(Me.addGroupButton)
            Me.RightPanelHeader.Controls.Add(Me.Label1)
            Me.RightPanelHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.RightPanelHeader.Location = New System.Drawing.Point(0, 0)
            Me.RightPanelHeader.Name = "RightPanelHeader"
            Me.RightPanelHeader.Size = New System.Drawing.Size(299, 41)
            Me.RightPanelHeader.TabIndex = 2
            '
            'deleteGroupButton
            '
            Me.deleteGroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteGroupButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteGroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteGroupButton.BorderRadius = 6
            Me.deleteGroupButton.BorderSize = 2
            Me.deleteGroupButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.deleteGroupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteGroupButton.FlatAppearance.BorderSize = 0
            Me.deleteGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.deleteGroupButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.deleteGroupButton.ForeColor = System.Drawing.Color.White
            Me.deleteGroupButton.Image = CType(resources.GetObject("deleteGroupButton.Image"), System.Drawing.Image)
            Me.deleteGroupButton.Location = New System.Drawing.Point(4, 3)
            Me.deleteGroupButton.Name = "deleteGroupButton"
            Me.deleteGroupButton.Size = New System.Drawing.Size(33, 33)
            Me.deleteGroupButton.TabIndex = 4
            Me.deleteGroupButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.deleteGroupButton, "حذف")
            Me.deleteGroupButton.UseVisualStyleBackColor = False
            '
            'editGroupButton
            '
            Me.editGroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editGroupButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editGroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editGroupButton.BorderRadius = 6
            Me.editGroupButton.BorderSize = 2
            Me.editGroupButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.editGroupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editGroupButton.FlatAppearance.BorderSize = 0
            Me.editGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.editGroupButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.editGroupButton.ForeColor = System.Drawing.Color.White
            Me.editGroupButton.Image = CType(resources.GetObject("editGroupButton.Image"), System.Drawing.Image)
            Me.editGroupButton.Location = New System.Drawing.Point(39, 3)
            Me.editGroupButton.Name = "editGroupButton"
            Me.editGroupButton.Size = New System.Drawing.Size(33, 33)
            Me.editGroupButton.TabIndex = 4
            Me.editGroupButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.editGroupButton, "تعديل")
            Me.editGroupButton.UseVisualStyleBackColor = False
            '
            'addGroupButton
            '
            Me.addGroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addGroupButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addGroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addGroupButton.BorderRadius = 6
            Me.addGroupButton.BorderSize = 2
            Me.addGroupButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.addGroupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addGroupButton.FlatAppearance.BorderSize = 0
            Me.addGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.addGroupButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.addGroupButton.ForeColor = System.Drawing.Color.White
            Me.addGroupButton.Image = CType(resources.GetObject("addGroupButton.Image"), System.Drawing.Image)
            Me.addGroupButton.Location = New System.Drawing.Point(74, 3)
            Me.addGroupButton.Name = "addGroupButton"
            Me.addGroupButton.Size = New System.Drawing.Size(33, 33)
            Me.addGroupButton.TabIndex = 4
            Me.addGroupButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.addGroupButton, "إنشاء مجموعة")
            Me.addGroupButton.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Silver
            Me.Label1.Location = New System.Drawing.Point(241, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 15)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "القوائم"
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.txtFindGroup, 1, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 88)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(293, 42)
            Me.TableLayoutPanel1.TabIndex = 8
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(257, 4)
            Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(30, 34)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PictureBox1.TabIndex = 7
            Me.PictureBox1.TabStop = False
            '
            'txtFindGroup
            '
            Me.txtFindGroup.AcceptNumbersOnly = False
            Me.txtFindGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFindGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.txtFindGroup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.txtFindGroup.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.txtFindGroup.BorderRadius = 0
            Me.txtFindGroup.BorderSize = 1
            Me.txtFindGroup.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtFindGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.txtFindGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtFindGroup.LabelControl = Nothing
            Me.txtFindGroup.Location = New System.Drawing.Point(0, 3)
            Me.txtFindGroup.Margin = New System.Windows.Forms.Padding(0)
            Me.txtFindGroup.Multiline = False
            Me.txtFindGroup.Name = "txtFindGroup"
            Me.txtFindGroup.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtFindGroup.PasswordChar = False
            Me.txtFindGroup.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtFindGroup.PlaceholderText = "بحث ..."
            Me.txtFindGroup.ReadOnly = False
            Me.txtFindGroup.ShowLabelOnFocus = False
            Me.txtFindGroup.Size = New System.Drawing.Size(251, 36)
            Me.txtFindGroup.TabIndex = 5
            Me.txtFindGroup.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtFindGroup.UnderlinedStyle = False
            Me.txtFindGroup.Value = ""
            '
            'aboutButton
            '
            Me.aboutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.aboutButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.aboutButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.aboutButton.BorderRadius = 6
            Me.aboutButton.BorderSize = 0
            Me.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.aboutButton.FlatAppearance.BorderSize = 0
            Me.aboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.aboutButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.aboutButton.ForeColor = System.Drawing.Color.White
            Me.aboutButton.Image = CType(resources.GetObject("aboutButton.Image"), System.Drawing.Image)
            Me.aboutButton.Location = New System.Drawing.Point(3, 3)
            Me.aboutButton.Name = "aboutButton"
            Me.aboutButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.aboutButton.Size = New System.Drawing.Size(31, 29)
            Me.aboutButton.TabIndex = 4
            Me.aboutButton.TextColor = System.Drawing.Color.White
            Me.ToolTip1.SetToolTip(Me.aboutButton, "عن البرنامج")
            Me.aboutButton.UseVisualStyleBackColor = False
            '
            'footerPanel
            '
            Me.footerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.footerPanel.Controls.Add(Me.Label2)
            Me.footerPanel.Controls.Add(Me.aboutButton)
            Me.footerPanel.Controls.Add(Me.txtUsername)
            Me.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.footerPanel.Location = New System.Drawing.Point(0, 724)
            Me.footerPanel.Name = "footerPanel"
            Me.footerPanel.Size = New System.Drawing.Size(1277, 36)
            Me.footerPanel.TabIndex = 4
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Silver
            Me.Label2.Location = New System.Drawing.Point(1200, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(61, 15)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "المستحدم :"
            '
            'txtUsername
            '
            Me.txtUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUsername.AutoEllipsis = True
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtUsername.ForeColor = System.Drawing.Color.Silver
            Me.txtUsername.Location = New System.Drawing.Point(1054, 9)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(135, 15)
            Me.txtUsername.TabIndex = 6
            Me.txtUsername.Text = "المستخدم"
            '
            'ContentAreaHeaderPanel
            '
            Me.ContentAreaHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ContentAreaHeaderPanel.Controls.Add(Me.txtPath)
            Me.ContentAreaHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.ContentAreaHeaderPanel.Location = New System.Drawing.Point(299, 46)
            Me.ContentAreaHeaderPanel.Name = "ContentAreaHeaderPanel"
            Me.ContentAreaHeaderPanel.Size = New System.Drawing.Size(978, 33)
            Me.ContentAreaHeaderPanel.TabIndex = 9
            Me.ContentAreaHeaderPanel.Visible = False
            '
            'txtPath
            '
            Me.txtPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPath.AutoEllipsis = True
            Me.txtPath.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.txtPath.ForeColor = System.Drawing.Color.Gray
            Me.txtPath.Location = New System.Drawing.Point(755, 8)
            Me.txtPath.Name = "txtPath"
            Me.txtPath.Size = New System.Drawing.Size(215, 15)
            Me.txtPath.TabIndex = 7
            Me.txtPath.Text = "القوائم  /  "
            '
            'ContentRoundedPanel
            '
            Me.ContentRoundedPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ContentRoundedPanel.BorderColor = System.Drawing.Color.DarkGray
            Me.ContentRoundedPanel.BorderRadius = 0
            Me.ContentRoundedPanel.BorderSize = 0
            Me.ContentRoundedPanel.BottomLeftRadius = True
            Me.ContentRoundedPanel.BottomRightRadius = True
            Me.ContentRoundedPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentRoundedPanel.ForeColor = System.Drawing.Color.Black
            Me.ContentRoundedPanel.Location = New System.Drawing.Point(489, 79)
            Me.ContentRoundedPanel.Name = "ContentRoundedPanel"
            Me.ContentRoundedPanel.Size = New System.Drawing.Size(788, 645)
            Me.ContentRoundedPanel.TabIndex = 10
            Me.ContentRoundedPanel.TopLeftRadius = True
            Me.ContentRoundedPanel.TopRightRadius = True
            Me.ContentRoundedPanel.Visible = False
            '
            'PanelDep
            '
            Me.PanelDep.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.PanelDep.Controls.Add(Me.TasksButton)
            Me.PanelDep.Controls.Add(Me.NotesButton)
            Me.PanelDep.Dock = System.Windows.Forms.DockStyle.Left
            Me.PanelDep.Location = New System.Drawing.Point(299, 79)
            Me.PanelDep.Name = "PanelDep"
            Me.PanelDep.Size = New System.Drawing.Size(190, 645)
            Me.PanelDep.TabIndex = 0
            Me.PanelDep.Visible = False
            '
            'TasksButton
            '
            Me.TasksButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.TasksButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.TasksButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.TasksButton.BorderRadius = 4
            Me.TasksButton.BorderSize = 1
            Me.TasksButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.TasksButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.TasksButton.FlatAppearance.BorderSize = 0
            Me.TasksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.TasksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.TasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.TasksButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.TasksButton.ForeColor = System.Drawing.Color.White
            Me.TasksButton.Image = CType(resources.GetObject("TasksButton.Image"), System.Drawing.Image)
            Me.TasksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TasksButton.Location = New System.Drawing.Point(6, 49)
            Me.TasksButton.Name = "TasksButton"
            Me.TasksButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 2)
            Me.TasksButton.Size = New System.Drawing.Size(178, 39)
            Me.TasksButton.TabIndex = 4
            Me.TasksButton.Text = "              إدارة المهام"
            Me.TasksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TasksButton.TextColor = System.Drawing.Color.White
            Me.TasksButton.UseVisualStyleBackColor = False
            '
            'NotesButton
            '
            Me.NotesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.NotesButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.NotesButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.NotesButton.BorderRadius = 4
            Me.NotesButton.BorderSize = 1
            Me.NotesButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NotesButton.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.NotesButton.FlatAppearance.BorderSize = 0
            Me.NotesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.NotesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.NotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.NotesButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.NotesButton.ForeColor = System.Drawing.Color.White
            Me.NotesButton.Image = CType(resources.GetObject("NotesButton.Image"), System.Drawing.Image)
            Me.NotesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.NotesButton.Location = New System.Drawing.Point(6, 6)
            Me.NotesButton.Name = "NotesButton"
            Me.NotesButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
            Me.NotesButton.Size = New System.Drawing.Size(178, 39)
            Me.NotesButton.TabIndex = 4
            Me.NotesButton.Text = "              إدارة الملاحضات"
            Me.NotesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.NotesButton.TextColor = System.Drawing.Color.White
            Me.NotesButton.UseVisualStyleBackColor = False
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1277, 760)
            Me.Controls.Add(Me.ContentRoundedPanel)
            Me.Controls.Add(Me.PanelDep)
            Me.Controls.Add(Me.ContentAreaHeaderPanel)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.RightPanel)
            Me.Controls.Add(Me.toolbarPanel)
            Me.Controls.Add(Me.footerPanel)
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "MainForm"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.RightToLeftLayout = True
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Form1"
            Me.toolbarPanel.ResumeLayout(False)
            Me.toolbarPanel.PerformLayout()
            CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RightPanel.ResumeLayout(False)
            Me.RightPanelHeader.ResumeLayout(False)
            Me.RightPanelHeader.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.footerPanel.ResumeLayout(False)
            Me.footerPanel.PerformLayout()
            Me.ContentAreaHeaderPanel.ResumeLayout(False)
            Me.PanelDep.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents closeButton As PictureBox
        Friend WithEvents Label3 As Label
        Friend WithEvents RightPanel As Panel
        Friend WithEvents RightPanelHeader As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents addGroupButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents deleteGroupButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents editGroupButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents footerPanel As Panel
        Friend WithEvents aboutButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents txtUsername As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents txtFindGroup As SafwanUiKit.Controls.STextBox
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents GroupSearchPanel As Panel
        Friend WithEvents RoundedPanelOfGroups As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents ContentAreaHeaderPanel As Panel
        Friend WithEvents ContentRoundedPanel As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents txtPath As Label
        Friend WithEvents PanelDep As Panel
        Friend WithEvents TasksButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents NotesButton As SafwanUiKit.Controls.PrimaryButton
    End Class
End NameSpace