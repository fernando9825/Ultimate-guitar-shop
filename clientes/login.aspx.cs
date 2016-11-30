using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class clientes_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if(Session["persona"].ToString() != null)
            {
                Response.Redirect("../default.aspx");
            }
            else
            {
                
            }
        }
        catch (Exception)
        {
            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        conexion con = new conexion();
      
        con.busca = loginusuario.Text;
        con.buscar();
        if (con.busca == loginusuario.Text & con.contra == logincontra.Text)
        {

            Session["persona"] = con.nombre + " " + con.apellido;
            Session["nombrecliente"] = con.nombre;
            Session["apellidocliente"] = con.apellido;
            
            Response.Redirect("../default.aspx");          
            
        }
        if (con.contra == logincontra.Text)
        {
            string script = "alert('Hola " + con.nombre + " " + con.apellido + " Bienvenido! ')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script, true);
            
          
           
        }
        else
        {
            string script = "alert('Lo sentimos :( nombre de usuario o contraseña incorrectos')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script, true);
        }
    }
}