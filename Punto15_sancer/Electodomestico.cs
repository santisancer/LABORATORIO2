using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Electrodomestico
    {
        protected String color;
        protected char consumoEnergetico;
        protected float precioBase;
        protected float peso;
        private float precioFinal;
        //Constructor por defecto
        public Electrodomestico()
        {
            this.color = "BLANCO";
            this.consumoEnergetico = 'F';
            this.precioBase = 100;
            this.peso = 5f;
        }
        //Constructor con precio y peso, resto por defecto
        public Electrodomestico(float precioBase, float peso)
        {
            this.color = "BLANCO";
            this.consumoEnergetico = 'F';
            this.precioBase = precioBase;
            this.peso = peso;
        }
        //Constructor con todos los valores añadidos por parámetro
        public Electrodomestico(String color, char consumoEnergetico, float precioBase, float peso)
        {
            ComprobarColor(color);
            ComprobarConsumoEnergetico(consumoEnergetico);
            this.precioBase = precioBase;
            this.peso = peso;
        }

        //Getters
        public string Color { get => color; }
        public char ConsumoEnergetico { get => consumoEnergetico; }
        public float PrecioBase { get => precioBase; }
        public float Peso { get => peso; }
        public float GetPrecioFinal { get => precioFinal; }


        //Métodos de comprobaciones
        private void ComprobarConsumoEnergetico(char letra)
        {
            if (letra != 'A' || letra != 'B' || letra != 'D' ||
                letra != 'E' || letra != 'F')
                this.consumoEnergetico = 'F';
            else
                this.consumoEnergetico = letra;
        }
        private void ComprobarColor(String color)
        {
            color.ToUpper();
            if (color != "BLANCO" || color != "NEGRO" ||
                color != "ROJO" || color != "AZUL" ||
                color != "GRIS")
                this.color = "BLANCO";
            else
                this.color = color;
        }

        //Métodos
        public void PrecioFinal()
        {
            float precio = 0;

            switch (consumoEnergetico)
            {
                case 'A':
                    precio += 100;
                    break;
                case 'B':
                    precio += 80;
                    break;
                case 'C':
                    precio += 60;
                    break;
                case 'D':
                    precio += 50;
                    break;
                case 'E':
                    precio += 30;
                    break;
                case 'F':
                    precio += 10;
                    break;
            }

            if (peso > 00 && peso <= 19)
                precio += 10;

            if (peso > 19 && peso <= 49)
                precio += 10;

            if (peso > 49 && peso <= 79)
                precio += 10;

            if (peso >= 80)
                precio += 100;

            precio += this.precioBase;
            this.precioFinal = precio;
        }
    }
}