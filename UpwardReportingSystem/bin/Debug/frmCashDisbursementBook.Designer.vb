<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashDisbursementBook
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
        Me.txtReportTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.cmbOrder = New System.Windows.Forms.ComboBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubAccount = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSubAcct = New System.Windows.Forms.ComboBox()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportTitle.Location = New System.Drawing.Point(13, 12)
        Me.txtReportTitle.Multiline = True
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportTitle.Size = New System.Drawing.Size(407, 96)
        Me.txtReportTitle.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOrder)
        Me.GroupBox1.Controls.Add(Me.lblSort)
        Me.GroupBox1.Controls.Add(Me.cmbOrder)
        Me.GroupBox1.Controls.Add(Me.cmbSort)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 72)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(24, 44)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(39, 13)
        Me.lblOrder.TabIndex = 10
        Me.lblOrder.Text = "Order:"
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Location = New System.Drawing.Point(24, 20)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(31, 13)
        Me.lblSort.TabIndex = 9
        Me.lblSort.Text = "Sort:"
        '
        'cmbOrder
        '
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.FormattingEnabled = True
        Me.cmbOrder.Location = New System.Drawing.Point(80, 40)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(309, 21)
        Me.cmbOrder.TabIndex = 1
        '
        'cmbSort
        '
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Location = New System.Drawing.Point(80, 16)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(309, 21)
        Me.cmbSort.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Date:"
        '
        'lblSubAccount
        '
        Me.lblSubAccount.AutoSize = True
        Me.lblSubAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubAccount.Location = New System.Drawing.Point(13, 166)
        Me.lblSubAccount.Name = "lblSubAccount"
        Me.lblSubAccount.Size = New System.Drawing.Size(72, 13)
        Me.lblSubAccount.TabIndex = 29
        Me.lblSubAccount.Text = "Sub-Account:"
        '
        'dtDate
        '
        Me.dtDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(93, 189)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(327, 21)
        Me.dtDate.TabIndex = 31
        '
        'cmbSubAcct
        '
        Me.cmbSubAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubAcct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubAcct.FormattingEnabled = True
        Me.cmbSubAcct.Location = New System.Drawing.Point(93, 162)
        Me.cmbSubAcct.Name = "cmbSubAcct"
        Me.cmbSubAcct.Size = New System.Drawing.Size(327, 21)
        Me.cmbSubAcct.TabIndex = 28
        '
        'cmbReport
        '
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Location = New System.Drawing.Point(93, 138)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(327, 21)
        Me.cmbReport.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Report:"
        '
        'cmbFormat
        '
        Me.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Location = New System.Drawing.Point(93, 114)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(327, 21)
        Me.cmbFormat.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Format:"
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(12, 300)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 100
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'frmCashDisbursementBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSubAccount)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.cmbSubAcct)
        Me.Controls.Add(Me.cmbReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFormat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCashDisbursementBook"
        Me.Text = "Cash Disbursement Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents lblSort As System.Windows.Forms.Label
    Friend WithEvents cmbOrder As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSort As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSubAccount As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
End Class
