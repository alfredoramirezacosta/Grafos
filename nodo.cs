using System;
using System.Collections.Generic;
namespace grafos
{
    public class Nodo
    {
        

        public string Dato { get; set; }
        public Nodo Adyacente { get; set; }


        public Nodo(string dato=" ", Nodo adyacente = null )
        {
            Dato = dato;
            Adyacente = adyacente;

        }
    }
}
