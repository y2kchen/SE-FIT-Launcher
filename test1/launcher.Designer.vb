<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(launcher))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLaunch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbFileName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 86)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(346, 217)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(56, 48)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(54, 23)
        Me.BtnRefresh.TabIndex = 1
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(290, 50)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {63, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "core selection"
        '
        'BtnLaunch
        '
        Me.BtnLaunch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnLaunch.Location = New System.Drawing.Point(196, 12)
        Me.BtnLaunch.Name = "BtnLaunch"
        Me.BtnLaunch.Size = New System.Drawing.Size(162, 23)
        Me.BtnLaunch.TabIndex = 4
        Me.BtnLaunch.Text = "Launch SE-FIT"
        Me.BtnLaunch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'TbFileName
        '
        Me.TbFileName.Location = New System.Drawing.Point(71, 9)
        Me.TbFileName.Name = "TbFileName"
        Me.TbFileName.Size = New System.Drawing.Size(100, 20)
        Me.TbFileName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name"
        '
        'launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 333)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLaunch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "launcher"
        Me.Text = "SE-FIT Launcher"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLaunch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbFileName As TextBox
    Friend WithEvents Label3 As Label
End Class
