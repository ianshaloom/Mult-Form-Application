<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mediaplayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mediaplayer))
        Me.mediapanel = New System.Windows.Forms.Panel()
        Me.previous = New System.Windows.Forms.Button()
        Me.pauses = New System.Windows.Forms.Button()
        Me.nextt = New System.Windows.Forms.Button()
        Me.forwardpay = New System.Windows.Forms.Button()
        Me.backwardplay = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.plays = New System.Windows.Forms.Button()
        Me.stopplay = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.mediapanel.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mediapanel
        '
        Me.mediapanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mediapanel.Controls.Add(Me.previous)
        Me.mediapanel.Controls.Add(Me.pauses)
        Me.mediapanel.Controls.Add(Me.nextt)
        Me.mediapanel.Controls.Add(Me.forwardpay)
        Me.mediapanel.Controls.Add(Me.backwardplay)
        Me.mediapanel.Controls.Add(Me.TextBox1)
        Me.mediapanel.Controls.Add(Me.Button3)
        Me.mediapanel.Controls.Add(Me.plays)
        Me.mediapanel.Controls.Add(Me.stopplay)
        Me.mediapanel.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.mediapanel.Location = New System.Drawing.Point(27, 43)
        Me.mediapanel.Name = "mediapanel"
        Me.mediapanel.Size = New System.Drawing.Size(545, 375)
        Me.mediapanel.TabIndex = 22
        '
        'previous
        '
        Me.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previous.Image = Global.Assignment.My.Resources.Resources.previous_icon
        Me.previous.Location = New System.Drawing.Point(128, 315)
        Me.previous.Name = "previous"
        Me.previous.Size = New System.Drawing.Size(29, 31)
        Me.previous.TabIndex = 9
        Me.previous.UseVisualStyleBackColor = True
        '
        'pauses
        '
        Me.pauses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pauses.Image = Global.Assignment.My.Resources.Resources.pause_icon
        Me.pauses.Location = New System.Drawing.Point(252, 315)
        Me.pauses.Name = "pauses"
        Me.pauses.Size = New System.Drawing.Size(29, 31)
        Me.pauses.TabIndex = 8
        Me.pauses.UseVisualStyleBackColor = True
        '
        'nextt
        '
        Me.nextt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextt.Image = Global.Assignment.My.Resources.Resources.next_icon
        Me.nextt.Location = New System.Drawing.Point(314, 315)
        Me.nextt.Name = "nextt"
        Me.nextt.Size = New System.Drawing.Size(29, 31)
        Me.nextt.TabIndex = 7
        Me.nextt.UseVisualStyleBackColor = True
        '
        'forwardpay
        '
        Me.forwardpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forwardpay.Image = Global.Assignment.My.Resources.Resources.fast_forward_icon
        Me.forwardpay.Location = New System.Drawing.Point(376, 315)
        Me.forwardpay.Name = "forwardpay"
        Me.forwardpay.Size = New System.Drawing.Size(29, 31)
        Me.forwardpay.TabIndex = 6
        Me.forwardpay.UseVisualStyleBackColor = True
        '
        'backwardplay
        '
        Me.backwardplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backwardplay.Image = Global.Assignment.My.Resources.Resources.fast_backward_icon
        Me.backwardplay.Location = New System.Drawing.Point(66, 315)
        Me.backwardplay.Name = "backwardplay"
        Me.backwardplay.Size = New System.Drawing.Size(29, 31)
        Me.backwardplay.TabIndex = 5
        Me.backwardplay.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(438, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(460, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 20)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Choose Fie"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'plays
        '
        Me.plays.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plays.Image = Global.Assignment.My.Resources.Resources.play_icon
        Me.plays.Location = New System.Drawing.Point(190, 315)
        Me.plays.Name = "plays"
        Me.plays.Size = New System.Drawing.Size(29, 31)
        Me.plays.TabIndex = 2
        Me.plays.UseVisualStyleBackColor = True
        '
        'stopplay
        '
        Me.stopplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stopplay.Image = Global.Assignment.My.Resources.Resources.stop_2_icon
        Me.stopplay.Location = New System.Drawing.Point(438, 315)
        Me.stopplay.Name = "stopplay"
        Me.stopplay.Size = New System.Drawing.Size(29, 31)
        Me.stopplay.TabIndex = 1
        Me.stopplay.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(5, 57)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(534, 252)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
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
        Me.length.Location = New System.Drawing.Point(15, 4)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(122, 20)
        Me.length.TabIndex = 24
        Me.length.Text = "Media Player"
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
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me.mediapanel
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'mediaplayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.mediapanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mediaplayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addmember"
        Me.mediapanel.ResumeLayout(False)
        Me.mediapanel.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mediapanel As System.Windows.Forms.Panel
    Friend WithEvents toolbar As System.Windows.Forms.Panel
    Friend WithEvents exitt As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents plays As System.Windows.Forms.Button
    Friend WithEvents stopplay As System.Windows.Forms.Button
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents previous As System.Windows.Forms.Button
    Friend WithEvents pauses As System.Windows.Forms.Button
    Friend WithEvents nextt As System.Windows.Forms.Button
    Friend WithEvents forwardpay As System.Windows.Forms.Button
    Friend WithEvents backwardplay As System.Windows.Forms.Button
    Friend WithEvents length As Label
End Class
