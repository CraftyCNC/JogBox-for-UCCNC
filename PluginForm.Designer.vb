<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JogBox
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JogBox))
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.pnlJogBtn = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnJogUL = New System.Windows.Forms.Button()
        Me.btnJogUp = New System.Windows.Forms.Button()
        Me.btnJogUR = New System.Windows.Forms.Button()
        Me.btnJogLeft = New System.Windows.Forms.Button()
        Me.btnJogBR = New System.Windows.Forms.Button()
        Me.btnJogRight = New System.Windows.Forms.Button()
        Me.btnJogBL = New System.Windows.Forms.Button()
        Me.btnJogDn = New System.Windows.Forms.Button()
        Me.btnjogZup = New System.Windows.Forms.Button()
        Me.btnjogZdown = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblStepSize = New System.Windows.Forms.Label()
        Me.nudJogStep = New System.Windows.Forms.NumericUpDown()
        Me.lblJogVel = New System.Windows.Forms.Label()
        Me.nudJogVel = New System.Windows.Forms.NumericUpDown()
        Me.pnlGoTo = New System.Windows.Forms.Panel()
        Me.btnGoToZero = New System.Windows.Forms.Button()
        Me.cbZSafeReturn = New System.Windows.Forms.CheckBox()
        Me.cbZSafeLift = New System.Windows.Forms.CheckBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.nudGoTOVel = New System.Windows.Forms.NumericUpDown()
        Me.tbGoToRot = New System.Windows.Forms.TextBox()
        Me.tbGoTOZ = New System.Windows.Forms.TextBox()
        Me.tbGoToY = New System.Windows.Forms.TextBox()
        Me.tbGoToX = New System.Windows.Forms.TextBox()
        Me.cbGoTORot = New System.Windows.Forms.CheckBox()
        Me.cbGoToZ = New System.Windows.Forms.CheckBox()
        Me.cbGoToY = New System.Windows.Forms.CheckBox()
        Me.cbGoToX = New System.Windows.Forms.CheckBox()
        Me.btnGoTo = New System.Windows.Forms.Button()
        Me.cbOnTop = New System.Windows.Forms.CheckBox()
        Me.rbGoTo = New System.Windows.Forms.RadioButton()
        Me.cbJogEnab = New System.Windows.Forms.CheckBox()
        Me.rbJogStep = New System.Windows.Forms.RadioButton()
        Me.rbJogCont = New System.Windows.Forms.RadioButton()
        Me.screenUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox25.SuspendLayout()
        Me.pnlJogBtn.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudJogStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJogVel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGoTo.SuspendLayout()
        CType(Me.nudGoTOVel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox25
        '
        Me.GroupBox25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox25.Controls.Add(Me.pnlJogBtn)
        Me.GroupBox25.Controls.Add(Me.pnlGoTo)
        Me.GroupBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox25.Location = New System.Drawing.Point(2, 64)
        Me.GroupBox25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox25.Size = New System.Drawing.Size(277, 244)
        Me.GroupBox25.TabIndex = 167
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Jogging"
        '
        'pnlJogBtn
        '
        Me.pnlJogBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlJogBtn.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlJogBtn.Controls.Add(Me.lblStepSize)
        Me.pnlJogBtn.Controls.Add(Me.nudJogStep)
        Me.pnlJogBtn.Controls.Add(Me.lblJogVel)
        Me.pnlJogBtn.Controls.Add(Me.nudJogVel)
        Me.pnlJogBtn.Location = New System.Drawing.Point(6, 21)
        Me.pnlJogBtn.Name = "pnlJogBtn"
        Me.pnlJogBtn.Size = New System.Drawing.Size(265, 218)
        Me.pnlJogBtn.TabIndex = 180
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogUL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogUp, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogUR, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogLeft, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogBR, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogRight, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogBL, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnJogDn, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnjogZup, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnjogZdown, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 4, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 65)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(259, 151)
        Me.TableLayoutPanel1.TabIndex = 178
        '
        'btnJogUL
        '
        Me.btnJogUL.BackgroundImage = CType(resources.GetObject("btnJogUL.BackgroundImage"), System.Drawing.Image)
        Me.btnJogUL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogUL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogUL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogUL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogUL.Location = New System.Drawing.Point(3, 2)
        Me.btnJogUL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogUL.Name = "btnJogUL"
        Me.btnJogUL.Size = New System.Drawing.Size(58, 46)
        Me.btnJogUL.TabIndex = 159
        Me.btnJogUL.TabStop = False
        Me.btnJogUL.UseVisualStyleBackColor = True
        '
        'btnJogUp
        '
        Me.btnJogUp.BackgroundImage = CType(resources.GetObject("btnJogUp.BackgroundImage"), System.Drawing.Image)
        Me.btnJogUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogUp.Location = New System.Drawing.Point(67, 2)
        Me.btnJogUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogUp.Name = "btnJogUp"
        Me.btnJogUp.Size = New System.Drawing.Size(58, 46)
        Me.btnJogUp.TabIndex = 159
        Me.btnJogUp.TabStop = False
        Me.btnJogUp.UseVisualStyleBackColor = True
        '
        'btnJogUR
        '
        Me.btnJogUR.BackgroundImage = CType(resources.GetObject("btnJogUR.BackgroundImage"), System.Drawing.Image)
        Me.btnJogUR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogUR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogUR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogUR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogUR.Location = New System.Drawing.Point(131, 2)
        Me.btnJogUR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogUR.Name = "btnJogUR"
        Me.btnJogUR.Size = New System.Drawing.Size(58, 46)
        Me.btnJogUR.TabIndex = 159
        Me.btnJogUR.TabStop = False
        Me.btnJogUR.UseVisualStyleBackColor = True
        '
        'btnJogLeft
        '
        Me.btnJogLeft.BackgroundImage = CType(resources.GetObject("btnJogLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnJogLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogLeft.Location = New System.Drawing.Point(3, 52)
        Me.btnJogLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogLeft.Name = "btnJogLeft"
        Me.btnJogLeft.Size = New System.Drawing.Size(58, 46)
        Me.btnJogLeft.TabIndex = 161
        Me.btnJogLeft.TabStop = False
        Me.btnJogLeft.UseVisualStyleBackColor = True
        '
        'btnJogBR
        '
        Me.btnJogBR.BackgroundImage = CType(resources.GetObject("btnJogBR.BackgroundImage"), System.Drawing.Image)
        Me.btnJogBR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogBR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogBR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogBR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogBR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogBR.Location = New System.Drawing.Point(131, 102)
        Me.btnJogBR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogBR.Name = "btnJogBR"
        Me.btnJogBR.Size = New System.Drawing.Size(58, 47)
        Me.btnJogBR.TabIndex = 159
        Me.btnJogBR.TabStop = False
        Me.btnJogBR.UseVisualStyleBackColor = True
        '
        'btnJogRight
        '
        Me.btnJogRight.BackgroundImage = CType(resources.GetObject("btnJogRight.BackgroundImage"), System.Drawing.Image)
        Me.btnJogRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogRight.Location = New System.Drawing.Point(131, 52)
        Me.btnJogRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogRight.Name = "btnJogRight"
        Me.btnJogRight.Size = New System.Drawing.Size(58, 46)
        Me.btnJogRight.TabIndex = 162
        Me.btnJogRight.TabStop = False
        Me.btnJogRight.UseVisualStyleBackColor = True
        '
        'btnJogBL
        '
        Me.btnJogBL.BackgroundImage = CType(resources.GetObject("btnJogBL.BackgroundImage"), System.Drawing.Image)
        Me.btnJogBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogBL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogBL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogBL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogBL.Location = New System.Drawing.Point(3, 102)
        Me.btnJogBL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogBL.Name = "btnJogBL"
        Me.btnJogBL.Size = New System.Drawing.Size(58, 47)
        Me.btnJogBL.TabIndex = 159
        Me.btnJogBL.TabStop = False
        Me.btnJogBL.UseVisualStyleBackColor = True
        '
        'btnJogDn
        '
        Me.btnJogDn.BackgroundImage = CType(resources.GetObject("btnJogDn.BackgroundImage"), System.Drawing.Image)
        Me.btnJogDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJogDn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJogDn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJogDn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJogDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJogDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogDn.Location = New System.Drawing.Point(67, 102)
        Me.btnJogDn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJogDn.Name = "btnJogDn"
        Me.btnJogDn.Size = New System.Drawing.Size(58, 47)
        Me.btnJogDn.TabIndex = 160
        Me.btnJogDn.TabStop = False
        Me.btnJogDn.UseVisualStyleBackColor = True
        '
        'btnjogZup
        '
        Me.btnjogZup.BackgroundImage = CType(resources.GetObject("btnjogZup.BackgroundImage"), System.Drawing.Image)
        Me.btnjogZup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnjogZup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnjogZup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnjogZup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnjogZup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnjogZup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjogZup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnjogZup.Location = New System.Drawing.Point(207, 2)
        Me.btnjogZup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnjogZup.Name = "btnjogZup"
        Me.btnjogZup.Size = New System.Drawing.Size(49, 46)
        Me.btnjogZup.TabIndex = 168
        Me.btnjogZup.TabStop = False
        Me.btnjogZup.Text = "+Z"
        Me.btnjogZup.UseVisualStyleBackColor = True
        '
        'btnjogZdown
        '
        Me.btnjogZdown.BackgroundImage = CType(resources.GetObject("btnjogZdown.BackgroundImage"), System.Drawing.Image)
        Me.btnjogZdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnjogZdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnjogZdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnjogZdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnjogZdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnjogZdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjogZdown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnjogZdown.Location = New System.Drawing.Point(207, 52)
        Me.btnjogZdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnjogZdown.Name = "btnjogZdown"
        Me.btnjogZdown.Size = New System.Drawing.Size(49, 46)
        Me.btnjogZdown.TabIndex = 169
        Me.btnjogZdown.TabStop = False
        Me.btnjogZdown.Text = "-Z"
        Me.btnjogZdown.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(207, 103)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(49, 45)
        Me.btnReset.TabIndex = 170
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblStepSize
        '
        Me.lblStepSize.AutoSize = True
        Me.lblStepSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStepSize.Location = New System.Drawing.Point(146, 4)
        Me.lblStepSize.Name = "lblStepSize"
        Me.lblStepSize.Size = New System.Drawing.Size(103, 16)
        Me.lblStepSize.TabIndex = 165
        Me.lblStepSize.Text = "Step Size (units)"
        '
        'nudJogStep
        '
        Me.nudJogStep.DecimalPlaces = 3
        Me.nudJogStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudJogStep.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudJogStep.Location = New System.Drawing.Point(150, 26)
        Me.nudJogStep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudJogStep.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudJogStep.Name = "nudJogStep"
        Me.nudJogStep.Size = New System.Drawing.Size(92, 22)
        Me.nudJogStep.TabIndex = 171
        Me.nudJogStep.TabStop = False
        '
        'lblJogVel
        '
        Me.lblJogVel.AutoSize = True
        Me.lblJogVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJogVel.Location = New System.Drawing.Point(4, 4)
        Me.lblJogVel.Name = "lblJogVel"
        Me.lblJogVel.Size = New System.Drawing.Size(114, 16)
        Me.lblJogVel.TabIndex = 166
        Me.lblJogVel.Text = "JogVel (units/min)"
        '
        'nudJogVel
        '
        Me.nudJogVel.DecimalPlaces = 1
        Me.nudJogVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudJogVel.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudJogVel.Location = New System.Drawing.Point(6, 26)
        Me.nudJogVel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudJogVel.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudJogVel.Name = "nudJogVel"
        Me.nudJogVel.Size = New System.Drawing.Size(92, 22)
        Me.nudJogVel.TabIndex = 170
        '
        'pnlGoTo
        '
        Me.pnlGoTo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGoTo.Controls.Add(Me.btnGoToZero)
        Me.pnlGoTo.Controls.Add(Me.cbZSafeReturn)
        Me.pnlGoTo.Controls.Add(Me.cbZSafeLift)
        Me.pnlGoTo.Controls.Add(Me.Label107)
        Me.pnlGoTo.Controls.Add(Me.nudGoTOVel)
        Me.pnlGoTo.Controls.Add(Me.tbGoToRot)
        Me.pnlGoTo.Controls.Add(Me.tbGoTOZ)
        Me.pnlGoTo.Controls.Add(Me.tbGoToY)
        Me.pnlGoTo.Controls.Add(Me.tbGoToX)
        Me.pnlGoTo.Controls.Add(Me.cbGoTORot)
        Me.pnlGoTo.Controls.Add(Me.cbGoToZ)
        Me.pnlGoTo.Controls.Add(Me.cbGoToY)
        Me.pnlGoTo.Controls.Add(Me.cbGoToX)
        Me.pnlGoTo.Controls.Add(Me.btnGoTo)
        Me.pnlGoTo.Location = New System.Drawing.Point(6, 21)
        Me.pnlGoTo.Name = "pnlGoTo"
        Me.pnlGoTo.Size = New System.Drawing.Size(265, 218)
        Me.pnlGoTo.TabIndex = 176
        '
        'btnGoToZero
        '
        Me.btnGoToZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoToZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGoToZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGoToZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoToZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToZero.Location = New System.Drawing.Point(146, 65)
        Me.btnGoToZero.Name = "btnGoToZero"
        Me.btnGoToZero.Size = New System.Drawing.Size(76, 52)
        Me.btnGoToZero.TabIndex = 186
        Me.btnGoToZero.Text = "GoTo 0"
        Me.btnGoToZero.UseVisualStyleBackColor = True
        '
        'cbZSafeReturn
        '
        Me.cbZSafeReturn.AutoSize = True
        Me.cbZSafeReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZSafeReturn.Location = New System.Drawing.Point(176, 164)
        Me.cbZSafeReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.cbZSafeReturn.Name = "cbZSafeReturn"
        Me.cbZSafeReturn.Size = New System.Drawing.Size(81, 30)
        Me.cbZSafeReturn.TabIndex = 185
        Me.cbZSafeReturn.TabStop = False
        Me.cbZSafeReturn.Text = "Return Z " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to start pos."
        Me.cbZSafeReturn.UseVisualStyleBackColor = True
        '
        'cbZSafeLift
        '
        Me.cbZSafeLift.AutoSize = True
        Me.cbZSafeLift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZSafeLift.Location = New System.Drawing.Point(156, 148)
        Me.cbZSafeLift.Margin = New System.Windows.Forms.Padding(2)
        Me.cbZSafeLift.Name = "cbZSafeLift"
        Me.cbZSafeLift.Size = New System.Drawing.Size(83, 17)
        Me.cbZSafeLift.TabIndex = 184
        Me.cbZSafeLift.TabStop = False
        Me.cbZSafeLift.Text = "Use SafeZ?"
        Me.cbZSafeLift.UseVisualStyleBackColor = True
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(9, 127)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(101, 13)
        Me.Label107.TabIndex = 180
        Me.Label107.Text = "GoToVel (units/min)"
        '
        'nudGoTOVel
        '
        Me.nudGoTOVel.DecimalPlaces = 1
        Me.nudGoTOVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGoTOVel.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudGoTOVel.Location = New System.Drawing.Point(110, 124)
        Me.nudGoTOVel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudGoTOVel.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudGoTOVel.Name = "nudGoTOVel"
        Me.nudGoTOVel.Size = New System.Drawing.Size(63, 20)
        Me.nudGoTOVel.TabIndex = 179
        '
        'tbGoToRot
        '
        Me.tbGoToRot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGoToRot.Location = New System.Drawing.Point(68, 82)
        Me.tbGoToRot.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGoToRot.Name = "tbGoToRot"
        Me.tbGoToRot.Size = New System.Drawing.Size(62, 21)
        Me.tbGoToRot.TabIndex = 178
        '
        'tbGoTOZ
        '
        Me.tbGoTOZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGoTOZ.Location = New System.Drawing.Point(68, 57)
        Me.tbGoTOZ.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGoTOZ.Name = "tbGoTOZ"
        Me.tbGoTOZ.Size = New System.Drawing.Size(62, 21)
        Me.tbGoTOZ.TabIndex = 177
        '
        'tbGoToY
        '
        Me.tbGoToY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGoToY.Location = New System.Drawing.Point(68, 32)
        Me.tbGoToY.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGoToY.Name = "tbGoToY"
        Me.tbGoToY.Size = New System.Drawing.Size(62, 21)
        Me.tbGoToY.TabIndex = 176
        '
        'tbGoToX
        '
        Me.tbGoToX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGoToX.Location = New System.Drawing.Point(68, 7)
        Me.tbGoToX.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGoToX.Name = "tbGoToX"
        Me.tbGoToX.Size = New System.Drawing.Size(62, 21)
        Me.tbGoToX.TabIndex = 175
        '
        'cbGoTORot
        '
        Me.cbGoTORot.AutoSize = True
        Me.cbGoTORot.Location = New System.Drawing.Point(11, 83)
        Me.cbGoTORot.Name = "cbGoTORot"
        Me.cbGoTORot.Size = New System.Drawing.Size(62, 21)
        Me.cbGoTORot.TabIndex = 4
        Me.cbGoTORot.Text = "Rot: "
        Me.cbGoTORot.UseVisualStyleBackColor = True
        '
        'cbGoToZ
        '
        Me.cbGoToZ.AutoSize = True
        Me.cbGoToZ.Location = New System.Drawing.Point(11, 58)
        Me.cbGoToZ.Name = "cbGoToZ"
        Me.cbGoToZ.Size = New System.Drawing.Size(47, 21)
        Me.cbGoToZ.TabIndex = 3
        Me.cbGoToZ.Text = "Z: "
        Me.cbGoToZ.UseVisualStyleBackColor = True
        '
        'cbGoToY
        '
        Me.cbGoToY.AutoSize = True
        Me.cbGoToY.Location = New System.Drawing.Point(11, 33)
        Me.cbGoToY.Name = "cbGoToY"
        Me.cbGoToY.Size = New System.Drawing.Size(47, 21)
        Me.cbGoToY.TabIndex = 2
        Me.cbGoToY.Text = "Y: "
        Me.cbGoToY.UseVisualStyleBackColor = True
        '
        'cbGoToX
        '
        Me.cbGoToX.AutoSize = True
        Me.cbGoToX.Location = New System.Drawing.Point(11, 8)
        Me.cbGoToX.Name = "cbGoToX"
        Me.cbGoToX.Size = New System.Drawing.Size(47, 21)
        Me.cbGoToX.TabIndex = 1
        Me.cbGoToX.Text = "X: "
        Me.cbGoToX.UseVisualStyleBackColor = True
        '
        'btnGoTo
        '
        Me.btnGoTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGoTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoTo.Location = New System.Drawing.Point(146, 7)
        Me.btnGoTo.Name = "btnGoTo"
        Me.btnGoTo.Size = New System.Drawing.Size(76, 52)
        Me.btnGoTo.TabIndex = 0
        Me.btnGoTo.Text = "Move to Location"
        Me.btnGoTo.UseVisualStyleBackColor = True
        '
        'cbOnTop
        '
        Me.cbOnTop.AutoSize = True
        Me.cbOnTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOnTop.Location = New System.Drawing.Point(16, 3)
        Me.cbOnTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbOnTop.Name = "cbOnTop"
        Me.cbOnTop.Size = New System.Drawing.Size(117, 20)
        Me.cbOnTop.TabIndex = 181
        Me.cbOnTop.TabStop = False
        Me.cbOnTop.Text = "Always on top?"
        Me.cbOnTop.UseVisualStyleBackColor = True
        '
        'rbGoTo
        '
        Me.rbGoTo.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGoTo.AutoSize = True
        Me.rbGoTo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbGoTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbGoTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbGoTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGoTo.Location = New System.Drawing.Point(185, 27)
        Me.rbGoTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbGoTo.Name = "rbGoTo"
        Me.rbGoTo.Size = New System.Drawing.Size(81, 32)
        Me.rbGoTo.TabIndex = 178
        Me.rbGoTo.Text = "Go To ..."
        Me.rbGoTo.UseVisualStyleBackColor = True
        '
        'cbJogEnab
        '
        Me.cbJogEnab.AutoSize = True
        Me.cbJogEnab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJogEnab.Location = New System.Drawing.Point(156, 3)
        Me.cbJogEnab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbJogEnab.Name = "cbJogEnab"
        Me.cbJogEnab.Size = New System.Drawing.Size(96, 20)
        Me.cbJogEnab.TabIndex = 167
        Me.cbJogEnab.TabStop = False
        Me.cbJogEnab.Text = "Enable Jog"
        Me.cbJogEnab.UseVisualStyleBackColor = True
        '
        'rbJogStep
        '
        Me.rbJogStep.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbJogStep.AutoSize = True
        Me.rbJogStep.Checked = True
        Me.rbJogStep.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbJogStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbJogStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbJogStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbJogStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJogStep.Location = New System.Drawing.Point(121, 27)
        Me.rbJogStep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbJogStep.Name = "rbJogStep"
        Me.rbJogStep.Size = New System.Drawing.Size(55, 32)
        Me.rbJogStep.TabIndex = 157
        Me.rbJogStep.TabStop = True
        Me.rbJogStep.Text = "Step"
        Me.rbJogStep.UseVisualStyleBackColor = True
        '
        'rbJogCont
        '
        Me.rbJogCont.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbJogCont.AutoSize = True
        Me.rbJogCont.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbJogCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbJogCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbJogCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbJogCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbJogCont.Location = New System.Drawing.Point(10, 27)
        Me.rbJogCont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbJogCont.Name = "rbJogCont"
        Me.rbJogCont.Size = New System.Drawing.Size(102, 32)
        Me.rbJogCont.TabIndex = 158
        Me.rbJogCont.Text = "Continuous"
        Me.rbJogCont.UseVisualStyleBackColor = True
        '
        'screenUpdateTimer
        '
        Me.screenUpdateTimer.Enabled = True
        Me.screenUpdateTimer.Interval = 200
        '
        'JogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 308)
        Me.Controls.Add(Me.GroupBox25)
        Me.Controls.Add(Me.cbOnTop)
        Me.Controls.Add(Me.cbJogEnab)
        Me.Controls.Add(Me.rbGoTo)
        Me.Controls.Add(Me.rbJogStep)
        Me.Controls.Add(Me.rbJogCont)
        Me.Name = "JogBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JogBox"
        Me.TopMost = True
        Me.GroupBox25.ResumeLayout(False)
        Me.pnlJogBtn.ResumeLayout(False)
        Me.pnlJogBtn.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nudJogStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJogVel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGoTo.ResumeLayout(False)
        Me.pnlGoTo.PerformLayout()
        CType(Me.nudGoTOVel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox25 As Windows.Forms.GroupBox
    Friend WithEvents pnlGoTo As Windows.Forms.Panel
    Friend WithEvents btnGoToZero As Windows.Forms.Button
    Friend WithEvents cbZSafeReturn As Windows.Forms.CheckBox
    Friend WithEvents cbZSafeLift As Windows.Forms.CheckBox
    Friend WithEvents Label107 As Windows.Forms.Label
    Friend WithEvents nudGoTOVel As Windows.Forms.NumericUpDown
    Friend WithEvents tbGoToRot As Windows.Forms.TextBox
    Friend WithEvents tbGoTOZ As Windows.Forms.TextBox
    Friend WithEvents tbGoToY As Windows.Forms.TextBox
    Friend WithEvents tbGoToX As Windows.Forms.TextBox
    Friend WithEvents cbGoTORot As Windows.Forms.CheckBox
    Friend WithEvents cbGoToZ As Windows.Forms.CheckBox
    Friend WithEvents cbGoToY As Windows.Forms.CheckBox
    Friend WithEvents cbGoToX As Windows.Forms.CheckBox
    Friend WithEvents btnGoTo As Windows.Forms.Button
    Friend WithEvents rbGoTo As Windows.Forms.RadioButton
    Friend WithEvents pnlJogBtn As Windows.Forms.Panel
    Friend WithEvents btnJogUp As Windows.Forms.Button
    Friend WithEvents btnJogLeft As Windows.Forms.Button
    Friend WithEvents btnJogRight As Windows.Forms.Button
    Friend WithEvents lblStepSize As Windows.Forms.Label
    Friend WithEvents nudJogStep As Windows.Forms.NumericUpDown
    Friend WithEvents lblJogVel As Windows.Forms.Label
    Friend WithEvents nudJogVel As Windows.Forms.NumericUpDown
    Friend WithEvents btnJogDn As Windows.Forms.Button
    Friend WithEvents btnjogZdown As Windows.Forms.Button
    Friend WithEvents btnjogZup As Windows.Forms.Button
    Friend WithEvents cbJogEnab As Windows.Forms.CheckBox
    Friend WithEvents rbJogStep As Windows.Forms.RadioButton
    Friend WithEvents rbJogCont As Windows.Forms.RadioButton
    Friend WithEvents btnJogBR As Windows.Forms.Button
    Friend WithEvents btnJogUR As Windows.Forms.Button
    Friend WithEvents btnJogBL As Windows.Forms.Button
    Friend WithEvents btnJogUL As Windows.Forms.Button
    Friend WithEvents cbOnTop As Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReset As Windows.Forms.Button
    Friend WithEvents screenUpdateTimer As Windows.Forms.Timer
End Class
