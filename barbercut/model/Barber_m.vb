Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Barber_M
    Private nama As String
    Private alamat As String
    Dim k As New KoneksiDB
    Dim dt As New DataTable
    Public Function Tambah(nama As String, skill As String, jenis_kelamin As String, umur As Integer) As Boolean
        Dim query As String = "INSERT INTO barber (nama, skill, jenis_kelamin, umur) VALUES (@nama, @skill, @jenis_kelamin, @umur)"
        Dim k As New KoneksiDB
        Dim parameters As MySqlParameter() = {
        New MySqlParameter("@nama", nama),
        New MySqlParameter("@skill", skill),
        New MySqlParameter("@jenis_kelamin", jenis_kelamin),
        New MySqlParameter("@umur", umur)
        }
        Return k.Execute(query, parameters)
    End Function
    Public Function Tampil() As DataTable
        Dim query As String = "SELECT * FROM barber"
        Dim k As New KoneksiDB
        Dim dt As DataTable = k.GetResult(query)
        Dim jumbar As Integer = dt.Rows.Count
        If jumbar = 0 Then
            dt = New DataTable
            dt.Columns.AddRange(New DataColumn() {
            New DataColumn("id_barber", GetType(Integer)),
            New DataColumn("nama", GetType(String)),
            New DataColumn("skill", GetType(String)),
            New DataColumn("jenis_kelamin", GetType(String)),
            New DataColumn("umur", GetType(Integer))
        })
        End If
        Return dt
    End Function
    Public Function Edit(id_barber As Integer)
        Dim query As String = "SELECT * FROM barber WHERE id_barber = " & id_barber
        Dim dt As DataTable = k.GetResult(query)
        Dim jumbar As Integer = dt.Rows.Count
        If jumbar = 0 Then
            dt = New DataTable
            dt.Columns.AddRange(New DataColumn() {
            New DataColumn("id_barber", GetType(Integer)),
            New DataColumn("nama", GetType(String)),
            New DataColumn("skill", GetType(String)),
            New DataColumn("jenis_kelamin", GetType(String)),
            New DataColumn("umur", GetType(Integer))
        })
        End If
        Return dt
    End Function
    Public Function Update(id_barber As Integer, nama As String, skill As String, jenis_kelamin As String, umur As Integer) As Boolean
        Dim query As String = "UPDATE barber SET nama = @nama, skill = @skill, jenis_kelamin = @jenis_kelamin, umur = @umur WHERE id_barber = @id_barber"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@id_barber", id_barber),
            New MySqlParameter("@nama", nama),
            New MySqlParameter("@skill", skill),
            New MySqlParameter("@jenis_kelamin", jenis_kelamin),
            New MySqlParameter("@umur", umur)
        }
        Return k.Execute(query, parameters)
    End Function

    Public Function Hapus(id_barber As Integer) As Boolean
        Dim query As String = "DELETE FROM barber WHERE id_barber = @id_barber"
        Dim k As New KoneksiDB
        Dim parameters As MySqlParameter() = {
        New MySqlParameter("@id_barber", id_barber)
    }
        Return k.Execute(query, parameters)
    End Function
    Public Sub SetBarber(nama As String, alamat As String)
        Me.nama = nama
        Me.alamat = alamat
    End Sub
    Public Function GetImage(id_gambar As Integer) As Byte()
        Dim query As String = "SELECT * FROM gambar WHERE idgambar = " & id_gambar
        Dim dt As DataTable = k.GetResult(query)
        If dt.Rows.Count > 0 Then
            Dim imageData As Byte() = CType(dt.Rows(0)("gambar"), Byte())
            Return imageData
        Else
            Return Nothing
        End If
    End Function
    Public Function GetGrafik() As DataTable
        Dim query As String = "SELECT * FROM grafik"
        Dim k As New KoneksiDB
        Dim dt As DataTable = k.GetResult(query)
        Dim jumbar As Integer = dt.Rows.Count
        If jumbar = 0 Then
            dt = New DataTable
            dt.Columns.AddRange(New DataColumn() {
            New DataColumn("id_grafik", GetType(Integer)),
            New DataColumn("grafik_nama", GetType(String)),
            New DataColumn("grafik_total", GetType(String))
        })
        End If
        Return dt
    End Function
End Class