using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Button1.Enabled = false;
        Button1.Visible = false;
        Button2.Enabled = false;
        Button2.Visible = false;
        Label1.Enabled = false;
        Label1.Visible = false;

        try
        {
            lblusuario.Text = Session["persona"].ToString();
            if (Session["persona"].ToString() != null)
            {

                Button1.Enabled = true;
                Button1.Visible = true;
                Button2.Enabled = false;
                Button2.Visible = false;
                Label1.Enabled = false;
                Label1.Visible = false;
            }
            if (Session["persona"].ToString() == "Fernando Alvarado")
            {
                Button2.Enabled = true;
                Button2.Visible = true;
                Label1.Enabled = true;
                Label1.Visible = true;
            }
        }
        catch (Exception) { }


            try
            {
                lblusuario.Text = Session["persona"].ToString();

            }
            catch (Exception)
            {

            }
        
      }
        
    

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Remove("persona");
        lblusuario.Text = "invitado";
        Button1.Enabled = false;
        Button1.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("../registro_productos.aspx");

    }
}