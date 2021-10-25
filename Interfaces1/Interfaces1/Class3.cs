using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Documento:Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("documento de word");
        }
    }
}
