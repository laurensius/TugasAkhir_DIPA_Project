Imports System.Windows.Forms
Imports System.Data.Sql
Imports MySql.Data.MySqlClient

Public Class MDIParent1
    Public f3 As Form3 = New Form3
    Public fpet As Petugas = New Petugas
    Private Sub KelolaPenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelolaPenggunaToolStripMenuItem.Click
        
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim x As MsgBoxResult
        Dim connString As String
        Dim sql As String
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        Dim conn As New MySqlConnection(connString)
        conn.Open()
        sql = "insert into log_admin (username,tanggal_masuk,tanggal_keluar) values (@username,@masuk,now())"
        Dim SqlCommand As New MySqlCommand(sql, conn)
        Try
            With SqlCommand.Parameters
                .AddWithValue("@username", Login.username)
                .AddWithValue("@masuk", Login.jam_masuk)
            End With
            SqlCommand.ExecuteNonQuery()
            Login.jam_masuk = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        x = MsgBox("Apakah Anda akan Keluar dari aplikasi", vbYesNo, "Konfirmasi")
        If (x = vbYes) Then
            Me.Close()
            Login.txtUsername.Focus()
        End If
    End Sub

    Private Sub ControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Form1 Then
                f.Activate()
                Return
            End If
        Next
        For Each g As Form In Application.OpenForms
            If TypeOf g Is PantauLahan Then
                g.Activate()
                Return
            End If
        Next
        Dim mdiChild As New Form1()
        Dim pantauLahan As New PantauLahan()
        mdiChild.MdiParent = Me
        If Application.OpenForms().OfType(Of Form3).Any And Application.OpenForms().OfType(Of Petugas).Any Then
            mdiChild.Show()
        ElseIf Login.level = 0 Then
            pantauLahan.Show()
        Else
            MsgBox("Silahkan Buka Form Display dan Verifikasi Keluar Terlebih Dahulu")
        End If

    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Form3 Then
                f.Activate()
                Return
            End If
        Next
        f3.MdiParent = Me
        f3.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f3 As Form3 = New Form3
    End Sub

    Private Sub KelolaPenggunaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KelolaPenggunaToolStripMenuItem1.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Form2 Then
                f.Activate()
                Return
            End If
        Next
        Dim mdiChild As New Form2()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub GenerateKartuParkirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateKartuParkirToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Form4 Then
                f.Activate()
                Return
            End If
        Next
        Dim mdiChild As New Form4()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub KelolaPetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelolaPetugasToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is KelolaPetugas Then
                f.Activate()
                Return
            End If
        Next
        Dim mdiChild As New KelolaPetugas()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub VerifikasiKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifikasiKeluarToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Petugas Then
                f.Activate()
                Return
            End If
        Next
        Dim mdiChild As New Petugas()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub LogPetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogPetugasToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is log_petugas Then
                f.Activate()
                Return
            End If
        Next
        Dim mdiChild As New log_petugas
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub LogKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogKendaraanToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is LogKendaraan Then
                f.Activate()
                Return
            End If
        Next
        Dim mdiChild As New LogKendaraan()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub
End Class
