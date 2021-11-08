Public Class guessgame
    Dim RandomNumber As Integer
    Dim Guesses As Integer

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        Guesses = 0
        GroupBoxGame.Enabled = False
        ButtonStart.Enabled = False
        TextBoxGuess.Enabled = True
        ButtonSubmit.Enabled = True
        LabelNumGuess.Text = "Number Of Guesses: " + Str(Guesses)
        LabelHighLow.Text = ""
        TextBoxGuess.Focus()
        TextBoxGuess.Clear()
        GetNumber()

    End Sub

    Private Sub GetNumber()
        Randomize()
        If RadioButton10.Checked = True Then
            RandomNumber = Rnd() * 9 + 1
        ElseIf RadioButton100.Checked = True Then
            RandomNumber = Rnd() * 99 + 1
        Else
            RandomNumber = Rnd() * 999 + 1
        End If
    End Sub

    Private Sub ButtonSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmit.Click
        If TextBoxGuess.Text <> "" Then
            Try
                If Integer.Parse(TextBoxGuess.Text) = RandomNumber Then
                    CorrectGuess()
                Else
                    NotCorrectGuess()

                End If
            Catch ex As Exception
                TextBoxGuess.Clear()
                TextBoxGuess.Focus()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CorrectGuess()
        Guesses += 1
        LabelNumGuess.Text = "Number Of Guesses: " + Str(Guesses)
        GroupBoxGame.Enabled = True
        ButtonStart.Enabled = True
        TextBoxGuess.Enabled = False
        ButtonSubmit.Enabled = False
        MsgBox("You Guessed My Number In " + Str(Guesses) + " Guesses!")
    End Sub

    Private Sub NotCorrectGuess()
        Guesses += 1
        LabelNumGuess.Text = "Number Of Guesses: " + Str(Guesses)
        If Integer.Parse(TextBoxGuess.Text) < RandomNumber Then
            LabelHighLow.Text = "Your Guess Was Too Low"
        Else
            LabelHighLow.Text = "Your Guess Was Too High"

        End If
        TextBoxGuess.Clear()
        TextBoxGuess.Focus()

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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub guessgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.theme1.Checked Then
            Me.BackColor = Color.Black
            Me.squarespanel.BackColor = Color.Yellow
            Me.toolbar.BackColor = Color.Yellow
        ElseIf Settings.theme2.Checked Then
            Me.BackColor = Color.RoyalBlue
            Me.squarespanel.BackColor = Color.PeachPuff
            Me.toolbar.BackColor = Color.PeachPuff
        ElseIf Settings.theme3.Checked Then
            Me.BackColor = Color.ForestGreen
            Me.squarespanel.BackColor = Color.GreenYellow
            Me.toolbar.BackColor = Color.GreenYellow
        ElseIf Settings.theme4.Checked Then
            Me.BackColor = Color.Teal
            Me.squarespanel.BackColor = Color.Tomato
            Me.toolbar.BackColor = Color.Tomato
        End If
    End Sub
End Class