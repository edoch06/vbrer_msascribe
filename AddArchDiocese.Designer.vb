<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddArchDiocese
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddArchDiocese))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbox_conn = New MSAscribe.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.cmb_diocese = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_code = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_country = New System.Windows.Forms.ComboBox
        Me.CustomPanel1 = New MSAscribe.CustomPanel
        Me.txt_altphone = New System.Windows.Forms.RichTextBox
        Me.CustomPanel2 = New MSAscribe.CustomPanel
        Me.txt_address = New System.Windows.Forms.RichTextBox
        Me.txt_fax = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_website = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_phone = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_email = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_head = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label7 = New System.Windows.Forms.Label
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbox_conn.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.CustomPanel1.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
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
        Me.gbox_conn.BorderColor = System.Drawing.Color.White
        Me.gbox_conn.Controls.Add(Me.btn_next)
        Me.gbox_conn.Controls.Add(Me.btn_save)
        Me.gbox_conn.Controls.Add(Me.btn_close)
        Me.gbox_conn.ForeColor = System.Drawing.Color.White
        Me.gbox_conn.Location = New System.Drawing.Point(7, 232)
        Me.gbox_conn.Name = "gbox_conn"
        Me.gbox_conn.Size = New System.Drawing.Size(706, 53)
        Me.gbox_conn.TabIndex = 2
        Me.gbox_conn.TabStop = False
        '
        'btn_next
        '
        Me.btn_next.ForeColor = System.Drawing.Color.Black
        Me.btn_next.Location = New System.Drawing.Point(490, 15)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(93, 23)
        Me.btn_next.TabIndex = 7
        Me.btn_next.Text = "Save && Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(387, 15)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 23)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(589, 15)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(93, 23)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.White
        Me.CustomGroupBox1.Controls.Add(Me.cmb_diocese)
        Me.CustomGroupBox1.Controls.Add(Me.Label11)
        Me.CustomGroupBox1.Controls.Add(Me.txt_code)
        Me.CustomGroupBox1.Controls.Add(Me.Label2)
        Me.CustomGroupBox1.Controls.Add(Me.cmb_country)
        Me.CustomGroupBox1.Controls.Add(Me.CustomPanel1)
        Me.CustomGroupBox1.Controls.Add(Me.CustomPanel2)
        Me.CustomGroupBox1.Controls.Add(Me.txt_fax)
        Me.CustomGroupBox1.Controls.Add(Me.txt_website)
        Me.CustomGroupBox1.Controls.Add(Me.Label10)
        Me.CustomGroupBox1.Controls.Add(Me.Label9)
        Me.CustomGroupBox1.Controls.Add(Me.Label8)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.Controls.Add(Me.txt_phone)
        Me.CustomGroupBox1.Controls.Add(Me.txt_email)
        Me.CustomGroupBox1.Controls.Add(Me.txt_head)
        Me.CustomGroupBox1.Controls.Add(Me.Label6)
        Me.CustomGroupBox1.Controls.Add(Me.Label5)
        Me.CustomGroupBox1.Controls.Add(Me.Label4)
        Me.CustomGroupBox1.Controls.Add(Me.Label1)
        Me.CustomGroupBox1.Controls.Add(Me.txt_name)
        Me.CustomGroupBox1.Controls.Add(Me.Label7)
        Me.CustomGroupBox1.ForeColor = System.Drawing.Color.White
        Me.CustomGroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(706, 219)
        Me.CustomGroupBox1.TabIndex = 1
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "ArchDiocese Details   "
        '
        'cmb_diocese
        '
        Me.cmb_diocese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_diocese.FormattingEnabled = True
        Me.cmb_diocese.Location = New System.Drawing.Point(89, 45)
        Me.cmb_diocese.Name = "cmb_diocese"
        Me.cmb_diocese.Size = New System.Drawing.Size(239, 21)
        Me.cmb_diocese.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "Diocese *"
        '
        'txt_code
        '
        Me.txt_code.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_code.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_code.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_code.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_code.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_code.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_code.Border.Class = "TextBoxBorder"
        Me.txt_code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_code.DisabledBackColor = System.Drawing.Color.White
        Me.txt_code.ForeColor = System.Drawing.Color.Black
        Me.txt_code.Location = New System.Drawing.Point(89, 75)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.PreventEnterBeep = True
        Me.txt_code.ReadOnly = True
        Me.txt_code.Size = New System.Drawing.Size(239, 20)
        Me.txt_code.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Code *"
        '
        'cmb_country
        '
        Me.cmb_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_country.FormattingEnabled = True
        Me.cmb_country.Location = New System.Drawing.Point(89, 104)
        Me.cmb_country.Name = "cmb_country"
        Me.cmb_country.Size = New System.Drawing.Size(239, 21)
        Me.cmb_country.TabIndex = 3
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderColor = System.Drawing.Color.Empty
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.BorderWidth = 0
        Me.CustomPanel1.Controls.Add(Me.txt_altphone)
        Me.CustomPanel1.Location = New System.Drawing.Point(445, 21)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(239, 27)
        Me.CustomPanel1.TabIndex = 188
        '
        'txt_altphone
        '
        Me.txt_altphone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_altphone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_altphone.Location = New System.Drawing.Point(0, 0)
        Me.txt_altphone.Name = "txt_altphone"
        Me.txt_altphone.Size = New System.Drawing.Size(237, 25)
        Me.txt_altphone.TabIndex = 0
        Me.txt_altphone.Text = ""
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BorderColor = System.Drawing.Color.Empty
        Me.CustomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel2.BorderWidth = 0
        Me.CustomPanel2.Controls.Add(Me.txt_address)
        Me.CustomPanel2.Location = New System.Drawing.Point(445, 107)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(239, 61)
        Me.CustomPanel2.TabIndex = 187
        '
        'txt_address
        '
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_address.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_address.Location = New System.Drawing.Point(0, 0)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(237, 59)
        Me.txt_address.TabIndex = 0
        Me.txt_address.Text = ""
        '
        'txt_fax
        '
        Me.txt_fax.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_fax.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fax.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_fax.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fax.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fax.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fax.Border.Class = "TextBoxBorder"
        Me.txt_fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_fax.DisabledBackColor = System.Drawing.Color.White
        Me.txt_fax.ForeColor = System.Drawing.Color.Black
        Me.txt_fax.Location = New System.Drawing.Point(445, 80)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.PreventEnterBeep = True
        Me.txt_fax.Size = New System.Drawing.Size(239, 20)
        Me.txt_fax.TabIndex = 8
        '
        'txt_website
        '
        Me.txt_website.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_website.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_website.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_website.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_website.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_website.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_website.Border.Class = "TextBoxBorder"
        Me.txt_website.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_website.DisabledBackColor = System.Drawing.Color.White
        Me.txt_website.ForeColor = System.Drawing.Color.Black
        Me.txt_website.Location = New System.Drawing.Point(445, 54)
        Me.txt_website.Name = "txt_website"
        Me.txt_website.PreventEnterBeep = True
        Me.txt_website.Size = New System.Drawing.Size(239, 20)
        Me.txt_website.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(367, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 184
        Me.Label10.Text = "Alt Phones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(367, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "Fax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(367, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Website"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Address"
        '
        'txt_phone
        '
        Me.txt_phone.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_phone.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_phone.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_phone.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_phone.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_phone.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_phone.Border.Class = "TextBoxBorder"
        Me.txt_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_phone.DisabledBackColor = System.Drawing.Color.White
        Me.txt_phone.ForeColor = System.Drawing.Color.Black
        Me.txt_phone.Location = New System.Drawing.Point(89, 184)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.PreventEnterBeep = True
        Me.txt_phone.Size = New System.Drawing.Size(239, 20)
        Me.txt_phone.TabIndex = 6
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_email.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_email.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_email.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_email.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_email.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_email.Border.Class = "TextBoxBorder"
        Me.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_email.DisabledBackColor = System.Drawing.Color.White
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(89, 158)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PreventEnterBeep = True
        Me.txt_email.Size = New System.Drawing.Size(239, 20)
        Me.txt_email.TabIndex = 5
        '
        'txt_head
        '
        Me.txt_head.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_head.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_head.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_head.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_head.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_head.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_head.Border.Class = "TextBoxBorder"
        Me.txt_head.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_head.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_head.DisabledBackColor = System.Drawing.Color.White
        Me.txt_head.ForeColor = System.Drawing.Color.Black
        Me.txt_head.Location = New System.Drawing.Point(89, 132)
        Me.txt_head.Name = "txt_head"
        Me.txt_head.PreventEnterBeep = True
        Me.txt_head.Size = New System.Drawing.Size(239, 20)
        Me.txt_head.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Email "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Head"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Location *"
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
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.DisabledBackColor = System.Drawing.Color.White
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(89, 19)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PreventEnterBeep = True
        Me.txt_name.Size = New System.Drawing.Size(239, 20)
        Me.txt_name.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Name *"
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AddArchDiocese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 293)
        Me.Controls.Add(Me.gbox_conn)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AddArchDiocese"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add ArchDiocese"
        Me.gbox_conn.ResumeLayout(False)
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents gbox_conn As MSAscribe.CustomGroupBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents txt_phone As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_email As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_head As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CustomPanel1 As MSAscribe.CustomPanel
    Friend WithEvents txt_altphone As System.Windows.Forms.RichTextBox
    Friend WithEvents CustomPanel2 As MSAscribe.CustomPanel
    Friend WithEvents txt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_fax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_website As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_country As System.Windows.Forms.ComboBox
    Friend WithEvents txt_code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_diocese As System.Windows.Forms.ComboBox
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
