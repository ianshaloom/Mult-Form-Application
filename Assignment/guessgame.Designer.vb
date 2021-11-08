<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guessgame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guessgame))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.squarespanel = New System.Windows.Forms.Panel()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxGuess = New System.Windows.Forms.TextBox()
        Me.GroupBoxGame = New System.Windows.Forms.GroupBox()
        Me.RadioButton100 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1000 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelHighLow = New System.Windows.Forms.Label()
        Me.LabelNumGuess = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.squarespanel.SuspendLayout()
        Me.GroupBoxGame.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'squarespanel
        '
        Me.squarespanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.squarespanel.Controls.Add(Me.ButtonStart)
        Me.squarespanel.Controls.Add(Me.Label1)
        Me.squarespanel.Controls.Add(Me.TextBoxGuess)
        Me.squarespanel.Controls.Add(Me.GroupBoxGame)
        Me.squarespanel.Controls.Add(Me.PictureBox2)
        Me.squarespanel.Controls.Add(Me.LabelHighLow)
        Me.squarespanel.Controls.Add(Me.LabelNumGuess)
        Me.squarespanel.Controls.Add(Me.ButtonSubmit)
        Me.squarespanel.Location = New System.Drawing.Point(108, 33)
        Me.squarespanel.Name = "squarespanel"
        Me.squarespanel.Size = New System.Drawing.Size(384, 375)
        Me.squarespanel.TabIndex = 2
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.White
        Me.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStart.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonStart.Location = New System.Drawing.Point(237, 319)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(125, 41)
        Me.ButtonStart.TabIndex = 18
        Me.ButtonStart.Text = "START GAME"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Enter A Guess:"
        '
        'TextBoxGuess
        '
        Me.TextBoxGuess.Enabled = False
        Me.TextBoxGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGuess.Location = New System.Drawing.Point(21, 251)
        Me.TextBoxGuess.Name = "TextBoxGuess"
        Me.TextBoxGuess.Size = New System.Drawing.Size(273, 32)
        Me.TextBoxGuess.TabIndex = 16
        '
        'GroupBoxGame
        '
        Me.GroupBoxGame.Controls.Add(Me.RadioButton100)
        Me.GroupBoxGame.Controls.Add(Me.RadioButton10)
        Me.GroupBoxGame.Controls.Add(Me.RadioButton1000)
        Me.GroupBoxGame.Location = New System.Drawing.Point(267, 68)
        Me.GroupBoxGame.Name = "GroupBoxGame"
        Me.GroupBoxGame.Size = New System.Drawing.Size(112, 148)
        Me.GroupBoxGame.TabIndex = 15
        Me.GroupBoxGame.TabStop = False
        '
        'RadioButton100
        '
        Me.RadioButton100.AutoSize = True
        Me.RadioButton100.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RadioButton100.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton100.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton100.Location = New System.Drawing.Point(15, 60)
        Me.RadioButton100.Name = "RadioButton100"
        Me.RadioButton100.Size = New System.Drawing.Size(68, 19)
        Me.RadioButton100.TabIndex = 22
        Me.RadioButton100.Text = "1 -100"
        Me.RadioButton100.UseVisualStyleBackColor = False
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RadioButton10.Checked = True
        Me.RadioButton10.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton10.Location = New System.Drawing.Point(15, 19)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(64, 19)
        Me.RadioButton10.TabIndex = 21
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "1 - 10"
        Me.RadioButton10.UseVisualStyleBackColor = False
        '
        'RadioButton1000
        '
        Me.RadioButton1000.AutoSize = True
        Me.RadioButton1000.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RadioButton1000.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1000.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton1000.Location = New System.Drawing.Point(15, 101)
        Me.RadioButton1000.Name = "RadioButton1000"
        Me.RadioButton1000.Size = New System.Drawing.Size(80, 19)
        Me.RadioButton1000.TabIndex = 20
        Me.RadioButton1000.Text = "1 - 1000"
        Me.RadioButton1000.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Assignment.My.Resources.Resources.Games_icon
        Me.PictureBox2.Location = New System.Drawing.Point(157, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'LabelHighLow
        '
        Me.LabelHighLow.AutoSize = True
        Me.LabelHighLow.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHighLow.ForeColor = System.Drawing.Color.White
        Me.LabelHighLow.Location = New System.Drawing.Point(17, 139)
        Me.LabelHighLow.Name = "LabelHighLow"
        Me.LabelHighLow.Size = New System.Drawing.Size(175, 20)
        Me.LabelHighLow.TabIndex = 5
        Me.LabelHighLow.Text = "High or Low Guess"
        '
        'LabelNumGuess
        '
        Me.LabelNumGuess.AutoSize = True
        Me.LabelNumGuess.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumGuess.ForeColor = System.Drawing.Color.White
        Me.LabelNumGuess.Location = New System.Drawing.Point(17, 71)
        Me.LabelNumGuess.Name = "LabelNumGuess"
        Me.LabelNumGuess.Size = New System.Drawing.Size(188, 20)
        Me.LabelNumGuess.TabIndex = 2
        Me.LabelNumGuess.Text = "Number of Guesses:"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.BackColor = System.Drawing.Color.White
        Me.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSubmit.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSubmit.Location = New System.Drawing.Point(21, 319)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(125, 41)
        Me.ButtonSubmit.TabIndex = 0
        Me.ButtonSubmit.Text = "SUBMIT"
        Me.ButtonSubmit.UseVisualStyleBackColor = False
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
        Me.length.Size = New System.Drawing.Size(118, 20)
        Me.length.TabIndex = 21
        Me.length.Text = "Guess Game"
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
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.squarespanel
        '
        'guessgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.squarespanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "guessgame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "squaresandroot"
        Me.squarespanel.ResumeLayout(False)
        Me.squarespanel.PerformLayout()
        Me.GroupBoxGame.ResumeLayout(False)
        Me.GroupBoxGame.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents squarespanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxGame As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton100 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1000 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelHighLow As System.Windows.Forms.Label
    Friend WithEvents LabelNumGuess As System.Windows.Forms.Label
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGuess As System.Windows.Forms.TextBox
    Friend WithEvents length As Label
End Class
