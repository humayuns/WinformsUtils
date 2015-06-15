Public Class NetVersion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(".NET Version: " & System.Environment.Version.ToString(), vbInformation)

        Dim sb As New System.Text.StringBuilder

        sb.AppendLine(".NET Version: " & System.Environment.Version.ToString())
        sb.AppendLine(".NET Build: " & System.Environment.Version.Build)

        TextBox1.Text = sb.ToString
    End Sub
End Class