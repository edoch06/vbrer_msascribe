<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddContributon
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddContributon))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ts_edit = New System.Windows.Forms.ToolStripButton
        Me.ts_delete = New System.Windows.Forms.ToolStripButton
        Me.ts_cancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_supp = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tslbl_status = New System.Windows.Forms.ToolStripStatusLabel
        Me.btn_cash = New System.Windows.Forms.Button
        Me.btn_cheque = New System.Windows.Forms.Button
        Me.btn_mobile = New System.Windows.Forms.Button
        Me.btn_card = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.CustomGroupBox5 = New MSAscribe.CustomGroupBox
        Me.dgv_items = New System.Windows.Forms.DataGridView
        Me.CustomGroupBox4 = New MSAscribe.CustomGroupBox
        Me.lbl_print = New System.Windows.Forms.Label
        Me.txt_refno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CustomGroupBox3 = New MSAscribe.CustomGroupBox
        Me.dgv_details = New System.Windows.Forms.DataGridView
        Me.CustomGroupBox2 = New MSAscribe.CustomGroupBox
        Me.lbl_cash = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_amntcollected = New System.Windows.Forms.TextBox
        Me.cmb_subaccount = New System.Windows.Forms.ComboBox
        Me.cmb_account = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.btn_searchm = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_code = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.cmb_votehead = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.CustomGroupBox5.SuspendLayout()
        CType(Me.dgv_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomGroupBox4.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_edit, Me.ts_delete, Me.ts_cancel, Me.ToolStripSeparator2, Me.ts_supp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1090, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_edit
        '
        Me.ts_edit.Image = Global.MSAscribe.My.Resources.Resources.editmat48
        Me.ts_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_edit.Name = "ts_edit"
        Me.ts_edit.Size = New System.Drawing.Size(112, 22)
        Me.ts_edit.Text = "Edit Transaction"
        '
        'ts_delete
        '
        Me.ts_delete.Image = Global.MSAscribe.My.Resources.Resources.deletemat48
        Me.ts_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_delete.Name = "ts_delete"
        Me.ts_delete.Size = New System.Drawing.Size(125, 22)
        Me.ts_delete.Text = "Delete Transaction"
        '
        'ts_cancel
        '
        Me.ts_cancel.Image = Global.MSAscribe.My.Resources.Resources.cancelmat48
        Me.ts_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_cancel.Name = "ts_cancel"
        Me.ts_cancel.Size = New System.Drawing.Size(128, 22)
        Me.ts_cancel.Text = "Cancel Transaction"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.Panel1.Size = New System.Drawing.Size(1090, 28)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(457, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "New Members Contribution"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 486)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1090, 22)
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
        'btn_cash
        '
        Me.btn_cash.ForeColor = System.Drawing.Color.Black
        Me.btn_cash.Location = New System.Drawing.Point(473, 203)
        Me.btn_cash.Name = "btn_cash"
        Me.btn_cash.Size = New System.Drawing.Size(106, 23)
        Me.btn_cash.TabIndex = 12
        Me.btn_cash.Text = "F1 - Cash"
        Me.ToolTip1.SetToolTip(Me.btn_cash, "Click or F1 for cash payments")
        Me.btn_cash.UseVisualStyleBackColor = True
        '
        'btn_cheque
        '
        Me.btn_cheque.ForeColor = System.Drawing.Color.Black
        Me.btn_cheque.Location = New System.Drawing.Point(582, 203)
        Me.btn_cheque.Name = "btn_cheque"
        Me.btn_cheque.Size = New System.Drawing.Size(106, 23)
        Me.btn_cheque.TabIndex = 13
        Me.btn_cheque.Text = "F2 - Cheque"
        Me.ToolTip1.SetToolTip(Me.btn_cheque, "Click or F2 for cheque payments")
        Me.btn_cheque.UseVisualStyleBackColor = True
        '
        'btn_mobile
        '
        Me.btn_mobile.ForeColor = System.Drawing.Color.Black
        Me.btn_mobile.Location = New System.Drawing.Point(582, 232)
        Me.btn_mobile.Name = "btn_mobile"
        Me.btn_mobile.Size = New System.Drawing.Size(106, 23)
        Me.btn_mobile.TabIndex = 15
        Me.btn_mobile.Text = "F4 - Mobile Money"
        Me.ToolTip1.SetToolTip(Me.btn_mobile, "Click or F4 for mobile payments")
        Me.btn_mobile.UseVisualStyleBackColor = True
        '
        'btn_card
        '
        Me.btn_card.ForeColor = System.Drawing.Color.Black
        Me.btn_card.Location = New System.Drawing.Point(473, 232)
        Me.btn_card.Name = "btn_card"
        Me.btn_card.Size = New System.Drawing.Size(106, 23)
        Me.btn_card.TabIndex = 14
        Me.btn_card.Text = "F3 - Card"
        Me.ToolTip1.SetToolTip(Me.btn_card, "Click or F3 for card payments")
        Me.btn_card.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(991, 104)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 23)
        Me.btn_save.TabIndex = 16
        Me.btn_save.Text = "F9 - Post"
        Me.ToolTip1.SetToolTip(Me.btn_save, "Click or F9 to post contribution")
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(994, 75)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(93, 23)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "F10 - Remove"
        Me.ToolTip1.SetToolTip(Me.btn_delete, "Click or F10 to remove an item")
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Location = New System.Drawing.Point(899, 75)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(93, 23)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "F8 - Edit"
        Me.ToolTip1.SetToolTip(Me.btn_edit, "Click or F8 to edit an item")
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Location = New System.Drawing.Point(804, 75)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(93, 23)
        Me.btn_add.TabIndex = 18
        Me.btn_add.Text = "F7 - Add"
        Me.ToolTip1.SetToolTip(Me.btn_add, "Click or F7 to add an item")
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'CustomGroupBox5
        '
        Me.CustomGroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CustomGroupBox5.Controls.Add(Me.dgv_items)
        Me.CustomGroupBox5.Location = New System.Drawing.Point(783, 133)
        Me.CustomGroupBox5.Name = "CustomGroupBox5"
        Me.CustomGroupBox5.Size = New System.Drawing.Size(304, 350)
        Me.CustomGroupBox5.TabIndex = 17
        Me.CustomGroupBox5.TabStop = False
        Me.CustomGroupBox5.Text = "Contribution Items Details     "
        '
        'dgv_items
        '
        Me.dgv_items.AllowUserToAddRows = False
        Me.dgv_items.AllowUserToDeleteRows = False
        Me.dgv_items.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_items.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_items.EnableHeadersVisualStyles = False
        Me.dgv_items.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgv_items.Location = New System.Drawing.Point(3, 16)
        Me.dgv_items.Name = "dgv_items"
        Me.dgv_items.ReadOnly = True
        Me.dgv_items.RowHeadersVisible = False
        Me.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_items.Size = New System.Drawing.Size(298, 331)
        Me.dgv_items.TabIndex = 3
        '
        'CustomGroupBox4
        '
        Me.CustomGroupBox4.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox4.Controls.Add(Me.lbl_print)
        Me.CustomGroupBox4.Controls.Add(Me.txt_refno)
        Me.CustomGroupBox4.Controls.Add(Me.Label6)
        Me.CustomGroupBox4.Location = New System.Drawing.Point(473, 59)
        Me.CustomGroupBox4.Name = "CustomGroupBox4"
        Me.CustomGroupBox4.Size = New System.Drawing.Size(304, 141)
        Me.CustomGroupBox4.TabIndex = 9
        Me.CustomGroupBox4.TabStop = False
        Me.CustomGroupBox4.Text = "Enter Transaction    "
        '
        'lbl_print
        '
        Me.lbl_print.AutoSize = True
        Me.lbl_print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_print.Location = New System.Drawing.Point(17, 107)
        Me.lbl_print.Name = "lbl_print"
        Me.lbl_print.Size = New System.Drawing.Size(186, 13)
        Me.lbl_print.TabIndex = 209
        Me.lbl_print.Text = "Processing Payments ..... Please Wait"
        Me.lbl_print.Visible = False
        '
        'txt_refno
        '
        Me.txt_refno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_refno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_refno.Location = New System.Drawing.Point(44, 45)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.ReadOnly = True
        Me.txt_refno.Size = New System.Drawing.Size(219, 20)
        Me.txt_refno.TabIndex = 200
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 207
        Me.Label6.Text = "Transaction Ref #"
        '
        'CustomGroupBox3
        '
        Me.CustomGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CustomGroupBox3.Controls.Add(Me.dgv_details)
        Me.CustomGroupBox3.Location = New System.Drawing.Point(4, 300)
        Me.CustomGroupBox3.Name = "CustomGroupBox3"
        Me.CustomGroupBox3.Size = New System.Drawing.Size(773, 181)
        Me.CustomGroupBox3.TabIndex = 8
        Me.CustomGroupBox3.TabStop = False
        Me.CustomGroupBox3.Text = "Payment Details     "
        '
        'dgv_details
        '
        Me.dgv_details.AllowUserToAddRows = False
        Me.dgv_details.AllowUserToDeleteRows = False
        Me.dgv_details.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_details.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_details.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_details.EnableHeadersVisualStyles = False
        Me.dgv_details.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgv_details.Location = New System.Drawing.Point(3, 16)
        Me.dgv_details.Name = "dgv_details"
        Me.dgv_details.ReadOnly = True
        Me.dgv_details.RowHeadersVisible = False
        Me.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_details.Size = New System.Drawing.Size(767, 162)
        Me.dgv_details.TabIndex = 3
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox2.Controls.Add(Me.cmb_votehead)
        Me.CustomGroupBox2.Controls.Add(Me.Label7)
        Me.CustomGroupBox2.Controls.Add(Me.Label5)
        Me.CustomGroupBox2.Controls.Add(Me.txt_amntcollected)
        Me.CustomGroupBox2.Controls.Add(Me.cmb_subaccount)
        Me.CustomGroupBox2.Controls.Add(Me.cmb_account)
        Me.CustomGroupBox2.Controls.Add(Me.Label1)
        Me.CustomGroupBox2.Controls.Add(Me.Label4)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(4, 140)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(463, 158)
        Me.CustomGroupBox2.TabIndex = 7
        Me.CustomGroupBox2.TabStop = False
        Me.CustomGroupBox2.Text = "Contribution Details  "
        '
        'lbl_cash
        '
        Me.lbl_cash.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.lbl_cash.Location = New System.Drawing.Point(473, 278)
        Me.lbl_cash.Name = "lbl_cash"
        Me.lbl_cash.Size = New System.Drawing.Size(294, 19)
        Me.lbl_cash.TabIndex = 61
        Me.lbl_cash.Text = "Cash"
        Me.lbl_cash.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Total Amount Expected *"
        '
        'txt_amntcollected
        '
        Me.txt_amntcollected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amntcollected.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_amntcollected.Location = New System.Drawing.Point(148, 105)
        Me.txt_amntcollected.Name = "txt_amntcollected"
        Me.txt_amntcollected.ReadOnly = True
        Me.txt_amntcollected.Size = New System.Drawing.Size(168, 20)
        Me.txt_amntcollected.TabIndex = 3
        '
        'cmb_subaccount
        '
        Me.cmb_subaccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_subaccount.FormattingEnabled = True
        Me.cmb_subaccount.Location = New System.Drawing.Point(148, 78)
        Me.cmb_subaccount.Name = "cmb_subaccount"
        Me.cmb_subaccount.Size = New System.Drawing.Size(265, 21)
        Me.cmb_subaccount.TabIndex = 2
        '
        'cmb_account
        '
        Me.cmb_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_account.FormattingEnabled = True
        Me.cmb_account.Location = New System.Drawing.Point(148, 51)
        Me.cmb_account.Name = "cmb_account"
        Me.cmb_account.Size = New System.Drawing.Size(265, 21)
        Me.cmb_account.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Sub Account *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Account *"
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox1.Controls.Add(Me.btn_searchm)
        Me.CustomGroupBox1.Controls.Add(Me.Label13)
        Me.CustomGroupBox1.Controls.Add(Me.txt_code)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.Controls.Add(Me.txt_name)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(4, 59)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(463, 75)
        Me.CustomGroupBox1.TabIndex = 6
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "Members Details  "
        '
        'btn_searchm
        '
        Me.btn_searchm.BackColor = System.Drawing.Color.LightGray
        Me.btn_searchm.BackgroundImage = Global.MSAscribe.My.Resources.Resources.personmat24
        Me.btn_searchm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_searchm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_searchm.FlatAppearance.BorderSize = 0
        Me.btn_searchm.Location = New System.Drawing.Point(420, 19)
        Me.btn_searchm.Name = "btn_searchm"
        Me.btn_searchm.Size = New System.Drawing.Size(23, 21)
        Me.btn_searchm.TabIndex = 100
        Me.btn_searchm.UseVisualStyleBackColor = False
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
        'txt_code
        '
        Me.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_code.Location = New System.Drawing.Point(148, 45)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.ReadOnly = True
        Me.txt_code.Size = New System.Drawing.Size(265, 20)
        Me.txt_code.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Member Name *"
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Location = New System.Drawing.Point(148, 19)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(265, 20)
        Me.txt_name.TabIndex = 0
        '
        'cmb_votehead
        '
        Me.cmb_votehead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_votehead.FormattingEnabled = True
        Me.cmb_votehead.Location = New System.Drawing.Point(148, 25)
        Me.cmb_votehead.Name = "cmb_votehead"
        Me.cmb_votehead.Size = New System.Drawing.Size(265, 21)
        Me.cmb_votehead.TabIndex = 196
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Vote Head *"
        '
        'AddContributon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1090, 508)
        Me.Controls.Add(Me.lbl_cash)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.CustomGroupBox5)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_mobile)
        Me.Controls.Add(Me.btn_card)
        Me.Controls.Add(Me.btn_cheque)
        Me.Controls.Add(Me.btn_cash)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CustomGroupBox4)
        Me.Controls.Add(Me.CustomGroupBox3)
        Me.Controls.Add(Me.CustomGroupBox2)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AddContributon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Members Contribution"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.CustomGroupBox5.ResumeLayout(False)
        CType(Me.dgv_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomGroupBox4.ResumeLayout(False)
        Me.CustomGroupBox4.PerformLayout()
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
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents CustomGroupBox2 As MSAscribe.CustomGroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_amntcollected As System.Windows.Forms.TextBox
    Friend WithEvents CustomGroupBox3 As MSAscribe.CustomGroupBox
    Friend WithEvents dgv_details As System.Windows.Forms.DataGridView
    Friend WithEvents CustomGroupBox4 As MSAscribe.CustomGroupBox
    Friend WithEvents ts_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslbl_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ts_cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_supp As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_cash As System.Windows.Forms.Label
    Friend WithEvents cmb_account As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_searchm As System.Windows.Forms.Button
    Friend WithEvents btn_cash As System.Windows.Forms.Button
    Friend WithEvents btn_cheque As System.Windows.Forms.Button
    Friend WithEvents btn_mobile As System.Windows.Forms.Button
    Friend WithEvents btn_card As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_refno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents CustomGroupBox5 As MSAscribe.CustomGroupBox
    Friend WithEvents dgv_items As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents cmb_subaccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_print As System.Windows.Forms.Label
    Friend WithEvents cmb_votehead As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
