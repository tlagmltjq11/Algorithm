using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1389
    {
        static bool[] visited;
        static List<int>[] graph;

        static int BFS(int n)
        {
            int[] dist;
            int min = int.MaxValue;
            int minIndex = -1;

            for(int i=0; i<n; i++)
            {
                dist = new int[n];
                visited = new bool[n];
                dist[i] = 0;

                Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
                q.Enqueue(new KeyValuePair<int, int>(i, 0));
                visited[i] = true;

                while(q.Count != 0)
                {
                    KeyValuePair<int, int> cur = q.Dequeue();
                    for(int j=0; j<graph[cur.Key].Count; j++)
                    {
                        if(!visited[graph[cur.Key][j]])
                        {
                            q.Enqueue(new KeyValuePair<int, int>(graph[cur.Key][j], cur.Value + 1));
                            dist[graph[cur.Key][j]] = cur.Value + 1;
                            visited[graph[cur.Key][j]] = true;
                        }
                    }
                }

                int temp = 0;
                for(int j=0; j<n; j++)
                {
                    temp += dist[j];
                }

                if(min > temp)
                {
                    min = temp;
                    minIndex = i;
                }
            }

            return minIndex + 1;
        }

        static void Main()
        {
            string[] nm = Console.ReadLine().Split(" ");
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            graph = new List<int>[n];

            for(int i=0; i<n; i++)
            {
                graph[i] = new List<int>();
            }

            for(int i=0; i<m; i++)
            {
                string[] relation = Console.ReadLine().Split(" ");
                int from = int.Parse(relation[0]);
                int to = int.Parse(relation[1]);

                graph[from - 1].Add(to - 1);
                graph[to - 1].Add(from - 1);
            }

            int answer = BFS(n);

            Console.WriteLine(answer);
        }
    }
}
