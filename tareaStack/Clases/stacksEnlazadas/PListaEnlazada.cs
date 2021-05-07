using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaStack.Clases.stacksEnlazadas
{
    class PListaEnlazada
    {
        public Nodo first;
        public Nodo last;
        private int cima;

        public PListaEnlazada()
        {
            first = null;
            cima = -1; // condicion de pila vacia
        }

        public void insertar(Object elemento)
        {

            Nodo aux = new Nodo(elemento);
            aux.enlace = first;
            first = aux;
            cima++;
        }

        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = (Object)first.dato;
            first = first.enlace;
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return cima;
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
    }
}
