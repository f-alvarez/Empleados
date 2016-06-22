<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploUC.aspx.cs" Inherits="Empleados.EjemploUC" %>

<%@ Register Src="~/LabelTexto.ascx" TagPrefix="uc1" TagName="LabelTexto" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:LabelTexto runat="server" ID="UCNombre" TextoLabel="Nombre" />

        <uc1:LabelTexto runat="server" ID="UCApellido" TextoLabel="Apellido" />


    </div>
        <asp:Button ID="IDSumar" runat="server" Text="Sumar" OnClick="Button1_Click" />
        <br/>
        <uc1:LabelTexto runat="server" ID="UCNombreCompleto" TextoLabel="UCNombre Completo" />
    </form>
</body>
</html>
