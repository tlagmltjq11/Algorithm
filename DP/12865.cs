using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _12865
    {
        static int[] W = new int[100];
        static int[] V = new int[100];
        static int n, k;
        static int[,] dp = new int[101, 100001];

        static int go(int i, int w)
        {
            if(dp[i, w] > 0)
            {
                return dp[i, w];
            }

            if(i == n)
            {
                return 0;
            }

            int n1 = 0;
            if(w + W[i] <= k)
            {
                n1 = V[i] + go(i + 1, w + W[i]); //해당 물품 포함
            }

            int n2 = go(i + 1, w); //미포함

            return dp[i, w] = Math.Max(n1, n2);
        }

        static void Main()
        {
            //물품의 수, 준서가 버틸 수 있는 무게 입력
            string[] read = Console.ReadLine().Split(" ");
            n = int.Parse(read[0]);
            k = int.Parse(read[1]);

            //각 물품마다 무게와 가치 입력
            for(int i=0; i<n; i++)
            {
                read = Console.ReadLine().Split(" ");
                W[i] = int.Parse(read[0]);
                V[i] = int.Parse(read[1]);
            }

            Console.WriteLine(go(0,0));
        }
    }
}
