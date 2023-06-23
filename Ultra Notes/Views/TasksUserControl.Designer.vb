Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TasksUserControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TasksUserControl))
            Me.toolbarPanel = New System.Windows.Forms.Panel()
            Me.txtSearch = New SafwanUiKit.Controls.STextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TodosPanel = New SafwanUiKit.Controls.RoundedPanel()
            Me.RightPanel = New SafwanUiKit.Controls.RoundedPanel()
            Me.ListsPanel = New SafwanUiKit.Controls.RoundedPanel()
            Me.RightPanelHeader = New System.Windows.Forms.Panel()
            Me.deleteListButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.editListButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.addListButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.CreateTodoTablePanel = New System.Windows.Forms.TableLayoutPanel()
            Me.createTodoButton = New SafwanUiKit.Controls.PrimaryButton()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.txtTodo = New SafwanUiKit.Controls.STextBox()
            Me.TodoControlsPanel = New System.Windows.Forms.Panel()
            Me.completedTodosButton = New SafwanUiKit.Controls.SShapedButton()
            Me.unCompletedTodosButton = New SafwanUiKit.Controls.SShapedButton()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.chkTody = New SafwanUiKit.Controls.SToggleButton()
            Me.allTodosButton = New SafwanUiKit.Controls.SShapedButton()
            Me.toolbarPanel.SuspendLayout()
            Me.RightPanel.SuspendLayout()
            Me.RightPanelHeader.SuspendLayout()
            Me.CreateTodoTablePanel.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TodoControlsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'toolbarPanel
            '
            Me.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.toolbarPanel.Controls.Add(Me.txtSearch)
            Me.toolbarPanel.Controls.Add(Me.Label1)
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
            Me.txtSearch.Location = New System.Drawing.Point(5, 4)
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
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Silver
            Me.Label1.Location = New System.Drawing.Point(738, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 15)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "المهام"
            '
            'TodosPanel
            '
            Me.TodosPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.TodosPanel.BorderColor = System.Drawing.Color.DarkGray
            Me.TodosPanel.BorderRadius = 0
            Me.TodosPanel.BorderSize = 0
            Me.TodosPanel.BottomLeftRadius = True
            Me.TodosPanel.BottomRightRadius = True
            Me.TodosPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TodosPanel.ForeColor = System.Drawing.Color.Black
            Me.TodosPanel.Location = New System.Drawing.Point(0, 83)
            Me.TodosPanel.Name = "TodosPanel"
            Me.TodosPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TodosPanel.Size = New System.Drawing.Size(545, 567)
            Me.TodosPanel.TabIndex = 4
            Me.TodosPanel.TopLeftRadius = True
            Me.TodosPanel.TopRightRadius = True
            Me.TodosPanel.Visible = False
            '
            'RightPanel
            '
            Me.RightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.RightPanel.BorderColor = System.Drawing.Color.DarkGray
            Me.RightPanel.BorderRadius = 0
            Me.RightPanel.BorderSize = 0
            Me.RightPanel.BottomLeftRadius = True
            Me.RightPanel.BottomRightRadius = True
            Me.RightPanel.Controls.Add(Me.ListsPanel)
            Me.RightPanel.Controls.Add(Me.RightPanelHeader)
            Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.RightPanel.ForeColor = System.Drawing.Color.Black
            Me.RightPanel.Location = New System.Drawing.Point(545, 42)
            Me.RightPanel.Name = "RightPanel"
            Me.RightPanel.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
            Me.RightPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.RightPanel.Size = New System.Drawing.Size(243, 652)
            Me.RightPanel.TabIndex = 5
            Me.RightPanel.TopLeftRadius = True
            Me.RightPanel.TopRightRadius = True
            '
            'ListsPanel
            '
            Me.ListsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.ListsPanel.BorderColor = System.Drawing.Color.DarkGray
            Me.ListsPanel.BorderRadius = 0
            Me.ListsPanel.BorderSize = 0
            Me.ListsPanel.BottomLeftRadius = True
            Me.ListsPanel.BottomRightRadius = True
            Me.ListsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListsPanel.ForeColor = System.Drawing.Color.Black
            Me.ListsPanel.Location = New System.Drawing.Point(1, 41)
            Me.ListsPanel.Name = "ListsPanel"
            Me.ListsPanel.Size = New System.Drawing.Size(242, 611)
            Me.ListsPanel.TabIndex = 4
            Me.ListsPanel.TopLeftRadius = True
            Me.ListsPanel.TopRightRadius = True
            '
            'RightPanelHeader
            '
            Me.RightPanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.RightPanelHeader.Controls.Add(Me.deleteListButton)
            Me.RightPanelHeader.Controls.Add(Me.editListButton)
            Me.RightPanelHeader.Controls.Add(Me.addListButton)
            Me.RightPanelHeader.Controls.Add(Me.Label2)
            Me.RightPanelHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.RightPanelHeader.Location = New System.Drawing.Point(1, 0)
            Me.RightPanelHeader.Name = "RightPanelHeader"
            Me.RightPanelHeader.Size = New System.Drawing.Size(242, 41)
            Me.RightPanelHeader.TabIndex = 3
            '
            'deleteListButton
            '
            Me.deleteListButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteListButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteListButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.deleteListButton.BorderRadius = 6
            Me.deleteListButton.BorderSize = 2
            Me.deleteListButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.deleteListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteListButton.FlatAppearance.BorderSize = 0
            Me.deleteListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.deleteListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.deleteListButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.deleteListButton.ForeColor = System.Drawing.Color.White
            Me.deleteListButton.Image = CType(resources.GetObject("deleteListButton.Image"), System.Drawing.Image)
            Me.deleteListButton.Location = New System.Drawing.Point(4, 3)
            Me.deleteListButton.Name = "deleteListButton"
            Me.deleteListButton.Size = New System.Drawing.Size(33, 33)
            Me.deleteListButton.TabIndex = 4
            Me.deleteListButton.TextColor = System.Drawing.Color.White
            Me.deleteListButton.UseVisualStyleBackColor = False
            '
            'editListButton
            '
            Me.editListButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editListButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editListButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.editListButton.BorderRadius = 6
            Me.editListButton.BorderSize = 2
            Me.editListButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.editListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editListButton.FlatAppearance.BorderSize = 0
            Me.editListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.editListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.editListButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.editListButton.ForeColor = System.Drawing.Color.White
            Me.editListButton.Image = CType(resources.GetObject("editListButton.Image"), System.Drawing.Image)
            Me.editListButton.Location = New System.Drawing.Point(39, 3)
            Me.editListButton.Name = "editListButton"
            Me.editListButton.Size = New System.Drawing.Size(33, 33)
            Me.editListButton.TabIndex = 4
            Me.editListButton.TextColor = System.Drawing.Color.White
            Me.editListButton.UseVisualStyleBackColor = False
            '
            'addListButton
            '
            Me.addListButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addListButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addListButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.addListButton.BorderRadius = 6
            Me.addListButton.BorderSize = 2
            Me.addListButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.addListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addListButton.FlatAppearance.BorderSize = 0
            Me.addListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.addListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.addListButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.addListButton.ForeColor = System.Drawing.Color.White
            Me.addListButton.Image = CType(resources.GetObject("addListButton.Image"), System.Drawing.Image)
            Me.addListButton.Location = New System.Drawing.Point(74, 3)
            Me.addListButton.Name = "addListButton"
            Me.addListButton.Size = New System.Drawing.Size(33, 33)
            Me.addListButton.TabIndex = 4
            Me.addListButton.TextColor = System.Drawing.Color.White
            Me.addListButton.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Silver
            Me.Label2.Location = New System.Drawing.Point(167, 11)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(66, 15)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "قوائم المهام"
            '
            'CreateTodoTablePanel
            '
            Me.CreateTodoTablePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.CreateTodoTablePanel.ColumnCount = 3
            Me.CreateTodoTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.CreateTodoTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.CreateTodoTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.CreateTodoTablePanel.Controls.Add(Me.createTodoButton, 2, 0)
            Me.CreateTodoTablePanel.Controls.Add(Me.PictureBox1, 0, 0)
            Me.CreateTodoTablePanel.Controls.Add(Me.txtTodo, 1, 0)
            Me.CreateTodoTablePanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.CreateTodoTablePanel.Location = New System.Drawing.Point(0, 650)
            Me.CreateTodoTablePanel.Name = "CreateTodoTablePanel"
            Me.CreateTodoTablePanel.RowCount = 1
            Me.CreateTodoTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.CreateTodoTablePanel.Size = New System.Drawing.Size(545, 44)
            Me.CreateTodoTablePanel.TabIndex = 9
            Me.CreateTodoTablePanel.Visible = False
            '
            'createTodoButton
            '
            Me.createTodoButton.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.createTodoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.createTodoButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.createTodoButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.createTodoButton.BorderRadius = 4
            Me.createTodoButton.BorderSize = 2
            Me.createTodoButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.createTodoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.createTodoButton.FlatAppearance.BorderSize = 0
            Me.createTodoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.createTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.createTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.createTodoButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.createTodoButton.ForeColor = System.Drawing.Color.White
            Me.createTodoButton.Image = CType(resources.GetObject("createTodoButton.Image"), System.Drawing.Image)
            Me.createTodoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.createTodoButton.Location = New System.Drawing.Point(6, 5)
            Me.createTodoButton.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.createTodoButton.Name = "createTodoButton"
            Me.createTodoButton.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
            Me.createTodoButton.Size = New System.Drawing.Size(86, 33)
            Me.createTodoButton.TabIndex = 10
            Me.createTodoButton.Text = "   إنشاء"
            Me.createTodoButton.TextColor = System.Drawing.Color.White
            Me.createTodoButton.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(509, 5)
            Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(30, 34)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PictureBox1.TabIndex = 7
            Me.PictureBox1.TabStop = False
            '
            'txtTodo
            '
            Me.txtTodo.AcceptNumbersOnly = False
            Me.txtTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.txtTodo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.txtTodo.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.txtTodo.BorderRadius = 0
            Me.txtTodo.BorderSize = 1
            Me.txtTodo.CustomPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtTodo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.txtTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.txtTodo.LabelControl = Nothing
            Me.txtTodo.Location = New System.Drawing.Point(98, 2)
            Me.txtTodo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
            Me.txtTodo.Multiline = False
            Me.txtTodo.Name = "txtTodo"
            Me.txtTodo.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
            Me.txtTodo.PasswordChar = False
            Me.txtTodo.PlaceholderColor = System.Drawing.Color.DimGray
            Me.txtTodo.PlaceholderText = "مهمة جديدة ..."
            Me.txtTodo.ReadOnly = False
            Me.txtTodo.ShowLabelOnFocus = False
            Me.txtTodo.Size = New System.Drawing.Size(405, 36)
            Me.txtTodo.TabIndex = 5
            Me.txtTodo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtTodo.UnderlinedStyle = False
            Me.txtTodo.Value = ""
            '
            'TodoControlsPanel
            '
            Me.TodoControlsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.TodoControlsPanel.Controls.Add(Me.completedTodosButton)
            Me.TodoControlsPanel.Controls.Add(Me.unCompletedTodosButton)
            Me.TodoControlsPanel.Controls.Add(Me.Label3)
            Me.TodoControlsPanel.Controls.Add(Me.chkTody)
            Me.TodoControlsPanel.Controls.Add(Me.allTodosButton)
            Me.TodoControlsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.TodoControlsPanel.Location = New System.Drawing.Point(0, 42)
            Me.TodoControlsPanel.Name = "TodoControlsPanel"
            Me.TodoControlsPanel.Size = New System.Drawing.Size(545, 41)
            Me.TodoControlsPanel.TabIndex = 10
            Me.TodoControlsPanel.Visible = False
            '
            'completedTodosButton
            '
            Me.completedTodosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.completedTodosButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.completedTodosButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.completedTodosButton.BorderRadius = 6
            Me.completedTodosButton.BorderSize = 0
            Me.completedTodosButton.BottomLeftRadius = False
            Me.completedTodosButton.BottomRightRadius = False
            Me.completedTodosButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.completedTodosButton.FlatAppearance.BorderSize = 0
            Me.completedTodosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.completedTodosButton.ForeColor = System.Drawing.Color.White
            Me.completedTodosButton.Location = New System.Drawing.Point(398, 3)
            Me.completedTodosButton.Name = "completedTodosButton"
            Me.completedTodosButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.completedTodosButton.Size = New System.Drawing.Size(72, 33)
            Me.completedTodosButton.TabIndex = 11
            Me.completedTodosButton.Text = "مكتملة"
            Me.completedTodosButton.TextColor = System.Drawing.Color.White
            Me.completedTodosButton.TopLeftRadius = False
            Me.completedTodosButton.TopRightRadius = False
            Me.completedTodosButton.UseVisualStyleBackColor = False
            '
            'unCompletedTodosButton
            '
            Me.unCompletedTodosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.unCompletedTodosButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.unCompletedTodosButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.unCompletedTodosButton.BorderRadius = 6
            Me.unCompletedTodosButton.BorderSize = 0
            Me.unCompletedTodosButton.BottomLeftRadius = False
            Me.unCompletedTodosButton.BottomRightRadius = True
            Me.unCompletedTodosButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.unCompletedTodosButton.FlatAppearance.BorderSize = 0
            Me.unCompletedTodosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.unCompletedTodosButton.ForeColor = System.Drawing.Color.White
            Me.unCompletedTodosButton.Location = New System.Drawing.Point(470, 3)
            Me.unCompletedTodosButton.Name = "unCompletedTodosButton"
            Me.unCompletedTodosButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.unCompletedTodosButton.Size = New System.Drawing.Size(72, 33)
            Me.unCompletedTodosButton.TabIndex = 11
            Me.unCompletedTodosButton.Text = "غير مكتملة"
            Me.unCompletedTodosButton.TextColor = System.Drawing.Color.White
            Me.unCompletedTodosButton.TopLeftRadius = False
            Me.unCompletedTodosButton.TopRightRadius = True
            Me.unCompletedTodosButton.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Silver
            Me.Label3.Location = New System.Drawing.Point(11, 12)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(56, 15)
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "اليوم فقط"
            '
            'chkTody
            '
            Me.chkTody.AutoSize = True
            Me.chkTody.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chkTody.LabelControl = Nothing
            Me.chkTody.Location = New System.Drawing.Point(72, 9)
            Me.chkTody.MinimumSize = New System.Drawing.Size(45, 22)
            Me.chkTody.Name = "chkTody"
            Me.chkTody.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.chkTody.OffToggleColor = System.Drawing.Color.Gainsboro
            Me.chkTody.OnBackColor = System.Drawing.Color.RoyalBlue
            Me.chkTody.OnToggleColor = System.Drawing.Color.WhiteSmoke
            Me.chkTody.Size = New System.Drawing.Size(45, 22)
            Me.chkTody.TabIndex = 12
            Me.chkTody.UseVisualStyleBackColor = True
            '
            'allTodosButton
            '
            Me.allTodosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.allTodosButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.allTodosButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(36, Byte), Integer))
            Me.allTodosButton.BorderRadius = 6
            Me.allTodosButton.BorderSize = 0
            Me.allTodosButton.BottomLeftRadius = True
            Me.allTodosButton.BottomRightRadius = False
            Me.allTodosButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.allTodosButton.FlatAppearance.BorderSize = 0
            Me.allTodosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.allTodosButton.ForeColor = System.Drawing.Color.White
            Me.allTodosButton.Location = New System.Drawing.Point(326, 3)
            Me.allTodosButton.Name = "allTodosButton"
            Me.allTodosButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.allTodosButton.Size = New System.Drawing.Size(72, 33)
            Me.allTodosButton.TabIndex = 11
            Me.allTodosButton.Text = "الكل"
            Me.allTodosButton.TextColor = System.Drawing.Color.White
            Me.allTodosButton.TopLeftRadius = True
            Me.allTodosButton.TopRightRadius = False
            Me.allTodosButton.UseVisualStyleBackColor = False
            '
            'TasksUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.Controls.Add(Me.TodosPanel)
            Me.Controls.Add(Me.TodoControlsPanel)
            Me.Controls.Add(Me.CreateTodoTablePanel)
            Me.Controls.Add(Me.RightPanel)
            Me.Controls.Add(Me.toolbarPanel)
            Me.Name = "TasksUserControl"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Size = New System.Drawing.Size(788, 694)
            Me.toolbarPanel.ResumeLayout(False)
            Me.toolbarPanel.PerformLayout()
            Me.RightPanel.ResumeLayout(False)
            Me.RightPanelHeader.ResumeLayout(False)
            Me.RightPanelHeader.PerformLayout()
            Me.CreateTodoTablePanel.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TodoControlsPanel.ResumeLayout(False)
            Me.TodoControlsPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents toolbarPanel As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents txtSearch As SafwanUiKit.Controls.STextBox
        Friend WithEvents TodosPanel As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents RightPanel As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents RightPanelHeader As Panel
        Friend WithEvents deleteListButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents editListButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents addListButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents Label2 As Label
        Friend WithEvents ListsPanel As SafwanUiKit.Controls.RoundedPanel
        Friend WithEvents CreateTodoTablePanel As TableLayoutPanel
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents txtTodo As SafwanUiKit.Controls.STextBox
        Friend WithEvents createTodoButton As SafwanUiKit.Controls.PrimaryButton
        Friend WithEvents TodoControlsPanel As Panel
        Friend WithEvents allTodosButton As SafwanUiKit.Controls.SShapedButton
        Friend WithEvents unCompletedTodosButton As SafwanUiKit.Controls.SShapedButton
        Friend WithEvents completedTodosButton As SafwanUiKit.Controls.SShapedButton
        Friend WithEvents Label3 As Label
        Friend WithEvents chkTody As SafwanUiKit.Controls.SToggleButton
    End Class
End NameSpace