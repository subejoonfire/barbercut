Public Class BarberEdit
    Inherits System.Web.UI.Page

    Dim Barber_M As New Barber_M
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim id_barber As Integer = Convert.ToInt32(Request.QueryString("id_barber"))
            Dim dt As DataTable = Barber_M.Edit(id_barber)
            If dt.Rows.Count > 0 Then
                txtIdBarber.Text = dt.Rows(0)("id_barber").ToString()
                txtNamaBarber.Text = dt.Rows(0)("nama").ToString()
                txtSkill.Text = dt.Rows(0)("skill").ToString()
                txtJenisKelamin.Text = dt.Rows(0)("jenis_kelamin").ToString()
                txtUmur.Text = dt.Rows(0)("umur").ToString()
            End If
        End If
    End Sub
    Protected Sub btnSimpan_Click(sender As Object, e As EventArgs)
        If Barber_M.Update(txtIdBarber.Text, txtNamaBarber.Text, txtSkill.Text, txtJenisKelamin.Text, CInt(txtUmur.Text)) Then
            Response.Redirect("Barber.aspx")
        Else
            Response.Redirect("Barber.aspx")
        End If
    End Sub

    Protected Sub btnKembali_Click(sender As Object, ByVal e As EventArgs) Handles btnKembali.Click
        Response.Redirect("Barber.aspx")
    End Sub
End Class