using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_WinForms_Grupo_1B.Modelos;

namespace TP_WinForms_Grupo_1B
{
    public partial class VentanaListarAticulos : Form
    {
        private List<Articulo> ListaArticulo;
        public VentanaListarAticulos()
        {
            InitializeComponent();
        }

        // VENTANA QUE LISTA LOS ARTICULOS//
        private void VentanaListarAticulos_Load(object sender, EventArgs e)
        {
            //ArticuloDB db = new ArticuloDB();
            //DgvArticulos.DataSource = db.listar();

            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.Listar();
            DgvArticulos.DataSource = ListaArticulo;
            pictureBoxArticulos.Load(ListaArticulo[0].Imagen);
            DgvArticulos.Columns["Imagen"].Visible = false;

            //cargarImagen(ListaArticulo[0].Imagen);
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.Imagen);
        }

        // metodo para cargar imagenes. Aparece imagen generica si falla
        private void cargarImagen(string imagen)
        {
            try 
            { 
            pictureBoxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArticulos.Load("https://i0.wp.com/msrwilo.com/wp-content/uploads/2023/10/placeholder-1-1.png?ssl=1");
            }
        }
    }
}
