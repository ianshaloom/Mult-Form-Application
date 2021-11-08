<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class squareandroot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(squareandroot))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.rootspanel = New System.Windows.Forms.Panel()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.GroupBoxFind = New System.Windows.Forms.GroupBox()
        Me.RadioButtonRoot = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSquare = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelAns = New System.Windows.Forms.Label()
        Me.LabelNumber = New System.Windows.Forms.Label()
        Me.ButtonSUBMIT = New System.Windows.Forms.Button()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rootspanel.SuspendLayout()
        Me.GroupBoxFind.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
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
        Me.length.Location = New System.Drawing.Point(12, 4)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(125, 20)
        Me.length.TabIndex = 22
        Me.length.Text = "Squares Root"
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
        'rootspanel
        '
        Me.rootspanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rootspanel.Controls.Add(Me.TextBoxNumber)
        Me.rootspanel.Controls.Add(Me.GroupBoxFind)
        Me.rootspanel.Controls.Add(Me.PictureBox2)
        Me.rootspanel.Controls.Add(Me.LabelAns)
        Me.rootspanel.Controls.Add(Me.LabelNumber)
        Me.rootspanel.Controls.Add(Me.ButtonSUBMIT)
        Me.rootspanel.Location = New System.Drawing.Point(108, 37)
        Me.rootspanel.Name = "rootspanel"
        Me.rootspanel.Size = New System.Drawing.Size(384, 375)
        Me.rootspanel.TabIndex = 21
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Enabled = False
        Me.TextBoxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumber.Location = New System.Drawing.Point(30, 136)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(184, 32)
        Me.TextBoxNumber.TabIndex = 16
        '
        'GroupBoxFind
        '
        Me.GroupBoxFind.Controls.Add(Me.RadioButtonRoot)
        Me.GroupBoxFind.Controls.Add(Me.RadioButtonSquare)
        Me.GroupBoxFind.Location = New System.Drawing.Point(233, 68)
        Me.GroupBoxFind.Name = "GroupBoxFind"
        Me.GroupBoxFind.Size = New System.Drawing.Size(146, 148)
        Me.GroupBoxFind.TabIndex = 15
        Me.GroupBoxFind.TabStop = False
        '
        'RadioButtonRoot
        '
        Me.RadioButtonRoot.AutoSize = True
        Me.RadioButtonRoot.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RadioButtonRoot.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonRoot.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButtonRoot.Location = New System.Drawing.Point(15, 81)
        Me.RadioButtonRoot.Name = "RadioButtonRoot"
        Me.RadioButtonRoot.Size = New System.Drawing.Size(61, 19)
        Me.RadioButtonRoot.TabIndex = 22
        Me.RadioButtonRoot.Text = "ROOT"
        Me.RadioButtonRoot.UseVisualStyleBackColor = False
        '
        'RadioButtonSquare
        '
        Me.RadioButtonSquare.AutoSize = True
        Me.RadioButtonSquare.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RadioButtonSquare.Checked = True
        Me.RadioButtonSquare.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonSquare.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButtonSquare.Location = New System.Drawing.Point(15, 27)
        Me.RadioButtonSquare.Name = "RadioButtonSquare"
        Me.RadioButtonSquare.Size = New System.Drawing.Size(75, 19)
        Me.RadioButtonSquare.TabIndex = 21
        Me.RadioButtonSquare.TabStop = True
        Me.RadioButtonSquare.Text = "SQUARE"
        Me.RadioButtonSquare.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Assignment.My.Resources.Resources.Apps_libreoffice_math_icon
        Me.PictureBox2.Location = New System.Drawing.Point(157, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'LabelAns
        '
        Me.LabelAns.AutoSize = True
        Me.LabelAns.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAns.ForeColor = System.Drawing.Color.White
        Me.LabelAns.Location = New System.Drawing.Point(75, 217)
        Me.LabelAns.Name = "LabelAns"
        Me.LabelAns.Size = New System.Drawing.Size(80, 20)
        Me.LabelAns.TabIndex = 5
        Me.LabelAns.Text = "ANSWER"
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumber.ForeColor = System.Drawing.Color.White
        Me.LabelNumber.Location = New System.Drawing.Point(26, 92)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(138, 20)
        Me.LabelNumber.TabIndex = 2
        Me.LabelNumber.Text = "Enter Number:"
        '
        'ButtonSUBMIT
        '
        Me.ButtonSUBMIT.BackColor = System.Drawing.Color.White
        Me.ButtonSUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSUBMIT.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSUBMIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSUBMIT.Location = New System.Drawing.Point(21, 292)
        Me.ButtonSUBMIT.Name = "ButtonSUBMIT"
        Me.ButtonSUBMIT.Size = New System.Drawing.Size(343, 41)
        Me.ButtonSUBMIT.TabIndex = 0
        Me.ButtonSUBMIT.Text = "SUBMIT"
        Me.ButtonSUBMIT.UseVisualStyleBackColor = False
        '
        'squareandroot
        '
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.rootspanel)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "squareandroot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rootspanel.ResumeLayout(False)
        Me.rootspanel.PerformLayout()
        Me.GroupBoxFind.ResumeLayout(False)
        Me.GroupBoxFind.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents rootspanel As System.Windows.Forms.Panel
    Friend WithEvents TextBoxNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxFind As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonRoot As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSquare As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelAns As System.Windows.Forms.Label
    Friend WithEvents LabelNumber As System.Windows.Forms.Label
    Friend WithEvents ButtonSUBMIT As System.Windows.Forms.Button
    Friend WithEvents length As Label
End Class
