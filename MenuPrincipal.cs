using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TP_WinForms_Grupo_1B.Modelos;


namespace TP_WinForms_Grupo_1B
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //ArticuloDB db = new ArticuloDB();
            //dgvArticulos.DataSource = db.listar();
        }
        
        private void ButtonListar_Click(object sender, EventArgs e)
        {
            VentanaListarAticulos Ventana= new VentanaListarAticulos();
            Ventana.ShowDialog();

            //int codigo = int.Parse(textBoxCodigo.Text);
            //string nombre = textBoxNombre.Text;
            //string descripcion = textBoxDescripcion.Text;
            //string marca = textBoxMarca.Text;
            //string categoria = textBoxCategoria.Text;
            //string imagen = textBoxImagen.Text; // Asume que la imagen es un path en un TextBox
            //decimal precio = decimal.Parse(textBoxPrecio.Text);

            //Articulo nuevoArticulo = new Articulo(codigo, nombre, descripcion, marca, categoria, imagen, precio);
            //MessageBox.Show(nuevoArticulo.ToString(), "Artículo Guardado");
        }


        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Form VentanaBuscar = new Form();
            VentanaBuscar.ShowDialog();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Form VentanaAgregar = new Form();
            VentanaAgregar.ShowDialog();
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            Form VentanaModificar = new Form();
            VentanaModificar.ShowDialog();
        }

        private void ButtonEliminarArticulo_Click(object sender, EventArgs e)
        {
            Form VentanaEliminar = new Form();
            VentanaEliminar.ShowDialog();
        }

        private void ButtonDetalle_Click(object sender, EventArgs e)
        {
            Form VentanaDetalle = new Form();
            VentanaDetalle.ShowDialog();
        }
        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
