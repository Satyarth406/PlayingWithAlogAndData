using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSm
{
    class Program
    {
        static void Main(string[] args)
        {
            //GraphSM graph = new GraphSM(5);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 4);

            //graph.PrintGraph();


            GraphSM g = new GraphSM(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            //g.BFS(2);
            g.DFS();

            Console.ReadLine();
        }
    }
}
