Public Class FormTextBoxWithSymbols



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ProcessText()
        ListBox1.Visible = False

    End Sub


    Private Sub ProcessText()



        Dim s = New Dictionary(Of String, String)

        s.Add("!u!", "☂")
        s.Add("!heart!", "❤")
        s.Add("!v!", "✔")
        s.Add("!x!", "❌")
        s.Add("!sun!", "☀")
        s.Add("!star!", "★")
        s.Add("!diamond!", "♢")
        s.Add("!bolt!", "⚡")


        For Each key In s.Keys

            Dim p = TextBox1.SelectionStart
            TextBox1.Text = TextBox1.Text.Replace(key, s(key))
            TextBox1.SelectionStart = p
            ' How do I find the position of a cursor in a text box? C#
            ' myTextBox.Text = myTextBox.Text.Insert(myTextBox.SelectionStart, "Hello world");

        Next

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = "`") Then
            ListBox1.Visible = True
            ListBox1.Location = TextBox1.GetPositionFromCharIndex(IIf(TextBox1.SelectionStart > 0, TextBox1.SelectionStart - 1, 0))
            ListBox1.Location = New Point(ListBox1.Location.X + TextBox1.Left, ListBox1.Location.Y + TextBox1.Top)
            e.Handled = True
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        TextBox1.Text = TextBox1.Text.Insert(TextBox1.SelectionStart, ListBox1.SelectedItem)
        ListBox1.Visible = False
    End Sub
End Class


