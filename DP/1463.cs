using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _1463
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] dp = new int[N + 1];

            dp[0] = dp[1] = 0;

            for(int i=2; i<=N; i++)
            {
                // N값에 -1을 한 경우에 대해서 최소값을 dp로 구한다.
                dp[i] = dp[i - 1] + 1;

                // N값에 /2가 가능하다면 해당 경우에 대해서 최소값을 dp로 구한다.
                if (i % 2 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                }

                // N값에 /3이 가능하다면 해당 경우에 대해서 최소값을 dp로 구한다.
                if (i % 3 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                }

                //최종적으로 -1, /2, /3 각 결과중 가장 최소값이 저장되게 된다.
            }

            Console.WriteLine(dp[N]);
        }
    }
    */
}
