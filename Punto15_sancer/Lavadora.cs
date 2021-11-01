using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomestico
    {
        private int carga;

        //Constructor por defecto
        public Lavadora()
            : base()
        {
            this.carga = 5;
        }

        //Constructor con precio y peso, resto por defecto
        public Lavadora(float precioBase, float peso)
            : base(precioBase, peso)
        {
            this.carga = 5;
        }

        //Constructor con todos los valores añadidos por parámetro
        public Lavadora(string color, char consumoEnergetico, float precioBase, float peso, int carga)
            : base(color, consumoEnergetico, precioBase, peso)
        {
            this.carga = carga;
        }

        //Getter
        public int Carga { get => carga; }

        public new void PrecioFinal()
        {
            base.PrecioFinal();

            if (this.carga > 30)
                this.precioBase += 50;
        }
    }
}