<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnGenerateThumbnails = New System.Windows.Forms.Button()
        Me.btnWebcamFeed = New System.Windows.Forms.Button()
        Me.btnJSONEditor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Interface"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Image Resize", "Flash Window", "Windows 8 Toast Notificaiton", "Clickthough form", "Desktop Child Window", "Media Player", "Transparent PNG", "Capture Webcam Feed", "Timers", "Threads", "JSON Editor", "Web Browser Control", "Tray Icon"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 100)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 342)
        Me.ListBox1.TabIndex = 1
        '
        'btnGenerateThumbnails
        '
        Me.btnGenerateThumbnails.Location = New System.Drawing.Point(168, 100)
        Me.btnGenerateThumbnails.Name = "btnGenerateThumbnails"
        Me.btnGenerateThumbnails.Size = New System.Drawing.Size(140, 23)
        Me.btnGenerateThumbnails.TabIndex = 2
        Me.btnGenerateThumbnails.Text = "Generate Thumbnails"
        Me.btnGenerateThumbnails.UseVisualStyleBackColor = True
        '
        'btnWebcamFeed
        '
        Me.btnWebcamFeed.Location = New System.Drawing.Point(168, 129)
        Me.btnWebcamFeed.Name = "btnWebcamFeed"
        Me.btnWebcamFeed.Size = New System.Drawing.Size(140, 23)
        Me.btnWebcamFeed.TabIndex = 3
        Me.btnWebcamFeed.Text = "Webcam Feed"
        Me.btnWebcamFeed.UseVisualStyleBackColor = True
        '
        'btnJSONEditor
        '
        Me.btnJSONEditor.Location = New System.Drawing.Point(168, 158)
        Me.btnJSONEditor.Name = "btnJSONEditor"
        Me.btnJSONEditor.Size = New System.Drawing.Size(140, 23)
        Me.btnJSONEditor.TabIndex = 4
        Me.btnJSONEditor.Text = "JSON Editor"
        Me.btnJSONEditor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 458)
        Me.Controls.Add(Me.btnJSONEditor)
        Me.Controls.Add(Me.btnWebcamFeed)
        Me.Controls.Add(Me.btnGenerateThumbnails)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Winforms Forms Utilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnGenerateThumbnails As System.Windows.Forms.Button
    Friend WithEvents btnWebcamFeed As System.Windows.Forms.Button
    Friend WithEvents btnJSONEditor As System.Windows.Forms.Button

End Class
