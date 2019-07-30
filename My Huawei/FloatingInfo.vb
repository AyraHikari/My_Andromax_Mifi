Public Class FloatingInfo
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub FloatingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TitleDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, NetType.MouseDown, SignalImg.MouseDown, BatteryLabel.MouseDown, ProviderLabel.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TitleMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, NetType.MouseMove, ProviderLabel.MouseMove, SignalImg.MouseMove, BatteryLabel.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TitleUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, NetType.MouseUp, ProviderLabel.MouseUp, SignalImg.MouseUp, BatteryLabel.MouseUp
        drag = False
    End Sub
End Class