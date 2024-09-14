﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_WinForms_Grupo_1B.Modelos;

namespace TP_WinForms_Grupo_1B
{
    public partial class BuscarArticulo : Form
    {
        private ArticuloNegocio articuloNegocio;
         
        public BuscarArticulo()
        {
            InitializeComponent();
            articuloNegocio = new ArticuloNegocio();
            llenarComboBoxes();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void llenarComboBoxes()
        {
            List<String> codigo = articuloNegocio.comboBoxCodigo();
            List<String> nombre = articuloNegocio.comboBoxNombre();
            List<String> marca = articuloNegocio.comboBoxMarca();
            List<String> categoria = articuloNegocio.comboBoxCategoria();

            comboBoxCodigo.Items.Clear();
            comboBoxNombre.Items.Clear();
            comboBoxMarca.Items.Clear();
            comboBoxCategoria.Items.Clear();
            comboBoxCodigo.Items.AddRange(codigo.ToArray());
            comboBoxNombre.Items.AddRange(nombre.ToArray());
            comboBoxMarca.Items.AddRange(marca.ToArray());
            comboBoxCategoria.Items.AddRange(categoria.ToArray());
        }
        

        private void BuscarArticulo_Load(object sender, EventArgs e)
        {

        }
    }
}
