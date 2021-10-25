using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            superman superman = new superman();
            Roing747 roing = new Roing747();
            TorreDeControl torre = new TorreDeControl();
            torre.agregarVolador(roing);
            torre.agregarVolador(pato);
            torre.agregarVolador(superman);

            torre.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
