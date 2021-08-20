using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 기지국_설치
    {
        static int solution(int n, int[] stations, int w)
        {
            int answer = 0;
            int prev = 1;
            int next;
            int counter = 2 * w + 1;
            
            for(int i=0; i<stations.Length; i++)
            {
                next = stations[i] - w;

                int cur = next - prev;
                if(cur > 0)
                {
                    if(cur % counter == 0)
                    {
                        answer += cur / counter;
                    }
                    else
                    {
                        answer += (cur / counter) + 1;
                    }
                }

                prev = stations[i] + w + 1;
            }

            if (prev < n)
            {
                int cur = n - prev;

                if (cur % counter == 0)
                {
                    answer += cur / counter;
                }
                else
                {
                    answer += (cur / counter) + 1;
                }
            }

            return answer;
        }

        static void Main()
        {
            Console.WriteLine(solution(11, new int[] { 4, 11 }, 1));
        }
    }
}
