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
        public VentanaListarAticulos()
        {
            InitializeComponent();
        }

        private void DgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaListarAticulos_Load(object sender, EventArgs e)
        {
            //ArticuloDB db = new ArticuloDB();
            //DgvArticulos.DataSource = db.listar();
            ArticuloNegocio negocio = new ArticuloNegocio();
            DgvArticulos.DataSource = negocio.Listar();
        }
    }
}
