﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11727
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int[] dp = new int[1001];
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 3;
            dp[3] = 5;

            for (int i = 4; i <= num; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2] * 2;
                dp[i] %= 10007;
            }

            Console.WriteLine(dp[num]);
        }
    }
}
