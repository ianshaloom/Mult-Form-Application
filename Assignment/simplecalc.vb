Public Class simplecalc
    Dim firstnum, secondnum, submit As Integer

    Private Sub submitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitt.Click
        Try
            firstnum = textboxNum1.Text
            secondnum = textboxNum2.Text
            If addbutton.Checked = True Then
                submit = firstnum + secondnum
            ElseIf minusbutton.Checked = True Then
                submit = firstnum - secondnum
            ElseIf divisionbutton.Checked = True Then
                submit = firstnum / secondnum
            ElseIf multiplybutton.Checked = True Then
                submit = firstnum * secondnum
            End If
        Catch
            MsgBox("Invalid Input")
            textboxNum1.Clear()
            textboxNum2.Clear()
            textboxNum1.Focus()
        End Try
        answer.Text = submit
    End Sub

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

    Private Sub addbutton_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbutton.CheckedChanged
        plus.Visible = True
        multiply.Visible = False
        minus.Visible = False
        divide.Visible = False
    End Sub

    Private Sub minusbutton_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minusbutton.CheckedChanged
        plus.Visible = False
        multiply.Visible = False
        minus.Visible = True
        divide.Visible = False
    End Sub

    Private Sub divisionbutton_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divisionbutton.CheckedChanged
        plus.Visible = False
        multiply.Visible = False
        minus.Visible = False
        divide.Visible = True
    End Sub

    Private Sub multiplybutton_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplybutton.CheckedChanged
        plus.Visible = False
        multiply.Visible = True
        minus.Visible = False
        divide.Visible = False
    End Sub

    Private Sub simplecalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Settings.theme1.Checked Then
            Me.BackColor = Color.Black
            Me.simplecalcpanel.BackColor = Color.Yellow
            Me.toolbar.BackColor = Color.Yellow
        ElseIf Settings.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.simplecalcpanel.BackColor = Color.PeachPuff
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Settings.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.simplecalcpanel.BackColor = Color.GreenYellow
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Settings.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.simplecalcpanel.BackColor = Color.Tomato
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub
End Class