using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 땅따먹기
    {
        static int solution(int[,] land)
        {
            int answer = 0;

            int[,] dp = new int[land.GetLength(0), 4];

            for(int i=0; i<land.GetLength(0); i++)
            {
                for(int j=0; j<4; j++)
                {
                    dp[i, j] = land[i, j];
                }
            }

            for(int i=1; i<land.GetLength(0); i++)
            {
                for(int j=0; j<4; j++)
                {
                    for(int k=0; k<4; k++)
                    {
                        if(j != k)
                        {
                            dp[i, j] = Math.Max(dp[i, j], land[i, j] + dp[i - 1, k]); 
                        }
                    }
                }
            }

            for(int i=0; i<4; i++)
            {
                answer = Math.Max(answer, dp[land.GetLength(0) - 1, i]);
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(new int[,] { { 1, 2, 3, 5 }, { 5, 6, 7, 8 }, { 4, 3, 2, 1 } }));
        }
    }
}
