using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _3036
    {
        // 최대공약수 (Greatest Common Divisor)
        static int gcd(int x, int y)
        {
            // 유클리드 (x를 y로 나눈 나머지가 0보다 클때까지 반복) 
            while (y > 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }

            return x;
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] rads = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));

            for(int i = 1; i<n; i++)
            {
                int GCD = gcd(rads[0], rads[i]);

                sb.AppendLine(rads[0] / GCD + "/" + rads[i] / GCD);
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
