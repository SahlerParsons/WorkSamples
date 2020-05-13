<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisteredCoursesForm
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
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.ItemHeight = 40
        Me.lstCourses.Location = New System.Drawing.Point(62, 35)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(415, 244)
        Me.lstCourses.TabIndex = 0
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(62, 314)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(191, 80)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(286, 314)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(191, 80)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'RegisteredCoursesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 40.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 437)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.lstCourses)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RegisteredCoursesForm"
        Me.Text = "Selected Courses"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCourses As ListBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClose As Button
End Class
