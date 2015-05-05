Public Class titlescreen

    Private Sub titlescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Show()
        dificultades.Show()
        Me.TopMost = True
    End Sub

    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        dificultades.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.FromArgb(134, 204, 149)
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As EventArgs) Handles Label2.MouseMove
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As EventArgs) Handles Label3.MouseMove
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.FromArgb(134, 204, 149)
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As EventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.FromArgb(134, 204, 149)
    End Sub

    Private Sub Label4_MouseClick(sender As Object, e As MouseEventArgs) Handles Label4.MouseClick
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left = Me.Width / 2 - Label1.Width / 2
        Panel1.Left = Me.Width / 2 - Panel1.Width / 2
        Panel1.Top = Me.Height / 2 - Panel1.Height / 2        
    End Sub
End Class