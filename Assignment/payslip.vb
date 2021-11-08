Public Class payslip
    Dim ans As Integer
    Dim deduc As Integer
    Dim paye As Integer
    Dim nhif As Integer
    Dim net As Integer
    Private Sub exitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
        mainMENU.Show()
    End Sub
    Private Sub exitt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseEnter
        exitt.BackColor = Color.Red
    End Sub

    Private Sub exitt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseLeave
        exitt.BackColor = Color.Transparent
    End Sub

    Private Sub compute_Click(sender As Object, e As EventArgs) Handles compute.Click
        ans = ((TextBox1.Text) * (TextBox2.Text) * (TextBox3.Text))
        TextBox7.Text = ans

        paye = ans * 0.05
        TextBox5.Text = paye
        nhif = ans * 0.02
        TextBox6.Text = nhif
        deduc = paye + nhif
        TextBox8.Text = deduc

        net = TextBox7.Text - TextBox8.Text
        TextBox9.Text = net
    End Sub

    Private Sub payslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.theme1.Checked Then
            Me.BackColor = Color.Black
            Me.payslippanel.BackColor = Color.Yellow
            Me.toolbar.BackColor = Color.Yellow
        ElseIf Settings.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.payslippanel.BackColor = Color.PeachPuff
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Settings.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.payslippanel.BackColor = Color.GreenYellow
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Settings.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.payslippanel.BackColor = Color.Tomato
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
    End Sub
End Class