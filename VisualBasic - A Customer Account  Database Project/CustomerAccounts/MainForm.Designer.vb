<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByCustomerNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BylastNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCustNum = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNameTag = New System.Windows.Forms.Label()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 36)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 36)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 36)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewRecordToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(67, 36)
        Me.EditToolStripMenuItem.Text = "E&dit"
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(268, 36)
        Me.AddNewRecordToolStripMenuItem.Text = "Add &New Record"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByCustomerNumberToolStripMenuItem, Me.BylastNameToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ByCustomerNumberToolStripMenuItem
        '
        Me.ByCustomerNumberToolStripMenuItem.Name = "ByCustomerNumberToolStripMenuItem"
        Me.ByCustomerNumberToolStripMenuItem.Size = New System.Drawing.Size(321, 36)
        Me.ByCustomerNumberToolStripMenuItem.Text = "By Customer &Number"
        '
        'BylastNameToolStripMenuItem
        '
        Me.BylastNameToolStripMenuItem.Name = "BylastNameToolStripMenuItem"
        Me.BylastNameToolStripMenuItem.Size = New System.Drawing.Size(321, 36)
        Me.BylastNameToolStripMenuItem.Text = "By &Last Name"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(92, 36)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(155, 36)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPayment)
        Me.GroupBox1.Controls.Add(Me.lblAccount)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Controls.Add(Me.lblZip)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblCustNum)
        Me.GroupBox1.Controls.Add(Me.lblLast)
        Me.GroupBox1.Controls.Add(Me.lblFirst)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 501)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Information"
        '
        'lblPayment
        '
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPayment.Location = New System.Drawing.Point(242, 448)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(322, 25)
        Me.lblPayment.TabIndex = 22
        '
        'lblAccount
        '
        Me.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccount.Location = New System.Drawing.Point(242, 414)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(322, 25)
        Me.lblAccount.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Date of Last Payment:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 414)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Account Balance:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(131, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 25)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Zip Code:"
        '
        'lblCity
        '
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCity.Location = New System.Drawing.Point(242, 245)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(322, 25)
        Me.lblCity.TabIndex = 17
        '
        'lblZip
        '
        Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZip.Location = New System.Drawing.Point(242, 324)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(322, 25)
        Me.lblZip.TabIndex = 16
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.Location = New System.Drawing.Point(242, 287)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(322, 25)
        Me.lblState.TabIndex = 15
        '
        'lblPhone
        '
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.Location = New System.Drawing.Point(242, 373)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(322, 25)
        Me.lblPhone.TabIndex = 14
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Location = New System.Drawing.Point(242, 207)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(322, 25)
        Me.lblAddress.TabIndex = 13
        '
        'lblCustNum
        '
        Me.lblCustNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustNum.Location = New System.Drawing.Point(242, 168)
        Me.lblCustNum.Name = "lblCustNum"
        Me.lblCustNum.Size = New System.Drawing.Size(322, 25)
        Me.lblCustNum.TabIndex = 12
        '
        'lblLast
        '
        Me.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLast.Location = New System.Drawing.Point(242, 89)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(322, 25)
        Me.lblLast.TabIndex = 11
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(242, 129)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(322, 25)
        Me.lblFirst.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(181, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Telephone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Customer Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Customer Account Information"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(74, 606)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(221, 40)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous Record"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(326, 606)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(221, 40)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next Record"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(32, 661)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 56)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(228, 661)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 56)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(427, 661)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(169, 56)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblNameTag
        '
        Me.lblNameTag.AutoSize = True
        Me.lblNameTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNameTag.Location = New System.Drawing.Point(18, 51)
        Me.lblNameTag.Name = "lblNameTag"
        Me.lblNameTag.Size = New System.Drawing.Size(2, 27)
        Me.lblNameTag.TabIndex = 14
        '
        'pdPrint
        '
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(358, 51)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(229, 42)
        Me.btnAddNew.TabIndex = 15
        Me.btnAddNew.Text = "Add New Record"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 742)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.lblNameTag)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByCustomerNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BylastNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustNum As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblNameTag As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents pdPrint As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnAddNew As System.Windows.Forms.Button

End Class
