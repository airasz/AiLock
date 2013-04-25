<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBarVertical
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LabelPB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelPB
        '
        Me.LabelPB.AutoSize = True
        Me.LabelPB.Location = New System.Drawing.Point(17, 132)
        Me.LabelPB.Name = "LabelPB"
        Me.LabelPB.Size = New System.Drawing.Size(13, 13)
        Me.LabelPB.TabIndex = 0
        Me.LabelPB.Text = "0"
        '
        'PBarVertical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelPB)
        Me.Name = "PBarVertical"
        Me.Size = New System.Drawing.Size(46, 276)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPB As System.Windows.Forms.Label

End Class
