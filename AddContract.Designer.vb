<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddContract
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddContract))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbox_conn = New MSAscribe.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.txt_descrip = New System.Windows.Forms.TextBox
        Me.cmb_duration = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbox_conn.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer)))
        '
        'gbox_conn
        '
        Me.gbox_conn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbox_conn.BorderColor = System.Drawing.Color.White
        Me.gbox_conn.Controls.Add(Me.btn_next)
        Me.gbox_conn.Controls.Add(Me.btn_save)
        Me.gbox_conn.Controls.Add(Me.btn_close)
        Me.gbox_conn.ForeColor = System.Drawing.Color.White
        Me.gbox_conn.Location = New System.Drawing.Point(7, 199)
        Me.gbox_conn.Name = "gbox_conn"
        Me.gbox_conn.Size = New System.Drawing.Size(455, 53)
        Me.gbox_conn.TabIndex = 2
        Me.gbox_conn.TabStop = False
        '
        'btn_next
        '
        Me.btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_next.ForeColor = System.Drawing.Color.Black
        Me.btn_next.Location = New System.Drawing.Point(239, 15)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(93, 23)
        Me.btn_next.TabIndex = 7
        Me.btn_next.Text = "Save && Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(136, 15)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 23)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(338, 15)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(93, 23)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.White
        Me.CustomGroupBox1.Controls.Add(Me.txt_name)
        Me.CustomGroupBox1.Controls.Add(Me.Label2)
        Me.CustomGroupBox1.Controls.Add(Me.txt_amount)
        Me.CustomGroupBox1.Controls.Add(Me.txt_descrip)
        Me.CustomGroupBox1.Controls.Add(Me.cmb_duration)
        Me.CustomGroupBox1.Controls.Add(Me.Label1)
        Me.CustomGroupBox1.Controls.Add(Me.Label9)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.ForeColor = System.Drawing.Color.White
        Me.CustomGroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(455, 186)
        Me.CustomGroupBox1.TabIndex = 1
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "Contract Details   "
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Location = New System.Drawing.Point(136, 19)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(293, 20)
        Me.txt_name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Amount *"
        '
        'txt_amount
        '
        Me.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount.Location = New System.Drawing.Point(136, 72)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(126, 20)
        Me.txt_amount.TabIndex = 2
        '
        'txt_descrip
        '
        Me.txt_descrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descrip.Location = New System.Drawing.Point(136, 98)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(293, 57)
        Me.txt_descrip.TabIndex = 3
        '
        'cmb_duration
        '
        Me.cmb_duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_duration.FormattingEnabled = True
        Me.cmb_duration.Items.AddRange(New Object() {"Per Month"})
        Me.cmb_duration.Location = New System.Drawing.Point(136, 45)
        Me.cmb_duration.Name = "cmb_duration"
        Me.cmb_duration.Size = New System.Drawing.Size(223, 21)
        Me.cmb_duration.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "Duration *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "Contract Name *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Description"
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AddContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 260)
        Me.Controls.Add(Me.gbox_conn)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AddContract"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Contract"
        Me.gbox_conn.ResumeLayout(False)
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents gbox_conn As MSAscribe.CustomGroupBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_duration As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
