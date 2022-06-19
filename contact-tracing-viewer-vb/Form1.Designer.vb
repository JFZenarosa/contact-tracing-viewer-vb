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
        Me.label2 = New System.Windows.Forms.Label()
        Me.clrBtn = New System.Windows.Forms.Button()
        Me.openBtn = New System.Windows.Forms.Button()
        Me.textReader = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.label2.Location = New System.Drawing.Point(8, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(636, 33)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Mercury Drugs Contact Tracing Form Viewer"
        '
        'clrBtn
        '
        Me.clrBtn.Location = New System.Drawing.Point(14, 112)
        Me.clrBtn.Name = "clrBtn"
        Me.clrBtn.Size = New System.Drawing.Size(107, 34)
        Me.clrBtn.TabIndex = 7
        Me.clrBtn.Text = "Clear"
        Me.clrBtn.UseVisualStyleBackColor = True
        '
        'openBtn
        '
        Me.openBtn.Location = New System.Drawing.Point(14, 72)
        Me.openBtn.Name = "openBtn"
        Me.openBtn.Size = New System.Drawing.Size(107, 34)
        Me.openBtn.TabIndex = 6
        Me.openBtn.Text = "Open File"
        Me.openBtn.UseVisualStyleBackColor = True
        '
        'textReader
        '
        Me.textReader.Location = New System.Drawing.Point(127, 72)
        Me.textReader.Name = "textReader"
        Me.textReader.Size = New System.Drawing.Size(512, 370)
        Me.textReader.TabIndex = 5
        Me.textReader.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 458)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.clrBtn)
        Me.Controls.Add(Me.openBtn)
        Me.Controls.Add(Me.textReader)
        Me.Name = "Form1"
        Me.Text = "Contact Tracing Form Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents clrBtn As Button
    Private WithEvents openBtn As Button
    Private WithEvents textReader As RichTextBox
End Class
