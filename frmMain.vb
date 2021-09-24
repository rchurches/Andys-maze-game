Public Class frmmain
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("welcome to Andys maze gamee")
    End Sub

    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        frmDouble.Show()
        Me.Hide()

    End Sub

    Private Sub btnSingle_Click(sender As Object, e As EventArgs) Handles btnSingle.Click
        MsgBox("these are instructions")

        MsgBox("avoid the walls")

        MsgBox("get to the finish line before the time riuns out")

        MsgBox("controls w-up s-dpwn a-left d-right")

        MsgBox("press ok to continuee")

        frmSingle.Show()
        Me.Hide()
        frmSingle.lblTimersignle.Text = 60
        frmSingle.Timer1.Start()
        frmSingle.picboxplayer.Top = 80
        frmSingle.picboxplayer.Left = 115


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("would you like to try agaoin=hfrryr", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class
