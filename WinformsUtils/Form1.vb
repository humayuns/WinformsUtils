Public Class Form1

    Private Sub btnGenerateThumbnails_Click(sender As Object, e As EventArgs) Handles btnGenerateThumbnails.Click
        GenerateThumbnailsForFolder.Show()
    End Sub

    Private Sub btnWebcamFeed_Click(sender As Object, e As EventArgs) Handles btnWebcamFeed.Click
        WebcamFeed.Show()
    End Sub

    Private Sub btnJSONEditor_Click(sender As Object, e As EventArgs) Handles btnJSONEditor.Click
        JSONEditor.Show()
    End Sub

    Private Sub btnLoadWebContent_Click(sender As Object, e As EventArgs) Handles btnLoadWebContent.Click
        WebContent.Show()
    End Sub
End Class
