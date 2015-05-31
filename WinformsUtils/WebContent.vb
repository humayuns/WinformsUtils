Imports System.Net
Imports System.IO

Public Class WebContent

    Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click


        PictureBox1.Image = GetImageFromUrl(TextBox1.Text)
    End Sub

    Private Function GetImageFromUrl(url As String) As Drawing.Image
        Dim tClient As WebClient = New WebClient
        Return Bitmap.FromStream(New MemoryStream(tClient.DownloadData(TextBox1.Text)))
    End Function

    Private Sub WebContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.Text
        If TextBox1.Text.Contains("http") Then
            PictureBox1.Image = GetImageFromUrl(TextBox1.Text)
        End If
    End Sub

 
End Class