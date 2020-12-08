using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1085
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ");
            int x = int.Parse(data[0]);
            int y = int.Parse(data[1]);
            int w = int.Parse(data[2]);
            int h = int.Parse(data[3]);

            int horiz, vert, result;

            horiz = (w - x) >= x ? x : w - x;
            vert = (h - y) >= y ? y : h - y;

            result = horiz >= vert ? vert : horiz;

            Console.WriteLine(result);
        }
    }
}
