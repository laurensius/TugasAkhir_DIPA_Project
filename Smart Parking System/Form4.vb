Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.IO.Ports

Public Class Form4
    Dim myPort As New SerialPort
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand = Nothing
    Dim connString As String
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim count As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Sub loadData()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from anggota where status_kartu=0"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "anggota")
        count = ds.Tables("anggota").Rows.Count
        For i As Integer = 0 To count - 1
            ComboId.Items.Add(ds.Tables("anggota").Rows(i).Item("id_card"))
            ComboId.SelectedIndex = 0
        Next
    End Sub
    Sub buka()
        Button3.Enabled = True
        ComboId.Enabled = True
        C_Generate.Enabled = True
        Button2.Enabled = False
        With myPort
            .PortName = ComboBox1.Text
            .BaudRate = 9600
            .DataBits = 8
            .StopBits = StopBits.One
            .DtrEnable = True
            .RtsEnable = True
            .ReceivedBytesThreshold = 1
        End With

        Try
            myPort.Open()
            MsgBox("Port Opened")
        Catch ex As Exception
            MessageBox.Show("Wrong", ex.Message)
        End Try
    End Sub
    Sub init()
        buttonDisable()
        Timer1.Stop()
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
    Sub buttonDisable()
        ComboId.Enabled = False
        C_Generate.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = True
        ComboId.Items.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buka()
        loadData()
        Timer1.Start()
    End Sub
    '-----START CONTROL GENERATE------
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    '-----END CONTROL GENERATE--------

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        buttonDisable()
        myPort.Close()
    End Sub

    Private Sub updateStatus()
        Dim sqlupd As String
        Dim val As Integer
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        Val = "1"
        sqlupd = "update anggota set status_kartu = '" & val & "'  where id_card = '" + ComboId.Text + "'"
        cmd = New MySqlCommand(sqlupd, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub C_Generate_Click(sender As Object, e As EventArgs) Handles C_Generate.Click
        Dim dataToWrite, param As String
        Dim paramInt As Integer
        param = myPort.ReadExisting
        paramInt = Val(param)
        dataToWrite = ComboId.Text
        myPort.Write(dataToWrite)
        If paramInt = 1 Then
            MsgBox("input berhasil")
            updateStatus()
            init()
            myPort.Close()
            ComboId.Items.Clear()
        ElseIf paramInt = 0 Then
            MsgBox("Input Gagal")
        Else
            MsgBox("Input Gagal")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
    End Sub
End Class