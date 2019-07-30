<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.HideBtn = New System.Windows.Forms.Button()
        Me.Provider = New System.Windows.Forms.Label()
        Me.WebUibtn = New System.Windows.Forms.Button()
        Me.MessageInfo = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GetMsg = New System.Windows.Forms.Timer(Me.components)
        Me.SignalBox = New System.Windows.Forms.PictureBox()
        Me.NetwkTypeLabel = New System.Windows.Forms.Label()
        Me.NetUsageLabel = New System.Windows.Forms.Label()
        Me.BatteryBar = New System.Windows.Forms.ProgressBar()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.AdvancedBtn = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SignalBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Loading..."
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem1.Text = "Open Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(12, 258)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(275, 30)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'HideBtn
        '
        Me.HideBtn.Location = New System.Drawing.Point(12, 222)
        Me.HideBtn.Name = "HideBtn"
        Me.HideBtn.Size = New System.Drawing.Size(275, 30)
        Me.HideBtn.TabIndex = 5
        Me.HideBtn.Text = "Hide"
        Me.HideBtn.UseVisualStyleBackColor = True
        '
        'Provider
        '
        Me.Provider.AutoSize = True
        Me.Provider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Provider.Location = New System.Drawing.Point(12, 13)
        Me.Provider.Name = "Provider"
        Me.Provider.Size = New System.Drawing.Size(84, 19)
        Me.Provider.TabIndex = 2
        Me.Provider.Text = "Loading..."
        '
        'WebUibtn
        '
        Me.WebUibtn.Location = New System.Drawing.Point(12, 186)
        Me.WebUibtn.Name = "WebUibtn"
        Me.WebUibtn.Size = New System.Drawing.Size(135, 30)
        Me.WebUibtn.TabIndex = 3
        Me.WebUibtn.Text = "Open WebUi"
        Me.WebUibtn.UseVisualStyleBackColor = True
        '
        'MessageInfo
        '
        Me.MessageInfo.BalloonTipText = "You got message!"
        Me.MessageInfo.BalloonTipTitle = "Click here to read message"
        Me.MessageInfo.Icon = CType(resources.GetObject("MessageInfo.Icon"), System.Drawing.Icon)
        Me.MessageInfo.Text = "Message"
        '
        'GetMsg
        '
        Me.GetMsg.Interval = 5000
        '
        'SignalBox
        '
        Me.SignalBox.Image = CType(resources.GetObject("SignalBox.Image"), System.Drawing.Image)
        Me.SignalBox.Location = New System.Drawing.Point(12, 76)
        Me.SignalBox.Name = "SignalBox"
        Me.SignalBox.Size = New System.Drawing.Size(80, 80)
        Me.SignalBox.TabIndex = 8
        Me.SignalBox.TabStop = False
        '
        'NetwkTypeLabel
        '
        Me.NetwkTypeLabel.AutoSize = True
        Me.NetwkTypeLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetwkTypeLabel.Location = New System.Drawing.Point(12, 76)
        Me.NetwkTypeLabel.Name = "NetwkTypeLabel"
        Me.NetwkTypeLabel.Size = New System.Drawing.Size(32, 26)
        Me.NetwkTypeLabel.TabIndex = 9
        Me.NetwkTypeLabel.Text = "??"
        '
        'NetUsageLabel
        '
        Me.NetUsageLabel.AutoSize = True
        Me.NetUsageLabel.Location = New System.Drawing.Point(98, 110)
        Me.NetUsageLabel.Name = "NetUsageLabel"
        Me.NetUsageLabel.Size = New System.Drawing.Size(74, 13)
        Me.NetUsageLabel.TabIndex = 10
        Me.NetUsageLabel.Text = "Battery remain"
        '
        'BatteryBar
        '
        Me.BatteryBar.Location = New System.Drawing.Point(98, 128)
        Me.BatteryBar.Name = "BatteryBar"
        Me.BatteryBar.Size = New System.Drawing.Size(189, 23)
        Me.BatteryBar.TabIndex = 11
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatteryLabel.Location = New System.Drawing.Point(174, 133)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(33, 13)
        Me.BatteryLabel.TabIndex = 12
        Me.BatteryLabel.Text = "100%"
        Me.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdvancedBtn
        '
        Me.AdvancedBtn.Location = New System.Drawing.Point(152, 186)
        Me.AdvancedBtn.Name = "AdvancedBtn"
        Me.AdvancedBtn.Size = New System.Drawing.Size(135, 30)
        Me.AdvancedBtn.TabIndex = 14
        Me.AdvancedBtn.Text = "Advanced"
        Me.AdvancedBtn.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 163)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Show Overlay Window"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.My_Huawei.My.Resources.Resources.Wifi
        Me.PictureBox1.InitialImage = Global.My_Huawei.My.Resources.Resources.Wifi
        Me.PictureBox1.Location = New System.Drawing.Point(234, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.My_Huawei.My.Resources.Resources.charginglogo
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(270, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 30)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AdvancedBtn)
        Me.Controls.Add(Me.BatteryLabel)
        Me.Controls.Add(Me.BatteryBar)
        Me.Controls.Add(Me.NetUsageLabel)
        Me.Controls.Add(Me.NetwkTypeLabel)
        Me.Controls.Add(Me.SignalBox)
        Me.Controls.Add(Me.WebUibtn)
        Me.Controls.Add(Me.Provider)
        Me.Controls.Add(Me.HideBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Andromax"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SignalBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ExitBtn As Button
    Friend WithEvents HideBtn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Provider As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WebUibtn As Button
    Friend WithEvents MessageInfo As NotifyIcon
    Friend WithEvents GetMsg As Timer
    Friend WithEvents SignalBox As PictureBox
    Friend WithEvents NetwkTypeLabel As Label
    Friend WithEvents NetUsageLabel As Label
    Friend WithEvents BatteryBar As ProgressBar
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents AdvancedBtn As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
