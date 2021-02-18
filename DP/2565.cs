using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2565
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] dp = new int[101];

            for(int i=0; i<n; i++)
            {
                string[] read = Console.ReadLine().Split(" ");

                a[i] = int.Parse(read[0]);
                b[i] = int.Parse(read[1]);
            }

            Array.Sort(a, b); //a를 기준으로 b까지 함께 정렬

            dp[0] = 1;

            for (int i = 0; i < n; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    //현재 값보다 큰 경우는 증가수열에 포함되지 않으므로 검사할 필요가 없다.
                    if (b[i] > b[j])
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

            Console.WriteLine(n - result);
        }
    }
}
