<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tslSearch = New System.Windows.Forms.ToolStripLabel()
        Me.tstSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslRecord = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslSearch, Me.tstSearch, Me.tsbOpen})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(392, 25)
        Me.tsMain.TabIndex = 49
        Me.tsMain.Text = "ToolStrip1"
        '
        'tslSearch
        '
        Me.tslSearch.Margin = New System.Windows.Forms.Padding(0, 1, 1, 2)
        Me.tslSearch.Name = "tslSearch"
        Me.tslSearch.Size = New System.Drawing.Size(45, 22)
        Me.tslSearch.Text = "Search:"
        '
        'tstSearch
        '
        Me.tstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstSearch.Name = "tstSearch"
        Me.tstSearch.Size = New System.Drawing.Size(310, 25)
        Me.tstSearch.ToolTipText = "Search"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 20)
        Me.tsbOpen.Text = "ToolStripButton1"
        Me.tsbOpen.ToolTipText = "Search"
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvSearch.ColumnHeadersHeight = 18
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearch.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearch.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSearch.Location = New System.Drawing.Point(0, 26)
        Me.dgvSearch.MultiSelect = False
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.RowHeadersVisible = False
        Me.dgvSearch.RowTemplate.Height = 18
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(392, 392)
        Me.dgvSearch.TabIndex = 48
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslRecord})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 418)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(392, 22)
        Me.StatusStrip1.TabIndex = 50
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel1.Text = "  Records:"
        '
        'tslRecord
        '
        Me.tslRecord.Name = "tslRecord"
        Me.tslRecord.Size = New System.Drawing.Size(13, 17)
        Me.tslRecord.Text = "0"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 440)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.dgvSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmSearch"
        Me.Text = "frmSearch"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tslSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslRecord As System.Windows.Forms.ToolStripStatusLabel
End Class
