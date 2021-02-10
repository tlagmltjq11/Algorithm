using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1003
    {
        static int[] d = new int[41];

        //top down 방식의 DP
        static int fibonacci(int n)
        {
            if(n < 0)
            {
                return 1;
            }

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                if (d[n] > 0)
                {
                    return d[n];
                }

                d[n] = fibonacci(n - 1) + fibonacci(n - 2);
                return d[n];
            }
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int one, zero = 0;

            for (int i=0; i<N; i++)
            {
                int fibo = int.Parse(Console.ReadLine());

                //n번째 피보나치수와 1의 호출 수는 동일하며
                //n번째 피보나치수를 구할때 호출되는 0의 수는
                //n-1번째 피보나치수와 동일하다는 규칙을 이용.
                one = fibonacci(fibo);
                zero = fibonacci(fibo - 1);

                sb.Append(zero.ToString() + " " + one.ToString());
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
