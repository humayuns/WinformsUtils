Imports System.Net
Imports System.IO

<ToolboxBitmap("C:\Users\Humayun\Desktop\AsyncWebPhotoViewer.ico")>
Public Class AsyncWebPhotoViewer


    Dim m_url As String

    Private Sub AsyncWebPhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub LoadPhoto(url As String)
        m_url = url
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Function GetImageFromUrl(url As String) As Drawing.Image
        Dim tClient As WebClient = New WebClient
        Return Bitmap.FromStream(New MemoryStream(tClient.DownloadData(url)))
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        PictureBox1.Image = GetImageFromUrl(m_url)
    End Sub
End Class
