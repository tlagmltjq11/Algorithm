using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice.NewFolder
{
    class 순위
    {
        static int solution(int n, int[,] results)
        {
            int answer = 0;
            bool[,] graph = new bool[n + 1, n + 1];

            for(int i=0; i<results.GetLength(0); i++)
            {
                int winner = results[i, 0];
                int loser = results[i, 1];

                //그래프에 경기결과 반영
                graph[winner, loser] = true;
            }

            //플로이드 와샬 알고리즘 적용
            for (int b = 1; b <= n; b++)
            {
                for (int a = 1; a <= n; a++)
                {
                    for (int c = 1; c <= n; c++)
                    {
                        // a가 b를 이겼고 b가 c를 이겼으면, a가 c를 이겼다고 표시
                        if (graph[a,b] && graph[b,c])
                            graph[a,c] = true;
                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                int winCount = 0;
                for (int j = 1; j <= n; j++)
                {
                    if (i == j) continue;
                    // a가 b를 이겼거나 b가 a를 이긴 경우
                    // 둘다 false면 경기결과를 예측할 수 없는 것
                    if (graph[i,j] || graph[j,i])
                        winCount++;
                }

                // 모든 선수와의 경기결과를 알 수 있어 순위가 확실해지는 경우
                if (winCount == n - 1)
                    answer++;
            }

            return answer;
        }

        static void Main()
        {

        }
    }
}
