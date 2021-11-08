Public Class squareandroot
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
    Private Sub ButtonSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSUBMIT.Click
        Try
            If RadioButtonSquare.Checked = True Then
                LabelAns.Text = Single.Parse(TextBoxNumber.Text) ^ 2
            Else
                LabelAns.Text = Single.Parse(TextBoxNumber.Text) ^ (1 / 2)
            End If

        Catch
            MsgBox("Invalid Input")
            TextBoxNumber.Clear()
            TextBoxNumber.Focus()
            LabelAns.Text = "Answer"
        End Try
    End Sub

    Private Sub squareandroot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class