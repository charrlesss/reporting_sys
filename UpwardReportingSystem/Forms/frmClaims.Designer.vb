<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaims
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClaims))
        Me.txtReportTitle = New System.Windows.Forms.TextBox()
        Me.cmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.dtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.lblClaimType = New System.Windows.Forms.Label()
        Me.cmbClaimType = New System.Windows.Forms.ComboBox()
        Me.lblPolicyNo = New System.Windows.Forms.Label()
        Me.txtPolicyNo = New System.Windows.Forms.TextBox()
        Me.txtAssuredName = New System.Windows.Forms.TextBox()
        Me.lblAssuredName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
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
        Me.txtReportTitle.TabIndex = 111
        '
        'cmbFormat
        '
        Me.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Items.AddRange(New Object() {"Date Created", "Date Claim", "Date Inspected", "Date Received", "Claim Type", "Policy No"})
        Me.cmbFormat.Location = New System.Drawing.Point(88, 117)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(332, 21)
        Me.cmbFormat.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Format:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(10, 174)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(42, 13)
        Me.lblStatus.TabIndex = 117
        Me.lblStatus.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"All", "Ongoing", "Denied", "Done"})
        Me.cmbStatus.Location = New System.Drawing.Point(88, 171)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(332, 21)
        Me.cmbStatus.TabIndex = 116
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFrom.Location = New System.Drawing.Point(10, 202)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(61, 13)
        Me.lblDateFrom.TabIndex = 118
        Me.lblDateFrom.Text = "Date From:"
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "MMMM dd, yyyy"
        Me.dtDateFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(88, 198)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Size = New System.Drawing.Size(332, 21)
        Me.dtDateFrom.TabIndex = 119
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTo.Location = New System.Drawing.Point(10, 229)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(49, 13)
        Me.lblDateTo.TabIndex = 120
        Me.lblDateTo.Text = "Date To:"
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "MMMM dd, yyyy"
        Me.dtDateTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(88, 225)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(332, 21)
        Me.dtDateTo.TabIndex = 121
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(10, 147)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(44, 13)
        Me.lblReport.TabIndex = 123
        Me.lblReport.Text = "Report:"
        '
        'cmbReport
        '
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Items.AddRange(New Object() {"Daily", "Monthly", "Custom"})
        Me.cmbReport.Location = New System.Drawing.Point(88, 144)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(332, 21)
        Me.cmbReport.TabIndex = 122
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(13, 257)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 124
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'lblClaimType
        '
        Me.lblClaimType.AutoSize = True
        Me.lblClaimType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaimType.Location = New System.Drawing.Point(10, 147)
        Me.lblClaimType.Name = "lblClaimType"
        Me.lblClaimType.Size = New System.Drawing.Size(72, 13)
        Me.lblClaimType.TabIndex = 126
        Me.lblClaimType.Text = "Claim Report:"
        '
        'cmbClaimType
        '
        Me.cmbClaimType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClaimType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClaimType.FormattingEnabled = True
        Me.cmbClaimType.Items.AddRange(New Object() {"OWN DAMAGE", "LOST/CARNAP", "VTPL-PROPERTY DAMAGE", "VTPL-BODILY INJURY", "THIRD PARTY-DEATH"})
        Me.cmbClaimType.Location = New System.Drawing.Point(88, 144)
        Me.cmbClaimType.Name = "cmbClaimType"
        Me.cmbClaimType.Size = New System.Drawing.Size(332, 21)
        Me.cmbClaimType.TabIndex = 125
        '
        'lblPolicyNo
        '
        Me.lblPolicyNo.AutoSize = True
        Me.lblPolicyNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolicyNo.Location = New System.Drawing.Point(10, 148)
        Me.lblPolicyNo.Name = "lblPolicyNo"
        Me.lblPolicyNo.Size = New System.Drawing.Size(58, 13)
        Me.lblPolicyNo.TabIndex = 127
        Me.lblPolicyNo.Text = "Policy No.:"
        '
        'txtPolicyNo
        '
        Me.txtPolicyNo.Location = New System.Drawing.Point(88, 145)
        Me.txtPolicyNo.Name = "txtPolicyNo"
        Me.txtPolicyNo.Size = New System.Drawing.Size(296, 20)
        Me.txtPolicyNo.TabIndex = 128
        '
        'txtAssuredName
        '
        Me.txtAssuredName.Location = New System.Drawing.Point(88, 172)
        Me.txtAssuredName.Name = "txtAssuredName"
        Me.txtAssuredName.ReadOnly = True
        Me.txtAssuredName.Size = New System.Drawing.Size(332, 20)
        Me.txtAssuredName.TabIndex = 130
        '
        'lblAssuredName
        '
        Me.lblAssuredName.AutoSize = True
        Me.lblAssuredName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssuredName.Location = New System.Drawing.Point(10, 174)
        Me.lblAssuredName.Name = "lblAssuredName"
        Me.lblAssuredName.Size = New System.Drawing.Size(80, 13)
        Me.lblAssuredName.TabIndex = 129
        Me.lblAssuredName.Text = "Assured Name:"
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
        Me.btnSearch.Location = New System.Drawing.Point(396, 144)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 21)
        Me.btnSearch.TabIndex = 131
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtAssuredName)
        Me.Controls.Add(Me.lblAssuredName)
        Me.Controls.Add(Me.txtPolicyNo)
        Me.Controls.Add(Me.lblPolicyNo)
        Me.Controls.Add(Me.lblClaimType)
        Me.Controls.Add(Me.cmbClaimType)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.cmbReport)
        Me.Controls.Add(Me.lblDateTo)
        Me.Controls.Add(Me.dtDateTo)
        Me.Controls.Add(Me.lblDateFrom)
        Me.Controls.Add(Me.dtDateFrom)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFormat)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Name = "frmClaims"
        Me.Text = "Claims"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents dtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateTo As System.Windows.Forms.Label
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
    Friend WithEvents lblClaimType As System.Windows.Forms.Label
    Friend WithEvents cmbClaimType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPolicyNo As System.Windows.Forms.Label
    Friend WithEvents txtPolicyNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAssuredName As System.Windows.Forms.TextBox
    Friend WithEvents lblAssuredName As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
