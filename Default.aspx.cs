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
        try
        {
            lblusuario.Text = Session["persona"].ToString();
            if (Session["persona"].ToString() != null)
            {

                Button1.Enabled = true;
                Button1.Visible = true;
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
}