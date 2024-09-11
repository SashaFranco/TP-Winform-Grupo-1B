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

        private void DgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // VENTANA QUE LISTA LOS ARTICULOS//
        private void VentanaListarAticulos_Load(object sender, EventArgs e)
        {
            //ArticuloDB db = new ArticuloDB();
            //DgvArticulos.DataSource = db.listar();
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.Listar();
            DgvArticulos.DataSource = ListaArticulo;
            DgvArticulos.Columns["Imagen"].Visible = false;
            cargarImagen(ListaArticulo[0].Imagen);
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.Imagen);
        }

        private void cargarImagen(string imagen)
        {
            try 
            { 
            pictureBoxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArticulos.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
            }
        }
    }
}
