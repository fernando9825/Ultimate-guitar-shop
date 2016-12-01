<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-large;
            text-transform: capitalize;
            color: #FFFFFF;
            background-color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMenuContextual1" Runat="Server">
    <strong>
    <asp:Label ID="lblusuario" runat="server" Text="Invitado" CssClass="auto-style1"></asp:Label>
    </strong>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cerrar sesión" Visible="false" Enabled="false" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Fernando, ¿Deseas registrar productos?"></asp:Label>
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Registrar productos." />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

