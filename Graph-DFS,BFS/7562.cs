using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _7562
    {
        static int length;
        static int goal_x;
        static int goal_y;

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


        static int BFS(int x, int y)
        {
            Queue<coordi> q = new Queue<coordi>();
            q.Enqueue(new coordi(x, y, 0));

            visited[x, y] = true;

            while(q.Count != 0)
            {
                coordi temp = q.Dequeue();

                if(temp.x == goal_x && temp.y == goal_y)
                {
                    return temp.dist;
                }

                if((temp.x - 1) >= 0 && (temp.y - 2) >= 0 && visited[temp.x - 1, temp.y - 2] == false)
                {
                    visited[temp.x - 1, temp.y - 2] = true;
                    q.Enqueue(new coordi(temp.x - 1, temp.y - 2, temp.dist + 1));
                }

                if ((temp.x - 2) >= 0 && (temp.y - 1) >= 0 && visited[temp.x - 2, temp.y - 1] == false)
                {
                    visited[temp.x - 2, temp.y - 1] = true;
                    q.Enqueue(new coordi(temp.x - 2, temp.y - 1, temp.dist + 1));
                }

                if ((temp.x - 2) >= 0 && (temp.y + 1) < length && visited[temp.x - 2, temp.y + 1] == false)
                {
                    visited[temp.x - 2, temp.y + 1] = true;
                    q.Enqueue(new coordi(temp.x - 2, temp.y + 1, temp.dist + 1));
                }

                if ((temp.x - 1) >= 0 && (temp.y + 2) < length && visited[temp.x - 1, temp.y + 2] == false)
                {
                    visited[temp.x - 1, temp.y + 2] = true;
                    q.Enqueue(new coordi(temp.x - 1, temp.y + 2, temp.dist + 1));
                }

                if ((temp.x + 1) < length && (temp.y - 2) >= 0 && visited[temp.x + 1, temp.y - 2] == false)
                {
                    visited[temp.x + 1, temp.y - 2] = true;
                    q.Enqueue(new coordi(temp.x + 1, temp.y - 2, temp.dist + 1));
                }

                if ((temp.x + 2) < length && (temp.y - 1) >= 0 && visited[temp.x + 2, temp.y - 1] == false)
                {
                    visited[temp.x + 2, temp.y - 1] = true;
                    q.Enqueue(new coordi(temp.x + 2, temp.y - 1, temp.dist + 1));
                }

                if ((temp.x + 2) < length && (temp.y + 1) < length && visited[temp.x + 2, temp.y + 1] == false)
                {
                    visited[temp.x + 2, temp.y + 1] = true;
                    q.Enqueue(new coordi(temp.x + 2, temp.y + 1, temp.dist + 1));
                }

                if ((temp.x + 1) < length && (temp.y + 2) < length && visited[temp.x + 1, temp.y + 2] == false)
                {
                    visited[temp.x + 1, temp.y + 2] = true;
                    q.Enqueue(new coordi(temp.x + 1, temp.y + 2, temp.dist + 1));
                }
            }

            return -1;
        }

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for(int i=0; i<t; i++)
            {
                length = int.Parse(Console.ReadLine());

                visited = new bool[length, length];

                string[] read = Console.ReadLine().Split(" ");
                int night_x = int.Parse(read[0]);
                int night_y = int.Parse(read[1]);

                read = Console.ReadLine().Split(" ");
                goal_x = int.Parse(read[0]);
                goal_y = int.Parse(read[1]);

                sb.AppendLine(BFS(night_x, night_y).ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
