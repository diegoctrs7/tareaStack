using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaStack.Clases.stacksEnlazadas
{
    class PLinealEnlazada
    {
        public Nodo first;
        public Nodo last;
        private int cima;

        public PLinealEnlazada()
        {
            first = null;
            cima = -1; // condicion de pila vacia         
        }

        public void insertar(object dato)
        {
            Nodo aux = new Nodo(dato);
            aux.enlace = first;
            first = aux;
            cima++;
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        // retorna un tipo char
        public Object quitarPila()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no hay data");
            }
            aux = (char)first.dato;
            first = first.enlace;
            cima--;
            return aux;
        }

        // extraer elemento de la pila (pop)
        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La Pila esta vacia, no se puede sacar");
            }
            // guardar el elemento en la cima
            aux = (int)first.dato;
            first = first.enlace;
            // decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }

        public void LimpiarPila()
        {
            cima = -1;
        }

        // operacion de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return first.dato;
        }

        public void inverse()
        {
            Nodo actual = first;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.enlace;
            }
        }
    }
}
