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
    public partial class VentanaEliminar : Form
    {
        private List<Articulo> ListaArticulo;
        public VentanaEliminar()
        {
            InitializeComponent();
            buttonEliminar.Visible = false;
        }

        private void VentanaEliminar_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id;
            string input = textBoxArtiuclo.Text;

            if (int.TryParse(input, out id))
            {
                id = int.Parse(textBoxArtiuclo.Text);
                ArticuloNegocio negocio = new ArticuloNegocio();
                ListaArticulo = negocio.BuscarDetalle(id);
                DgvArticulos.DataSource = ListaArticulo;

                if (ListaArticulo.Count!=0)
                {
                    buttonEliminar.Visible = true;

                try
                {
                    pictureBoxArticulos.Load(ListaArticulo[0].Imagen);
                }
                catch (Exception ex)
                {
                    pictureBoxArticulos.Load("https://i0.wp.com/msrwilo.com/wp-content/uploads/2023/10/placeholder-1-1.png?ssl=1");
                }
                }
                else
                {
                    buttonEliminar.Visible = false;
                }
                try
                {
                    pictureBoxArticulos.Load(ListaArticulo[0].Imagen);
                }
                catch (Exception ex)
                {
                    pictureBoxArticulos.Load("https://i0.wp.com/msrwilo.com/wp-content/uploads/2023/10/placeholder-1-1.png?ssl=1");
                }

                //DgvArticulos.Columns["Imagen"].Visible = false;
                //MessageBox.Show("ID válido: " + id.ToString());
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido.");
                textBoxArtiuclo.Clear();
                textBoxArtiuclo.Focus();
                buttonEliminar.Visible=false;
            } 
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id;
            ArticuloNegocio aux = new ArticuloNegocio();
            id = int.Parse(textBoxArtiuclo.Text);
            if (ListaArticulo != null && ListaArticulo.Count > 0)
            {
            Articulo articuloElimnar = ListaArticulo[0];

            // Este objeto permite crear un MesseageBox con opcion de Si y No para tomarlo como true y false
            DialogResult resultado = 
            MessageBox.Show(
            $"¿Estás seguro de que deseas eliminar el artículo '{articuloElimnar.Nombre}'?","Confirmar Eliminación", 
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            
                if (resultado == DialogResult.Yes) 
                {
                    aux.Eliminar(articuloElimnar);
                    MessageBox.Show("Articulo Eliminado");
                }
        }
    }
}
}
