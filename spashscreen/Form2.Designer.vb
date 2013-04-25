<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnShutDown = New System.Windows.Forms.Button()
        Me.BtnEsc = New System.Windows.Forms.Button()
        Me.LabelBinary = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TCekTB = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressB = New System.Windows.Forms.Timer(Me.components)
        Me.TLblWell2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProBar1 = New iLockScreen.ProBar()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ProBar1)
        Me.GroupBox1.Controls.Add(Me.BtnShutDown)
        Me.GroupBox1.Controls.Add(Me.BtnEsc)
        Me.GroupBox1.Controls.Add(Me.LabelBinary)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LblDev)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(1, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 235)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(326, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 22)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Lime
        Me.Label18.Location = New System.Drawing.Point(6, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 20)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Type"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Lime
        Me.Label17.Location = New System.Drawing.Point(6, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Target"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Lime
        Me.Label15.Location = New System.Drawing.Point(88, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(243, 20)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = ":  C.I.A main server"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnShutDown
        '
        Me.BtnShutDown.BackColor = System.Drawing.Color.Black
        Me.BtnShutDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShutDown.ForeColor = System.Drawing.Color.White
        Me.BtnShutDown.Location = New System.Drawing.Point(197, 182)
        Me.BtnShutDown.Name = "BtnShutDown"
        Me.BtnShutDown.Size = New System.Drawing.Size(110, 34)
        Me.BtnShutDown.TabIndex = 8
        Me.BtnShutDown.Text = "KILL MACHINE"
        Me.BtnShutDown.UseVisualStyleBackColor = False
        Me.BtnShutDown.Visible = False
        '
        'BtnEsc
        '
        Me.BtnEsc.AccessibleDescription = ""
        Me.BtnEsc.BackColor = System.Drawing.Color.Black
        Me.BtnEsc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEsc.ForeColor = System.Drawing.Color.White
        Me.BtnEsc.Location = New System.Drawing.Point(67, 182)
        Me.BtnEsc.Name = "BtnEsc"
        Me.BtnEsc.Size = New System.Drawing.Size(108, 34)
        Me.BtnEsc.TabIndex = 7
        Me.BtnEsc.Tag = ""
        Me.BtnEsc.Text = "ESCAPE"
        Me.BtnEsc.UseVisualStyleBackColor = False
        Me.BtnEsc.Visible = False
        '
        'LabelBinary
        '
        Me.LabelBinary.ForeColor = System.Drawing.Color.Lime
        Me.LabelBinary.Location = New System.Drawing.Point(17, 184)
        Me.LabelBinary.Name = "LabelBinary"
        Me.LabelBinary.Size = New System.Drawing.Size(324, 30)
        Me.LabelBinary.TabIndex = 17
        Me.LabelBinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(-7, 229)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(348, 28)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Super secure login protocol "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDev
        '
        Me.LblDev.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDev.ForeColor = System.Drawing.Color.Red
        Me.LblDev.Location = New System.Drawing.Point(88, 37)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(261, 20)
        Me.LblDev.TabIndex = 5
        Me.LblDev.Text = ":  level A protected system"
        Me.LblDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(20, 148)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 29)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(28, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 69)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TCekTB
        '
        Me.TCekTB.Enabled = True
        Me.TCekTB.Interval = 1000
        '
        'TProgressB
        '
        Me.TProgressB.Interval = 60
        '
        'TLblWell2
        '
        Me.TLblWell2.Enabled = True
        Me.TLblWell2.Interval = 2000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 100)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(321, 33)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'ProBar1
        '
        Me.ProBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProBar1.ForeColor = System.Drawing.Color.White
        Me.ProBar1.GradColor1 = System.Drawing.Color.Green
        Me.ProBar1.GradColor2 = System.Drawing.Color.Green
        Me.ProBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.ProBar1.Location = New System.Drawing.Point(20, 146)
        Me.ProBar1.Name = "ProBar1"
        Me.ProBar1.PBText = ""
        Me.ProBar1.Size = New System.Drawing.Size(321, 32)
        Me.ProBar1.TabIndex = 3
        Me.ProBar1.value = 0.0R
        Me.ProBar1.ValueMax = 1000.0R
        Me.ProBar1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(363, 232)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Opacity = 0.7R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ProBar1 As iLockScreen.ProBar
    Friend WithEvents BtnShutDown As System.Windows.Forms.Button
    Friend WithEvents BtnEsc As System.Windows.Forms.Button
    Friend WithEvents LabelBinary As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblDev As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TCekTB As System.Windows.Forms.Timer
    Friend WithEvents TProgressB As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TLblWell2 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
