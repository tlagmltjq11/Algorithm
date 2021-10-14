using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _9095
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int[] dp = new int[11];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;

            for(int i=4; i<=10; i++)
            {
                dp[i] = dp[i - 3] + dp[i - 2] + dp[i - 1];
            }

            StringBuilder sb = new StringBuilder();
            for(int i=0; i<t; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sb.AppendLine(dp[num].ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
