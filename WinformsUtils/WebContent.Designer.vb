<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebContent
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnLoadImage = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAsyncLoadImage = New System.Windows.Forms.Button()
        Me.AsyncWebPhotoViewer1 = New WinformsUtils.AsyncWebPhotoViewer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(176, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 295)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(533, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnLoadImage
        '
        Me.btnLoadImage.Location = New System.Drawing.Point(133, 321)
        Me.btnLoadImage.Name = "btnLoadImage"
        Me.btnLoadImage.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadImage.TabIndex = 2
        Me.btnLoadImage.Text = "Load Image"
        Me.btnLoadImage.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(158, 277)
        Me.ListBox1.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 321)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(48, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(66, 321)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(61, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAsyncLoadImage
        '
        Me.btnAsyncLoadImage.Location = New System.Drawing.Point(214, 321)
        Me.btnAsyncLoadImage.Name = "btnAsyncLoadImage"
        Me.btnAsyncLoadImage.Size = New System.Drawing.Size(113, 23)
        Me.btnAsyncLoadImage.TabIndex = 7
        Me.btnAsyncLoadImage.Text = "Load Image Async"
        Me.btnAsyncLoadImage.UseVisualStyleBackColor = True
        '
        'AsyncWebPhotoViewer1
        '
        Me.AsyncWebPhotoViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AsyncWebPhotoViewer1.Location = New System.Drawing.Point(12, 350)
        Me.AsyncWebPhotoViewer1.Name = "AsyncWebPhotoViewer1"
        Me.AsyncWebPhotoViewer1.Size = New System.Drawing.Size(533, 283)
        Me.AsyncWebPhotoViewer1.TabIndex = 6
        '
        'WebContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 644)
        Me.Controls.Add(Me.btnAsyncLoadImage)
        Me.Controls.Add(Me.AsyncWebPhotoViewer1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnLoadImage)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "WebContent"
        Me.Text = "WebContent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadImage As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents AsyncWebPhotoViewer1 As WinformsUtils.AsyncWebPhotoViewer
    Friend WithEvents btnAsyncLoadImage As System.Windows.Forms.Button
End Class
