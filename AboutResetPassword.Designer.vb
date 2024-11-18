<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutResetPassword))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbox_conn = New MSAscribe.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.txt_conpasswd = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_passwd = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_uname = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_fname = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.gbox_conn.Controls.Add(Me.btn_close)
        Me.gbox_conn.ForeColor = System.Drawing.Color.White
        Me.gbox_conn.Location = New System.Drawing.Point(7, 161)
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
        Me.btn_next.Text = "Save"
        Me.btn_next.UseVisualStyleBackColor = True
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
        Me.CustomGroupBox1.Controls.Add(Me.txt_conpasswd)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.Controls.Add(Me.txt_passwd)
        Me.CustomGroupBox1.Controls.Add(Me.Label2)
        Me.CustomGroupBox1.Controls.Add(Me.txt_uname)
        Me.CustomGroupBox1.Controls.Add(Me.Label1)
        Me.CustomGroupBox1.Controls.Add(Me.txt_fname)
        Me.CustomGroupBox1.Controls.Add(Me.Label9)
        Me.CustomGroupBox1.ForeColor = System.Drawing.Color.White
        Me.CustomGroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(455, 148)
        Me.CustomGroupBox1.TabIndex = 1
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "User Details   "
        '
        'txt_conpasswd
        '
        Me.txt_conpasswd.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_conpasswd.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_conpasswd.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_conpasswd.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_conpasswd.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_conpasswd.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_conpasswd.Border.Class = "TextBoxBorder"
        Me.txt_conpasswd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_conpasswd.DisabledBackColor = System.Drawing.Color.White
        Me.txt_conpasswd.ForeColor = System.Drawing.Color.Black
        Me.txt_conpasswd.Location = New System.Drawing.Point(121, 97)
        Me.txt_conpasswd.Name = "txt_conpasswd"
        Me.txt_conpasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_conpasswd.PreventEnterBeep = True
        Me.txt_conpasswd.Size = New System.Drawing.Size(281, 20)
        Me.txt_conpasswd.TabIndex = 3
        Me.txt_conpasswd.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Confirm Password *"
        '
        'txt_passwd
        '
        Me.txt_passwd.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_passwd.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_passwd.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_passwd.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_passwd.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_passwd.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_passwd.Border.Class = "TextBoxBorder"
        Me.txt_passwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_passwd.DisabledBackColor = System.Drawing.Color.White
        Me.txt_passwd.ForeColor = System.Drawing.Color.Black
        Me.txt_passwd.Location = New System.Drawing.Point(121, 71)
        Me.txt_passwd.Name = "txt_passwd"
        Me.txt_passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passwd.PreventEnterBeep = True
        Me.txt_passwd.Size = New System.Drawing.Size(281, 20)
        Me.txt_passwd.TabIndex = 2
        Me.txt_passwd.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Password  *"
        '
        'txt_uname
        '
        Me.txt_uname.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_uname.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_uname.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_uname.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_uname.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_uname.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_uname.Border.Class = "TextBoxBorder"
        Me.txt_uname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_uname.DisabledBackColor = System.Drawing.Color.White
        Me.txt_uname.ForeColor = System.Drawing.Color.Black
        Me.txt_uname.Location = New System.Drawing.Point(121, 45)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.PreventEnterBeep = True
        Me.txt_uname.ReadOnly = True
        Me.txt_uname.Size = New System.Drawing.Size(281, 20)
        Me.txt_uname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "User Name *"
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_fname.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fname.Border.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_fname.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fname.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fname.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_fname.Border.Class = "TextBoxBorder"
        Me.txt_fname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_fname.DisabledBackColor = System.Drawing.Color.White
        Me.txt_fname.ForeColor = System.Drawing.Color.Black
        Me.txt_fname.Location = New System.Drawing.Point(121, 19)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PreventEnterBeep = True
        Me.txt_fname.ReadOnly = True
        Me.txt_fname.Size = New System.Drawing.Size(281, 20)
        Me.txt_fname.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "Full Name *"
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AboutResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 222)
        Me.Controls.Add(Me.gbox_conn)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AboutResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.gbox_conn.ResumeLayout(False)
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents gbox_conn As MSAscribe.CustomGroupBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents txt_fname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_uname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_conpasswd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_passwd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
