using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1912
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[n+1];
            int[] nums = new int[n + 1];

            string[] read = Console.ReadLine().Split(" ");

            for(int i=1; i<=read.Length; i++)
            {
                nums[i] = int.Parse(read[i - 1]);
            }

            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                if(dp[i-1] < 0)
                {
                    dp[i] = nums[i];
                }
                else
                {
                    dp[i] = dp[i - 1] + nums[i];
                }
            }

            int max = -1001;

            for(int i=1; i<=n; i++)
            {
                if(dp[i] > max)
                {
                    max = dp[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
