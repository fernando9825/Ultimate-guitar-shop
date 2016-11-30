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
        btninicar.Enabled = false;
        btninicar.Visible = false;
        btnregistrar.Enabled = false;
        btnregistrar.Visible = false;
        lblinformacion.Visible = false;
        Session["aviso"] = "Lo sentimos, sera necesario que inicies sesión o registrarte para que puedas llevar a cabo la comprar del producto.";

        try
        {
            
            if (Session["comprobar"].ToString() != null & Session["persona"] == null)
             {
                btninicar.Enabled = true;
                btninicar.Visible = true;
                btnregistrar.Enabled = true;
                btnregistrar.Visible = true;
                lblinformacion.Visible = true;
                lblinformacion.Enabled = true;
                lblinformacion.Text = Session["aviso"].ToString();
                Session.Remove("comprobar");
            }
            else
            {
                Session["comprobar"] = "si";
            }
       
    }
        catch { }

        
        try
        {
            lblproducto.Text = Session["nombreproducto"].ToString();
            lblmarca.Text = Session["marca"].ToString();
            lblprecio.Text = "$ " + Session["precio"].ToString();
            lbldescripcion.Text = Session["descripcion"].ToString();
            lblexistencias.Text = Session["existencias"].ToString();
        }
        catch { }


        //Imagenes//
        //Guitarras Acusticas//
        if (lblproducto.Text == "Breedlove Pursuit Nylon Acoustic-Electric Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/breedlove pursuit.png";
        }
        if (lblproducto.Text == "Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/hohner hag.png";
        }
        if (lblproducto.Text == "Jasmine S-34C Cutaway Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/jasmine cutaway.png";
        }
        if (lblproducto.Text == "Luna Guitars Gypsy Spalt Grand Auditorium Acoustic-Electric Guitar  ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/luna guitars gypsy.png";
        }
        if (lblproducto.Text == "Luna Guitars Muse Safari Series Mahogany 3/4 Dreadnought Travel Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/luna guitars muse safari.png";
        }
        if (lblproducto.Text == "Mitchell MO120CESB Acoustic-Electric Cutaway Vintage Sunburst")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/mitchell acoustic-electric cutaway.png";
        }
        if (lblproducto.Text == "Mitchell MD100 Dreadnought Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/mitchell md100.png";
        }
        if (lblproducto.Text == " Mitchell MX420 Grand Auditorium Acoustic-Electric Guitar Midnight Black Finish")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/mitchell mx420.png";
        }
        if (lblproducto.Text == "Rogue RA-100D Dreadnought Acoustic Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/rogue blue.png";
        }
        if (lblproducto.Text == "Rogue Starter Acoustic Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/rogue concert.png";
        }
        if (lblproducto.Text == "Rogue RA-090 Concert Acoustic Guitar  ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/Rogue Ra 090 Dreadnought guitarra acustica  $49.97.png";
        }
        if (lblproducto.Text == "Rogue RG-624 Left-Handed Dreadnought Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/rogue rg 624.png";
        }
        if (lblproducto.Text == "Rogue RA-090 Concert Acoustic Guitar  ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/rogue starter acoustic guitar.png";
        }
        if (lblproducto.Text == "Rogue RD80 Dreadnought Acoustic Guitar  ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/rogue yellow.png";
        }
        if (lblproducto.Text == " Savannah Savannah SO-SGD-10C Dreadnought Acoustic-Electric Guitar Black")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/savannah sdg 10.png";
        }
        if (lblproducto.Text == "Rogue RA-100D Dreadnought Acoustic Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/rogue cutawat.png";
        }
        if (lblproducto.Text == " Alvarez 50th Anniversary AFA1965 OM/Folk Acoustic Guitar Sunburst")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/alvarez 50th anniversary.png";
        }
        if (lblproducto.Text == "Alvarez AG610CESHB Grand Auditorium Acoustic-Electric Guitar Shadow Burst")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/alvarez grand.png";
        }
        if (lblproducto.Text == "Alvarez RP266EBK Parlor Acoustic-Electric Guitar Black")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/alvarez parlor.png";
        }
        if (lblproducto.Text == "Luna Guitars Vista Eagle 12-String Acoustic-Electric Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/luna guitars vista eagle.png";
        }
        if (lblproducto.Text == " Recording King Dirty Thirties OOO Solid Top Satin Sunburst")
        {
            imagenproducto.ImageUrl = "~/imagenes/Acusticas/recording king dirty.png";
        }

        //FIN GUITARRAS ACUSTICAS//

        //IMAGENES DE GUITARRAS ELECTRICAS//

        if (lblproducto.Text == "B.C. Rich Tempered Mockingbird Electric Guitar Black Stunner")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/b.c. rich tempered.png";
        }
        if (lblproducto.Text == "Cort MBC-1 Matthew Bellamy Signature Electric Guitar Matte Black Rosewood")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/cort mbc.png";
        }
        if (lblproducto.Text == "Cort MBC-1 Matthew Bellamy Signature Electric Guitar Matte Black Rosewood")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/cort mbc.png";
        }
        if (lblproducto.Text == "D Angelico EX-175 Deluxe Edition Hollowbody Electric Guitar Midnight Matte")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/D'Angelico EX-175.png";
        }
        if (lblproducto.Text == "D Angelico EX-DC")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/D'Angelico EX-175.png";
        }
        if (lblproducto.Text == "D Angelico EX - SS")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/D'Angelico EX-SS Deluxe.png";
        }
        if (lblproducto.Text == "FG-521 Electric Guitar with Built-in Lighted Learning System")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/fg-521.png";
        }
        if (lblproducto.Text == "Hofner Shorty Electric Travel Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/hofner shorty.png";
        }
        if (lblproducto.Text == "Mitchell MD200 Double Cutaway Electric Guitar ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/mitchell md200.png";
        }
        if (lblproducto.Text == "Mitchell MS400 Thinline Single-Cutaway Electric Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/mitchell md400 modern rock.png";
        }
        if (lblproducto.Text == "Mitchell MD200 Double Cutaway Electric Guitar ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/mitchell mm100.png";
        }
        if (lblproducto.Text == " Mitchell MX420 Grand Auditorium Acoustic-Electric Guitar Midnight Black Finish")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/mitchell ms400.png";
        }
        if (lblproducto.Text == "Rogue Rocketeer Deluxe Electric Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/rogue rocketeer deluxe.png";
        }
        if (lblproducto.Text == "Rogue RR100 Rocketeer Electric Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/rogue rocketeer.png";
        }
        if (lblproducto.Text == "You Rock Guitar 2nd Generation MIDI Guitar ")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/you rock midi guitar.png";
        }
        if (lblproducto.Text == "B.C. Rich Mockingbird with Double Locking Tremolo Electric Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/rich mockingbird.png";
        }
        if (lblproducto.Text == "B.C. Rich Mockingbird Set Neck Electric Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/rich set neck.png";
        }
        if (lblproducto.Text == "B.C. Rich Tempered Mockingbird Electric Guitar Black Stunner")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/rich warbeast with double tremolo.png";
        }
        if (lblproducto.Text == "B.C. Rich Warbeast with Double Locking Tremolo Electric Guitar Black Devil")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/rick warlock with double tremolo.png";
        }
        if (lblproducto.Text == "Laguna LE50 Short-Scale Electric Guitar Satin Black")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/laguna le50.png";
        }
        if (lblproducto.Text == "Hofner Shorty Electric Travel Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/Open Box D.png";
        }
        if (lblproducto.Text == "Open Box Hofner Ignition Series Violin Electric Guitar Sunburst")
        {
            imagenproducto.ImageUrl = "~/imagenes/Electricas/open box series violin.png";
        }

        //IMAGES DE GUITARRAS ELECTRICAS, TERMINADAS//

        //IMAGENES DE GUITARRAS CLASICAS//

        if (lblproducto.Text == " Kremona Romida Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/alvarez artist series.png";
        }
        if (lblproducto.Text == " Cordoba C9 CD/MH Acoustic Nylon String Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/breedlove pursuit nylon.png";
        }
        if (lblproducto.Text == " Cordoba C9 CD/MH Acoustic Nylon String Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/hofner a.png";
        }
        if (lblproducto.Text == " Cordoba C9 CD/MH Acoustic Nylon String Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/hofner a.png";
        }
        if (lblproducto.Text == "Hofner Solid Cedar Top Mahogany Body Classical Acoustic Guitar Matte Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/hofner solid cedar.png";
        }
        if (lblproducto.Text == "Hofner Solid Cedar Top Mahogany Body Classical Acoustic Guitar Matte Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/hofner solid cedar.png";
        }
        if (lblproducto.Text == "Kremona Fiesta CW-7 Classical Electric Guitar Gloss Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona fiesta.png";
        }
        if (lblproducto.Text == "Kremona Rosa Morena Classical Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona rosa morena.png";
        }
        if (lblproducto.Text == "Kremona Soloist S65C Classical Acoustic Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona solois.png";
        }
        if (lblproducto.Text == " Kremona Rosa Luna Flamenco Acoustic-Electric Nylon Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona verea cutaway.png";
        }
        if (lblproducto.Text == "Lucero LFB250Sce Spruce/Cypress Thinline Acoustic-Electric Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero cypress.png";
        }
        if (lblproducto.Text == "Lucero LC230S Exotic wood Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero exotic wood.png";
        }
        if (lblproducto.Text == "Lucero LC230S Exotic wood Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero exotic wood.png";
        }
        if (lblproducto.Text == "Lucero LC230S Exotic wood Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero exotic wood.png";
        }
        if (lblproducto.Text == "Lucero LC100CE Acoustic-Electric Cutaway Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero lc100.png";
        }
        if (lblproducto.Text == "Lucero LFN200Sce Spruce/Rosewood Thinline Acoustic-Electric Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero lc100ce.png";
        }
        if (lblproducto.Text == " Lucero LC150Sce Spruce/Sapele Cutaway Acoustic-Electric Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero lc150s.png";
        }
        if (lblproducto.Text == "Cordoba Solista CD/IN Acoustic Nylon String Classical Guitar")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero rosewood.png";
        }
        if (lblproducto.Text == " Kremona 90th Anniversary Nylon String Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lucero spruce.png";
        }
        if (lblproducto.Text == "Lyons Classroom Guitar  ")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/lyons classroom guitar.png";
        }
        if (lblproducto.Text == "Kremona Sofia S63CW Classical Acoustic-Electric Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona sofia s63cw.png";
        }
        if (lblproducto.Text == " Yamaha C40 Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona rosa luna flamenco.png";
        }
        if (lblproducto.Text == "Espana Classical Guitar Natural")
        {
            imagenproducto.ImageUrl = "~/imagenes/clasicas/kremona rondo.png";
        }

        //FIN DE IMAGENES CLASICAS//
    }



    protected void btncomprar_Click(object sender, EventArgs e)
    {
        Session["comprobar"] = "si";
        redireccionar();
    }
    public int verficar = 0;
    public void redireccionar()
    {

        
        try
        {
            
            if (Session["persona"].ToString() == null)
            {  
               Session["comprobar"] = "si";
                btninicar.Enabled = true;
                btninicar.Visible = true;
                btnregistrar.Enabled = true;
                btnregistrar.Visible = true;
                lblinformacion.Visible = true;
                lblinformacion.Enabled = true;
                lblinformacion.Text = Session["aviso"].ToString();
            }
            else
            {
                Response.Redirect("../compra-facturacion/factura.aspx");
                Session.Remove("comprobar");
            }
            
        }
        catch (Exception)
        {

        }


    }

    public void mensaje()
    {
        string script6 = "alert('Hola, ... disculpa las molestias, sera necesario que te registres para proceder con la compra')";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script6, true);
    }
}





