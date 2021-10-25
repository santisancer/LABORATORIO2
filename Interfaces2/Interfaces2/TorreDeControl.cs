using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
 class TorreDeControl
{
    List<IVolador> listaDeVoladores = new List<IVolador>();

    public void ImprimirTodo()
    {
        foreach (IVolador i in listaDeVoladores)
        {
            i.volador();
        }
    }
    public void agregarVolador(IVolador volar)
    {
        listaDeVoladores.Add(volar);
    }
}
}