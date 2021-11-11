using System;
using System.Collections.Generic;
using System.Text;

namespace Punto18_santiagoSancer
{
    public class Pantalon : Prenda
    {
        private bool bermuda;

        public Pantalon(bool bermuda)
        {
           bermuda = bermuda;
        }

        public bool Bermuda { set => bermuda = value; }

        public override float calcularValor(float precio, int cantidad)
        {
            float precioFinal = precio;
                if (bermuda)
            {
                precioFinal -= precioFinal * 0.20f;
                if (CalidadPremium)
                {
                    precioFinal += precioFinal * 0.30f;
                    
                }
                precioFinal = (float)precioFinal * cantidad;

                return precioFinal;
            }
        }
    }
}
