Public Class Quiz

    Private Sub exitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
        mainMENU.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ButtonSTART_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonSTART.Click
        rootspanel.Hide()
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
    End Sub

    Private Sub ButtonSUBMIT1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSUBMIT1.Click
        If RadioButtonUhuru.Checked Then
            MsgBox("Correct")
            Panel1.Hide()
            Panel2.Show()
            Panel3.Hide()
        Else
            MsgBox("Incorrect. Try again")
        End If
    End Sub

    Private Sub Quiz_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rootspanel.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
    End Sub

    Private Sub ButtonSUBMIT2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSUBMIT2.Click
        If RadioButtonTrue.Checked Then
            MsgBox("Correct")
            rootspanel.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel3.Show()

        Else
            MsgBox("Incorrect. Try again")
        End If

    End Sub

    Private Sub ButtonSUBMIT3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSUBMIT3.Click
        If RadioButtonNrb.Checked Then
            MsgBox("Correct")
            Close()
            mainMENU.Show()
        Else
            MsgBox("Incorrect. Try Again")
        End If
    End Sub
End Class