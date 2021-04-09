using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2206
    {
        static int[,] mat;
        static bool[,,] visited;
        static int n, m;
        static int[] dx = { 1, -1, 0, 0 }, dy = { 0, 0, 1, -1 };

        struct pos
        {
            // x좌표, y좌표, 지금까지 거리, 벽을 부순 횟수
            public int x, y, d, k;

            public pos(int x, int y, int d, int k)
            {
                this.x = x;
                this.y = y;
                this.d = d;
                this.k = k;
            }
        }

        static int BFS()
        {
            Queue<pos> q = new Queue<pos>();
            q.Enqueue(new pos(0, 0, 1, 0));

            while (q.Count != 0)
            {
                pos temp = q.Dequeue();

                if(temp.x == n-1 && temp.y == m-1)
                {
                    return temp.d;
                }

                for (int d = 0; d < 4; d++)
                {
                    int xx = temp.x + dx[d];
                    int yy = temp.y + dy[d];

                    if (xx < 0 || yy < 0 || xx >= n || yy >= m) continue;

                    if(mat[xx, yy] == 0)
                    {
                        //이미 방문한 길인 경우 pass
                        if (visited[xx, yy, temp.k]) continue;

                        q.Enqueue(new pos(xx, yy, temp.d + 1, temp.k));
                        visited[xx, yy, temp.k] = true;
                    }
                    else
                    {
                        // 벽을 부술 수 없거나, 이미 왔던 길일 경우 pass
                        if (temp.k != 0 || visited[xx, yy, temp.k + 1]) continue;
                        // 벽을 부술 수 있다면 부수고 이동 
                        q.Enqueue(new pos(xx, yy, temp.d + 1, temp.k + 1));
                        visited[xx, yy, temp.k + 1] = true;
                    }

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
            visited = new bool[n, m, 2];

            for(int i=0; i<n; i++)
            {
                string num = Console.ReadLine();

                for(int j=0; j<m; j++)
                {
                    mat[i, j] = (int)char.GetNumericValue(num[j]);
                }
            }

            Console.WriteLine(BFS());
        }
    }
}
