<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Troubleshooter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Troubleshooter))
        Me.RTB_TroubleShooter = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RTB_TroubleShooter
        '
        Me.RTB_TroubleShooter.Location = New System.Drawing.Point(13, 13)
        Me.RTB_TroubleShooter.Name = "RTB_TroubleShooter"
        Me.RTB_TroubleShooter.Size = New System.Drawing.Size(497, 554)
        Me.RTB_TroubleShooter.TabIndex = 0
        Me.RTB_TroubleShooter.Text = resources.GetString("RTB_TroubleShooter.Text")
        '
        'Troubleshooter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 579)
        Me.Controls.Add(Me.RTB_TroubleShooter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Troubleshooter"
        Me.Text = "Troubleshooter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RTB_TroubleShooter As RichTextBox
End Class
