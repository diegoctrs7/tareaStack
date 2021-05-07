using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaStack.Clases.stacksEnlazadas;

namespace tareaStack.Clases.stacks
{
    class PilaLista
    {
        private int cima;
        private List<Object> ListaPila;
        public Nodo first;
        public Nodo last;

        public PilaLista()
        {
            cima = -1; // condicion de pila vacia
            ListaPila = new List<Object>();
            first = null;
        }

        public void insertar(Object elemento)
        {
            cima++;
            ListaPila.Add(elemento);
        }

        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = ListaPila.ElementAt(cima);
            ListaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return ListaPila.ElementAt(cima);
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
