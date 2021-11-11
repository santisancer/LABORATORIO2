using System;
using System.Collections.Generic;
using System.Text;

namespace Punto18_santiagoSancer
{
    public abstract class Prenda
    {
        private bool calidadPremium;
        private bool calidadEstandar;


        public bool CalidadEstandar { get => calidadEstandar; set => calidadEstandar = value; }
        public bool CalidadPremium { get => calidadPremium; set => calidadPremium = value; }

        public abstract float calcularValor(float precio , int cantidad );
    }
}
