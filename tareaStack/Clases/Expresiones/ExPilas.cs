using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaStack.Clases.Expresiones
{
    class ExPilas
    {
        private int tamaño;
        private int cima;
        private Object[] Pila;

        public ExPilas(int n)
        {
            this.tamaño = n;
            cima = 0;
            Pila = new Object[tamaño];
        }

        public bool pilavacia()
        {
            return cima == 0;
        }

        public bool pilallena()
        {
            return cima == tamaño;
        }

        public void apilar(Object elemento)
        {
            if (!pilallena())
            {
                cima++;
                Pila[cima] = elemento;
            }
        }

        public void limpiarPila()
        {
            cima = 0;
        }

        //retorna un tipo char
        public object desapilar()
        {
            Object aux;
            if (pilavacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (Object)Pila[cima];
            cima--;
            return aux;
        }

        //operación de acceso a la pila
        public Object topePila()
        {
            if (pilavacia())
            {
                throw new Exception("Pila vacia");
            }
            return Pila[cima];
        }
    }
}
