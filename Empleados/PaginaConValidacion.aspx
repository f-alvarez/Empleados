<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="PaginaConValidacion.aspx.cs" Inherits="Empleados.PaginaConValidacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
         
    <p>
        DNI:
        <asp:TextBox ID="dniText" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="DniVacio" runat="server"  ValidationGroup="grupo1" ControlToValidate="dniText" ErrorMessage="El campo esta vacio" Display="Dynamic">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="DniEntero" runat="server" ValidationGroup="grupo1" ErrorMessage="Tiene que ser un numero entero mayor a 0" MaximumValue="100000000" MinimumValue="0" Type="Integer" ControlToValidate="dniText" Display="Dynamic">*</asp:RangeValidator>
    </p>
    <p>
        Fecha Nac:
        <asp:TextBox ID="FNText" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="FechaVacia" runat="server" ValidationGroup="grupo1" ControlToValidate="FNText" ErrorMessage="Fecha esta Vacia" Display="Dynamic">*</asp:RequiredFieldValidator>
    </p>    
     <p>
        Email:
        <asp:TextBox ID="EmailText" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="EmailVacio" runat="server" ValidationGroup="grupo1" ControlToValidate="EmailText" ErrorMessage="El Email esta vacio" Display="Dynamic">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="ValidaEmail" runat="server" ValidationGroup="grupo1" Display="Dynamic" ErrorMessage="El mail no es valido" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$" ControlToValidate="EmailText">*</asp:RegularExpressionValidator>
    </p>
     <p>
        Contraseña:
        <asp:TextBox ID="ContraText" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="ContraVacia" ValidationGroup="grupo1" runat="server" ControlToValidate="ContraText" ErrorMessage="La Contraseña esta vacia" Display="Dynamic">*</asp:RequiredFieldValidator>
    </p>               
     <p>
        Confirma Contraseña:
        <asp:TextBox ID="ConfirContraText" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="ReContraVacia" runat="server" ValidationGroup="grupo1" ControlToValidate="ConfirContraText"  ErrorMessage="La Contraseña esta vacia" Display="Dynamic" textMode="password">*</asp:RequiredFieldValidator>
    </p>
        <div>
            Tipo Usuario:&nbsp;
            <asp:DropDownList ID="TipoUsuario" runat="server">
                <asp:ListItem Value="-1">Selecciones Opcion</asp:ListItem>
                <asp:ListItem Value="1">Elemento1</asp:ListItem>
                <asp:ListItem Value="2">Elemento2</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="ValidaOpc" ValidationGroup="grupo1" runat="server" ErrorMessage="Selecciones una Opcion" InitialValue="-1" ControlToValidate="TipoUsuario" Display="Dynamic">*</asp:RequiredFieldValidator>
        </div>
        <p>
            <asp:Button ID="Registrarse" runat="server" Text="Registrarse" ValidationGroup="grupo1" OnClick="Registrarse_Click"  />
        </p>
        <asp:ValidationSummary ID="ResumenValidaciones" runat="server" ValidationGroup="grupo1" />
    </form>
</body>
</html>
