Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.IO
Public Class Form2
    Dim pilih As String
    Dim conn As MySqlConnection
    Dim connString As String
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim count As Integer
    Dim reader As MySqlDataReader = Nothing

    Dim new_id As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("insert")
        ComboBox1.Items.Add("update")
        ComboBox1.Items.Add("delete")
        ComboBox1.SelectedIndex = 0
        ButtonDisabled()
        'LoadGrid()
        'LoadId()
    End Sub



    Public Sub BtnPilih_Click(sender As Object, e As EventArgs) Handles BtnPilih.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = ComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = ComboBox1.SelectedItem
            If sitem = "insert" Then
                ComboId.Enabled = False
                TxtId.Enabled = True
                TxtKartu.Enabled = False
                TxtNama.Enabled = True
                TxtPekerjaan.Enabled = True
                TxtUmur.Enabled = True
                TxtAlamat.Enabled = True
                TxtNoKend.Enabled = True
                TxtJenis.Enabled = True
                TxtMerk.Enabled = True
                btnPilih1.Enabled = True
                btnPilih2.Enabled = True
                btnPilih3.Enabled = True
                BtnSimpan.Enabled = True
                BtnUpdate.Enabled = False
                BtnHapus.Enabled = False
                TextClear()
                LoadGrid()
                id_generate()
                Dim folder As String = "D:\Latihan\VB.Net\Smart Parking System\Smart Parking System\img"
                Dim filename As String = System.IO.Path.Combine(folder, "user_icon.jpg")
                pictureFoto1.Image = Image.FromFile(filename)
                pictureFoto2.Image = Image.FromFile(filename)
                pictureFoto3.Image = Image.FromFile(filename)
            End If
            If sitem = "update" Then
                ComboId.Items.Clear()
                LoadId()
                ComboId.Enabled = True
                TxtId.Enabled = True
                TxtKartu.Enabled = True
                TxtNama.Enabled = True
                TxtPekerjaan.Enabled = True
                TxtUmur.Enabled = True
                TxtAlamat.Enabled = True
                TxtNoKend.Enabled = True
                TxtJenis.Enabled = True
                TxtMerk.Enabled = True
                btnPilih1.Enabled = True
                btnPilih2.Enabled = True
                btnPilih3.Enabled = True
                BtnUpdate.Enabled = True
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = False
                LoadGrid()
                Dim folder As String = "D:\Latihan\VB.Net\Smart Parking System\Smart Parking System\img"
                Dim filename As String = System.IO.Path.Combine(folder, "user_icon.jpg")
                pictureFoto1.Image = Image.FromFile(filename)
                pictureFoto2.Image = Image.FromFile(filename)
                pictureFoto3.Image = Image.FromFile(filename)
            End If
            If sitem = "delete" Then
                ComboId.Items.Clear()
                LoadId()
                ComboId.Enabled = True
                TxtId.Enabled = True
                TxtKartu.Enabled = True
                TxtNama.Enabled = True
                TxtPekerjaan.Enabled = True
                TxtUmur.Enabled = True
                TxtAlamat.Enabled = True
                TxtNoKend.Enabled = True
                TxtJenis.Enabled = True
                TxtMerk.Enabled = True
                BtnHapus.Enabled = True
                BtnSimpan.Enabled = False
                BtnUpdate.Enabled = False
                LoadGrid()
                Dim folder As String = "D:\Latihan\VB.Net\Smart Parking System\Smart Parking System\img"
                Dim filename As String = System.IO.Path.Combine(folder, "user_icon.jpg")
                pictureFoto1.Image = Image.FromFile(filename)
                pictureFoto2.Image = Image.FromFile(filename)
                pictureFoto3.Image = Image.FromFile(filename)
            End If
        End If
        Me.Refresh()
    End Sub

    Private Sub ButtonDisabled()
        ComboId.Enabled = False
        TxtId.Enabled = False
        TxtKartu.Enabled = False
        TxtNama.Enabled = False
        TxtPekerjaan.Enabled = False
        TxtUmur.Enabled = False
        TxtAlamat.Enabled = False
        TxtNoKend.Enabled = False
        TxtJenis.Enabled = False
        TxtMerk.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
        BtnUpdate.Enabled = False
        btnPilih1.Enabled = False
        btnPilih2.Enabled = False
        btnPilih3.Enabled = False
        Dim folder As String = "D:\Latihan\VB.Net\Smart Parking System\Smart Parking System\img"
        Dim filename As String = System.IO.Path.Combine(folder, "user_icon.jpg")
        pictureFoto1.Image = Image.FromFile(filename)
        pictureFoto2.Image = Image.FromFile(filename)
        pictureFoto3.Image = Image.FromFile(filename)
    End Sub

    Private Sub TextClear()
        TxtId.Text = ""
        TxtKartu.Text = ""
        TxtNama.Text = ""
        TxtPekerjaan.Text = ""
        TxtUmur.Text = ""
        TxtAlamat.Text = ""
        TxtNoKend.Text = ""
        TxtJenis.Text = ""
        TxtMerk.Text = ""
    End Sub

    Private Sub LoadData()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from anggota inner join kendaraan on anggota.id_card = '" & ComboId.Text & "' and kendaraan.id_card = '" & ComboId.Text & "'"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Dim foto1 As Byte()
        Dim foto2 As Byte()
        Dim foto3 As Byte()
        reader = SqlCommand.ExecuteReader
        Using table As New DataTable
            Try
                table.Load(reader)
                If table.Rows.Count <> 1 Then
                    MsgBox("error")
                Else
                    'reader.Read()
                    Dim row As DataRow = table.Rows(0)
                    TxtKartu.Text = row(0)
                    TxtId.Text = row(1)
                    TxtNama.Text = row(2)
                    TxtAlamat.Text = row(3)
                    TxtUmur.Text = row(4)
                    TxtPekerjaan.Text = row(5)
                    foto1 = row(6)
                    foto2 = row(7)
                    foto3 = row(8)
                    TxtNoKend.Text = row(10)
                    TxtJenis.Text = row(12)
                    TxtMerk.Text = row(13)
                    pictureFoto1.Image = Image.FromStream(New IO.MemoryStream(foto1))
                    pictureFoto2.Image = Image.FromStream(New IO.MemoryStream(foto2))
                    pictureFoto3.Image = Image.FromStream(New IO.MemoryStream(foto3))
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End Using
       
    End Sub

    Private Sub LoadGrid()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select anggota.id_card,anggota.no_identitas,anggota.nama,anggota.alamat_hunian,anggota.umur,anggota.pekerjaan,kendaraan.no_mobil,kendaraan.jenis_mobil,kendaraan.merk_mobil from anggota inner join kendaraan on anggota.id_card = kendaraan.id_card"
        Dim dt As New DataTable
        Dim da = New MySqlDataAdapter(sql, conn)
        Try
            dg1.DataMember = Nothing
            dg1.DataSource = Nothing
            dt.Clear()
            da.Fill(dt)
            dg1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnId_Click(sender As Object, e As EventArgs)
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from anggota"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "anggota")
        count = ds.Tables("anggota").Rows.Count
        If ComboId.SelectedIndex > -1 Then
            Dim tindex As Integer
            tindex = ComboId.SelectedIndex
            Dim item As Object
            item = ComboId.SelectedItem
            Try
                TxtKartu.Text = Convert.ToString(ds.Tables("anggota").Rows(tindex).Item("id_card"))
                TxtNama.Text = ds.Tables("anggota").Rows(tindex).Item("nama")
                TxtPekerjaan.Text = ds.Tables("anggota").Rows(tindex).Item("pekerjaan")
                TxtUmur.Text = ds.Tables("anggota").Rows(tindex).Item("umur")
                TxtAlamat.Text = ds.Tables("anggota").Rows(tindex).Item("alamat_hunian")
                TxtId.Text = ds.Tables("anggota").Rows(tindex).Item("no_identitas")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        conn.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "insert into anggota (id_card,no_identitas,nama,umur,pekerjaan,alamat_hunian,foto1,foto2,foto3) values(@idcard,@noid,@nama,@umur,@pekerjaan,@alamat,@foto1,@foto2,@foto3);"
        sql &= "insert into kendaraan (no_mobil,id_card,jenis_mobil,merk_mobil,status) values(@nobil,@idcard,@jenis,@merk,@status)"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Dim ms As MemoryStream = New MemoryStream
        Dim ms2 As MemoryStream = New MemoryStream
        Dim ms3 As MemoryStream = New MemoryStream
        pictureFoto1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        pictureFoto2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
        pictureFoto3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg)
        ms.ToArray()
        ms2.ToArray()
        ms3.ToArray()
        If TxtAlamat.Text = "" Or TxtId.Text = "" Or TxtJenis.Text = "" Or TxtKartu.Text = "" Or TxtMerk.Text = "" Or TxtNama.Text = "" Or TxtNoKend.Text = "" Or TxtPekerjaan.Text = "" Or TxtUmur.Text = "" Then
            MsgBox("Harap Isi Semua Form")
        Else
            Try
                With SqlCommand.Parameters
                    .AddWithValue("@idcard", TxtKartu.Text)
                    .AddWithValue("@noid", TxtId.Text)
                    .AddWithValue("@nama", TxtNama.Text)
                    .AddWithValue("@umur", TxtUmur.Text)
                    .AddWithValue("@alamat", TxtAlamat.Text)
                    .AddWithValue("@pekerjaan", TxtPekerjaan.Text)
                    .AddWithValue("@nobil", TxtNoKend.Text)
                    .AddWithValue("@jenis", TxtJenis.Text)
                    .AddWithValue("@merk", TxtMerk.Text)
                    .AddWithValue("@foto1", ms.ToArray)
                    .AddWithValue("@foto2", ms2.ToArray)
                    .AddWithValue("@foto3", ms3.ToArray)
                    .AddWithValue("@status", 0)
                End With
                SqlCommand.ExecuteNonQuery()
                MsgBox("Data Tersimpan")
                TextClear()
                LoadGrid()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "update anggota set id_card = @idcard, no_identitas = @noid, nama = @nama, umur = @umur, pekerjaan = @pekerjaan, alamat_hunian = @alamat, foto1 = @foto1, foto2 = @foto2, foto3 = @foto3 where id_card = @id"
        sql &= ";"
        sql &= "update kendaraan set no_mobil = @nobil, id_card = @idcard, jenis_mobil = @jenis, merk_mobil = @merk where id_card = @id"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Dim table As New DataTable("anggota")
        Dim adapter As New MySqlDataAdapter("select foto1,foto2,foto3 from anggota where id_card = '" + ComboId.Text + "'", conn)
        adapter.Fill(table)
        If ofd1.FileName = Nothing Then
            Dim row As DataRow = table.Rows(0)
            Using ms As New IO.MemoryStream(CType(row(0), Byte()))
                Dim img As Image = Image.FromStream(ms)
                pictureFoto1.Image = img
                Dim ms2 As MemoryStream = New MemoryStream
                Dim ms3 As MemoryStream = New MemoryStream
                pictureFoto2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
                pictureFoto3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg)
                ms2.ToArray()
                ms3.ToArray()
                Try
                    With SqlCommand.Parameters
                        .AddWithValue("@idcard", TxtKartu.Text)
                        .AddWithValue("@noid", TxtId.Text)
                        .AddWithValue("@nama", TxtNama.Text)
                        .AddWithValue("@umur", TxtUmur.Text)
                        .AddWithValue("@alamat", TxtAlamat.Text)
                        .AddWithValue("@pekerjaan", TxtPekerjaan.Text)
                        .AddWithValue("@nobil", TxtNoKend.Text)
                        .AddWithValue("@jenis", TxtJenis.Text)
                        .AddWithValue("@merk", TxtMerk.Text)
                        .AddWithValue("@foto1", CType(row(0), Byte()))
                        .AddWithValue("@foto2", ms2.ToArray)
                        .AddWithValue("@foto3", ms3.ToArray)
                    End With
                    SqlCommand.ExecuteNonQuery()
                    MsgBox("Data Berhasil Diperbaharui")
                    TextClear()
                    ButtonDisabled()
                    LoadGrid()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ofd2.FileName = Nothing Then
            Dim row As DataRow = table.Rows(0)
            Using ms As New IO.MemoryStream(CType(row(1), Byte()))
                Dim img As Image = Image.FromStream(ms)
                pictureFoto2.Image = img
                Dim ms2 As MemoryStream = New MemoryStream
                Dim ms3 As MemoryStream = New MemoryStream
                pictureFoto1.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
                pictureFoto3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg)
                ms2.ToArray()
                ms3.ToArray()
                Try
                    With SqlCommand.Parameters
                        .AddWithValue("@idcard", TxtKartu.Text)
                        .AddWithValue("@noid", TxtId.Text)
                        .AddWithValue("@nama", TxtNama.Text)
                        .AddWithValue("@umur", TxtUmur.Text)
                        .AddWithValue("@alamat", TxtAlamat.Text)
                        .AddWithValue("@pekerjaan", TxtPekerjaan.Text)
                        .AddWithValue("@nobil", TxtNoKend.Text)
                        .AddWithValue("@jenis", TxtJenis.Text)
                        .AddWithValue("@merk", TxtMerk.Text)
                        .AddWithValue("@foto2", CType(row(1), Byte()))
                        .AddWithValue("@foto1", ms2.ToArray)
                        .AddWithValue("@foto3", ms3.ToArray)
                    End With
                    SqlCommand.ExecuteNonQuery()
                    MsgBox("Data Berhasil Diperbaharui")
                    TextClear()
                    ButtonDisabled()
                    LoadGrid()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        ElseIf ofd3.FileName = Nothing Then
            Dim row As DataRow = table.Rows(0)
            Using ms As New IO.MemoryStream(CType(row(2), Byte()))
                Dim img As Image = Image.FromStream(ms)
                pictureFoto3.Image = img
                Dim ms2 As MemoryStream = New MemoryStream
                Dim ms3 As MemoryStream = New MemoryStream
                pictureFoto1.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
                pictureFoto2.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg)
                ms2.ToArray()
                ms3.ToArray()
                Try
                    With SqlCommand.Parameters
                        .AddWithValue("@idcard", TxtKartu.Text)
                        .AddWithValue("@noid", TxtId.Text)
                        .AddWithValue("@nama", TxtNama.Text)
                        .AddWithValue("@umur", TxtUmur.Text)
                        .AddWithValue("@alamat", TxtAlamat.Text)
                        .AddWithValue("@pekerjaan", TxtPekerjaan.Text)
                        .AddWithValue("@nobil", TxtNoKend.Text)
                        .AddWithValue("@jenis", TxtJenis.Text)
                        .AddWithValue("@merk", TxtMerk.Text)
                        .AddWithValue("@foto3", CType(row(2), Byte()))
                        .AddWithValue("@foto1", ms2.ToArray)
                        .AddWithValue("@foto2", ms3.ToArray)
                    End With
                    SqlCommand.ExecuteNonQuery()
                    MsgBox("Data Berhasil Diperbaharui")
                    TextClear()
                    ButtonDisabled()
                    LoadGrid()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        Else
            Dim ms As MemoryStream = New MemoryStream
            Dim ms2 As MemoryStream = New MemoryStream
            Dim ms3 As MemoryStream = New MemoryStream
            pictureFoto1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            pictureFoto2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
            pictureFoto3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg)
            ms.ToArray()
            ms2.ToArray()
            ms3.ToArray()
            Try
                With SqlCommand.Parameters
                    .AddWithValue("@id", ComboId.Text)
                    .AddWithValue("@idcard", TxtKartu.Text)
                    .AddWithValue("@noid", TxtId.Text)
                    .AddWithValue("@nama", TxtNama.Text)
                    .AddWithValue("@umur", TxtUmur.Text)
                    .AddWithValue("@alamat", TxtAlamat.Text)
                    .AddWithValue("@pekerjaan", TxtPekerjaan.Text)
                    .AddWithValue("@nobil", TxtNoKend.Text)
                    .AddWithValue("@jenis", TxtJenis.Text)
                    .AddWithValue("@merk", TxtMerk.Text)
                    .AddWithValue("@foto1", ms.ToArray)
                    .AddWithValue("@foto2", ms2.ToArray)
                    .AddWithValue("@foto3", ms3.ToArray)
                End With
                SqlCommand.ExecuteNonQuery()
                MsgBox("Data Berhasil Diperbaharui")
                TextClear()
                ButtonDisabled()
                LoadGrid()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "delete from anggota where id_card = '" + ComboId.Text + "'"
        sql &= ";"
        sql &= "delete from kendaraan where id_card = '" + ComboId.Text + "'"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Try
            SqlCommand.ExecuteNonQuery()
            MsgBox("Data Terhapus")
            Me.Refresh()
            ComboId.SelectedIndex = 0
            LoadGrid()
            ButtonDisabled()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboId.SelectedIndexChanged
        LoadData()
    End Sub

    Sub LoadId()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select * from anggota"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "anggota")
        count = ds.Tables("anggota").Rows.Count
        For i As Integer = 0 To count - 1
            ComboId.Items.Add(ds.Tables("anggota").Rows(i).Item("id_card"))
            ComboId.SelectedIndex = 0
        Next
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnPilih1_Click(sender As Object, e As EventArgs) Handles btnPilih1.Click
        If ofd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pictureFoto1.ImageLocation = ofd1.FileName
        End If
    End Sub

    Private Sub btnPilih2_Click(sender As Object, e As EventArgs) Handles btnPilih2.Click
        If ofd2.ShowDialog = Windows.Forms.DialogResult.OK Then
            pictureFoto2.ImageLocation = ofd2.FileName
        End If
    End Sub

    Private Sub btnPilih3_Click(sender As Object, e As EventArgs) Handles btnPilih3.Click
        If ofd3.ShowDialog = Windows.Forms.DialogResult.OK Then
            pictureFoto3.ImageLocation = ofd3.FileName
        End If
    End Sub

    Sub id_generate()
        Dim id As String
        Dim id2 As String
        Dim id3 As String
        Dim id4 As Integer
        Dim id5 As Integer
        Dim idx As String

        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select id_card from anggota order by id_card desc"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "anggota")
        id = ds.Tables("anggota").Rows(0).Item(0)
        id2 = id.Substring(1)
        id3 = id2.Substring(0, id2.Length - 1)
        id4 = Val(id3)
        id5 = id4 + 1
        idx = id5.ToString
        If idx.Length = 1 Then
            new_id = "P00" + idx + "E"
        Else
            If idx.Length = 2 Then
                new_id = "P0" + idx + "E"

            Else
                If idx.Length = 3 Then
                    new_id = "P" + idx + "E"
                End If
            End If
        End If
        TxtKartu.Text = new_id
        conn.Close()
    End Sub

    Private Sub TxtKartu_TextChanged(sender As Object, e As EventArgs) Handles TxtKartu.TextChanged

    End Sub
End Class