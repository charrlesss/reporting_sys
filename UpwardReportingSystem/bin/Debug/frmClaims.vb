Public Class frmClaims
    Private Sub ReportTitle()
        txtReportTitle.Text = Form1.ReportTitleByDepartment & vbCrLf &
                        IIf(cmbReport.SelectedIndex = 0, "Daily ", IIf(cmbReport.SelectedIndex = 1, "Monthly ", "")) & "Claims Report" & vbCrLf &
                       IIf(cmbReport.SelectedIndex = 2, "From " & dtDateFrom.Text & " To " & dtDateTo.Text, dtDateFrom.Text)
    End Sub
    Sub FieldToShow()
     
     

        If cmbFormat.SelectedIndex = 4 Then
            lblReport.Visible = False
            lblStatus.Visible = False

            cmbStatus.Visible = False
            cmbReport.Visible = False

            lblClaimType.Visible = True
            cmbClaimType.Visible = True

            lblPolicyNo.Visible = False
            lblAssuredName.Visible = False
            txtPolicyNo.Visible = False
            txtAssuredName.Visible = False


            dtDateFrom.Visible = True
            lblDateFrom.Visible = True

            dtDateTo.Visible = True
            lblDateTo.Visible = True

            dtDateFrom.Top = dtDateFrom.Top - 25
            lblDateFrom.Top = lblDateFrom.Top - 25


            dtDateTo.Top = dtDateTo.Top - 25
            lblDateTo.Top = lblDateTo.Top - 25

            dtDateFrom.Format = DateTimePickerFormat.Custom
            dtDateFrom.CustomFormat = "MMMM dd, yyyy"
            dtDateFrom.ShowUpDown = False
            btnSearch.Visible = True

        ElseIf cmbFormat.SelectedIndex = 5 Then
            lblReport.Visible = False
            lblStatus.Visible = False
            lblDateFrom.Visible = False
            cmbStatus.Visible = False
            cmbReport.Visible = False
            dtDateFrom.Visible = False

            lblClaimType.Visible = False
            cmbClaimType.Visible = False


            lblPolicyNo.Visible = True
            lblAssuredName.Visible = True
            txtPolicyNo.Visible = True
            txtAssuredName.Visible = True

            dtDateTo.Visible = False
            lblDateTo.Visible = False
            btnSearch.Visible = False


        Else
            lblReport.Visible = True
            lblDateFrom.Visible = True
            lblStatus.Visible = True

            cmbStatus.Visible = True
            cmbReport.Visible = True
            dtDateFrom.Visible = True

            lblClaimType.Visible = False
            cmbClaimType.Visible = False

            lblPolicyNo.Visible = False
            lblAssuredName.Visible = False
            txtPolicyNo.Visible = False
            txtAssuredName.Visible = False
            btnSearch.Visible = False

            dtDateTo.Visible = False
            lblDateTo.Visible = False

            dtDateFrom.Top = 198
            lblDateFrom.Top = 198


            dtDateTo.Top = 198 + 25
            lblDateTo.Top = 198 + 25

            If cmbReport.Text = "Monthly" Then
                dtDateFrom.Format = DateTimePickerFormat.Custom
                dtDateFrom.CustomFormat = "MMMM yyyy"
                dtDateFrom.ShowUpDown = True
            Else
                dtDateFrom.Format = DateTimePickerFormat.Custom
                dtDateFrom.CustomFormat = "MMMM dd, yyyy"
                dtDateFrom.ShowUpDown = False
            End If

        End If
    End Sub


    Sub showDateTo()
        If cmbReport.SelectedIndex = 2 Then
            dtDateTo.Visible = True
            lblDateTo.Visible = True
        Else
            dtDateTo.Visible = False
            lblDateTo.Visible = False
        End If
    End Sub

    Private Sub frmClaims_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSearch.Visible = False


        If Form1.FieldStorage.ContainsKey("claims_cmbFormat") And
         Form1.FieldStorage.ContainsKey("claims_txtPolicyNo") And
         Form1.FieldStorage.ContainsKey("claims_txtAssuredName") And
         Form1.FieldStorage.ContainsKey("claims_dtDateFrom") And
         Form1.FieldStorage.ContainsKey("claims_dtDateTo") And
         Form1.FieldStorage.ContainsKey("claims_cmbStatus") And
         Form1.FieldStorage.ContainsKey("claims_cmbReport") And
         Form1.FieldStorage.ContainsKey("claims_cmbClaimType") Then

            cmbFormat.SelectedIndex = Form1.FieldStorage("claims_cmbFormat")
            txtPolicyNo.Text = Form1.FieldStorage("claims_txtPolicyNo")
            txtAssuredName.Text = Form1.FieldStorage("claims_txtAssuredName")
            dtDateFrom.Value = Form1.FieldStorage("claims_dtDateFrom")
            dtDateTo.Value = Form1.FieldStorage("claims_dtDateTo")
            cmbStatus.SelectedIndex = Form1.FieldStorage("claims_cmbStatus")
            cmbReport.SelectedIndex = Form1.FieldStorage("claims_cmbReport")
            cmbClaimType.SelectedIndex = Form1.FieldStorage("claims_cmbClaimType")
        Else
            cmbStatus.SelectedIndex = 0
            cmbFormat.SelectedIndex = 0
            cmbReport.SelectedIndex = 1
            cmbClaimType.SelectedIndex = 0
        End If

     

        ReportTitle()
        showDateTo()
    End Sub


    Private Sub cmbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReport.SelectedIndexChanged
        If cmbReport.Text = "Monthly" Then
            dtDateFrom.Format = DateTimePickerFormat.Custom
            dtDateFrom.CustomFormat = "MMMM yyyy"
            dtDateFrom.ShowUpDown = True
        Else
            dtDateFrom.Format = DateTimePickerFormat.Custom
            dtDateFrom.CustomFormat = "MMMM dd, yyyy"
            dtDateFrom.ShowUpDown = False
        End If
        ReportTitle()
        showDateTo()
    End Sub

    Private Sub dtDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtDateFrom.ValueChanged
        ReportTitle()

    End Sub

    Private Sub dtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtDateTo.ValueChanged
        ReportTitle()
    End Sub

    Private Async Sub btnSchecSubmit_Click(sender As Object, e As EventArgs) Handles btnSchecSubmit.Click
        Form1.ShowLoading()
        Await Task.Delay(100)

        Dim postData As New Dictionary(Of String, String) From {
           {"dateTo", dtDateTo.Value},
           {"dateFrom", dtDateFrom.Value},
           {"status", cmbStatus.SelectedIndex},
           {"format", cmbFormat.SelectedIndex},
           {"report", cmbReport.SelectedIndex},
           {"claim_type", cmbReport.SelectedIndex},
           {"PolicyNo", txtPolicyNo.Text}
       }
        Form1.PostReportApi("/task/claims/claims/report-claim-desk", postData, AddressOf HandleApiResponse)
    End Sub

    Sub HandleApiResponse(dt As DataTable)
        Form1.HideLoading()
        If (dt.Rows.Count <= 0) Then
            MsgBox("No Record Found!")
            Exit Sub
        End If

        StoredFields()

        Dim rpt As New rptClaimsReport

        rpt.SetDataSource(dt)
        rpt.SummaryInfo.ReportTitle = txtReportTitle.Text
        Form1.CrystalReportViewer1.Refresh()
        Form1.CrystalReportViewer1.ReportSource = rpt
        Me.ParentForm.Close()


    End Sub

    Sub StoredFields()
        Form1.FieldStorage("claims_cmbFormat") = cmbFormat.SelectedIndex
        Form1.FieldStorage("claims_txtPolicyNo") = txtPolicyNo.Text
        Form1.FieldStorage("claims_txtAssuredName") = txtAssuredName.Text
        Form1.FieldStorage("claims_dtDateFrom") = dtDateFrom.Value
        Form1.FieldStorage("claims_dtDateTo") = dtDateTo.Value
        Form1.FieldStorage("claims_cmbStatus") = cmbStatus.SelectedIndex
        Form1.FieldStorage("claims_cmbReport") = cmbReport.SelectedIndex
        Form1.FieldStorage("claims_cmbClaimType") = cmbClaimType.SelectedIndex
    End Sub

    Private Sub cmbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormat.SelectedIndexChanged
        FieldToShow()
    End Sub

    Private Sub txtReportTitle_TextChanged(sender As Object, e As EventArgs) Handles txtReportTitle.TextChanged
        ReportTitle()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim frmMSearch As New frmSearch

        If frmMSearch.Search("Policy", txtPolicyNo.Text.Trim) Then
            txtPolicyNo.Text = frmMSearch.RetVal1
            txtAssuredName.Text = frmMSearch.RetVal2
        End If
    End Sub

   
 
    Private Sub txtPolicyNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPolicyNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim frmMSearch As New frmSearch

            If frmMSearch.Search("Policy", txtPolicyNo.Text.Trim) Then
                txtPolicyNo.Text = frmMSearch.RetVal1
                txtAssuredName.Text = frmMSearch.RetVal2
            End If
        End If
    End Sub
End Class