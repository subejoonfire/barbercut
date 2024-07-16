Public Class Team_m
    Public Function Lihat() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT * FROM barber"

        'create object k
        Dim t As New KoneksiDB
        dt = t.GetResult(query)

        Return dt
    End Function
End Class
