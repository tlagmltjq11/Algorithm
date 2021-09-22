using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _10026
    {
        static char[,] grid;
        static int n;
        static bool[,] visited;

        static void DFS(int x, int y, bool flag)
        {
            if ((x + 1) < n && !visited[x + 1, y])
            {
                if (!flag || grid[x, y].Equals('B'))
                {
                    if (grid[x + 1, y].Equals(grid[x, y]))
                    {
                        visited[x + 1, y] = true;
                        DFS(x + 1, y, flag);
                    }
                }
                else
                {
                    if (grid[x + 1, y].Equals('R') || grid[x + 1, y].Equals('G'))
                    {
                        visited[x + 1, y] = true;
                        DFS(x + 1, y, flag);
                    }
                }
            }

            if ((x - 1) >= 0 && !visited[x - 1, y])
            {
                if (!flag || grid[x, y].Equals('B'))
                {
                    if (grid[x - 1, y].Equals(grid[x, y]))
                    {
                        visited[x - 1, y] = true;
                        DFS(x - 1, y, flag);
                    }
                }
                else
                {
                    if (grid[x - 1, y].Equals('R') || grid[x - 1, y].Equals('G'))
                    {
                        visited[x - 1, y] = true;
                        DFS(x - 1, y, flag);
                    }
                }
            }

            if ((y + 1) < n && !visited[x, y + 1])
            {
                if (!flag || grid[x, y].Equals('B'))
                {
                    if (grid[x, y + 1].Equals(grid[x, y]))
                    {
                        visited[x, y + 1] = true;
                        DFS(x, y + 1, flag);
                    }
                }
                else
                {
                    if (grid[x, y + 1].Equals('R') || grid[x, y + 1].Equals('G'))
                    {
                        visited[x, y + 1] = true;
                        DFS(x, y + 1, flag);
                    }
                }
            }

            if ((y - 1) >= 0 && !visited[x, y - 1])
            {
                if (!flag || grid[x, y].Equals('B'))
                {
                    if (grid[x, y - 1].Equals(grid[x, y]))
                    {
                        visited[x, y - 1] = true;
                        DFS(x, y - 1, flag);
                    }
                }
                else
                {
                    if (grid[x, y - 1].Equals('R') || grid[x, y - 1].Equals('G'))
                    {
                        visited[x, y - 1] = true;
                        DFS(x, y - 1, flag);
                    }
                }
            }
        }

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            grid = new char[n, n];
            for(int i=0; i<n; i++)
            {
                string temp = Console.ReadLine();
                for(int j=0; j<n; j++)
                {
                    grid[i, j] = temp[j];
                }
            }

            string answer = string.Empty;
            visited = new bool[n, n];
            int areas = 0;

            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!visited[i, j])
                    {
                        DFS(i, j, false);
                        areas++;
                    }
                }
            }
            answer += areas.ToString();

            visited = new bool[n, n];
            areas = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!visited[i, j])
                    {
                        DFS(i, j, true);
                        areas++;
                    }
                }
            }
            answer += " " + areas.ToString();

            Console.WriteLine(answer);
        }
    }
}
