using stackTest.Clases;
using System;

namespace stackTest
{
    class Program
    {

        static void ejemploPilaLineal()
        {
            PilaLineal pila;
            int x;
            int CLAVE = -1;
            Console.WriteLine("Ingrese numeros, y para terminar -1");

            try
            {
                pila = new PilaLineal(); //crea la pila
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x!=-1)
                    {
                        pila.insertar(x);
                    }
                    
                } while (x!=CLAVE);

                //desapilar
                Console.WriteLine("Estos son los elementos de la pila:");
                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"Elemento: {x}");
                }
                pila.insertar(900);
            }

            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }

        }

        static void pilindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                //creamos la pila con los chars
                for (int i = 0; i < pal.Length;)
                {
                    Char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c; //evalua si la pos es igual 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }


        }

        static void ejemploPilaLista()
        {
            PilaLista pl = new PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(21);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            int pau;
            pau = 0;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //ejemploPilaLineal();
            ejemploPilaLista();

        }
    }
}
