<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-large;
            text-transform: capitalize;
            color: #ff0000;
            background-color: #000000;

            
        }

        .auto-style2 {
          width: 120px;
            height: 30px;
            color: #ffffff;
          
            font-size: 10px;
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
    <h1>SOMOS LO MEJOR, ¿Eres un guitarrista de siempre buscando algo especialmente único? Echa un vistazo a nuestros instrumentos; guitarras, todo tipo de guitarras en nuestra tienda en línea, o en persona en su tienda Gshop local. 
Venta de instrumentos musicales y accesorios. En nuestra web encontrarás más de 2.000 productos de todo tipo relacionados con la música a precios imbatibles. Nuestro catálogo de guitarras eléctricas en venta es especialmente amplio. Disponemos de una amplia gama de guitarras, así como guitarras acústicas y clásicas y electricas
No importa su nivel de experiencia o preferencia musical, nuestro equipo de experimentados músicos le ayudará a encontrar la pieza adecuada para su banda, conjunto o lugar de música. Ya sea que esté empezando a hacer música, o si es un profesional que trabaja, Guitar Shop tiene lo que necesita para ayudar a hacer que los sonidos en su cabeza sean una realidad.
</h1> 
    <table class= "auto-style2"></table>
    
</asp:Content>

