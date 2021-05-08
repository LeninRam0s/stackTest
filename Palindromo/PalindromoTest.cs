using stackTest.Pilas;
using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Palindromo
{
    class PalindromoTest
    {
        public void polindromoArray()
        {
            Pila pilaTxt;
            bool esPalindromo;
            String pal;

            try
            {
                pilaTxt = new Pila();
                Console.WriteLine("Teclee una palabra");
                pal = Console.ReadLine();
                //creamos la pila con los char
                foreach (var letra in pal)
                {
                    Char c;
                    c = letra;
                    pilaTxt.insertar(c);
                }

                //comprueba si es palindromo
                esPalindromo = true;
                for (int i = 0; esPalindromo && !pilaTxt.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaTxt.quitarChar();
                    esPalindromo = pal[i++] == c; // evalua si la sigueinte letra es igual
                }
                pilaTxt.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra es palindromo");
                }
                else
                {
                    Console.WriteLine($"La palabra no es un palindromo");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }

        public void polindromoLista()
        {
            PilaLista pilaChar;
            bool esPalindromo;
            String pal;

            try
            {
                pilaChar = new PilaLista();
                Console.WriteLine("Teclee una palabra");
                pal = Console.ReadLine();
                //creamos la pila con los char
                foreach (var letra in pal)
                {
                    Char c;
                    c = letra;
                    pilaChar.insertar(c);
                }

                //comprueba si es palindromo
                esPalindromo = true;
                for (int i = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[i++] == c; // evalua si la sigueinte letra es igual
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra es palindromo");
                }
                else
                {
                    Console.WriteLine($"La palabra no es un palindromo");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }
        public void polindromoListaEnlazada()
        {
            PilaListaEnlazada pilaChar;
            bool esPalindromo;
            String pal;

            try
            {
                pilaChar = new PilaListaEnlazada();
                Console.WriteLine("Teclee una palabra");
                pal = Console.ReadLine();
                //creamos la pila con los char
                foreach (var letra in pal)
                {
                    Char c;
                    c = letra;
                    pilaChar.insertar(c);
                }

                //comprueba si es palindromo
                esPalindromo = true;
                for (int i = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[i++] == c; // evalua si la sigueinte letra es igual
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra es palindromo");
                }
                else
                {
                    Console.WriteLine($"La palabra no es un palindromo");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }

    }
}
