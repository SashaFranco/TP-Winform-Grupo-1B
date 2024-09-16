using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TP_WinForms_Grupo_1B.Modelos;

namespace TP_WinForms_Grupo_1B
{
    public partial class VentanaModificar : Form
    {
        private Elemento elemento;
        private List<Articulo> ListaArticulo;
        private ArticuloNegocio articuloNegocio;
        public VentanaModificar()
        {
            InitializeComponent();
            articuloNegocio= new ArticuloNegocio();
            llenarComboBox();
        }

        private void VentanaModificar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ElementoNegocio elemento = new ElementoNegocio();
            try
            {
                cboCategoriaMod.DataSource = elemento.listar("Select Id, Descripcion from CATEGORIAS");
                cboMarcaMod.DataSource = elemento.listar("Select Id, Descripcion from MARCAS");
                ListaArticulo = negocio.Listar();
            dgvModificar.DataSource = ListaArticulo;
                dgvModificar.Columns["Imagen"].Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void llenarComboBox()
        {
            //    ElementoNegocio elemento = new ElementoNegocio();
            //    cboCategoriaMod.DataSource = elemento.listar("Select Id, Descripcion from CATEGORIAS");
            //    cboMarcaMod.DataSource = elemento.listar("Select Id, Descripcion from MARCAS");
            //List<String> marca = articuloNegocio.comboBoxMarca();
            //List<String> categoria = articuloNegocio.comboBoxCategoria();

            //cboMarcaMod.Items.Clear();
            //cboCategoriaMod.Items.Clear();
            //cboMarcaMod.Items.AddRange(marca.ToArray());
            //cboCategoriaMod.Items.AddRange(categoria.ToArray());

        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvModificar.CurrentRow.DataBoundItem;
            if (dgvModificar.SelectedRows.Count > 0)
            {
                Articulo aux= new Articulo();
                aux.Id=seleccionado.Id;
                aux.Marca = new Elemento();
                aux.Categoria = new Elemento();
                aux.Codigo = txtCodigoMod.Text;
                aux.Nombre = txtNombreMod.Text;
                aux.Descripcion = txtDescripMod.Text;
                aux.Precio = decimal.Parse(txtPrecioMod.Text);
                aux.Imagen = seleccionado.Imagen;
                
                aux.Marca = (Elemento)cboMarcaMod.SelectedItem;
                aux.Categoria=(Elemento)cboCategoriaMod.SelectedItem;
                articuloNegocio.Modificar(aux);
                
                MessageBox.Show("Modificado con exito");
                Close();


            }

        }

        private void dgvModificar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvModificar.CurrentRow.DataBoundItem;
            txtNombreMod.Text=seleccionado.Nombre.ToString();
            txtCodigoMod.Text=seleccionado.Codigo.ToString();
            txtDescripMod.Text=seleccionado.Descripcion.ToString();
            txtPrecioMod.Text=seleccionado.Precio.ToString();
            cboMarcaMod.Text=seleccionado.Marca.Descripcion.ToString() ;
            cboCategoriaMod.Text=seleccionado.Categoria.Descripcion.ToString() ;
            

        }
    }
}
