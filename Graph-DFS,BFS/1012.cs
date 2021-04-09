using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1012
    {
        static int[,] mat;
        static int m;
        static int n;

        static void DFS(int i, int j)
        {
            mat[i, j] = 0;

            if ((i - 1) >= 0 && mat[i - 1, j] == 1)
            {
                    DFS(i - 1, j);
            }

            if ((i + 1) < m && mat[i + 1, j] == 1)
            {
                    DFS(i + 1, j);
            }

            if ((j - 1) >= 0 && mat[i, j - 1] == 1)
            {
                    DFS(i, j - 1);
            }

            if ((j + 1) < n && mat[i, j + 1] == 1)
            {
                    DFS(i, j + 1);
            }
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                m = int.Parse(read[0]);
                n = int.Parse(read[1]);
                int k = int.Parse(read[2]);

                mat = new int[m, n];

                for (int j = 0; j < k; j++)
                {
                    read = Console.ReadLine().Split(" ");
                    int x = int.Parse(read[0]);
                    int y = int.Parse(read[1]);

                    mat[x, y] = 1;
                }

                int cnt = 0;

                for(int j=0; j<m; j++)
                {
                    for(int l=0; l<n; l++)
                    {
                        if(mat[j, l] == 1)
                        {
                            DFS(j, l);
                            cnt++;
                        }
                    }
                }

                sb.AppendLine(cnt.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
