using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class instrumentos_acusticas : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        try { Session["comprobar"] = "si"; } catch { }
        Button19.Enabled = false;
        Button19.Visible = false;
        try
        {
            lblacususuario.Text = Session["persona"].ToString();
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

    public string iniciarbusqueda;
    

    protected void Button19_Click(object sender, EventArgs e)
    {
        Session.Remove("persona");
        lblacususuario.Text = "Invitado";
        Button19.Enabled = false;
        Button19.Visible = false;
    }

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
        iniciarbusqueda = "Breedlove Pursuit Nylon Acoustic-Electric Guitar Natural";
        datos();
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Acoustic Guitar Natural";
        datos();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Jasmine S-34C Cutaway Acoustic Guitar Natural";
        datos();
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Luna Guitars Gypsy Spalt Grand Auditorium Acoustic-Electric Guitar  ";
        datos();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Luna Guitars Muse Safari Series Mahogany 3/4 Dreadnought Travel Acoustic Guitar Natural";
        datos();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Mitchell MO120CESB Acoustic-Electric Cutaway Vintage Sunburst";
        datos();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Mitchell MD100 Dreadnought Acoustic Guitar Natural";
        datos();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Mitchell MX420 Grand Auditorium Acoustic-Electric Guitar Midnight Black Finish";
        datos();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RA-100D Dreadnought Acoustic Guitar";
        datos();
    }


    protected void Button10_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue Starter Acoustic Guitar";
        datos();
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RA-090 Concert Acoustic Guitar  ";
        datos();
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RG-624 Left-Handed Dreadnought Acoustic Guitar Natural";
        datos();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RA-090 Concert Acoustic Guitar  ";
        datos();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RD80 Dreadnought Acoustic Guitar  ";
        datos();
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Savannah Savannah SO-SGD-10C Dreadnought Acoustic-Electric Guitar Black";
        datos();
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RA-100D Dreadnought Acoustic Guitar";
        datos();
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Alvarez 50th Anniversary AFA1965 OM/Folk Acoustic Guitar Sunburst";
        datos();
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Alvarez AG610CESHB Grand Auditorium Acoustic-Electric Guitar Shadow Burst";
        datos();
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Alvarez RP266EBK Parlor Acoustic-Electric Guitar Black";
        datos();
    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Luna Guitars Vista Eagle 12-String Acoustic-Electric Guitar Natural";
        datos();
    }

    protected void Button23_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Recording King Dirty Thirties OOO Solid Top Satin Sunburst";
        datos();
    }


   
}