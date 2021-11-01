using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodomesticos
{
    public partial class VentanaPrincipal : Form
    {
        List<Electrodomestico> listaElectrodomesticos = new List<Electrodomestico>();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }



        //Seleccion de electrodomestico
        #region SELECCION DE ELECTRODOMÉSTICO
        private void radioElectrodomestico_CheckedChanged(object sender, EventArgs e)
        {
            groupTV.Enabled = false;
            groupLavadora.Enabled = false;
            //Vaciar textBox de Lavadora
            boxCarga.Text = null;
            //Vaciar textBox de TV
            boxResolucion.Text = null;
            radioSintonizadorTrue.Checked = false;
            radioSintonizadorFalse.Checked = false;
        }

        private void radioLavadora_CheckedChanged(object sender, EventArgs e)
        {
            groupTV.Enabled = false;
            groupLavadora.Enabled = true;
            //Vaciar textBox de TV
            boxResolucion.Text = null;
            radioSintonizadorTrue.Checked = false;
            radioSintonizadorFalse.Checked = false;
        }

        private void radioTelevisor_CheckedChanged(object sender, EventArgs e)
        {
            groupTV.Enabled = true;
            groupLavadora.Enabled = false;
            //Vaciar textBox de Lavadora
            boxCarga.Text = null;
        }

        #endregion




        //Acciones del botón
        #region BOTÓN 
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //En caso de que se seleccione ELECTRODOMÉSTICO
            if (radioElectrodomestico.Checked)
            {
                if (comprobarConstructorVacio()) //Si no se ingresó NINGÚN dato, se crea un objeto por defecto
                {
                    listaElectrodomesticos.Add(new Electrodomestico());

                    //Mensaje de éxito
                    labelResultadoBoton.ForeColor = Color.Green;
                    labelResultadoBoton.Text = "ELECTRODOMÉSTICO AÑADIDO\n" +
                        "POR DEFECTO";
                }
                else if (comprobarPrecioYPeso()) //Comprueba si se ingresó SOLO Precio y Peso
                {
                    //Convierte los valores
                    if (double.TryParse(boxPrecioBase.Text, out double precioBase) &&
                        double.TryParse(boxPeso.Text, out double peso))
                    {
                        listaElectrodomesticos.Add(new Electrodomestico((float)precioBase, (float)peso));

                        labelResultadoBoton.ForeColor = Color.Green;
                        labelResultadoBoton.Text = "ELECTRODOMÉSTICO AÑADIDO\n" +
                        "POR PRECIO Y PESO";
                    }
                    else //Por si ha habido un error de conversión
                    {
                        labelResultadoBoton.ForeColor = Color.OrangeRed;
                        labelResultadoBoton.Text = "Error de tipo en el dato ingresado";
                    }
                }
                else
                {
                    if (double.TryParse(boxPrecioBase.Text, out double precioBase) &&
                        double.TryParse(boxPeso.Text, out double peso) &&
                        char.TryParse(boxConsumo.Text.ToUpper(), out char consumo))
                    {
                        listaElectrodomesticos.Add(new Electrodomestico(boxColor.Text, consumo, (float)precioBase, (float)peso));
                        labelResultadoBoton.ForeColor = Color.Green;
                        labelResultadoBoton.Text = "ELECTRODOMÉSTICO AÑADIDO ";
                    }
                    else //Por si ha habido un error de conversión
                    {
                        labelResultadoBoton.ForeColor = Color.OrangeRed;
                        labelResultadoBoton.Text = "Error de tipo en el dato ingresado";
                    }
                }
            }

            //En caso de que se seleccione LAVADORA
            if (radioLavadora.Checked)
            {
                if (comprobarConstructorVacio()) //Si no se ingresó NINGÚN dato, se crea un objeto por defecto
                {
                    listaElectrodomesticos.Add(new Lavadora());

                    //Mensaje de éxito
                    labelResultadoBoton.ForeColor = Color.Green;
                    labelResultadoBoton.Text = "LAVADORA AÑADIDA\n" +
                        "POR DEFECTO";
                }
                else if (comprobarPrecioYPeso()) //Comprueba si se ingresó SOLO Precio y Peso
                {
                    if (double.TryParse(boxPrecioBase.Text, out double precioBase) && //Convierte los valores
                        double.TryParse(boxPeso.Text, out double peso))
                    {
                        listaElectrodomesticos.Add(new Lavadora((float)precioBase, (float)peso));
                        labelResultadoBoton.Text = "LAVADORA AÑADIDA\n" +
                        "POR PRECIO Y PESO";
                    }
                    else //Por si ha habido un error de conversión
                    {
                        labelResultadoBoton.ForeColor = Color.OrangeRed;
                        labelResultadoBoton.Text = "Error de tipo en el dato ingresado";
                    }
                }
                else
                {
                    if (double.TryParse(boxPrecioBase.Text, out double precioBase) &&
                        double.TryParse(boxPeso.Text, out double peso) &&
                        char.TryParse(boxConsumo.Text.ToUpper(), out char consumo) &&
                        int.TryParse(boxCarga.Text, out int carga))
                    {
                        listaElectrodomesticos.Add(new Lavadora(boxColor.Text, consumo, (float)precioBase, (float)peso, carga));
                        labelResultadoBoton.ForeColor = Color.Green;
                        labelResultadoBoton.Text = "ELECTRODOMÉSTICO AÑADIDO";
                    }
                    else //Por si ha habido un error de conversión
                    {
                        labelResultadoBoton.ForeColor = Color.OrangeRed;
                        labelResultadoBoton.Text = "Error de tipo en el dato ingresado";
                    }
                }
            }

            //En caso de que se seleccione TELEVISOR
            if (radioTelevisor.Checked)
            {
                if (comprobarConstructorVacio()) //Si no se ingresó NINGÚN dato, se crea un objeto por defecto
                {
                    listaElectrodomesticos.Add(new Television());

                    //Mensaje de éxito
                    labelResultadoBoton.ForeColor = Color.Green;
                    labelResultadoBoton.Text = "TELEVISIÓN AÑADIDA\n" +
                        "POR DEFECTO";
                }
                else if (comprobarPrecioYPeso()) //Comprueba si se ingresó SOLO Precio y Peso
                {
                    if (double.TryParse(boxPrecioBase.Text, out double precioBase) && //Convierte los valores
                        double.TryParse(boxPeso.Text, out double peso))
                    {
                        listaElectrodomesticos.Add(new Television((float)precioBase, (float)peso));
                        labelResultadoBoton.Text = "TELEVISIÓN AÑADIDA\n" +
                        "POR PRECIO Y PESO";
                    }
                    else //Por si ha habido un error de conversión
                    {
                        labelResultadoBoton.ForeColor = Color.OrangeRed;
                        labelResultadoBoton.Text = "Error de tipo en el dato ingresado";
                    }
                }
                else
                {
                    if (double.TryParse(boxPrecioBase.Text, out double precioBase) &&
                        double.TryParse(boxPeso.Text, out double peso) &&
                        char.TryParse(boxConsumo.Text.ToUpper(), out char consumo) &&
                        int.TryParse(boxResolucion.Text, out int carga))
                    {
                        bool sintonizador;
                        if (radioSintonizadorTrue.Checked)
                        {
                            sintonizador = true;
                        }
                        else
                        {
                            sintonizador = false;
                        }
                        listaElectrodomesticos.Add(new Television(boxColor.Text, consumo, (float)precioBase, (float)peso, carga, sintonizador));
                        labelResultadoBoton.ForeColor = Color.Green;
                        labelResultadoBoton.Text = "ELECTRODOMÉSTICO AÑADIDO";
                    }
                    else //Por si ha habido un error de conversión
                    {
                        labelResultadoBoton.ForeColor = Color.OrangeRed;
                        labelResultadoBoton.Text = "Error de tipo en el dato ingresado";
                    }
                }
            }


            mostrarElementos();
            mostrarCostosFinales();
        }

        #endregion







        //-------------------------------------------------------------------------------------------------------------
        //COMPROBACIONES
        private bool comprobarConstructorVacio()
        {
            bool estaVacio;
            if (String.IsNullOrEmpty(boxPrecioBase.Text) && String.IsNullOrEmpty(boxPeso.Text) &&
                String.IsNullOrEmpty(boxColor.Text) && String.IsNullOrEmpty(boxConsumo.Text))
            {
                estaVacio = true;
            }
            else
            {
                estaVacio = false;
            }

            if (estaVacio)
            {
                if (radioLavadora.Checked)
                {
                    if (String.IsNullOrEmpty(boxCarga.Text))
                    {
                        estaVacio = true;
                    }
                    else
                    {
                        estaVacio = false;
                    }
                }

                if (radioTelevisor.Checked)
                {
                    if (String.IsNullOrEmpty(boxResolucion.Text) && !radioSintonizadorFalse.Checked &&
                        !radioSintonizadorTrue.Checked)
                    {
                        estaVacio = true;
                    }
                    else
                    {
                        estaVacio = false;
                    }
                }
            }

            return estaVacio;
        }


        private bool comprobarPrecioYPeso()
        {

            //Comprueba si Precio y Peso son los que no están vacíos
            if (String.IsNullOrEmpty(boxPrecioBase.Text) && String.IsNullOrEmpty(boxPeso.Text))
            {
                return false; //Si están vacíos termina aquí
            }
            else
            {
                //Comprueba si hay algún otro campo que fue rellenado, o solo fueron Precio y Peso
                if (String.IsNullOrEmpty(boxColor.Text) && String.IsNullOrEmpty(boxConsumo.Text) &&
                    String.IsNullOrEmpty(boxCarga.Text) && String.IsNullOrEmpty(boxResolucion.Text) &&
                    !radioSintonizadorFalse.Checked && !radioSintonizadorTrue.Checked)
                {
                    //Comprueba que estén los dos
                    if (!String.IsNullOrEmpty(boxPeso.Text))
                    {
                        return true;
                    }
                    else
                    {
                        boxPeso.Text = "ERROR";
                        return false;
                    }
                    //Comprueba que estén los dos x2
                    if (!String.IsNullOrEmpty(boxPeso.Text))
                    {
                        if (!String.IsNullOrEmpty(boxPrecioBase.Text))
                        {
                            return true;
                        }
                        else
                        {
                            boxPrecioBase.Text = "ERROR";
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            boxCarga.Text = null;
            boxColor.Text = null;
            boxConsumo.Text = null;
            boxPeso.Text = null;
            boxPrecioBase.Text = null;
            boxResolucion.Text = null;

            radioSintonizadorTrue.Checked = false;
            radioSintonizadorFalse.Checked = false;
        }

        private void mostrarElementos()
        {
            labelElementosAniadidos.Text = "Añadidos: " + listaElectrodomesticos.Count + " elementos.";
        }

        private void buttonEliminarElemento_Click(object sender, EventArgs e)
        {
            if (listaElectrodomesticos.Count > 0)
            {
                listaElectrodomesticos.RemoveAt(listaElectrodomesticos.Count - 1);
            }
            mostrarElementos();
            mostrarCostosFinales();
        }

        private void mostrarCostosFinales()
        {
            float costoElectro = 0f;
            float costoLavadoras = 0f;
            float costoTelevisores = 0f;
            foreach (Electrodomestico i in listaElectrodomesticos)
            {
                i.PrecioFinal();
                costoElectro += i.GetPrecioFinal;

                if (i is Lavadora)
                {
                    costoLavadoras += i.GetPrecioFinal;
                }
                else if (i is Television)
                {
                    costoTelevisores += i.GetPrecioFinal;
                }
            }

            labelCostosFinales.Text = "El costo total de\n" +
            "Electrodomésticos: " + costoElectro + "$\n" +
            "Lavadoras: " + costoLavadoras + "$\n" +
            "Televisores: " + costoTelevisores + "$";
        }
    }
}