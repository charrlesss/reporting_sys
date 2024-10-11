Public Class frmBalanceSheetLong
    Dim dt As DataTable
    Public sReport As String = "Balance Sheet - Long"
    Private Sub ReportTitle()
        txtReportTitle.Text = frmMain.ReportTitleByDepartment & IIf(cmbSubAcct.Text = "ALL", "", "(" & cmbSubAcct.Text & ")") & vbCrLf & _
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
        frmMain.GetReportTableApi("/reports/accounting/get-sub-account-trial", AddressOf getSubAccount)
    End Sub

    Private Sub frmBalanceSheetLong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubAccounts()

        If frmMain.FieldStorage.ContainsKey("balance_sheet_cmbFormat") And
        frmMain.FieldStorage.ContainsKey("balance_sheet_cmbReport") And
        frmMain.FieldStorage.ContainsKey("balance_sheet_cmbSubAcct") And
        frmMain.FieldStorage.ContainsKey("balance_sheet_cmbAccount") And
        frmMain.FieldStorage.ContainsKey("balance_sheet_dtDate") Then
            cmbFormat.SelectedIndex = frmMain.FieldStorage("balance_sheet_cmbFormat")
            cmbReport.SelectedIndex = frmMain.FieldStorage("balance_sheet_cmbReport")
            cmbSubAcct.SelectedIndex = frmMain.FieldStorage("balance_sheet_cmbSubAcct")
            cmbAccount.SelectedIndex = frmMain.FieldStorage("balance_sheet_cmbAccount")
            dtDate.Value = frmMain.FieldStorage("balance_sheet_dtDate")
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
        frmMain.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"sub_acct", cmbSubAcct.Text},
           {"dateFormat", cmbReport.Text},
           {"format", cmbFormat.SelectedIndex}
       }
        frmMain.PostReportApi("/reports/accounting/balance-sheet-long-report-desk", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        StoredFields()
        frmMain.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        If cmbFormat.SelectedIndex = 0 Then
            Dim rpt As New rptBalanceSheet
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()
        Else
            Dim rpt As New rptBalanceSheetSumm
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()
        End If

    End Sub


    Sub StoredFields()
        frmMain.FieldStorage("balance_sheet_cmbFormat") = cmbFormat.SelectedIndex
        frmMain.FieldStorage("balance_sheet_cmbReport") = cmbReport.SelectedIndex
        frmMain.FieldStorage("balance_sheet_cmbSubAcct") = cmbSubAcct.SelectedIndex
        frmMain.FieldStorage("balance_sheet_cmbAccount") = cmbAccount.SelectedIndex
        frmMain.FieldStorage("balance_sheet_dtDate") = dtDate.Value
    End Sub

End Class