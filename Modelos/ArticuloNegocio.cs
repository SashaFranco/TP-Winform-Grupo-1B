using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace TP_WinForms_Grupo_1B.Modelos
{
    //Clase para conecarte a la tabla Articulos de la DB
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
                comando.CommandText = "SELECT A.Id, A.Nombre,Codigo,A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio, I.ImagenUrl FROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Id = I.IdArticulo;";
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
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Imagen = (string)lector["ImagenURL"];

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
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio) values (" + nuevo.Codigo + ",'" + nuevo.Nombre + "' , '" + nuevo.Descripcion + "', nuevo.Precio)");
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

