using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1774
    {
        struct Point
        {
            public int x, y, num;
            
            public Point(int x, int y, int num)
            {
                this.x = x;
                this.y = y;
                this.num = num;
            }
        }

        struct Edge
        {
            public int start, end;
            public double dist;

            public Edge(int s, int e, double d)
            {
                start = s;
                end = e;
                dist = d;
            }
        }

        static double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        static void Union(int a, int b)
        {
            int root1 = Find(a);
            int root2 = Find(b);

            if(root1 != root2)
            {
                parents[root1] = root2;
            }
        }

        static int Find(int a)
        {
            if(parents[a] == a)
            {
                return a;
            }

            return parents[a] = Find(parents[a]);
        }

        static int[] parents;

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");

            int n = int.Parse(read[0]);
            int m = int.Parse(read[1]);

            parents = new int[n+1];
            for(int i=0; i<=n; i++)
            {
                parents[i] = i;
            }

            List<Point> vertex_List = new List<Point>();
            List<Edge> edge_List = new List<Edge>();

            for(int i=0; i<n; i++)
            {
                read = Console.ReadLine().Split(" ");

                vertex_List.Add(new Point(int.Parse(read[0]), int.Parse(read[1]), i + 1));
            }

            for(int i=0; i<m; i++)
            {
                read = Console.ReadLine().Split(" ");
                Union(int.Parse(read[0]), int.Parse(read[1]));
            }

            for(int i=0; i<n; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    edge_List.Add(new Edge(vertex_List[i].num, vertex_List[j].num, GetDistance(vertex_List[i], vertex_List[j])));
                }
            }

            edge_List.Sort((x1, x2) => x1.dist.CompareTo(x2.dist));

            double answer = 0;
            for(int i=0; i<edge_List.Count; i++)
            {
                Edge temp = edge_List[i];

                int root1 = Find(temp.start);
                int root2 = Find(temp.end);

                if(root1 != root2)
                {
                    Union(temp.start, temp.end);
                    answer += temp.dist;
                }
            }

            Console.WriteLine(answer.ToString("F2"));
        }
    }
}
