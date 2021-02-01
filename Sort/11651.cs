using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class sorter : IComparer<Point>
    {
        int IComparer<Point>.Compare(Point a, Point b)
        {
            if (a.y > b.y)
            {
                return 1;
            }
            else if (a.y < b.y)
            {
                return -1;
            }
            else
            {
                if (a.x > b.x)
                {
                    return 1;
                }
                else if (a.x < b.x)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

    class _11651
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            List<Point> points = new List<Point>();
            int n = int.Parse(Console.ReadLine());
            string[] inputs;
            Point point;

            for (int i = 0; i < n; i++)
            {
                inputs = Console.ReadLine().Split(" ");

                // C#에서 new는 생성자를 호출한다는 의미이다.
                // value type에서 생성자는 필드를 초기화 해준다는 의미이지, 힙에 메모리 할당과 무관하다
                point = new Point(int.Parse(inputs[0]), int.Parse(inputs[1]));
                points.Add(point);
            }

            points.Sort(new sorter());

            for (int i = 0; i < points.Count; i++)
            {
                sb.AppendLine(points[i].x + " " + points[i].y);
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}