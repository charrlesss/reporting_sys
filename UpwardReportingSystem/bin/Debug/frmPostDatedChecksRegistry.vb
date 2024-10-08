Public Class frmPostDatedChecksRegistry
    Dim dt As DataTable

    Private Sub ReportTitle()
        txtReportTitle.Text = "UPWARD MANAGEMENT INSURANCE SERVICES " & IIf(cmbPDCBranch.Text = "ALL", "", "(" & cmbPDCBranch.Text & ")") & vbCrLf & _
                         "Post Dated Checks Registered" & vbCrLf & _
                         "From " & Format(dtDateFrom.Value.ToString("MM/dd/yyyy")) & " to " & Format(dtDateTo.Value.ToString("MM/dd/yyyy"))

    End Sub
    Sub getSubAccount(dt As DataTable)
        If dt.Rows.Count > 0 Then
            cmbPDCBranch.Items.Add("ALL")
            For i As Integer = 0 To dt.Rows.Count - 1
                cmbPDCBranch.Items.Add(dt(i)("Sub_Acct").ToString)
            Next
        End If
    End Sub


    Private Sub LoadSubAccounts()
        Form1.GetReportTableApi("/reports/accounting/get-sub-account-trial", AddressOf getSubAccount)
    End Sub

    Sub loadControls()
        cmbPDCFormat.Items.Clear()
        cmbPDCField.Items.Clear()
        cmbPDCBranch.Items.Clear()
        cmbSort.Items.Clear()
        cmbOrder.Items.Clear()

        cmbPDCFormat.Items.Add("Format - 1")
        cmbPDCFormat.Items.Add("Format - 2")

        cmbPDCField.Items.Add("Check Date")
        cmbPDCField.Items.Add("Date Received")

       LoadSubAccounts()

        cmbSort.Items.Add("Name")
        cmbSort.Items.Add("Check Date")
        cmbSort.Items.Add("Date Received")

        cmbOrder.Items.Add("Ascending")
        cmbOrder.Items.Add("Descending")

        cmbPDCFormat.SelectedIndex = 0
        cmbPDCField.SelectedIndex = 0
        cmbPDCBranch.SelectedIndex = 0
        cmbSort.SelectedIndex = 0
        cmbOrder.SelectedIndex = 0
        cmbType.SelectedIndex = 0
    End Sub


    Private Sub frmPostDatedChecksRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadControls()

    End Sub

    Private Sub txtReportTitle_TextChanged(sender As Object, e As EventArgs) Handles txtReportTitle.TextChanged
        ReportTitle()

    End Sub

    Private Sub cmbPDCFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPDCFormat.SelectedIndexChanged
        ReportTitle()

    End Sub

    Private Sub cmbPDCField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPDCField.SelectedIndexChanged
        ReportTitle()

    End Sub

    Private Sub cmbPDCBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPDCBranch.SelectedIndexChanged
        ReportTitle()

    End Sub

    Private Sub dtDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtDateFrom.ValueChanged
        ReportTitle()

    End Sub

    Private Sub dtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtDateTo.ValueChanged
        ReportTitle()

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        ReportTitle()

    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
                {"sort", cmbSort.SelectedIndex},
                {"order", cmbOrder.SelectedIndex},
                {"type", cmbType.SelectedIndex},
                {"field", cmbPDCField.SelectedIndex},
                {"sub_acct", cmbPDCBranch.Text},
                {"datefrom", dtDateFrom.Value},
                {"dateto", dtDateTo.Value}
               }
        Form1.PostReportApi("/reports/accounting/post-dated-check-registered-desk", postData, AddressOf HandleApiResponse)
    End Sub
    Sub HandleApiResponse(dt As DataTable)
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        Select Case cmbPDCFormat.Text
            Case "Format - 1"
                Dim rpt As New rptPDCRegister
                rpt.SetDataSource(dt)
                rpt.SummaryInfo.ReportTitle = txtReportTitle.Text

                Form1.CrystalReportViewer1.Refresh()
                Form1.CrystalReportViewer1.ReportSource = rpt
                Me.ParentForm.Close()
            Case "Format - 2"

                Dim rpt As New rptPDCRegister
                rpt.SetDataSource(dt)
                rpt.SummaryInfo.ReportTitle = txtReportTitle.Text

                Form1.CrystalReportViewer1.Refresh()
                Form1.CrystalReportViewer1.ReportSource = rpt
                Me.ParentForm.Close()

        End Select



    End Sub

End Class