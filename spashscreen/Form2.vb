Imports System.IO
Public Class Form2
    Dim neo As Integer = 26
    Dim noe As Integer = 26
    Dim greating As Integer = 0
    Dim pass As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    'start animation some label plus starting some timer
    Private Sub TLblWell2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLblWell2.Tick
        greating += 1
        If greating = 1 Then
            Label2.Text = "WELCOME!"
        ElseIf greating = 3 Then
            Label2.Text = "CONSOLE IS READY"
            '    My.Computer.Audio.Play(My.Resources.Please_Log_In, _
            'AudioPlayMode.Background)
            TextBox1.Visible = True
            TextBox1.Enabled = True
            TextBox1.Focus()
            Form1.TextLog.Text = Form1.TextLog.Text + vbCrLf + "Preparing textbox"
            Form1.TextLog.ScrollToCaret()

        ElseIf greating = 4 Then
            TLblWell2.Enabled = False

        End If
    End Sub

    'Private Sub textbox1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    My.Computer.Audio.Play(My.Resources.click, _
    '    AudioPlayMode.Background)
    '    BtnEsc.Visible = False
    '    BtnShutDown.Visible = False
    '    Dim KeyAscii As Short = CShort(Asc(eventArgs.KeyChar))

    '    If KeyAscii = System.Windows.Forms.Keys.Return Then
    '        If TextBox1.Text <> "" Then
    '            My.Computer.Audio.Play(My.Resources.click_enter, _
    '      AudioPlayMode.Background)
    '            eventArgs.Handled = True
    '            pass = My.Settings.password
    '            'form1.ProgressBar1.Visible = True
    '            ProBar1.Visible = True
    '            Form1.TmrNumAni2.Enabled = True
    '            'Form1.LblWell2.Enabled = True
    '            'start_aquiring()
    '            TProgressB.Enabled = True
    '            TextBox1.Visible = False
    '        Else
    '            Label2.Text = "Cannot be empty code"
    '        End If
    '    End If
    '    If KeyAscii = 8 Then
    '        My.Computer.Audio.Play(My.Resources.click_enter, _
    '  AudioPlayMode.Background)
    '    End If
    'End Sub
    'always focus on authority textbox
    Private Sub TCekTB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCekTB.Tick
        If TextBox1.Text <> "" Then
            'Form1.TmrNumAni.Enabled = True
            'Form1.TmrNumCon.Enabled = True
            'Form1.GBbin.Visible = True
            'Form1.GBbin.Text = "ENCRYPTING LOGIN DATA"
            'LabelBinary.Visible = True
        Else
            'Form1.TmrNumAni.Enabled = False

            'Form1.TmrNumCon.Enabled = False
            Form1.GBbin.Text = "WAITING FOR ENTERED CODE"
            'Form1.reset_num_bridge_connection()
            'Form1.GBbin_clear()
            Form1.Label14.Text = "NULL"
        End If
        Me.TextBox1.Focus()
        ' Me.TopLevel = True
        'Me.Top = True
        'Me.TopMost = True

        If TextBox1.Text <> "" Then
            Dim val As String = Nothing
            Dim result As New System.Text.StringBuilder
            For Each character As Byte In System.Text.ASCIIEncoding.ASCII.GetBytes(TextBox1.Text)
                result.Append(Convert.ToString(character, 2).PadLeft(0, "0"))
                result.Append("   ")
            Next
            val = result.ToString.Substring(0, result.ToString.Length - 1)
            LabelBinary.Text = val
        End If
        ' If TextBox1.Text <> "" Then
        'Dim stri As String = TextBox1.Text
        ' Dim bit() As Byte
        ' Dim hexs As System.Text.StringBuilder = New System.Text.StringBuilder
        '   bit = System.Text.ASCIIEncoding.ASCII.GetBytes(stri)
        '      For i As Integer = 0 To bit.Length - 1
        'hexs.Append(bit(i).ToString("x"))
        '      Next

        '     LabelBinary.Text = Val()
        '     End If

    End Sub
    'starting progress bar
    Dim lin As Boolean = False
    Private Sub TProgressB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TProgressB.Tick
        ProBar1.value += 5
        ProgressBar1.Value = ProgressBar1.Value + 5
        Form1.LblPrcnt.Text = ProBar1.value
        If lin = True Then
            ProBar1.PBText = 1000 - ProBar1.value
        End If

        If ProgressBar1.Value = 10 Then
            'Form1.TmrBreak.Enabled = True
            'Form1.cek = True
            ProBar1.PBText = "FOUND : " & Form1.Label19.Text.ToString
        End If
        If Label2.Text = "Please enter your right code or press ESCAPE to logoff and KILL MACHINE to shutdown" Then
            Form1.LblAutoCMD.Text = "CONTINUING SEND COMMAND"
        End If
        If ProgressBar1.Value = 0 Then
            Label2.Text = "Please wait!"
        End If
        If ProgressBar1.Value = 70 Then
            My.Computer.Audio.Play(My.Resources.loggin_check, _
            AudioPlayMode.BackgroundLoop)
            Label2.Text = "Preparing code"
        End If
        If ProgressBar1.Value = 200 Then
            'Label2.Text = "Please wait!"
            Label2.Text = "Begin Attack"
        End If
        If ProgressBar1.Value = 400 Then
            Label2.Text = "SENDING : " & Form1.Label19.Text.ToString
            lin = True

        End If
        If ProgressBar1.Value = 600 Then
            If TextBox1.Text = pass Then
                Label2.Text = "Access Granted."
                My.Computer.Audio.Play(My.Resources.Access_Granted, _
        AudioPlayMode.Background)
                ProBar1.PBText = ""
            Else
                Label2.Text = "Access Denied."
                ProBar1.PBText = ""
                My.Computer.Audio.Play(My.Resources.Acces_Denied, _
        AudioPlayMode.Background)
            End If
        End If
        If ProgressBar1.Value = 800 Then
            If TextBox1.Text = pass Then
                Label2.Text = "Welcome to C.I.A secure system"
                TextBox1.Visible = False
                Form1.TextLog.Text = Form1.TextLog.Text + vbCrLf + "TextBox1.Visible = False "
                Form1.TextLog.ScrollToCaret()
                '        My.Computer.Audio.Play(My.Resources.User_Name_Authorized, _
                'AudioPlayMode.Background)
            Else
                '        My.Computer.Audio.Play(My.Resources.User_Name_Rejected, _
                'AudioPlayMode.Background)
                'Label2.Text = "Please enter your right code or press ESCAPE to logoff and KILL MACHINE to shutdown"
                Label2.Text = "CODE INVALID, TRY ANOTHER! "
                Form1.TmrCPU2.Enabled = False
                reset_break()

            End If
        End If
        If ProgressBar1.Value = 1000 Then
            TProgressB.Enabled = False
            ProgressBar1.Value = 0
            ProBar1.value = 0
            ProgressBar1.Visible = False
            ProBar1.Visible = False
            Form1.TBTyping.Clear()
            Form1.TmrTyping.Enabled = False
            Form1.TmrNumAni.Enabled = False
            Form1.TmrNumCon.Enabled = False

            Form1.reset_num_bridge_connection()
            'GBbin.Text = "WAITING FOR ENTERED CODE"
            Form1.LblPrcnt.Text = ""
            Form1.GBbin_clear()
            Form1.Label14.Text = "NULL"
            If TextBox1.Text = pass Then
                'TmrEndDelay.Enabled = True
                'Form1.tutup = True
                TextBox1.Visible = False
                Form1.GBbin.Text = "ENCRYPTING STOPPED"
                Form1.LblAutoCMD.Text = "WELL DONE"
                Form1.TmrNumCon.Enabled = False
                Form1.Label14.Text = "FINISHED"
                TCekTB.Enabled = False
                End
            Else
                Form1.mula = False
                Form1.TmrCPU2.Enabled = False
                Form1.hitung = 0
                Form1.cek = False
                Form1.itung = 0
                Form1.TmrBreak.Enabled = True
                TextBox1.Text = ""
                TextBox1.Visible = True
                TextBox1.Focus()
                ProgressBar1.Value = 0
                ProBar1.value = 0
                Form1.TmrNumAni.Enabled = False
                TProgressB.Enabled = False
                Form1.TextLog.Text = Form1.TextLog.Text + vbCrLf + "TProgressB.Enabled = False"
                Form1.TextLog.ScrollToCaret()
                ProgressBar1.Visible = False
                ProBar1.Visible = False
                neo = 26
                noe = 26
                Form1.LblAutoCMD.Text = "WAITING"
                Form1.GBbin.Text = "WAITING FOR ENTERED CODE"
                Form1.TmrNumCon.Enabled = False
                BtnEsc.Visible = True
                BtnShutDown.Visible = True
                LabelBinary.Visible = False
                lin = False
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.GroupBox1.Visible = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal Eventsender As System.Object, ByVal EventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        My.Computer.Audio.Play(My.Resources.click, _
        AudioPlayMode.Background)
        BtnEsc.Visible = False
        BtnShutDown.Visible = False
        Dim KeyAscii As Short = CShort(Asc(EventArgs.KeyChar))

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If TextBox1.Text <> "" Then
                My.Computer.Audio.Play(My.Resources.click_enter, _
          AudioPlayMode.Background)
                EventArgs.Handled = True
                pass = My.Settings.password
                'form1.ProgressBar1.Visible = True
                ProBar1.Visible = True
                Form1.TmrNumAni2.Enabled = True
                'Form1.LblWell2.Enabled = True
                'start_aquiring()
                'TProgressB.Enabled = True
                TextBox1.Visible = False
                Form1.mula = True
                Form1.TmrCPU2.Enabled = True
                Form1.TextLog.Text = Form1.TextLog.Text + vbCrLf + "Form1.TmrCPU2.Enabled = True"
                Form1.TextLog.ScrollToCaret()
                ProBar1.PBText = "BREAKING CODE"
                Label2.Text = "PLEASE WAIT!"
            Else
                
                Label2.Text = "Cannot be empty code"
            End If
        End If
        If KeyAscii = 8 Then
            My.Computer.Audio.Play(My.Resources.click_enter, _
      AudioPlayMode.Background)
        End If
    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class