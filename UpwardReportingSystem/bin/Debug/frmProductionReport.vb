Public Class frmProductionReport
    Dim dt As DataTable
    Public sReport As String = "Production Report"


    Private Sub ReportTitle()
        txtReportTitle.Text = Form1.ReportTitleByDepartment & IIf(sReport = "Production Report", IIf(cmbType.SelectedIndex = 0, "", "(Financed)"), IIf(cmbSubAcct.Text = "ALL", "", "(" & cmbSubAcct.Text & ")")) & vbCrLf & _
                         cmbReport.Text & " " & sReport & IIf(sReport <> "Production Report", "", " (" & IIf(Microsoft.VisualBasic.Left(cmbSubAcct.Text, 1) = "G", "Bonds", cmbSubAcct.Text) & " - " & cmbOrder.Text & ")") & IIf(cmbFormat.SelectedIndex = 0, "", " Summary") & vbCrLf & _
                         IIf(sReport <> "Production Report", "", "Cut off Date: ") & dtDate.Text
    End Sub

    Sub getAccounts(dt As DataTable)
        If dt.Rows.Count > 0 Then
            cmbOrder.Items.Add("ALL")
            For i As Integer = 0 To dt.Rows.Count - 1
                cmbOrder.Items.Add(dt(i)("Account").ToString)
            Next
        End If
    End Sub
    Sub getTypes(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                cmbSubAcct.Items.Add(dt(i)("PolicyType").ToString)
            Next
        End If
    End Sub

    Private Sub LoadAccounts()
        Form1.GetReportTableApi("/reports/accounting/get-report-policy-accounts", AddressOf getAccounts)

    End Sub
    Private Sub LoadType()
        Form1.GetReportTableApi("/reports/accounting/get-report-policy-types", AddressOf getTypes)

    End Sub




    Private Sub ProductionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbOrder.Items.Add("ALL")
        cmbFormat.Items.Add("Full")
        cmbFormat.Items.Add("Summary")

        cmbType.Items.Add("All")
        cmbType.Items.Add("Financed")
        cmbType.SelectedIndex = 0

        cmbReport.Items.Add("Daily")
        cmbReport.Items.Add("Monthly")
        cmbReport.Items.Add("Yearly")

        lblSubAccount.Text = "Type:"
        LoadType()
        LoadAccounts()
        cmbSort.Items.Add("Date Issued")
        cmbSort.Items.Add("Policy No#")
        cmbSort.Items.Add("Date From")

        lblOrder.Text = "Account:"

        lblPolicy.Visible = True
        cmbpolicy.Visible = True

        If Form1.FieldStorage.ContainsKey("production_report_cmbFormat") And
            Form1.FieldStorage.ContainsKey("production_report_cmbType") And
            Form1.FieldStorage.ContainsKey("production_report_cmbReport") And
            Form1.FieldStorage.ContainsKey("production_report_numYear") And
            Form1.FieldStorage.ContainsKey("production_report_cmbSubAcct") And
            Form1.FieldStorage.ContainsKey("production_report_dtDate") And
            Form1.FieldStorage.ContainsKey("production_report_cmbpolicy") And
            Form1.FieldStorage.ContainsKey("production_report_cmbSort") And
            Form1.FieldStorage.ContainsKey("production_report_cmbOrder") And
            Form1.FieldStorage.ContainsKey("production_report_cmbFormat") And
            Form1.FieldStorage.ContainsKey("production_report_cmbType") And
            Form1.FieldStorage.ContainsKey("production_report_cmbReport") And
            Form1.FieldStorage.ContainsKey("production_report_numYear") And
            Form1.FieldStorage.ContainsKey("production_report_cmbSubAcct") And
            Form1.FieldStorage.ContainsKey("production_report_dtDate") And
            Form1.FieldStorage.ContainsKey("production_report_cmbpolicy") And
            Form1.FieldStorage.ContainsKey("production_report_cmbSort") And
            Form1.FieldStorage.ContainsKey("production_report_cmbOrder") Then

            cmbFormat.SelectedIndex = Form1.FieldStorage("production_report_cmbFormat")
            cmbType.SelectedIndex = Form1.FieldStorage("production_report_cmbType")
            cmbReport.SelectedIndex = Form1.FieldStorage("production_report_cmbReport")
            numYear.Value = Form1.FieldStorage("production_report_numYear")
            cmbSubAcct.SelectedIndex = Form1.FieldStorage("production_report_cmbSubAcct")
            dtDate.Value = Form1.FieldStorage("production_report_dtDate")
            cmbpolicy.SelectedIndex = Form1.FieldStorage("production_report_cmbpolicy")
            cmbSort.SelectedIndex = Form1.FieldStorage("production_report_cmbSort")
            cmbOrder.SelectedIndex = Form1.FieldStorage("production_report_cmbOrder")
        Else
            cmbpolicy.SelectedIndex = 0
            cmbSubAcct.SelectedIndex = 0
            cmbFormat.SelectedIndex = 0
            cmbOrder.SelectedIndex = 0
            cmbSort.SelectedIndex = 0
            cmbReport.SelectedIndex = 1
        End If

    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged

        If cmbReport.Text = "Monthly" Then
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "MMMM yyyy"
            dtDate.ShowUpDown = True
        ElseIf cmbReport.Text = "Yearly" Then
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "yyyy"
            dtDate.ShowUpDown = False

        Else
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "MMMM dd, yyyy"
            dtDate.ShowUpDown = False
        End If


        If cmbReport.Text = "Yearly" Then
            numYear.Visible = True
        Else
            numYear.Visible = False
        End If
        ReportTitle()
    End Sub

   
    Public Function GetMonthLastDay(ByVal dDate As Date) As Date
        GetMonthLastDay = DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, CDate(Month(dDate) & " " & Year(dDate)))))
    End Function
   

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)


        Dim FDate As Date
        Dim TDate As Date

        If cmbReport.Text = "Monthly" Then
            FDate = Format(dtDate.Value.Date, "01/MM/yyyy")
            TDate = GetMonthLastDay(dtDate.Value.Date)
        ElseIf cmbReport.Text = "Yearly" Then
            FDate = Format(DateAdd(DateInterval.Year, (numYear.Value * -1), dtDate.Value.Date), "01/MM/yyyy")
            TDate = GetMonthLastDay(dtDate.Value.Date)
        Else
            FDate = dtDate.Value.Date
            TDate = dtDate.Value.Date
        End If


        Dim postData As New Dictionary(Of String, String) From {
           {"FDate", FDate},
           {"TDate", TDate},
           {"cmbOrder", cmbOrder.Text},
           {"cmbSubAcct", cmbSubAcct.Text},
           {"cmbType", cmbType.SelectedIndex},
           {"cmbpolicy", cmbpolicy.Text},
           {"cmbSort", cmbSort.Text}
       }

        Form1.PostReportApi("/reports/reports/get-production-report-desk", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        StoredFields()
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If
        StoredFields()

        If cmbFormat.SelectedIndex = 0 Then
            Select Case cmbSubAcct.Text
                Case "TPL"
                    Dim rpt As New rptProductionTPL
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.Refresh()
                    Form1.CrystalReportViewer1.ReportSource = rpt
                Case "COM"
                    Dim rpt As New rptProductionCOM
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.Refresh()
                    Form1.CrystalReportViewer1.ReportSource = rpt
                Case "MAR", "MSPR", "PA", "CGL"
                    Dim rpt As New rptProductionMAR
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.Refresh()
                    Form1.CrystalReportViewer1.ReportSource = rpt
                Case "FIRE"
                    Dim rpt As New rptProductionFIRE
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.Refresh()
                    Form1.CrystalReportViewer1.ReportSource = rpt
                Case Else
                    Dim rpt As New rptProductionBONDS
                    rpt.SetDataSource(dt)
                    rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
                    Form1.CrystalReportViewer1.Refresh()
                    Form1.CrystalReportViewer1.ReportSource = rpt
            End Select
        Else
            Dim rpt As New rptProductionSUMM
            rpt.SetDataSource(dt)
            rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
            Form1.CrystalReportViewer1.Refresh()
            Form1.CrystalReportViewer1.ReportSource = rpt
        End If

        Me.ParentForm.Close()
    End Sub

    Sub StoredFields()
        Form1.FieldStorage("production_report_cmbFormat") = cmbFormat.SelectedIndex
        Form1.FieldStorage("production_report_cmbType") = cmbType.SelectedIndex
        Form1.FieldStorage("production_report_cmbReport") = cmbReport.SelectedIndex
        Form1.FieldStorage("production_report_numYear") = numYear.Value
        Form1.FieldStorage("production_report_cmbSubAcct") = cmbSubAcct.SelectedIndex
        Form1.FieldStorage("production_report_dtDate") = dtDate.Value
        Form1.FieldStorage("production_report_cmbpolicy") = cmbpolicy.SelectedIndex
        Form1.FieldStorage("production_report_cmbSort") = cmbSort.SelectedIndex
        Form1.FieldStorage("production_report_cmbOrder") = cmbOrder.SelectedIndex
    End Sub
End Class