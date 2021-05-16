using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 게임_맵_최단거리
    {
        static bool[,] visited;

        struct coordi
        {
            public int x, y, dist;

            public coordi(int x, int y, int dist)
            {
                this.x = x;
                this.y = y;
                this.dist = dist;
            }
        }

        static int BFS(int[,] maps)
        {
            Queue<coordi> q = new Queue<coordi>();
            visited[0, 0] = true;
            q.Enqueue(new coordi(0, 0, 1));

            while(q.Count != 0)
            {
                coordi cur = q.Dequeue();
                visited[cur.x, cur.y] = true;

                if(cur.x == maps.GetLength(0)-1 && cur.y == maps.GetLength(1) - 1)
                {
                    return cur.dist;
                }

                if(cur.x - 1 >= 0)
                {
                    if(!visited[cur.x - 1, cur.y] && maps[cur.x - 1, cur.y] == 1)
                    {
                        visited[cur.x - 1, cur.y] = true;
                        q.Enqueue(new coordi(cur.x - 1, cur.y, cur.dist + 1));
                    }
                }

                if (cur.x + 1 < maps.GetLength(0))
                {
                    if (!visited[cur.x + 1, cur.y] && maps[cur.x + 1, cur.y] == 1)
                    {
                        visited[cur.x + 1, cur.y] = true;
                        q.Enqueue(new coordi(cur.x + 1, cur.y, cur.dist + 1));
                    }
                }

                if (cur.y - 1 >= 0)
                {
                    if (!visited[cur.x, cur.y - 1] && maps[cur.x, cur.y - 1] == 1)
                    {
                        visited[cur.x, cur.y - 1] = true;
                        q.Enqueue(new coordi(cur.x, cur.y - 1, cur.dist + 1));
                    }
                }

                if (cur.y + 1 < maps.GetLength(1) && maps[cur.x, cur.y + 1] == 1)
                {
                    if (!visited[cur.x, cur.y + 1])
                    {
                        visited[cur.x, cur.y + 1] = true;
                        q.Enqueue(new coordi(cur.x, cur.y + 1, cur.dist + 1));
                    }
                }
            }

            return -1;
        }

        static int solution(int[,] maps)
        {
            int answer = 0;

            visited = new bool[maps.GetLength(0), maps.GetLength(1)];
            answer = BFS(maps);

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[,] { { 1, 0, 1, 1, 1 },{ 1, 0, 1, 0, 1 },{ 1, 0, 1, 1, 1 },{ 1, 1, 1, 0, 1 },{ 0, 0, 0, 0, 1 } }));
        }
    }
}
