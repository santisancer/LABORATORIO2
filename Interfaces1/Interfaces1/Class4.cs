using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Impresora
    {
        List<Imprimible> listaDeImprimibles = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach(Imprimible i in listaDeImprimibles)
            {
                i.imprimir();
            }
        }
        public void agregarImprimible(Imprimible imprimible)
        {
            listaDeImprimibles.Add(imprimible);
        }
    }
}
