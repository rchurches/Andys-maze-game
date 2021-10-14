Public Class frmSingle
    Private Sub frmSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimersignle.ForeColor = Color.ForestGreen
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            lblTimersignle.Text = 60
            Timer1.Start()

        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmmain.Show()
        Me.Close()
    End Sub

    Private Sub frmSingle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            picboxplayer.Left -= 3
        End If
        If e.KeyCode = Keys.D Then
            picboxplayer.Left += 3
        End If
        If e.KeyCode = Keys.S Then
            picboxplayer.Top += 3
        End If
        If e.KeyCode = Keys.W Then
            picboxplayer.Top -= 3
        End If
        'Move in the maze and check any wall collisions
        'If picboxplayer.Bounds.IntersectsWith(Label1.Bounds) Then
        '    BacktoHome()

        'End If
        f picboxplayer.Bounds.IntersectsWith(Label1.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label10.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label2.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label3.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label4.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label5.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label6.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label7.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label8.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(Label9.Bounds) Then
            BacktoHome()

        End If
        If picboxplayer.Bounds.IntersectsWith(lblFinish.Bounds) Then
            MsgBox("yee")

        End If

    End Sub
    Private Sub BacktoHome()
        MsgBox("you hit the wall. Back you go to the in the begining")
        picboxplayer.Top = 80
        picboxplayer.Left = 115

    End Sub
    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000

        If lblTimersignle.Text = 10 Then
            lblTimersignle.ForeColor = Color.Red
            lblTimersignle.Text = Val(lblTimersignle.Text) - 1
        ElseIf lblTimersignle.Text = 0 Then
            Timer1.Enabled = False

            If MessageBox.Show("would you like to try again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                MessageBox.Show("press OK")
                picboxplayer.Top = 80
                picboxplayer.Left = 115
                Me.Hide()
                frmmain.Show()



                If lblTimersignle.Text = 10 Then
                    lblTimersignle.Text = 60
                    Timer1.Start()
                    lblTimersignle.ForeColor = Color.Red
                    lblTimersignle.Text = Val(lblTimersignle.Text) - 1
                    lblTimersignle.Text = Val(lblTimersignle.Text) - 1
                End If
            ElseIf lblTimersignle.Text = 0 Then
                Timer1.Enabled = False
                lblTimersignle.ForeColor = Color.Green
                If Timer1.Enabled = True Then
                    Timer1.Start()
                Else
                    lblTimersignle.Text = 60
                    Timer1.Start()
                End If

            Else
                MessageBox.Show("press OK")
                Me.Hide()
                frmmain.Show()

            End If

        Else
            lblTimersignle.Text = Val(lblTimersignle.Text) - 1
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class