Public Class AutocorrectForm

    Private Sub AutocorrectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        If TextBox1.Text.Contains(" i ") Then
            AutoCorrect(" I ", " i ".Length)
        End If

        If TextBox1.Text.Contains(" havent ") Then
            AutoCorrect(" haven't ", " havent ".Length)
        End If

    End Sub


    Private Sub AutoCorrect(text As String, backspacecount As Integer)
        For i = 1 To backspacecount
            SendKeys.Send("{BS}")
        Next
        SendKeys.Send(text)
    End Sub
End Class