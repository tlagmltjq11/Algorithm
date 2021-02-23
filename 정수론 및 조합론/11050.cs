using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _11050
    {
        static int[,] dp = new int[100, 100];

        static int nCk(int n, int k)
        {
            if (dp[n, k] > 0) //메모이제이션
            {
                return dp[n, k];
            }
            else if (k == 0 || k == n) //안뽑거나, 모두 뽑는 경우는 1
            {
                return dp[n,k] = 1;
            }
            else if ((0 < k) && (k < n))
            {
                return dp[n,k] = nCk(n - 1, k - 1) + nCk(n - 1, k); //저장 + 재귀
            }
            else
            {
                return 0;
            }
        }

        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            int n1 = int.Parse(read[0]);
            int n2 = int.Parse(read[1]);

            int result = nCk(n1, n2);

            Console.WriteLine(result);
        }
    }
    */
}
