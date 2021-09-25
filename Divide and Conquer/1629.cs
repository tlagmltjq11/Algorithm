using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1629
    {
        static long Divide(long a, long b, long c)
        {
            if(b == 0)
            {
                return 1;
            }

            long n = Divide(a, b / 2, c);
            long temp = n * n % c;

            if(b % 2 == 0)
            {
                return temp;
            }
            else
            {
                return a * temp % c;
            }
        }

        static void Main()
        {
            long a, b, c;
            string[] read = Console.ReadLine().Split(" ");

            a = int.Parse(read[0]);
            b = int.Parse(read[1]);
            c = int.Parse(read[2]);

            long result = Divide(a, b, c);

            Console.WriteLine(result);
        }
    }
}
