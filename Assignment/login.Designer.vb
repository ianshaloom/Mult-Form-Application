<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.passwrd = New System.Windows.Forms.Label()
        Me.iconn = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.usernamee = New System.Windows.Forms.Label()
        Me.loginn = New System.Windows.Forms.Button()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.loginpanel.SuspendLayout()
        CType(Me.iconn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'loginpanel
        '
        Me.loginpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginpanel.Controls.Add(Me.TextBox2)
        Me.loginpanel.Controls.Add(Me.passwrd)
        Me.loginpanel.Controls.Add(Me.iconn)
        Me.loginpanel.Controls.Add(Me.TextBox1)
        Me.loginpanel.Controls.Add(Me.usernamee)
        Me.loginpanel.Controls.Add(Me.loginn)
        Me.loginpanel.Location = New System.Drawing.Point(105, 34)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(388, 376)
        Me.loginpanel.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(32, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(322, 20)
        Me.TextBox2.TabIndex = 6
        '
        'passwrd
        '
        Me.passwrd.AutoSize = True
        Me.passwrd.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwrd.ForeColor = System.Drawing.Color.White
        Me.passwrd.Location = New System.Drawing.Point(22, 230)
        Me.passwrd.Name = "passwrd"
        Me.passwrd.Size = New System.Drawing.Size(91, 20)
        Me.passwrd.TabIndex = 5
        Me.passwrd.Text = "Password"
        '
        'iconn
        '
        Me.iconn.Image = CType(resources.GetObject("iconn.Image"), System.Drawing.Image)
        Me.iconn.Location = New System.Drawing.Point(128, 15)
        Me.iconn.Name = "iconn"
        Me.iconn.Size = New System.Drawing.Size(128, 128)
        Me.iconn.TabIndex = 4
        Me.iconn.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 20)
        Me.TextBox1.TabIndex = 3
        '
        'usernamee
        '
        Me.usernamee.AutoSize = True
        Me.usernamee.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamee.ForeColor = System.Drawing.Color.White
        Me.usernamee.Location = New System.Drawing.Point(22, 152)
        Me.usernamee.Name = "usernamee"
        Me.usernamee.Size = New System.Drawing.Size(97, 20)
        Me.usernamee.TabIndex = 2
        Me.usernamee.Text = "Username"
        '
        'loginn
        '
        Me.loginn.BackColor = System.Drawing.Color.LightBlue
        Me.loginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginn.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginn.ForeColor = System.Drawing.Color.White
        Me.loginn.Location = New System.Drawing.Point(32, 323)
        Me.loginn.Name = "loginn"
        Me.loginn.Size = New System.Drawing.Size(322, 40)
        Me.loginn.TabIndex = 0
        Me.loginn.Text = "Login"
        Me.loginn.UseVisualStyleBackColor = False
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
        Me.toolbar.TabIndex = 20
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(271, 3)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(70, 20)
        Me.length.TabIndex = 21
        Me.length.Text = "LOG IN"
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.White
        Me.exitt.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitt.Image = CType(resources.GetObject("exitt.Image"), System.Drawing.Image)
        Me.exitt.Location = New System.Drawing.Point(576, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(24, 29)
        Me.exitt.TabIndex = 5
        Me.exitt.TabStop = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.loginpanel
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.toolbar
        Me.BunifuDragControl1.Vertical = True
        '
        'login
        '
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.loginpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        CType(Me.iconn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents loginpanel As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents passwrd As System.Windows.Forms.Label
    Friend WithEvents iconn As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents usernamee As System.Windows.Forms.Label
    Friend WithEvents loginn As System.Windows.Forms.Button
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents length As Label
End Class
