using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace TP_WinForms_Grupo_1B
{
    class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);

                }
               
            }
            catch (Exception )
            {

                MessageBox.Show("Hubo un error...");
               
            }
            conexion.Close();
            return lista;







        }
            public void Agregar (Articulo nuevo)
            {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(" insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio) values (" + nuevo.Codigo + ",'" + nuevo.Nombre + "' , '" + nuevo.Descripcion + "', nuevo.Precio)");
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        
        
        
        
        
     }



 }

