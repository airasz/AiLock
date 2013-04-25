Module Module_animasi
    Public Sub num_animasi()
        Dim hitung As Integer
        hitung = (9 * Rnd(9))
        Form1.Label14.Text = "BRIDGE MODE: " & hitung
        If hitung = 0 Then
            Form1.NC1.Visible = True
            Form1.NC2.Visible = False
            Form1.NC3.Visible = False
            Form1.NC4.Visible = True
            Form1.NC5.Visible = True
            Form1.NC6.Visible = True
            Form1.NC7.Visible = False
            Form1.NH1.Visible = False
            Form1.NH2.Visible = False
            Form1.NH3.Visible = False
            Form1.Label3.Visible = True
            Form1.Label4.Visible = False
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = False
        End If
        If hitung = 1 Then
            Form1.NC1.Visible = False
            Form1.NC2.Visible = True
            Form1.NC3.Visible = True
            Form1.NC4.Visible = True
            Form1.NC5.Visible = True
            Form1.NC6.Visible = True
            Form1.NC7.Visible = True
            Form1.NH1.Visible = False
            Form1.NH2.Visible = False
            Form1.NH3.Visible = False
            Form1.Label3.Visible = False
            Form1.Label4.Visible = True
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = True
        End If

        If hitung = 2 Then
            Form1.NC1.Visible = True
            Form1.NC2.Visible = False
            Form1.NC3.Visible = True
            Form1.NC4.Visible = False
            Form1.NC5.Visible = True
            Form1.NC6.Visible = False
            Form1.NC7.Visible = True
            Form1.NH1.Visible = False
            Form1.NH2.Visible = False
            Form1.NH3.Visible = True
            Form1.Label3.Visible = True
            Form1.Label4.Visible = True
            Form1.Label5.Visible = False
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = True
        End If
        If hitung = 3 Then
            Form1.NC1.Visible = False
            Form1.NC2.Visible = True
            Form1.NC3.Visible = False
            Form1.NC4.Visible = True
            Form1.NC5.Visible = True
            Form1.NC6.Visible = True
            Form1.NC7.Visible = False
            Form1.NH1.Visible = False
            Form1.NH2.Visible = True
            Form1.NH3.Visible = True
            Form1.Label3.Visible = False
            Form1.Label4.Visible = True
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = False
        End If
        If hitung = 4 Then
            Form1.NC1.Visible = True
            Form1.NC2.Visible = False
            Form1.NC3.Visible = True
            Form1.NC4.Visible = False
            Form1.NC5.Visible = False
            Form1.NC6.Visible = True
            Form1.NC7.Visible = True
            Form1.NH1.Visible = True
            Form1.NH2.Visible = False
            Form1.NH3.Visible = True
            Form1.Label3.Visible = True
            Form1.Label4.Visible = True
            Form1.Label5.Visible = False
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = True
        End If
        If hitung = 5 Then
            Form1.NC1.Visible = True
            Form1.NC2.Visible = True
            Form1.NC3.Visible = False
            Form1.NC4.Visible = False
            Form1.NC5.Visible = True
            Form1.NC6.Visible = False
            Form1.NC7.Visible = False
            Form1.NH1.Visible = False
            Form1.NH2.Visible = True
            Form1.NH3.Visible = False
            Form1.Label3.Visible = True
            Form1.Label4.Visible = True
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = False
            Form1.Label8.Visible = False
        End If
        If hitung = 6 Then
            Form1.NC1.Visible = True
            Form1.NC2.Visible = False
            Form1.NC3.Visible = True
            Form1.NC4.Visible = False
            Form1.NC5.Visible = False
            Form1.NC6.Visible = True
            Form1.NC7.Visible = False
            Form1.NH1.Visible = True
            Form1.NH2.Visible = False
            Form1.NH3.Visible = True
            Form1.Label3.Visible = True
            Form1.Label4.Visible = True
            Form1.Label5.Visible = False
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = False
        End If
        If hitung = 7 Then
            Form1.NC1.Visible = False
            Form1.NC2.Visible = True
            Form1.NC3.Visible = False
            Form1.NC4.Visible = True
            Form1.NC5.Visible = False
            Form1.NC6.Visible = True
            Form1.NC7.Visible = True
            Form1.NH1.Visible = True
            Form1.NH2.Visible = False
            Form1.NH3.Visible = True
            Form1.Label3.Visible = True
            Form1.Label4.Visible = True
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = True
        End If
        If hitung = 8 Then
            Form1.NC1.Visible = False
            Form1.NC2.Visible = True
            Form1.NC3.Visible = True
            Form1.NC4.Visible = False
            Form1.NC5.Visible = True
            Form1.NC6.Visible = False
            Form1.NC7.Visible = False
            Form1.NH1.Visible = False
            Form1.NH2.Visible = True
            Form1.NH3.Visible = False
            Form1.Label3.Visible = False
            Form1.Label4.Visible = True
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = False
        End If
        If hitung = 9 Then
            Form1.NC1.Visible = True
            Form1.NC2.Visible = True
            Form1.NC3.Visible = True
            Form1.NC4.Visible = False
            Form1.NC5.Visible = True
            Form1.NC6.Visible = True
            Form1.NC7.Visible = True
            Form1.NH1.Visible = False
            Form1.NH2.Visible = True
            Form1.NH3.Visible = False
            Form1.Label3.Visible = True
            Form1.Label4.Visible = True
            Form1.Label5.Visible = True
            Form1.Label6.Visible = True
            Form1.Label7.Visible = True
            Form1.Label8.Visible = True
        End If
    End Sub
    Public Sub reset_break()
        Form1.RichTextBox4.Clear()
        With Form1
            .Label20.ForeColor = Color.Lime
            .Label21.ForeColor = Color.Lime
            .Label22.ForeColor = Color.Lime
            .Label23.ForeColor = Color.Lime
            .Label24.ForeColor = Color.Lime
            .Label25.ForeColor = Color.Lime
            .Label26.ForeColor = Color.Lime
            .Label27.ForeColor = Color.Lime
            .Label28.ForeColor = Color.Lime
            .Label29.ForeColor = Color.Lime
            .Label30.ForeColor = Color.Lime
            .Label31.ForeColor = Color.Lime
        End With
    End Sub

   
End Module
