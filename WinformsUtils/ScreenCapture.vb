

Public Class ScreenCapture

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CaptureScreen(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "C:\Users\Humayun\Desktop")
    End Sub


    ' ref: http://www.codeproject.com/Articles/91487/Screen-Capture-in-WPF-WinForms-Application?msg=5061810#xx5061810xx
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
        CaptureScreen(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "C:\Users\Humayun\Desktop")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CaptureScreen(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "C:\Users\Humayun\Desktop")
        Me.WindowState = FormWindowState.Normal
        Timer1.Enabled = False
    End Sub
End Class