using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class tttt
    {
        static int[,] matrix;
        static bool[,] visited;
        static int[] dx = new int[] { 0, 1, 0, -1 };
        static int[] dy = new int[] { 1, 0, -1, 0 };
        static int size;

        static void DFS(int x, int y)
        {
            int nextX = x;
            int nextY = y;
            for(int i=0; i<4; i++)
            {
                nextX = x + dx[i];
                nextY = y + dy[i];

                if (nextX < 0 || nextY < 0 || nextX >= matrix.GetLength(0) || nextY >= matrix.GetLength(0))
                {
                    continue;
                }

                if (matrix[nextX, nextY] != 0 && !visited[nextX, nextY])
                {
                    visited[nextX, nextY] = true;
                    size++;
                    DFS(nextX, nextY);
                }
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];
            visited = new bool[n, n];

            for(int i=0; i<n; i++)
            {
                int[] read = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), (s) => int.Parse(s));

                for(int j=0; j<n; j++)
                {
                    matrix[i, j] = read[j];
                }
            }

            int area = 0;
            List<int> list = new List<int>();
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(matrix[i,j] != 0 && !visited[i, j])
                    {
                        size = 1;
                        area++;
                        visited[i, j] = true;
                        DFS(i, j);
                        list.Add(size);
                    }
                }
            }

            list.Sort();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < area - 1; i++)
            {
                sb.Append(list[i] + " ");
            }
            sb.Append(list[area - 1]);

            Console.WriteLine(area);
            Console.WriteLine(sb.ToString());
        }
    }
}
