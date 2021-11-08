Public Class datime

    Private Sub exitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
        mainMENU.Show()
    End Sub

    Private Sub datime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        If Settings.theme1.Checked Then
            Me.BackColor = Color.Black
            Me.rootspanel.BackColor = Color.Yellow
            Me.toolbar.BackColor = Color.Yellow
        ElseIf Settings.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.rootspanel.BackColor = Color.PeachPuff
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Settings.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.rootspanel.BackColor = Color.GreenYellow
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Settings.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.rootspanel.BackColor = Color.Tomato
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd-MMM-yy  hh:mm:ss")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class