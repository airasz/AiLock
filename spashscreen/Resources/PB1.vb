Imports System.Drawing.Drawing2D
Public Class ProBar
    ' Dim GradColor1 As New Color
    'Dim GradColor2 As New Color
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'LabelPB.ForeColor = Color.Black
        LabelPB.Text = "ProgressBar"
        'LabelPB.Text = MyBase.Name
        LabelPB.Location = New Point(Me.Width / 2 - LabelPB.Width / 2, Me.Height / 2 - LabelPB.Height / 2)
        ' Add any initialization after the InitializeComponent() call
        maxi = 100
    End Sub
    Protected percent As Double = 0.0
    Protected Texto As String = "ProgressBar"
    Protected warna As System.Drawing.Color
    Protected warna1 As System.Drawing.Color
    Protected maxi As Double

    Protected gradien As LinearGradientMode

    Protected warna2 As System.Drawing.Color
    Public Property GradColor1 As System.Drawing.Color
        Get
            Return warna
        End Get
        Set(ByVal GradColor1 As System.Drawing.Color)
            warna = GradColor1
            'LabelPB.Text = value.ToString() + "%"
            Me.Invalidate()
        End Set
    End Property
    Public Property GradColor2 As Color
        Get
            Return warna1
        End Get
        Set(ByVal GradColor2 As Color)
            warna1 = GradColor2
            Me.Invalidate()
        End Set
    End Property
    Public Property ValueMax As Double
        Get
            Return maxi
        End Get
        Set(ByVal ValueMax As Double)
            maxi = ValueMax
            Me.Invalidate()
        End Set
    End Property
    Public Property value As Double
        Get
            Return percent
        End Get
        Set(ByVal value As Double)
            If value < 0 Then value = 0 Else If value > maxi Then value = maxi
            percent = value
            'LabelPB.Text = value.ToString() + "%"
            Me.Invalidate()
        End Set
    End Property
    Public Property PBText As System.String
        Get
            Return Texto
        End Get
        Set(ByVal PBText As String)
            Texto = PBText
            LabelPB.Text = Texto
            LabelPB.Location = New Point(Me.Width / 2 - LabelPB.Width / 2, Me.Height / 2 - LabelPB.Height / 2)

            Me.Invalidate()
        End Set
    End Property
    ' Public Property PBFontColor As System.Drawing.Color
    '    Get
    '      Return warna2
    ''    End Get
    '   Set(ByVal PBFontColor As System.Drawing.Color)
    '      warna2 = PBFontColor
    '     LabelPB.ForeColor = warna2
    '      Me.Invalidate()
    'End Set
    'End Property
    Public Property GradientMode As LinearGradientMode
        Get
            Return gradien
        End Get
        Set(ByVal GradientMode As LinearGradientMode)
            gradien = GradientMode
            Me.Update()
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim b As Brush = New SolidBrush(Me.GradColor2)
        'Dim lb As New LinearGradientBrush(New Rectangle(0, 0, Me.Width, Me.Height), Color.FromArgb(255, Color.White), Color.FromArgb(55, Color.White), LinearGradientMode.ForwardDiagonal)
        Dim lb As New LinearGradientBrush(New Rectangle(0, 0, Me.Width, Me.Height), Color.FromArgb(255, Me.GradColor1), Color.FromArgb(55, Me.GradColor2), gradien)
        Dim width As Integer = CInt(percent / ValueMax * Me.Width)
        Dim height As Integer = CInt(percent / ValueMax * Me.Height)
        e.Graphics.FillRectangle(b, 0, 0, width, Me.Height)
        e.Graphics.FillRectangle(lb, 0, 0, width, Me.Height)
        b.Dispose() : lb.Dispose()
    End Sub
    Private Sub ProBar_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        LabelPB.Location = New Point(Me.Width / 2 - LabelPB.Width / 2, Me.Height / 2 - LabelPB.Height / 2)

    End Sub

    Private Sub LabelPB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelPB.TextChanged
        LabelPB.Location = New Point(Me.Width / 2 - LabelPB.Width / 2, Me.Height / 2 - LabelPB.Height / 2)
    End Sub

    Private Sub ProBar_ForeColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ForeColorChanged
        LabelPB.ForeColor = Me.ForeColor
    End Sub
End Class
