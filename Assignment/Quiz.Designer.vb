<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quiz))
        Me.rootspanel = New System.Windows.Forms.Panel()
        Me.ButtonQUIT = New System.Windows.Forms.Button()
        Me.ButtonSTART = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonUhuru = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRaila = New System.Windows.Forms.RadioButton()
        Me.ButtonSUBMIT1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTrue = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFalse = New System.Windows.Forms.RadioButton()
        Me.ButtonSUBMIT2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNrb = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMsa = New System.Windows.Forms.RadioButton()
        Me.ButtonSUBMIT3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.rootspanel.SuspendLayout()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootspanel
        '
        Me.rootspanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rootspanel.Controls.Add(Me.ButtonQUIT)
        Me.rootspanel.Controls.Add(Me.ButtonSTART)
        Me.rootspanel.Controls.Add(Me.Label1)
        Me.rootspanel.Location = New System.Drawing.Point(35, 66)
        Me.rootspanel.Name = "rootspanel"
        Me.rootspanel.Size = New System.Drawing.Size(529, 337)
        Me.rootspanel.TabIndex = 22
        '
        'ButtonQUIT
        '
        Me.ButtonQUIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQUIT.Location = New System.Drawing.Point(173, 184)
        Me.ButtonQUIT.Name = "ButtonQUIT"
        Me.ButtonQUIT.Size = New System.Drawing.Size(183, 45)
        Me.ButtonQUIT.TabIndex = 9
        Me.ButtonQUIT.Text = "QUIT"
        Me.ButtonQUIT.UseVisualStyleBackColor = True
        '
        'ButtonSTART
        '
        Me.ButtonSTART.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSTART.Location = New System.Drawing.Point(173, 108)
        Me.ButtonSTART.Name = "ButtonSTART"
        Me.ButtonSTART.Size = New System.Drawing.Size(183, 45)
        Me.ButtonSTART.TabIndex = 8
        Me.ButtonSTART.Text = "START"
        Me.ButtonSTART.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(139, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 44)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "GET READY!"
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(600, 29)
        Me.toolbar.TabIndex = 23
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Red
        Me.exitt.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitt.Image = CType(resources.GetObject("exitt.Image"), System.Drawing.Image)
        Me.exitt.Location = New System.Drawing.Point(576, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(24, 29)
        Me.exitt.TabIndex = 5
        Me.exitt.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ButtonSUBMIT1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(35, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 337)
        Me.Panel1.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonUhuru)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRaila)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 132)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonUhuru
        '
        Me.RadioButtonUhuru.AutoSize = True
        Me.RadioButtonUhuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUhuru.ForeColor = System.Drawing.Color.White
        Me.RadioButtonUhuru.Location = New System.Drawing.Point(56, 71)
        Me.RadioButtonUhuru.Name = "RadioButtonUhuru"
        Me.RadioButtonUhuru.Size = New System.Drawing.Size(89, 30)
        Me.RadioButtonUhuru.TabIndex = 8
        Me.RadioButtonUhuru.TabStop = True
        Me.RadioButtonUhuru.Text = "Uhuru"
        Me.RadioButtonUhuru.UseVisualStyleBackColor = True
        '
        'RadioButtonRaila
        '
        Me.RadioButtonRaila.AutoSize = True
        Me.RadioButtonRaila.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonRaila.ForeColor = System.Drawing.Color.White
        Me.RadioButtonRaila.Location = New System.Drawing.Point(56, 19)
        Me.RadioButtonRaila.Name = "RadioButtonRaila"
        Me.RadioButtonRaila.Size = New System.Drawing.Size(80, 30)
        Me.RadioButtonRaila.TabIndex = 7
        Me.RadioButtonRaila.TabStop = True
        Me.RadioButtonRaila.Text = "Raila"
        Me.RadioButtonRaila.UseVisualStyleBackColor = True
        '
        'ButtonSUBMIT1
        '
        Me.ButtonSUBMIT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSUBMIT1.Location = New System.Drawing.Point(123, 244)
        Me.ButtonSUBMIT1.Name = "ButtonSUBMIT1"
        Me.ButtonSUBMIT1.Size = New System.Drawing.Size(249, 71)
        Me.ButtonSUBMIT1.TabIndex = 13
        Me.ButtonSUBMIT1.Text = "SUBMIT"
        Me.ButtonSUBMIT1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1. Who's the current president of Kenya?"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.ButtonSUBMIT2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(35, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 337)
        Me.Panel2.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonTrue)
        Me.GroupBox2.Controls.Add(Me.RadioButtonFalse)
        Me.GroupBox2.Location = New System.Drawing.Point(88, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 132)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'RadioButtonTrue
        '
        Me.RadioButtonTrue.AutoSize = True
        Me.RadioButtonTrue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTrue.ForeColor = System.Drawing.Color.White
        Me.RadioButtonTrue.Location = New System.Drawing.Point(56, 19)
        Me.RadioButtonTrue.Name = "RadioButtonTrue"
        Me.RadioButtonTrue.Size = New System.Drawing.Size(73, 30)
        Me.RadioButtonTrue.TabIndex = 8
        Me.RadioButtonTrue.TabStop = True
        Me.RadioButtonTrue.Text = "True"
        Me.RadioButtonTrue.UseVisualStyleBackColor = True
        '
        'RadioButtonFalse
        '
        Me.RadioButtonFalse.AutoSize = True
        Me.RadioButtonFalse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFalse.ForeColor = System.Drawing.Color.White
        Me.RadioButtonFalse.Location = New System.Drawing.Point(56, 71)
        Me.RadioButtonFalse.Name = "RadioButtonFalse"
        Me.RadioButtonFalse.Size = New System.Drawing.Size(83, 30)
        Me.RadioButtonFalse.TabIndex = 7
        Me.RadioButtonFalse.TabStop = True
        Me.RadioButtonFalse.Text = "False"
        Me.RadioButtonFalse.UseVisualStyleBackColor = True
        '
        'ButtonSUBMIT2
        '
        Me.ButtonSUBMIT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSUBMIT2.Location = New System.Drawing.Point(144, 250)
        Me.ButtonSUBMIT2.Name = "ButtonSUBMIT2"
        Me.ButtonSUBMIT2.Size = New System.Drawing.Size(249, 71)
        Me.ButtonSUBMIT2.TabIndex = 14
        Me.ButtonSUBMIT2.Text = "SUBMIT"
        Me.ButtonSUBMIT2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "2. Life is full of ups and downs."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.ButtonSUBMIT3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(35, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(529, 337)
        Me.Panel3.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonNrb)
        Me.GroupBox3.Controls.Add(Me.RadioButtonMsa)
        Me.GroupBox3.Location = New System.Drawing.Point(88, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(358, 132)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'RadioButtonNrb
        '
        Me.RadioButtonNrb.AutoSize = True
        Me.RadioButtonNrb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNrb.ForeColor = System.Drawing.Color.White
        Me.RadioButtonNrb.Location = New System.Drawing.Point(56, 71)
        Me.RadioButtonNrb.Name = "RadioButtonNrb"
        Me.RadioButtonNrb.Size = New System.Drawing.Size(99, 30)
        Me.RadioButtonNrb.TabIndex = 8
        Me.RadioButtonNrb.TabStop = True
        Me.RadioButtonNrb.Text = "Nairobi"
        Me.RadioButtonNrb.UseVisualStyleBackColor = True
        '
        'RadioButtonMsa
        '
        Me.RadioButtonMsa.AutoSize = True
        Me.RadioButtonMsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMsa.ForeColor = System.Drawing.Color.White
        Me.RadioButtonMsa.Location = New System.Drawing.Point(56, 19)
        Me.RadioButtonMsa.Name = "RadioButtonMsa"
        Me.RadioButtonMsa.Size = New System.Drawing.Size(126, 30)
        Me.RadioButtonMsa.TabIndex = 7
        Me.RadioButtonMsa.TabStop = True
        Me.RadioButtonMsa.Text = "Mombasa"
        Me.RadioButtonMsa.UseVisualStyleBackColor = True
        '
        'ButtonSUBMIT3
        '
        Me.ButtonSUBMIT3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSUBMIT3.Location = New System.Drawing.Point(144, 256)
        Me.ButtonSUBMIT3.Name = "ButtonSUBMIT3"
        Me.ButtonSUBMIT3.Size = New System.Drawing.Size(249, 71)
        Me.ButtonSUBMIT3.TabIndex = 14
        Me.ButtonSUBMIT3.Text = "SUBMIT"
        Me.ButtonSUBMIT3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(83, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "3. What is the capital city of Kenya?"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.rootspanel)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Quiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.rootspanel.ResumeLayout(False)
        Me.rootspanel.PerformLayout()
        Me.toolbar.ResumeLayout(False)
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rootspanel As System.Windows.Forms.Panel
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonQUIT As Button
    Friend WithEvents ButtonSTART As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonUhuru As RadioButton
    Friend WithEvents RadioButtonRaila As RadioButton
    Friend WithEvents ButtonSUBMIT1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonTrue As RadioButton
    Friend WithEvents RadioButtonFalse As RadioButton
    Friend WithEvents ButtonSUBMIT2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonNrb As RadioButton
    Friend WithEvents RadioButtonMsa As RadioButton
    Friend WithEvents ButtonSUBMIT3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
