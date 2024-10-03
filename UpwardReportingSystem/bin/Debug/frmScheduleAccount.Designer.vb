<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleAccount))
        Me.cmbOrder = New System.Windows.Forms.ComboBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSubsi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.txtReportTitle = New System.Windows.Forms.RichTextBox()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSubsi = New System.Windows.Forms.TextBox()
        Me.cmbInsurance = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbOrder
        '
        Me.cmbOrder.FormattingEnabled = True
        Me.cmbOrder.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.cmbOrder.Location = New System.Drawing.Point(82, 287)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(336, 21)
        Me.cmbOrder.TabIndex = 32
        '
        'cmbSort
        '
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"Name", "Sub Account/I.D. No."})
        Me.cmbSort.Location = New System.Drawing.Point(82, 259)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(336, 21)
        Me.cmbSort.TabIndex = 31
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(16, 338)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 30
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Date From:"
        '
        'dtDate
        '
        Me.dtDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(82, 222)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(336, 20)
        Me.dtDate.TabIndex = 28
        '
        'cmbSubsi
        '
        Me.cmbSubsi.FormattingEnabled = True
        Me.cmbSubsi.Location = New System.Drawing.Point(82, 194)
        Me.cmbSubsi.Name = "cmbSubsi"
        Me.cmbSubsi.Size = New System.Drawing.Size(195, 21)
        Me.cmbSubsi.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Subsidiary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Account:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Report:"
        '
        'cmbReport
        '
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Items.AddRange(New Object() {"GL Account (Detailed)", "All Accounts"})
        Me.cmbReport.Location = New System.Drawing.Point(82, 116)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(336, 21)
        Me.cmbReport.TabIndex = 21
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Location = New System.Drawing.Point(11, 7)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Size = New System.Drawing.Size(407, 96)
        Me.txtReportTitle.TabIndex = 20
        Me.txtReportTitle.Text = ""
        '
        'txtAccountName
        '
        Me.txtAccountName.Location = New System.Drawing.Point(82, 167)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.ReadOnly = True
        Me.txtAccountName.Size = New System.Drawing.Size(336, 20)
        Me.txtAccountName.TabIndex = 19
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(82, 141)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(273, 20)
        Me.txtAccount.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Sort:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Order:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(361, 141)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 21)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSubsi
        '
        Me.txtSubsi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubsi.Location = New System.Drawing.Point(283, 195)
        Me.txtSubsi.Name = "txtSubsi"
        Me.txtSubsi.Size = New System.Drawing.Size(135, 21)
        Me.txtSubsi.TabIndex = 57
        Me.txtSubsi.Text = "All"
        Me.txtSubsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbInsurance
        '
        Me.cmbInsurance.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInsurance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInsurance.FormattingEnabled = True
        Me.cmbInsurance.Location = New System.Drawing.Point(283, 195)
        Me.cmbInsurance.Name = "cmbInsurance"
        Me.cmbInsurance.Size = New System.Drawing.Size(135, 21)
        Me.cmbInsurance.TabIndex = 59
        Me.cmbInsurance.Visible = False
        '
        'frmScheduleAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.cmbInsurance)
        Me.Controls.Add(Me.txtSubsi)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbOrder)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.cmbSubsi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbReport)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.txtAccount)
        Me.Name = "frmScheduleAccount"
        Me.Text = "Schedule of Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbOrder As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSort As System.Windows.Forms.ComboBox
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSubsi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents txtReportTitle As System.Windows.Forms.RichTextBox
    Friend WithEvents txtAccountName As System.Windows.Forms.TextBox
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSubsi As System.Windows.Forms.TextBox
    Friend WithEvents cmbInsurance As System.Windows.Forms.ComboBox
End Class
