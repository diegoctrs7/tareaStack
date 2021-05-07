using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaStack.Clases.stacksEnlazadas;

namespace tareaStack.Clases.stacks
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] ListaPila;
        public Nodo first;
        public Nodo last;

        public PilaLineal()
        {
            cima = -1; // condicion de pila vacia
            ListaPila = new Object[TAMPILA];
            first = null;
        }

        public bool pilaLlena()
        {
            return cima == TAMPILA - 1;
        }

        // operaciones que modifican la pila
        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de Pila Stack Overflow");
            }
            // incrementar puntero cima y vamos a insertar el elemento
            cima++;
            ListaPila[cima] = elemento;
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        // retorna un tipo char
        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no hay data");
            }
            aux = (char)ListaPila[cima];
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
            aux = (int)ListaPila[cima];
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
            return ListaPila[cima];
        }
    }
}
