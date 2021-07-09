using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 거리두기_확인하기
    {
        static string[,] map;
        static int a = 0;
        //사람이면 안되는 곳
        static int[] x1 = { 1, -1, 0, 0 };
        static int[] y1 = { 0, 0, -1, 1 };
        //사람일 수는 있지만 두 곳에 파티션이 필요한 곳
        static int[] x2 = { -1, -1, 1, 1 };
        static int[] y2 = { -1, 1, -1, 1 };
        //사람일 수는 있지만 한 곳에 파티션이 필요한 곳
        static int[] x3 = { -2, 2, 0, 0 };
        static int[] y3 = { 0, 0, -2, 2 };
        static int answer;
        static int[] solution(string[,] places)
        {
            answer = 1;
            int[] ans = new int[places.GetLength(0)];
            map = places;

            for (a = 0; a < places.GetLength(0); a++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (places[a, i][j] == 'P')
                        {
                            dfs(i, j);
                        }
                    }
                }
                if (answer == 0)
                {
                    ans[a] = answer;
                }
                else
                {
                    ans[a] = answer;
                }
                answer = 1;
            }

            return ans;
        }
        static void dfs(int x, int y)
        {
            for (int i = 0; i < 4; i++)
            {
                int nx = x + x1[i];
                int ny = y + y1[i];

                if (nx < 0 || ny < 0 || nx >= 5 || ny >= 5) continue;
                if (map[a, nx][ny] == 'P') answer = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                int nx = x + x2[i];
                int ny = y + y2[i];

                if (nx < 0 || ny < 0 || nx >= 5 || ny >= 5) continue;
                if (map[a, nx][ny] == 'P') check1(x, y, nx, ny);
            }

            for (int i = 0; i < 4; i++)
            {
                int nx = x + x3[i];
                int ny = y + y3[i];

                if (nx < 0 || ny < 0 || nx >= 5 || ny >= 5) continue;
                if (map[a, nx][ny] == 'P') check2(x, y, nx, ny);
            }
        }

        static void check1(int x, int y, int nx, int ny)
        {
            int newX = x - nx;
            int newY = y - ny;

            if (newX == 1 && newY == 1)
            {
                if (map[a, x-1][y] != 'X' || map[a, x][y - 1] != 'X') answer = 0;
            }
            else if (newX == 1 && newY == -1)
            {
                if (map[a, x - 1][y] != 'X' || map[a, x][y+1] != 'X') answer = 0;
            }
            else if (newX == -1 && newY == 1)
            {
                if (map[a, x][y - 1] != 'X' || map[a, x+1][y] != 'X') answer = 0;
            }
            else
            {
                if (map[a, x][y + 1] != 'X' || map[a, x + 1][y] != 'X') answer = 0;
            }
        }
        static void check2(int x, int y, int nx, int ny)
        {
            int newX = x - nx;
            int newY = y - ny;

            if (newX == -2 && newY == 0)
            {
                if (map[a, x + 1][y] != 'X') answer = 0;
            }
            else if (newX == 2 && newY == 0)
            {
                if (map[a, x - 1][y] != 'X') answer = 0;
            }
            else if (newX == 0 && newY == -2)
            {
                if (map[a, x][y + 1] != 'X') answer = 0;
            }
            else
            {
                if (map[a, x][y - 1] != 'X') answer = 0;
            }
        }

        static void Main()
        {
            int[] result = solution(new string[,] { { "POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP" },
                { "POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP" }, { "PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX" },
                { "OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO" }, { "PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP" } });

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}