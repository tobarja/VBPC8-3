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
        Me.Sentences = New System.Windows.Forms.ListBox()
        Me.btnMakeSentence = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Sentences
        '
        Me.Sentences.FormattingEnabled = True
        Me.Sentences.ItemHeight = 16
        Me.Sentences.Location = New System.Drawing.Point(16, 15)
        Me.Sentences.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sentences.Name = "Sentences"
        Me.Sentences.Size = New System.Drawing.Size(625, 212)
        Me.Sentences.TabIndex = 0
        '
        'btnMakeSentence
        '
        Me.btnMakeSentence.Location = New System.Drawing.Point(16, 235)
        Me.btnMakeSentence.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMakeSentence.Name = "btnMakeSentence"
        Me.btnMakeSentence.Size = New System.Drawing.Size(165, 43)
        Me.btnMakeSentence.TabIndex = 1
        Me.btnMakeSentence.Text = "Make Sentence"
        Me.btnMakeSentence.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(189, 235)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(165, 43)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear Sentences"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 235)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 43)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 322)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMakeSentence)
        Me.Controls.Add(Me.Sentences)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Random Sentences"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sentences As System.Windows.Forms.ListBox
    Friend WithEvents btnMakeSentence As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
