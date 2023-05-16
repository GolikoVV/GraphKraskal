using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphKraskal
{
    
    internal class Edge //представляет ребро графа
    {
        public int Source { get; }
        public int Destination { get; } //целевая вершина
        public int Weight { get; } //вес ребра

        public Edge(int source, int destination, int weight) 
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}
