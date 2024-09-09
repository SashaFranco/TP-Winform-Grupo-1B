using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string codi = txtCodigo.Text;
            string descrip = txtDescrip.Text;   
            string nom = txtNombre.Text;
            string Precio = txtPrecio.Text;
            lvListar.Items.Add(codi);
            lvListar.Items.Add(descrip);
            lvListar.Items.Add(nom);
            lvListar.Items.Add(Precio);
        }

        

        

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
