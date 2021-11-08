<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class areaperimeter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(areaperimeter))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.areaperipanel = New System.Windows.Forms.Panel()
        Me.peri = New System.Windows.Forms.Label()
        Me.area = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.widthtb = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.arearadio = New System.Windows.Forms.RadioButton()
        Me.perimeterradio = New System.Windows.Forms.RadioButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.widthh = New System.Windows.Forms.Label()
        Me.lengthtb = New System.Windows.Forms.TextBox()
        Me.length = New System.Windows.Forms.Label()
        Me.calcbutton = New System.Windows.Forms.Button()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.areaperipanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'areaperipanel
        '
        Me.areaperipanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.areaperipanel.Controls.Add(Me.peri)
        Me.areaperipanel.Controls.Add(Me.area)
        Me.areaperipanel.Controls.Add(Me.Label1)
        Me.areaperipanel.Controls.Add(Me.widthtb)
        Me.areaperipanel.Controls.Add(Me.GroupBox2)
        Me.areaperipanel.Controls.Add(Me.PictureBox7)
        Me.areaperipanel.Controls.Add(Me.widthh)
        Me.areaperipanel.Controls.Add(Me.lengthtb)
        Me.areaperipanel.Controls.Add(Me.length)
        Me.areaperipanel.Controls.Add(Me.calcbutton)
        Me.areaperipanel.Location = New System.Drawing.Point(108, 55)
        Me.areaperipanel.Name = "areaperipanel"
        Me.areaperipanel.Size = New System.Drawing.Size(384, 366)
        Me.areaperipanel.TabIndex = 1
        '
        'peri
        '
        Me.peri.AutoSize = True
        Me.peri.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peri.ForeColor = System.Drawing.Color.White
        Me.peri.Location = New System.Drawing.Point(71, 318)
        Me.peri.Name = "peri"
        Me.peri.Size = New System.Drawing.Size(166, 23)
        Me.peri.TabIndex = 18
        Me.peri.Text = "The Peri Equals"
        '
        'area
        '
        Me.area.AutoSize = True
        Me.area.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.area.ForeColor = System.Drawing.Color.White
        Me.area.Location = New System.Drawing.Point(69, 318)
        Me.area.Name = "area"
        Me.area.Size = New System.Drawing.Size(171, 23)
        Me.area.TabIndex = 17
        Me.area.Text = "The Area Equals"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(260, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "..."
        '
        'widthtb
        '
        Me.widthtb.Location = New System.Drawing.Point(207, 105)
        Me.widthtb.Name = "widthtb"
        Me.widthtb.Size = New System.Drawing.Size(121, 20)
        Me.widthtb.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.arearadio)
        Me.GroupBox2.Controls.Add(Me.perimeterradio)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'arearadio
        '
        Me.arearadio.AutoSize = True
        Me.arearadio.BackColor = System.Drawing.Color.DarkSlateGray
        Me.arearadio.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.arearadio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.arearadio.Location = New System.Drawing.Point(185, 43)
        Me.arearadio.Name = "arearadio"
        Me.arearadio.Size = New System.Drawing.Size(58, 19)
        Me.arearadio.TabIndex = 22
        Me.arearadio.Text = "AREA"
        Me.arearadio.UseVisualStyleBackColor = False
        '
        'perimeterradio
        '
        Me.perimeterradio.AutoSize = True
        Me.perimeterradio.BackColor = System.Drawing.Color.DarkSlateGray
        Me.perimeterradio.Checked = True
        Me.perimeterradio.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.perimeterradio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.perimeterradio.Location = New System.Drawing.Point(32, 43)
        Me.perimeterradio.Name = "perimeterradio"
        Me.perimeterradio.Size = New System.Drawing.Size(91, 19)
        Me.perimeterradio.TabIndex = 19
        Me.perimeterradio.TabStop = True
        Me.perimeterradio.Text = "PERIMETER"
        Me.perimeterradio.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Assignment.My.Resources.Resources.office_school_rulers_icon
        Me.PictureBox7.Location = New System.Drawing.Point(169, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'widthh
        '
        Me.widthh.AutoSize = True
        Me.widthh.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widthh.ForeColor = System.Drawing.Color.White
        Me.widthh.Location = New System.Drawing.Point(240, 74)
        Me.widthh.Name = "widthh"
        Me.widthh.Size = New System.Drawing.Size(59, 20)
        Me.widthh.TabIndex = 5
        Me.widthh.Text = "Width"
        '
        'lengthtb
        '
        Me.lengthtb.Location = New System.Drawing.Point(46, 105)
        Me.lengthtb.Name = "lengthtb"
        Me.lengthtb.Size = New System.Drawing.Size(121, 20)
        Me.lengthtb.TabIndex = 3
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.White
        Me.length.Location = New System.Drawing.Point(71, 71)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(70, 20)
        Me.length.TabIndex = 2
        Me.length.Text = "Length"
        '
        'calcbutton
        '
        Me.calcbutton.BackColor = System.Drawing.Color.White
        Me.calcbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calcbutton.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcbutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.calcbutton.Location = New System.Drawing.Point(21, 246)
        Me.calcbutton.Name = "calcbutton"
        Me.calcbutton.Size = New System.Drawing.Size(344, 41)
        Me.calcbutton.TabIndex = 0
        Me.calcbutton.Text = "CALCULATE"
        Me.calcbutton.UseVisualStyleBackColor = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.areaperipanel
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.Controls.Add(Me.Label2)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(600, 29)
        Me.toolbar.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Area Perimeter"
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
        'areaperimeter
        '
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 454)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.areaperipanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "areaperimeter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.areaperipanel.ResumeLayout(False)
        Me.areaperipanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents areaperipanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents widthtb As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents arearadio As System.Windows.Forms.RadioButton
    Friend WithEvents perimeterradio As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents widthh As System.Windows.Forms.Label
    Friend WithEvents lengthtb As System.Windows.Forms.TextBox
    Friend WithEvents length As System.Windows.Forms.Label
    Friend WithEvents calcbutton As System.Windows.Forms.Button
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents area As System.Windows.Forms.Label
    Friend WithEvents peri As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
End Class
