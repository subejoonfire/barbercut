<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Sidebar.ascx.vb" Inherits="barbercut.Sidebar" %>

<%@ Register Src="ModalLogout.ascx" TagPrefix="uc" TagName="ModalLogout" %>

<%-- Sidebar --%>
<ul class="navbar-nav bg-primary sidebar sidebar-dark accordion" id="accordionSidebar">


<%-- Sidebar - Brand --%>
<li class="nav-item">
<% 
    Dim level As String = Session("level")
    Dim home As String
    home = "Beranda.aspx"
%>


<a class="sidebar-brand d-flex align-items-center justify-content-center" href="#">
<div class="sidebar-brand-icon">
<img src="/img/logobarber.jpg" width="50" />
</div>
<div class="sidebar-brand-text mx-3">Executes Barber</div>
</a>
</li>


<%-- Divider --%>
<li>
<hr class="sidebar-divider my-0">
</li>


<%-- Nav Item - Beranda --%>
<% If level = "admin" Or level = "member" Then%>
<li class="nav-item">
<a class="nav-link" href="Barber.aspx">
<i class="fa-solid fa-fw fa-home"></i>
<span>Beranda</span></a>
</li>
<% End If %>

<%-- Divider --%>
<li>
<hr class="sidebar-divider my-0">
</li>


<%--Nav Item - Logout--%>
<li class="nav-item">
<a class="nav-link" href="#" data-toggle="modal" data-target="#ModalLogout">
<i class="fa-solid fa-fw fa-sign-out-alt"></i>
<span>Logout</span></a>
</li>
</ul>
<%--End of Sidebar--%>


<%-- Sertakan Modal Logout --%>
<uc:ModalLogout ID="ModalLogout" runat="server" />