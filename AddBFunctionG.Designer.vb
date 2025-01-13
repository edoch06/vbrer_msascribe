<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBFunctionG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBFunctionG))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ts_refresh = New System.Windows.Forms.ToolStrip
        Me.ts_selectgrp = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_add = New System.Windows.Forms.ToolStripButton
        Me.ts_edit = New System.Windows.Forms.ToolStripButton
        Me.ts_delete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_add2 = New System.Windows.Forms.ToolStripButton
        Me.ts_del2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.IDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.CustomGroupBox2 = New MSAscribe.CustomGroupBox
        Me.chk_selectallgrp = New System.Windows.Forms.CheckBox
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgv_mod = New System.Windows.Forms.DataGridView
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.chk_selectall = New System.Windows.Forms.CheckBox
        Me.dgv_details = New System.Windows.Forms.DataGridView
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.ts_refresh.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        CType(Me.dgv_mod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomGroupBox1.SuspendLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer)))
        '
        'ts_refresh
        '
        Me.ts_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ts_refresh.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_refresh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_selectgrp, Me.ToolStripSeparator2, Me.ts_add, Me.ts_edit, Me.ts_delete, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ts_add2, Me.ts_del2, Me.ToolStripSplitButton1})
        Me.ts_refresh.Location = New System.Drawing.Point(0, 0)
        Me.ts_refresh.Name = "ts_refresh"
        Me.ts_refresh.Size = New System.Drawing.Size(726, 25)
        Me.ts_refresh.TabIndex = 0
        Me.ts_refresh.Text = "ToolStrip1"
        '
        'ts_selectgrp
        '
        Me.ts_selectgrp.Image = Global.MSAscribe.My.Resources.Resources.usergrpmat48
        Me.ts_selectgrp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_selectgrp.Name = "ts_selectgrp"
        Me.ts_selectgrp.Size = New System.Drawing.Size(94, 22)
        Me.ts_selectgrp.Text = "Select Group"
        Me.ts_selectgrp.ToolTipText = "Select User Group"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ts_add
        '
        Me.ts_add.Image = Global.MSAscribe.My.Resources.Resources.addmat48
        Me.ts_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_add.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.ts_add.Name = "ts_add"
        Me.ts_add.Size = New System.Drawing.Size(93, 22)
        Me.ts_add.Text = "Add Module"
        Me.ts_add.ToolTipText = "Add function to be blocked from group"
        '
        'ts_edit
        '
        Me.ts_edit.Image = Global.MSAscribe.My.Resources.Resources.editmat48
        Me.ts_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_edit.Name = "ts_edit"
        Me.ts_edit.Size = New System.Drawing.Size(47, 22)
        Me.ts_edit.Text = "Edit"
        Me.ts_edit.ToolTipText = "Edit function"
        '
        'ts_delete
        '
        Me.ts_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_delete.Image = Global.MSAscribe.My.Resources.Resources.deletemat48
        Me.ts_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_delete.Name = "ts_delete"
        Me.ts_delete.Size = New System.Drawing.Size(23, 22)
        Me.ts_delete.Text = "Delete"
        Me.ts_delete.ToolTipText = "Remove function"
        Me.ts_delete.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.MSAscribe.My.Resources.Resources.refreshmat48
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton4.Text = "Refresh"
        Me.ToolStripButton4.ToolTipText = "Refresh view"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ts_add2
        '
        Me.ts_add2.Image = Global.MSAscribe.My.Resources.Resources.checkmat48
        Me.ts_add2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_add2.Name = "ts_add2"
        Me.ts_add2.Size = New System.Drawing.Size(145, 22)
        Me.ts_add2.Text = "Add Selected Modules"
        Me.ts_add2.ToolTipText = "Add selected modules on the left to the selected group"
        '
        'ts_del2
        '
        Me.ts_del2.Image = Global.MSAscribe.My.Resources.Resources.cancelmat48
        Me.ts_del2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_del2.Name = "ts_del2"
        Me.ts_del2.Size = New System.Drawing.Size(150, 22)
        Me.ts_del2.Text = "Delete Seleted Modules"
        Me.ts_del2.ToolTipText = "Remove selected modules on right to the selected group"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem, Me.LabelsToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripSplitButton1.Text = "Sort by"
        Me.ToolStripSplitButton1.ToolTipText = "Click to sort"
        '
        'IDToolStripMenuItem
        '
        Me.IDToolStripMenuItem.Name = "IDToolStripMenuItem"
        Me.IDToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.IDToolStripMenuItem.Text = "ID"
        '
        'LabelsToolStripMenuItem
        '
        Me.LabelsToolStripMenuItem.Name = "LabelsToolStripMenuItem"
        Me.LabelsToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LabelsToolStripMenuItem.Text = "Labels"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 28)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(260, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Add Group Access To Functions"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(726, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox2.Controls.Add(Me.chk_selectallgrp)
        Me.CustomGroupBox2.Controls.Add(Me.txt_name)
        Me.CustomGroupBox2.Controls.Add(Me.Label7)
        Me.CustomGroupBox2.Controls.Add(Me.dgv_mod)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(344, 59)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(378, 350)
        Me.CustomGroupBox2.TabIndex = 7
        Me.CustomGroupBox2.TabStop = False
        Me.CustomGroupBox2.Text = "Available Functions   "
        '
        'chk_selectallgrp
        '
        Me.chk_selectallgrp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_selectallgrp.AutoSize = True
        Me.chk_selectallgrp.Location = New System.Drawing.Point(300, 50)
        Me.chk_selectallgrp.Name = "chk_selectallgrp"
        Me.chk_selectallgrp.Size = New System.Drawing.Size(70, 17)
        Me.chk_selectallgrp.TabIndex = 159
        Me.chk_selectallgrp.Text = "Select All"
        Me.chk_selectallgrp.UseVisualStyleBackColor = True
        Me.chk_selectallgrp.Visible = False
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_name.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_name.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_name.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_name.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_name.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_name.Border.Class = "TextBoxBorder"
        Me.txt_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(104, 27)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PreventEnterBeep = True
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(239, 20)
        Me.txt_name.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Group"
        '
        'dgv_mod
        '
        Me.dgv_mod.AllowUserToAddRows = False
        Me.dgv_mod.AllowUserToDeleteRows = False
        Me.dgv_mod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_mod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_mod.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_mod.EnableHeadersVisualStyles = False
        Me.dgv_mod.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgv_mod.Location = New System.Drawing.Point(3, 71)
        Me.dgv_mod.Name = "dgv_mod"
        Me.dgv_mod.RowHeadersVisible = False
        Me.dgv_mod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mod.Size = New System.Drawing.Size(372, 276)
        Me.dgv_mod.TabIndex = 3
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.CustomGroupBox1.Controls.Add(Me.chk_selectall)
        Me.CustomGroupBox1.Controls.Add(Me.dgv_details)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(4, 59)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(334, 353)
        Me.CustomGroupBox1.TabIndex = 6
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "Available Functions   "
        '
        'chk_selectall
        '
        Me.chk_selectall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_selectall.AutoSize = True
        Me.chk_selectall.Location = New System.Drawing.Point(258, 18)
        Me.chk_selectall.Name = "chk_selectall"
        Me.chk_selectall.Size = New System.Drawing.Size(70, 17)
        Me.chk_selectall.TabIndex = 5
        Me.chk_selectall.Text = "Select All"
        Me.chk_selectall.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_details.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_details.EnableHeadersVisualStyles = False
        Me.dgv_details.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dgv_details.Location = New System.Drawing.Point(3, 41)
        Me.dgv_details.Name = "dgv_details"
        Me.dgv_details.RowHeadersVisible = False
        Me.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_details.Size = New System.Drawing.Size(328, 309)
        Me.dgv_details.TabIndex = 2
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AddBFunctionG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 439)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CustomGroupBox2)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ts_refresh)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddBFunctionG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Group Access To Functions"
        Me.ts_refresh.ResumeLayout(False)
        Me.ts_refresh.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.CustomGroupBox2.PerformLayout()
        CType(Me.dgv_mod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ts_refresh As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ts_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents dgv_details As System.Windows.Forms.DataGridView
    Friend WithEvents CustomGroupBox2 As MSAscribe.CustomGroupBox
    Friend WithEvents dgv_mod As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ts_selectgrp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_del2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts_add2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_selectallgrp As System.Windows.Forms.CheckBox
    Friend WithEvents chk_selectall As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents IDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
