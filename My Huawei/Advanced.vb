Public Class Advanced
    Dim webClient As New System.Net.WebClient

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Console.WriteLine(TabControl1.SelectedIndex)
    End Sub

    Private Sub Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IPaddrMe.Text = My.Settings.IpAddress
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        ' IP Address
        Save2.Enabled = False
        Save.Enabled = False
        If IPaddrMe.Text = "" Then
            MsgBox("Invaild IP address!", 16)
            Save2.Enabled = True
            Save.Enabled = True
            Return
        End If
        ' Trying to connect
        Try
            webClient.DownloadString("http://" + IPaddrMe.Text + "/")
        Catch
            MsgBox("Could not connect to " + My.Settings.IpAddress + ", please input your IP Address again")
            Save2.Enabled = True
            Save.Enabled = True
            Return
        End Try
        ' Success connected
        My.Settings.IpAddress = IPaddrMe.Text
        Save2.Enabled = True
        Save.Enabled = True
        MsgBox("Connected!")
        My.Settings.Cookie = webClient.ResponseHeaders.Get("Set-Cookie")
        IPaddrMe.Text = My.Settings.IpAddress
        My.Settings.IpAddress = IPaddrMe.Text
    End Sub
End Class