using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Lista
{
    class Listas
    {
        Nodo cabeza = new Nodo();
        Nodo cola = new Nodo();
        int _longitud;

        public int longitud { get => _longitud; set => _longitud = value; }

        public MyLista()
        {
            cabeza = null;
            cola = null;
        }

        public void add(Object dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = dato;
            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
                cabeza.siguiete = cabeza;

                cabeza.anterior = cola;
            }
            else
            {
                cola.siguiete = nuevo;
                nuevo.anterior = cola;
                nuevo.siguiete = cabeza;
                cola = nuevo;
            }

        }
        public void recorrer()
        {
            longitud = 0;
            Nodo actual = new Nodo();
            actual = cabeza;

            if (actual != null)
            {
                do
                {
                    longitud++;

                    actual = actual.siguiete;

                } while (actual != cabeza);
            }


        }
        public void imprimirLista()
        {
            longitud = 0;
            Nodo actual = new Nodo();
            actual = cabeza;

            if (actual != null)
            {
                do
                {
                    longitud++;
                    Console.WriteLine(actual.dato);
                    actual = actual.siguiete;

                } while (actual != cabeza);
            }
        }
        public Object[] toArreglo()
        {
            recorrer();
            Object[] datos = new object[longitud];

            Nodo actual = new Nodo();
            actual = cabeza;
            int iterador = 0;
            if (actual != null)
            {
                do
                {
                    datos[iterador] = actual.dato;
                    actual = actual.siguiete;
                    iterador++;
                } while (actual != cabeza);
            }
            return datos;
        }
    }
}
