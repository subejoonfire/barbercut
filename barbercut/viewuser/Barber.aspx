<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Barber.aspx.vb" Inherits="barbercut.Barber" %>

<%@ Register TagPrefix="uc" TagName="Sidebar" Src="~/viewuser/Sidebar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Topbar" Src="~/viewuser/Topbar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewuser/Footer.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Executes Barber</title>

    <%-- Custom fonts for this template --%>
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />

    <%-- Icon Font Stylesheet --%>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v6.5.2/css/all.css" />

    <%-- Template Stylesheet --%>
    <link href="/css/SBAdmin.css" rel="stylesheet" />
</head>

<body id="page-top">
    <form id="form1" runat="server">
        <%-- Page Wrapper --%>
        <div id="wrapper">
            <%-- Panggil Sidebar --%>
            <uc:Sidebar ID="SidebarControl" runat="server" />

            <%-- Content Wrapper --%>
            <div id="content-wrapper" class="d-flex flex-column">
                <%-- Main Content --%>
                <div id="content">
                    <%-- Panggil Topbar --%>
                    <uc:Topbar ID="TopbarControl" runat="server" />

                    <%-- Begin Page Content --%>
                    <div class="container-fluid">
                        <%-- Page Heading --%>
                        <div class="d-sm-flex align-items-center justify-content-between mb-4">
                            <h1 class="h3 mb-0 text-gray-800">Beranda</h1>
                        </div>

                        <%-- Content Row --%>
                        <div class="row">
                            <div class="col-md-12">
                                <%-- Tombol Tambah --%>
                                <asp:Button ID="btnTambah" runat="server" Text="Tambah Barber" CssClass="btn btn-primary mb-3" OnClick="btnTambah_Click" />

                                <%-- GridView untuk menampilkan data --%>
                                <asp:GridView ID="GV" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
                                    <Columns>
                                        <asp:BoundField DataField="id_barber" HeaderText="ID Barber" />
                                        <asp:BoundField DataField="nama" HeaderText="Nama Barber" />
                                        <asp:BoundField DataField="skill" HeaderText="Skill" />
                                        <asp:BoundField DataField="jenis_kelamin" HeaderText="Jenis Kelamin" />
                                        <asp:BoundField DataField="umur" HeaderText="Umur" />
                                        <asp:TemplateField HeaderText="Actions">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("id_barber") %>' OnCommand="Edit_Barber" Text="Edit" />
                                                <asp:LinkButton ID="lbDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("id_barber") %>' OnCommand="Delete_Barber" Text="Delete" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <%-- End Container Fluid --%>
                </div>
                <%-- End Main Content --%>

                <%-- Panggil Footer --%>
                <uc:Footer ID="FooterControl" runat="server" />
            </div>
            <%-- End Content Wrapper --%>
        </div>
        <%-- End Page Wrapper --%>
    </form>
</body>
</html>
