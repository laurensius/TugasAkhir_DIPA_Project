Imports System.IO.Ports
Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim myPort As New SerialPort
    Public s1, s2, s3, s4, valNFC As String
    Public jam_tamu_masuk, jam_tamu_keluar As Integer
    Public kend_masuk, kend_keluar As System.DateTime
    Dim sensor1, sensor2, sensor3, sensor4 As Integer
    Public conn As New MySqlConnection
    Public conn_string As String
    Dim cmd As MySqlCommand = Nothing
    Dim reader As MySqlDataReader = Nothing
    Dim reader2 As MySqlDataReader = Nothing
    Dim kartu_anggota, kartu_tamu As String
    Dim f3 As Form3 = CType(Application.OpenForms("Form3"), Form3)
    Dim fpet As Petugas = CType(Application.OpenForms("Petugas"), Petugas)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        Me.MdiParent = MDIParent1
        conn_string = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn.ConnectionString = conn_string
        conn.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukaPort()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        init()
        myPort.Close()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        C_PantauLahan()
        lapangan()

        If TextBox10.Text <> "" Then
            displayFoto()
            verifikasiKartu()
        End If
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
    '-----START CONTROL PANTAU LAHAN-----
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
    '------START CONTROL ENTRY KENDARAAN & VERIFIKASI KELUAR--------
    Sub verifikasiKartu()
        bacaSerial()
        Dim da, da_kend, da_tamu As MySqlDataAdapter
        Dim ds, ds_kend, ds_tamu As DataSet
        Dim query As String
        Dim query_status As String
        Dim query_tamu As String
        Dim status_kend, status_tamu As String
        Dim count, count_tamu As Integer
        'Dim id_card As String
        query = "select id_card from anggota where id_card = '" + TextBox10.Text + "'"
        query_status = "select status from kendaraan where id_card = '" + TextBox10.Text + "'"
        query_tamu = "select id_tamu,status_kendaraan from tamu where id_tamu = '" + TextBox10.Text + "' "
        da = New MySqlDataAdapter(query, conn)
        ds = New DataSet
        da_kend = New MySqlDataAdapter(query_status, conn)
        ds_kend = New DataSet
        da_tamu = New MySqlDataAdapter(query_tamu, conn)
        ds_tamu = New DataSet
        da.Fill(ds, "anggota")
        da_kend.Fill(ds_kend, "kendaraan")
        da_tamu.Fill(ds_tamu, "tamu")
        count_tamu = ds_tamu.Tables("tamu").Rows.Count
        count = ds.Tables("anggota").Rows.Count
        If ds_kend.Tables("kendaraan").Rows.Count > 0 Then
            status_kend = ds_kend.Tables("kendaraan").Rows(0).Item(0)
            kartu_anggota = ds.Tables("anggota").Rows(0).Item(0)
            If count > 0 And status_kend = "0" Then
                Label12.Text = "Informasi : Data match!"
                myPort.Write(0)
                update_status1()
                kend_masuk = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                f3.Label2.Text = "Penghuni"
            ElseIf count = 0 Then
                Label12.Text = "Informasi : Data not match!"
            End If
            If count > 0 And status_kend = "1" Then
                Label12.Text = "Informasi : Data match!"
                myPort.Write(2)
                update_status0()
                insertLogPenghuni()
                fpet.Label5.Text = "Pnghuni"
            ElseIf count = 0 Then
                Label12.Text = "Informasi : Data not match!"
            End If
        ElseIf count_tamu > 0 Then
            status_tamu = ds_tamu.Tables("tamu").Rows(0).Item(1)
            kartu_tamu = ds_tamu.Tables("tamu").Rows(0).Item(0)
            If count_tamu > 0 And status_tamu = "0" Then
                Label12.Text = "Informasi : Data match!"
                myPort.Write(0)
                update_status_tamu1()
                jam_tamu_masuk = DateTime.Now.Hour
                kend_masuk = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                f3.Label2.Text = "Tamu"
            ElseIf count_tamu = 0 Then
                Label12.Text = "Informasi : Data not match!"
            End If
            If count_tamu > 0 And status_tamu = "1" Then
                Label12.Text = "Informasi : Data match!"
                myPort.Write(2)
                update_status_tamu0()
                jam_tamu_keluar = DateTime.Now.Hour
                updateJam()
                hitungBiaya()
                insertLogTamu()
                fpet.Label5.Text = "Tamu"
            ElseIf count_tamu = 0 Then
                Label12.Text = "Informasi : Data not match!"
            End If
        End If   
    End Sub
    '------END CONTROL ENTRY KENDARAAN & VERIFIKASI KELUAR--------
    Private Sub update_status1()
        Dim val As String
        Dim sqlupd As String
        val = "1"
        sqlupd = "update kendaraan set status = '" & val & "'  where id_card = '" + TextBox10.Text + "'"
        cmd = New MySqlCommand(sqlupd, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub update_status0()
        Dim val As String
        Dim sqlupd As String
        val = "0"
        sqlupd = "update kendaraan set status = '" & val & "'  where id_card = '" + TextBox10.Text + "'"
        cmd = New MySqlCommand(sqlupd, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub update_status_tamu0()
        Dim val As String
        Dim sqlupd As String
        val = "0"
        sqlupd = "update tamu set status_kendaraan = '" & val & "'  where id_tamu = '" + TextBox10.Text + "'"
        cmd = New MySqlCommand(sqlupd, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub update_status_tamu1()
        Dim val As String
        Dim sqlupd As String
        val = "1"
        sqlupd = "update tamu set status_kendaraan = '" & val & "'  where id_tamu = '" + TextBox10.Text + "'"
        cmd = New MySqlCommand(sqlupd, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub lapangan()
        bacaSerial()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim query As String
        Dim sensorDefault As Integer
        konversiSensor()
        query = "select jarak from sensor_lot"
        da = New MySqlDataAdapter(query, conn)
        ds = New DataSet
        da.Fill(ds, "sensor_lot")
        sensorDefault = ds.Tables("sensor_lot").Rows(0).Item(0)
        Try
            'f3.Label1.Text = sensorDefault
            If sensor1 >= sensorDefault And sensor1 < 22 Then
                f3.LabelA1.Text = "Tersedia"
                f3.LabelA1.ForeColor = Color.Green
            ElseIf sensor1 < sensorDefault And sensor1 > 0 Then
                f3.LabelA1.Text = "Tidak Tersedia"
                f3.LabelA1.ForeColor = Color.Red

            ElseIf (sensor1 = 0 And f3.LabelA1.Text = "Tersedia") Then
                f3.LabelA1.Text = "Tersedia"
                f3.LabelA1.ForeColor = Color.Green
            ElseIf (sensor1 = 0 And f3.LabelA1.Text = "Tidak Tersedia") Then
                f3.LabelA1.Text = "Tidak Tersedia"
                f3.LabelA1.ForeColor = Color.Red
            End If

            If sensor2 >= sensorDefault And sensor2 < 22 Then
                f3.LabelA2.Text = "Tersedia"
                f3.LabelA2.ForeColor = Color.Green
            ElseIf sensor2 < sensorDefault And sensor2 > 0 Then
                f3.LabelA2.Text = "Tidak Tersedia"
                f3.LabelA2.ForeColor = Color.Red
            ElseIf (sensor2 = 0 And f3.LabelA2.Text = "Tersedia") Then
                f3.LabelA2.Text = "Tersedia"
                f3.LabelA2.ForeColor = Color.Green
            ElseIf (sensor2 = 0 And f3.LabelA2.Text = "Tidak Tersedia") Then
                f3.LabelA2.Text = "Tidak Tersedia"
                f3.LabelA2.ForeColor = Color.Red
            End If

            If sensor3 >= sensorDefault And sensor3 < 22 Then
                f3.LabelA3.Text = "Tersedia"
                f3.LabelA3.ForeColor = Color.Green
            ElseIf sensor3 < sensorDefault And sensor3 > 0 Then
                f3.LabelA3.Text = "Tidak Tersedia"
                f3.LabelA3.ForeColor = Color.Red
            ElseIf (sensor3 = 0 And f3.LabelA3.Text = "Tersedia") Then
                f3.LabelA3.Text = "Tersedia"
                f3.LabelA3.ForeColor = Color.Green
            ElseIf (sensor3 = 0 And f3.LabelA3.Text = "Tidak Tersedia") Then
                f3.LabelA3.Text = "Tidak Tersedia"
                f3.LabelA3.ForeColor = Color.Red
            End If

            If sensor4 >= sensorDefault And sensor4 < 22 Then
                f3.LabelA4.Text = "Tersedia"
                f3.LabelA4.ForeColor = Color.Green
            ElseIf sensor4 < sensorDefault And sensor4 > 0 Then
                f3.LabelA4.Text = "Tidak Tersedia"
                f3.LabelA4.ForeColor = Color.Red
            ElseIf (sensor4 = 0 And f3.LabelA4.Text = "Tersedia") Then
                f3.LabelA4.Text = "Tersedia"
                f3.LabelA4.ForeColor = Color.Green
            ElseIf (sensor4 = 0 And f3.LabelA4.Text = "Tidak Tersedia") Then
                f3.LabelA4.Text = "Tidak Tersedia"
                f3.LabelA4.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox("Harap Buka Form Display Terlebih Dahulu !")
            init()
            myPort.Close()
            Timer1.Stop()
            Me.Close()
        End Try 
    End Sub
    Sub displayFoto()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim query As String
        'Dim count As Integer
        Dim foto1 As Byte()
        Dim foto2 As Byte()
        Dim foto3 As Byte()
        query = "select anggota.foto1,anggota.foto2,anggota.foto3 from anggota inner join kendaraan on anggota.id_card = '" + TextBox10.Text + "' and kendaraan.status = 1 "
        da = New MySqlDataAdapter(query, conn)
        ds = New DataSet
        da.Fill(ds, "anggota")
        If ds.Tables("anggota").Rows.Count > 0 Then
            foto1 = ds.Tables("anggota").Rows(0).Item(0)
            foto2 = ds.Tables("anggota").Rows(0).Item(1)
            foto3 = ds.Tables("anggota").Rows(0).Item(2)
            fpet.pictureFoto1.Image = Image.FromStream(New IO.MemoryStream(foto1))
            fpet.pictureFoto2.Image = Image.FromStream(New IO.MemoryStream(foto2))
            fpet.pictureFoto3.Image = Image.FromStream(New IO.MemoryStream(foto3))
        End If
    End Sub
    Private Sub updateJam()
        Dim sqlupd As String
        sqlupd = "update tamu set jam_masuk = '" & jam_tamu_masuk & "', jam_keluar = '" & jam_tamu_keluar & "'   where id_tamu = '" + TextBox10.Text + "'"
        cmd = New MySqlCommand(sqlupd, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub hitungBiaya()
        Dim query As String
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim masuk, keluar, jumlah, jumlah2 As Integer
        query = "select jam_masuk,jam_keluar from tamu where id_tamu = '" + TextBox10.Text + "'"
        da = New MySqlDataAdapter(query, conn)
        ds = New DataSet
        da.Fill(ds, "tamu")
        masuk = ds.Tables("tamu").Rows(0).Item(0)
        keluar = ds.Tables("tamu").Rows(0).Item(1)
        jumlah = (keluar - masuk)
        If jumlah = 0 Then
            fpet.Label7.Text = "1000"
        Else
            jumlah2 = jumlah * 1000
            fpet.Label7.Text = jumlah2.ToString
        End If
    End Sub
    Private Sub insertLogPenghuni()
        Dim sql As String
        sql = "insert into log_kendaraan (id_kartu,waktu_masuk,waktu_keluar) values(@id,@masuk,now())"
        Dim SqlCommand As New MySqlCommand(Sql, conn)
        Try
            With SqlCommand.Parameters
                .AddWithValue("@id", Me.kartu_anggota)
                .AddWithValue("@masuk", Me.kend_masuk)
            End With
            SqlCommand.ExecuteNonQuery()
            Me.kend_masuk = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub insertLogTamu()
        Dim sql As String
        sql = "insert into log_kendaraan (id_kartu,waktu_masuk,waktu_keluar) values(@id,@masuk,now())"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Try
            With SqlCommand.Parameters
                .AddWithValue("@id", Me.kartu_tamu)
                .AddWithValue("@masuk", Me.kend_masuk)
            End With
            SqlCommand.ExecuteNonQuery()
            Me.kend_masuk = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class