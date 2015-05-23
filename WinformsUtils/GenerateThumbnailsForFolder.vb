Public Class GenerateThumbnailsForFolder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IO.Directory.CreateDirectory(TextBox1.Text & "\thumbnails")

        If CheckBox1.Checked Then IO.Directory.CreateDirectory(TextBox1.Text & "\Large")

        ListBox1.Items.Clear()

        For Each f As String In IO.Directory.GetFiles(TextBox1.Text)

            ListBox1.Items.Add(f)


            Dim filename = IO.Path.GetFileName(f)
            If Not filename = "Thumbs.db" Then

                Try
                    Dim bmp = New Bitmap(TextBox1.Text & "\" & filename)
                    Dim img = ResizeImage(bmp, New Size(250, 20000), True)

                    Dim newLargeHeight = bmp.Height
                    If bmp.Height > 1000 Then
                        newLargeHeight = 1000
                    End If

                    If CheckBox1.Checked Then
                        Dim img2 = ResizeImage(bmp, New Size(20000, newLargeHeight), True)
                        img2.Save(TextBox1.Text & "\large\" & filename)
                        img2.Dispose()
                    End If

                    img.Save(TextBox1.Text & "\thumbnails\" & filename)
                    bmp.Dispose()
                    img.Dispose()


                    GC.Collect()
                Catch ex As OutOfMemoryException
                    GC.Collect()

                End Try


            End If

        Next

        MsgBox("Reize is done!", vbInformation)
    End Sub



    Private Function ResizeImage(ByVal image As Image, _
ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            FolderBrowserDialog1.SelectedPath = TextBox1.Text
        End If
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub
End Class