Public Class PlotEquation


    Private Count As Integer = 3
    Private x0 As Single = 17
    Private x1 As Single = 235
    Private y0 As Single = 81
    Private y1 As Single = 154


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


    Public Sub DrawInPicture(ByVal pc As PictureBox, ByVal [color] As Color)
        Try
            Dim BMP As Bitmap = New Bitmap(pc.Image)
            Dim G As Graphics = Graphics.FromImage(BMP)
            Dim P As Pen = New Pen(color)
            For i = 1 To Count
                G.DrawLine(P, x0, y0, x1, y1)
            Next i
            pc.Image = BMP
        Catch
            MsgBox("clsBorder.DrawInPicture Error")
        End Try
    End Sub

    Private Sub DrawLine(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Try
            Dim BMP As Bitmap = New Bitmap(PictureBox1.Image)
            Dim G As Graphics = Graphics.FromImage(BMP)
            Dim P As Pen = New Pen(Brushes.Black)
            For i = 1 To Count
                G.DrawLine(P, x1, y1, x2, y2)
            Next i
            PictureBox1.Image = BMP
        Catch
            MsgBox("clsBorder.DrawInPicture Error")
        End Try
    End Sub

    Private Sub DrawPixel(x As Integer, y As Integer)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DrawInPicture(PictureBox1, Color.Black)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DrawLine(0, PictureBox1.Height / 2, PictureBox1.Width, PictureBox1.Height / 2)
        DrawLine(PictureBox1.Width / 2, 0, PictureBox1.Width / 2, PictureBox1.Height)
    End Sub
End Class