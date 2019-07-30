<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloatingInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.NetType = New System.Windows.Forms.Label()
        Me.ProviderLabel = New System.Windows.Forms.Label()
        Me.SignalImg = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SignalImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatteryLabel.Location = New System.Drawing.Point(69, 32)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(33, 13)
        Me.BatteryLabel.TabIndex = 16
        Me.BatteryLabel.Text = "100%"
        Me.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NetType
        '
        Me.NetType.AutoSize = True
        Me.NetType.BackColor = System.Drawing.Color.Transparent
        Me.NetType.Location = New System.Drawing.Point(30, 28)
        Me.NetType.Name = "NetType"
        Me.NetType.Size = New System.Drawing.Size(14, 13)
        Me.NetType.TabIndex = 13
        Me.NetType.Text = "X"
        '
        'ProviderLabel
        '
        Me.ProviderLabel.AutoSize = True
        Me.ProviderLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProviderLabel.Location = New System.Drawing.Point(3, 7)
        Me.ProviderLabel.Name = "ProviderLabel"
        Me.ProviderLabel.Size = New System.Drawing.Size(54, 13)
        Me.ProviderLabel.TabIndex = 12
        Me.ProviderLabel.Text = "Loading..."
        '
        'SignalImg
        '
        Me.SignalImg.BackColor = System.Drawing.Color.Transparent
        Me.SignalImg.Image = Global.My_Huawei.My.Resources.Resources.loading1
        Me.SignalImg.Location = New System.Drawing.Point(6, 26)
        Me.SignalImg.Name = "SignalImg"
        Me.SignalImg.Size = New System.Drawing.Size(16, 16)
        Me.SignalImg.TabIndex = 11
        Me.SignalImg.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.My_Huawei.My.Resources.Resources.charginglogo
        Me.PictureBox1.Location = New System.Drawing.Point(74, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 30)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'FloatingInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(109, 50)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BatteryLabel)
        Me.Controls.Add(Me.NetType)
        Me.Controls.Add(Me.ProviderLabel)
        Me.Controls.Add(Me.SignalImg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FloatingInfo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FloatingInfo"
        Me.TopMost = True
        CType(Me.SignalImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents NetType As Label
    Friend WithEvents ProviderLabel As Label
    Friend WithEvents SignalImg As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
