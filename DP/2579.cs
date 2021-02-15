using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2579
    {
        static void Main()
        {
            int[] stairs = new int[300];
            int[] dp = new int[300];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int read = int.Parse(Console.ReadLine());
                stairs[i] = read;
            }

            dp[0] = stairs[0];
            dp[1] = Math.Max(stairs[0] + stairs[1], stairs[1]);
            dp[2] = Math.Max(stairs[0] + stairs[2], stairs[1] + stairs[2]);

            for (int i = 3; i < n; i++)
            {
                dp[i] = Math.Max(stairs[i] + stairs[i - 1] + dp[i - 3], stairs[i] + dp[i - 2]);
            }

            Console.WriteLine(dp[n-1]);
        }
    }
}
