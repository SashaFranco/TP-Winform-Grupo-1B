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
                comando.CommandText = "SELECT A.Id, A.Nombre, A.Codigo,A.Descripcion, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria, I.ImagenUrl FROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Id = I.IdArticulo;";
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
                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Elemento();
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

        public List<String> comboBoxCodigo()
        {
            List<String> codigo = new List<String>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT DISTINCT Codigo FROM ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    codigo.Add(aux.Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de artículos: {ex.Message}");
            }
            finally
            {
                datos.cerrarConexion();
            }
        
            return codigo;
        }
        public List<String> comboBoxNombre()
        {
            List<String> nombre = new List<String>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT DISTINCT Nombre FROM ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Nombre"];
                    nombre.Add(aux.Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de artículos: {ex.Message}");
            }
            finally
            {
                datos.cerrarConexion();
            }
            return nombre;
        }
        public List<String> comboBoxMarca()
        {
            List<String> Marca = new List<String>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT DISTINCT M.Descripcion AS Marca FROM ARTICULOS A INNER JOIN MARCAS M ON a.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    Marca.Add(aux.Marca.Descripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos de artículos: {ex.Message}");
            }
            finally
            {
                datos.cerrarConexion();
            }
            return Marca;
        }

        public List<String> comboBoxCategoria()
        {
            List<String> Categoria = new List<String>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT DISTINCT C.Descripcion AS Categoria FROM ARTICULOS A INNER JOIN CATEGORIAS C ON a.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    Categoria.Add(aux.Categoria.Descripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos de artículos: {ex.Message}");
            }
            finally
            {
                datos.cerrarConexion();
            }
            return Categoria;
        }



        public List<Articulo> Buscar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try 
            { 

            
            return lista;
            }
            catch(Exception ex) 
            {
                throw ex;
            }

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

