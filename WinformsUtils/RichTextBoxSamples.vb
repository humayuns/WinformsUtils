Public Class RichTextBoxSamples

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
        RichTextBox1.SelectionStart = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionFont = RichTextBox1.Font
    End Sub
End Class