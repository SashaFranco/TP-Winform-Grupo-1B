namespace TP_WinForms_Grupo_1B
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonListar = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.ButtonEliminarArticulo = new System.Windows.Forms.Button();
            this.ButtonDetalle = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.buscarArtículoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.agregarArtículoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.detalleToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // buscarArtículoToolStripMenuItem
            // 
            this.buscarArtículoToolStripMenuItem.Name = "buscarArtículoToolStripMenuItem";
            this.buscarArtículoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.buscarArtículoToolStripMenuItem.Text = "Buscar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // agregarArtículoToolStripMenuItem
            // 
            this.agregarArtículoToolStripMenuItem.Name = "agregarArtículoToolStripMenuItem";
            this.agregarArtículoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarArtículoToolStripMenuItem.Text = "Agregar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.detalleToolStripMenuItem.Text = "Detalle";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.creditosToolStripMenuItem.Text = "Creditos";
            // 
            // ButtonListar
            // 
            this.ButtonListar.Location = new System.Drawing.Point(287, 139);
            this.ButtonListar.Name = "ButtonListar";
            this.ButtonListar.Size = new System.Drawing.Size(315, 29);
            this.ButtonListar.TabIndex = 1;
            this.ButtonListar.Text = "Listar Artículos";
            this.ButtonListar.UseVisualStyleBackColor = true;
            this.ButtonListar.Click += new System.EventHandler(this.ButtonListar_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(350, 90);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(195, 29);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "MENU PRINCIPAL";
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(287, 174);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(315, 29);
            this.ButtonBuscar.TabIndex = 3;
            this.ButtonBuscar.Text = "Buscar Artículo x Criterios";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.Location = new System.Drawing.Point(287, 209);
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(315, 29);
            this.ButtonAgregar.TabIndex = 4;
            this.ButtonAgregar.Text = "Agregar Artículo";
            this.ButtonAgregar.UseVisualStyleBackColor = true;
            this.ButtonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.Location = new System.Drawing.Point(287, 244);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(315, 29);
            this.ButtonModificar.TabIndex = 5;
            this.ButtonModificar.Text = "Modificar Artículo";
            this.ButtonModificar.UseVisualStyleBackColor = true;
            this.ButtonModificar.Click += new System.EventHandler(this.ButtonModificar_Click);
            // 
            // ButtonEliminarArticulo
            // 
            this.ButtonEliminarArticulo.Location = new System.Drawing.Point(287, 279);
            this.ButtonEliminarArticulo.Name = "ButtonEliminarArticulo";
            this.ButtonEliminarArticulo.Size = new System.Drawing.Size(315, 29);
            this.ButtonEliminarArticulo.TabIndex = 6;
            this.ButtonEliminarArticulo.Text = "Eliminar Artículo";
            this.ButtonEliminarArticulo.UseVisualStyleBackColor = true;
            this.ButtonEliminarArticulo.Click += new System.EventHandler(this.ButtonEliminarArticulo_Click);
            // 
            // ButtonDetalle
            // 
            this.ButtonDetalle.Location = new System.Drawing.Point(287, 314);
            this.ButtonDetalle.Name = "ButtonDetalle";
            this.ButtonDetalle.Size = new System.Drawing.Size(315, 29);
            this.ButtonDetalle.TabIndex = 7;
            this.ButtonDetalle.Text = "Ver detalle de un Artículo";
            this.ButtonDetalle.UseVisualStyleBackColor = true;
            this.ButtonDetalle.Click += new System.EventHandler(this.ButtonDetalle_Click);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalir.Location = new System.Drawing.Point(287, 382);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(315, 50);
            this.ButtonSalir.TabIndex = 8;
            this.ButtonSalir.Text = "SALIR";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 522);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.ButtonDetalle);
            this.Controls.Add(this.ButtonEliminarArticulo);
            this.Controls.Add(this.ButtonModificar);
            this.Controls.Add(this.ButtonAgregar);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.ButtonListar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de artículos";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.Button ButtonListar;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonModificar;
        private System.Windows.Forms.Button ButtonEliminarArticulo;
        private System.Windows.Forms.Button ButtonDetalle;
        private System.Windows.Forms.Button ButtonSalir;
    }
}

