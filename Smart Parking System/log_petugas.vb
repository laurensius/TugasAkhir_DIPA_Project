Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.IO
Public Class log_petugas
    Dim conn As MySqlConnection
    Dim connString As String
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim count, count_grid As Integer
    Private Sub log_petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadId()
    End Sub
    '------START CONTROL LOG PETUGAS--------
    Sub LoadId()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select username from admin where status_user=1"
        da = New MySqlDataAdapter(Sql, conn)
        ds = New DataSet
        da.Fill(ds, "admin")
        count = ds.Tables("admin").Rows.Count
        For i As Integer = 0 To count - 1
            ComboBox1.Items.Add(ds.Tables("admin").Rows(i).Item(0))
            ComboBox1.SelectedIndex = 0
        Next
    End Sub
    Private Sub C_LogPetugas()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select tanggal_masuk,tanggal_keluar from log_admin where username = '" + ComboBox1.Text + "'"
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
    '-----END CONTROL LOG PETUGAS-------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C_LogPetugas()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class