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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            Elemento marca = new Elemento();
            Elemento categoria = new Elemento();
            ArticuloNegocio nego = new ArticuloNegocio();
            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescrip.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.Categoria = (Elemento)cboCategoria.SelectedItem;
                art.Marca = (Elemento)cboMarca.SelectedItem;
                //art.Imagen = "https://i0.wp.com/msrwilo.com/wp-content/uploads/2023/10/placeholder-1-1.png?ssl=1";
                nego.Agregar(art);
                ImagenNegocio imagen = new ImagenNegocio();
                imagen.CargarImagen();
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error....");
            }

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            ElementoNegocio articuloNegocio = new ElementoNegocio();

            try
            {
                cboCategoria.DataSource = articuloNegocio.listar("Select Id, Descripcion from CATEGORIAS");
                cboMarca.DataSource = articuloNegocio.listar("Select Id, Descripcion from MARCAS");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
