Public Class BerandaPub
    Inherits System.Web.UI.Page

    Dim Barber_M As New Barber_M
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable = Barber_M.GetGrafik()
        ViewState("GrafikData") = dt
    End Sub
End Class