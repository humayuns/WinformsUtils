Public Class RADFunctions
    Public Shared Function GetImageFromUrl(url As String) As Drawing.Image
        Dim tClient As Net.WebClient = New Net.WebClient
        Return Bitmap.FromStream(New IO.MemoryStream(tClient.DownloadData(url)))
    End Function

    Public Shared Sub CreateFolderIfNotExists(path As String)
        If Not IO.Directory.Exists(path) Then
            IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Public Shared Sub CreateFileIfNotExists(filename As String)
        If Not IO.File.Exists(filename) Then
            IO.File.Create(filename).Dispose()
        End If
    End Sub
End Class
