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
            ArticuloNegocio nego = new ArticuloNegocio();
            try
            {
                art.Codigo =txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescrip.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.Categoria = (Elemento)cboCategoria.SelectedItem;
                art.Marca = (Elemento)cboMarca.SelectedItem;

                nego.Agregar(art);
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
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                cboCategoria.DataSource = articuloNegocio.Listar();
                cboMarca.DataSource = articuloNegocio.Listar();
                cboCategoria.DisplayMember = "Categoria"; 
                //cboCategoria.ValueMember = "IdCategoria";
                cboMarca.DisplayMember = "Marca";     
                //cboMarca.ValueMember = "IdMarca";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }

        }

        
    }
}
