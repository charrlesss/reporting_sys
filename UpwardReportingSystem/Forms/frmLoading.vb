Public Class frmLoading
    Private loadingLabel As Label ' Declare label for loading message

    Public Sub New()
        InitializeComponent()
        Me.TopMost = True  ' Keeps the loading form on top
        Me.FormBorderStyle = FormBorderStyle.None  ' No borders
        Me.FormBorderStyle = FormBorderStyle.None  ' No borders
        Me.WindowState = FormWindowState.Maximized  ' Fullscreen
        Me.StartPosition = FormStartPosition.CenterScreen  ' Center the form
        Me.Opacity = 0.8D
    End Sub


  
    Private Sub CenterLabel()
        loadingLabel.Location = New Point((Me.ClientSize.Width - 150 - loadingLabel.Width) / 2,
                                           (Me.ClientSize.Height - loadingLabel.Height) / 2)
    End Sub
  
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingLabel = New Label()
        loadingLabel.Text = "Loading, please wait..."
        loadingLabel.AutoSize = True
        loadingLabel.Font = New Font("Arial", 20, FontStyle.Bold)
        loadingLabel.ForeColor = Color.Black
        CenterLabel()
        Me.Controls.Add(loadingLabel)  ' Add label to the form
    End Sub
End Class