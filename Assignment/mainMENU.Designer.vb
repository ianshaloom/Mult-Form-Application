<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMENU))
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.maximize = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.toolbar.SuspendLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.leftPanel.SuspendLayout()
        Me.rightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.Controls.Add(Me.length)
        Me.toolbar.Controls.Add(Me.minimize)
        Me.toolbar.Controls.Add(Me.maximize)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(1000, 29)
        Me.toolbar.TabIndex = 19
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(12, 6)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(105, 20)
        Me.length.TabIndex = 22
        Me.length.Text = "Main Menu"
        '
        'minimize
        '
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.minimize.Image = CType(resources.GetObject("minimize.Image"), System.Drawing.Image)
        Me.minimize.Location = New System.Drawing.Point(928, 0)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(24, 29)
        Me.minimize.TabIndex = 7
        Me.minimize.TabStop = False
        '
        'maximize
        '
        Me.maximize.BackColor = System.Drawing.Color.Transparent
        Me.maximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.maximize.Image = CType(resources.GetObject("maximize.Image"), System.Drawing.Image)
        Me.maximize.Location = New System.Drawing.Point(952, 0)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(24, 29)
        Me.maximize.TabIndex = 6
        Me.maximize.TabStop = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitt.Image = CType(resources.GetObject("exitt.Image"), System.Drawing.Image)
        Me.exitt.Location = New System.Drawing.Point(976, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(24, 29)
        Me.exitt.TabIndex = 5
        Me.exitt.TabStop = False
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.Transparent
        Me.leftPanel.Controls.Add(Me.Button1)
        Me.leftPanel.Controls.Add(Me.Btn7)
        Me.leftPanel.Controls.Add(Me.Btn3)
        Me.leftPanel.Controls.Add(Me.Btn1)
        Me.leftPanel.Controls.Add(Me.Btn5)
        Me.leftPanel.Controls.Add(Me.Btn6)
        Me.leftPanel.Controls.Add(Me.Btn4)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.leftPanel.Location = New System.Drawing.Point(0, 29)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(500, 552)
        Me.leftPanel.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Assignment.My.Resources.Resources.payment_icon
        Me.Button1.Location = New System.Drawing.Point(0, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(500, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "   Payslip"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.FlatAppearance.BorderSize = 0
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(0, 598)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(200, 50)
        Me.Btn7.TabIndex = 14
        Me.Btn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.FlatAppearance.BorderSize = 0
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Image = Global.Assignment.My.Resources.Resources.Calculator_icon__1_
        Me.Btn3.Location = New System.Drawing.Point(0, 109)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(500, 50)
        Me.Btn3.TabIndex = 15
        Me.Btn3.Text = "     Simple Calc"
        Me.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.FlatAppearance.BorderSize = 0
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Image = CType(resources.GetObject("Btn1.Image"), System.Drawing.Image)
        Me.Btn1.Location = New System.Drawing.Point(0, 23)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(500, 50)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "    Members"
        Me.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.FlatAppearance.BorderSize = 0
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Image = Global.Assignment.My.Resources.Resources.Games_icon
        Me.Btn5.Location = New System.Drawing.Point(0, 453)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(500, 50)
        Me.Btn5.TabIndex = 12
        Me.Btn5.Text = "    Guess Game"
        Me.Btn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.FlatAppearance.BorderSize = 0
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Image = Global.Assignment.My.Resources.Resources.Apps_libreoffice_math_icon
        Me.Btn6.Location = New System.Drawing.Point(0, 281)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(500, 50)
        Me.Btn6.TabIndex = 13
        Me.Btn6.Text = "   Squares Root"
        Me.Btn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn4.FlatAppearance.BorderSize = 0
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Image = Global.Assignment.My.Resources.Resources.office_school_rulers_icon
        Me.Btn4.Location = New System.Drawing.Point(0, 211)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(500, 50)
        Me.Btn4.TabIndex = 10
        Me.Btn4.Text = "   Area Perimeter"
        Me.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'rightPanel
        '
        Me.rightPanel.BackColor = System.Drawing.Color.Transparent
        Me.rightPanel.Controls.Add(Me.Button7)
        Me.rightPanel.Controls.Add(Me.Button2)
        Me.rightPanel.Controls.Add(Me.Button3)
        Me.rightPanel.Controls.Add(Me.Button4)
        Me.rightPanel.Controls.Add(Me.Button6)
        Me.rightPanel.Controls.Add(Me.Button8)
        Me.rightPanel.Controls.Add(Me.Button5)
        Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightPanel.Location = New System.Drawing.Point(500, 29)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(500, 552)
        Me.rightPanel.TabIndex = 21
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(3, 248)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(500, 50)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "   Quiz"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(3, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(500, 50)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "   Grade Results"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.Assignment.My.Resources.Resources.watch_icon
        Me.Button4.Location = New System.Drawing.Point(1, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(500, 50)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "   Date and Time"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.Assignment.My.Resources.Resources.Windows_Media_Player_icon
        Me.Button6.Location = New System.Drawing.Point(3, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(500, 50)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "   Media Player"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.Assignment.My.Resources.Resources.school_book_icon
        Me.Button8.Location = New System.Drawing.Point(3, 398)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(500, 50)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "   Admission Form"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.Assignment.My.Resources.Resources.Settings_icon
        Me.Button5.Location = New System.Drawing.Point(3, 473)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(500, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "   Settings"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.toolbar
        Me.BunifuDragControl1.Vertical = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(3, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(500, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Meaning of ife"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mainMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 581)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainMENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.leftPanel.ResumeLayout(False)
        Me.rightPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents leftPanel As System.Windows.Forms.Panel
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents rightPanel As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

    Friend WithEvents minimize As System.Windows.Forms.PictureBox
    Friend WithEvents maximize As System.Windows.Forms.PictureBox
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents length As Label
    Friend WithEvents Button2 As Button
End Class
