Public Class frmSingle
    Private Sub frmSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub
End Class