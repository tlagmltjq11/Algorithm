using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2178
    {
        static int[,] mat;
        static int[,] distance;
        static int n, m;
        
        static int BFS(int x, int y)
        {
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            q.Enqueue(new KeyValuePair<int, int>(x, y));

            mat[0, 0] = 0;
            distance[0, 0] = 1;

            while(q.Count != 0)
            {
                int i, j;

                KeyValuePair<int, int> temp = q.Dequeue();
                i = temp.Key;
                j = temp.Value;

                //목적지에 도착했다면 종료 -> 먼저 도착한 부분이 가장 최단 경로이기 때문
                if(i == n-1 && j == m-1)
                {
                    return distance[i, j];
                }

                if ((i - 1) >= 0 && mat[i - 1, j] == 1)
                {
                    mat[i - 1, j] = 0;
                    distance[i - 1, j] = distance[i, j] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(i - 1, j));
                }

                if ((i + 1) < n && mat[i + 1, j] == 1)
                {
                    mat[i + 1, j] = 0;
                    distance[i + 1, j] = distance[i, j] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(i + 1, j));
                }

                if ((j - 1) >= 0 && mat[i, j - 1] == 1)
                {
                    mat[i, j - 1] = 0;
                    distance[i, j - 1] = distance[i, j] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(i, j - 1));
                }

                if ((j + 1) < m && mat[i, j + 1] == 1)
                {
                    mat[i, j + 1] = 0;
                    distance[i, j + 1] = distance[i, j] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(i, j + 1));
                }
            }

            return -1;
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            n = int.Parse(read[0]);
            m = int.Parse(read[1]);

            mat = new int[n, m];
            distance = new int[n, m];

            for(int i=0; i<n; i++)
            {
                string read1 = Console.ReadLine();

                for(int j=0; j<m; j++)
                {
                    mat[i, j] = (int)char.GetNumericValue(read1[j]);
                }
            }

            Console.WriteLine(BFS(0, 0));
        }
    }
}
