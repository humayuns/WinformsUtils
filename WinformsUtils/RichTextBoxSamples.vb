Public Class RichTextBoxSamples

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionStart = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionFont = RichTextBox1.Font
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Italic)
        RichTextBox1.SelectionStart = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionFont = RichTextBox1.Font
    End Sub


    ' ref: http://www.codeproject.com/Articles/4544/Insert-Plain-Text-and-Images-into-RichTextBox-at-R

    ' TRichTextBox – A universal RichTextBox which can display animated images and more
    ' http://www.codeproject.com/Articles/134358/TRichTextBox-A-universal-RichTextBox-which-can-dis
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim lstrFile As String = OpenFileDialog1.FileName
            Dim myBitmap As New Bitmap(lstrFile)
            ' Copy the bitmap to the clipboard.
            Clipboard.SetDataObject(myBitmap)
            ' Get the format for the object type.
            Dim myFormat As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)
            ' After verifying that the data can be pasted, paste
            If RichTextBox1.CanPaste(myFormat) Then
                RichTextBox1.Paste(myFormat)
            Else
                MessageBox.Show("The data format that you attempted site" + " is not supportedby this control.")
            End If
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub
End Class