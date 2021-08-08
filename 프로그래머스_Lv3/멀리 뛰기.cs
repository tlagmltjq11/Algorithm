﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 멀리_뛰기
    {
        static long solution(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int[] dp = new int[n + 1];

            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
                dp[i] = (dp[i - 1] + dp[i - 2]) % 1234567;
            return dp[n];
        }

        static void Main()
        {
            Console.Write(solution(4));
        }
    }
}
