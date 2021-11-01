
namespace Electrodomesticos
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.groupOpcionesSeleccion = new System.Windows.Forms.GroupBox();
            this.labelTelevisor = new System.Windows.Forms.Label();
            this.labelLavadora = new System.Windows.Forms.Label();
            this.labelElectrodomestico = new System.Windows.Forms.Label();
            this.radioTelevisor = new System.Windows.Forms.RadioButton();
            this.radioLavadora = new System.Windows.Forms.RadioButton();
            this.radioElectrodomestico = new System.Windows.Forms.RadioButton();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.groupElectrodomestico = new System.Windows.Forms.GroupBox();
            this.groupLavadora = new System.Windows.Forms.GroupBox();
            this.labelCarga = new System.Windows.Forms.Label();
            this.boxCarga = new System.Windows.Forms.TextBox();
            this.groupTV = new System.Windows.Forms.GroupBox();
            this.radioSintonizadorFalse = new System.Windows.Forms.RadioButton();
            this.radioSintonizadorTrue = new System.Windows.Forms.RadioButton();
            this.labelSintonizador = new System.Windows.Forms.Label();
            this.boxResolucion = new System.Windows.Forms.TextBox();
            this.labelResolucion = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelConsumo = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.boxConsumo = new System.Windows.Forms.TextBox();
            this.boxPeso = new System.Windows.Forms.TextBox();
            this.boxColor = new System.Windows.Forms.TextBox();
            this.labelPrecioBase = new System.Windows.Forms.Label();
            this.boxPrecioBase = new System.Windows.Forms.TextBox();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelResultadoBoton = new System.Windows.Forms.Label();
            this.labelElementosAniadidos = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonEliminarElemento = new System.Windows.Forms.Button();
            this.labelCostosFinales = new System.Windows.Forms.Label();
            this.groupOpcionesSeleccion.SuspendLayout();
            this.groupElectrodomestico.SuspendLayout();
            this.groupLavadora.SuspendLayout();
            this.groupTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOpcionesSeleccion
            // 
            this.groupOpcionesSeleccion.BackColor = System.Drawing.SystemColors.Control;
            this.groupOpcionesSeleccion.Controls.Add(this.labelTelevisor);
            this.groupOpcionesSeleccion.Controls.Add(this.labelLavadora);
            this.groupOpcionesSeleccion.Controls.Add(this.labelElectrodomestico);
            this.groupOpcionesSeleccion.Controls.Add(this.radioTelevisor);
            this.groupOpcionesSeleccion.Controls.Add(this.radioLavadora);
            this.groupOpcionesSeleccion.Controls.Add(this.radioElectrodomestico);
            this.groupOpcionesSeleccion.Controls.Add(this.labelSeleccion);
            this.groupOpcionesSeleccion.Location = new System.Drawing.Point(12, 12);
            this.groupOpcionesSeleccion.Name = "groupOpcionesSeleccion";
            this.groupOpcionesSeleccion.Size = new System.Drawing.Size(473, 58);
            this.groupOpcionesSeleccion.TabIndex = 0;
            this.groupOpcionesSeleccion.TabStop = false;
            // 
            // labelTelevisor
            // 
            this.labelTelevisor.AutoSize = true;
            this.labelTelevisor.Location = new System.Drawing.Point(396, 35);
            this.labelTelevisor.Name = "labelTelevisor";
            this.labelTelevisor.Size = new System.Drawing.Size(50, 13);
            this.labelTelevisor.TabIndex = 7;
            this.labelTelevisor.Text = "Televisor";
            // 
            // labelLavadora
            // 
            this.labelLavadora.AutoSize = true;
            this.labelLavadora.Location = new System.Drawing.Point(208, 35);
            this.labelLavadora.Name = "labelLavadora";
            this.labelLavadora.Size = new System.Drawing.Size(52, 13);
            this.labelLavadora.TabIndex = 6;
            this.labelLavadora.Text = "Lavadora";
            // 
            // labelElectrodomestico
            // 
            this.labelElectrodomestico.AutoSize = true;
            this.labelElectrodomestico.Location = new System.Drawing.Point(6, 35);
            this.labelElectrodomestico.Name = "labelElectrodomestico";
            this.labelElectrodomestico.Size = new System.Drawing.Size(88, 13);
            this.labelElectrodomestico.TabIndex = 5;
            this.labelElectrodomestico.Text = "Electrodoméstico";
            // 
            // radioTelevisor
            // 
            this.radioTelevisor.AutoSize = true;
            this.radioTelevisor.Location = new System.Drawing.Point(415, 19);
            this.radioTelevisor.Name = "radioTelevisor";
            this.radioTelevisor.Size = new System.Drawing.Size(14, 13);
            this.radioTelevisor.TabIndex = 4;
            this.radioTelevisor.TabStop = true;
            this.radioTelevisor.UseVisualStyleBackColor = true;
            this.radioTelevisor.CheckedChanged += new System.EventHandler(this.radioTelevisor_CheckedChanged);
            // 
            // radioLavadora
            // 
            this.radioLavadora.AutoSize = true;
            this.radioLavadora.Location = new System.Drawing.Point(227, 21);
            this.radioLavadora.Name = "radioLavadora";
            this.radioLavadora.Size = new System.Drawing.Size(14, 13);
            this.radioLavadora.TabIndex = 3;
            this.radioLavadora.TabStop = true;
            this.radioLavadora.UseVisualStyleBackColor = true;
            this.radioLavadora.CheckedChanged += new System.EventHandler(this.radioLavadora_CheckedChanged);
            // 
            // radioElectrodomestico
            // 
            this.radioElectrodomestico.AutoSize = true;
            this.radioElectrodomestico.Location = new System.Drawing.Point(43, 19);
            this.radioElectrodomestico.Name = "radioElectrodomestico";
            this.radioElectrodomestico.Size = new System.Drawing.Size(14, 13);
            this.radioElectrodomestico.TabIndex = 2;
            this.radioElectrodomestico.TabStop = true;
            this.radioElectrodomestico.UseVisualStyleBackColor = true;
            this.radioElectrodomestico.CheckedChanged += new System.EventHandler(this.radioElectrodomestico_CheckedChanged);
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.Location = new System.Drawing.Point(133, -3);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(184, 19);
            this.labelSeleccion.TabIndex = 1;
            this.labelSeleccion.Text = "¿Qué desea comprar?";
            // 
            // groupElectrodomestico
            // 
            this.groupElectrodomestico.Controls.Add(this.groupLavadora);
            this.groupElectrodomestico.Controls.Add(this.groupTV);
            this.groupElectrodomestico.Controls.Add(this.labelPeso);
            this.groupElectrodomestico.Controls.Add(this.labelConsumo);
            this.groupElectrodomestico.Controls.Add(this.labelColor);
            this.groupElectrodomestico.Controls.Add(this.boxConsumo);
            this.groupElectrodomestico.Controls.Add(this.boxPeso);
            this.groupElectrodomestico.Controls.Add(this.boxColor);
            this.groupElectrodomestico.Controls.Add(this.labelPrecioBase);
            this.groupElectrodomestico.Controls.Add(this.boxPrecioBase);
            this.groupElectrodomestico.Location = new System.Drawing.Point(12, 89);
            this.groupElectrodomestico.Name = "groupElectrodomestico";
            this.groupElectrodomestico.Size = new System.Drawing.Size(290, 227);
            this.groupElectrodomestico.TabIndex = 1;
            this.groupElectrodomestico.TabStop = false;
            this.groupElectrodomestico.Text = "Añadir Electrodoméstico General";
            // 
            // groupLavadora
            // 
            this.groupLavadora.Controls.Add(this.labelCarga);
            this.groupLavadora.Controls.Add(this.boxCarga);
            this.groupLavadora.Enabled = false;
            this.groupLavadora.Location = new System.Drawing.Point(6, 81);
            this.groupLavadora.Name = "groupLavadora";
            this.groupLavadora.Size = new System.Drawing.Size(278, 43);
            this.groupLavadora.TabIndex = 12;
            this.groupLavadora.TabStop = false;
            // 
            // labelCarga
            // 
            this.labelCarga.AutoSize = true;
            this.labelCarga.Location = new System.Drawing.Point(5, 16);
            this.labelCarga.Name = "labelCarga";
            this.labelCarga.Size = new System.Drawing.Size(35, 13);
            this.labelCarga.TabIndex = 5;
            this.labelCarga.Text = "Carga";
            // 
            // boxCarga
            // 
            this.boxCarga.Location = new System.Drawing.Point(46, 13);
            this.boxCarga.Name = "boxCarga";
            this.boxCarga.Size = new System.Drawing.Size(75, 20);
            this.boxCarga.TabIndex = 6;
            // 
            // groupTV
            // 
            this.groupTV.Controls.Add(this.radioSintonizadorFalse);
            this.groupTV.Controls.Add(this.radioSintonizadorTrue);
            this.groupTV.Controls.Add(this.labelSintonizador);
            this.groupTV.Controls.Add(this.boxResolucion);
            this.groupTV.Controls.Add(this.labelResolucion);
            this.groupTV.Enabled = false;
            this.groupTV.Location = new System.Drawing.Point(6, 130);
            this.groupTV.Name = "groupTV";
            this.groupTV.Size = new System.Drawing.Size(278, 91);
            this.groupTV.TabIndex = 6;
            this.groupTV.TabStop = false;
            // 
            // radioSintonizadorFalse
            // 
            this.radioSintonizadorFalse.AutoSize = true;
            this.radioSintonizadorFalse.Location = new System.Drawing.Point(105, 69);
            this.radioSintonizadorFalse.Name = "radioSintonizadorFalse";
            this.radioSintonizadorFalse.Size = new System.Drawing.Size(52, 17);
            this.radioSintonizadorFalse.TabIndex = 11;
            this.radioSintonizadorFalse.TabStop = true;
            this.radioSintonizadorFalse.Text = "Tiene";
            this.radioSintonizadorFalse.UseVisualStyleBackColor = true;
            // 
            // radioSintonizadorTrue
            // 
            this.radioSintonizadorTrue.AutoSize = true;
            this.radioSintonizadorTrue.Location = new System.Drawing.Point(105, 50);
            this.radioSintonizadorTrue.Name = "radioSintonizadorTrue";
            this.radioSintonizadorTrue.Size = new System.Drawing.Size(65, 17);
            this.radioSintonizadorTrue.TabIndex = 10;
            this.radioSintonizadorTrue.TabStop = true;
            this.radioSintonizadorTrue.Text = "No tiene";
            this.radioSintonizadorTrue.UseVisualStyleBackColor = true;
            // 
            // labelSintonizador
            // 
            this.labelSintonizador.AutoSize = true;
            this.labelSintonizador.Location = new System.Drawing.Point(9, 50);
            this.labelSintonizador.Name = "labelSintonizador";
            this.labelSintonizador.Size = new System.Drawing.Size(90, 13);
            this.labelSintonizador.TabIndex = 9;
            this.labelSintonizador.Text = "Sintonizador TDT";
            // 
            // boxResolucion
            // 
            this.boxResolucion.Location = new System.Drawing.Point(89, 13);
            this.boxResolucion.Name = "boxResolucion";
            this.boxResolucion.Size = new System.Drawing.Size(46, 20);
            this.boxResolucion.TabIndex = 8;
            // 
            // labelResolucion
            // 
            this.labelResolucion.AutoSize = true;
            this.labelResolucion.Location = new System.Drawing.Point(9, 16);
            this.labelResolucion.Name = "labelResolucion";
            this.labelResolucion.Size = new System.Drawing.Size(74, 13);
            this.labelResolucion.TabIndex = 7;
            this.labelResolucion.Text = "Resolución   \"";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(153, 20);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(52, 13);
            this.labelPeso.TabIndex = 3;
            this.labelPeso.Text = "Peso (kg)";
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Location = new System.Drawing.Point(156, 55);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(76, 13);
            this.labelConsumo.TabIndex = 3;
            this.labelConsumo.Text = "Consumo (A-F)";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(9, 55);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color";
            // 
            // boxConsumo
            // 
            this.boxConsumo.Location = new System.Drawing.Point(238, 52);
            this.boxConsumo.Name = "boxConsumo";
            this.boxConsumo.Size = new System.Drawing.Size(22, 20);
            this.boxConsumo.TabIndex = 2;
            // 
            // boxPeso
            // 
            this.boxPeso.Location = new System.Drawing.Point(211, 17);
            this.boxPeso.Name = "boxPeso";
            this.boxPeso.Size = new System.Drawing.Size(46, 20);
            this.boxPeso.TabIndex = 2;
            // 
            // boxColor
            // 
            this.boxColor.Location = new System.Drawing.Point(60, 52);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(75, 20);
            this.boxColor.TabIndex = 2;
            // 
            // labelPrecioBase
            // 
            this.labelPrecioBase.AutoSize = true;
            this.labelPrecioBase.Location = new System.Drawing.Point(9, 20);
            this.labelPrecioBase.Name = "labelPrecioBase";
            this.labelPrecioBase.Size = new System.Drawing.Size(78, 13);
            this.labelPrecioBase.TabIndex = 1;
            this.labelPrecioBase.Text = "Precio base   $";
            // 
            // boxPrecioBase
            // 
            this.boxPrecioBase.Location = new System.Drawing.Point(87, 17);
            this.boxPrecioBase.Name = "boxPrecioBase";
            this.boxPrecioBase.Size = new System.Drawing.Size(48, 20);
            this.boxPrecioBase.TabIndex = 0;
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.AutoSize = true;
            this.labelInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrucciones.Location = new System.Drawing.Point(314, 95);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(180, 130);
            this.labelInstrucciones.TabIndex = 5;
            this.labelInstrucciones.Text = resources.GetString("labelInstrucciones.Text");
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(317, 249);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(168, 33);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelResultadoBoton
            // 
            this.labelResultadoBoton.AutoSize = true;
            this.labelResultadoBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoBoton.Location = new System.Drawing.Point(314, 288);
            this.labelResultadoBoton.Name = "labelResultadoBoton";
            this.labelResultadoBoton.Size = new System.Drawing.Size(0, 12);
            this.labelResultadoBoton.TabIndex = 13;
            // 
            // labelElementosAniadidos
            // 
            this.labelElementosAniadidos.AutoSize = true;
            this.labelElementosAniadidos.Location = new System.Drawing.Point(12, 321);
            this.labelElementosAniadidos.Name = "labelElementosAniadidos";
            this.labelElementosAniadidos.Size = new System.Drawing.Size(0, 13);
            this.labelElementosAniadidos.TabIndex = 14;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(245, 321);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(57, 31);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonEliminarElemento
            // 
            this.buttonEliminarElemento.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminarElemento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminarElemento.BackgroundImage")));
            this.buttonEliminarElemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminarElemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminarElemento.Location = new System.Drawing.Point(210, 322);
            this.buttonEliminarElemento.Name = "buttonEliminarElemento";
            this.buttonEliminarElemento.Size = new System.Drawing.Size(29, 30);
            this.buttonEliminarElemento.TabIndex = 16;
            this.buttonEliminarElemento.UseVisualStyleBackColor = false;
            this.buttonEliminarElemento.Click += new System.EventHandler(this.buttonEliminarElemento_Click);
            // 
            // labelCostosFinales
            // 
            this.labelCostosFinales.AutoSize = true;
            this.labelCostosFinales.Location = new System.Drawing.Point(12, 366);
            this.labelCostosFinales.Name = "labelCostosFinales";
            this.labelCostosFinales.Size = new System.Drawing.Size(0, 13);
            this.labelCostosFinales.TabIndex = 17;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(506, 447);
            this.Controls.Add(this.labelCostosFinales);
            this.Controls.Add(this.buttonEliminarElemento);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.labelElementosAniadidos);
            this.Controls.Add(this.labelResultadoBoton);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.groupElectrodomestico);
            this.Controls.Add(this.groupOpcionesSeleccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Calculadora Electrodomésticos";
            this.groupOpcionesSeleccion.ResumeLayout(false);
            this.groupOpcionesSeleccion.PerformLayout();
            this.groupElectrodomestico.ResumeLayout(false);
            this.groupElectrodomestico.PerformLayout();
            this.groupLavadora.ResumeLayout(false);
            this.groupLavadora.PerformLayout();
            this.groupTV.ResumeLayout(false);
            this.groupTV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOpcionesSeleccion;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.Label labelElectrodomestico;
        private System.Windows.Forms.RadioButton radioTelevisor;
        private System.Windows.Forms.RadioButton radioLavadora;
        private System.Windows.Forms.RadioButton radioElectrodomestico;
        private System.Windows.Forms.Label labelTelevisor;
        private System.Windows.Forms.Label labelLavadora;
        private System.Windows.Forms.GroupBox groupElectrodomestico;
        private System.Windows.Forms.Label labelPrecioBase;
        private System.Windows.Forms.TextBox boxPrecioBase;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox boxColor;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.TextBox boxConsumo;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox boxPeso;
        private System.Windows.Forms.TextBox boxCarga;
        private System.Windows.Forms.Label labelCarga;
        private System.Windows.Forms.Label labelSintonizador;
        private System.Windows.Forms.TextBox boxResolucion;
        private System.Windows.Forms.Label labelResolucion;
        private System.Windows.Forms.Label labelInstrucciones;
        private System.Windows.Forms.GroupBox groupTV;
        private System.Windows.Forms.RadioButton radioSintonizadorFalse;
        private System.Windows.Forms.RadioButton radioSintonizadorTrue;
        private System.Windows.Forms.GroupBox groupLavadora;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelResultadoBoton;
        private System.Windows.Forms.Label labelElementosAniadidos;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonEliminarElemento;
        private System.Windows.Forms.Label labelCostosFinales;
    }
}


