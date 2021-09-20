using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11403
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] graph = new List<int>[n];
                
            for(int i=0; i<n; i++)
            {
                graph[i] = new List<int>();
            }

            for(int i=0; i<n; i++)
            {
                int[] temp = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), (s) => int.Parse(s));

                for(int j=0; j<temp.Length; j++)
                {
                    if(temp[j] == 1)
                    {
                        graph[i].Add(j);
                    }
                }
            }

            int[,] answer = new int[n, n];
            for(int i=0; i<n; i++)
            {
                Queue<int> q = new Queue<int>();
                bool[] visited = new bool[n];
                q.Enqueue(i);

                while(q.Count != 0)
                {
                    int cur = q.Dequeue();
                    
                    for(int j=0; j<graph[cur].Count; j++)
                    {
                        if(!visited[graph[cur][j]])
                        {
                            visited[graph[cur][j]] = true;
                            q.Enqueue(graph[cur][j]);

                            answer[i, graph[cur][j]] = 1;
                        }
                    }
                }
            }

            StringBuilder sb = new StringBuilder(); ;
            for (int i=0; i<answer.GetLength(0); i++)
            {
                for(int j=0; j<answer.GetLength(1); j++)
                {
                    sb.Append(answer[i, j].ToString() + " ");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
