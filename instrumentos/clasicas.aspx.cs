using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class instrumentos_clasicas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button19.Enabled = false;
        Button19.Visible = false;
        try
        {
            lblclausu.Text = Session["persona"].ToString();
            if (Session["persona"].ToString() != null)
            {

                Button19.Enabled = true;
                Button19.Visible = true;
            }
        }
        catch (Exception)
        {

        }
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        Session.Remove("persona");
        lblclausu.Text = "Invitado";
        Button19.Enabled = false;
        Button19.Visible = false;
    }
    public string iniciarbusqueda;
    public void datos()
    {
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("../compra-facturacion/compra.aspx");

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Kremona Romida Classical Guitar Natural";
        datos();
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        
        iniciarbusqueda = " Cordoba C9 CD/MH Acoustic Nylon String Classical Guitar Natural";
        datos();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Cordoba C9 CD/MH Acoustic Nylon String Classical Guitar Natural";
        datos();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Hofner Solid Cedar Top Mahogany Body Classical Acoustic Guitar Matte Natural";
        datos();
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Johnson LG-520 Acoustic Guitar Spruce, White Wood";
        datos();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Kremona Fiesta CW-7 Classical Electric Guitar Gloss Natural";
        datos();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Kremona Rosa Morena Classical Acoustic Guitar Natural";
        datos();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Kremona Soloist S65C Classical Acoustic Guitar Natural";
        datos();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Kremona Rosa Luna Flamenco Acoustic-Electric Nylon Guitar Natural";
        datos();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Lucero LFB250Sce Spruce/Cypress Thinline Acoustic-Electric Classical Guitar Natural";
        datos();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Lucero LC230S Exotic wood Classical Guitar Natural";
        datos();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Lucero LC100CE Acoustic-Electric Cutaway Classical Guitar Natural";
        datos();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Lucero LC100CE Acoustic-Electric Cutaway Classical Guitar Natural";
        datos();
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Lucero LFN200Sce Spruce/Rosewood Thinline Acoustic-Electric Classical Guitar Natural";
        datos();
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Lucero LC150Sce Spruce/Sapele Cutaway Acoustic-Electric Classical Guitar Natural";
        datos();
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Cordoba Solista CD/IN Acoustic Nylon String Classical Guitar";
        datos();
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Kremona 90th Anniversary Nylon String Guitar Natural";
        datos();
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Lyons Classroom Guitar  ";
        datos();
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Kremona Sofia S63CW Classical Acoustic-Electric Guitar Natural";
        datos();
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Yamaha C40 Classical Guitar Natural";
        datos();
    }


    protected void Button22_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Espana Classical Guitar Natural";
        datos();
    }
}