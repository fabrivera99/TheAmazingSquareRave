Public Class dificultades

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As EventArgs) Handles Label2.MouseMove
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As EventArgs) Handles Label3.MouseMove
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As EventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left = Me.Width / 2 - Label1.Width / 2
        Panel1.Left = Me.Width / 2 - Panel1.Width / 2
        Panel1.Top = Me.Height / 2 - Panel1.Height / 2
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Form1.Show()

        tutorial.Show()
    End Sub

    Private Sub dificultades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        titlescreen.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.PictureBox2.BackgroundImage = My.Resources.trangle_blue
        Form1.PictureBox3.BackgroundImage = My.Resources.trangle_blue
        Form1.PictureBox4.BackgroundImage = My.Resources.trangle_blue
        Form1.PictureBox5.BackgroundImage = My.Resources.trangle_blue

        Form1.life1 = 5
        Form1.life2 = 5
        Form1.life3 = 5
        Form1.life4 = 5

        Form1.i = 8
        Form1.Rand.Interval = 50

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form1.PictureBox2.BackgroundImage = My.Resources.trangleYellow
        Form1.PictureBox3.BackgroundImage = My.Resources.trangleYellow
        Form1.PictureBox4.BackgroundImage = My.Resources.trangleYellow
        Form1.PictureBox5.BackgroundImage = My.Resources.trangleYellow

        Form1.life1 = 8
        Form1.life2 = 8
        Form1.life3 = 8
        Form1.life4 = 8

        Form1.Rand.Interval = 1
        Form1.i = 16

        Form1.bulletCounter = True
        Form1.Label1.Visible = True

        Me.Hide()
        Form1.Show()
    End Sub
End Class