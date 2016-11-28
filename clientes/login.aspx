<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="clientes_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 45%;
            margin-left: 243px;
           color: #ffffff
        }
        .auto-style2 {
            text-align: center;
            background-color: #000;
                  color: #ffffff
        }
        .auto-style3 {
            width: 132px;
      background-color: #000;
              color: #ffffff
        }
        .auto-style4 {
            width: 251px;
           background-color: #000;
               
                  color: #ffffff
        }
        .auto-style5 {
            text-decoration: underline;
            text-align: center;
    background-color: #000;
                color: #ffffff
        }
        .auto-style6 {
            color: #000080;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMenuContextual1" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="auto-style5">Inicie sesión para poder comprar en Guitar Shop.</h2>


    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style3">Nombre de usuario:</td>
            <td class="auto-style4">
                <asp:TextBox ID="loginusuario" runat="server" Width="233px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Contraseña</td>
            <td class="auto-style4">
                <asp:TextBox ID="logincontra" runat="server" TextMode="Password" Width="232px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Iniciar_sesion" runat="server" Text="Iniciar sesión." OnClick="Button1_Click" CssClass="auto-style6" />
            </td>
        </tr>
    </table>
</asp:Content>

