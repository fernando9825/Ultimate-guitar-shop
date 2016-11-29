using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class compra_facturacion_compra : System.Web.UI.Page

{

   
    
    
    protected void Page_Load(object sender, EventArgs e)

    {
        try
        {
            lblproducto.Text = Session["nombreproducto"].ToString();
            lblmarca.Text = Session["marca"].ToString();
            lblprecio.Text = "$ " + Session["precio"].ToString();
            lbldescripcion.Text = Session["descripcion"].ToString();
            lblexistencias.Text = Session["existencias"].ToString();
        }
        catch { }
        
    }
}