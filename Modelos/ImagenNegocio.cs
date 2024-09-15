using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForms_Grupo_1B.Modelos
{
    public class ImagenNegocio
    {
        public void CargarImagen()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulo aux = new Articulo();
            AccesoDatos datos = new AccesoDatos();
            aux = articulo.BuscarUltimoArticulo();
            try
            {
                string consulta = "insert into IMAGENES(IdArticulo,ImagenUrl)values(@id,@url)";
                datos.setearConsulta(consulta);
                datos.setearParametro("@id", aux.Id);
                datos.setearParametro("@url", "https://i0.wp.com/msrwilo.com/wp-content/uploads/2023/10/placeholder-1-1.png?ssl=1");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pude cargar imagen");
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
