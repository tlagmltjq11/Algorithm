using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11444
    {
        static long[,] Multi(long[,] a, long[,] b)
        {
            long[,] result = new long[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    long temp = 0;

                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }

                    result[i, j] = temp % 1000000007;
                }
            }

            return result;
        }

        static int Main()
        {
            long n = int.Parse(Console.ReadLine());

            if(n<=1)
            {
                Console.WriteLine(n);
                return 0;
            }

            long[,] ans = { { 1, 0 }, { 0, 1 } };
            long[,] a = { { 1, 1 }, { 1, 0 } };

            while(n > 0)
            {
                if(n%2 == 1)
                {
                    ans = Multi(ans, a);
                }

                a = Multi(a, a);
                n /= 2;
            }

            Console.WriteLine(ans[0, 1]);

            return 0;
        }
    }
}
