<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCourses = New System.Windows.Forms.ComboBox()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a course you would like to take:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(639, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Days and Times:"
        '
        'cboCourses
        '
        Me.cboCourses.FormattingEnabled = True
        Me.cboCourses.Items.AddRange(New Object() {"COP 1110 Beginning Java ", "COP 1120 Beginning C++ ", "COP 1130 Beginning Visual Studio", "COP 1140 Beginning C# ", "COP 2210 Intermediate Java ", "COP 2120 Intermediate C++ ", "COP 2130 Intermediate Visual Studio", "COP 2140 Intermediate C#"})
        Me.cboCourses.Location = New System.Drawing.Point(30, 124)
        Me.cboCourses.Name = "cboCourses"
        Me.cboCourses.Size = New System.Drawing.Size(552, 45)
        Me.cboCourses.TabIndex = 2
        '
        'lblDateTime
        '
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateTime.Location = New System.Drawing.Point(639, 127)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(457, 42)
        Me.lblDateTime.TabIndex = 3
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(170, 214)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(251, 89)
        Me.BtnConfirm.TabIndex = 4
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(745, 214)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(251, 89)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 342)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.cboCourses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrationForm"
        Me.Text = "Register Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCourses As ComboBox
    Friend WithEvents lblDateTime As Label
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents BtnClose As Button
End Class
