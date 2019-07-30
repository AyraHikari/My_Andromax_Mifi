<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advanced
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AccountTab = New System.Windows.Forms.TabPage()
        Me.UiTab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IPaddrMe = New System.Windows.Forms.TextBox()
        Me.Save2 = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.AccountTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AccountTab)
        Me.TabControl1.Controls.Add(Me.UiTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(479, 322)
        Me.TabControl1.TabIndex = 2
        '
        'AccountTab
        '
        Me.AccountTab.Controls.Add(Me.GroupBox1)
        Me.AccountTab.Location = New System.Drawing.Point(4, 22)
        Me.AccountTab.Name = "AccountTab"
        Me.AccountTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AccountTab.Size = New System.Drawing.Size(471, 296)
        Me.AccountTab.TabIndex = 0
        Me.AccountTab.Text = "Account"
        Me.AccountTab.UseVisualStyleBackColor = True
        '
        'UiTab
        '
        Me.UiTab.Location = New System.Drawing.Point(4, 22)
        Me.UiTab.Name = "UiTab"
        Me.UiTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UiTab.Size = New System.Drawing.Size(471, 296)
        Me.UiTab.TabIndex = 1
        Me.UiTab.Text = "User Interface"
        Me.UiTab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.Save2)
        Me.GroupBox1.Controls.Add(Me.IPaddrMe)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change IP Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address"
        '
        'IPaddrMe
        '
        Me.IPaddrMe.Location = New System.Drawing.Point(71, 17)
        Me.IPaddrMe.Name = "IPaddrMe"
        Me.IPaddrMe.Size = New System.Drawing.Size(148, 20)
        Me.IPaddrMe.TabIndex = 1
        '
        'Save2
        '
        Me.Save2.Location = New System.Drawing.Point(6, 43)
        Me.Save2.Name = "Save2"
        Me.Save2.Size = New System.Drawing.Size(128, 23)
        Me.Save2.TabIndex = 2
        Me.Save2.Text = "Save and Reconnect"
        Me.Save2.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(140, 43)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(79, 23)
        Me.Save.TabIndex = 3
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Advanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 323)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Advanced"
        Me.Text = "Advanced"
        Me.TabControl1.ResumeLayout(False)
        Me.AccountTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AccountTab As TabPage
    Friend WithEvents UiTab As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Save As Button
    Friend WithEvents Save2 As Button
    Friend WithEvents IPaddrMe As TextBox
    Friend WithEvents Label1 As Label
End Class
