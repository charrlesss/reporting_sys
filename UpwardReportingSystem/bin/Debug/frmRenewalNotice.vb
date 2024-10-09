﻿Public Class frmRenewalNotice
    Private Sub ReportTitle()
        txtReportTitle.Text = "UPWARD MANAGEMENT INSURANCE SERVICES " & vbCrLf &
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
        Form1.GetReportTableApi("/reports/accounting/get-report-policy-accounts", AddressOf getAccounts)
        ReportTitle()
        dtDate.Format = DateTimePickerFormat.Custom
        dtDate.CustomFormat = "MMMM yyyy"
        dtDate.ShowUpDown = True

    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"policy", cmbPolicy.Text},
           {"account", cmbAccount.Text},
           {"type", cmbType.Text}
       }
        Form1.PostReportApi("/reports/reports/renewal-notice", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If
        StoredFields()

        If cmbPolicy.Text = "COM" And cmbType.Text = "Regular" Then
            Dim rpt As New rptRenewalNotice

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "COM" And cmbType.Text <> "Regular" Then
            Dim rpt As New rptRenewalNotice

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "FIRE" Then
            Dim rpt As New rptRenewalNoticeFire

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "MAR" Then
            Dim rpt As New rptRenewalNoticeMAR

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
        ElseIf cmbPolicy.Text = "PA" Then
            Dim rpt As New rptRenewalNoticePA

            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt

        End If


      
        Me.ParentForm.Close()


    End Sub

    Sub StoredFields()

        'Form1.FieldStorage("dtDate") = dtDate.Value
        ' Form1.FieldStorage("cmbReport") = cmbReport.SelectedIndex
        ' Form1.FieldStorage("cmbFormat") = cmbFormat.SelectedIndex
        ' Form1.FieldStorage("cmbSubAcct") = cmbSubAcct.SelectedIndex
        ' Form1.FieldStorage("cmbpolicy") = cmbpolicy.SelectedIndex
    End Sub

    Private Sub frmRenewalNotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadType()
        LoadAccounts()
        cmbAccount.SelectedIndex = 0
        cmbPolicy.SelectedIndex = 0
        cmbType.SelectedIndex = 0
    End Sub
End Class