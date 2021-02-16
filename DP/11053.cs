using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11053
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));
            int[] dp = new int[n];

            dp[0] = 1;

            for (int i = 0; i < n; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    //현재 값보다 큰 경우는 증가수열에 포함되지 않으므로 검사할 필요가 없다.
                    if (nums[i] > nums[j])
                    {
                        max = Math.Max(max, dp[j]); //제일 긴 수열값을 찾는다.
                    }
                }
                dp[i] = max + 1; //제일 긴 수열에 자신을 포함시켜 저장한다.
            }

            int result = -1;
            for (int i = 0; i < n; i++)
            {
                result = Math.Max(dp[i], result);
            }

            Console.WriteLine(result);
        }
    }
}
