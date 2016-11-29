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

    protected void Button1_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Breedlove Pursuit Nylon Acoustic-Electric Guitar Natural";
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("/compra-facturacion/compra.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Acoustic Guitar Natural";
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("/compra-facturacion/compra.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Jasmine S-34C Cutaway Acoustic Guitar Natural";
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("/compra-facturacion/compra.aspx");
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Luna Guitars Gypsy Spalt Grand Auditorium Acoustic-Electric Guitar  ";
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("/compra-facturacion/compra.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Luna Guitars Muse Safari Series Mahogany 3/4 Dreadnought Travel Acoustic Guitar Natural";
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("/compra-facturacion/compra.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        iniciarbusqueda = "Mitchell MO120CESB Acoustic-Electric Cutaway Vintage Sunburst";
        conexion buscar = new conexion();
        buscar.nombreproducto = iniciarbusqueda;
        buscar.buscarproducto();
        Session["nombreproducto"] = buscar.nombreproducto;
        Session["marca"] = buscar.marca;
        Session["descripcion"] = buscar.descripcion;
        Session["precio"] = buscar.precio;
        Session["existencias"] = buscar.existencias;
        Response.Redirect("/compra-facturacion/compra.aspx");
    }
}