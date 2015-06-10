Public Class RADFunctions
    Public Shared Function GetImageFromUrl(url As String) As Drawing.Image
        Dim tClient As Net.WebClient = New Net.WebClient
        Return Bitmap.FromStream(New IO.MemoryStream(tClient.DownloadData(url)))
    End Function
End Class
