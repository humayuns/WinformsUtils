Public Class GetPixelExamples

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                Using MyBMP As New Bitmap(PictureBox1.Image)
                    Dim MyColor As Color = MyBMP.GetPixel(e.X, e.Y)
                    PictureBox2.BackColor = MyColor
                End Using
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class