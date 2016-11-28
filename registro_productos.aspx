<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="registro_productos.aspx.cs" Inherits="registro_productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-left: 0px;
            margin-right: 0px;
        }
        .auto-style2 {
            text-align: left;
            background-color: #003366;
        }
        .auto-style4 {
            width: 57px;
        }
        .auto-style5 {
            width: 57px;
            height: 28px;
        }
        .auto-style6 {
            height: 28px;
            width: 14px;
        }
        .auto-style7 {
            width: 14px;
        }
        .auto-style8 {
            width: 57px;
            height: 25px;
            color: #FFFFFF;
            background-color: #003366;
        }
        .auto-style9 {
            height: 25px;
            width: 14px;
            background-color: #003366;
        }
        .auto-style10 {
            width: 57px;
            height: 59px;
            color: #FFFFFF;
            background-color: #003366;
        }
        .auto-style11 {
            width: 14px;
            height: 59px;
            background-color: #003366;
        }
        .auto-style12 {
            width: 57px;
            color: #FFFFFF;
            background-color: #003366;
        }
        .auto-style13 {
            width: 57px;
            height: 28px;
            color: #FFFFFF;
            background-color: #003366;
        }
        .auto-style14 {
            width: 14px;
            background-color: #003366;
        }
        .auto-style15 {
            height: 28px;
            width: 14px;
            background-color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMenuContextual1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">Producto</td>
            <td class="auto-style15">
                <asp:TextBox ID="producto" runat="server" Width="230px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Marca</td>
            <td class="auto-style14">
                <asp:TextBox ID="marca" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Precio</td>
            <td class="auto-style14">
                <asp:TextBox ID="precio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Existencias</td>
            <td class="auto-style9">
                <asp:TextBox ID="existencias" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Descripcion</td>
            <td class="auto-style11">
                <asp:TextBox ID="descripcion" runat="server" Height="56px" Width="229px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrar producto" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

