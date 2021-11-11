using System;
using System.Collections.Generic;
using System.Text;

namespace Punto18_santiagoSancer
{
    public class Camisa : Prenda
    {
        private bool mangaCorta;

        public Camisa mangaCorta (bool mangaCorta)
        {
            this.mangaCorta = mangaCorta;
        }
        public bool mangaCorta { get => mangaCorta; set => mangaCorta = value; }

        public override float calcularValor(float precio, int cantidad)
        {
            float precioFinal = precio;
            if (mangaCorta)
            {
                precioFinal -= precioFinal * 0.10f;

            }
            else if(CalidadPremium)
            {
                precioFinal += precioFinal * 0.30f;
                precioFinal = (float)precioFinal * cantidad;
                return precioFinal;
            }
        }

    }
}
