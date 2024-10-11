Public Class frmRenewalNotice
    Private Sub ReportTitle()
        txtReportTitle.Text = frmMain.ReportTitleByDepartment & vbCrLf &
                                "Renewal Notice Report"
    End Sub

    Sub getAccounts(dt As DataTable)
        If dt.Rows.Count > 0 Then
            cmbAccount.Items.Add("ALL")
            For i As Integer = 0 To dt.Rows.Count - 1
                cmbAccount.Items.Add(dt(i)("Account").ToString)
            Next
        End If
    End Sub
    Private Sub LoadType()
        cmbPolicy.Items.Add("COM")
        cmbPolicy.Items.Add("FIRE")
        cmbPolicy.Items.Add("MAR")
        cmbPolicy.Items.Add("PA")
    End Sub

    Private Sub LoadAccounts()
        frmMain.GetReportTableApi("/reports/accounting/get-report-policy-accounts", AddressOf getAccounts)
        ReportTitle()
        dtDate.Format = DateTimePickerFormat.Custom
        dtDate.CustomFormat = "MMMM yyyy"
        dtDate.ShowUpDown = True

    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        frmMain.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"policy", cmbPolicy.Text},
           {"account", cmbAccount.Text},
           {"type", cmbType.Text}
       }
        frmMain.PostReportApi("/reports/reports/renewal-notice", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        StoredFields()
        frmMain.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If
        StoredFields()

        If cmbPolicy.Text = "COM" And cmbType.Text = "Regular" Then
            Dim rpt As New rptRenewalNotice

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "COM" And cmbType.Text <> "Regular" Then
            Dim rpt As New rptRenewalNotice

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "FIRE" Then
            Dim rpt As New rptRenewalNoticeFire

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "MAR" Then
            Dim rpt As New rptRenewalNoticeMAR

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "PA" Then
            Dim rpt As New rptRenewalNoticePA

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            frmMain.CrystalReportViewer1.Refresh()
            frmMain.CrystalReportViewer1.ReportSource = rpt

        End If



        Me.ParentForm.Close()


    End Sub

    Sub StoredFields()
        frmMain.FieldStorage("renewal_notice_cmbPolicy") = cmbPolicy.SelectedIndex
        frmMain.FieldStorage("renewal_notice_cmbAccount") = cmbAccount.SelectedIndex
        frmMain.FieldStorage("renewal_notice_cmbType") = cmbType.SelectedIndex
        frmMain.FieldStorage("renewal_notice_dtDate") = dtDate.Value
    End Sub

    Private Sub frmRenewalNotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadType()
        LoadAccounts()

        If frmMain.FieldStorage.ContainsKey("renewal_notice_cmbPolicy") And
            frmMain.FieldStorage.ContainsKey("renewal_notice_cmbAccount") And
            frmMain.FieldStorage.ContainsKey("renewal_notice_cmbType") And
            frmMain.FieldStorage.ContainsKey("renewal_notice_dtDate") Then

            cmbPolicy.SelectedIndex = frmMain.FieldStorage("renewal_notice_cmbPolicy")
            cmbAccount.SelectedIndex = frmMain.FieldStorage("renewal_notice_cmbAccount")
            cmbType.SelectedIndex = frmMain.FieldStorage("renewal_notice_cmbType")
            dtDate.Value = frmMain.FieldStorage("renewal_notice_dtDate")
        Else
            cmbAccount.SelectedIndex = 0
            cmbPolicy.SelectedIndex = 0
            cmbType.SelectedIndex = 0
        End If


    End Sub
End Class