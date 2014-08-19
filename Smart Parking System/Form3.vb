Imports System.IO.Ports
Imports System.Data.Sql
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As MySqlConnection
    Dim connString As String
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        kapasitas()
    End Sub

    Public Sub LabelA1_Click(sender As Object, e As EventArgs) Handles LabelA1.Click

    End Sub
    Sub kapasitas()
        Dim kap As Integer
        connString = "Server=Localhost;Database=smart_parking;User Id=root;password="
        conn = New MySqlConnection(connString)
        conn.Open()
        sql = "select status_kendaraan from tamu where status_kendaraan = 0"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "tamu")
        kap = ds.Tables("tamu").Rows.Count
        If kap > 0 Then
            Label3.Text = kap
        Else
            Label3.Text = "Penuh"
        End If
    End Sub
End Class