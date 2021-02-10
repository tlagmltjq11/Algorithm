using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1904
    {
        //각 갯수들은 결국 피보나치와 같은 규칙으로 이루어짐.
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] dp = new int[1000001];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;

            for(int i=3; i<=n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
                dp[i] = dp[i] % 15746;
            }

            Console.WriteLine(dp[n]);
        }
    }
}
