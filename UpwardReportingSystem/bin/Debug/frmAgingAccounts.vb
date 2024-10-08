Public Class frmAgingAccounts
    Public sReport As String = "Aging of Accounts"

    Private Sub ReportTitle()
        txtReportTitle.Text = "UPWARD MANAGEMENT INSURANCE SERVICES " & vbCrLf &
                        cmbReport.Text & " " & sReport & IIf(cmbFormat.SelectedIndex = 0, "", " Summary") & vbCrLf & _
                         dtDate.Text
    End Sub

    Private Sub frmAgingAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFormat.Items.Add(" All Accounts")
        cmbReport.Items.Add("Monthly")
        cmbSubAcct.Items.Add("ALL")

        If Form1.FieldStorage.ContainsKey("dtDate") And
            Form1.FieldStorage.ContainsKey("cmbFormat") And
            Form1.FieldStorage.ContainsKey("cmbReport") And
            Form1.FieldStorage.ContainsKey("cmbSubAcct") And
            Form1.FieldStorage.ContainsKey("cmbpolicy") Then

            dtDate.Value = Form1.FieldStorage("dtDate")
            cmbFormat.SelectedIndex = Form1.FieldStorage("cmbFormat")
            cmbReport.SelectedIndex = Form1.FieldStorage("cmbReport")
            cmbSubAcct.SelectedIndex = Form1.FieldStorage("cmbSubAcct")
            cmbpolicy.SelectedIndex = Form1.FieldStorage("cmbpolicy")
        Else
            cmbFormat.SelectedIndex = 0
            cmbReport.SelectedIndex = 0
            cmbSubAcct.SelectedIndex = 0
            cmbpolicy.SelectedIndex = 0
        End If


     

        ReportTitle()
    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"date", dtDate.Value},
           {"policyType", cmbpolicy.Text}
       }
        Form1.PostReportApi("/reports/accounting/aging-accounts-desk", postData, AddressOf HandleApiResponse)
    End Sub
    Public Function GetMonthLastDay(ByVal dDate As Date) As Date
        GetMonthLastDay = DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, CDate(Month(dDate) & " " & Year(dDate)))))
    End Function


    Sub HandleApiResponse(dt As DataTable)
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        StoredFields()
    
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
        Form1.CrystalReportViewer1.Refresh()
        Form1.CrystalReportViewer1.ReportSource = rpt
        Me.ParentForm.Close()
     

    End Sub

    Sub StoredFields()

        Form1.FieldStorage("dtDate") = dtDate.Value
        Form1.FieldStorage("cmbReport") = cmbReport.SelectedIndex
        Form1.FieldStorage("cmbFormat") = cmbFormat.SelectedIndex
        Form1.FieldStorage("cmbSubAcct") = cmbSubAcct.SelectedIndex
        Form1.FieldStorage("cmbpolicy") = cmbpolicy.SelectedIndex
    End Sub

 
End Class