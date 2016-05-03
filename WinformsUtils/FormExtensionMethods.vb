Imports System.Runtime.CompilerServices

Module FormExtensionMethods
    <Extension()>
    Sub DrawEllipse(form As Form, pen As Pen, x As Integer, y As Integer, width As Integer, height As Integer)
        Using g = form.CreateGraphics()
            'g.DrawLine(New Pen(Brushes.Black), e.X, e.Y, e.X, e.Y)
            g.DrawEllipse(pen, x, y, height, width)
        End Using
    End Sub

    Sub PSet(form As Form, pen As Pen, x As Integer, y As Integer)
        Using g = form.CreateGraphics()
            g.DrawRectangle(pen, x, y, 1, 1)
        End Using
    End Sub
End Module
