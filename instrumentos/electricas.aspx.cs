using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class instrumentos_electricas : System.Web.UI.Page
{
    public string iniciarbusqueda;

    protected void Page_Load(object sender, EventArgs e)
    {
        try { Session["comprobar"] = "si"; } catch { }
        Button22.Enabled = false;
        Button22.Visible = false;
        try
        {
            lblelecusu.Text = Session["persona"].ToString();
            if (Session["persona"].ToString() != null)
            {

                Button22.Enabled = true;
                Button22.Visible = true;
            }
        }
        catch (Exception)
        {

        }

    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        Session.Remove("persona");
        lblelecusu.Text = "Invitado";
        Button22.Enabled = false;
        Button22.Visible = false;
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


    //BOTONES//

    protected void Button1_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "B.C. Rich Tempered Mockingbird Electric Guitar Black Stunner";
        datos();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Cort MBC-1 Matthew Bellamy Signature Electric Guitar Matte Black Rosewood";
        datos();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "D Angelico EX-175 Deluxe Edition Hollowbody Electric Guitar Midnight Matte";
        datos();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "D Angelico EX-DC";
        datos();
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "D Angelico EX - SS";
        datos();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "FG-521 Electric Guitar with Built-in Lighted Learning System";
        datos();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Hofner Shorty Electric Travel Guitar";
        datos();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Mitchell MD200 Double Cutaway Electric Guitar ";
        datos();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Mitchell MS400 Thinline Single-Cutaway Electric Guitar";
        datos();
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Mitchell MD200 Double Cutaway Electric Guitar ";
        datos();
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = " Mitchell MX420 Grand Auditorium Acoustic-Electric Guitar Midnight Black Finish";
        datos();
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue Rocketeer Deluxe Electric Guitar";
        datos();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Rogue RR100 Rocketeer Electric Guitar";
        datos();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "You Rock Guitar 2nd Generation MIDI Guitar ";
        datos();
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "B.C. Rich Mockingbird with Double Locking Tremolo Electric Guitar";
        datos();
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "B.C. Rich Mockingbird Set Neck Electric Guitar";
        datos();
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "B.C. Rich Tempered Mockingbird Electric Guitar Black Stunner";
        datos();
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "B.C. Rich Warbeast with Double Locking Tremolo Electric Guitar Black Devil";
        datos();
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Laguna LE50 Short-Scale Electric Guitar Satin Black";
        datos();
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Hofner Shorty Electric Travel Guitar";
        datos();
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Open Box Hofner Ignition Series Violin Electric Guitar Sunburst";
        datos();
    }
}