<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado-UI.aspx.cs" Inherits="Empleados.Empleado_UI" UnobtrusiveValidationMode="None" %>

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
    
        <asp:Label ID="error" runat="server" Text="USUARIO EXISTENTE MODIFICAR" visible="false"></asp:Label>
    
    </div>

        <uc1:LabelTexto runat="server" id="LabelTexto" />

        <p>
            Legajo: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="ValidaLega" runat="server" ValidationGroup="grupo1" ControlToValidate="TextBox1" Text="*" ErrorMessage="Esta Vacio" Display="Static"></asp:RequiredFieldValidator>
            
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="*"></asp:CustomValidator>
            
        </p>
        <p>
            Nombre: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="ValidarNom" runat="server" ControlToValidate="TextBox2" Text="*" ErrorMessage="Esta Vacio" Display="Static"></asp:RequiredFieldValidator>
            
        </p>
        <p>
            Apellido: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>         
            
            <asp:RequiredFieldValidator ID="ValidarApe" runat="server" ControlToValidate="TextBox3" Text="*" ErrorMessage="Esta Vacio" Display="Static"></asp:RequiredFieldValidator>
            
        </p>
        <p>
            Contraseña: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>         
            
            <asp:RequiredFieldValidator ID="ValidaContra" runat="server" ControlToValidate="TextBox5" Text="*" ErrorMessage="Esta Vacio" Display="Static"></asp:RequiredFieldValidator>
            
        </p>
        <p>
            Confirme contreaseña: <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>         
            

            
            <asp:CompareValidator ID="ConfiContrasenia" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox5" ErrorMessage="Las contraseñas no son iguales">*</asp:CompareValidator>
            

            
        </p>
        <p>
            <asp:DropDownList ID="TipoUsuario" runat="server">
                <asp:ListItem Value="-1">Elija una Opcion</asp:ListItem>
                <asp:ListItem Value="1">Cocinero</asp:ListItem>
                <asp:ListItem Value="2">Comensal</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="ValidaTipoUsuario" runat="server" ControlToValidate="TipoUsuario" ErrorMessage="Debe seleccionar una opcion" InitialValue="-1">*</asp:RequiredFieldValidator>
        </p>
         <p>
            <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" OnClick="btnGuardar_Click" CausesValidation="true"/>
        </p>
        <asp:GridView ID="gvEmpleados" runat="server" >
        </asp:GridView>
        <br />
        Legajo a borrar:         
        <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
        <p>
            <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="BORRAR" />
        </p>
        <asp:ValidationSummary ID="ResumenValidaciones" runat="server" />
    </form>
</body>
</html>
