using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class clientes_registrarse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["persona"].ToString() != null)
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

    public string cliente;
    
    conexion con = new conexion();
    protected void registrarse_Click(object sender, EventArgs e)
    {
        try
        {


            if (txtnombre.Text != "" & txtapellido.Text != "" & txtusuario.Text != "" & txtapellido.Text != "")
            {

                string sql = "Insert into Registro (nombre, apellido, usuario, contraseña) values ('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtusuario.Text + "','" + txtcontraseña.Text + "');";
                con.guardar(sql);
                string script = "alert(\"Hello!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
               "ServerControlScript", script, true);


                //CAMBIOS
                Session["persona"] = con.nombre + " " + con.apellido;



                if (sql != null)
                {

                    Response.Redirect("/instrumentos/acusticas.aspx");

                }

            }
            else
            {

                string script2 = "alert('Por favor no dejes ninguna casilla en blanco, puesto que todos los campos son requeridos!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script2, true);
            }


        }





        catch (Exception )
        {

            string script5 = "alert('No se pudo guardar, Intenta rellenar todas las casillas, ya que son campos obligatorios');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script5, true);
        }
        finally
        {




        }

    }
}
