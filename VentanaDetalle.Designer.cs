namespace TP_WinForms_Grupo_1B
{
    partial class VentanaDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxArtiuclo = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Location = new System.Drawing.Point(326, 148);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(399, 354);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulos.TabIndex = 3;
            this.pictureBoxArticulos.TabStop = false;
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(12, 12);
            this.DgvArticulos.MultiSelect = false;
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(1027, 119);
            this.DgvArticulos.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(352, 527);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(166, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "INGRESE EL ID DEL ARTICULO";
            // 
            // textBoxArtiuclo
            // 
            this.textBoxArtiuclo.Location = new System.Drawing.Point(525, 527);
            this.textBoxArtiuclo.Name = "textBoxArtiuclo";
            this.textBoxArtiuclo.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtiuclo.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(369, 569);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(325, 53);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // VentanaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 657);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxArtiuclo);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.DgvArticulos);
            this.Name = "VentanaDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentanaDetalle";
            this.Load += new System.EventHandler(this.VentanaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxArtiuclo;
        private System.Windows.Forms.Button buttonBuscar;
    }
}