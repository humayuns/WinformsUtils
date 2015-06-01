Imports System.Net

Public Class WebContentText

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Using client = New WebClient()
            txtContent.Text = client.DownloadString(txtUrl.Text)
        End Using
    End Sub
End Class