Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class Barber
    Inherits System.Web.UI.Page
    Dim Barber_M As New Barber_M

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindGridView()
        End If
    End Sub

    Protected Sub btnTambah_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("~/viewuser/BarberTambah.aspx")
    End Sub
    Protected Sub Edit_Barber(sender As Object, e As CommandEventArgs)
        Dim id_barber As Integer = Convert.ToInt32(e.CommandArgument)
        Server.Transfer("~/viewuser/BarberEdit.aspx?id_barber=" & id_barber.ToString())
    End Sub

    Protected Sub Delete_Barber(sender As Object, e As CommandEventArgs)
        Dim id_barber As Integer = Convert.ToInt32(e.CommandArgument)
        Barber_M.Hapus(id_barber)
        Response.Redirect("~/viewuser/Barber.aspx")
    End Sub
    Private Sub BindGridView()
        Dim dt As DataTable = Barber_M.Tampil()
        GV.DataSource = dt
        GV.DataBind()
    End Sub
End Class
