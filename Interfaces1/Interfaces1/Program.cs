using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();

            impresora.agregarImprimible(documento);
            impresora.agregarImprimible(foto);
            impresora.agregarImprimible(contrato);
            impresora.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
