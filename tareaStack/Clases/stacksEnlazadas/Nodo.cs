using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaStack.Clases.stacksEnlazadas
{
    class Nodo
    {
        public Object dato;
        public Nodo enlace;

        public Nodo(object x)
        {
            this.dato = x;
            this.enlace = null;
        }

        public Nodo(Object x, Nodo n)
        {
            dato = x;
            enlace = n;
        }

        public Object getDato()
        {
            return dato;
        }

        public Nodo getEnlace()
        {
            return enlace;
        }

        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }
    }
}
