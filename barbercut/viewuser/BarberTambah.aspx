<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BarberTambah.aspx.vb" Inherits="barbercut.BarberTambah" %>

<%@ Register TagPrefix="uc" TagName="Sidebar" Src="~/viewuser/Sidebar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Topbar" Src="~/viewuser/Topbar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewuser/Footer.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" runat="server">
<head>
    <title>Executes Barber</title>
    
    <!-- Custom fonts for this template -->
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />

    <!-- Icon Font Stylesheet -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v6.5.2/css/all.css" />

    <!-- SB Admin CSS -->
    <link href="/css/SBAdmin.css" rel="stylesheet" />

    <!-- Bootstrap CSS -->
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body id="page-top">
    <form id="form1" runat="server">
        <!-- Page Wrapper -->
        <div id="wrapper">
            <!-- Sidebar -->
            <uc:Sidebar ID="SidebarControl" runat="server" />

            <!-- Content Wrapper -->
            <div id="content-wrapper" class="d-flex flex-column">
                <!-- Main Content -->
                <div id="content">
                    <!-- Topbar -->
                    <uc:Topbar ID="TopbarControl" runat="server" />

                    <!-- Begin Page Content -->
                    <div class="container-fluid">
                        <!-- Page Heading -->
                        <div class="d-sm-flex align-items-center justify-content-between mb-4">
                            <h1 class="h3 mb-0 text-gray-800">Beranda</h1>
                        </div>

                        <!-- Form Tambah Data Barber -->
                        <div class="card shadow mb-4">
                            <div class="card-header py-3">
                                <h6 class="m-0 font-weight-bold text-primary">Tambah Data Barber</h6>
                            </div>
                            <div class="card-body">
                                <div class="form-group">
                                    <asp:Label ID="LabelNamaBarber" runat="server" Text="Nama Barber"></asp:Label>
                                    <asp:TextBox ID="txtNamaBarber" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="LabelSkill" runat="server" Text="Skill"></asp:Label>
                                    <asp:TextBox ID="txtSkill" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="LabelJenisKelamin" runat="server" Text="Jenis Kelamin"></asp:Label>
                                    <asp:TextBox ID="txtJenisKelamin" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="LabelUmur" runat="server" Text="Umur"></asp:Label>
                                    <asp:TextBox ID="txtUmur" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" OnClick="btnSimpan_Click" />
                                <asp:Button ID="btnKembali" runat="server" Text="Kembali" CssClass="btn btn-secondary" OnClick="btnKembali_Click" />
                            </div>
                        </div>
                    </div>
                    <!-- End Container Fluid -->
                </div>
                <!-- End Main Content -->
            </div>
            <!-- End Content Wrapper -->
        </div>
        <!-- End Page Wrapper -->

        <!-- Bootstrap JS and SB Admin JS -->
        <script src="/js/bootstrap.bundle.min.js"></script>
        <script src="/js/SBAdmin2Min.js"></script>
    </form>
</body>
</html>
