using System;
using System.Collections.Generic;

namespace GraphSm
{
    public class GraphSM
    {
        int V;
        public List<int>[] adjacentList;

        public GraphSM(int size)
        {
            V = size;
            adjacentList = new List<int>[V];
            for (int i = 0; i < adjacentList.Length; i++)
            {
                adjacentList[i] = new List<int>();
            }
        }

        internal void PrintGraph()
        {
            for (int i = 0; i < V; i++)
            {
                List<int> list = adjacentList[i];
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }
        }

        public void AddEdge(int src, int des)
        {
            adjacentList[src].Add(des);
            //adjacentList[des].Add(src);  in case the graph is non directional
        }

        public void DFS()
        {
            bool[] visited = new bool[V];
            //DFSUtil(0, visited);
            for (int i = 0; i < V; i++)
            {
                DFSUtilAlter(i, visited);
            }
        }

        private void DFSUtil(int s, bool[] visited)
        {
            List<int> list = adjacentList[s];
            visited[s] = true;
            Console.WriteLine(s);

            foreach (var item in list)
            {
                if (!visited[item])
                {
                    DFSUtil(item, visited);
                }
            }
        }

        private void DFSUtilAlter(int s, bool[] visited)
        {
            List<int> list = adjacentList[s];


            foreach (var item in list)
            {
                if (!visited[item])
                {
                    Console.WriteLine(item);
                    visited[item] = true;
                    DFSUtilAlter(item,visited);
                }
            }
        }


        public void BFS(int s)
        {
            bool[] visited = new bool[V];
            Dictionary<int, List<int>> elementLevels = new Dictionary<int, List<int>>();
            elementLevels.Add(0, new List<int>() { s });
            Dictionary<int, int> elementParent = new Dictionary<int, int>();
            elementParent[s] = int.MinValue;
            List<int> frontier = new List<int>();
            frontier.Add(s);
            int j = 1;
            visited[s] = true;
            while (frontier.Count > 0)
            {
                List<int> next = new List<int>();
                for (int i = 0; i < frontier.Count; i++)
                {
                    List<int> frontierList = adjacentList[frontier[i]];
                    Console.WriteLine(frontier[i]);

                    foreach (var item in frontierList)
                    {

                        if (!visited[item])
                        {
                            if (!elementLevels.ContainsKey(j))
                            {
                                elementLevels[j] = new List<int>() { item };
                            }
                            else
                            {
                                elementLevels[j].Add(item);

                            }
                            visited[item] = true;
                            next.Add(item);
                            elementParent[item] = frontier[i];
                        }
                    }
                }
                frontier = next;
                j++;
            }

        }
    }
}
