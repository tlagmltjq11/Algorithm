using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1167
    {
        static int maxDist;
        static int maxNode;
        static bool[] visited; //방문체크

        class tree
        {
            int n; // 노드의 개수
            List<KeyValuePair<int, int>>[] list; //노드간 연결 정보 저장

            public tree(int n)
            {
                this.n = n;
                list = new List<KeyValuePair<int, int>>[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    list[i] = new List<KeyValuePair<int, int>>();
                }
            }

            public void insert_edge(int start, int end, int dist)
            {
                list[start].Add(new KeyValuePair<int, int>(end, dist));
                list[end].Add(new KeyValuePair<int, int>(start, dist));
            }

            public void dfs(int v, int dist)
            {
                if (visited[v])
                {
                    return;
                }

                visited[v] = true;

                if (maxDist < dist)
                {
                    maxDist = dist;
                    maxNode = v;
                }

                for (int i = 0; i < list[v].Count; i++)
                {
                    dfs(list[v][i].Key, dist + list[v][i].Value);
                }
            }
        }

        static void Main()
        {
            int v = int.Parse(Console.ReadLine());

            tree t = new tree(v);

            string[] read;
            for (int i = 0; i < v; i++)
            {
                read = Console.ReadLine().Split(" ");

                int start = int.Parse(read[0]);

                int index = 1;
                while (true)
                {
                    if (int.Parse(read[index]) == -1)
                    {
                        break;
                    }

                    int end = int.Parse(read[index]);
                    int dist = int.Parse(read[index + 1]);

                    t.insert_edge(start, end, dist);
                    index += 2;
                }
            }

            visited = new bool[v + 1];
            t.dfs(1, 0); //임의의 정점 1에서 가장 거리간 먼 정점을 찾는다.
            visited = new bool[v + 1];
            t.dfs(maxNode, 0); //1과 가장 먼 정점에서 다시 DFS를 통해 트리의 지름을 찾는다.

            Console.WriteLine(maxDist);
        }
    }
}
