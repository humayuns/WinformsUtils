Public Class PlotEquation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim g As Graphics = PictureBox1.CreateGraphics


        For i = 1 To PictureBox1.Width - 1
            'g.DrawLine(Pens.AliceBlue, New Point(i, PictureBox1.Height / 2), New Point(i, PictureBox1.Height / 2))
            CType(PictureBox1.Image, Bitmap).SetPixel(i, PictureBox1.Height / 2, Color.Black)
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown



        CType(PictureBox1.Image, Bitmap).SetPixel(e.X, e.Y, Color.Beige)

    End Sub

    Private Sub PlotEquation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
    End Sub
End Class