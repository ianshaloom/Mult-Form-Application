
Public Class mainMENU
    Private Sub minimize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub exitt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
        login.Show()
        members.Close()
        simplecalc.Close()
        areaperimeter.Close()
        squareandroot.Close()
        guessgame.Close()
        mediaplayer.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
    End Sub
    Private Sub exitt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseEnter
        exitt.BackColor = Color.Red
    End Sub

    Private Sub exitt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseLeave
        exitt.BackColor = Color.Transparent
    End Sub
    Private Sub maximize_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximize.MouseEnter
        maximize.BackColor = Color.LimeGreen
    End Sub

    Private Sub maximize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximize.MouseLeave
        maximize.BackColor = Color.Transparent
    End Sub

    Private Sub minimize_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize.MouseEnter
        minimize.BackColor = Color.Yellow
    End Sub

    Private Sub minimize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize.MouseLeave
        minimize.BackColor = Color.Transparent
    End Sub
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        members.Show()
        simplecalc.Close()
        areaperimeter.Close()
        squareandroot.Close()
        guessgame.Close()
        mediaplayer.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub
    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        simplecalc.Show()
        members.Close()
        areaperimeter.Close()
        squareandroot.Close()
        guessgame.Close()
        mediaplayer.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        areaperimeter.Show()
        members.Close()
        simplecalc.Close()
        squareandroot.Close()
        guessgame.Close()
        mediaplayer.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        guessgame.Show()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        squareandroot.Close()
        mediaplayer.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        squareandroot.Show()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        mediaplayer.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        mediaplayer.Show()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        payslip.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        payslip.Show()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form2.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form2.Show()
        payslip.Close()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        payslip.Close()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form2.Close()
        Quiz.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Quiz.Show()
        payslip.Close()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form3.Close()
        Form2.Close()
        Form5.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form5.Show()
        payslip.Close()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form3.Close()
        Quiz.Close()
        Form2.Close()

        datime.Close()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Settings.Show()
        payslip.Close()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()
        Form2.Close()
        datime.Close()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        datime.Show()
        payslip.Close()
        mediaplayer.Close()
        squareandroot.Close()
        guessgame.Close()
        areaperimeter.Close()
        members.Close()
        simplecalc.Close()
        Form3.Close()
        Quiz.Close()
        Form5.Close()

        Form2.Close()
        Me.Hide()
    End Sub

    Private Sub mainMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.theme1.Checked Then
            Me.BackColor = Color.Black

        ElseIf Settings.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Settings.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Settings.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub
End Class