<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedTextBoxTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AdvancedTextBox1 = New WinformsUtils.AdvancedTextBox()
        Me.SuspendLayout()
        '
        'AdvancedTextBox1
        '
        Me.AdvancedTextBox1.Location = New System.Drawing.Point(133, 100)
        Me.AdvancedTextBox1.Name = "AdvancedTextBox1"
        Me.AdvancedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AdvancedTextBox1.TabIndex = 0
        '
        'AdvancedTextBoxTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 377)
        Me.Controls.Add(Me.AdvancedTextBox1)
        Me.Name = "AdvancedTextBoxTest"
        Me.Text = "AdvancedTextBoxTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdvancedTextBox1 As WinformsUtils.AdvancedTextBox
End Class
