using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] listaPila;

        //constructor
        public PilaLineal()
        {
            cima = -1; //condicion de pila vacia
            listaPila = new Object[TAMPILA];
        }

        public bool pilaLlena()
        {
            return cima == TAMPILA - 1;
        }

        //operaciones que modifican la pila
        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordameinto de pila Stack Overflow");
            }
            //incrementamos el puntero cima y vamos a insertar el elemento
            cima++;
            listaPila[cima] = elemento;
        }


        public bool pilaVacia()
        {
            return cima == -1;
        }

        //Retorna un tipo char
        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("pila vacia no hay datos");
            }
            aux = (char)listaPila[cima];
            cima--;
            return aux;
        }


        //extraer el valor de la pila (pop)

        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La Pila esta vacia, no se puede quitar");
            }
            //guardar el elemento en la cima
            aux = (int)listaPila[cima]; //en el casteo podemos cambiarlo de acuerdo al tipo de dato
            cima--; //decrementar el valor de cima y retornar el elemento
            return aux;
        }

        //limpiar pila de datos
        public void limpiarPila()
        {
            cima = -1;
        }

        //opcion de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return listaPila[cima];
        }
    }
}
