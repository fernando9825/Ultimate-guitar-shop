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
        double cantidad=1;
        double subtotal;
        double total=0;
        string cant;
        

        try
        {
            
            lblnombre.Text = Session["nombrecliente"].ToString();
            con.nombreparafactura = Session["nombrecliente"].ToString();
            lblapellido.Text = Session["apellidocliente"].ToString();
            lblproducto.Text = Session["nombreproducto"].ToString();
            costo = Session["precio"].ToString();     
            precio = Convert.ToDouble(costo);
            lblprecio.Text =  Convert.ToString(precio);
            iva = Session["precio"].ToString();
            lblcantidad.Text = Session["cantidad"].ToString();
            cant = Session["cantidad"].ToString();
            cantidad = Convert.ToDouble(cant);
            calculoiva = Convert.ToDouble(iva) * 0.13;
            lblprecioiva.Text = Convert.ToString(calculoiva);
            subtotal = precio + calculoiva;
            lblsubtotal.Text = Convert.ToString(subtotal);
            total = subtotal * cantidad;
            lbltotal.Text = Convert.ToString(total);

            //Cambio a cliente//

            string efectivo;
            double dinerocliente;
            double cambio;
            efectivo = Session["efectivo"].ToString();
            dinerocliente = Convert.ToDouble(efectivo);
            cambio = dinerocliente - total;
            lblcambio.Text = Convert.ToString(cambio);

            //numero de factura
            string sql = "Insert into Factura (nombre, apellido, producto, cantidad, total) values ('" + lblnombre.Text + "','" + lblapellido.Text + "','" + lblproducto.Text + "','" + cantidad + "','" + total + "');";
            con.guardar(sql);
            con.Factura();
            Session["factura"] = con.numerofactura;


            //Fin numero de factura


        }
        catch (Exception E)
        {
            string script = "alert('Hola " + con.nombre + " " + con.apellido + " Lo sentimos, ocurrió el siguiente error!" + E + "')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script, true);
        }
        try { lblfactura.Text = Session["factura"].ToString(); } catch { }
        
        
    }
}