Public Class Settings

    Private Sub exitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Me.Hide()
        mainMENU.Show()

        settingspanel.Visible = True
    End Sub
    Private Sub exitt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseEnter
        exitt.BackColor = Color.Red
    End Sub

    Private Sub exitt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseLeave
        exitt.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles theme.Click
        themepanel.Visible = True
        settingspanel.Visible = False
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles theme.MouseEnter
        theme.BackColor = Color.DarkBlue
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles theme.MouseLeave
        theme.BackColor = Color.Transparent
    End Sub
    Private Sub savetheme_Click(sender As Object, e As EventArgs) Handles savetheme.Click

        If Me.theme1.Checked Then
            Me.BackColor = Color.Black
            Me.themepanel.BackColor = Color.White
            Me.settingspanel.BackColor = Color.White
            Me.toolbar.BackColor = Color.White
        ElseIf Me.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.themepanel.BackColor = Color.PeachPuff
            Me.settingspanel.BackColor = Color.PeachPuff
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Me.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.themepanel.BackColor = Color.GreenYellow
            Me.settingspanel.BackColor = Color.GreenYellow
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Me.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.themepanel.BackColor = Color.Tomato
            Me.settingspanel.BackColor = Color.Tomato
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub
End Class