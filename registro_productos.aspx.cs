using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registro_productos : System.Web.UI.Page
{
    conexion con = new conexion();
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {


            if (producto.Text != "" & marca.Text != "" & precio.Text != "" & existencias.Text != "" & descripcion.Text != "")
            {

                string sql = "Insert into Guitarras (producto, marca, precio, existencias, descripcion) values ('" + producto.Text + "','" + marca.Text + "','" + precio.Text + "','" + existencias.Text + "','" + descripcion.Text + "');";
                con.guardar(sql);






                if (sql != null)
                {

                    string script2 = "alert('Datos guardados exitosamente, continua...');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script2, true);
                    borrar();

                }

            }
            else
            {

                string script2 = "alert('Por favor no dejes ninguna casilla en blanco, puesto que todos los campos son requeridos!');";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Informacion", script2, true);
            }
        }



        catch (Exception) { }
    }

    private void borrar()
    {
        producto.Text = "";
        marca.Text = "";
        precio.Text = "";
        existencias.Text = "";
        descripcion.Text = "";
    }
}