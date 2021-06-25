using System;
using System.Collections.Generic;

namespace grafos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Vertice> Grafo = new List<Vertice>();

             
            Vertice verticeA = new Vertice();
            verticeA.AgregarNodoVertice("a");
            verticeA.AgregarAdyacente("e");
            verticeA.AgregarAdyacente("i");
            Grafo.Add(verticeA);

            Vertice verticeE = new Vertice();
            verticeE.AgregarNodoVertice("e");
            verticeE.AgregarAdyacente("o");
            Grafo.Add(verticeE);

            
                
            

            Console.ReadLine();

        }
    }
}
