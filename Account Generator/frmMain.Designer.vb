<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Account_Check = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleshooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTroubleshooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboType
        '
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"Minecraft", "Netflix", "Reddit", "Spotify"})
        Me.comboType.Location = New System.Drawing.Point(13, 34)
        Me.comboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(388, 28)
        Me.comboType.TabIndex = 0
        Me.comboType.Text = "Account Type"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(92, 121)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(235, 26)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "Username"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(92, 198)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(235, 26)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(13, 457)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(390, 35)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate Account"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(391, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Account_Check
        '
        Me.Account_Check.Location = New System.Drawing.Point(13, 414)
        Me.Account_Check.Name = "Account_Check"
        Me.Account_Check.Size = New System.Drawing.Size(390, 35)
        Me.Account_Check.TabIndex = 6
        Me.Account_Check.Text = "Check Account"
        Me.Account_Check.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.TroubleshooterToolStripMenuItem, Me.ChangelogToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(426, 33)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(140, 30)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TroubleshooterToolStripMenuItem
        '
        Me.TroubleshooterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenTroubleshooterToolStripMenuItem})
        Me.TroubleshooterToolStripMenuItem.Name = "TroubleshooterToolStripMenuItem"
        Me.TroubleshooterToolStripMenuItem.Size = New System.Drawing.Size(143, 29)
        Me.TroubleshooterToolStripMenuItem.Text = "Troubleshooter"
        '
        'OpenTroubleshooterToolStripMenuItem
        '
        Me.OpenTroubleshooterToolStripMenuItem.Name = "OpenTroubleshooterToolStripMenuItem"
        Me.OpenTroubleshooterToolStripMenuItem.Size = New System.Drawing.Size(265, 30)
        Me.OpenTroubleshooterToolStripMenuItem.Text = "Open Troubleshooter"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowChangelogToolStripMenuItem})
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'ShowChangelogToolStripMenuItem
        '
        Me.ShowChangelogToolStripMenuItem.Name = "ShowChangelogToolStripMenuItem"
        Me.ShowChangelogToolStripMenuItem.Size = New System.Drawing.Size(232, 30)
        Me.ShowChangelogToolStripMenuItem.Text = "Show Changelog"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(426, 506)
        Me.Controls.Add(Me.Account_Check)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.comboType)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Sapphire Account Generator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboType As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Account_Check As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TroubleshooterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTroubleshooterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
