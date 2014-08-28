Imports System.Data.Sql
Imports MySql.Data.MySqlClient
Imports System.IO.Ports

Public Class Login
    Dim connString As String
    Dim sql As String
    Dim count As Integer
    Public username As String
    Public jam_masuk As System.DateTime
    Public level As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C_login()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '----Start Control Login-----
    Private Sub C_login()
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Aktifkan Local Host Terlebih Dahulu!")
        End Try
        Dim da As MySqlDataAdapter
        Dim ds As DataSet

        Dim password As String
        username = txtUsername.Text
        password = txtPassword.Text
        sql = "select * from admin where username = '" + username + "'"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "admin")
        Try
            count = ds.Tables("admin").Rows.Count
            level = ds.Tables("admin").Rows(0).Item("status_user")
            If count > 0 Then
                If password = ds.Tables("admin").Rows(0).Item("password") Then
                    If level = 0 Then
                        MsgBox("Login Sukses")
                        MDIParent1.KelolaPenggunaToolStripMenuItem.Enabled = True
                        MDIParent1.DisplayToolStripMenuItem.Enabled = False
                        MDIParent1.VerifikasiKeluarToolStripMenuItem.Enabled = False
                        MDIParent1.Show()
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        jam_masuk = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    Else
                        MsgBox("Login Sukses")
                        MDIParent1.KelolaPenggunaToolStripMenuItem.Enabled = False
                        MDIParent1.DisplayToolStripMenuItem.Enabled = True
                        MDIParent1.VerifikasiKeluarToolStripMenuItem.Enabled = True
                        MDIParent1.Show()
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        jam_masuk = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    End If
                Else
                    MsgBox("Password Salah")
                End If
            End If
        Catch ex As Exception
            MsgBox("Username Salah", vbExclamation, "Smart Parking System")
        End Try
        conn.Close()
    End Sub
    '-----END CONTROL LOGIN--------

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress

        If e.KeyChar = Chr(13) Then
            C_login()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
