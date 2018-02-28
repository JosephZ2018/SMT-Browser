<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchHistory
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
        Me.Rtb_result = New System.Windows.Forms.RichTextBox()
        Me.Btn_results1 = New System.Windows.Forms.Button()
        Me.Btn_result1 = New System.Windows.Forms.Button()
        Me.Btn_result12 = New System.Windows.Forms.Button()
        Me.Btn_result13 = New System.Windows.Forms.Button()
        Me.Btn_result14 = New System.Windows.Forms.Button()
        Me.Btn_quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Rtb_result
        '
        Me.Rtb_result.Location = New System.Drawing.Point(1, 3)
        Me.Rtb_result.Name = "Rtb_result"
        Me.Rtb_result.Size = New System.Drawing.Size(444, 437)
        Me.Rtb_result.TabIndex = 0
        Me.Rtb_result.Text = ""
        '
        'Btn_results1
        '
        Me.Btn_results1.Location = New System.Drawing.Point(4, 460)
        Me.Btn_results1.Name = "Btn_results1"
        Me.Btn_results1.Size = New System.Drawing.Size(75, 23)
        Me.Btn_results1.TabIndex = 1
        Me.Btn_results1.Text = "Gresults1"
        Me.Btn_results1.UseVisualStyleBackColor = True
        '
        'Btn_result1
        '
        Me.Btn_result1.Location = New System.Drawing.Point(4, 460)
        Me.Btn_result1.Name = "Btn_result1"
        Me.Btn_result1.Size = New System.Drawing.Size(75, 23)
        Me.Btn_result1.TabIndex = 1
        Me.Btn_result1.Text = "Gresults1"
        Me.Btn_result1.UseVisualStyleBackColor = True
        '
        'Btn_result12
        '
        Me.Btn_result12.Location = New System.Drawing.Point(85, 460)
        Me.Btn_result12.Name = "Btn_result12"
        Me.Btn_result12.Size = New System.Drawing.Size(75, 23)
        Me.Btn_result12.TabIndex = 1
        Me.Btn_result12.Text = "Gresults2"
        Me.Btn_result12.UseVisualStyleBackColor = True
        '
        'Btn_result13
        '
        Me.Btn_result13.Location = New System.Drawing.Point(166, 460)
        Me.Btn_result13.Name = "Btn_result13"
        Me.Btn_result13.Size = New System.Drawing.Size(75, 23)
        Me.Btn_result13.TabIndex = 1
        Me.Btn_result13.Text = "Gresults3"
        Me.Btn_result13.UseVisualStyleBackColor = True
        '
        'Btn_result14
        '
        Me.Btn_result14.Location = New System.Drawing.Point(247, 460)
        Me.Btn_result14.Name = "Btn_result14"
        Me.Btn_result14.Size = New System.Drawing.Size(75, 23)
        Me.Btn_result14.TabIndex = 1
        Me.Btn_result14.Text = "Gresults4"
        Me.Btn_result14.UseVisualStyleBackColor = True
        '
        'Btn_quit
        '
        Me.Btn_quit.Location = New System.Drawing.Point(346, 460)
        Me.Btn_quit.Name = "Btn_quit"
        Me.Btn_quit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_quit.TabIndex = 2
        Me.Btn_quit.Text = "Exit"
        Me.Btn_quit.UseVisualStyleBackColor = True
        '
        'SearchHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 495)
        Me.Controls.Add(Me.Btn_quit)
        Me.Controls.Add(Me.Btn_result13)
        Me.Controls.Add(Me.Btn_result12)
        Me.Controls.Add(Me.Btn_result14)
        Me.Controls.Add(Me.Btn_result1)
        Me.Controls.Add(Me.Btn_results1)
        Me.Controls.Add(Me.Rtb_result)
        Me.Name = "SearchHistory"
        Me.Text = "Keywords"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rtb_result As System.Windows.Forms.RichTextBox
    Friend WithEvents Btn_results1 As System.Windows.Forms.Button
    Friend WithEvents Btn_result1 As System.Windows.Forms.Button
    Friend WithEvents Btn_result12 As System.Windows.Forms.Button
    Friend WithEvents Btn_result13 As System.Windows.Forms.Button
    Friend WithEvents Btn_result14 As System.Windows.Forms.Button
    Friend WithEvents Btn_quit As System.Windows.Forms.Button
End Class
