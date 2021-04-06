using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class Graph
    {
        int n; //정점의 개수
        bool[] visited;
        List<int>[] adj_List;
        int maxSize;

        public Graph(int maxSize)
        {
            n = 0;

            this.maxSize = maxSize;
            visited = new bool[maxSize + 1];

            adj_List = new List<int>[maxSize + 1];
        }

        public void Init()
        {
            for(int i=1; i<=maxSize; i++)
            {
                visited[i] = false;
            }
        }

        public void insert_vertex(int vertex)
        {
            n++;

            adj_List[n] = new List<int>();
        }

        public void insert_edge(int u, int v)
        {
            adj_List[u].Add(v);
            adj_List[v].Add(u);
        }

        public int BFS(int v)
        {
            Queue<int> q = new Queue<int>();
            int result = 0;
            visited[v] = true;
            q.Enqueue(v); 

            while(q.Count != 0)
            {
                int temp = q.Dequeue();

                for(int i=0; i<adj_List[temp].Count; i++)
                {
                    if (visited[adj_List[temp][i]] == false)
                    {
                        q.Enqueue(adj_List[temp][i]);
                        visited[adj_List[temp][i]] = true;
                        result++;
                    }
                }
            }

            return result;
        }
    }

    class _2606
    {
        static void Main()
        {
            int com = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Graph g = new Graph(com);
            g.Init();

            for(int i=0; i<com; i++)
            {
                g.insert_vertex(i + 1);
            }

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                int u = int.Parse(read[0]);
                int v = int.Parse(read[1]);

                g.insert_edge(u, v);
            }

            Console.WriteLine(g.BFS(1));
        }
    }
}
