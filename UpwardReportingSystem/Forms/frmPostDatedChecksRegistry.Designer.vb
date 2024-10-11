<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostDatedChecksRegistry
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReportTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOrder = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.cmbPDCBranch = New System.Windows.Forms.ComboBox()
        Me.cmbPDCField = New System.Windows.Forms.ComboBox()
        Me.cmbPDCFormat = New System.Windows.Forms.ComboBox()
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Type:"
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportTitle.Location = New System.Drawing.Point(13, 12)
        Me.txtReportTitle.Multiline = True
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportTitle.Size = New System.Drawing.Size(407, 96)
        Me.txtReportTitle.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Date To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Date From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Branch:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Field:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Order:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sort:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Format:"
        '
        'cmbOrder
        '
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.FormattingEnabled = True
        Me.cmbOrder.Location = New System.Drawing.Point(80, 37)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(321, 21)
        Me.cmbOrder.TabIndex = 1
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"All", "Rent", "Loan"})
        Me.cmbType.Location = New System.Drawing.Point(97, 234)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(323, 21)
        Me.cmbType.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbOrder)
        Me.GroupBox1.Controls.Add(Me.cmbSort)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 66)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'cmbSort
        '
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Location = New System.Drawing.Point(80, 13)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(321, 21)
        Me.cmbSort.TabIndex = 0
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "MMMM dd, yyyy"
        Me.dtDateTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(97, 210)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.ShowUpDown = True
        Me.dtDateTo.Size = New System.Drawing.Size(323, 21)
        Me.dtDateTo.TabIndex = 28
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "MMMM dd, yyyy"
        Me.dtDateFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(97, 186)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.ShowUpDown = True
        Me.dtDateFrom.Size = New System.Drawing.Size(323, 21)
        Me.dtDateFrom.TabIndex = 27
        '
        'cmbPDCBranch
        '
        Me.cmbPDCBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPDCBranch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPDCBranch.FormattingEnabled = True
        Me.cmbPDCBranch.Location = New System.Drawing.Point(97, 162)
        Me.cmbPDCBranch.Name = "cmbPDCBranch"
        Me.cmbPDCBranch.Size = New System.Drawing.Size(323, 21)
        Me.cmbPDCBranch.TabIndex = 26
        '
        'cmbPDCField
        '
        Me.cmbPDCField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPDCField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPDCField.FormattingEnabled = True
        Me.cmbPDCField.Location = New System.Drawing.Point(97, 138)
        Me.cmbPDCField.Name = "cmbPDCField"
        Me.cmbPDCField.Size = New System.Drawing.Size(323, 21)
        Me.cmbPDCField.TabIndex = 25
        '
        'cmbPDCFormat
        '
        Me.cmbPDCFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPDCFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPDCFormat.FormattingEnabled = True
        Me.cmbPDCFormat.Location = New System.Drawing.Point(97, 114)
        Me.cmbPDCFormat.Name = "cmbPDCFormat"
        Me.cmbPDCFormat.Size = New System.Drawing.Size(323, 21)
        Me.cmbPDCFormat.TabIndex = 24
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(13, 336)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 98
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'frmPostDatedChecksRegistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtDateTo)
        Me.Controls.Add(Me.dtDateFrom)
        Me.Controls.Add(Me.cmbPDCBranch)
        Me.Controls.Add(Me.cmbPDCField)
        Me.Controls.Add(Me.cmbPDCFormat)
        Me.Name = "frmPostDatedChecksRegistry"
        Me.Text = "Post Dated Checks Registry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbOrder As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSort As System.Windows.Forms.ComboBox
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPDCBranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPDCField As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPDCFormat As System.Windows.Forms.ComboBox
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
End Class
