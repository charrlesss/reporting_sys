<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPettyCashFundDisbursement
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.cmbFund = New System.Windows.Forms.ComboBox()
        Me.cmbSubAcct = New System.Windows.Forms.ComboBox()
        Me.btnSchecSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportTitle.Location = New System.Drawing.Point(12, 12)
        Me.txtReportTitle.Multiline = True
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportTitle.Size = New System.Drawing.Size(407, 96)
        Me.txtReportTitle.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(93, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "ex. H 0412-999"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "To:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "ex. H 0401-001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Fund:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Sub-Account:"
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(93, 220)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(326, 21)
        Me.txtTo.TabIndex = 40
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(93, 172)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(326, 21)
        Me.txtFrom.TabIndex = 39
        '
        'cmbFund
        '
        Me.cmbFund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFund.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFund.FormattingEnabled = True
        Me.cmbFund.Items.AddRange(New Object() {"Petty Cash"})
        Me.cmbFund.Location = New System.Drawing.Point(93, 124)
        Me.cmbFund.Name = "cmbFund"
        Me.cmbFund.Size = New System.Drawing.Size(326, 21)
        Me.cmbFund.TabIndex = 37
        '
        'cmbSubAcct
        '
        Me.cmbSubAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubAcct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubAcct.FormattingEnabled = True
        Me.cmbSubAcct.Location = New System.Drawing.Point(93, 148)
        Me.cmbSubAcct.Name = "cmbSubAcct"
        Me.cmbSubAcct.Size = New System.Drawing.Size(326, 21)
        Me.cmbSubAcct.TabIndex = 38
        '
        'btnSchecSubmit
        '
        Me.btnSchecSubmit.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSchecSubmit.Location = New System.Drawing.Point(12, 271)
        Me.btnSchecSubmit.Name = "btnSchecSubmit"
        Me.btnSchecSubmit.Size = New System.Drawing.Size(407, 31)
        Me.btnSchecSubmit.TabIndex = 99
        Me.btnSchecSubmit.Text = "Submit"
        Me.btnSchecSubmit.UseVisualStyleBackColor = False
        '
        'frmPettyCashFundDisbursement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 405)
        Me.Controls.Add(Me.btnSchecSubmit)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cmbFund)
        Me.Controls.Add(Me.cmbSubAcct)
        Me.Name = "frmPettyCashFundDisbursement"
        Me.Text = "Petty Cash Fund Disbursement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents cmbFund As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubAcct As System.Windows.Forms.ComboBox
    Friend WithEvents btnSchecSubmit As System.Windows.Forms.Button
End Class
