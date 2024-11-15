<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutMeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutMeDetails))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbox_conn = New MSAscribe.CustomGroupBox
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.cmb_usergrp = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btn_change = New System.Windows.Forms.Button
        Me.txt_phoneno = New System.Windows.Forms.TextBox
        Me.CustomPanel4 = New MSAscribe.CustomPanel
        Me.txt_address = New System.Windows.Forms.RichTextBox
        Me.cmb_nationality = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_website = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_fax = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_city = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_phonecode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_county = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_pcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbox_conn.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.CustomPanel4.SuspendLayout()
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
        Me.gbox_conn.Controls.Add(Me.btn_save)
        Me.gbox_conn.Controls.Add(Me.btn_close)
        Me.gbox_conn.ForeColor = System.Drawing.Color.White
        Me.gbox_conn.Location = New System.Drawing.Point(5, 286)
        Me.gbox_conn.Name = "gbox_conn"
        Me.gbox_conn.Size = New System.Drawing.Size(634, 53)
        Me.gbox_conn.TabIndex = 8
        Me.gbox_conn.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(417, 19)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 23)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(516, 19)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(93, 23)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.CustomGroupBox1.Controls.Add(Me.cmb_usergrp)
        Me.CustomGroupBox1.Controls.Add(Me.Label13)
        Me.CustomGroupBox1.Controls.Add(Me.btn_change)
        Me.CustomGroupBox1.Controls.Add(Me.txt_phoneno)
        Me.CustomGroupBox1.Controls.Add(Me.CustomPanel4)
        Me.CustomGroupBox1.Controls.Add(Me.cmb_nationality)
        Me.CustomGroupBox1.Controls.Add(Me.Label12)
        Me.CustomGroupBox1.Controls.Add(Me.txt_website)
        Me.CustomGroupBox1.Controls.Add(Me.Label11)
        Me.CustomGroupBox1.Controls.Add(Me.txt_email)
        Me.CustomGroupBox1.Controls.Add(Me.Label9)
        Me.CustomGroupBox1.Controls.Add(Me.txt_fax)
        Me.CustomGroupBox1.Controls.Add(Me.Label10)
        Me.CustomGroupBox1.Controls.Add(Me.txt_city)
        Me.CustomGroupBox1.Controls.Add(Me.Label7)
        Me.CustomGroupBox1.Controls.Add(Me.Label8)
        Me.CustomGroupBox1.Controls.Add(Me.txt_phonecode)
        Me.CustomGroupBox1.Controls.Add(Me.Label6)
        Me.CustomGroupBox1.Controls.Add(Me.txt_county)
        Me.CustomGroupBox1.Controls.Add(Me.Label5)
        Me.CustomGroupBox1.Controls.Add(Me.txt_pcode)
        Me.CustomGroupBox1.Controls.Add(Me.Label4)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.Controls.Add(Me.txt_name)
        Me.CustomGroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CustomGroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(634, 278)
        Me.CustomGroupBox1.TabIndex = 6
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "User Details  "
        '
        'cmb_usergrp
        '
        Me.cmb_usergrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_usergrp.FormattingEnabled = True
        Me.cmb_usergrp.Location = New System.Drawing.Point(118, 45)
        Me.cmb_usergrp.Name = "cmb_usergrp"
        Me.cmb_usergrp.Size = New System.Drawing.Size(189, 21)
        Me.cmb_usergrp.TabIndex = 102
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "User Group *"
        '
        'btn_change
        '
        Me.btn_change.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change.ForeColor = System.Drawing.Color.Black
        Me.btn_change.Location = New System.Drawing.Point(471, 37)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(126, 28)
        Me.btn_change.TabIndex = 100
        Me.btn_change.Text = "Change Password"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'txt_phoneno
        '
        Me.txt_phoneno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phoneno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phoneno.Location = New System.Drawing.Point(173, 158)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.ReadOnly = True
        Me.txt_phoneno.Size = New System.Drawing.Size(134, 20)
        Me.txt_phoneno.TabIndex = 4
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BorderColor = System.Drawing.Color.Empty
        Me.CustomPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel4.BorderWidth = 0
        Me.CustomPanel4.Controls.Add(Me.txt_address)
        Me.CustomPanel4.Location = New System.Drawing.Point(119, 72)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Size = New System.Drawing.Size(289, 54)
        Me.CustomPanel4.TabIndex = 97
        '
        'txt_address
        '
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_address.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_address.Location = New System.Drawing.Point(0, 0)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(287, 52)
        Me.txt_address.TabIndex = 0
        Me.txt_address.Text = ""
        '
        'cmb_nationality
        '
        Me.cmb_nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nationality.FormattingEnabled = True
        Me.cmb_nationality.Location = New System.Drawing.Point(118, 134)
        Me.cmb_nationality.Name = "cmb_nationality"
        Me.cmb_nationality.Size = New System.Drawing.Size(189, 21)
        Me.cmb_nationality.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Website"
        '
        'txt_website
        '
        Me.txt_website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_website.Location = New System.Drawing.Point(119, 236)
        Me.txt_website.Name = "txt_website"
        Me.txt_website.ReadOnly = True
        Me.txt_website.Size = New System.Drawing.Size(310, 20)
        Me.txt_website.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Email Address"
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_email.Location = New System.Drawing.Point(118, 210)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(310, 20)
        Me.txt_email.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Fax"
        '
        'txt_fax
        '
        Me.txt_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fax.Location = New System.Drawing.Point(394, 183)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.ReadOnly = True
        Me.txt_fax.Size = New System.Drawing.Size(155, 20)
        Me.txt_fax.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "City"
        '
        'txt_city
        '
        Me.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_city.Location = New System.Drawing.Point(119, 184)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.ReadOnly = True
        Me.txt_city.Size = New System.Drawing.Size(188, 20)
        Me.txt_city.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Nationality"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Phone"
        '
        'txt_phonecode
        '
        Me.txt_phonecode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phonecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phonecode.Location = New System.Drawing.Point(119, 158)
        Me.txt_phonecode.Name = "txt_phonecode"
        Me.txt_phonecode.ReadOnly = True
        Me.txt_phonecode.Size = New System.Drawing.Size(49, 20)
        Me.txt_phonecode.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "County"
        '
        'txt_county
        '
        Me.txt_county.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_county.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_county.Location = New System.Drawing.Point(393, 131)
        Me.txt_county.Name = "txt_county"
        Me.txt_county.ReadOnly = True
        Me.txt_county.Size = New System.Drawing.Size(155, 20)
        Me.txt_county.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Postal Code"
        '
        'txt_pcode
        '
        Me.txt_pcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pcode.Location = New System.Drawing.Point(394, 157)
        Me.txt_pcode.Name = "txt_pcode"
        Me.txt_pcode.ReadOnly = True
        Me.txt_pcode.Size = New System.Drawing.Size(154, 20)
        Me.txt_pcode.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "User Name *"
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Location = New System.Drawing.Point(118, 19)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(310, 20)
        Me.txt_name.TabIndex = 0
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AboutMeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 346)
        Me.Controls.Add(Me.gbox_conn)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AboutMeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Me"
        Me.gbox_conn.ResumeLayout(False)
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.CustomPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents cmb_nationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_website As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_phonecode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_county As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_pcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents CustomPanel4 As MSAscribe.CustomPanel
    Friend WithEvents txt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_phoneno As System.Windows.Forms.TextBox
    Friend WithEvents gbox_conn As MSAscribe.CustomGroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_change As System.Windows.Forms.Button
    Friend WithEvents cmb_usergrp As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
