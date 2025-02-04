<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddChild
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddChild))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ts_member = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_add = New System.Windows.Forms.ToolStripButton
        Me.ts_edit = New System.Windows.Forms.ToolStripButton
        Me.ts_delete = New System.Windows.Forms.ToolStripButton
        Me.ts_supp = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tslbl_status = New System.Windows.Forms.ToolStripStatusLabel
        Me.CustomGroupBox4 = New MSAscribe.CustomGroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.rbtn_fmale = New System.Windows.Forms.RadioButton
        Me.rbtn_male = New System.Windows.Forms.RadioButton
        Me.txt_dob = New System.Windows.Forms.MaskedTextBox
        Me.dt_dob = New System.Windows.Forms.DateTimePicker
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.CustomGroupBox3 = New MSAscribe.CustomGroupBox
        Me.dgv_details = New System.Windows.Forms.DataGridView
        Me.CustomGroupBox2 = New MSAscribe.CustomGroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_residence = New System.Windows.Forms.TextBox
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_pcode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_pname = New System.Windows.Forms.TextBox
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.CustomGroupBox4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.CustomGroupBox3.SuspendLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomGroupBox2.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer)))
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_member, Me.ToolStripSeparator3, Me.ts_add, Me.ts_edit, Me.ts_delete, Me.ts_supp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(901, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_member
        '
        Me.ts_member.Image = Global.MSAscribe.My.Resources.Resources.usermat30
        Me.ts_member.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_member.Name = "ts_member"
        Me.ts_member.Size = New System.Drawing.Size(106, 22)
        Me.ts_member.Text = "Select Member"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ts_add
        '
        Me.ts_add.Image = Global.MSAscribe.My.Resources.Resources.savemat48
        Me.ts_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_add.Name = "ts_add"
        Me.ts_add.Size = New System.Drawing.Size(81, 22)
        Me.ts_add.Text = "Save Entry"
        '
        'ts_edit
        '
        Me.ts_edit.Image = Global.MSAscribe.My.Resources.Resources.editmat48
        Me.ts_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_edit.Name = "ts_edit"
        Me.ts_edit.Size = New System.Drawing.Size(50, 22)
        Me.ts_edit.Text = "Edit "
        '
        'ts_delete
        '
        Me.ts_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_delete.Image = Global.MSAscribe.My.Resources.Resources.deletemat48
        Me.ts_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_delete.Name = "ts_delete"
        Me.ts_delete.Size = New System.Drawing.Size(23, 22)
        Me.ts_delete.Text = "Delete Transaction"
        Me.ts_delete.Visible = False
        '
        'ts_supp
        '
        Me.ts_supp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_supp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_supp.Name = "ts_supp"
        Me.ts_supp.Size = New System.Drawing.Size(23, 22)
        Me.ts_supp.Text = "ToolStripButton1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 28)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(414, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "New Child"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 421)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(901, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslbl_status
        '
        Me.tslbl_status.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tslbl_status.Name = "tslbl_status"
        Me.tslbl_status.Size = New System.Drawing.Size(92, 17)
        Me.tslbl_status.Text = "Contributed : 0  "
        '
        'CustomGroupBox4
        '
        Me.CustomGroupBox4.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox4.Controls.Add(Me.Label16)
        Me.CustomGroupBox4.Controls.Add(Me.Panel7)
        Me.CustomGroupBox4.Controls.Add(Me.txt_dob)
        Me.CustomGroupBox4.Controls.Add(Me.dt_dob)
        Me.CustomGroupBox4.Controls.Add(Me.Label36)
        Me.CustomGroupBox4.Controls.Add(Me.Label1)
        Me.CustomGroupBox4.Controls.Add(Me.txt_lname)
        Me.CustomGroupBox4.Controls.Add(Me.Label4)
        Me.CustomGroupBox4.Controls.Add(Me.txt_fname)
        Me.CustomGroupBox4.Location = New System.Drawing.Point(473, 59)
        Me.CustomGroupBox4.Name = "CustomGroupBox4"
        Me.CustomGroupBox4.Size = New System.Drawing.Size(423, 168)
        Me.CustomGroupBox4.TabIndex = 9
        Me.CustomGroupBox4.TabStop = False
        Me.CustomGroupBox4.Text = "Childs Details    "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Gender"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rbtn_fmale)
        Me.Panel7.Controls.Add(Me.rbtn_male)
        Me.Panel7.Location = New System.Drawing.Point(124, 71)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(189, 32)
        Me.Panel7.TabIndex = 2
        '
        'rbtn_fmale
        '
        Me.rbtn_fmale.AutoSize = True
        Me.rbtn_fmale.Location = New System.Drawing.Point(71, 7)
        Me.rbtn_fmale.Name = "rbtn_fmale"
        Me.rbtn_fmale.Size = New System.Drawing.Size(59, 17)
        Me.rbtn_fmale.TabIndex = 1
        Me.rbtn_fmale.TabStop = True
        Me.rbtn_fmale.Text = "Female"
        Me.rbtn_fmale.UseVisualStyleBackColor = True
        '
        'rbtn_male
        '
        Me.rbtn_male.AutoSize = True
        Me.rbtn_male.Location = New System.Drawing.Point(10, 7)
        Me.rbtn_male.Name = "rbtn_male"
        Me.rbtn_male.Size = New System.Drawing.Size(48, 17)
        Me.rbtn_male.TabIndex = 0
        Me.rbtn_male.TabStop = True
        Me.rbtn_male.Text = "Male"
        Me.rbtn_male.UseVisualStyleBackColor = True
        '
        'txt_dob
        '
        Me.txt_dob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dob.Location = New System.Drawing.Point(124, 109)
        Me.txt_dob.Mask = "00/00/0000"
        Me.txt_dob.Name = "txt_dob"
        Me.txt_dob.Size = New System.Drawing.Size(108, 20)
        Me.txt_dob.TabIndex = 3
        Me.txt_dob.ValidatingType = GetType(Date)
        '
        'dt_dob
        '
        Me.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dob.Location = New System.Drawing.Point(234, 109)
        Me.dt_dob.Name = "dt_dob"
        Me.dt_dob.Size = New System.Drawing.Size(21, 20)
        Me.dt_dob.TabIndex = 112
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(19, 111)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(68, 13)
        Me.Label36.TabIndex = 111
        Me.Label36.Text = "Date Of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Last Name *"
        '
        'txt_lname
        '
        Me.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lname.Location = New System.Drawing.Point(124, 45)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(262, 20)
        Me.txt_lname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "First Name *"
        '
        'txt_fname
        '
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fname.Location = New System.Drawing.Point(124, 19)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(262, 20)
        Me.txt_fname.TabIndex = 0
        '
        'CustomGroupBox3
        '
        Me.CustomGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CustomGroupBox3.Controls.Add(Me.dgv_details)
        Me.CustomGroupBox3.Location = New System.Drawing.Point(4, 233)
        Me.CustomGroupBox3.Name = "CustomGroupBox3"
        Me.CustomGroupBox3.Size = New System.Drawing.Size(892, 181)
        Me.CustomGroupBox3.TabIndex = 8
        Me.CustomGroupBox3.TabStop = False
        Me.CustomGroupBox3.Text = "Children Details     "
        '
        'dgv_details
        '
        Me.dgv_details.AllowUserToAddRows = False
        Me.dgv_details.AllowUserToDeleteRows = False
        Me.dgv_details.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_details.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_details.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_details.EnableHeadersVisualStyles = False
        Me.dgv_details.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgv_details.Location = New System.Drawing.Point(3, 16)
        Me.dgv_details.Name = "dgv_details"
        Me.dgv_details.ReadOnly = True
        Me.dgv_details.RowHeadersVisible = False
        Me.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_details.Size = New System.Drawing.Size(886, 162)
        Me.dgv_details.TabIndex = 3
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox2.Controls.Add(Me.Label5)
        Me.CustomGroupBox2.Controls.Add(Me.txt_residence)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(4, 140)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(463, 87)
        Me.CustomGroupBox2.TabIndex = 7
        Me.CustomGroupBox2.TabStop = False
        Me.CustomGroupBox2.Text = "Residence Details  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Residence"
        '
        'txt_residence
        '
        Me.txt_residence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_residence.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_residence.Location = New System.Drawing.Point(148, 19)
        Me.txt_residence.Name = "txt_residence"
        Me.txt_residence.Size = New System.Drawing.Size(271, 20)
        Me.txt_residence.TabIndex = 0
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox1.Controls.Add(Me.Button1)
        Me.CustomGroupBox1.Controls.Add(Me.Label13)
        Me.CustomGroupBox1.Controls.Add(Me.txt_pcode)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.Controls.Add(Me.txt_pname)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(4, 59)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(463, 75)
        Me.CustomGroupBox1.TabIndex = 6
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "Parent Details  "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.BackgroundImage = Global.MSAscribe.My.Resources.Resources.personmat24
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Location = New System.Drawing.Point(413, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 21)
        Me.Button1.TabIndex = 102
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "Members Number *"
        '
        'txt_pcode
        '
        Me.txt_pcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pcode.Location = New System.Drawing.Point(148, 45)
        Me.txt_pcode.Name = "txt_pcode"
        Me.txt_pcode.ReadOnly = True
        Me.txt_pcode.Size = New System.Drawing.Size(260, 20)
        Me.txt_pcode.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Parent Name *"
        '
        'txt_pname
        '
        Me.txt_pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pname.Location = New System.Drawing.Point(148, 19)
        Me.txt_pname.Name = "txt_pname"
        Me.txt_pname.ReadOnly = True
        Me.txt_pname.Size = New System.Drawing.Size(260, 20)
        Me.txt_pname.TabIndex = 0
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AddChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 443)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CustomGroupBox4)
        Me.Controls.Add(Me.CustomGroupBox3)
        Me.Controls.Add(Me.CustomGroupBox2)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddChild"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Child"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.CustomGroupBox4.ResumeLayout(False)
        Me.CustomGroupBox4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.CustomGroupBox3.ResumeLayout(False)
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.CustomGroupBox2.PerformLayout()
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_pname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_pcode As System.Windows.Forms.TextBox
    Friend WithEvents CustomGroupBox2 As MSAscribe.CustomGroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_residence As System.Windows.Forms.TextBox
    Friend WithEvents CustomGroupBox3 As MSAscribe.CustomGroupBox
    Friend WithEvents dgv_details As System.Windows.Forms.DataGridView
    Friend WithEvents CustomGroupBox4 As MSAscribe.CustomGroupBox
    Friend WithEvents ts_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslbl_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ts_member As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_supp As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents rbtn_fmale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_male As System.Windows.Forms.RadioButton
    Friend WithEvents txt_dob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dt_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
