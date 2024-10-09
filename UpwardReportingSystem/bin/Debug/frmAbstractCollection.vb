Public Class frmAbstractCollection
    Dim dt As DataTable
    Public sReport As String = "Abstract of Collections"
    Private Sub ReportTitle()
        txtReportTitle.Text = "UPWARD MANAGEMENT INSURANCE SERVICES " & vbCrLf & _
                         cmbReport.Text & " " & sReport & vbCrLf & dtDate.Text


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
        cmbFormat.Items.Clear()
        cmbReport.Items.Clear()
        cmbSubAcct.Items.Clear()
        cmbSort.Items.Clear()
        cmbOrder.Items.Clear()
        With dtDate
            .Value = DateSerial(Year(.Value), Month(.Value), 1)
        End With
        cmbFormat.Items.Add("Format - 1")
        cmbReport.Items.Add("Daily")
        cmbReport.Items.Add("Monthly")

        LoadSubAccounts()

        cmbSort.Items.Add("Reference No")

        cmbOrder.Items.Add("Ascending")
        cmbOrder.Items.Add("Descending")

        lblPolicy.Visible = False
        cmbpolicy.Visible = False
    End Sub

    Private Sub frmAbstractCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadControls()

        cmbFormat.SelectedIndex = 0
        cmbReport.SelectedIndex = 1
        cmbSubAcct.SelectedIndex = 0
        cmbOrder.SelectedIndex = 0
        cmbSort.SelectedIndex = 0

    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        If cmbReport.Text = "Monthly" Then
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "MMMM yyyy"
            dtDate.ShowUpDown = True
        Else
            dtDate.Format = DateTimePickerFormat.Custom
            dtDate.CustomFormat = "MMMM dd, yyyy"
            dtDate.ShowUpDown = False
        End If
        ReportTitle()

    End Sub

    Private Sub cmbSubAcct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubAcct.SelectedIndexChanged
        ReportTitle()
    End Sub

 

    Private Sub cmbOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrder.SelectedIndexChanged
        ReportTitle()

    End Sub

    Private Sub cmbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormat.SelectedIndexChanged
        ReportTitle()
    End Sub



    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"dateFormat", cmbReport.Text},
           {"sub_acct", cmbSubAcct.Text},
        {"date", dtDate.Value},
        {"order", cmbOrder.Text}
       }
        Form1.PostReportWithSummaryApi("/reports/accounting/abstract-collection-report-desk", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable, dtSummary As DataTable)
        Form1.HideLoading()
        If (dt.Rows.Count <= 0 And dtSummary.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        Dim rpt As New rptAbstractOfCollections
        rpt.SetDataSource(dt)
        rpt.Subreports(0).SetDataSource(dtSummary)
        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text

        Form1.CrystalReportViewer1.Refresh()
        Form1.CrystalReportViewer1.ReportSource = rpt
        Me.ParentForm.Close()
    End Sub

   
End Class