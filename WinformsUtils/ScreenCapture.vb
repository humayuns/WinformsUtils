

Public Class ScreenCapture

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CaptureScreen(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "C:\Users\Humayun\Desktop")
    End Sub


    Private Sub CaptureScreen(x As Double, y As Double, width As Double, height As Double, SavePath As String)
        Dim ix As Integer, iy As Integer, iw As Integer, ih As Integer
        ix = Convert.ToInt32(x)
        iy = Convert.ToInt32(y)
        iw = Convert.ToInt32(width)
        ih = Convert.ToInt32(height)
        Dim image As New Bitmap(iw, ih, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(image)
        g.CopyFromScreen(ix, iy, ix, iy, New System.Drawing.Size(iw, ih), CopyPixelOperation.SourceCopy)
        Dim filename = SavePath & "\" & "screenshot-" & DateTime.Now.ToString().Replace("/", "-").Replace(":", ".") & ".png"
        image.Save(filename, System.Drawing.Imaging.ImageFormat.Png)
    End Sub

End Class