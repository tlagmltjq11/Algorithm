using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 멀쩡한_사각형
    {
        static long gcd(long a, long b)
        {
            long temp;
            while(b > 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }

        static long solution(int w, int h)
        {
            long answer = 1;

            long gcdResult = gcd(w, h);

            answer = (long)w * (long)h - ((long)w + (long)h - gcdResult);

            return answer;
        }

        static void Main()
        {
            Console.Write(solution(8, 12));
        }
    }
}
