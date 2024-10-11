<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceSheetLong
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
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.chkBF = New System.Windows.Forms.CheckBox()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.cmbSubAcct = New System.Windows.Forms.ComboBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAccount = New System.Windows.Forms.ComboBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.cmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReportTitle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(12, 323)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 83
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'chkBF
        '
        Me.chkBF.AutoSize = True
        Me.chkBF.Location = New System.Drawing.Point(120, 283)
        Me.chkBF.Name = "chkBF"
        Me.chkBF.Size = New System.Drawing.Size(152, 17)
        Me.chkBF.TabIndex = 82
        Me.chkBF.Text = "Create Balance Forwarded"
        Me.chkBF.UseVisualStyleBackColor = True
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Location = New System.Drawing.Point(9, 182)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(72, 13)
        Me.lblSort.TabIndex = 72
        Me.lblSort.Text = "Sub Account:"
        '
        'cmbSubAcct
        '
        Me.cmbSubAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubAcct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubAcct.FormattingEnabled = True
        Me.cmbSubAcct.Location = New System.Drawing.Point(120, 179)
        Me.cmbSubAcct.Name = "cmbSubAcct"
        Me.cmbSubAcct.Size = New System.Drawing.Size(299, 21)
        Me.cmbSubAcct.TabIndex = 77
        '
        'dtDate
        '
        Me.dtDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(120, 243)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(299, 21)
        Me.dtDate.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Date:"
        '
        'cmbAccount
        '
        Me.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccount.FormattingEnabled = True
        Me.cmbAccount.Items.AddRange(New Object() {"Pre Closing", "Post Closing"})
        Me.cmbAccount.Location = New System.Drawing.Point(120, 211)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.Size = New System.Drawing.Size(299, 21)
        Me.cmbAccount.TabIndex = 71
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(9, 214)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(90, 13)
        Me.lblAccount.TabIndex = 78
        Me.lblAccount.Text = "Nominal Account:"
        '
        'cmbReport
        '
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Items.AddRange(New Object() {"Daily", "Monthly"})
        Me.cmbReport.Location = New System.Drawing.Point(120, 147)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(299, 21)
        Me.cmbReport.TabIndex = 76
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(9, 150)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(44, 13)
        Me.lblReport.TabIndex = 75
        Me.lblReport.Text = "Report:"
        '
        'cmbFormat
        '
        Me.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Items.AddRange(New Object() {"Default", "Summary"})
        Me.cmbFormat.Location = New System.Drawing.Point(120, 115)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(299, 21)
        Me.cmbFormat.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Format:"
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportTitle.Location = New System.Drawing.Point(12, 12)
        Me.txtReportTitle.Multiline = True
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportTitle.Size = New System.Drawing.Size(407, 96)
        Me.txtReportTitle.TabIndex = 81
        '
        'frmBalanceSheetLong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.chkBF)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.cmbSubAcct)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAccount)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.cmbReport)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.cmbFormat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Name = "frmBalanceSheetLong"
        Me.Text = "frmBalanceSheetLong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
    Friend WithEvents chkBF As System.Windows.Forms.CheckBox
    Friend WithEvents lblSort As System.Windows.Forms.Label
    Friend WithEvents cmbSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
End Class
