using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1967
    {
        static List<KeyValuePair<int, int>>[] list;
        static int maxDist;
        static int maxNode;
        static bool[] visited;

        static void DFS(int node, int dist)
        {
            visited[node] = true;

            if(maxDist < dist)
            {
                maxDist = dist;
                maxNode = node;
            }

            for(int i=0; i<list[node].Count; i++)
            {
                if(!visited[list[node][i].Key])
                {
                    DFS(list[node][i].Key, list[node][i].Value + dist);
                }
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            list = new List<KeyValuePair<int, int>>[n + 1];
            visited = new bool[n + 1];

            for (int i=1; i<=n; i++)
            {
                list[i] = new List<KeyValuePair<int, int>>();
            }
           
            string[] read;
            for(int i=0; i<n-1; i++)
            {
                read = Console.ReadLine().Split(" ");

                list[int.Parse(read[0])].Add(new KeyValuePair<int, int>(int.Parse(read[1]), int.Parse(read[2])));
                list[int.Parse(read[1])].Add(new KeyValuePair<int, int>(int.Parse(read[0]), int.Parse(read[2])));
            }

            if(n > 1)
            {
                DFS(1, 0);
                visited = new bool[n + 1];
                DFS(maxNode, 0);

                Console.WriteLine(maxDist);
            }    
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
