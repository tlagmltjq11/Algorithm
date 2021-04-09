using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _7569
    {
        struct coord
        {
            public int x;
            public int y;
            public int z;

            public coord(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        static int[,,] mat;
        static List<coord> list = new List<coord>();
        static int h, n, m;

        static int BFS()
        {
            Queue<coord> q = new Queue<coord>();

            for (int i = 0; i < list.Count; i++)
            {
                q.Enqueue(list[i]);
            }

            int day = 0;

            while (q.Count != 0)
            {
                coord temp = q.Dequeue();

                int i = temp.x;
                int j = temp.y;
                int k = temp.z;

                if ((i - 1) >= 0 && mat[i - 1, j, k] == 0)
                {
                    mat[i - 1, j, k] = mat[i, j, k] + 1;
                    q.Enqueue(new coord(i - 1, j, k));
                }

                if ((i + 1) < h && mat[i + 1, j, k] == 0)
                {
                    mat[i + 1, j, k] = mat[i, j , k] + 1;
                    q.Enqueue(new coord(i + 1, j, k));
                }

                if ((j - 1) >= 0 && mat[i, j - 1, k] == 0)
                {
                    mat[i, j - 1, k] = mat[i, j, k] + 1;
                    q.Enqueue(new coord(i, j - 1, k));
                }

                if ((j + 1) < n && mat[i, j + 1, k] == 0)
                {
                    mat[i, j + 1, k] = mat[i, j, k] + 1;
                    q.Enqueue(new coord(i, j + 1, k));
                }


                if ((k - 1) >= 0 && mat[i, j, k - 1] == 0)
                {
                    mat[i, j, k - 1] = mat[i, j, k] + 1;
                    q.Enqueue(new coord(i, j, k - 1));
                }

                if ((k + 1) < m && mat[i, j, k + 1] == 0)
                {
                    mat[i, j, k + 1] = mat[i, j, k] + 1;
                    q.Enqueue(new coord(i, j, k + 1));
                }
            }


            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        if (mat[i, j, k] == 0)
                        {
                            return -1;
                        }

                        if(day < mat[i, j, k])
                        {
                            day = mat[i, j, k];
                        }
                    }
                }
            }

            return day - 1;
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");

            n = int.Parse(read[1]);
            m = int.Parse(read[0]);
            h = int.Parse(read[2]);

            mat = new int[h, n, m];

            for(int i=0; i<h; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    read = Console.ReadLine().Split(" ");

                    for (int k = 0; k < m; k++)
                    {
                        int temp = int.Parse(read[k]);
                        mat[i, j, k] = temp;

                        if(temp == 1)
                        {
                            list.Add(new coord(i, j, k));
                        }
                    }
                }
            }

            Console.WriteLine(BFS());
        }
    }
}
