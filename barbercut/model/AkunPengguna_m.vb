Public Class AkunPengguna_m
    Dim idakun As Integer
    Dim username As String
    Dim password As String
    Dim level As String

    Public Function CekLogin(username As String, password As String) As DataTable
        Dim dt As New DataTable


        'mengambil data akun_pengguna berdasarkan nilai username
        Dim query As String = "SELECT * FROM akun_pengguna WHERE username = '" & username & "' AND password = '" & password & "'"
        Dim k As New KoneksiDB
        dt = k.GetResult(query)


        'menguji apakah dt ada isinya?
        Dim jumbar As Integer = dt.Rows.Count
        If jumbar = 0 Then
            dt = New DataTable  'mengosongkan dt jika tidak valid
        End If
        Return dt
    End Function
End Class
