Public Class frmSubsidiaryLedger
    Dim Subsi As String = ""

    Sub getCIDNoSubAccount(dt As DataTable)
        If (dt.Rows.Count > 0) Then
            If cmbSubsi.SelectedIndex = 1 Then
                Subsi = "id no.: " & dt.Rows(0)(0).ToString() & " (" & txtSubsi.Text.Trim & ")"

            ElseIf cmbSubsi.SelectedIndex = 2 Then
                Subsi = "sub account: " & dt.Rows(0)(1).ToString() & " (" & txtSubsi.Text.Trim & ")"

            End If
        End If
    End Sub


    Private Sub ReportTitle()
        txtReportTitle.Text = frmMain.ReportTitleByDepartment & vbCrLf & _
                              "Subsidiary Ledger" & vbCrLf & vbCrLf & _
                              "Account: " & txtAccountName.Text & " (" & txtAccount.Text & ")" & _
                              IIf(cmbSubsi.SelectedIndex = 0, "", vbCrLf & Subsi) & vbCrLf & _
                              "For the Period: " & dtDateFrom.Value.ToString("MMM dd, yyyy") & " to " & dtDateTo.Value.ToString("MMM dd, yyyy")
    End Sub
    Private Sub frmSubsidiaryLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmMain.FieldStorage.ContainsKey("subsidiary_ledger_cmbSubsi") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_cmbFormat") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_cmbField") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_dtDateFrom") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_dtDateTo") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_txtAccount") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_txtAccountName") And
            frmMain.FieldStorage.ContainsKey("subsidiary_ledger_txtSubsi") Then

            cmbSubsi.SelectedIndex = frmMain.FieldStorage("subsidiary_ledger_cmbSubsi")
            cmbFormat.SelectedIndex = frmMain.FieldStorage("subsidiary_ledger_cmbFormat")
            cmbField.SelectedIndex = frmMain.FieldStorage("subsidiary_ledger_cmbField")
            dtDateFrom.Value = frmMain.FieldStorage("subsidiary_ledger_dtDateFrom")
            dtDateTo.Value = frmMain.FieldStorage("subsidiary_ledger_dtDateTo")
            txtAccount.Text = frmMain.FieldStorage("subsidiary_ledger_txtAccount")
            txtAccountName.Text = frmMain.FieldStorage("subsidiary_ledger_txtAccountName")
            txtSubsi.Text = frmMain.FieldStorage("subsidiary_ledger_txtSubsi")
        Else
            cmbSubsi.SelectedIndex = 0
            cmbFormat.SelectedIndex = 0
            cmbField.SelectedIndex = 0
        End If


    End Sub

    Private Sub cmbSubsi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubsi.SelectedIndexChanged
        txtSubsi.Text = ""
        If cmbSubsi.Text = "ALL" Then
            txtSubsi.Enabled = False
        Else
            txtSubsi.Enabled = True
        End If
        ReportTitle()
    End Sub

    Private Sub txtAccount_TextChanged(sender As Object, e As EventArgs) Handles txtAccount.TextChanged
        If txtAccount.Text = Nothing Then
            txtAccountName.Text = Nothing
        End If
    End Sub

    Private Sub txtAccountName_TextChanged(sender As Object, e As EventArgs) Handles txtAccountName.TextChanged
        ReportTitle()
    End Sub

    Private Sub txtSubsi_TextChanged(sender As Object, e As EventArgs) Handles txtSubsi.TextChanged
        If cmbSubsi.SelectedIndex = 1 Then
            frmMain.GetReportTableApi("/reports/accounting/subsidiary-ledger-report-get-cINo-Sub-desk?search=" & txtSubsi.Text.Trim, AddressOf getCIDNoSubAccount)

        ElseIf cmbSubsi.SelectedIndex = 2 Then
            frmMain.GetReportTableApi("/reports/accounting/subsidiary-ledger-report-get-cINo-Sub-desk?search=" & txtSubsi.Text.Trim, AddressOf getCIDNoSubAccount)
        End If
        ReportTitle()
    End Sub

    Private Sub dtDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtDateFrom.ValueChanged
        ReportTitle()
    End Sub

    Private Sub dtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtDateTo.ValueChanged
        ReportTitle()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim frmMSearch As New frmSearch

        If frmMSearch.Search("Chart of Account", txtAccount.Text.Trim) Then
            txtAccount.Text = frmMSearch.RetVal1
            txtAccountName.Text = frmMSearch.RetVal2
            ReportTitle()
        End If
    End Sub

    Private Sub txtAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccount.KeyDown
        If txtAccount.Text = Nothing Then Exit Sub
        frmMain.GetReportTableApi("/reports/accounting/subsidiary-ledger-report-get-acct-title-desk?Acct_Code=" & txtAccount.Text, AddressOf TitleResponse)
    End Sub

    Sub TitleResponse(dt As DataTable)
        If dt.Rows.Count > 0 Then
            txtAccountName.Text = dt(0)(0).ToString
        End If
    End Sub




    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        If txtAccount.Text.Trim = "" Then
            MsgBox("Provide account", MsgBoxStyle.Information)
            Exit Sub
        End If

        frmMain.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"dateFrom", dtDateFrom.Value},
           {"dateTo", dtDateTo.Value},
           {"subsi", cmbSubsi.SelectedIndex},
           {"subsi_options", txtSubsi.Text},
           {"account", txtAccount.Text},
           {"mField", cmbField.Text}
       }

        frmMain.PostReportApi("/reports/accounting/subsidiary-ledger-report-desk", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        StoredFields()
        frmMain.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        If cmbFormat.Text = "No Running Balance" Then
            Dim rpt As New rptCRLedger1
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()
        Else
            Dim rpt As New rptCRLedger2
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()
        End If
    End Sub

    Sub StoredFields()
        frmMain.FieldStorage("subsidiary_ledger_cmbSubsi") = cmbSubsi.SelectedIndex
        frmMain.FieldStorage("subsidiary_ledger_cmbFormat") = cmbFormat.SelectedIndex
        frmMain.FieldStorage("subsidiary_ledger_cmbField") = cmbField.SelectedIndex
        frmMain.FieldStorage("subsidiary_ledger_dtDateFrom") = dtDateFrom.Value
        frmMain.FieldStorage("subsidiary_ledger_dtDateTo") = dtDateTo.Value
        frmMain.FieldStorage("subsidiary_ledger_txtAccount") = txtAccount.Text
        frmMain.FieldStorage("subsidiary_ledger_txtAccountName") = txtAccountName.Text
        frmMain.FieldStorage("subsidiary_ledger_txtSubsi") = txtSubsi.Text
    End Sub


End Class