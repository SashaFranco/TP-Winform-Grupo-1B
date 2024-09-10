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
            //articulodb db = new articulodb();
            //dgvarticulos.datasource = db.listar();
        }
        
        private void ButtonListar_Click(object sender, EventArgs e)
        {
            VentanaListarAticulos Ventana = new VentanaListarAticulos();
            Ventana.ShowDialog();

            //int codigo = int.parse(textboxcodigo.text);
            //string nombre = textboxnombre.text;
            //string descripcion = textboxdescripcion.text;
            //string marca = textboxmarca.text;
            //string categoria = textboxcategoria.text;
            //string imagen = textboximagen.text; // asume que la imagen es un path en un textbox
            //decimal precio = decimal.parse(textboxprecio.text);

            //articulo nuevoarticulo = new articulo(codigo, nombre, descripcion, marca, categoria, imagen, precio);
            //messagebox.show(nuevoarticulo.tostring(), "artículo guardado");
        }


        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Form VentanaBuscar = new Form();
            VentanaBuscar.ShowDialog();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo VentanaAgregar = new AgregarArticulo();
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
