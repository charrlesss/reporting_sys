Public Class frmModal
    Dim buttonNames As String() = {
        "Schedule of Accounts",
        "Subsidiary Ledger",
        "Trial Balance",
        "Income Statement - Long",
        "Balance Sheet - Long",
        "General Ledger",
        "Abstract of Collection",
        "Deposited Collections",
        "Returned Checks",
        "Post Dated Checks Registry",
        "Petty Cash Fund Disbursement",
        "Cash Disbursement Book - CDB",
        "General Journal Book - GJB",
        "Aging of Accounts",
        "Production Report",
        "Renewal Notice",
        "Claims Report"
    }
    '   "Production Book - PB",
    ' "VAT Book - VB",
    ' "Cancelled Accounts",
    ' "Fully Paid Accounts",

    Dim dynamicContentPanel As New FlowLayoutPanel()


    Private Sub Modal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.WrapContents = False

        CreateButtons(FlowLayoutPanel1, buttonNames)
    End Sub

   

    Private Sub CreateButtons(flowPanel As FlowLayoutPanel, buttonTexts As String())
        ' Loop through each string in the array
        For Each text As String In buttonTexts
            ' Create a new button
            Dim newButton As New Button()

            ' Set button properties
            newButton.Text = text
            newButton.Width = 258
            newButton.Height = 30
            newButton.Margin = New Padding(0)
            newButton.TextAlign = ContentAlignment.MiddleLeft
            newButton.BackColor = Color.LightGray


            ' Add an event handler for the button click
            AddHandler newButton.Click, AddressOf Button_Click

            flowPanel.Controls.Add(newButton)


        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' Cast the sender to a Button
        Dim clickedButton As Button = CType(sender, Button)
        Dim buttonText As String = clickedButton.Text.Trim()



        Select Case buttonText
            Case "Schedule of Accounts"
                ShowFormInPanel(New frmScheduleAccount())

            Case "Subsidiary Ledger"
                ShowFormInPanel(New frmSubsidiaryLedger())
            Case "Trial Balance"
                ShowFormInPanel(New frmTrialBalance())
            Case "Income Statement - Long"
                ShowFormInPanel(New frmIncomeStatementLong())
            Case "Balance Sheet - Long"
                ShowFormInPanel(New frmBalanceSheetLong())
            Case "General Ledger"
                ShowFormInPanel(New frmGeneralLedger())
            Case "Abstract of Collection"
                ShowFormInPanel(New frmAbstractCollection())
            Case "Deposited Collections"
                ShowFormInPanel(New frmDepositCollection())
            Case "Returned Checks"
                ShowFormInPanel(New frmReturnChecks())
            Case "Post Dated Checks Registry"
                ShowFormInPanel(New frmPostDatedChecksRegistry())
            Case "Petty Cash Fund Disbursement"
                ShowFormInPanel(New frmPettyCashFundDisbursement())
            Case "Cash Disbursement Book - CDB"
                ShowFormInPanel(New frmCashDisbursementBook())
            Case "General Journal Book - GJB"
                ShowFormInPanel(New frmGeneralJournalBook())
                'Case "Production Book - PB"
                '  MessageBox.Show("Production Book - PB selected")
                ' Case "VAT Book - VB"
                '  MessageBox.Show("VAT Book - VB selected")
            Case "Aging of Accounts"
                ShowFormInPanel(New frmAgingAccounts())
                ' Case "Cancelled Accounts"
                '  MessageBox.Show("Cancelled Accounts selected")
                ' Case "Fully Paid Accounts"
                ' MessageBox.Show("Fully Paid Accounts selected")
            Case "Production Report"
                MessageBox.Show("Production Report selected")
            Case "Renewal Notice"
                MessageBox.Show("Renewal Notice selected")
            Case "Claims Report"
                MessageBox.Show("Claims Report selected")
            Case Else
                MessageBox.Show("Unknown option selected")
        End Select


    End Sub

    Private Sub ShowFormInPanel(childForm As Form)
        Panel4.Controls.Clear()

        ' Set the child form properties to act like a control within panel4
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill ' Make the form fill the panel
        ' Add the child form to panel4's controls
        Panel4.Controls.Add(childForm)

        ' Show the form
        childForm.Show()

    End Sub


  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class