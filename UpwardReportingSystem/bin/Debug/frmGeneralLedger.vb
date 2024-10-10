Public Class frmGeneralLedger
    Dim dt As DataTable
    Public sReport As String = "General Ledger"
    Private Sub ReportTitle()
        txtReportTitle.Text = Form1.ReportTitleByDepartment & IIf(cmbSubAcct.Text = "ALL", "", "(" & cmbSubAcct.Text & ")") & vbCrLf & _
                         cmbReport.Text & " " & sReport & IIf(cmbFormat.SelectedIndex = 1, " (Per Revenue Center)", "") & vbCrLf & _
                         dtDate.Text
    End Sub

    Sub getSubAccount(dt As DataTable)
        If dt.Rows.Count > 0 Then
            cmbSubAcct.Items.Add("ALL")
            For i As Integer = 0 To dt.Rows.Count - 1
                cmbSubAcct.Items.Add(dt(i)("Sub_Acct").ToString)
            Next
        End If
    End Sub

    Private Sub LoadSubAccounts()
        Form1.GetReportTableApi("/reports/accounting/get-sub-account-trial", AddressOf getSubAccount)

    End Sub

    Private Sub frmGeneralLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubAccounts()

        If Form1.FieldStorage.ContainsKey("general_ledger_cmbFormat") And
            Form1.FieldStorage.ContainsKey("general_ledger_cmbReport") And
            Form1.FieldStorage.ContainsKey("general_ledger_cmbSubAcct") And
            Form1.FieldStorage.ContainsKey("general_ledger_cmbAccount") And
            Form1.FieldStorage.ContainsKey("general_ledger_dtDate") Then

            cmbFormat.SelectedIndex = Form1.FieldStorage("general_ledger_cmbFormat")
            cmbReport.SelectedIndex = Form1.FieldStorage("general_ledger_cmbReport")
            cmbSubAcct.SelectedIndex = Form1.FieldStorage("general_ledger_cmbSubAcct")
            cmbAccount.SelectedIndex = Form1.FieldStorage("general_ledger_cmbAccount")
            dtDate.Value = Form1.FieldStorage("general_ledger_dtDate")
        Else
            cmbFormat.SelectedIndex = 0
            cmbReport.SelectedIndex = 1
            cmbSubAcct.SelectedIndex = 0
            If cmbAccount.Enabled Then cmbAccount.SelectedIndex = 0
            dtDate.Value = Now
        End If

        ReportTitle()
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        If cmbReport.Text = "Monthly" Then
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "MMMM yyyy"
        Else
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "MMMM dd, yyyy"
            chkBF.Checked = False
        End If
        chkBF.Enabled = IIf(cmbReport.SelectedIndex = 1 And cmbSubAcct.SelectedIndex = 0, True, False)
        ReportTitle()
    End Sub

    Private Sub cmbSubAcct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubAcct.SelectedIndexChanged
        chkBF.Enabled = IIf(cmbReport.SelectedIndex = 1 And cmbSubAcct.SelectedIndex = 0, True, False)
        ReportTitle()
    End Sub

    Private Sub cmbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormat.SelectedIndexChanged
        If cmbFormat.SelectedIndex = 1 Then
            cmbSubAcct.SelectedIndex = 0
            cmbSubAcct.Enabled = False
        Else
            cmbSubAcct.Enabled = True
        End If
        ReportTitle()
    End Sub

    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        ReportTitle()
    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"sub_acct", cmbSubAcct.Text},
           {"dateFormat", cmbReport.Text},
            {"transSumm", "0"},
           {"account", cmbAccount.SelectedIndex},
           {"format", cmbFormat.SelectedIndex}
       }
        Form1.PostReportApi("/reports/accounting/general-ledger-report-desk", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        StoredFields()
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        If cmbFormat.SelectedIndex = 0 Then
            Dim rpt As New rptGeneralLedger
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()
        Else
            Dim rpt As New rptGeneralLedgerSumm
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()
        End If
    End Sub


    Sub StoredFields()


        Form1.FieldStorage("general_ledger_cmbFormat") = cmbFormat.SelectedIndex
        Form1.FieldStorage("general_ledger_cmbReport") = cmbReport.SelectedIndex
        Form1.FieldStorage("general_ledger_cmbSubAcct") = cmbSubAcct.SelectedIndex
        Form1.FieldStorage("general_ledger_cmbAccount") = cmbAccount.SelectedIndex
        Form1.FieldStorage("general_ledger_dtDate") = dtDate.Value
   
    End Sub


End Class