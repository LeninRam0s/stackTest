using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.ListaSimple
{
    class Nodo
    {
        private Object dato;
        private Nodo enlace = null;
        public Nodo()
        {

        }
        public Nodo(string dato, Nodo enlace)
        {
            this.dato = dato;
            this.enlace = enlace;
        }
        public Object getDato() => this.dato;
        public void setDato(Object dato) => this.dato = dato;
        public Nodo getEnlace() => this.enlace;
        public void setEnlace(Nodo enlace) => this.enlace = enlace;

    }
}
