using System;
using System.Collections.Generic;
using System.Text;
namespace grafos
{
    public class Vertice
    {
        Nodo VerticeInicial;
        Nodo VerticeActual;

        public Vertice()
        {
            VerticeInicial = new Nodo();
        }
        public void AgregarNodoVertice(string dato)
        {
            VerticeActual = VerticeInicial;
            Nodo nuevoVertice = new Nodo(dato);
            VerticeActual.Adyacente = nuevoVertice;
            //return nuevoVertice;
        }

        public void AgregarAdyacente(string dato)
        {
            VerticeActual = VerticeInicial;
            while (VerticeActual.Adyacente != null)
            {
                VerticeActual = VerticeActual.Adyacente;

            }
            Nodo nuevoVertice = new Nodo(dato);
            VerticeActual.Adyacente = nuevoVertice;
        }

    }
}
