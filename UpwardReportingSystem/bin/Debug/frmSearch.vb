Public Class frmSearch
    Private mySearch As String
    Private myCaption As String
    Private SearchText As String
    Private ExtraURLParams As String
    Private myReturn As Boolean

    Public RetVal1 As String
    Public RetVal2 As String
    Public RetVal3 As String

    Dim ColWidth1 As Integer = -1
    Dim ColWidth2 As Integer = -1
    Dim ColWidth3 As Integer = -1
    Dim ColWidth4 As Integer = -1
    Dim ColAllign1 As New DataGridViewContentAlignment
    Dim ColAllign2 As New DataGridViewContentAlignment
    Dim ColAllign3 As New DataGridViewContentAlignment
    Dim ColAllign4 As New DataGridViewContentAlignment

    Public Function Search(ByVal Caption As String, Optional ByVal SearchText As String = "") As Boolean
        mySearch = Caption
        myCaption = Me.Text & " - " & Caption
        tstSearch.Text = SearchText
        LoadSearch(mySearch, tstSearch.Text.Trim)
        Me.ShowDialog()

        Search = myReturn

    End Function


    Sub ChartAccount(dt As DataTable)

        Try
            ColWidth1 = 80
            ColWidth2 = 179
            ColWidth3 = 114
            dgvSearch.DataSource = dt
            dgvSearch.Columns(0).Width = ColWidth1
            dgvSearch.Columns(1).Width = ColWidth2
            dgvSearch.Columns(2).Width = ColWidth3
            tslRecord.Text = IIf(dt.Rows.Count = 100, "Top ", "") & dt.Rows.Count.ToString("#,##0")
        Catch
        End Try
    End Sub

    Private Sub LoadSearch(ByVal SearchFor As String, Optional ByVal Search As String = "")
        Dim StrQry As String = ""

        Select Case SearchFor
            Case "Chart of Account"
                Form1.GetReportTableApi("/reports/accounting/chart-schedule-account-desk?account_search=" & Search & ExtraURLParams, AddressOf ChartAccount)
        End Select


    End Sub

    Private Sub SelectSearch(ByVal RVal1 As String, ByVal RVal2 As String, ByVal RVal3 As String)
        myReturn = True

        RetVal1 = RVal1
        RetVal2 = RVal2
        RetVal3 = RVal3

        Me.Hide()
    End Sub

    Private Sub tstSearch_Click(sender As Object, e As EventArgs) Handles tstSearch.Click

    End Sub

    Private Sub tstSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tstSearch.KeyDown
        If e.KeyCode = Keys.Down Then
            If dgvSearch.Rows.Count <> 0 Then dgvSearch.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            LoadSearch(mySearch, tstSearch.Text.Trim)
        End If
    End Sub

    Private Sub dgvSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvSearch_CellDoubleClick(sender, New DataGridViewCellEventArgs(0, dgvSearch.CurrentRow.Index))
        ElseIf e.KeyCode = Keys.Up Then
            If dgvSearch.Rows.Count > 0 Then
                If dgvSearch.CurrentRow.Index = 0 Then
                    tstSearch.Focus()
                End If
            Else
                tstSearch.Focus()
            End If
        End If
    End Sub



    Private Sub dgvSearch_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellDoubleClick
        If dgvSearch.Rows.Count = 0 Or e.RowIndex = -1 Then Exit Sub

        Dim Val3 As String = ""

        If dgvSearch.Columns.Count >= 3 Then Val3 = dgvSearch.Item(2, e.RowIndex).Value.ToString

        SelectSearch(dgvSearch.Item(0, e.RowIndex).Value, dgvSearch.Item(1, e.RowIndex).Value, Val3)

    End Sub

  
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If dgvSearch.Rows.Count <= 0 Then
            tstSearch.Focus()
        End If
    End Sub
End Class