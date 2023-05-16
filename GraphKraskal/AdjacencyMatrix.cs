using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphKraskal
{
    internal class AdjacencyMatrix
    {
        private int[,] matrix;

        public AdjacencyMatrix(int vertices)
        {
            matrix = new int[vertices, vertices];
        }

        public void AddEdge(int source, int destination, int weight)
        {
            matrix[source, destination] = weight;
            matrix[destination, source] = weight;
        }

        public void PrintAdjacencyMatrix()
        {
            int vertices = matrix.GetLength(0);

            Console.WriteLine("Таблица смежности:");

            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}