using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaStack.Clases.met;
using tareaStack.Clases.stacks;
using tareaStack.Clases.stacksEnlazadas;

namespace tareaStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos meths = new Metodos();

            //meths.ejemploPilaLinealEn();
            //meths.polindromoListEn();
            //meths.EjemploPilaListaEn();
            meths.expresionesPilas();
        }
    }
}
