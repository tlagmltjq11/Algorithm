using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 카카오프렌즈_컬러링북
    {
        struct Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static int[] solution(int m, int n, int[,] picture)
        {
            int numberOfArea = 0;
            int maxSizeOfOneArea = 0;

            bool[,] visited = new bool[m, n];

            Stack<Point> stack = new Stack<Point>();

            for(int i=0; i<m; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(picture[i, j] != 0 && visited[i, j] != true)
                    {
                        numberOfArea++;
                        stack.Push(new Point(i, j));
                        visited[i, j] = true;

                        int cnt = 1;

                        while(stack.Count != 0)
                        {
                            Point temp = stack.Pop();
                            int x = temp.x;
                            int y = temp.y;

                            if(visited[x,y] == false)
                            {
                                visited[x, y] = true;
                                cnt++;
                            }

                            if(x - 1 >= 0 && !visited[x - 1, y] && picture[x - 1, y] == picture[i, j])
                            {
                                stack.Push(new Point(x - 1, y));
                            }

                            if (x + 1 < m && !visited[x + 1, y] && picture[x + 1, y] == picture[i, j])
                            {
                                stack.Push(new Point(x + 1, y));
                            }

                            if (y - 1 >= 0 && !visited[x, y - 1] && picture[x, y - 1] == picture[i, j])
                            {
                                stack.Push(new Point(x, y - 1));
                            }

                            if (y + 1 < n && !visited[x, y + 1] && picture[x, y + 1] == picture[i, j])
                            {
                                stack.Push(new Point(x, y + 1));
                            }
                        }

                        maxSizeOfOneArea = Math.Max(maxSizeOfOneArea, cnt);
                    }
                }
            }

            int[] answer = new int[2];
            answer[0] = numberOfArea;
            answer[1] = maxSizeOfOneArea;
            return answer;
        }

        static void Main()
        {
            int[] answer = solution(6, 4, new int[,] { { 1, 1, 1, 0 }, { 1, 1, 1, 0 }, { 0, 0, 0, 1 }, { 0, 0, 0, 1 }, { 0, 0, 0, 1 }, { 0, 0, 0, 1 } });

            Console.WriteLine(answer[0].ToString());
            Console.WriteLine(answer[1].ToString());
        }
    }
}
