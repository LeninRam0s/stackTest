using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stackTest.Pilas
{
    class PilaLista
    {
        private int cima;
        private List<Object> listPila;

        public PilaLista()
        {
            cima = -1; // condicion de pila vacia.
            listPila = new List<Object>();
        }

        public void insertar(Object dato)
        {
            cima++;
            listPila.Add(dato);
        }

        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = listPila.ElementAt(cima);
            listPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return listPila.ElementAt(cima);
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = (char)listPila.ElementAt(cima);
            cima--;
            return aux;
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
