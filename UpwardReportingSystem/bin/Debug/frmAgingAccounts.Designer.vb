﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgingAccounts
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
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubAccount = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSubAcct = New System.Windows.Forms.ComboBox()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbpolicy = New System.Windows.Forms.ComboBox()
        Me.lblPolicy = New System.Windows.Forms.Label()
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
        Me.txtReportTitle.TabIndex = 110
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(13, 256)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 111
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Date:"
        '
        'lblSubAccount
        '
        Me.lblSubAccount.AutoSize = True
        Me.lblSubAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubAccount.Location = New System.Drawing.Point(13, 166)
        Me.lblSubAccount.Name = "lblSubAccount"
        Me.lblSubAccount.Size = New System.Drawing.Size(72, 13)
        Me.lblSubAccount.TabIndex = 106
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
        Me.dtDate.TabIndex = 108
        '
        'cmbSubAcct
        '
        Me.cmbSubAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubAcct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubAcct.FormattingEnabled = True
        Me.cmbSubAcct.Location = New System.Drawing.Point(93, 162)
        Me.cmbSubAcct.Name = "cmbSubAcct"
        Me.cmbSubAcct.Size = New System.Drawing.Size(327, 21)
        Me.cmbSubAcct.TabIndex = 105
        '
        'cmbReport
        '
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Location = New System.Drawing.Point(93, 138)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(327, 21)
        Me.cmbReport.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 103
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
        Me.cmbFormat.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Format:"
        '
        'cmbpolicy
        '
        Me.cmbpolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpolicy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpolicy.FormattingEnabled = True
        Me.cmbpolicy.Items.AddRange(New Object() {"Regular", "Temporary"})
        Me.cmbpolicy.Location = New System.Drawing.Point(93, 216)
        Me.cmbpolicy.Name = "cmbpolicy"
        Me.cmbpolicy.Size = New System.Drawing.Size(326, 21)
        Me.cmbpolicy.TabIndex = 112
        '
        'lblPolicy
        '
        Me.lblPolicy.AutoSize = True
        Me.lblPolicy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolicy.Location = New System.Drawing.Point(13, 219)
        Me.lblPolicy.Name = "lblPolicy"
        Me.lblPolicy.Size = New System.Drawing.Size(65, 13)
        Me.lblPolicy.TabIndex = 113
        Me.lblPolicy.Text = "Policy Type:"
        '
        'frmAgingAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.lblPolicy)
        Me.Controls.Add(Me.cmbpolicy)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSubAccount)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.cmbSubAcct)
        Me.Controls.Add(Me.cmbReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFormat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgingAccounts"
        Me.Text = "Aging of Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSubAccount As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbpolicy As System.Windows.Forms.ComboBox
    Friend WithEvents lblPolicy As System.Windows.Forms.Label
End Class
