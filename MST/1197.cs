using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class Edge
    {
        public int start, end, weight;

        public Edge(int a, int b, int c)
        {
            start = a;
            end = b;
            weight = c;
        }
    }

    class _1197
    {
        static int[] parent;
        static int v;
        static int edgeAccepted = 0;
        static int totalWeight = 0;

        static void Union(int a, int b, int weight)
        {
            int root1 = Find(a);
            int root2 = Find(b);

            if (root1 != root2)
            {
                edgeAccepted++;
                totalWeight += weight;
                parent[root1] = root2;
            }
        }

        static int Find(int cur)
        {
            if (parent[cur] == cur)
            {
                return cur;
            }

            return parent[cur] = Find(parent[cur]);
        }

        static void Set_Init()
        {
            for (int i = 1; i <= v; i++)
            {
                parent[i] = i;
            }
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            v = int.Parse(read[0]);
            int e = int.Parse(read[1]);

            parent = new int[v + 1];
            Set_Init();

            List<Edge> list = new List<Edge>();

            for(int i=0; i<e; i++)
            {
                read = Console.ReadLine().Split(" ");

                int start = int.Parse(read[0]);
                int end = int.Parse(read[1]);
                int weight = int.Parse(read[2]);

                list.Add(new Edge(start, end, weight));
            }

            list.Sort((x1, x2) => x1.weight.CompareTo(x2.weight));

            int iter = 0;
            while(edgeAccepted < v-1)
            {
                Edge temp = list[iter];
                Union(temp.start, temp.end, temp.weight);
                iter++;
            }

            Console.WriteLine(totalWeight);
        }
    }
}
