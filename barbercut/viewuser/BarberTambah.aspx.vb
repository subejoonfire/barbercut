Imports System.Data.SqlClient

Public Class BarberTambah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Kode yang ingin dijalankan saat halaman dimuat dapat ditambahkan di sini jika diperlukan
    End Sub

    Protected Sub btnSimpan_Click(sender As Object, e As EventArgs)
        Dim barber As New Barber_M
        If barber.Tambah(txtNamaBarber.Text, txtSkill.Text, txtJenisKelamin.Text, CInt(txtUmur.Text)) Then
            Response.Redirect("Barber.aspx")
        Else
            Response.Redirect("Barber.aspx")
        End If
    End Sub

    Protected Sub btnKembali_Click(sender As Object, ByVal e As EventArgs) Handles btnKembali.Click
        Response.Redirect("Barber.aspx")
    End Sub
End Class
