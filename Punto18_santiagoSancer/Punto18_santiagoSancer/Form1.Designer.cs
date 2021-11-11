
namespace Punto18_santiagoSancer
{
    partial class Form1
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbPrendas = new System.Windows.Forms.GroupBox();
            this.cbBermuda = new System.Windows.Forms.CheckBox();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.gbCalidadPrenda = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbEstandar = new System.Windows.Forms.RadioButton();
            this.gbPrecio = new System.Windows.Forms.GroupBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.gbCantidad = new System.Windows.Forms.GroupBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.bCalculador = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.gbPrendas.SuspendLayout();
            this.gbCalidadPrenda.SuspendLayout();
            this.gbPrecio.SuspendLayout();
            this.gbCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbTitulo.Location = new System.Drawing.Point(7, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(225, 29);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Ventas al por mayor";
            // 
            // gbPrendas
            // 
            this.gbPrendas.BackColor = System.Drawing.Color.Transparent;
            this.gbPrendas.Controls.Add(this.cbBermuda);
            this.gbPrendas.Controls.Add(this.cbMangaCorta);
            this.gbPrendas.Controls.Add(this.rbPantalon);
            this.gbPrendas.Controls.Add(this.rbCamisa);
            this.gbPrendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbPrendas.Location = new System.Drawing.Point(12, 56);
            this.gbPrendas.Name = "gbPrendas";
            this.gbPrendas.Size = new System.Drawing.Size(231, 105);
            this.gbPrendas.TabIndex = 1;
            this.gbPrendas.TabStop = false;
            this.gbPrendas.Text = "Tipo de Prenda";
            // 
            // cbBermuda
            // 
            this.cbBermuda.AutoSize = true;
            this.cbBermuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBermuda.Location = new System.Drawing.Point(122, 63);
            this.cbBermuda.Name = "cbBermuda";
            this.cbBermuda.Size = new System.Drawing.Size(82, 20);
            this.cbBermuda.TabIndex = 3;
            this.cbBermuda.Text = "Bermuda";
            this.cbBermuda.UseVisualStyleBackColor = true;
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMangaCorta.Location = new System.Drawing.Point(122, 37);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(102, 20);
            this.cbMangaCorta.TabIndex = 2;
            this.cbMangaCorta.Text = "Manga corta";
            this.cbMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPantalon.Location = new System.Drawing.Point(0, 61);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(79, 20);
            this.rbPantalon.TabIndex = 1;
            this.rbPantalon.TabStop = true;
            this.rbPantalon.Text = "Pantalón";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCamisa.Location = new System.Drawing.Point(0, 35);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(72, 20);
            this.rbCamisa.TabIndex = 0;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // gbCalidadPrenda
            // 
            this.gbCalidadPrenda.Controls.Add(this.rbPremium);
            this.gbCalidadPrenda.Controls.Add(this.rbEstandar);
            this.gbCalidadPrenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbCalidadPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalidadPrenda.Location = new System.Drawing.Point(12, 167);
            this.gbCalidadPrenda.Name = "gbCalidadPrenda";
            this.gbCalidadPrenda.Size = new System.Drawing.Size(231, 60);
            this.gbCalidadPrenda.TabIndex = 0;
            this.gbCalidadPrenda.TabStop = false;
            this.gbCalidadPrenda.Text = "Calidad de la prenda";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPremium.Location = new System.Drawing.Point(122, 32);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(79, 20);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbEstandar
            // 
            this.rbEstandar.AutoSize = true;
            this.rbEstandar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstandar.Location = new System.Drawing.Point(6, 32);
            this.rbEstandar.Name = "rbEstandar";
            this.rbEstandar.Size = new System.Drawing.Size(80, 20);
            this.rbEstandar.TabIndex = 0;
            this.rbEstandar.TabStop = true;
            this.rbEstandar.Text = "Estandar";
            this.rbEstandar.UseVisualStyleBackColor = true;
            // 
            // gbPrecio
            // 
            this.gbPrecio.Controls.Add(this.tbPrecio);
            this.gbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrecio.Location = new System.Drawing.Point(18, 245);
            this.gbPrecio.Name = "gbPrecio";
            this.gbPrecio.Size = new System.Drawing.Size(86, 55);
            this.gbPrecio.TabIndex = 2;
            this.gbPrecio.TabStop = false;
            this.gbPrecio.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(13, 21);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(66, 22);
            this.tbPrecio.TabIndex = 2;
            // 
            // gbCantidad
            // 
            this.gbCantidad.Controls.Add(this.tbCantidad);
            this.gbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCantidad.Location = new System.Drawing.Point(134, 245);
            this.gbCantidad.Name = "gbCantidad";
            this.gbCantidad.Size = new System.Drawing.Size(86, 55);
            this.gbCantidad.TabIndex = 3;
            this.gbCantidad.TabStop = false;
            this.gbCantidad.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(13, 21);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(66, 22);
            this.tbCantidad.TabIndex = 0;
            // 
            // bCalculador
            // 
            this.bCalculador.BackColor = System.Drawing.Color.White;
            this.bCalculador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCalculador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bCalculador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bCalculador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.bCalculador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalculador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculador.Location = new System.Drawing.Point(18, 318);
            this.bCalculador.Name = "bCalculador";
            this.bCalculador.Size = new System.Drawing.Size(218, 51);
            this.bCalculador.TabIndex = 4;
            this.bCalculador.Text = "Calcular precio final.";
            this.bCalculador.UseVisualStyleBackColor = false;
            this.bCalculador.Click += new System.EventHandler(this.bCalculador_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbError.Location = new System.Drawing.Point(65, 291);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(109, 13);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "Tipo de dato inválido.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(268, 381);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.bCalculador);
            this.Controls.Add(this.gbCantidad);
            this.Controls.Add(this.gbPrecio);
            this.Controls.Add(this.gbCalidadPrenda);
            this.Controls.Add(this.gbPrendas);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Calculador de venta";
            this.gbPrendas.ResumeLayout(false);
            this.gbPrendas.PerformLayout();
            this.gbCalidadPrenda.ResumeLayout(false);
            this.gbCalidadPrenda.PerformLayout();
            this.gbPrecio.ResumeLayout(false);
            this.gbPrecio.PerformLayout();
            this.gbCantidad.ResumeLayout(false);
            this.gbCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbPrendas;
        private System.Windows.Forms.CheckBox cbMangaCorta;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.CheckBox cbBermuda;
        private System.Windows.Forms.GroupBox gbCalidadPrenda;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbEstandar;
        private System.Windows.Forms.GroupBox gbPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.GroupBox gbCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button bCalculador;
        private System.Windows.Forms.Label lbError;
    }
}