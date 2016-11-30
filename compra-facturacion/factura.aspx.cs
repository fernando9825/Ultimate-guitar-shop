using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class compra_facturacion_factura : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        conexion con = new conexion();
        string iva;
        string costo;
        double precio;
        double calculoiva;
        double cantidad=0;
        double subtotal;
        double total;
        try
        {//numero de factura
            string sql = "Insert into Factura (nombre, apellido, usuario, contraseña) values ('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtusuario.Text + "','" + txtcontraseña.Text + "');";
            con.guardar(sql);
            string script = "alert(\"Hello!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
           "ServerControlScript", script, true);
            //Fin numero de factura



            lblnombre.Text = Session["nombrecliente"].ToString();
            lblapellido.Text = Session["apellidocliente"].ToString();
            lblproducto.Text = Session["nombreproducto"].ToString();
            costo = Session["precio"].ToString();
            
            precio = Convert.ToDouble(costo);
            lblprecio.Text =  Convert.ToString(precio);
            iva = Session["precio"].ToString();

            calculoiva = Convert.ToDouble(iva) * 0.13;
            lblprecioiva.Text = Convert.ToString(calculoiva);
            subtotal = precio + calculoiva;
            lblsubtotal.Text = Convert.ToString(subtotal);
            total = subtotal * cantidad;
            lbltotal.Text = Convert.ToString(total);
            
        }
        catch { }
        
    }
}