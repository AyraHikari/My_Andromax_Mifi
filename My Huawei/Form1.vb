Imports System.Xml
Imports System.Web
Public Class Form1
    Dim webClient As New System.Net.WebClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' IP Address
        Dim IP
        FloatingInfo.Show()
        FloatingInfo.Visible = False
        If My.Settings.FirstTime = False Then
InputIP:
            IP = InputBox("Input Your Mifi IP Address")
            If IP = "" Then
                End
            End If
            My.Settings.IpAddress = IP
        End If
        ' Trying to connect
        Try
            webClient.DownloadString("http://" + My.Settings.IpAddress + "/")
        Catch
            MsgBox("Could not connect to " + My.Settings.IpAddress + ", please input your IP Address again")
            GoTo InputIP
        End Try
        ' Success connected
        My.Settings.FirstTime = True
        Timer1.Enabled = True
        GetMsg.Enabled = True
        My.Settings.Cookie = webClient.ResponseHeaders.Get("Set-Cookie")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Creating dim
        Dim result, prov As String

        ' Set Cookie
        webClient.Headers.Set("Cookie", My.Settings.Cookie)

        ' Trying to get status, if failed return and try again later
        Try
            result = webClient.DownloadString("http://" + My.Settings.IpAddress + "/mark_title.w.xml")
        Catch ex As Exception
            Console.WriteLine("Request Time Out at monitoring")
            Return
        End Try

        ' Load Signal xml
        Dim xmlsignal As New XmlDocument()
        xmlsignal.LoadXml(result)

        ' Get if data is turned on
        Dim mifidata = xmlsignal.GetElementsByTagName("wifi")(0).InnerText

        ' Set Network Mode
        Dim netwk, netname
        Dim nettype = xmlsignal.GetElementsByTagName("netstatus")(0).InnerText
        If nettype = 9 Then
            netwk = "Smartfren"
            netname = "4G"
        Else
            netwk = "No Service"
            netname = "x"
        End If

        ' Set Signal Icon
        Dim asw = xmlsignal.GetElementsByTagName("onex")
        If asw(0) Is Nothing Or Provider.Text = "No Service" Then
            NotifyIcon1.Icon = My.Resources.no_service
            NotifyIcon1.Text = "No service"
            SignalBox.Image = My.Resources.icon_signal_00_result
        Else
            If asw(0).InnerText = 0 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_0
                    NotifyIcon1.Text = netname + ": 0 bar" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_0
                    NotifyIcon1.Text = netname + ": 0 bar" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_00_result
                FloatingInfo.SignalImg.Image = My.Resources.signal_01
            ElseIf asw(0).InnerText = 1 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_1
                    NotifyIcon1.Text = netname + ": 1 bar" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_1
                    NotifyIcon1.Text = netname + ": 1 bar" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_01_result
                FloatingInfo.SignalImg.Image = My.Resources.signal_11
            ElseIf asw(0).InnerText = 2 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_2
                    NotifyIcon1.Text = netname + ": 2 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_2
                    NotifyIcon1.Text = netname + ": 2 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_02_result
                FloatingInfo.SignalImg.Image = My.Resources.signal_21
            ElseIf asw(0).InnerText = 3 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_3
                    NotifyIcon1.Text = netname + ": 3 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_3
                    NotifyIcon1.Text = netname + ": 3 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_03_result
                FloatingInfo.SignalImg.Image = My.Resources.signal_31
            ElseIf asw(0).InnerText = 4 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_4
                    NotifyIcon1.Text = netname + ": 4 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_4
                    NotifyIcon1.Text = netname + ": 4 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_04_result
                FloatingInfo.SignalImg.Image = My.Resources.signal_41
            ElseIf asw(0).InnerText = 5 Then
                If mifidata = 1 Then
                    NotifyIcon1.Icon = My.Resources.signal_5
                    NotifyIcon1.Text = netname + ": 5 bars" + vbCrLf
                Else
                    NotifyIcon1.Icon = My.Resources.disabled_5
                    NotifyIcon1.Text = netname + ": 5 bars" + vbCrLf
                End If
                SignalBox.Image = My.Resources.icon_signal_05_result
                FloatingInfo.SignalImg.Image = My.Resources.signal_51
            End If

            If xmlsignal.GetElementsByTagName("wifi")(0).InnerText = "1" Then
                PictureBox1.Visible = True
            Else
                PictureBox1.Visible = False
            End If

            If xmlsignal.GetElementsByTagName("usb")(0).InnerText = "1" Then
                PictureBox2.Visible = True
                FloatingInfo.PictureBox1.Visible = True
            Else
                PictureBox2.Visible = False
                FloatingInfo.PictureBox1.Visible = False
            End If

            Provider.Text = netwk
            NetwkTypeLabel.Text = netname
            FloatingInfo.ProviderLabel.Text = netwk
            FloatingInfo.NetType.Text = netname

            BatteryBar.Value = xmlsignal.GetElementsByTagName("batt_p")(0).InnerText
            FloatingInfo.BatteryLabel.Text = xmlsignal.GetElementsByTagName("batt_p")(0).InnerText + "%"
            BatteryLabel.Text = xmlsignal.GetElementsByTagName("batt_p")(0).InnerText + "%"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles HideBtn.Click
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles WebUibtn.Click
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub MessageInfo_Click(sender As Object, e As MouseEventArgs) Handles MessageInfo.MouseClick
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/html/smsinbox.html")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub msgpic_DoubleClick(sender As Object, e As EventArgs)
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/html/smsinbox.html")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub MessageInfo_BalloonTipClicked(sender As Object, e As EventArgs) Handles MessageInfo.BalloonTipClicked
        Dim homepage As New Uri("http://" + My.Settings.IpAddress + "/html/smsinbox.html")
        BrowserMifi.WebBrowser1.Url = homepage
        BrowserMifi.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next
        Me.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        On Error Resume Next
        Me.Show()
    End Sub

    Private Sub Advanced_Click(sender As Object, e As EventArgs) Handles AdvancedBtn.Click
        Advanced.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            FloatingInfo.Visible = True
        Else
            FloatingInfo.Visible = False
        End If
    End Sub
End Class
