<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.PathBox = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(334, 12)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectButton.TabIndex = 0
        Me.SelectButton.Text = "Select"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'PathBox
        '
        Me.PathBox.Location = New System.Drawing.Point(12, 14)
        Me.PathBox.Name = "PathBox"
        Me.PathBox.Size = New System.Drawing.Size(316, 20)
        Me.PathBox.TabIndex = 1
        Me.PathBox.Text = "C:\Windows\System32\cmd.exe"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 40)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(397, 23)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 68)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.PathBox)
        Me.Controls.Add(Me.SelectButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "UAC Bypass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectButton As System.Windows.Forms.Button
    Friend WithEvents PathBox As System.Windows.Forms.TextBox
    Friend WithEvents StartButton As System.Windows.Forms.Button

End Class
