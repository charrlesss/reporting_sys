Imports System.Net
Imports System.IO
Imports System.Text

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class Form1
    Private loadingForm As frmLoading  ' Declare the loading form

    Dim __URL As String = "http://localhost:4400"
    Dim __CURL As String = "localhost"

    Dim ACCESS_TOKEN As String = ""
    Dim REFRESH_TOKEN As String = ""
    Dim DEPARTMENT As String = ""
    Dim IS_ADMIN As String = ""
    Dim ACCESS As String = ""
    Dim up_ac_login As String = ""
    Dim up_dpm_login As String = ""
    Dim up_ima_login As String = ""
    Dim up_at_login As String = ""
    Dim up_rt_login As String = ""



    Public Sub ShowLoading()
        ' Ensure that the loading form is not already open
        If loadingForm Is Nothing OrElse loadingForm.IsDisposed Then

            loadingForm = New frmLoading()
            loadingForm.Show()
            loadingForm.BringToFront()  ' Bring it to the front to ensure visibility
        End If
    End Sub
    Public Sub HideLoading()
        If loadingForm IsNot Nothing AndAlso loadingForm.Visible Then
            loadingForm.Close()
        End If

    End Sub

    Public Sub ResponseSubAccount(dt As DataTable)
        Try

            Dim report As New ReportDocument()
            report.Load(Application.StartupPath & "\userReport.rpt")
            report.Database.Tables("users").SetDataSource(dt)

            report.SummaryInfo.ReportTitle = "CHARLES USERS"
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.ReportSource = report


        Catch ex As System.Runtime.InteropServices.COMException
            MessageBox.Show("COM Exception: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General Exception: " & ex.Message)

        End Try
    End Sub

    Public Function GetApiData(url As String) As String
        ' Create a request to the API
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.Headers("Authorization") = "Bearer " & ACCESS_TOKEN ' Replace with your access token if required

        ' Get the response from the API
        Dim jsonResponse As String = String.Empty

        Try
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    jsonResponse = reader.ReadToEnd()
                End Using
            End Using

            Return jsonResponse ' Return the response as a string

        Catch ex As WebException
            ' Handle exceptions (e.g., log the error)
            Using reader As New StreamReader(ex.Response.GetResponseStream())
                Dim errorResponse As String = reader.ReadToEnd()
                Console.WriteLine("Error: " & errorResponse)
            End Using
            Return String.Empty
        End Try
    End Function

    Sub addCokie(request As HttpWebRequest)
        Dim cookieContainer As New CookieContainer()
        Dim cookie1 As New Cookie("up-ac-login", up_ac_login) With {
            .Domain = __CURL
        }
        cookieContainer.Add(cookie1)
        Dim cookie2 As New Cookie("up-dpm-login", up_dpm_login) With {
            .Domain = __CURL
        }
        cookieContainer.Add(cookie2)
        Dim cookie3 As New Cookie("up-ima-login", up_ima_login) With {
        .Domain = __CURL
        }
        cookieContainer.Add(cookie3)

        Dim cookie4 As New Cookie("up-at-login", up_at_login) With {
        .Domain = __CURL
        }
        cookieContainer.Add(cookie4)

        Dim cookie5 As New Cookie("up-rt-login", up_rt_login) With {
        .Domain = __CURL
        }
        cookieContainer.Add(cookie5)

        request.CookieContainer = cookieContainer
    End Sub


    Public Sub GetReportApi(url As String, callback As CallbackDelegate)
        Dim _url As String = __URL & "/api" & url

        ' Create a request to the API
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(_url), HttpWebRequest)
        request.Method = "GET"


        request.ContentType = "application/json"
        request.Headers("Authorization") = "Bearer " & ACCESS_TOKEN
        addCokie(request)


        ' Get the response from the API
        Dim jsonResponse As String
        Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                jsonResponse = reader.ReadToEnd()
            End Using
        End Using

        ' Deserialize the JSON response to a JObject
        Dim jsonObject As JObject = JObject.Parse(jsonResponse)

        ' Extract the "data" field as a JArray (adjust the key name based on your API response)
        Dim dataArray As JArray = jsonObject("data")

        ' Deserialize the JArray to a DataTable
        Dim dtbs As DataTable = JsonConvert.DeserializeObject(Of DataTable)(dataArray.ToString())

        If callback IsNot Nothing Then
            callback(dtbs)
        End If
    End Sub



    Public Sub PostReportApi(url As String, postData As Dictionary(Of String, String), callback As CallbackDelegate)
        Dim _url As String = __URL & "/api" & url

        ' Serialize the data object to JSON
        Dim jsonPayload As String = JsonConvert.SerializeObject(postData)

        ' Create a request to the API
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(_url), HttpWebRequest)
        request.Method = "POST"


        request.ContentType = "application/json"
        request.Headers("Authorization") = "Bearer " & ACCESS_TOKEN

        ' (Cookie setup omitted for brevity)

        ' Convert the JSON payload to a byte array
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(jsonPayload)
        request.ContentLength = byteArray.Length

        ' Write the JSON data to the request stream
        Using dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
        End Using

        ' Get the response from the API
        Dim jsonResponse As String
        Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                jsonResponse = reader.ReadToEnd()
            End Using
        End Using

        ' Deserialize the JSON response to a JObject
        Dim jsonObject As JObject = JObject.Parse(jsonResponse)

        ' Extract the "data" field as a JArray (adjust the key name based on your API response)
        Dim dataArray As JArray = jsonObject("data")

        ' Deserialize the JArray to a DataTable
        Dim dtbs As DataTable = JsonConvert.DeserializeObject(Of DataTable)(dataArray.ToString())

        If callback IsNot Nothing Then
            callback(dtbs)
        End If
    End Sub

    Public Sub GetReportTableApi(url As String, callback As CallbackDelegate)
        Dim _url As String = __URL & "/api" & url


        ' Create a request to the API
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(_url), HttpWebRequest)
        request.Method = "GET"

        request.ContentType = "application/json"
        request.Headers("Authorization") = "Bearer " & ACCESS_TOKEN
        addCokie(request)


        ' Get the response from the API
        Dim jsonResponse As String
        Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                jsonResponse = reader.ReadToEnd()
            End Using
        End Using

        ' Deserialize the JSON response to a JObject
        Dim jsonObject As JObject = JObject.Parse(jsonResponse)

        ' Extract the "data" field as a JArray (adjust the key name based on your API response)
        Dim dataArray As JArray = jsonObject("data")

        ' Deserialize the JArray to a DataTable
        Dim dtbs As DataTable = JsonConvert.DeserializeObject(Of DataTable)(dataArray.ToString())

        If callback IsNot Nothing Then
            callback(dtbs)
        End If
    End Sub


    Public Delegate Sub CallbackDelegate(data As DataTable)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.FormBorderStyle = FormBorderStyle.None
        Me.MaximizeBox = True
        Me.WindowState = FormWindowState.Maximized
        CrystalReportViewer1.ToolPanelView = False
        Button1.FlatAppearance.BorderSize = 0


        Dim url As String = ""
        Dim response As String = ""
        url = __URL & "/api/get-user-details"

        Dim jsonResponse As String = GetApiData(url)
        response = jsonResponse

        Using reader As New System.IO.StringReader(response)
            Dim line As String
            ' Read each line until the end of the string
            While (reader.Peek() >= 0)
                line = reader.ReadLine() ' Read a single line
                Dim colonIndex As Integer = line.IndexOf(":")
                If colonIndex <> -1 Then
                    Dim namePart As String = line.Substring(0, colonIndex) ' Get the part before the colon
                    Dim valuePart As String = line.Substring(colonIndex + 1) ' Get the part after the colon
                    Select Case namePart.Trim()
                        Case "ACCESS_TOKEN"
                            ACCESS_TOKEN = valuePart.Trim()
                        Case "REFRESH_TOKEN"
                            REFRESH_TOKEN = valuePart.Trim()
                        Case "DEPARTMENT"
                            DEPARTMENT = valuePart.Trim()
                        Case "IS_ADMIN"
                            IS_ADMIN = valuePart.Trim()
                        Case "ACCESS"
                            ACCESS = valuePart.Trim()
                        Case "up_ac_login"
                            up_ac_login = valuePart.Trim()
                        Case "up_dpm_login"
                            up_dpm_login = valuePart.Trim()
                        Case "up_ima_login"
                            up_ima_login = valuePart.Trim()
                        Case "up_at_login"
                            up_at_login = valuePart.Trim()
                        Case "up_rt_login"
                            up_rt_login = valuePart.Trim()
                        Case Else
                    End Select
                End If
            End While
        End Using

        Console.WriteLine(ACCESS_TOKEN)
        Console.WriteLine(REFRESH_TOKEN)
        Console.WriteLine(DEPARTMENT)
        Console.WriteLine(IS_ADMIN)
        Console.WriteLine(ACCESS)
        Console.WriteLine(up_ac_login)
        Console.WriteLine(up_dpm_login)
        Console.WriteLine(up_ima_login)
        Console.WriteLine(up_at_login)
        Console.WriteLine(up_rt_login)



    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formodal As New Form1
        Try
            Dim modal As New frmModal



            modal.StartPosition = FormStartPosition.CenterParent
            modal.Owner = formodal
            modal.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this application?",
                                           "Confirm Exit",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the closing event
        End If
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class
