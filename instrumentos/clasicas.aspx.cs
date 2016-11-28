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
}