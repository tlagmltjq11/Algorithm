using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2156
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] wine = new int[n+1];
            int[] dp = new int[10001];

            for(int i=1; i<=n; i++)
            {
                wine[i] = int.Parse(Console.ReadLine());
            }

            dp[0] = 0;
            dp[1] = wine[1];

            if (n > 1)
            {
                dp[2] = dp[1] + wine[2];
            }

            if (n > 2)
            {
                for (int i = 3; i <= n; i++)
                {
                    dp[i] = Math.Max(dp[i - 3] + wine[i - 1] + wine[i], Math.Max(dp[i - 1], dp[i - 2] + wine[i]));
                }
            }

            Console.WriteLine(dp[n]);

        }
    }
}
