<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Pagina-con-master.aspx.cs" Inherits="Empleados.Pagina_con_master" %>
<%@ MasterType VirtualPath="~/Base.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <asp:TextBox ID="IDTxtUsuario" runat="server"></asp:TextBox>
    <asp:Button ID="BtnGuardar" runat="server" Text="Button" OnClick="BtnGuardar_Click"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PieDePagina" runat="server">
</asp:Content>

   