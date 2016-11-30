<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="compra.aspx.cs" Inherits="compra_facturacion_compra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style4 {
            font-size: x-large;
            color: #FFFFFF;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style5 {
            font-size: large;
            color: #FFFFFF;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-weight: bold;
            text-transform: capitalize;
        }
        .auto-style6 {
            font-size: medium;
            color: #FFFFFF;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            color: #FFFFFF;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMenuContextual1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="auto-style1">
        <tr>
            <td rowspan="4">
                <asp:Image ID="imagenproducto" runat="server" Width="207px" />
            </td>
            <td colspan="6">
                <strong>
                <asp:Label ID="lblmarca" runat="server" Text="Marca del producto" CssClass="auto-style4" ></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="lblproducto" runat="server" Text="Nombre de producto" CssClass="auto-style5" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <em>
                <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion" CssClass="auto-style6" ></asp:Label>
                </em>
            </td>
        </tr>
        <tr>
            <td>
                <strong>
                <asp:Label ID="Label1" runat="server" Text="Precio:" CssClass="auto-style3" ></asp:Label>
                <asp:Label ID="lblprecio" runat="server" CssClass="auto-style3"></asp:Label>
                </strong>
            </td>
            <td>
                <strong>
                <asp:Label ID="Label2" runat="server" Text="Existencias:" CssClass="auto-style3" ></asp:Label>
                <asp:Label ID="lblexistencias" runat="server" CssClass="auto-style3" ></asp:Label>
                </strong>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btncomprar" runat="server" CssClass="auto-style2" Text="Comprar!" OnClick="btncomprar_Click" />
            </td>
        </tr>
    </table>
    <br /><br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style7"><strong>
                <asp:Label ID="lblinformacion" runat="server" CssClass="auto-style8"></asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="btninicar" runat="server" Text="Iniciar sesión!" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnregistrar" runat="server" Text="Registrarse!" />
            </td>
        </tr>
    </table>
    <br />

</asp:Content>

