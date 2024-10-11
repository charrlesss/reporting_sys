Public Class frmPettyCashFundDisbursement
    Dim dt As DataTable
    Public sReport As String = ""
    Private Sub ReportTitle()
        txtReportTitle.Text = frmMain.ReportTitleByDepartment & IIf(cmbSubAcct.Text = "ALL", "", "(" & cmbSubAcct.Text & ")") & vbCrLf & _
                         "Petty Cash Fund Disbursement" & sReport & vbCrLf & _
                         "From " & txtFrom.Text & " to " & txtTo.Text
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

    Sub loadControls()
        LoadSubAccounts()
    End Sub
    Private Sub frmPettyCashFundDisbursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadControls()

        If frmMain.FieldStorage.ContainsKey("petty_cash_fund_cmbFund") And
            frmMain.FieldStorage.ContainsKey("petty_cash_fund_cmbSubAcct") And
            frmMain.FieldStorage.ContainsKey("petty_cash_fund_txtFrom") And
            frmMain.FieldStorage.ContainsKey("petty_cash_fund_txtTo") Then
            cmbFund.SelectedIndex = frmMain.FieldStorage("petty_cash_fund_cmbFund")
            cmbSubAcct.SelectedIndex = frmMain.FieldStorage("petty_cash_fund_cmbSubAcct")
            txtFrom.Text = frmMain.FieldStorage("petty_cash_fund_txtFrom")
            txtTo.Text = frmMain.FieldStorage("petty_cash_fund_txtTo")
        Else
            cmbSubAcct.SelectedIndex = 0
            cmbFund.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbSubAcct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubAcct.SelectedIndexChanged
        ReportTitle()

    End Sub

    Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs) Handles txtFrom.TextChanged
        ReportTitle()

    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged
        ReportTitle()

    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        frmMain.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"sub_acct", cmbSubAcct.Text},
           {"seriesFrom", txtFrom.Text},
           {"seriesTo", txtTo.Text}
       }
        frmMain.PostReportWithSummaryApi("/reports/accounting/petty-cash-fund-disbursement-desk", postData, AddressOf HandleApiResponse)
    End Sub
    Sub HandleApiResponse(dt As DataTable, dtSummary As DataTable)
        StoredFields()
        frmMain.HideLoading()
        If (dt.Rows.Count <= 0 And dtSummary.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        Dim rpt As New rptPettyCashFund
        rpt.SetDataSource(dt)
        rpt.Subreports(0).SetDataSource(dtSummary)
        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text

        frmMain.CrystalReportViewer1.Refresh()
        frmMain.CrystalReportViewer1.ReportSource = rpt
        Me.ParentForm.Close()
    End Sub
    Sub StoredFields()
        frmMain.FieldStorage("petty_cash_fund_cmbFund") = cmbFund.SelectedIndex
        frmMain.FieldStorage("petty_cash_fund_cmbSubAcct") = cmbSubAcct.SelectedIndex
        frmMain.FieldStorage("petty_cash_fund_txtFrom") = txtFrom.Text
        frmMain.FieldStorage("petty_cash_fund_txtTo") = txtTo.Text
    End Sub

End Class