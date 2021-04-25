using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _4803
    {
        static int[,] adj_mat;
        static bool[] visited;
        static int treeCnt = 0; 
        static bool hasCycle = false;
        static int n, m;

        static void Recur(int before, int cur)
        {
            visited[cur] = true;

            for(int i=1; i<=n; i++)
            {
                if(adj_mat[cur, i] == 1 && i != before)
                {
                    if (visited[i] == true)
                    {
                        hasCycle = true;
                    }
                    else
                    {
                        Recur(cur, i);
                    }
                }
            }
        }

        static void Main()
        {
            int cnt = 0;

            while (true)
            {
                string[] read = Console.ReadLine().Split(" ");

                n = int.Parse(read[0]);
                m = int.Parse(read[1]);

                if (n == 0 && m == 0)
                {
                    break;
                }

                adj_mat = new int[n + 1, n + 1];
                visited = new bool[n + 1];
                treeCnt = 0;
                hasCycle = false;

                for (int i = 0; i < m; i++)
                {
                    read = Console.ReadLine().Split(" ");
                    adj_mat[int.Parse(read[0]), int.Parse(read[1])] = 1;
                    adj_mat[int.Parse(read[1]), int.Parse(read[0])] = 1;
                }

                for (int i = 1; i <= n; i++)
                {
                    if(visited[i] == false)
                    {
                        Recur(0, i);

                        if(!hasCycle)
                        {
                            treeCnt++;
                        }
                    }
                }

                cnt++;

                if(treeCnt == 0)
                {
                    Console.WriteLine("Case {0}: No trees.", cnt);
                }
                else if(treeCnt == 1)
                {
                    Console.WriteLine("Case {0}: There is one tree.", cnt);
                }
                else
                {
                    Console.WriteLine("Case {0}: A forest of {1} trees.", cnt, treeCnt);
                }
            }
        }
    }
}
