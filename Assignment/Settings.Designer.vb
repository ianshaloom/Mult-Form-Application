<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.settingspanel = New System.Windows.Forms.Panel()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.theme = New System.Windows.Forms.Button()
        Me.themepanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.theme4 = New System.Windows.Forms.RadioButton()
        Me.theme3 = New System.Windows.Forms.RadioButton()
        Me.theme2 = New System.Windows.Forms.RadioButton()
        Me.theme1 = New System.Windows.Forms.RadioButton()
        Me.savetheme = New System.Windows.Forms.Button()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.themepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'settingspanel
        '
        Me.settingspanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.settingspanel.Location = New System.Drawing.Point(110, 93)
        Me.settingspanel.Name = "settingspanel"
        Me.settingspanel.Size = New System.Drawing.Size(384, 330)
        Me.settingspanel.TabIndex = 22
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.Controls.Add(Me.length)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(600, 29)
        Me.toolbar.TabIndex = 23
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(12, 4)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(81, 20)
        Me.length.TabIndex = 25
        Me.length.Text = "Settings"
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitt.Image = CType(resources.GetObject("exitt.Image"), System.Drawing.Image)
        Me.exitt.Location = New System.Drawing.Point(576, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(24, 29)
        Me.exitt.TabIndex = 5
        Me.exitt.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 25
        Me.BunifuElipse2.TargetControl = Me.settingspanel
        '
        'theme
        '
        Me.theme.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.theme.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.theme.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme.ForeColor = System.Drawing.Color.White
        Me.theme.Location = New System.Drawing.Point(245, 48)
        Me.theme.Name = "theme"
        Me.theme.Size = New System.Drawing.Size(130, 30)
        Me.theme.TabIndex = 24
        Me.theme.Text = "Theme"
        Me.theme.UseVisualStyleBackColor = False
        '
        'themepanel
        '
        Me.themepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.themepanel.Controls.Add(Me.Button2)
        Me.themepanel.Controls.Add(Me.theme4)
        Me.themepanel.Controls.Add(Me.theme3)
        Me.themepanel.Controls.Add(Me.theme2)
        Me.themepanel.Controls.Add(Me.theme1)
        Me.themepanel.Controls.Add(Me.savetheme)
        Me.themepanel.Location = New System.Drawing.Point(110, 93)
        Me.themepanel.Name = "themepanel"
        Me.themepanel.Size = New System.Drawing.Size(384, 330)
        Me.themepanel.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(294, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'theme4
        '
        Me.theme4.AutoSize = True
        Me.theme4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme4.ForeColor = System.Drawing.Color.White
        Me.theme4.Location = New System.Drawing.Point(33, 266)
        Me.theme4.Name = "theme4"
        Me.theme4.Size = New System.Drawing.Size(132, 22)
        Me.theme4.TabIndex = 4
        Me.theme4.Text = "Teal Tomato"
        Me.theme4.UseVisualStyleBackColor = True
        '
        'theme3
        '
        Me.theme3.AutoSize = True
        Me.theme3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme3.ForeColor = System.Drawing.Color.White
        Me.theme3.Location = New System.Drawing.Point(33, 193)
        Me.theme3.Name = "theme3"
        Me.theme3.Size = New System.Drawing.Size(199, 22)
        Me.theme3.TabIndex = 3
        Me.theme3.Text = "Forest Green Yelllow"
        Me.theme3.UseVisualStyleBackColor = True
        '
        'theme2
        '
        Me.theme2.AutoSize = True
        Me.theme2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme2.ForeColor = System.Drawing.Color.White
        Me.theme2.Location = New System.Drawing.Point(33, 120)
        Me.theme2.Name = "theme2"
        Me.theme2.Size = New System.Drawing.Size(202, 22)
        Me.theme2.TabIndex = 2
        Me.theme2.Text = "Royal Blue Peachpuff"
        Me.theme2.UseVisualStyleBackColor = True
        '
        'theme1
        '
        Me.theme1.AutoSize = True
        Me.theme1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theme1.ForeColor = System.Drawing.Color.White
        Me.theme1.Location = New System.Drawing.Point(33, 47)
        Me.theme1.Name = "theme1"
        Me.theme1.Size = New System.Drawing.Size(163, 22)
        Me.theme1.TabIndex = 1
        Me.theme1.Text = "Black and White"
        Me.theme1.UseVisualStyleBackColor = True
        '
        'savetheme
        '
        Me.savetheme.BackColor = System.Drawing.Color.LightSkyBlue
        Me.savetheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savetheme.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savetheme.ForeColor = System.Drawing.Color.White
        Me.savetheme.Location = New System.Drawing.Point(240, 47)
        Me.savetheme.Name = "savetheme"
        Me.savetheme.Size = New System.Drawing.Size(129, 33)
        Me.savetheme.TabIndex = 0
        Me.savetheme.Text = "Save Theme"
        Me.savetheme.UseVisualStyleBackColor = False
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 25
        Me.BunifuElipse3.TargetControl = Me.themepanel
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.theme)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.settingspanel)
        Me.Controls.Add(Me.themepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.themepanel.ResumeLayout(False)
        Me.themepanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents settingspanel As System.Windows.Forms.Panel
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents themepanel As System.Windows.Forms.Panel
    Friend WithEvents theme As System.Windows.Forms.Button
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents theme4 As System.Windows.Forms.RadioButton
    Friend WithEvents theme3 As System.Windows.Forms.RadioButton
    Friend WithEvents theme2 As System.Windows.Forms.RadioButton
    Friend WithEvents theme1 As System.Windows.Forms.RadioButton
    Friend WithEvents savetheme As System.Windows.Forms.Button
    Friend WithEvents length As Label
End Class
