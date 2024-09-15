﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

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
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    //aux.Marca.Id = (int)lector["IdMarca"]; // Aca esto no va, sino nuestra consulta da error
                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    //aux.Categoria.Id = (int)lector["IdCategoria"]; // Aca esto no va, sino nuestra consulta da error
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Imagen = (string)lector["ImagenURL"];
                    //if (!(lector["UrlImagen"] is DBNull))
                    //    aux.Imagen = (string)lector["UrlImagen"];

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



        public List<Articulo> Buscar(string codigo, string nombre, string marca, string categoria)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = @"SELECT A.Nombre, A.Codigo, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl AS Imagen FROM ARTICULOS A INNER JOIN MARCAS M ON A.IDMarca = M.Id INNER JOIN CATEGORIAS C ON A.IDCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE A.Nombre = @nombre AND A.Codigo = @codigo AND M.Descripcion = @marca AND C.Descripcion = @categoria";
                datos.setearConsulta(consulta);

                // Esto hace que si no elije anda en el comboBox, la consulta no rompa. El DBnull permite ignorarlo en la consulta
                datos.setearParametro("@nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                datos.setearParametro("@codigo", string.IsNullOrEmpty(codigo) ? (object)DBNull.Value : codigo);
                datos.setearParametro("@marca", string.IsNullOrEmpty(marca) ? (object)DBNull.Value : marca);
                datos.setearParametro("@categoria", string.IsNullOrEmpty(categoria) ? (object)DBNull.Value : categoria);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    //aux.Marca.Id = (int)lector["IdMarca"]; // Aca esto no va, sino nuestra consulta da error
                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    //aux.Categoria.Id = (int)lector["IdCategoria"]; // Aca esto no va, sino nuestra consulta da error
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = (string)datos.Lector["Imagen"];
                    //if (!(lector["UrlImagen"] is DBNull))
                    //    aux.Imagen = (string)lector["UrlImagen"];

                    lista.Add(aux);

                }
            return lista;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hubo un error, intente luego");
            }
            finally 
            {
             datos.cerrarConexion();
            }
            return lista;
        }
           
            
        public void Agregar (Articulo nuevo)
            {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdCategoria,IdMarca,Activo) values (@Codigo,@Nombre,@Descripcion,@Precio,@IdCategoria,@IdMarca,@Activo)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@Activo", 1);
                
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

