Imports System.Net
Imports System.IO

Public Class WebContent

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tClient As WebClient = New WebClient

        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(TextBox1.Text)))

        PictureBox1.Image = tImage
    End Sub
End Class