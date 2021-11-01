using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomestico
    {
        private float resolucion;
        private bool sintonizadorTDT;

        //Constructor por defecto
        public Television()
            : base()
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        //Constructor con precio y peso, resto por defecto
        public Television(float precioBase, float peso)
            : base(precioBase, peso)
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        //Constructor con todos los valores añadidos por parámetro
        public Television(string color, char consumoEnergetico, float precioBase, float peso, int resolucion, bool sintonizadorTDT)
            : base(color, consumoEnergetico, precioBase, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public float Resolucion { get => resolucion; }
        public bool SintonizadorTDT { get => sintonizadorTDT; }

        public new void PrecioFinal()
        {
            base.PrecioFinal();

            if (resolucion > 30)
                this.precioBase = (this.precioBase * 1.30f);

            if (sintonizadorTDT)
                this.precioBase = (this.precioBase * 1.50f);
        }
    }
}