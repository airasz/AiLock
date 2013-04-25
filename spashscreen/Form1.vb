
Imports System.IO



Public Class Form1
    Private OldValue As Single = 0
    Private NewValue As Single = 0
    Dim XMove As Integer = 1
    Dim Chunks As Integer = 10
    Dim maksGraph As Single = 100
    Dim minGraphs As Single = 0
    Dim LeftMargin As Integer = 5
    Dim RightMargin As Integer = 5
    Dim BaseMargin As Integer = 2
    Dim TopMargin As Integer = 2


    Dim hit As Integer
    Public mula As Boolean = False
    Public word As String
    Dim rndstring As String
    Dim rndstrings As String
    Dim neo As Integer = 26
    Dim noe As Integer = 26
    Dim time As Date
    Dim pass As String
    Dim LL, II, PP, XX, YY, ZZ As Integer
    Dim angka As Integer = 100
    Dim greating As Integer = 0
    Dim text2 As String
    Dim text3 As String
    Public rando As Integer
    Public rndomis As New Random()
    Dim randomise As Integer
    Dim tutup As Boolean = False
    'block ALT +F4 key
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Alt Or Keys.F4) Then
            Return True
        ElseIf keyData = (Keys.Control Or Keys.Alt Or Keys.F12) Then
            GBcodeCh.Focus()
            GBcodeCh.Visible = True
            TCekTB.Enabled = False
            TmrGBcodeCh.Enabled = True
            GBcodeCh.Dock = DockStyle.None
            TBcodeCh.Focus()
            BtnEsc.Enabled = False
            BtnShutDown.Enabled = False
            Return True
            Return MyBase.ProcessCmdKey(msg, keyData)
            Form2.Hide()
        ElseIf keyData = (Keys.Control Or Keys.Alt Or Keys.F11) Then
            TCekTB.Enabled = False
            Return True
            Return MyBase.ProcessCmdKey(msg, keyData)
            Me.Top = False
        End If
    End Function
    Public Property UseCompatibleTextRendering As Boolean
    Public qq As Integer
    Public ww As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'RichTextBox1.UseCompatibleTextRendering = True
        'Label2.UseCompatibleTextRendering = True
        'Label1.UseCompatibleTextRendering = True
        'Label9.UseCompatibleTextRendering = True

        'Label9.Font = Module1.GetInstance(9, FontStyle.Regular)
        'My.Computer.FileSystem.CopyFile(My.Resources.OCR, "C:/Windows/Fonts")
        RichTextBox1.Font = Module1.GetInstance(9, FontStyle.Regular)
        RichTextBox2.Font = Module1.GetInstance(9, FontStyle.Regular)
        RichTextBox3.Font = Module1.GetInstance(11, FontStyle.Regular)
        RichTextBox4.Font = Module1.GetInstance(10, FontStyle.Regular)
        'Label2.Font = Module1.GetInstance(16, FontStyle.Regular)
        'RichTextBox1.Font = (9, My.Resources.SF_Digital_Readout_Medium)
        Me.UseCompatibleTextRendering = True
        LblDate.Text = Date.Now
        typing()
        reset_num_bridge_connection()
        position()
        TextLog.Text = "Starting Position"
        TextLog.ScrollToCaret()
        'break()
        binary()
        qq = Label19.Top
        TextLog.Text = TextLog.Text + vbCrLf + "Writing Code"
        TextLog.ScrollToCaret()
        ww = qq + 2
    End Sub
    Sub binary()
        RichTextBox3.Text = RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10)
        RichTextBox3.Text = RichTextBox3.Text & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) & vbCrLf & RandomStringa(10) '& vbCrLf & RichTextBox3.Text
    End Sub
    Sub position()
        GroupBox2.Width = (Me.Width / 2) + 100
        'GBTyping.Width = Me.Width / 2
        'GBTyping.Left = (Me.Width / 2) + 12
        'GroupBox1.Left = (Me.Width / 2) - (GroupBox1.Width / 2)
        GBbin.Left = (Me.Width / 2) - (GBbin.Width / 2)
        GBbin.Top = Me.Top + 20
        GroupBox2.Height = Me.Height - 50
        GBTyping.Height = Me.Height - 50
        Panel1.Height = GroupBox2.Height - 70
        Panel1.Width = GroupBox2.Width - 5
        RichTextBox1.Height = Panel1.Height - 5
        RichTextBox1.Width = (Panel1.Width / 2) - 20
        RichTextBox1.Left = (Panel1.Left) + 2
        RichTextBox2.Width = (Panel1.Width / 2) - 10
        RichTextBox2.Height = Panel1.Height - 5
        Label10.Left = Panel1.Width / 2
        GroupBox1.Left = (GroupBox2.Width / 2) - (GroupBox1.Width / 2)
        Label12.Top = Label11.Top
        TextLog.Top = RichTextBox3.Height + 10
        'GBbin.Left = Me.Width - GBbin.Width - 20
    End Sub
    'Private Sub start_analysis()
   

   
    'handling textbox authority code entered 
    Private Sub textbox1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        My.Computer.Audio.Play(My.Resources.click, _
        AudioPlayMode.Background)
        BtnEsc.Visible = False
        BtnShutDown.Visible = False
        Dim KeyAscii As Short = CShort(Asc(eventArgs.KeyChar))

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If TextBox1.Text <> "" Then
                My.Computer.Audio.Play(My.Resources.click_enter, _
          AudioPlayMode.Background)
                eventArgs.Handled = True
                pass = My.Settings.password
                'ProgressBar1.Visible = True
                ProBar1.Visible = True
                TmrNumAni2.Enabled = True
                TLblWell2.Enabled = True
                start_aquiring()
                TextBox1.Visible = False
                mula = True
                Label12.Text = mula.ToString
            Else
                Label2.Text = "Cannot be empty code"
            End If
        End If
        If KeyAscii = 8 Then
            My.Computer.Audio.Play(My.Resources.click_enter, _
      AudioPlayMode.Background)
        End If
    End Sub
    Private Sub start_aquiring()
        TProgressB.Enabled = True
    End Sub
    'always focus on authority textbox
    Private Sub TCekTB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCekTB.Tick
        If TextBox1.Text <> "" Then
            'TmrNumAni.Enabled = True
            'TmrNumCon.Enabled = True
            'GBbin.Text = "ENCRYPTING LOGIN DATA"
            LabelBinary.Visible = True
        Else
            'TmrNumAni.Enabled = False
            'TmrNumCon.Enabled = False
            'GBbin.Text = "WAITING FOR ENTERED CODE"
            'reset_num_bridge_connection()
            'GBbin_clear()
            'Label14.Text = "NULL"
        End If
        'Me.TextBox1.Focus()
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
    Private Sub TProgressB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TProgressB.Tick
        ProBar1.value += 5
        ProgressBar1.Value = ProgressBar1.Value + 5
        LblPrcnt.Text = ProBar1.value
        ProBar1.PBText = 1000 - ProBar1.value

        If ProgressBar1.Value = 10 Then
            ' My.Computer.Audio.Play(My.Resources.Processing, _
            'AudioPlayMode.Background)
        End If
        If Label2.Text = "Please enter your right code or press ESCAPE to logoff and KILL MACHINE to shutdown" Then
            LblAutoCMD.Text = "CONTINUING SEND COMMAND"
        End If
        If ProgressBar1.Value = 0 Then
            Label2.Text = "Please wait!"
        End If
        If ProgressBar1.Value = 70 Then
            My.Computer.Audio.Play(My.Resources.loggin_check, _
            AudioPlayMode.BackgroundLoop)
        End If
        If ProgressBar1.Value = 200 Then
            Label2.Text = "System checking the code you,ve entered...."
        End If
        If ProgressBar1.Value = 600 Then
            If TextBox1.Text = pass Then
                Label2.Text = "Access Granted."
                My.Computer.Audio.Play(My.Resources.Access_Granted, _
        AudioPlayMode.Background)
            Else
                Label2.Text = "Access Denied."
                My.Computer.Audio.Play(My.Resources.Acces_Denied, _
        AudioPlayMode.Background)
            End If
        End If
        If ProgressBar1.Value = 800 Then
            If TextBox1.Text = pass Then
                Label2.Text = "Welcome to C.I.A secure system"
                TextBox1.Visible = False
                '        My.Computer.Audio.Play(My.Resources.User_Name_Authorized, _
                'AudioPlayMode.Background)
            Else
                '        My.Computer.Audio.Play(My.Resources.User_Name_Rejected, _
                'AudioPlayMode.Background)
                Label2.Text = "Please enter your right code or press ESCAPE to logoff and KILL MACHINE to shutdown"
            End If
        End If
        If ProgressBar1.Value = 1000 Then
            TProgressB.Enabled = False
            ProgressBar1.Value = 0
            ProBar1.value = 0
            ProgressBar1.Visible = False
            ProBar1.Visible = False
            TBTyping.Clear()
            TmrTyping.Enabled = False
            TmrNumAni.Enabled = False
            TmrNumCon.Enabled = False

            reset_num_bridge_connection()
            'GBbin.Text = "WAITING FOR ENTERED CODE"
            LblPrcnt.Text = ""
            GBbin_clear()
            Label14.Text = "NULL"
            If TextBox1.Text = pass Then
                'TmrEndDelay.Enabled = True
                tutup = True
                TextBox1.Visible = False
                GBbin.Text = "ENCRYPTING STOPPED"
                LblAutoCMD.Text = "WELL DONE"
                TmrNumCon.Enabled = False
                Label14.Text = "FINISHED"
                TCekTB.Enabled = False
                End
            Else

                TextBox1.Text = ""
                TextBox1.Visible = True
                TextBox1.Focus()
                ProgressBar1.Value = 0
                ProBar1.value = 0
                TmrNumAni.Enabled = False
                TProgressB.Enabled = False
                ProgressBar1.Visible = False
                ProBar1.Visible = False
                neo = 26
                noe = 26
                LblAutoCMD.Text = "WAITING"
                GBbin.Text = "WAITING FOR ENTERED CODE"
                TmrNumCon.Enabled = False
                BtnEsc.Visible = True
                BtnShutDown.Visible = True
                LabelBinary.Visible = False
            End If
        End If
    End Sub
    Private Sub TLblWell_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLblWell.Tick
        If Label2.Visible = False Then
            Label2.Visible = True
        Else : Label2.Visible = False
        End If
    End Sub
    'start animation some label plus starting some timer
    Private Sub TLblWell2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLblWell2.Tick
        'If Label2.Text = "" Then
        '    Label2.Text = "Hello Agent!"
        '    LblIntMap.Text = "CREATE CONNECTION"
        '    TLblWell2.Enabled = False
        '    TLblWell3.Enabled = True
        'End If
        greating += 1
        If greating = 1 Then
            Label2.Text = "Hello Agent!"
        ElseIf greating = 3 Then
            Label2.Text = "Please enter your authority code :"
            '    My.Computer.Audio.Play(My.Resources.Please_Log_In, _
            'AudioPlayMode.Background)
            TextBox1.Visible = True
            TextBox1.Enabled = True
            TextBox1.Focus()
            LblAutoCMD.Text = "SENDING COMMAND"
            TmrTyping.Enabled = True
            'TmrCon1.Enabled = True
            '  start_analysis()
        ElseIf greating = 4 Then
            TLblWell2.Enabled = False
            Form2.ShowDialog()
        End If
    End Sub

    'binary animation session
    'just fake binary encrypting
    Dim num As Integer
    Dim thisString As String
    'randomize function
    Function RandomString(ByVal length As Integer) As String
        Dim strb As New System.Text.StringBuilder
        'Dim Chars() As String = {"A ", "B ", "C ", "D ", "E ", "F ", "G ", "H ", "I ", "j ", "K ", "L ", "M ", "N ", "O ", "P ", "Q ", "R ", "S ", "T ", "U ", "V ", "W ", "X ", "Y ", "Z ", "0 ", "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 "}
        Dim Chars() As String = {"0 ", "1 ", "2 "} 'make random number. number will be show 0 or 1.
        Dim UpperBound As Integer = UBound(Chars)
        For x As Integer = 1 To length
            strb.Append(Chars(Int(Rnd() * UpperBound)))
        Next
        Return strb.ToString
    End Function
    Function RandomStringa(ByVal length As Integer) As String
        Dim strb As New System.Text.StringBuilder
        'Dim Charsa() As String = {"A   ", "B   ", "C   ", "D   ", "E   ", "F   ", "G   ", "H   ", "I   ", "j   ", "K   ", "L   ", "M   ", "N   ", "O   ", "P   ", "Q   ", "R   ", "S   ", "T   ", "U   ", "V   ", "W   ", "X   ", "Y   ", "Z   ", "0   ", "1   ", "2   ", "3   ", "4   ", "5   ", "6   ", "7   ", "8   ", "9  "}
        Dim Charsa() As String = {"0 ", "1 ", "2 "} 'make random number. number will be show 0 or 1.
        Dim UpperBounda As Integer = UBound(Charsa)
        For x As Integer = 1 To length
            strb.Append(Charsa(Int(Rnd() * UpperBounda)))
        Next
        Return strb.ToString '.ToUpper
    End Function
    Function RandomStringb(ByVal length As Integer) As String
        Dim strb As New System.Text.StringBuilder
        Dim Charsb() As String = {"A ", "B ", "C", "D", "E", "F", "G", "H", "I", "j", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        'Dim Charsa() As String = {"0       ", "1       ", "2 "} 'make random number. number will be show 0 or 1.
        Dim UpperBounda As Integer = UBound(Charsb)
        For x As Integer = 1 To length
            strb.Append(Charsb(Int(Rnd() * UpperBounda)))
        Next
        Return strb.ToString.ToUpper
    End Function
    Function RandomStringc(ByVal length As Integer) As String
        Dim strb As New System.Text.StringBuilder
        Dim Charsc() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "j", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        'Dim Charsa() As String = {"0       ", "1       ", "2 "} 'make random number. number will be show 0 or 1.
        Dim UpperBounda As Integer = UBound(Charsc)
        For x As Integer = 1 To length
            strb.Append(Charsc(Int(Rnd() * UpperBounda)))
        Next
        Return strb.ToString.ToUpper
    End Function
    Private Sub TmrNumAni_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrNumAni.Tick
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim ee As Integer
        Dim f As Integer

        a = (826598123 * Rnd(9))
        b = a - 100
        c = (563563342 * Rnd(9))
        d = (757563457 * Rnd(9))
        ee = (234456634 * Rnd(9))
        f = (787654364 * Rnd(9))
        'Label3.Text = b + " " + c + " " + d + " " + ee + " " + f & vbCrLf & a
        Label3.Text = b & " " & f & vbCrLf & a
        Label4.Text = ee & " " & c & vbCrLf & a
        Label5.Text = b & " " & d & vbCrLf & a
        Label6.Text = f & " " & ee & vbCrLf & a
        Label7.Text = c & " " & f & vbCrLf & a
        Label8.Text = d & " " & b & vbCrLf & a
        'Label9.Text = ee & " " & f & vbCrLf & a
        rndstring = RandomString(neo)
        rndstrings = RandomString(noe)
        Label9.Text = rndstring & vbCrLf & rndstrings
        'TBBackground.Text = rndstring & vbCrLf & rndstrings
        'TextBox2.Text = rndstring & vbCrLf & rndstrings
    End Sub
    Private Sub TmrNumAni2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrNumAni2.Tick
        noe = noe - 1
        neo = neo - 1
        If Label9.Text = "" Then
            TmrNumAni2.Enabled = False
        End If
    End Sub
    Public Sub GBbin_clear()
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub
    Public Sub reset_num_bridge_connection()
        NC1.Visible = False
        NC2.Visible = False
        NC3.Visible = False
        NC4.Visible = False
        NC5.Visible = False
        NC6.Visible = False
        NC7.Visible = False
        NH1.Visible = False
        NH2.Visible = False
        NH3.Visible = False
    End Sub
    Private Sub TmrNumCon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrNumCon.Tick
        Module_animasi.num_animasi()
    End Sub
    Dim rr As Boolean = False
    Public tng As Integer = 0
    Private Sub TmrDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrDate.Tick
        LblDate.Text = "//Backdoor_force_login_mode//_{now}: " + Date.Now
        'blocking all the way to kiil this locker
        If Form2.Visible = True Then
            TopMost = True
            Form2.TopMost = True
        Else
            TopMost = True
        End If
        Me.Top = True
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "explorer" Then
                'selProcess.Kill()
                Exit For
            End If
        Next
        
        'RichTextBox3.Text = RandomStringa(10)



    End Sub
    Public cek As Boolean = False
    
    'auto type animation session
    Dim ff As String
    Dim gg As String
    Dim kata As String
    Dim tik As Integer = 0
    Dim tiki As Integer = 0
    Sub typing()

        tik += 1
        tiki += 1
        If tik > 2 Then tik = 0
        If tiki > 4 Then tiki = 0
        ' kata = My.Resources.Com
        If tik = 1 Then
            kata = My.Resources.Com
        ElseIf tik = 2 Then
            kata = My.Resources.java
        End If
        ' gg = My.Resources.asm_1
        If tiki = 1 Then
            gg = My.Resources.asm_1
        ElseIf tiki = 2 Then
            gg = My.Resources.asm_2
        ElseIf tiki = 3 Then
            gg = My.Resources.asm_3
        End If
        TextLog.Text = TextLog.Text + vbCrLf + "create assembly version: " + tik.ToString
        TextLog.ScrollToCaret()
        text2 = "" + kata
        LL = Len(text2)
        II = 1
        PP = 1
        TextLog.Text = TextLog.Text + vbCrLf + "create assembly version: " + tiki.ToString
        TextLog.ScrollToCaret()
        text3 = "" + gg
        XX = Len(text3)
        YY = 1
        ZZ = 1
        Label12.Text = Me.Width.ToString & " " & Me.Height.ToString
        'Label12.Text = LL.ToString
        'Label13.Text = tik.ToString

        'FileOpen(1, "janji/words.txt", OpenMode.Input)
        'FileOpen(1, My.Resources.kata, OpenMode.Input)
        

        Label12.Text = word
    End Sub
    Dim baca As String
    Public counter As Integer
    Public randoming2 As New Random()
    Public randoming As New Random()
    Dim rndm As Integer
    Sub break()
        FileOpen(1, My.Application.Info.DirectoryPath & "/dictionary.txt", OpenMode.Input)

        counter = 0
        Do While Not EOF(1)
            Input(1, word)
            counter = counter + 1
        Loop
        FileClose(1)
        ' FileOpen(1, My.Application.Info.DirectoryPath & "/dictionary.txt", OpenMode.Append)

        bac()
       
    End Sub
    Dim lineToRead As Short
    Public Sub bac()


        'Randomize()
        ' lineToRead = Int(Rnd() * counter)

        'lineToRead = Int(Rnd() * 100)

        lineToRead = (randoming.Next(0, 30000))
        ' If (1, My.Application.Info.DirectoryPath & "/dictionary.txt", OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
        FileOpen(1, My.Application.Info.DirectoryPath & "/dictionary.txt", OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
        'FileOpen(1, My.Resources.dictionary, OpenMode.Input)

        For Me.counter = 1 To lineToRead
            Input(1, word)

        Next counter
        FileClose(1)

        word = UCase(word)
    End Sub
    Public hitung As Integer = 0
    Public itung As Integer = 0
    Dim af As Integer
    Dim fa As Integer = 0
    Dim se As String
    Dim a, b, c, d, f, g, h, i, j, k, l, m As String
    Public o As Integer = 23
    Private Sub TmrBreak_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrBreak.Tick
        o += 1
        If o = 100 Then
            RichTextBox3.Clear()
            o = 23
            binary()
        End If
        RichTextBox3.Text = RandomStringa(10) & vbCrLf & RichTextBox3.Text
        If o > 22 Then
            RichTextBox3.Text = Replace(RichTextBox3.Text, RichTextBox3.Lines(23), "")
        End If

        'RichTextBox3.ScrollToCaret()
        'o = RichTextBox3.Lines(23)
        'RichTextBox3.Text
        If itung = 0 Then
            a = RandomStringc(1)
            b = RandomStringc(1)
            c = RandomStringc(1)
            d = RandomStringc(1)
            f = RandomStringc(1)
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
        End If
        If itung = 1 Then
            a = RandomStringc(1)
            b = RandomStringc(1)
            c = RandomStringc(1)
            d = RandomStringc(1)
            f = RandomStringc(1)
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
        End If
        If itung = 2 Then
            'a = a
            b = RandomStringc(1)
            c = RandomStringc(1)
            d = RandomStringc(1)
            f = RandomStringc(1)
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
        End If
        If itung = 3 Then
            'a = a
            'b = b
            c = RandomStringc(1)
            d = RandomStringc(1)
            f = RandomStringc(1)
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
        End If
        If itung = 4 Then
            'a = a
            'b = b
            'c = c
            d = RandomStringc(1)
            f = RandomStringc(1)
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
        End If
        If itung = 5 Then
            f = RandomStringc(1)
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
        End If
        If itung = 6 Then
            g = RandomStringc(1)
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
        End If
        If itung = 7 Then
            h = RandomStringc(1)
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label26.ForeColor = Color.White
        End If
        If itung = 8 Then
            i = RandomStringc(1)
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label26.ForeColor = Color.White
            Label27.ForeColor = Color.White
        End If
        If itung = 9 Then
            j = RandomStringc(1)
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label26.ForeColor = Color.White
            Label27.ForeColor = Color.White
            Label28.ForeColor = Color.White
        End If
        If itung = 10 Then
            k = RandomStringc(1)
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label26.ForeColor = Color.White
            Label27.ForeColor = Color.White
            Label28.ForeColor = Color.White
            Label29.ForeColor = Color.White
        End If
        If itung = 11 Then
            l = RandomStringc(1)
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label26.ForeColor = Color.White
            Label27.ForeColor = Color.White
            Label28.ForeColor = Color.White
            Label29.ForeColor = Color.White
            Label30.ForeColor = Color.White
        End If
        If itung = 12 Then
            m = RandomStringc(1)
            Label20.ForeColor = Color.White
            Label21.ForeColor = Color.White
            Label22.ForeColor = Color.White
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label26.ForeColor = Color.White
            Label27.ForeColor = Color.White
            Label28.ForeColor = Color.White
            Label29.ForeColor = Color.White
            Label30.ForeColor = Color.White
            Label31.ForeColor = Color.White
            cek = True
            mula = False
            itung = 12
            TmrBreak.Enabled = False
            TmrCPU2.Enabled = True
            Form2.TProgressB.Enabled = True
        End If
        'Label19.Text = RandomStringb(12)
        Label19.Text = a & b & c & d & f & g & h & i & j & k & l & m
        Label20.Text = a
        Label21.Text = b
        Label22.Text = c
        Label23.Text = d
        Label24.Text = f
        Label25.Text = g
        Label26.Text = h
        Label27.Text = i
        Label28.Text = j
        Label29.Text = k
        Label30.Text = l
        Label31.Text = m
        rndm = (randoming2.Next(0, 5))
        'rndmLabel19.Text = rndm.ToString
        If rndm = 1 Then
            'RichTextBox3.ForeColor = Color.Black
            Form2.Top = qq
        Else
            'RichTextBox3.ForeColor = Color.LimeGreen
            Form2.Top = ww
        End If
        hitung += 1
        If hitung < 36 Then
            If RichTextBox4.Text = "" Then
                RichTextBox4.Text = Label19.Text
            Else
                RichTextBox4.Text = RichTextBox4.Text & vbCrLf & Label19.Text
            End If
        End If


        hit = (randoming2.Next(1, 35))

        af = (randoming.Next(1, 35))
        fa += 1
        If fa = 1 Then
            se = "-"
        ElseIf fa = 2 Then
            se = "--"
        ElseIf fa = 3 Then
            se = "---"
        ElseIf fa = 4 Then
            se = "---- "
        ElseIf fa = 5 Then
            se = "-----"
        ElseIf fa = 6 Then
            se = "------"
            fa = 0
        End If
        If hitung > 35 Then

            ' RichTextBox4.GetLineFromCharIndex(2)
            hitung = 36
            'RichTextBox4.Clear()
            RichTextBox4.Text = Replace(RichTextBox4.Text, RichTextBox4.Lines(hit), Label19.Text, 1, 1)

            'If hit < 10 Then
            '    RichTextBox4.Text = Replace(RichTextBox4.Text, RichTextBox4.Lines(af), " ")
            'ElseIf hit < 5 Then
            '    RichTextBox4.Text = Label19.Text & vbCrLf & RichTextBox4.Text
            '    RichTextBox4.Text = Replace(RichTextBox4.Text, RichTextBox4.Lines(35), "", 1, 1)
            'End If
        End If
        'word = ""
        'Label19.Text = ""
        'bac()
        ' break()
    End Sub
    Private Sub TmrCPU2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrCPU2.Tick
        If mula = True Then
            itung += 1
        End If
        Label12.Text = mula.ToString
        If cek = True Then
            'Form2.ProBar1.PBText = "FOUND : " & Label19.Text.ToString
            'Form2.Label2.Text = "TRY SEND : " & Label19.Text.ToString
            If rr = False Then
                rr = True
                RichTextBox4.Text = Replace(RichTextBox4.Text, RichTextBox4.Lines(hit), " ", 1, 1)
            Else
                RichTextBox4.Text = Replace(RichTextBox4.Text, RichTextBox4.Lines(hit), Label19.Text)
                rr = False
            End If
        End If

      
        'If rr = True Then

        '    RichTextBox4.Text = Replace(RichTextBox4.Text, RichTextBox4.Lines(hit), Label19.Text)
        '    rr = False
        'End If

        'Label13.Text = rr.ToString
    End Sub
    Dim numb As Integer

    Private Sub TmrTyping_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrTyping.Tick
        'TBTyping.Text = TBTyping.Text + Mid(text2, II, 1)
        'Label20.Text = Label20.Text + Mid(text2, II, 1)
        numb += 1
        If numb = 700 Then
            RichTextBox1.Clear()
        ElseIf numb = 1200 Then
            RichTextBox2.Clear()
            numb = 0
        End If

        RichTextBox1.Text = RichTextBox1.Text + Mid(text2, II, 1)
        If II > LL Then
            II = 0
            'TBTyping.Text = ""

            '  Label20.Text = ""



            RichTextBox1.Clear()

            typing()
        End If
        II = II + 1
        RichTextBox1.ScrollToCaret()
        'TmrTyping2.Enabled = True


        'TBTyping.Text = TBTyping.Text + Mid(text2, II, 1)
        'Label10.Text = Label10.Text + Mid(text3, YY, 1)
        RichTextBox2.Text = RichTextBox2.Text + Mid(text3, YY, 1)
        If YY > XX Then
            YY = 0
            'TBTyping.Text = ""


            typing()
        ElseIf YY = 10 Then
            RichTextBox2.Clear()
        End If
        YY = YY + 1
        RichTextBox2.ScrollToCaret()
        ' RichTextBox2.Size = RichTextBox2.SelectionCharOffset.ToString

        'TmrTyping2.Enabled = True
        If Label10.Height > Panel1.Height Then
            Label10.Text = ""
        End If
        'If Label20.Height > Panel2.Height Then
        'Label20.Text = ""
        'End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub BtnEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEsc.Click
        System.Diagnostics.Process.Start("shutdown", "-l -t 0 ") 'if computer installed win XP
        System.Diagnostics.Process.Start("shutdown", "/l /f") 'if computer installed win 7
    End Sub
    Private Sub BtnShutDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShutDown.Click
        My.Computer.Audio.Play(My.Resources.Shutting_Down, _
          AudioPlayMode.Background)
        System.Diagnostics.Process.Start("shutdown", "-s -t 0")
    End Sub
    'connection line animatio session
    'because I am from Indonesia, this line connection look likes accessing from Jakarta :-)
    'start position of line

    'function to randomize line connection



    Private Sub BtnChanger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChanger.Click

        If TBcodeCh.Text = "" Then
            GBcodeCh.Dock = DockStyle.None
            BtnChanger.Text = "Cancel"
            GBcodeCh.Visible = False
            TCekTB.Enabled = True
            TmrGBcodeCh.Enabled = False
            My.Computer.Audio.Play(My.Resources.click_enter, _
      AudioPlayMode.Background)
        Else
            GBcodeCh.Dock = DockStyle.None
            BtnChanger.Text = "Save"
            My.Settings.password = TBcodeCh.Text
            My.Settings.Save()
            GBcodeCh.Visible = False
            TCekTB.Enabled = True
            TmrGBcodeCh.Enabled = False
            My.Computer.Audio.Play(My.Resources.click_enter, _
      AudioPlayMode.Background)
        End If
        Form2.ShowDialog()
        BtnEsc.Enabled = True
        BtnShutDown.Enabled = True
    End Sub

    Private Sub TmrGBcodeCh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrGBcodeCh.Tick
        'TBcodeCh.Focus()
        If TBcodeCh.Text = "" Then
            BtnChanger.Text = "Cancel"
        Else
            BtnChanger.Text = "Save"
        End If
        If CheckBox1.Checked = True Then
            TBcodeCh.PasswordChar = ""
        Else
            TBcodeCh.PasswordChar = "*"
        End If
    End Sub

    Private Sub TBcodeCh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBcodeCh.TextChanged
        My.Computer.Audio.Play(My.Resources.click, _
      AudioPlayMode.Background)
    End Sub
    'Dim cpuUsage As New PerformanceCounter("Memory", "Available MBytes")
    'Protected ramCounter As System.Diagnostics.PerformanceCounter
    ' ramCounter.i
    'Dim CPU As inter



    Dim t As String


    Private Sub BtnOFD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub BtnSFD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.ShowDialog()
    End Sub





 
End Class
