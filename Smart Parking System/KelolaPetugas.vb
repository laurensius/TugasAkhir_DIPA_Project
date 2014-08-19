Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Public Class KelolaPetugas
    Dim pilih As String
    Dim conn As MySqlConnection
    Dim connString As String
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim count As Integer
    Dim reader As MySqlDataReader = Nothing
    Private Sub KelolaPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMenu.Items.Add("insert")
        cmbMenu.Items.Add("update")
        cmbMenu.Items.Add("delete")
        cmbMenu.SelectedIndex = 0
        ButtonDisabled()
    End Sub
    Private Sub LoadId()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from admin"
        da = New MySqlDataAdapter(Sql, conn)
        ds = New DataSet
        da.Fill(ds, "admin")
        count = ds.Tables("admin").Rows.Count
        For i As Integer = 0 To count - 1
            cmbPetugas.Items.Add(ds.Tables("admin").Rows(i).Item("username"))
            cmbPetugas.SelectedIndex = 0
        Next
    End Sub
    Private Sub LoadData()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from admin where username = '" + cmbPetugas.Text + "'"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        reader = SqlCommand.ExecuteReader
        Try
            reader.Read()
            txtUsername.Text = reader.GetString(1)
            txtPassword.Text = reader.GetString(2)
            txtNama.Text = reader.GetString(3)
            txtAlamat.Text = reader.GetString(4)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub LoadGrid()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from admin"
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
    Private Sub ButtonDisabled()
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtNama.Enabled = False
        txtAlamat.Enabled = False
        cmbPetugas.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub TextClear()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
    End Sub


    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If cmbMenu.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = cmbMenu.SelectedIndex
            Dim sitem As Object
            sitem = cmbMenu.SelectedItem
            If sitem = "insert" Then
                txtUsername.Enabled = True
                txtPassword.Enabled = True
                txtNama.Enabled = True
                txtAlamat.Enabled = True
                btnUpdate.Enabled = False
                btnSimpan.Enabled = True
                btnHapus.Enabled = False
                cmbPetugas.Enabled = False
                TextClear()
            End If
            If sitem = "update" Then
                txtUsername.Enabled = True
                txtPassword.Enabled = True
                txtNama.Enabled = True
                txtAlamat.Enabled = True
                btnUpdate.Enabled = True
                btnSimpan.Enabled = False
                btnHapus.Enabled = False
                cmbPetugas.Enabled = True
                TextClear()
                LoadId()
            End If
            If sitem = "delete" Then
                txtUsername.Enabled = True
                txtPassword.Enabled = True
                txtNama.Enabled = True
                txtAlamat.Enabled = True
                btnUpdate.Enabled = False
                btnSimpan.Enabled = False
                btnHapus.Enabled = True
                cmbPetugas.Enabled = True
                TextClear()
                LoadId()
            End If
        End If
    End Sub

    Private Sub cmbPetugas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPetugas.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "insert into admin(username,password,nama_user,alamat,status_user) values(@user,@pass,@nama,@alamat,@status)"
        Dim sqlCommand As New MySqlCommand(sql, conn)
        Try
            With sqlCommand.Parameters
                .AddWithValue("@user", txtUsername.Text)
                .AddWithValue("@pass", txtPassword.Text)
                .AddWithValue("@nama", txtNama.Text)
                .AddWithValue("@alamat", txtAlamat.Text)
                .AddWithValue("status", 1)
            End With
            sqlCommand.ExecuteNonQuery()
            MsgBox("Data Tersimpan")
            TextClear()
            LoadGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "update admin set username=@user, password=@pass, nama_user=@nama, alamat=@alamat where username=@userid"
        Dim sqlCommand As New MySqlCommand(sql, conn)
        Try
            With sqlCommand.Parameters
                .AddWithValue("@userid", cmbPetugas.Text)
                .AddWithValue("@user", txtUsername.Text)
                .AddWithValue("@pass", txtPassword.Text)
                .AddWithValue("@nama", txtNama.Text)
                .AddWithValue("@alamat", txtAlamat.Text)
            End With
            sqlCommand.ExecuteNonQuery()
            MsgBox("Data Terupdate")
            TextClear()
            LoadGrid()
            ButtonDisabled()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "delete from admin where username = '" + cmbPetugas.Text + "'"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Try
            SqlCommand.ExecuteNonQuery()
            MsgBox("Data Terhapus")
            cmbPetugas.SelectedIndex = 0
            LoadGrid()
            ButtonDisabled()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class