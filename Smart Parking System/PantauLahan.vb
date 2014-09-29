Imports System.IO.Ports
Public Class PantauLahan
    Dim myPort As New SerialPort
    Public s1, s2, s3, s4, valNFC As String
    Dim sensor1, sensor2, sensor3, sensor4 As Integer
    Private Sub PantauLahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Public Sub init()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False

        Label11.Text = ""

        Button1.Enabled = True
        Button2.Enabled = False

        ComboBox1.Enabled = True
        ComboBox1.Items.Clear()
        Try
            For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
                ComboBox1.Items.Add(My.Computer.Ports.SerialPortNames(i))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ComboBox1.SelectedIndex = 0
    End Sub
    Public Sub bacaSerial()
        Dim data_serial As String
        Dim panjang_serial As Integer
        Dim char_data_serial() As Char
        Dim separator As String
        separator = "#"
        data_serial = myPort.ReadExisting
        char_data_serial = data_serial.ToCharArray
        panjang_serial = data_serial.Length

        Label11.Text = "Isi data : " & data_serial & " length : " & panjang_serial

        Dim ctr, current_ctr, ketemu As Integer
        Dim ping_1(50) As Char
        Dim ping_2(19) As Char
        Dim ping_3(19) As Char
        Dim ping_4(19) As Char
        Dim nfc(19) As Char
        ketemu = 0
        current_ctr = 0

        For ctr = 0 To panjang_serial - 1
            If (char_data_serial(ctr).ToString = separator) Then
                ketemu += 1
                current_ctr = 0
            Else
                If (ketemu = 0) Then
                    ping_1(current_ctr) = char_data_serial(ctr)
                    current_ctr += 1
                End If
                If (ketemu = 1) Then
                    ping_2(current_ctr) = char_data_serial(ctr)
                    current_ctr += 1
                End If
                If (ketemu = 2) Then
                    ping_3(current_ctr) = char_data_serial(ctr)
                    current_ctr += 1
                End If
                If (ketemu = 3) Then
                    ping_4(current_ctr) = char_data_serial(ctr)
                    current_ctr += 1
                End If
                If (ketemu = 4) Then
                    nfc(current_ctr) = char_data_serial(ctr)
                    current_ctr += 1
                End If
            End If
        Next
        s1 = ping_1
        s2 = ping_2
        s3 = ping_3
        s4 = ping_4
        valNFC = nfc
    End Sub

    Sub C_PantauLahan()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

        bacaSerial()

        TextBox1.Text = s1
        TextBox2.Text = s2
        TextBox3.Text = s3
        TextBox4.Text = s4
        TextBox5.Text = valNFC

        If (TextBox5.Text <> "" And TextBox5.Text.Length > 5) Then
            Dim data_kotor As String
            data_kotor = TextBox5.Text.Substring(3)
            TextBox6.Text = TextBox1.Text
            TextBox7.Text = TextBox2.Text
            TextBox8.Text = TextBox3.Text
            TextBox9.Text = TextBox4.Text
            TextBox10.Text = data_kotor.Substring(0, data_kotor.Length - 2)

        End If
    End Sub
    '-----END CONTROL PANTAU LAHAN-------
    Sub konversiSensor()
        sensor1 = Val(TextBox6.Text)
        sensor2 = Val(TextBox7.Text)
        sensor3 = Val(TextBox8.Text)
        sensor4 = Val(TextBox9.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        init()
        myPort.Close()
        Timer1.Stop()
    End Sub
    Public Sub bukaPort()
        Button1.Enabled = False
        Button2.Enabled = True

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True

        With myPort
            .PortName = ComboBox1.Text
            .BaudRate = 9600
            .DataBits = 8
            .StopBits = StopBits.One
            .DtrEnable = True
            .RtsEnable = True
            .ReceivedBytesThreshold = 1
            Timer1.Start()
        End With

        Try
            myPort.Open()
        Catch ex As Exception
            MessageBox.Show("Wrong", ex.Message)
        End Try

        ComboBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukaPort()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        C_PantauLahan()
        'lapangan()
    End Sub
End Class