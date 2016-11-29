<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="compra.aspx.cs" Inherits="compra_facturacion_compra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
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
                <asp:Label ID="lblproducto" runat="server" Text="Nombre de producto"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="lblmarca" runat="server" Text="Marca del producto"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Precio:"></asp:Label>
                <asp:Label ID="lblprecio" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Existencias:"></asp:Label>
                <asp:Label ID="lblexistencias" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btncomprar" runat="server" CssClass="auto-style2" Text="Comprar!" />
            </td>
        </tr>
    </table>
</asp:Content>

