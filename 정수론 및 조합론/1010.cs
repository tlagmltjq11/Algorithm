using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _1010
    {
        static double[] dp = new double[100];

        static double facto(int n)
        {
            if(dp[n] > 0)
            {
                return dp[n];
            }

            if(n <= 1)
            {
                return 1;
            }
            else
            {
                return dp[n] = n * facto(n - 1);
            }
        }

        static double mCn(int m, int n)
        {
            return facto(m) / (facto(n) * facto(m - n));
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            for(int i=0; i<N; i++)
            {
                string[] read = Console.ReadLine().Split(" ");
                int n = int.Parse(read[0]);
                int m = int.Parse(read[1]);

                double result = Math.Round(mCn(m, n), 1);
                sb.AppendLine(result.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
