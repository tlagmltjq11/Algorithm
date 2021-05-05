using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class N개의_최소공배수
    {
        static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        static int lcm(int a, int b)
        {
            return a * b / gcd(a, b);
        }

        static int solution(int[] arr)
        {
            int answer = arr[0];

            for(int i=1; i<arr.Length; i++)
            {
                answer = lcm(answer, arr[i]);
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[] { 2, 6, 8, 14 }));
        }
    }
}
