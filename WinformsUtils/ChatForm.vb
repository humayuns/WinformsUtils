Public Class ChatForm

    Private Sub ChatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        PictureBox1.Image = RADFunctions.GetImageFromUrl("http://www.codeproject.com/KB/edit/CsExRichTextBox/ExRichTextBox.jpg")
    End Sub
End Class