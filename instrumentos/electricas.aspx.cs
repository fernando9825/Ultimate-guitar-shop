using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class instrumentos_electricas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
}