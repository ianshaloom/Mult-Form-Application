Public Class Form5
    Dim marks As Integer
    Dim grd As Integer

    Dim a, b, c, d, r As Integer
    Private Sub exitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
        mainMENU.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        marks = (a + b + c + d + r)
        TextBox8.Text = marks
        a = TextBox6.Text
        b = TextBox5.Text
        c = TextBox4.Text
        d = TextBox1.Text
        r = TextBox2.Text

        grd = marks / 5
        TextBox7.Text = grd

        If grd >= 89 Then
            TextBox9.Text = "Grade A"
        ElseIf grd >= 79 Then
            TextBox9.Text = "Grade B"
        ElseIf grd >= 69 Then
            TextBox9.Text = "Grade C"
        ElseIf grd <= 49 Then
            TextBox9.Text = "Grade D"
        End If
    End Sub
End Class