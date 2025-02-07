<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCollections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCollections))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.gbox_conn = New MSAscribe.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.CustomGroupBox1 = New MSAscribe.CustomGroupBox
        Me.CustomPanel2 = New MSAscribe.CustomPanel
        Me.txt_descrip = New System.Windows.Forms.RichTextBox
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TTHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbox_conn.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
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
        Me.gbox_conn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbox_conn.BorderColor = System.Drawing.Color.White
        Me.gbox_conn.Controls.Add(Me.btn_next)
        Me.gbox_conn.Controls.Add(Me.btn_save)
        Me.gbox_conn.Controls.Add(Me.btn_close)
        Me.gbox_conn.ForeColor = System.Drawing.Color.White
        Me.gbox_conn.Location = New System.Drawing.Point(7, 156)
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
        Me.CustomGroupBox1.Controls.Add(Me.CustomPanel2)
        Me.CustomGroupBox1.Controls.Add(Me.txt_name)
        Me.CustomGroupBox1.Controls.Add(Me.Label9)
        Me.CustomGroupBox1.Controls.Add(Me.Label3)
        Me.CustomGroupBox1.ForeColor = System.Drawing.Color.White
        Me.CustomGroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(455, 143)
        Me.CustomGroupBox1.TabIndex = 1
        Me.CustomGroupBox1.TabStop = False
        Me.CustomGroupBox1.Text = "Collection Details   "
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BorderColor = System.Drawing.Color.Empty
        Me.CustomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel2.BorderWidth = 0
        Me.CustomPanel2.Controls.Add(Me.txt_descrip)
        Me.CustomPanel2.Location = New System.Drawing.Point(121, 46)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(239, 61)
        Me.CustomPanel2.TabIndex = 187
        '
        'txt_descrip
        '
        Me.txt_descrip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_descrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_descrip.Location = New System.Drawing.Point(0, 0)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(237, 59)
        Me.txt_descrip.TabIndex = 0
        Me.txt_descrip.Text = ""
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
        Me.txt_name.Location = New System.Drawing.Point(121, 19)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PreventEnterBeep = True
        Me.txt_name.Size = New System.Drawing.Size(308, 20)
        Me.txt_name.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "Collection Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Description"
        '
        'TTHelp
        '
        Me.TTHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(146, Byte), Integer))
        '
        'AddCollections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 217)
        Me.Controls.Add(Me.gbox_conn)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AddCollections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Collections"
        Me.gbox_conn.ResumeLayout(False)
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.CustomPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox1 As MSAscribe.CustomGroupBox
    Friend WithEvents gbox_conn As MSAscribe.CustomGroupBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents CustomPanel2 As MSAscribe.CustomPanel
    Friend WithEvents txt_descrip As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TTHelp As System.Windows.Forms.ToolTip
End Class
