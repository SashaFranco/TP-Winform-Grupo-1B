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
using static System.Net.Mime.MediaTypeNames;

namespace TP_WinForms_Grupo_1B
{
    public partial class VentanaDetalle : Form
    {
        private List<Articulo> ListaArticulo;
        public VentanaDetalle()
        {
            InitializeComponent();
        }

        private void VentanaDetalle_Load(object sender, EventArgs e)
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
            }
        }
    }
}
