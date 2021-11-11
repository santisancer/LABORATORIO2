using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Punto18_santiagoSancer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbError.Visible = false;
        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            cbBermuda.Checked = false;
            cbBermuda.Enabled = false;
            cbMangaCorta.Enabled = true;
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            cbMangaCorta.Checked = false;
            cbMangaCorta.Enabled = false;
            cbBermuda.Enabled = true;
        }

        private void bCalculador_Click(object sender, EventArgs e)
        {
            float precio = 0;
            int cant = 0;

            try
            {
                lbError.Visible = false;
                precio = (float)Convert.ToDecimal(tbPrecio.Text);
                cant = Convert.ToInt32(tbCantidad.Text);
            }
            catch (Exception)
            {
                lbError.Visible = true;
                tbPrecio.Text = null;
                tbCantidad.Text = null;
            }
            if (rbCamisa.Checked)
            {
                Camisa c1 = new Camisa(cbMangaCorta.Checked);
                if (rbPremium.Checked) { c1.CalidadPremium = true; }

                float x = c1.calcularValor(precio, cant);
                if (x > 0) { MessageBox.Show("El monto por la compra es de $" + x); }
            }
            else if (rbPantalon.Checked)
            {
                Pantalon p1 = new Pantalon(cbBermuda.Checked);
                if (rbPremium.Checked) { p1.CalidadPremium = true; }
                float x = p1.calcularValor(precio, cant);
                if (x > 0) { MessageBox.Show("El monto por la compra es de $" + x); }
            }
        }
    }
}