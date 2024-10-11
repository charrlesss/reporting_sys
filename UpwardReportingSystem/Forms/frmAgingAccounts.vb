Public Class frmAgingAccounts
    Public sReport As String = "Aging of Accounts"

    Private Sub ReportTitle()
        txtReportTitle.Text = frmMain.ReportTitleByDepartment & vbCrLf &
                        cmbReport.Text & " " & sReport & IIf(cmbFormat.SelectedIndex = 0, "", " Summary") & vbCrLf & _
                         dtDate.Text
    End Sub

    Private Sub frmAgingAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFormat.Items.Add(" All Accounts")
        cmbReport.Items.Add("Monthly")
        cmbSubAcct.Items.Add("ALL")

        If frmMain.FieldStorage.ContainsKey("dtDate") And
            frmMain.FieldStorage.ContainsKey("cmbFormat") And
            frmMain.FieldStorage.ContainsKey("cmbReport") And
            frmMain.FieldStorage.ContainsKey("cmbSubAcct") And
            frmMain.FieldStorage.ContainsKey("cmbpolicy") Then

            dtDate.Value = frmMain.FieldStorage("dtDate")
            cmbFormat.SelectedIndex = frmMain.FieldStorage("cmbFormat")
            cmbReport.SelectedIndex = frmMain.FieldStorage("cmbReport")
            cmbSubAcct.SelectedIndex = frmMain.FieldStorage("cmbSubAcct")
            cmbpolicy.SelectedIndex = frmMain.FieldStorage("cmbpolicy")
        Else
            cmbFormat.SelectedIndex = 0
            cmbReport.SelectedIndex = 0
            cmbSubAcct.SelectedIndex = 0
            cmbpolicy.SelectedIndex = 0
        End If

        ReportTitle()
    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        frmMain.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"policyType", cmbpolicy.Text}
       }
        frmMain.PostReportApi("/reports/accounting/aging-accounts-desk", postData, AddressOf HandleApiResponse)
    End Sub
    Public Function GetMonthLastDay(ByVal dDate As Date) As Date
        GetMonthLastDay = DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, CDate(Month(dDate) & " " & Year(dDate)))))
    End Function


    Sub HandleApiResponse(dt As DataTable)

        StoredFields()
        frmMain.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If


        Dim ADate As Date

        If cmbReport.Text = "Monthly" Then
            ADate = GetMonthLastDay(dtDate.Value.Date)
        Else
            ADate = dtDate.Value.Date
        End If
        Dim rpt As New rptAging

        rpt.SetDataSource(dt)
        rpt.Subreports(0).SetDataSource(dt)
        rpt.SetParameterValue("AsOfDate", ADate.Date.ToString("MMMM dd, yyyy"))
        rpt.SetParameterValue("CurrentDate", ADate.Date.ToString("MMMM dd, yyyy"))
        rpt.SetParameterValue("CurrDate", ADate.Date.ToString("MMMM dd, yyyy"))

        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
        frmMain.CrystalReportViewer1.Refresh()
        frmMain.CrystalReportViewer1.ReportSource = rpt
        Me.ParentForm.Close()


    End Sub

    Sub StoredFields()

        frmMain.FieldStorage("dtDate") = dtDate.Value
        frmMain.FieldStorage("cmbReport") = cmbReport.SelectedIndex
        frmMain.FieldStorage("cmbFormat") = cmbFormat.SelectedIndex
        frmMain.FieldStorage("cmbSubAcct") = cmbSubAcct.SelectedIndex
        frmMain.FieldStorage("cmbpolicy") = cmbpolicy.SelectedIndex
    End Sub

 
End Class