using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tareaStack.Clases.Expresiones;
using tareaStack.Clases.stacks;
using tareaStack.Clases.stacksEnlazadas;

namespace tareaStack.Clases.met
{
    class Metodos
    {
        public void ejemploPilaLinealEn()
        {
            PLinealEnlazada pila;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pila = new PLinealEnlazada(); // crea la pila
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pila.insertar(x);                       
                    }
                } while (x != CLAVE);

                Console.WriteLine("Estos son los elementos de la pila:");

                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento: {x}");
                }
                pila.insertar(900);
                pila.insertar(45);
                pila.insertar(12);
                pila.insertar(1);
                int pausa;
                pausa = 0;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error = " + error.Message);
            }

            Console.ReadKey();
        }

        public void polindromoListEn()
        {
            bool esPalindromo;
            String pal;
            PLinealEnlazada lsimple = new PLinealEnlazada();

            try
            {
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                string rep = Regex.Replace(pal, @"\s", "");
                string con = rep.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                string nr = con.Normalize(NormalizationForm.FormD);
                string ns = reg.Replace(nr, "");

                // creamos la pila con los chars
                for (int i = 0; i < ns.Length;)
                {
                    Char c;
                    c = ns[i++];
                    lsimple.insertar(c);
                }
                int pausa;
                pausa = 0;
                // comprueba si es palindromo
                Console.WriteLine("Imprimiendo en orden inverso:");
                lsimple.inverse();
                esPalindromo = true;
                for (int j = 0; esPalindromo && !lsimple.pilaVacia();)
                {
                    Char c;
                    c = (Char)lsimple.quitarPila();
                    esPalindromo = ns[j++] == c; // evalua si la pos es igual
                }
                lsimple.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra ({ns}) SI es palindromo");
                }
                else
                {
                    Console.WriteLine($"La palabra ({ns}) NO es palindromo");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups, error = " + error.Message);
            }

            Console.ReadKey();
        }

        public void EjemploPilaListaEn()
        {
            int x;

            PListaEnlazada pe = new PListaEnlazada();
            pe.insertar(1);
            pe.insertar(5);
            pe.insertar(16);
            pe.insertar(217);
            pe.insertar(41);
            pe.insertar(19);

            var xx = pe.quitar();
            int pausa;
            pausa = 0;

            Console.ReadKey();
        }

        public void expresionesPilas()
        {
            string infija;
            Console.WriteLine("INGRESE LA EXPRESION QUE DESEA EVALUAR");
            infija = Console.ReadLine();
            Console.WriteLine("EL RESULTADO ES " + ArPilas.evaluar(infija));

            Console.ReadKey();
        }
    }
}
