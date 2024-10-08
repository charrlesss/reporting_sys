﻿Public Class frmPettyCashFundDisbursement
    Dim dt As DataTable
    Public sReport As String = ""
    Private Sub ReportTitle()
        txtReportTitle.Text = "UPWARD MANAGEMENT INSURANCE SERVICES " & IIf(cmbSubAcct.Text = "ALL", "", "(" & cmbSubAcct.Text & ")") & vbCrLf & _
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
        Form1.GetReportTableApi("/reports/accounting/get-sub-account-trial", AddressOf getSubAccount)
    End Sub

    Sub loadControls()
       
        LoadSubAccounts()
        cmbSubAcct.SelectedIndex = 0
        cmbFund.SelectedIndex = 0

    End Sub
    Private Sub frmPettyCashFundDisbursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadControls()
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
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"sub_acct", cmbSubAcct.Text},
           {"seriesFrom", txtFrom.Text},
           {"seriesTo", txtTo.Text}
       }
        Form1.PostReportWithSummaryApi("/reports/accounting/petty-cash-fund-disbursement-desk", postData, AddressOf HandleApiResponse)
    End Sub
    Sub HandleApiResponse(dt As DataTable, dtSummary As DataTable)
        Form1.HideLoading()
        If (dt.Rows.Count <= 0 And dtSummary.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        Dim rpt As New rptPettyCashFund
        rpt.SetDataSource(dt)
        rpt.Subreports(0).SetDataSource(dtSummary)
        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text

        Form1.CrystalReportViewer1.Refresh()
        Form1.CrystalReportViewer1.ReportSource = rpt
        Me.ParentForm.Close()
    End Sub
End Class