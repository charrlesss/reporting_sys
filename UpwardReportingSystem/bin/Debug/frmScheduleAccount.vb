Public Class frmScheduleAccount
  

    Private Sub ReportTitle()
        Select Case cmbReport.Text
            Case "GL Account (Detailed)"
                txtReportTitle.Text = Form1.ReportTitleByDepartment & IIf(txtSubsi.Text.Trim = "" Or txtSubsi.Text.Trim = "ALL", "", "(" & txtSubsi.Text.Trim & ")") & vbCrLf & _
                                      "Schedule of " & txtAccountName.Text.Trim & IIf(cmbInsurance.SelectedIndex = 2, " - " & cmbInsurance.Text, "") & " (" & txtAccount.Text.Trim & ")" & vbCrLf & _
                                      dtDate.Text
            Case "All Accounts"
                txtReportTitle.Text = Form1.ReportTitleByDepartment & IIf(txtSubsi.Text.Trim = "" Or txtSubsi.Text.Trim = "ALL", "", "(" & txtSubsi.Text.Trim & ")") & vbCrLf & _
                                      "Schedule of Accounts" & vbCrLf & _
                                      dtDate.Text
        End Select
    End Sub

    Sub Account(dt As DataTable)
        If dt.Rows.Count > 0 Then
            cmbInsurance.Items.Add("ALL")
            For i As Integer = 0 To dt.Rows.Count - 1
                cmbInsurance.Items.Add(dt(i)(0).ToString)
            Next
        End If
        cmbInsurance.SelectedIndex = 0

    End Sub
    Private Sub LoadAccounts()
        Form1.GetReportTableApi("/reports/accounting/chart-schedule-account-account-desk", AddressOf Account)
    End Sub





    Public Sub LoadSubsidiary()
        cmbSubsi.Items.Clear()
        Select Case cmbReport.SelectedIndex
            Case 0 '"GL Account (Detailed)"
                cmbSubsi.Items.Add("Sub Acct")
                cmbSubsi.Items.Add("I.D. No.")
                cmbSubsi.Items.Add("Insurance")
            Case 1 '"All Accounts"
                cmbSubsi.Items.Add("I.D. No.")
        End Select
    End Sub


    Private Sub frmScheduleAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubsidiary()
        LoadAccounts()


        If Form1.FieldStorage.ContainsKey("schedule_account_cmbReport") And
            Form1.FieldStorage.ContainsKey("schedule_account_cmbSubsi") And
            Form1.FieldStorage.ContainsKey("schedule_account_cmbInsurance") And
            Form1.FieldStorage.ContainsKey("schedule_account_cmbSort") And
            Form1.FieldStorage.ContainsKey("schedule_account_cmbOrder") And
            Form1.FieldStorage.ContainsKey("schedule_account_dtDate") And
            Form1.FieldStorage.ContainsKey("schedule_account_txtAccount") And
            Form1.FieldStorage.ContainsKey("schedule_account_txtAccountName") Then

            cmbReport.SelectedIndex = Form1.FieldStorage("schedule_account_cmbReport")
            LoadSubsidiary()
            cmbSubsi.SelectedIndex = Form1.FieldStorage("schedule_account_cmbSubsi")
            cmbInsurance.SelectedIndex = Form1.FieldStorage("schedule_account_cmbInsurance")
            cmbSort.SelectedIndex = Form1.FieldStorage("schedule_account_cmbSort")
            cmbOrder.SelectedIndex = Form1.FieldStorage("schedule_account_cmbOrder")
            dtDate.Value = Form1.FieldStorage("schedule_account_dtDate")
            txtAccount.Text = Form1.FieldStorage("schedule_account_txtAccount")
            txtAccountName.Text = Form1.FieldStorage("schedule_account_txtAccountName")
        Else
            cmbReport.SelectedIndex = 0
            LoadSubsidiary()
            cmbSubsi.SelectedIndex = 0
            cmbSort.SelectedIndex = 0
            cmbOrder.SelectedIndex = 0
        End If


    

    End Sub

    Private Sub cmbScheduleSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSort.SelectedIndexChanged

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

        If e.KeyCode = Keys.Enter Then
            Dim frmMSearch As New frmSearch

            If frmMSearch.Search("Chart of Account", txtAccount.Text.Trim) Then
                txtAccount.Text = frmMSearch.RetVal1
                txtAccountName.Text = frmMSearch.RetVal2
            End If
        End If

       

    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        Select Case cmbReport.SelectedIndex
            Case 0 '"GL Account (Detailed)"
                txtAccount.Enabled = True
                btnSearch.Enabled = True
            Case 1 '"All Accounts"
                txtAccount.Enabled = False
                btnSearch.Enabled = False
        End Select

        ReportTitle()
    End Sub

    Private Sub cmbInsurance_SelectedIndexChanged(sender As Object, e As EventArgs)
        ReportTitle()
    End Sub

    Private Sub txtAccountName_TextChanged(sender As Object, e As EventArgs) Handles txtAccountName.TextChanged
        ReportTitle()
    End Sub

    Private Sub txtAccount_TextChanged(sender As Object, e As EventArgs) Handles txtAccount.TextChanged
        ReportTitle()
    End Sub

    Private Sub cmbSubsi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubsi.SelectedIndexChanged
        cmbInsurance.Visible = IIf(cmbSubsi.SelectedIndex = 2, True, False)
    End Sub


    Private Sub txtSubsi_TextChanged(sender As Object, e As EventArgs) Handles txtSubsi.TextChanged
        If txtSubsi.Text.Trim = "" Then txtSubsi.Text = "ALL"
    End Sub


    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        If txtAccount.Text.Trim = "" And cmbReport.Text = "GL Account (Detailed)" Then
            MsgBox("Provide account", MsgBoxStyle.Information)
            Form1.HideLoading()

            Exit Sub
        End If

        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"report", cmbReport.Text},
           {"subsi", cmbSubsi.SelectedIndex},
           {"subsiText", txtSubsi.Text},
           {"account", txtAccount.Text},
           {"insurance", cmbInsurance.Text},
           {"order", cmbOrder.SelectedIndex},
           {"sort", cmbSort.SelectedIndex}
       }
        Form1.PostReportApi("/reports/accounting/schedule-account-report-desk", postData, AddressOf HandleApiResponse)
    End Sub
    Private Sub HandleApiResponse(dt As DataTable)
        StoredFields()
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If


        If cmbSubsi.SelectedIndex = 0 Then

            Select Case cmbReport.SelectedIndex
                Case 0 '"GL Account(Detailed)"
                    Dim rpt As New rptSchedule_Sub
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.ReportSource = rpt
                    Me.ParentForm.Close()


                Case 1 '"GL Account(Detailed)"
                    Dim rpt As New rptSchedule_Sub
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.ReportSource = rpt
                    Me.ParentForm.Close()


            End Select
        ElseIf cmbSubsi.SelectedIndex = 1 Then
            If txtSubsi.Text.Trim.ToUpper <> "ALL" Then
                Select Case cmbReport.SelectedIndex
                    Case 0 '"GL Account(Detailed)"

                        Dim rpt As New rptSchedule_IDNo
                        rpt.SetDataSource(dt)
                        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                        Form1.CrystalReportViewer1.ReportSource = rpt
                        Me.ParentForm.Close()


                    Case 1 '"All Accounts"


                        Dim rpt As New rptSchedule_Cont1
                        rpt.SetDataSource(dt)
                        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                        Form1.CrystalReportViewer1.ReportSource = rpt
                        Me.ParentForm.Close()


                End Select
            Else
                Select Case cmbReport.SelectedIndex
                    Case 0 '"GL Account(Detailed)"
                        Dim rpt As New rptSchedule_IDNo
                        rpt.SetDataSource(dt)
                        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                        Form1.CrystalReportViewer1.ReportSource = rpt
                        Me.ParentForm.Close()


                    Case 1 '"All Accounts"
                        Dim rpt As New rptSchedule_Cont1
                        rpt.SetDataSource(dt)
                        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                        Form1.CrystalReportViewer1.ReportSource = rpt
                        Me.ParentForm.Close()

                End Select
            End If
        Else
            Dim rpt As New rptSchedule_IDNo
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.ReportSource = rpt
            Me.ParentForm.Close()

        End If

    End Sub

    Private Sub txtReportTitle_TextChanged(sender As Object, e As EventArgs) Handles txtReportTitle.TextChanged
        ReportTitle()
    End Sub

    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        ReportTitle()
    End Sub

    Sub StoredFields()
        Form1.FieldStorage("schedule_account_cmbReport") = cmbReport.SelectedIndex
        Form1.FieldStorage("schedule_account_cmbSubsi") = cmbSubsi.SelectedIndex
        Form1.FieldStorage("schedule_account_cmbInsurance") = cmbInsurance.SelectedIndex
        Form1.FieldStorage("schedule_account_cmbSort") = cmbSort.SelectedIndex
        Form1.FieldStorage("schedule_account_cmbOrder") = cmbOrder.SelectedIndex
        Form1.FieldStorage("schedule_account_dtDate") = dtDate.Value
        Form1.FieldStorage("schedule_account_txtAccount") = txtAccount.Text
        Form1.FieldStorage("schedule_account_txtAccountName") = txtAccountName.Text

    End Sub



End Class