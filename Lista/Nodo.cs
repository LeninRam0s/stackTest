using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Lista
{
    class Nodo
    {
        private Object _dato;
        private Nodo _siguiente;
        private Nodo _anterior;


        public Object dato { get => _dato; set => _dato = value; }
        public Nodo siguiete { get => _siguiente; set => _siguiente = value; }
        public Nodo anterior { get => _anterior; set => _anterior = value; }

    }
}
