Public Class areaperimeter
    Dim firstnum As Integer
    Dim secondnum As Integer
    Dim submit As Integer
    Private Sub calcbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcbutton.Click
        firstnum = lengthtb.Text
        secondnum = widthtb.Text
        If arearadio.Checked = True Then
            submit = firstnum * secondnum
        ElseIf perimeterradio.Checked = True Then
            submit = 2 * (firstnum + secondnum)
        End If
        Label1.Text = submit
    End Sub
    Private Sub exitt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
        mainMENU.Show()
    End Sub
    Private Sub exitt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseEnter
        exitt.BackColor = Color.Red
    End Sub

    Private Sub exitt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseLeave
        exitt.BackColor = Color.Transparent
    End Sub
    Private Sub perimeterradio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perimeterradio.CheckedChanged
        peri.Visible = True
        area.Visible = False
    End Sub

    Private Sub arearadio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arearadio.CheckedChanged
        peri.Visible = False
        area.Visible = True
    End Sub

    Private Sub areaperimeter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.theme1.Checked Then
            Me.BackColor = Color.Black
            Me.areaperipanel.BackColor = Color.Yellow
            Me.toolbar.BackColor = Color.Yellow
        ElseIf Settings.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.areaperipanel.BackColor = Color.PeachPuff
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Settings.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.areaperipanel.BackColor = Color.GreenYellow
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Settings.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.areaperipanel.BackColor = Color.Tomato
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub
End Class