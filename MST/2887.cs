using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2887
    {
        struct Point
        {
            public int x, y, z, num;

            public Point(int x, int y, int z, int num)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.num = num;
            }
        }

        struct Edge
        {
            public int start, end, dist;

            public Edge(int s, int e, int d)
            {
                start = s;
                end = e;
                dist = d;
            }
        }

        static void Union(int a, int b)
        {
            int root1 = Find(a);
            int root2 = Find(b);

            if (root1 != root2)
            {
                parent[root1] = root2;
            }
        }

        static int Find(int a)
        {
            if (parent[a] == a)
            {
                return a;
            }

            return parent[a] = Find(parent[a]);
        }

        static int[] parent;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            List<Point> vertex_List = new List<Point>();
            List<Edge> edge_List = new List<Edge>();

            for (int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                vertex_List.Add(new Point(int.Parse(read[0]), int.Parse(read[1]), int.Parse(read[2]), i + 1));
            }

            vertex_List.Sort((x1, x2) => x1.x.CompareTo(x2.x));
            for(int i=0; i<n-1; i++)
            {
                int dist = Math.Abs(vertex_List[i].x - vertex_List[i + 1].x);

                edge_List.Add(new Edge(vertex_List[i].num, vertex_List[i + 1].num, dist));
            }

            vertex_List.Sort((x1, x2) => x1.y.CompareTo(x2.y));
            for (int i = 0; i < n - 1; i++)
            {
                int dist = Math.Abs(vertex_List[i].y - vertex_List[i + 1].y);

                edge_List.Add(new Edge(vertex_List[i].num, vertex_List[i + 1].num, dist));
            }

            vertex_List.Sort((x1, x2) => x1.z.CompareTo(x2.z));
            for (int i = 0; i < n - 1; i++)
            {
                int dist = Math.Abs(vertex_List[i].z - vertex_List[i + 1].z);

                edge_List.Add(new Edge(vertex_List[i].num, vertex_List[i + 1].num, dist));
            }

            parent = new int[n + 1];
            for(int i=0; i<=n; i++)
            {
                parent[i] = i;
            }

            edge_List.Sort((x1, x2) => x1.dist.CompareTo(x2.dist));

            int ans = 0;
            int cnt = 0;
            int iter = 0;

            while(cnt < n-1)
            {
                Edge temp = edge_List[iter];

                if(Find(temp.start) != Find(temp.end))
                {
                    Union(temp.start, temp.end);
                    ans += temp.dist;
                    cnt++;
                }

                iter++;
            }

            Console.WriteLine(ans);
        }
    }
}
