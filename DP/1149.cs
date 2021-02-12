using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1149
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int R, G, B, r, g, b;
            r = g = b = 0;

            for (int i = 0; i < N; ++i)
            {
                string[] inputs = Console.ReadLine().Split();
                R = int.Parse(inputs[0]);
                G = int.Parse(inputs[1]);
                B = int.Parse(inputs[2]);

                //현재까지 진행된 값을 계속해서 누적하는것이 포인트
                R += Math.Min(g, b);
                G += Math.Min(r, b);
                B += Math.Min(r, g);

                r = R;
                g = G;
                b = B;
            }
            Console.Write(Math.Min(Math.Min(r, g), b));
        }
    }
}