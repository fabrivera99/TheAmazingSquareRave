Public Class tutorial
    Private Sub tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True

        transition.Start()

        PictureBox1.Left = (Form1.player.Left - Form1.player.Width / 2)
        PictureBox1.Top = (Form1.player.Top - Form1.player.Width / 2)

        PictureBox1.Width = Form1.player.Width * 2
        PictureBox1.Height = Form1.player.Width * 2

    End Sub

    Private Sub transition_Tick(sender As Object, e As EventArgs) Handles transition.Tick
        Me.Opacity = Me.Opacity + 0.05
        If Me.Opacity >= 0.8 Then
            transition.Stop()
        End If
    End Sub
End Class