Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.IO
Public Class LogKendaraan
    Dim conn As MySqlConnection
    Dim connString As String
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim count, count_grid As Integer
    Private Sub LogKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadId()
    End Sub
    Sub LoadId()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select anggota.id_card,tamu.id_tamu from anggota inner join tamu on anggota.status_kartu = 1 and tamu.status_kartu=1"
        da = New MySqlDataAdapter(Sql, conn)
        ds = New DataSet
        da.Fill(ds, "anggota")
        count = ds.Tables("anggota").Rows.Count
        For i As Integer = 0 To count - 1
            ComboBox1.Items.Add(ds.Tables("anggota").Rows(i).Item(0))
            ComboBox1.Items.Add(ds.Tables("anggota").Rows(i).Item(1))
            ComboBox1.SelectedIndex = 0
        Next
    End Sub
    Private Sub loadGrid()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select waktu_masuk,waktu_keluar from log_kendaraan where id_kartu = '" + ComboBox1.Text + "'"
        Dim dt As New DataTable
        Dim da = New MySqlDataAdapter(sql, conn)
        Try
            DataGridView1.DataMember = Nothing
            DataGridView1.DataSource = Nothing
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadGrid()
    End Sub
End Class