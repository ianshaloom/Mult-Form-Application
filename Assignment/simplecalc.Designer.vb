<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class simplecalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(simplecalc))
        Me.simplecalcpanel = New System.Windows.Forms.Panel()
        Me.signpanel = New System.Windows.Forms.Panel()
        Me.plus = New System.Windows.Forms.PictureBox()
        Me.minus = New System.Windows.Forms.PictureBox()
        Me.divide = New System.Windows.Forms.PictureBox()
        Me.multiply = New System.Windows.Forms.PictureBox()
        Me.equalspanel = New System.Windows.Forms.Panel()
        Me.answer = New System.Windows.Forms.Label()
        Me.textboxNum2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.multiplybutton = New System.Windows.Forms.RadioButton()
        Me.minusbutton = New System.Windows.Forms.RadioButton()
        Me.divisionbutton = New System.Windows.Forms.RadioButton()
        Me.addbutton = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.num2 = New System.Windows.Forms.Label()
        Me.textboxNum1 = New System.Windows.Forms.TextBox()
        Me.num1 = New System.Windows.Forms.Label()
        Me.submitt = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.simplecalcpanel.SuspendLayout()
        Me.signpanel.SuspendLayout()
        CType(Me.plus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.divide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.multiply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.equalspanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'simplecalcpanel
        '
        Me.simplecalcpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.simplecalcpanel.Controls.Add(Me.signpanel)
        Me.simplecalcpanel.Controls.Add(Me.equalspanel)
        Me.simplecalcpanel.Controls.Add(Me.textboxNum2)
        Me.simplecalcpanel.Controls.Add(Me.GroupBox1)
        Me.simplecalcpanel.Controls.Add(Me.PictureBox2)
        Me.simplecalcpanel.Controls.Add(Me.num2)
        Me.simplecalcpanel.Controls.Add(Me.textboxNum1)
        Me.simplecalcpanel.Controls.Add(Me.num1)
        Me.simplecalcpanel.Controls.Add(Me.submitt)
        Me.simplecalcpanel.Location = New System.Drawing.Point(108, 35)
        Me.simplecalcpanel.Name = "simplecalcpanel"
        Me.simplecalcpanel.Size = New System.Drawing.Size(384, 414)
        Me.simplecalcpanel.TabIndex = 1
        '
        'signpanel
        '
        Me.signpanel.BackColor = System.Drawing.Color.White
        Me.signpanel.Controls.Add(Me.plus)
        Me.signpanel.Controls.Add(Me.minus)
        Me.signpanel.Controls.Add(Me.divide)
        Me.signpanel.Controls.Add(Me.multiply)
        Me.signpanel.Location = New System.Drawing.Point(152, 94)
        Me.signpanel.Name = "signpanel"
        Me.signpanel.Size = New System.Drawing.Size(61, 52)
        Me.signpanel.TabIndex = 18
        '
        'plus
        '
        Me.plus.BackgroundImage = Global.Assignment.My.Resources.Resources.Science_Plus2_Math_icon
        Me.plus.Location = New System.Drawing.Point(14, 10)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(32, 32)
        Me.plus.TabIndex = 10
        Me.plus.TabStop = False
        '
        'minus
        '
        Me.minus.BackgroundImage = Global.Assignment.My.Resources.Resources.Science_Minus2_Math_icon
        Me.minus.Location = New System.Drawing.Point(14, 10)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(32, 32)
        Me.minus.TabIndex = 12
        Me.minus.TabStop = False
        '
        'divide
        '
        Me.divide.BackgroundImage = Global.Assignment.My.Resources.Resources.Science_Divide_2_icon
        Me.divide.Location = New System.Drawing.Point(14, 10)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(32, 32)
        Me.divide.TabIndex = 11
        Me.divide.TabStop = False
        '
        'multiply
        '
        Me.multiply.BackgroundImage = Global.Assignment.My.Resources.Resources.Science_Multiply_2_icon
        Me.multiply.Location = New System.Drawing.Point(14, 10)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(32, 32)
        Me.multiply.TabIndex = 13
        Me.multiply.TabStop = False
        '
        'equalspanel
        '
        Me.equalspanel.BackColor = System.Drawing.Color.White
        Me.equalspanel.Controls.Add(Me.answer)
        Me.equalspanel.Location = New System.Drawing.Point(113, 269)
        Me.equalspanel.Name = "equalspanel"
        Me.equalspanel.Size = New System.Drawing.Size(159, 62)
        Me.equalspanel.TabIndex = 17
        '
        'answer
        '
        Me.answer.AutoSize = True
        Me.answer.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer.ForeColor = System.Drawing.Color.Black
        Me.answer.Location = New System.Drawing.Point(45, 19)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(93, 28)
        Me.answer.TabIndex = 14
        Me.answer.Text = "Equals"
        '
        'textboxNum2
        '
        Me.textboxNum2.Location = New System.Drawing.Point(221, 110)
        Me.textboxNum2.Name = "textboxNum2"
        Me.textboxNum2.Size = New System.Drawing.Size(121, 20)
        Me.textboxNum2.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.multiplybutton)
        Me.GroupBox1.Controls.Add(Me.minusbutton)
        Me.GroupBox1.Controls.Add(Me.divisionbutton)
        Me.GroupBox1.Controls.Add(Me.addbutton)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'multiplybutton
        '
        Me.multiplybutton.AutoSize = True
        Me.multiplybutton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.multiplybutton.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.multiplybutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.multiplybutton.Location = New System.Drawing.Point(202, 60)
        Me.multiplybutton.Name = "multiplybutton"
        Me.multiplybutton.Size = New System.Drawing.Size(130, 19)
        Me.multiplybutton.TabIndex = 22
        Me.multiplybutton.TabStop = True
        Me.multiplybutton.Text = "MULTIPLICATION"
        Me.multiplybutton.UseVisualStyleBackColor = False
        '
        'minusbutton
        '
        Me.minusbutton.AutoSize = True
        Me.minusbutton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.minusbutton.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.minusbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.minusbutton.Location = New System.Drawing.Point(203, 17)
        Me.minusbutton.Name = "minusbutton"
        Me.minusbutton.Size = New System.Drawing.Size(129, 19)
        Me.minusbutton.TabIndex = 21
        Me.minusbutton.TabStop = True
        Me.minusbutton.Text = "SUBTRACTION    "
        Me.minusbutton.UseVisualStyleBackColor = False
        '
        'divisionbutton
        '
        Me.divisionbutton.AutoSize = True
        Me.divisionbutton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.divisionbutton.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.divisionbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.divisionbutton.Location = New System.Drawing.Point(10, 64)
        Me.divisionbutton.Name = "divisionbutton"
        Me.divisionbutton.Size = New System.Drawing.Size(88, 19)
        Me.divisionbutton.TabIndex = 20
        Me.divisionbutton.TabStop = True
        Me.divisionbutton.Text = "DIVISION  "
        Me.divisionbutton.UseVisualStyleBackColor = False
        '
        'addbutton
        '
        Me.addbutton.AutoSize = True
        Me.addbutton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.addbutton.Checked = True
        Me.addbutton.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.addbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.addbutton.Location = New System.Drawing.Point(10, 17)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(87, 19)
        Me.addbutton.TabIndex = 19
        Me.addbutton.TabStop = True
        Me.addbutton.Text = "ADDITION"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Assignment.My.Resources.Resources.calculator_icon
        Me.PictureBox2.Location = New System.Drawing.Point(157, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.ForeColor = System.Drawing.Color.White
        Me.num2.Location = New System.Drawing.Point(217, 64)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(148, 20)
        Me.num2.TabIndex = 5
        Me.num2.Text = "Second Number"
        '
        'textboxNum1
        '
        Me.textboxNum1.Location = New System.Drawing.Point(21, 109)
        Me.textboxNum1.Name = "textboxNum1"
        Me.textboxNum1.Size = New System.Drawing.Size(121, 20)
        Me.textboxNum1.TabIndex = 3
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.ForeColor = System.Drawing.Color.White
        Me.num1.Location = New System.Drawing.Point(17, 64)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(125, 20)
        Me.num1.TabIndex = 2
        Me.num1.Text = "First Number"
        '
        'submitt
        '
        Me.submitt.BackColor = System.Drawing.Color.White
        Me.submitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitt.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.submitt.Location = New System.Drawing.Point(21, 347)
        Me.submitt.Name = "submitt"
        Me.submitt.Size = New System.Drawing.Size(344, 41)
        Me.submitt.TabIndex = 0
        Me.submitt.Text = "SUBMIT"
        Me.submitt.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.simplecalcpanel
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
        Me.length.Size = New System.Drawing.Size(159, 20)
        Me.length.TabIndex = 21
        Me.length.Text = "Simpe Calculator"
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
        'simplecalc
        '
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 454)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.simplecalcpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "simplecalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.simplecalcpanel.ResumeLayout(False)
        Me.simplecalcpanel.PerformLayout()
        Me.signpanel.ResumeLayout(False)
        CType(Me.plus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.divide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.multiply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.equalspanel.ResumeLayout(False)
        Me.equalspanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents simplecalcpanel As System.Windows.Forms.Panel
    Friend WithEvents textboxNum2 As System.Windows.Forms.TextBox
    Friend WithEvents plus As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents multiplybutton As System.Windows.Forms.RadioButton
    Friend WithEvents minusbutton As System.Windows.Forms.RadioButton
    Friend WithEvents divisionbutton As System.Windows.Forms.RadioButton
    Friend WithEvents addbutton As System.Windows.Forms.RadioButton
    Friend WithEvents answer As System.Windows.Forms.Label
    Friend WithEvents multiply As System.Windows.Forms.PictureBox
    Friend WithEvents minus As System.Windows.Forms.PictureBox
    Friend WithEvents divide As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents num2 As System.Windows.Forms.Label
    Friend WithEvents textboxNum1 As System.Windows.Forms.TextBox
    Friend WithEvents num1 As System.Windows.Forms.Label
    Friend WithEvents submitt As System.Windows.Forms.Button
    Friend WithEvents equalspanel As System.Windows.Forms.Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents signpanel As System.Windows.Forms.Panel
    Friend WithEvents length As Label
End Class
