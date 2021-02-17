using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _11054
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), s => int.Parse(s));
            int[] DP = new int[1000];
            int[] R_DP = new int[1000];

            DP[0] = 1;
            for (int i = 0; i < N; i++)
            {
                DP[i] = 1;
                for (int j = 0; j <= i; j++)
                {
                    if (nums[j] < nums[i] && DP[i] < DP[j] + 1)
                    {
                        DP[i] = DP[j] + 1;
                    }
                }
            }

            for (int i = N - 1; i >= 0; i--)
            {
                R_DP[i] = 1;
                for (int j = N - 1; j >= i; j--)
                {
                    if (nums[i] > nums[j] && R_DP[j] + 1 > R_DP[i])
                    {
                        R_DP[i] = R_DP[j] + 1;
                    }
                }
            }

            int answer = 0;
            for (int i = 0; i < N; i++)
            {
                if (answer < DP[i] + R_DP[i] - 1) answer = DP[i] + R_DP[i] - 1;
            }


            Console.WriteLine(answer);
        }
    }
}
