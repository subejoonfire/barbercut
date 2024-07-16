Imports MySql.Data.MySqlClient

Public Class KoneksiDB
    Dim username, password, server, database As String
    Dim mycn As MySqlConnection
    Dim mycmd As MySqlCommand

    Public Sub New()
        username = "root"
        password = ""
        server = "localhost"
        database = "barberexecut"

        Dim con_str As String
        con_str = "server=" & server & ";"
        con_str &= "user=" & username & ";"
        con_str &= "password=" & password & ";"
        con_str &= "database=" & database & ";"
        con_str &= "SslMode=none;"

        mycn = New MySqlConnection(con_str)
    End Sub

    Public Sub CekKoneksi()
        Try
            mycn.Open()
            mycn.Close()
            MsgBox("Koneksi Berhasil")
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
            End If
            MsgBox("Koneksi Gagal")
        End Try
    End Sub

    Public Function Execute(query As String, Optional parameters As MySqlParameter() = Nothing) As Boolean
        Try
            mycn.Open()
            mycmd = New MySqlCommand(query, mycn)

            If parameters IsNot Nothing Then
                mycmd.Parameters.AddRange(parameters)
            End If

            Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()
            mycn.Close()

            Return rowsAffected > 0
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
            End If
            MsgBox("Terjadi kesalahan saat menjalankan perintah SQL: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function GetResult(query As String) As DataTable
        Dim dt As New DataTable
        Try
            mycn.Open()
            Dim mydata As New MySqlDataAdapter(query, mycn)
            mydata.Fill(dt)
            mycn.Close()
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
            End If
            MsgBox("Data tidak dapat ditampilkan: " & ex.Message, MsgBoxStyle.Information, "Informasi")
        End Try
        Return dt
    End Function
End Class
