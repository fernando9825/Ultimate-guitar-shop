using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

/// <summary>
/// Descripción breve de conexion
/// </summary>
public class conexion
{
    public string busca;
    public string contra;
    public string nombre;
    public string apellido;

    //VARIABLES PARA BUSCAR PRODUCTO Y COMPRAR//

    public string nombreproducto;
    public string marca;
    public string descripcion;
    public string precio;
    public string existencias;
    public string nombreparafactura;


    //VARIABLES PARA BUSCAR PRODUCTO Y COMPRAR//
    public string numerofactura;

    /* CONEXION
     * CON
     * BASE DE DATOS */

    SqlConnection con = new SqlConnection("Data Source=.\\express;Initial Catalog=Tiendaguitarras;Integrated Security=True;Pooling=False");
    public SqlCommand comando;

    public object Response { get; private set; }

    //METODO CONECTAR//

    public void conectar()
    {
        try
        {
            con.Open();
        }
        catch
        {

        }
        finally
        {
            con.Close();
        }

    }

    //FIN METODO CONECTAR//

    //METODO GUARDAR

    public void guardar(string sql)
    {
        con.Open();
        comando = new SqlCommand(sql, con);
        int i = comando.ExecuteNonQuery();
        if (i > 0)
        {

        }
        else
        {

        }


    }

    //FIN METODO GUARDAR//

    //METODO GUARDAR//
    public bool eliminar(string elimina)
    {
        con.Open();
        comando = new SqlCommand(elimina, con);
        int i = comando.ExecuteNonQuery();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //FIN METODO GUARDAR

    //METODO ACTUALIZAR

    public bool actualizar(string tabla, string campos, string condicion)
    {
        con.Open();
        string actualizar = "update " + tabla + " set " + campos + " where " + condicion;
        int i = comando.ExecuteNonQuery();
        if (i > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //FIN METODO ACTUALIZAR  


    //BUSCAR
    public void buscar()
    {


        try
        {
            SqlConnection con1 = new SqlConnection("Data Source=.\\express;Initial Catalog=Tiendaguitarras;Integrated Security=True;Pooling=False");
            con1.Open();
            string cadsql = "SELECT *FROM Registro WHERE usuario ='" + busca + "'";
            SqlCommand comando = new SqlCommand(cadsql, con1);
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {
               
                nombre = leer["nombre"].ToString();
                apellido = leer["apellido"].ToString();
                contra = leer["contraseña"].ToString();
                

            }
        }
        catch (Exception)
        {


        }
    }



    //COMPRAR


    public void buscarproducto()
    {


        try
        {
            SqlConnection con2 = new SqlConnection("Data Source = guitarshop.mssql.somee.com; Persist Security Info=True;User ID = fernando9825_SQLLogin_2; Password=8nwapgzhqt");
            con2.Open();
            string cadsql = "select *from Guitarras where producto ='" + nombreproducto + "'";
            SqlCommand comando = new SqlCommand(cadsql, con2);
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {
                
                marca = leer["marca"].ToString();
                precio = leer["precio"].ToString();
                existencias = leer["existencias"].ToString();
                descripcion = leer["descripcion"].ToString();
                

            }
            else
            {
              
            }
        }
        catch (Exception)
        {


        }
    }

    public void Factura()
    {
        try
        {
            SqlConnection con3 = new SqlConnection("Data Source=.\\express;Initial Catalog=Tiendaguitarras;Integrated Security=True;Pooling=False");
            con3.Open();
            string cadsql = "SELECT *FROM Factura WHERE nombre ='" + nombreparafactura + "'";
            SqlCommand comando = new SqlCommand(cadsql, con3);
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {

                numerofactura = leer["Id"].ToString();
                
                
                
            }
        }
        catch (Exception)
        {


        }
    }


}




