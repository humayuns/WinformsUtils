Imports System.Net
Imports System.IO

Public Class WebContent

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        PictureBox1.Image = GetImageFromUrl(TextBox1.Text)
    End Sub

    Private Function GetImageFromUrl(url As String) As Drawing.Image
        Dim tClient As WebClient = New WebClient
        Return Bitmap.FromStream(New MemoryStream(tClient.DownloadData(TextBox1.Text)))
    End Function
End Class